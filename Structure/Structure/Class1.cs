using System;

namespace Structure
{
    public struct ZPower
    {
        //Определение полей
        public double Base { get; set; }
        public int Exponent { get; set; }
        //
        public double Value
        {
            get
            {
                return Math.Pow(Base, Exponent);
            }
        }

        public bool IsPositive
        {
            get
            {
                return Value > 0;
            }
        }

        // Конструктор с параметрами для задания значений основных полей
        public ZPower(double baseValue, int exponentValue)
        {
            Base = baseValue;
            Exponent = exponentValue;
        }

        // Переопределение метода Equals для сравнения двух экземпляров структуры ZPower
        public override bool Equals(object obj)
        {
            if (obj is ZPower)
            {
                ZPower other = (ZPower)obj;
                return Base == other.Base && Exponent == other.Exponent;
            }
            return false;
        }

        // Переопределение метода GetHashCode для генерации хеш-кода
        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 31 + Base.GetHashCode();
            hash = hash * 31 + Exponent.GetHashCode();
            return hash;
        }

        // Переопределение операций == и != для сравнения двух экземпляров структуры ZPower
        public static bool operator ==(ZPower left, ZPower right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(ZPower left, ZPower right)
        {
            return !(left == right);
        }

        // Переопределение операций * и / для умножения и деления
        // двух экземпляров структуры ZPower с одинаковыми основаниями
        public static ZPower operator *(ZPower left, ZPower right)
        {
            if (left.Base == right.Base)
                return new ZPower(left.Base, left.Exponent + right.Exponent);
            else
                throw new ArgumentException("Основания должны быть одинаковыми");
        }

        public static ZPower operator /(ZPower left, ZPower right)
        {
            if (left.Base == right.Base)
                return new ZPower(left.Base, left.Exponent - right.Exponent);
            else
                throw new ArgumentException("Основания должны быть одинаковыми");
        }

        // Переопределение метода ToString для представления экземпляра структуры в виде строки
        public override string ToString()
        {
            return $"{Base}E{Exponent}";
        }
    }


}
