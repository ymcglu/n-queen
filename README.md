### N-Queens
這個程式解決在 N * N 的棋盤上安放 N 個皇后的問題，使得它們不會互相攻擊
使用了深度優先搜尋 (DFS) 的演算法來尋找所有可能的皇后配置

**SolveNQueens**
初始化棋盤和兩個對角線

**FindSolutions**
採用深度優先搜尋(DFS)的方式來尋找解

**IsSafe**
檢查位置是否已經被放置皇后的列、對角線覆蓋。沒有被覆蓋返回 true，被覆蓋返回 false。

**PlaceQueen**
給定位置放置皇后

**RemoveQueen**
給定位置刪除皇后

**建制程式**
1.要建立這個程式，需要先安裝 .NET Core
[](https://dotnet.microsoft.com/zh-cn/download/dotnet)

2.在終端機建立一個新的目錄並進入該目錄：
```
mkdir n-queens
cd n-queens

```
3.在終端機執行以下命令來建立一個新的 .NET Core 控制台應用程式：
`dotnet new console`

4.將代碼覆蓋到新建的Program.cs檔案

5.在終端機執行以下命令建立可執行檔：
`dotnet build`

6.在終端機執行以下命令執行程式並查看結果：
`dotnet run`
這將會執行程式並輸出所有可能的皇后配置
