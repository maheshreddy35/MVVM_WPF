   M S B A M L   `   `   `  ????B  >MVVMApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:MVVMApp.ViewMVVMApp.View  5      =#clr-namespace:MVVMApp.customcontrolMVVMApp.customcontrol  67       MVVMApp.View.LoginView   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:MVVMApp.View     5      7control#clr-namespace:MVVMApp.customcontrol     67   .??5	      ? .+?5   
   &    MVVMApp.customcontrol.CustomText  $??23??6   $
??Left=?6)   $??	10,10,0,0q?6D   $??Login:??6W   $	??Top=?6e   ?? 5   
   -   5        $??textBlockHeading??5   N   $??50??6   $
??Left=?6    $??	24,48,0,0q?6;   $	??Top=?6f   $??12(?6~   $??Italic$?6?     ?? Padding$  5q?6?   
???????][Note: Please login here to view the features of this site. If you are new on this site then?? 5   j   please click on5      ?? 5   
   -   5        $??
textBlock1??5   O   $??23??6   $
??Left=?6    $??
66,169,0,0q?6;   $??Phone Number:??6a   $	??Top=?6v   $??98??6?   
???   ?$
??Bold"?6?   ?? 5   
   -   5        $??
textBlock2??5   O   $??23??6   $
??Left=?6    $??
66,225,0,0q?6;   $??	Password:??6a   $	??Top=?6r   $??77??6?   
???   ? J? RenderTransformOrigin$ 1.121,0.406&?6?   $
??Bold"?6?   ?? 5   
   -   5        $??textBoxEmail??5   N   $??24??6   $
??Left=?6   $??183,168,0,0q?69   $	??Top=?6b   $	??247??6z   $??14(?6?   ??6?   ?? *User.Mobile+ ?? Mode$ TwoWay=??? 5   
   -   5        $??passwordBox1??5   N   $??23??6   $
??Left=?6   $??183,225,0,0q?69   $	??Top=?6b   $	??247??6z   $??14(?6?   ??6?   ?? *User.Password+$ TwoWay=?(   "MVVMApp.customcontrol.Custombutton  5   
   $
??Left=?5      $??186,281,0,0q?6'   $	??Top=?6<   $??14(?6{   
?????????6U   ??  ?? Path$ LoginCommand?6?   ?? 5   
   -   5         ??Name$ errormessage??5   ;   $??23??6   $
??Left=?6    $	??Top=?6R   $	??400??6j   $??
51,113,0,0q?6v    J? OpacityMask
 ?<?????	#FFE5572C$
??Bold"?6?   $??14(?6?   $??Italic$?6  ??6?   ?? *Errormessage+$ TwoWay=?6  5      5      