using System.Collections.Generic;
using System.Windows.Media;
using Newtonsoft.Json.Linq;
using System;

namespace AiteCriminal
{
    public static class Global
    {
        public static int minSeason = 1;
        public static int maxSeason
        {
            get
            {
                int maxSeason = 1;
                foreach (JProperty currentCase in user.data["response"]["cases_stars"])
                {
                    int caseNumber = Convert.ToInt32(currentCase.Name);
                    int curSeason = caseNumber / 100;
                    if (curSeason > maxSeason) maxSeason = curSeason;
                }
                return maxSeason;
            }
        }
        public static Dictionary<string, string> Pets = new Dictionary<string, string>()
            {
                { "1", "德國牧羊犬" },
                { "2", "查理士王小獵犬" },
                { "3", "黃金獵犬" },
                { "4", "拳師犬" },
                { "5", "秋田犬" },
                { "6", "巴哥犬" },
                { "7", "吉娃娃" },
                { "8", "牧羊犬" },
                { "9", "大麥町" },
                { "10", "傑克羅素梗" },
                { "11", "聖伯納" },
                { "12", "哈士奇" },
                { "13", "老虎" },
                { "14", "熊貓" },
                { "15", "機器狗" },
                { "16", "猴子" },
                { "17", "紅熊貓" },
                { "18", "貓" },
                { "19", "海獅" },
                { "20", "海豚" },
                { "21", "鵜鶘" },
                { "22", "貓頭鷹" },
                { "23", "浣熊" },
                { "24", "短吻鱷" },
                { "25", "松鼠" },
                { "26", "狐狸" },
                { "27", "兔子" },
                { "28", "熊" },
                { "29", "小狐狸" },
                { "30", "獅子" },
                { "31", "山羊" },
                { "32", "機器貓" },
                { "33", "黑猩猩" },
                { "34", "狼" },
                { "35", "鼠" },
                { "36", "巴吉度獵犬" },
                { "37", "駱駝" },
                { "38", "長頸鹿" },
                { "39", "豹" },
                { "40", "大象" },
                { "41", "鶴" },
                { "42", "龍" },
                { "43", "鴨嘴獸" },
                { "44", "袋鼠" },
                { "45", "無尾熊" },
                { "46", "鸚鵡" },
                { "47", "樹懶" },
                { "48", "大羊駝" },
                { "49", "老鷹" },
                { "50", "緬因貓" },
                { "51", "熊" }
            };
        public static Brush getStageButtonBrushColor(int caseNumber = -1)
        {
            BrushConverter brushConverter = new BrushConverter();
            Brush brush = null;
            if (caseNumber == -1)
                brush = (Brush)brushConverter.ConvertFromString("#FF252525");
            else
            {
                int eliteMedalType = user.Elite_Medal(caseNumber);
                int normalMedalType = user.Medal(caseNumber);
                if (user.isCollectMode(caseNumber))
                    brush = (Brush)brushConverter.ConvertFromString("#F7665A");
                else if (eliteMedalType == 4)
                    brush = (Brush)brushConverter.ConvertFromString("#EE9944");
                else if (eliteMedalType == 5)
                    brush = (Brush)brushConverter.ConvertFromString("#F3F3F3");
                else if (eliteMedalType == 6)
                    brush = (Brush)brushConverter.ConvertFromString("#FFFF00");
                else if (normalMedalType == 1)
                    brush = (Brush)brushConverter.ConvertFromString("#B87333");
                else if (normalMedalType == 2)
                    brush = (Brush)brushConverter.ConvertFromString("#C0C0C0");
                else if (normalMedalType == 3)
                    brush = (Brush)brushConverter.ConvertFromString("#FFD700");
            }
            return brush;
        }
    }

}