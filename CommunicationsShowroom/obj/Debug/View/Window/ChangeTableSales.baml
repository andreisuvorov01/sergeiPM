   M S B A M L   `   `   `  ����Q  MCommunicationsShowroom, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:CommunicationsShowroom.View.Window"CommunicationsShowroom.View.Window  5   	   9    3CommunicationsShowroom.View.Window.ChangeTableSales   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Blocal0clr-namespace:CommunicationsShowroom.View.Window     5   	     � Icon$  /Image/icon.ico��5   
    � WindowStyle$
 None=�5	   	    � 
ResizeMode$ NoResize=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	   '  !System.Windows.Shell.WindowChrome   IsHitTestVisibleInChrome .  � Title$' !Добавления данных��5   
   $	��520��6$   $	��300��61   .��5      �� 
���   �$��2q�6!    �� CornerRadius$ 5��65   ._�5   
   � ���#555555 � RowDefinitions 5      �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    .+�5      ]� $��Stretch=�6   $��Stretch=�5      ��. $��30��5      $��0��5       .+�5!      � $��Right=�6   ���#573595.+�5#      ��  �� Orientation$ 
Horizontal=�6!   $��Right=�5$      $��Center=�5%      $��20��5&      .+�5'      �� -   5        	 ��Name$	 MinimizeButton��5'   !   -  'System.Windows.Input.KeyboardNavigation
   	IsTabStop
 .  $��20��5)      $��20��5*      ���#c2d430$��4,0,4,0q�5-      .��5.      �� $��/Image/minimize.png��6%   5/      �� 50      -   5        $	 CloseButton��50   !   
 .  $��20��52      $��20��53      $��4,0,4,0q�54      ���#c2d430.��57      �� $��/Image/close.png��6$   58      59      5:      5;      �� 5=      $��1��5>      $��10q�5?      .+�5@      �� $��Дата��5A      $��18(�5B      ���#c2d4305C      �� 5E      $��23��5F      ��5H      �� *Date+5J      �� 5K      $��2��6   $��10q�6'   .+�5L      �� $��Id Клиента��5M      $��18(�5N      ���#c2d4305O      �� 5Q      $��23��5R      ��5T      �� *	Id_Client+5V      �� 5W      $��10q�5X      $��3��5Y      .+�5Z      �� $��Id Устройства��5[      $��18(�5\      ���#c2d4305]      �� 5_      $��23��5`      ��5b      �� *	Id_Device+5d      �� 5e      $��10q�5f      $��4��5g      .+�5h      �� $��Стоимость��5i      $��18(�5j      ���#c2d4305k      �� 5m      $��23��5n      ��5p      �� *Price+5r      �� 5s      $��10q�5t      $��5��5u      .+�5v      �� $��Статус��5w      $��18(�5x      ���#c2d4305y      �� 5{      $��23��5|      ��5~      �� *	Id_Status+5�      �� 5�      -   5        $��btnSave��5�      ���#58a023$��Italic$�5�      $��6��5�      $��90��5�      $��10q�5�      $��30��5�      $��14(�5�      $��Right=�5�      $��Сохранить��5�      5�      5�      5�      