   M S B A M L   `   `   `  ����K  GDatabase Manager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Database_ManagerDatabase_Manager  5   	   #    Database_Manager.SecondWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Database_Manager     5   	     � Title$  SecondWindow��5   	   $	��450��6   $	��800��6+   ���#161616 � 
ResizeMode$ NoResize=�6L   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��20 �6   6*   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $��* �6   6)   �� 5      $��20 �6   6*   .+�5   
   �� -   5         ��Name$ ChooseTable��5      $��2��6(   $��1��68   $	��200��5      $��30��6   $��3��6#    �� SelectedItem$
 Gady��6d   $��
40,10,0,45q�6x   ��5      �� 5       .R�5!      �� ��6#   �� 5"      5%      �� 5'   
   -   5         ��Name$ GoBack��5'      $��2��6!   $��2��61   $	��200��6>   $��3��5(      $��30��6!   $��	40,0,0,95q�6-   $��GO BACK��6@   $
��Bold"�6R   
��� ���
���� ��6�   &   System.Windows.Controls.DataGrid  5*   
   -   5          Name$ dataGrid��5*      $��1��6%   $��1��65   $��3��5+      $��20q�6$   $	��310��60      AutoGenerateColumns$ False��5,      	   AlternatingRowBackground
	 �����
   Columns
 5-      0  *System.Windows.Controls.DataGridTextColumn  5.      ,  &System.Windows.Controls.DataGridColumn   Header$ 	ZwierzeId��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 68   �� *	ZwierzeId+  5/      $ Nazwa��6%    64   �� *Nazwa+  50      $ Sposób Odżywiania��6%    6@   �� *SposobOdzywiania+52      54      55      