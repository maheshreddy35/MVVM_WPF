   M S B A M L   `   `   `  ????B  >MVVMApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:MVVMApp.ViewMVVMApp.View  5          MVVMApp.View.ContactView   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:MVVMApp.View     5      .??5	      ?? .+?5   
   ??   ?? Orientation$  
Horizontal=?6   .+?5      ?? $	??200??5      $??30??5      $??	10,20,0,0q?5      $
??Left=?5      ??5      ?? *Contactlist+ ?? SelectedItem 5      ??  ?? Path$ Selected? ?? UpdateSourceTrigger$ PropertyChanged=???5      ?? 5      .R?5      ?? ??6    ?? *Name+69   5       5#      ?? 5%      
???????$??
100,20,0,0q?6,   $
??Auto??6@   $
??Auto??6M   .+?5&      ?? $  
Horizontal=?6   .+?5'      ?? .??6   Name:6#   ?? 5(      $??0,0,0,0q?68   $??17(?6I   
???  ????6    ?? *Person+6j   5)      ?? 5*      $  
Horizontal=?6   .+?5+      ?? .??6   Mobile Number:6,   ?? 5,      $??0,0,0,0q?65   $??17(?6F   
???  ????6    ?? *Frd+6g   5-      ?? 5.      .+?5/      ?? ??6    ?? *
ContactFrd+6>   ?? 50      ??6    ?? *ContactPerson+6A   51      53      55      &   System.Windows.Controls.DataGrid  57   
      DataGridRowStyle1   RowStyle# ?   6     DataGridFocusVisualStyle1 ? FocusVisualStyle# ?  6B     DataGridCellStyle1   	CellStyle# ?  6?     DataGridColumnHeaderStyle1   ColumnHeaderStyle# ?  6?   $
??Left=?58      $??Center=?59         	RowHeight$ 30Q?5:      	   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$		 100 6"   $??	10,10,0,0q?5;      
   AutoGenerateColumns$
 False??5<      $	??290??6/   $??Hidden=?5=      $??Hidden=?5>       ?? IsTextSearchEnabled$
 True??5?      ??57   ?   ?? *Contactlist+ 5@      ?? *SelectedContact+$ PropertyChanged=?   Columns 5B      0  *System.Windows.Controls.DataGridTextColumn  5D      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name??6>   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   ?? *Name+6N     5F      $ Mobile Number??6C    6%   ?? *	FrdMobile+6\   5J      5L      5M      