using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{

    public class Category : IComparable<Category>
    {
        public readonly string ProductName;
        public readonly MessageType MessageType;
        public readonly MessageTopic MessageTopic;

        public Category(string productName, MessageType messageType, MessageTopic messageTopic)
        {
            ProductName = productName;
            MessageType = messageType;
            MessageTopic = messageTopic;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Category other = (Category)obj;
            return ProductName == other.ProductName && MessageType == other.MessageType && MessageTopic == other.MessageTopic;
        }

        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 23 + ProductName.GetHashCode();
            hash = hash * 23 + MessageType.GetHashCode();
            hash = hash * 23 + MessageTopic.GetHashCode();
            return hash;
        }

        public int CompareTo(Category other)
        {
            int result = ProductName.CompareTo(other.ProductName);
            if (result != 0) return result;

            result = MessageType.CompareTo(other.MessageType);
            if (result != 0) return result;

            return MessageTopic.CompareTo(other.MessageTopic);
        }

        public static bool operator ==(Category left, Category right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Category left, Category right)
        {
            return !(left == right);
        }

        public static bool operator <(Category left, Category right)
        {
            return left.CompareTo(right) < 0;
        }

        public static bool operator >(Category left, Category right)
        {
            return left.CompareTo(right) > 0;
        }

        public static bool operator <=(Category left, Category right)
        {
            return left.CompareTo(right) <= 0;
        }

        public static bool operator >=(Category left, Category right)
        {
            return left.CompareTo(right) >= 0;
        }

        public override string ToString()
        {
            return $"{ProductName}.{MessageType}.{MessageTopic}";
        }
    }
}
