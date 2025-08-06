namespace LinShin.Fundation.Helper
{
    public static class CharacterInspector
    {
        /// <summary>
        /// 字元是否為兩格位置的符號
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool IsWideChar(char c)
        {
            return
                IsCJK(c) ||
                IsFullWidth(c) ||
                IsHangul(c) ||
                IsCompatibilityForm(c) ||
                IsPUA(c) ||
                IsWideSymbol(c);
        }

        /// <summary>
        /// 字元是否為[中日韓漢字]、[擴充字元]
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        private static bool IsCJK(char c)
        {
            return (c >= 0x4E00 && c <= 0x9FFF) ||
                   (c >= 0x3400 && c <= 0x4DBF);
        }

        /// <summary>
        /// 字元是否為[全形字元]
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        private static bool IsFullWidth(char c)
        {
            return (c >= 0xFF01 && c <= 0xFF60) || (c >= 0xFFE0 && c <= 0xFFE6);
        }

        /// <summary>
        /// 字元是否為[Hangul Syllables]
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        private static bool IsHangul(char c)
        {
            return (c >= 0xAC00 && c <= 0xD7AF);
        }

        /// <summary>
        /// 字元是否為[CJK Compatibility Forms]、[Vertical Forms] 特殊符號
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        private static bool IsCompatibilityForm(char c)
        {
            return (c >= 0xFE10 && c <= 0xFE6F);
        }

        /// <summary>
        /// 字元是否為[Unicode Private Use Area]的區間符號
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        private static bool IsPUA(char c)
        {
            return (c >= 0xE000 && c <= 0xF8FF);
        }

        /// <summary>
        /// 字元是否為[包含部首、擴展符號、日文假名]
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        private static bool IsWideSymbol(char c)
        {
            return (c >= 0x2E80 && c <= 0xA4CF);
        }
    }
}
