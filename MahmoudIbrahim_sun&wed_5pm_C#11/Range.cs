using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MahmoudIbrahim_sun_wed_5pm_C_11
{
    public class Rangee <T> where T : IComparable
    {

        public T Min { get; set; }
        public T Max { get; set; }
        public Rangee (T start, T end)
        {
            Min = start;
            Max = end;
        }

        public override string? ToString()
        {
            return $"{this.Min} - {this.Max}";
        }

        public int Length ()
        {
            return Convert.ToInt32(this.Max) - Convert.ToInt32(this.Min);
        }

        public int isInRange(T value)
        {
            int result = this.CompareTo(this);
            return result;
        }

        // implement iComparable
        public int CompareTo(object? obj)
        {
            if (obj == null) return 1;
            Rangee<T> range = obj as Rangee<T>;
            if (range != null)
            {
                if (this.Min.CompareTo(range.Min) > 0)
                {
                    return 1;
                }
                else if (this.Min.CompareTo(range.Min) < 0)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                throw new ArgumentException("Object is not within the Range !");
            }
        }
    }
}
