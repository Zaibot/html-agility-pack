// Description: Html Agility Pack - HTML Parsers, selectors, traversors, manupulators.
// Website & Documentation: http://html-agility-pack.net
// Forum & Issues: https://github.com/zzzprojects/html-agility-pack
// License: https://github.com/zzzprojects/html-agility-pack/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright � ZZZ Projects Inc. 2014 - 2017. All rights reserved.

#if !METRO
namespace HtmlAgilityPack
{
    using System;

    /// <summary>
    ///     Represents a fragment of text in a mixed code document.
    /// </summary>
    public struct TagName : IEquatable<TagName>, IComparable<TagName>, IComparable
    {
        public bool Equals(TagName other)
        {
            return string.Equals(Original, other.Original, StringComparison.OrdinalIgnoreCase);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }
            return obj is TagName && Equals((TagName) obj);
        }

        public override int GetHashCode()
        {
            return StringComparer.OrdinalIgnoreCase.GetHashCode(Original);
        }

        public static bool operator ==(TagName left, TagName right)
        {
            return left.Equals(right);
        }

        public int CompareTo(TagName other)
        {
            return string.Compare(Original, other.Original, StringComparison.OrdinalIgnoreCase);
        }

        public int CompareTo(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return 1;
            }
            if (!(obj is TagName))
            {
                throw new ArgumentException($"Object must be of type {nameof(TagName)}");
            }
            return CompareTo((TagName) obj);
        }

        public static bool operator <(TagName left, TagName right)
        {
            return left.CompareTo(right) < 0;
        }

        public static bool operator >(TagName left, TagName right)
        {
            return left.CompareTo(right) > 0;
        }

        public static bool operator <=(TagName left, TagName right)
        {
            return left.CompareTo(right) <= 0;
        }

        public static bool operator >=(TagName left, TagName right)
        {
            return left.CompareTo(right) >= 0;
        }

        public static bool operator !=(TagName left, TagName right)
        {
            return !left.Equals(right);
        }

        public string Original { get; }

        public TagName(string original)
        {
            Original = original;
        }

        public static implicit operator string(TagName name)
        {
            return name.Original.ToLower();
        }

        public static implicit operator TagName(string name)
        {
            return new TagName(name);
        }

        public int Length
        {
            get { return this.Original.Length; }
        }
        public string ToUpper()
        {
            return Original.ToUpper();
        }
        public string ToLower()
        {
            return Original.ToLower();
        }
        public override string ToString()
        {
            return Original.ToLower();
        }
    }
}
#endif