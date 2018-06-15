# CriminalCase-Bot

Due to an accident crash on my computer, unfortunately, the source code of this bot is missing.
Sorry that I cannot upload the original code, the code here is extracted by .NET reflector.
If you would like to add some features or change anything, the only way you can do is using reverse engineering and assembly language.

### How to use
中文  
1. 使用 Chrome 瀏覽器連上 https://apps.facebook.com/criminalcase  
2. 按下F12或是 Ctrl+Shit+I，然後點擊 Console  
3. 將選單中從 top 選到 iframe_canvas_fb_https  
4. 在下面的輸入欄裡面輸入config.userId 以及 config.signature 會得到兩串數字  
5. 將這兩串數字分別貼在登錄畫面上的那兩格  

English
1. First, use Chrome and enter https://apps.facebook.com/criminalcase  
2. Press F12 or Ctrl+Shift+I and press Console
3. Change the drop-down list shown with the name 'top' to 'iframe_canvas_fb_https'
4. Type config.userId and config.signature to get two strings in the console
5. Copy the two strings and paste them to the two input fields respectively

### Screenshots
![](https://github.com/KuoAiTe/CriminalCase_AiteBot/blob/master/Screenshot/1.png)  
![](https://github.com/KuoAiTe/CriminalCase_AiteBot/blob/master/Screenshot/2.png)  
![](https://github.com/KuoAiTe/CriminalCase_AiteBot/blob/master/Screenshot/3.png)  

最低需求: .NET framework 4.0 
https://www.microsoft.com/zh-tw/download/details.aspx…

### Latest Version : 1.4.0

### V1.0.0
餵食寵物
  記錄在同目錄下的pet.log  
支援自動吃柳橙汁、洋芋片、漢堡  
　可選擇單吃或無限吃  
支援所有關卡(會有開始結束提示)  
　關卡手動調整分數(區分菁英跟一般模式，隨星級而上限不同)  
　關卡顯示星星數量  
　關卡可分為單次遊玩、無限循環  
　關卡遊玩記錄會寫在criminal.log  
　升級紀錄會自動記錄分享連結在share.log  
　單次遊玩可選擇隊友  
支援自動收禮  
　30秒檢查一次信箱  
　可各別設定收取、記錄  
支援秒換漢堡  
　一秒換漢堡(需要滿星才能使用，一般模式下不會開啟菁英模式，菁英模式也是一秒換)  
### V1.1.0  
新增單次遊玩可選擇隊友(會紀錄)  
表格排序更正  
關卡名稱支援到第二季24關名字  
### V1.1.1
修正無寵物玩家閃退  
### V1.1.2
新增無限循環使用隊友  
### v1.1.3
修正部分玩家菁英模式出現問題  
### v1.1.4
修正擁有第三季寵物閃退問題  
新增一鍵滿星  
新增即時訊息  
### v1.1.5
將兩個檔案合併為一個，防止玩家移來移去出現BUG  
關卡倒排序  
新增快速報告  
### v1.2.0
更直觀的介面  
新增隊友用光自動停止  
新增贊助按鈕  
支援全部寵物名字  
修正升級分享連結  
### v1.2.1
介面更正(新增三種顏色區別菁英模式)  
修正第二季57 58 59被隱藏  
### v1.2.2
加快吃柳橙汁洋芋片漢堡速度  
收藏模式顯示為櫻花色  
原本的兌換漢堡修正成兌換柳橙汁、洋芋片、漢堡、能量、金錢、貼紙包  
新增贈送能量(聖誕老人圖樣)  
贈送禮物會顯示  
新增開貼紙包  
### v.1.2.3
修正使用隊友顯示問題並新增提示  
修正兌換漢堡顯示增加到柳橙汁  
修正辦案最小分數與最大分數  
修正兌換金幣顯示超額  
### v.1.3.0
支援第四季  
### v1.4.0
支援第五季  
