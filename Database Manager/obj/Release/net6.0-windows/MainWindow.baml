   M S B A M L   `   `   `  ���� K  GDatabase Manager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Database_ManagerDatabase_Manager  !    Database_Manager.MainWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     0localclr-namespace:Database_Manager       � Title$  Database Manager��$	��450��$	��800�����#161616 � 
ResizeMode$ NoResize=�.���  � ColumnDefinitions �� $��20 ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $��* ��� $��20 � � RowDefinitions �� $��20 ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $��* ��� $��20 �.+��� $��1��$��1��$��20(�
���� ��$��Nazwa zwierzecia��$��0,30,0,0q��� -    ��Name$ NazwaZwierzecia��$��2��$��1��$��	10,30,0,0q�$��20��$	��100���� $��1��$��2��$��20(�
���� ��$	��Typ���� -   $	 Typ��$��2��$��10,0,0,0q�$��2��$��20��$	��100���� $��1��$��3��$��20(�
���� ��$��Sposób Odżywiania���� -   $��SposobOdzywiania��$��2��$��3��$��20��$	��100��$��10,0,0,0q��� -    ��Name$ 
Add_Record��$��1��$��4��$��SUBMIT��$
��Bold"�$
��auto��$��25��$��2��$��0,20,0,0q�
���� ��
���/kU��� $��1��$��5��$��20(�
���� ��$��ID��$��0,20,0,0q��� -   $��DeleteRecord��$��2��$��5��$��20��$	��100��$��	10,20,0,0q��� -   $ Delete_Record��$��1��$��6��$ ��DELETE RECORD WITH THAT ID��$
��Bold"�
���  ��
���� ��$
��auto��$��25��$��2��$��0,30,0,0q��� -   $ 
NextWindow��$��1��$��7��$��SEE ALL TABLES��$
��Bold"�
��� ���
���� ��$
��auto��$��25��$��2��$��0,40,0,0q�&   System.Windows.Controls.DataGrid  -   $��Animals��$��3��$��1��$��9��$
��auto��$	��370��$��60,0,0,0q�   CanUserAddRows$ false��   AlternatingRowBackground
 �����   AutoGenerateColumns$ false��	   Columns	 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn
   Header$
 Id Zwierzęcia��1  +System.Windows.Controls.DataGridBoundColumn   Binding ��  �� Path$ Id�  $
 Nazwa�� �� $ Nazwa�  $	
 Typ�� �� $	 Typ�  $
 Sposób Odżywiania�� �� $ SposobOdzywiania�