   M S B A M L   `   `   `  ����Q  MCommunicationsShowroom, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:CommunicationsShowroom.ViewCommunicationsShowroom.View  5      ,    &CommunicationsShowroom.View.DevicePage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:CommunicationsShowroom.View     5        N� ShowsNavigationUI  .   N� Title$ 
DevicePage��5
      .��5      � ���#ACE1AF.+�5   
   &   System.Windows.Controls.DataGrid  ���#ACE1AF   
IsReadOnly .    AutoGenerateColumns .   �� SelectedItem 5      �� *SelectDevice+��5      �� *	Devices+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Бренд��5         
Foreground
 �   �1  +System.Windows.Controls.DataGridBoundColumn   Binding 5      �� *Brand+  5      $! Тип устройства��5      
 �   � 5      �� *
DeviceType+  5      $ Стоимость��5      
 �   � 5       �� *Price+  5!      $, &Количество на складе��5"      
 �   � 5$      �� *AmountInStock+5&      5(      5)      