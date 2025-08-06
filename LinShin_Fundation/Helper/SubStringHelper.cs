namespace LinShin.Fundation.Helper
{
    public class SubStringHelper
    {
        /// <summary>
        /// 傳入預設字元長度為基準，並動態根據特殊字元數，減少切除字串長度
        /// </summary>
        /// <param name="input">傳入整行文字</param>
        /// <param name="startVisualIndex">上一個欄位動態調整後的起始位置</param>
        /// <param name="visualLength">預設非包含特殊字元的長度</param>
        /// <returns></returns>
        public static string Substring(string input, int startVisualIndex, int visualLength)
        {
            int currentVisual = 0;
            int currentCharIndex = 0;
            int startCharIndex = -1;
            int takenCharCount = 0;

            while (currentCharIndex < input.Length)
            {
                char c = input[currentCharIndex];
                int width = CharacterInspector.IsWideChar(c) ? 2 : 1;

                if (currentVisual >= startVisualIndex && startCharIndex == -1)
                {
                    startCharIndex = currentCharIndex;
                }

                if (startCharIndex != -1)
                {
                    takenCharCount++;
                }

                currentVisual += width;

                if (currentVisual >= startVisualIndex + visualLength)
                {
                    break;
                }

                currentCharIndex++;
            }

            if (startCharIndex == -1 || startCharIndex >= input.Length)
                return "";

            return input.Substring(startCharIndex, takenCharCount);
        }

        /// <summary>
        /// 該列字串的最後一個欄位，直接取到底，避免長度不固定
        /// </summary>
        /// <param name="input"></param>
        /// <param name="startVisualIndex"></param>
        /// <returns></returns>
        public static string SubstringEndField(string input, int startVisualIndex)
        {
            int currentVisual = 0;
            int currentCharIndex = 0;
            int startCharIndex = -1;

            while (currentCharIndex < input.Length)
            {
                char c = input[currentCharIndex];
                int width = CharacterInspector.IsWideChar(c) ? 2 : 1;

                if (currentVisual >= startVisualIndex)
                {
                    startCharIndex = currentCharIndex;
                    break;
                }

                currentVisual += width;
                currentCharIndex++;
            }

            if (startCharIndex == -1 || startCharIndex >= input.Length)
                return "";

            return input[startCharIndex..];
        }
    }
}
