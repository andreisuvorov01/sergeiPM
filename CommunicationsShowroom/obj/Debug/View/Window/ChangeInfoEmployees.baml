   M S B A M L   `   `   `  ����Q  MCommunicationsShowroom, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:CommunicationsShowroom.View.Window"CommunicationsShowroom.View.Window  5   	   <    6CommunicationsShowroom.View.Window.ChangeInfoEmployees   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Blocal0clr-namespace:CommunicationsShowroom.View.Window     5   	     � Icon$  /Image/icon.ico��5   	    � WindowStyle$
 None=�5	   	    � 
ResizeMode$ NoResize=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	   '  !System.Windows.Shell.WindowChrome   IsHitTestVisibleInChrome .  � Title$' !Добавления данных��5   
   $	��650��6$   $	��300��61   .��5      �� 
���   �$��2q�6!    �� CornerRadius$ 5��65   ._�5   
   � ���#ACE1AF � RowDefinitions 5      �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    .+�5      ]� $��Stretch=�6   $��Stretch=�5      ��. $��30��5      $��0��5      .+�5       � $��Right=�6   ���#573595.+�5"      ��  �� Orientation$ 
Horizontal=�6!   $��Right=�5#      $��Center=�5$      $��20��5%      .+�5&      �� -   5        	 ��Name$	 MinimizeButton��5&   !   -  'System.Windows.Input.KeyboardNavigation
   	IsTabStop
 .  $��20��5(      $��20��5)      ���#47ba44$��4,0,4,0q�5,         ButtonStyleAll#���   6&   .��5-      �� $��/Image/minimize.png��6%   5.      �� 5/      -   5        $	 CloseButton��5/   !   
 .  $��20��51      $��20��52      $��4,0,4,0q�53      ���#47ba44#���   55   ,   .��56      �� $��/Image/close.png��6$   57      58      59      5:      �� 5<      $��1��5=      $��10q�5>      .+�5?      �� $��Имя��5@      $��18(�5A      
���   �5B      �� 5D      $��23��5E      ��5G      �� *Name+5I      �� 5J      $��2��6   $��10q�6'   .+�5K      �� $��Фамилия��5L      $��18(�5M      
���   �5N      �� 5P      $��23��5Q      ��5S      �� *
LastName+5U      �� 5V      $��10q�5W      $��3��5X      .+�5Y      �� $��Должность��5Z      $��18(�5[      
���   �5\      �� 5^      $��23��5_      ��5a      �� *
Position+5c      �� 5d      $��10q�5e      $��4��5f      .+�5g      �� $��
Почта��5h      $��18(�5i      
���   �5j      �� 5l      $��23��5m      ��5o      �� *Email+5q      �� 5r      $��10q�5s      $��5��5t      .+�5u      �� $3��-Время принятия на работу��5v      $��18(�5w      
���   �5x      �� 5z      $��23��5{      ��5}      �� *DateEnterOnJob+5      �� 5�      $��10q�5�      $��6��5�      .+�5�      �� $��Зарплата��5�      $��18(�5�      
���   �5�      �� 5�      $��23��5�      ��5�      �� *Salary+5�      �� 5�      $��10q�5�      $��7��5�      .+�5�      �� $/��)Кол .проданных товаров��5�      $��18(�5�      
���   �5�      �� 5�      $��23��5�      ��5�      �� *	GoodsSold+5�      �� 5�      -   5        $��btnSave��5�      ���#47ba44$��Italic$�5�      $��8��5�      $��90��5�      $��10q�5�      $��30��5�      $��14(�5�      $��Right=�5�      $��Сохранить��5�      5�      5�      5�      