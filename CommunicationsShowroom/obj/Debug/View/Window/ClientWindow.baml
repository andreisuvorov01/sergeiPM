   M S B A M L   `   `   `  ����Q  MCommunicationsShowroom, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:CommunicationsShowroom.ViewCommunicationsShowroom.View  5   	   .    (CommunicationsShowroom.View.ClientWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:CommunicationsShowroom.View     5   	     � Icon$  /Image/icon.ico��5   	    � WindowStyle$
 None=�5	   	    � 
ResizeMode$ NoResize=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	   '  !System.Windows.Shell.WindowChrome   IsHitTestVisibleInChrome .  � Title$ ClientWindow��5   	   $	��450��6   $	��800��6+   .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      $	��550 �6   �� 5      .+�5   
   ]� $��Stretch=�6   $��Stretch=�5      ��. $��30��5      $��0��5      $��3��5      .+�5      � $��Right=�6   ���#58a023.+�5      ��  �� Orientation$ 
Horizontal=�6   $��Right=�5       $��Center=�5!      $��30��5"      .+�5#      �� $��Center=�5$      $��13(�5%      $��Oblique$�5&      $
��Bold"�5'      
���   ���5)      �� *	Surname+�� 5+      -   5        	 ��Name$	 MinimizeButton��5+      -  'System.Windows.Input.KeyboardNavigation
   	IsTabStop
 .  $��20��5-      $��20��5.      ���#c2d430$��4,0,4,0q�50      .��51      �� $��/Image/minimize.png��6!   52      �� 53      -   5        $	 CloseButton��53      
 .  $��20��55      $��20��56      $��4,0,4,0q�57      ���#c2d430.��5:      �� $��/Image/close.png��6    5;      5<      �� 5=      -   5        $	 
BackButton��5?      $��20��5@      $��20��5A      ���#c2d430$
��Left=�5C      
 .  .��5E      �� $��/Image/back.png��6   5F      5G      5H      5I      5J      