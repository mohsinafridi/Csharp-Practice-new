

namespace general_practice_03
{
    public static class learntuple
    {
        // Using Tuple
        public static (string firstName,string lastName) ParseFirstAndLastName(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException(nameof(name));

            int indexOfFirstSpace = name.IndexOf(' '); // 6 // Mohsin Azam Afridi                        
            int lastIndex = name.LastIndexOf(" ");

            if (indexOfFirstSpace < 0)
            {
                indexOfFirstSpace = name.Length;
            }
            return (name.Substring(0, indexOfFirstSpace), name.Substring(indexOfFirstSpace));
        }

        // Using WITHOUT Tuple
        public static  void ParseFirstAndLastNameWithOutTuple(string name, out string firstName,out string lastName)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException(nameof(name));

            int indexOfFirstSpace = name.IndexOf(' ');
            if (indexOfFirstSpace < 0)
            {
                indexOfFirstSpace = name.Length;
            }
            firstName = name.Substring(0, indexOfFirstSpace);
            lastName = name.Substring(indexOfFirstSpace);
        }

        // get the nth index of any sub-string in a string.
        public static int IndexOfNth(this string str, string value, int nth = 0)
        {
            if (nth < 0)
                throw new ArgumentException("Can not find a negative index of substring in string. Must start with 0");

            int offset = str.IndexOf(value);
            for (int i = 0; i < nth; i++)
            {
                if (offset == -1) return -1;
                offset = str.IndexOf(value, offset + 1);
            }

            return offset;
        }
    }
}
