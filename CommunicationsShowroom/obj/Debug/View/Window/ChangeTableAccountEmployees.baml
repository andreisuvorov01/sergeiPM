   M S B A M L   `   `   `  ����Q  MCommunicationsShowroom, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:CommunicationsShowroom.View.Window"CommunicationsShowroom.View.Window  5   	   D    >CommunicationsShowroom.View.Window.ChangeTableAccountEmployees   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Blocal0clr-namespace:CommunicationsShowroom.View.Window     5   	     � Icon$  /Image/icon.ico��5   	    � WindowStyle$
 None=�5	   	    � 
ResizeMode$ NoResize=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	   '  !System.Windows.Shell.WindowChrome   IsHitTestVisibleInChrome .  � Title$' !Добавления данных��5   
   $	��520��6$   $	��300��61   .��5      �� 
���   �$��2q�6!    �� CornerRadius$ 5��65   ._�5   
   � ���#ACE1AF � RowDefinitions 5      �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    .+�5      ]� $��Stretch=�6   $��Stretch=�5      ��. $��30��5      $��0��5      .+�5      � $��Right=�6   ���#573595.+�5       ��  �� Orientation$ 
Horizontal=�6!   $��Right=�5!      $��Center=�5"      $��20��5#      .+�5$      �� -   5        	 ��Name$	 MinimizeButton��5$   !   -  'System.Windows.Input.KeyboardNavigation
   	IsTabStop
 .  $��20��5&      $��20��5'      ���#47ba44$��4,0,4,0q�5*         ButtonStyleAll#���   6&   .��5+      �� $��/Image/minimize.png��6%   5,      �� 5-      -   5        $	 CloseButton��5-   !   
 .  $��20��5/      $��20��50      $��4,0,4,0q�51      ���#47ba44#���   53   ,   .��54      �� $��/Image/close.png��6$   55      56      57      58      �� 5:      $��1��5;      $��10q�5<      .+�5=      �� $��
Логин��5>      $��18(�5?      
���   �5@      �� 5B      $��23��5C      ��5E      �� *LoginEmployees+5G      �� 5H      $��2��6   $��10q�6'   .+�5I      �� $��Пароль��5J      $��18(�5K      
���   �5L      �� 5N      $��23��5O      ��5Q      �� *PasswordEmployees+5S      �� 5T      $��10q�5U      $��3��5V      .+�5W      �� $��Id Сотрудника��5X      $��18(�5Y      
���   �5Z      �� 5\      $��23��5]      ��5_      �� *Id_Employees+5a      �� 5b      $��10q�5c      $��4��5d      .+�5e      �� $��Статус��5f      $��18(�5g      
���   �5h      �� 5j      $��23��5k      ��5m      �� *	Id_Status+5o      �� 5q      -   5        $��btnSave��5u      ���#47ba44$��Italic$�5s      $��5��5t      $��90��5w      $��10q�5x      $��30��5y      $��14(�5z      $��Right=�5{      $��Сохранить��5|      5~      5      5�      