   M S B A M L   `   `   `  ���� K  GDatabase Manager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Database_ManagerDatabase_Manager  #    Database_Manager.SecondWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     0localclr-namespace:Database_Manager       � Title$  SecondWindow��$	��450��$	��800�����#161616 � 
ResizeMode$ NoResize=�.���  � ColumnDefinitions �� $��20 ��� $
��auto ��� $
��auto ��� $
��auto ��� $��* ��� $��20 � � RowDefinitions �� $��20 ��� $
��auto ��� $
��auto ��� $
��auto ��� $��* ��� $��20 �.+��� -    ��Name$ ChooseTable��$��2��$��1��$	��200��$��30��$��3�� �� SelectedItem$
 Gady��$��
40,10,0,45q����� .R��� ���� �� -    ��Name$ GoBack��$��2��$��2��$	��200��$��3��$��30��$��	40,0,0,95q�$��GO BACK��$
��Bold"�
��� ���
���� ��&   System.Windows.Controls.DataGrid  -     Name$ dataGrid��$��1��$��1��$��3��$��20q�$	��310��   AutoGenerateColumns$ False��	   AlternatingRowBackground
	 �����
   Columns
 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ 	ZwierzeId��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *	ZwierzeId+  $ Nazwa�� �� *Nazwa+  $ Sposób Odżywiania�� �� *SposobOdzywiania+