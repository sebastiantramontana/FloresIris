using System;
using System.Collections.Generic;
using System.Linq;

namespace IrisForm
{
    public class EnumInfo<TEnum> where TEnum : struct, Enum
    {
        public EnumInfo(string nombre, TEnum valor)
        {
            this.Nombre = nombre;
            this.Valor = valor;
        }

        public string Nombre { get; }
        public TEnum Valor { get; }

        public override bool Equals(object obj)
        {
            return this.Equals(obj as EnumInfo<TEnum>);
        }

        public bool Equals(EnumInfo<TEnum> enumInfo)
        {
            return !object.ReferenceEquals(enumInfo, null) && this.Equals(enumInfo.Valor);
        }

        public bool Equals(TEnum enumValue)
        {
            return this.Valor.GetHashCode() == enumValue.GetHashCode();
        }

        public override int GetHashCode()
        {
            return this.Valor.GetHashCode();
        }

        public override string ToString()
        {
            return this.Nombre;
        }

        public static bool operator ==(EnumInfo<TEnum> v1, EnumInfo<TEnum> v2)
        {
            return !object.ReferenceEquals(v1, null) && !object.ReferenceEquals(v2, null) && v1.Equals(v2);
        }

        public static bool operator !=(EnumInfo<TEnum> v1, EnumInfo<TEnum> v2)
        {
            return !(v1 == v2);
        }

        public static EnumInfo<TEnum> From(TEnum valor)
        {
            var type = typeof(TEnum);
            return new EnumInfo<TEnum>(Enum.GetName(type, valor), valor);
        }

        public static IEnumerable<EnumInfo<TEnum>> GetInfos()
        {
            var type = typeof(TEnum);

            var nombres = Enum.GetNames(type);
            var valores = Enum.GetValues(type);

            return nombres.Select((nom, i) => new EnumInfo<TEnum>(nom, (TEnum)valores.GetValue(i)));
        }
    }
}
