   M S B A M L   `   `   `  ����Q  MCommunicationsShowroom, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:CommunicationsShowroom.View.Page CommunicationsShowroom.View.Page  5      8    2CommunicationsShowroom.View.Page.InfoEmployeesPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      @local.clr-namespace:CommunicationsShowroom.View.Page     5        N� ShowsNavigationUI  .   N� Title$ AccountClientPage��5
      .��5      � ���#ACE1AF.+�5   
   &   System.Windows.Controls.DataGrid  ���#ACE1AF   
IsReadOnly .    AutoGenerateColumns .   �� SelectedItem 5      �� *SelectInfoEmployees+��5      �� *	Employees+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Имя��5         
Foreground
 �   �1  +System.Windows.Controls.DataGridBoundColumn   Binding 5      �� *Name+  5      $ Фамилия��5      
 �   � 5      �� *
LastName+  5      $ Должность��5      
 �   � 5       �� *
Position+  5!      $ 
Почта��5"      
 �   � 5$      �� *Email+  5%      $3 -Время принятия на работу��5&      
 �   � 5(      �� *DateEnterOnJob+  5)      $ Зарплата��5*      
 �   � 5,      �� *Salary+  5-      $/ )Кол .проданных товаров��5.      
 �   � 50      �� *	GoodsSold+52      55      56      