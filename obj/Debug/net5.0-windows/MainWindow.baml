   M S B A M L   `   `   `  ????B  >MVVMApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:MVVMApp.ViewMVVMApp.View  5	   	   5clr-namespace:MVVMApp.ViewModelMVVMApp.ViewModel  5
   	       MVVMApp.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,viewsclr-namespace:MVVMApp.View     5	   	   6
viewModelsclr-namespace:MVVMApp.ViewModel     5
   	     ? Title$  
MainWindow??5   	   $	??500??6   $	??800??6)    ? DataContext 5      +  %MVVMApp.ViewModel.MainWindowViewModel  5   
    ? 	Resources 5       ?? DataType-   'MVVMApp.ViewModel.RegistrationViewModel#   MVVMApp.View.RegistrationView%   MVVMApp.ViewModel.UserViewModel   MVVMApp.View.UserView&    MVVMApp.ViewModel.LoginViewModel   MVVMApp.View.LoginView??%?   (??       5      *, +)(?? 2     5      *, +)(?? d     5      *, +)?? 5   
   "  6   .R?5        5      ?? 5   
   "  6   .R?5        5      ?? 5   
   "  6   .R?5        5      5      .??5      ?? .+?5    
   ?? 
??? E??$??62??6-   .+?5#   
   ??  ?? Orientation$ 
Horizontal=?6   $??Right=?6.   $??	0,30,20,0q?6J   .+?5$      ?? $??Get All Users??6   $	??get??5&      
?????? 
???????$??0,0,40,0q?5)      
?????? ??5%      ?? *
NavCommand+5*      ?? 5,      $??Registration??6   $??register??5.      
?????? 
???????$??0,0,40,0q?51      
?????? ??5-      ?? *
NavCommand+52      ?? 56      $??Login??6   $??login??58      
?????? 
???????
?????? ??57      ?? *
NavCommand+5;      5=      5>      ?? 5B   
   -   5         ??Name$ MainContent??5B      $??1??6,   $	??428??6;   ??5C      ?? 5D       ?? ImageSource$R Lhttps://i.pinimg.com/originals/02/d6/1f/02d61f74cdf08abf44babe9b07b28edd.jpg??6    j? Stretch$
 Fill=?6x   6?   .+?5F      ?? ??6!   ?? *CurrentViewModel+5G      5J      5O      