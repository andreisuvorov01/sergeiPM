   M S B A M L   `   `   `  ����Q  MCommunicationsShowroom, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:CommunicationsShowroom.View.Window"CommunicationsShowroom.View.Window  5   	   .    (CommunicationsShowroom.View.Autorization   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Blocal0clr-namespace:CommunicationsShowroom.View.Window     5   	     � Icon$  /Image/icon.ico��5   	    � WindowStyle$
 None=�5	   	    � 
ResizeMode$ NoResize=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	   '  !System.Windows.Shell.WindowChrome   IsHitTestVisibleInChrome .  � Title$ Авторизация��5   	   $	��500��6   $	��400��6*   ��5   
   Z� .��5      ��  �� CornerRadius$ 10��6   $��1q�6   ._�5   
   � ���#ACE1AF � RowDefinitions 5      �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    .+�5      ]� $��Stretch=�6   $��Stretch=�5      ��. $��30��5      $��0��5      .+�5      � -   5        $��Right=�5      ���#573595.+�5      ��  �� Orientation$ 
Horizontal=�6!   $��Right=�5      $��Center=�5       $��30��5!      .+�5"      �� $��24(�5#      $��0,0,65,0q�5$      
�������$��Center=�5&      $
��Left=�5'      $��Авторизация��5(      $��Edwardian Script ITC)�6'   $��Italic$�6I   �� 5)      -   5        	 ��Name$	 MinimizeButton��5)   !   -  'System.Windows.Input.KeyboardNavigation
   	IsTabStop
 .  $��20��5+      $��20��5,      ���#47ba44$��4,0,4,0q�5/         ButtonStyleAll#���   6&   .��50      �� $��/Image/minimize.png��6%   $��10��6C   $��10��6N   $��Center=�6Z   51      �� 52      -   5        $	 CloseButton��52   !   
 .  $��20��54      $��20��55      $��4,0,4,0q�56      ���#47ba44#���   58   ,   .��59      �� $��/Image/close.png��6$   $��10��6>   $��10��6I   $��Center=�6U   5:      5;      5<      5=      �� 5>      $��1��6   $��20q�6&   .+�5?      �� $��5,10,0,0q�5@      $��25(�5A      
���   �$��
Логин��5C      $��Edwardian Script ITC)�6!   $��Italic$�6C   �� 5D      $ 10��6   $��1q�6+   ���#a4a4a4���#6acc86._�5E      �� -   5         ��Name$ loginBox��5G      $��	10,0,10,0q�5H      $��23��5I      ��5F      �� *Login+5I      5K      5L      �� 5M      $��2��6   $��20q�6&   .+�5N      �� $��5,10,0,0q�5O      $��25(�5P      
���   �$��Пароль��5R      $��Edwardian Script ITC)�6"   $��Italic$�6D   �� 5S      $ 10��6   $��1q�6+   ���#a4a4a4���#6acc86._�5T      G� -   5        $��pswBox��5U      $��23��5V      $��	10,0,10,0q�5W      5Z      5[      �� 5\      $��3��6   $ 
Horizontal=�5]      $��Center=�5_      .+�5a      �� $��
Гость��5b      $��80��5c      $y�Hidden=�5d      $��40��5e      $��20(�5f      ���#58a023$
��Left=�5h      $��10q�5i      #���   6   �� 5k      -   5        $��
Войти��5m      $��80��5n      $��40��5o      $��20(�5p      ���#8c82af$��Right=�5r      $��	210,0,0,0q�5s      #���   6$   $��Italic$�6M   $��Goudy Old Style)�6`   5u      5v      5w      5x      