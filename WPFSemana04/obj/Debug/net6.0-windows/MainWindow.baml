   M S B A M L   `   `   `  ����F  BWPFSemana04, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WPFSemana04WPFSemana04  5   	       WPFSemana04.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:WPFSemana04     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	       �� 
TargetType �� Property �� Value��%�   '��       �� 5
   
   " ��6   .�5      ��  � ��$ Center=�64   �� 5       � ��$ Comic Sans MS)�6+   �� 5       � ��$ 14(�6)   5      5      .��5      � .+�5   
   �� .+�5      �� .+�5      �� $��LISTA DE PERSONAS��6   5      �� 5       �� Orientation$ 
Horizontal=�6   .+�5      �� -   5         ��Name$ btnConsulta��5      .��6C   
Consulta6M   �� 5      $��Nombre��6   �� 5      -   5         ��Name$ txtFirstName��5      $��150px��60   �� 5      $��Apellido��6   �� 5      -   5        $ txtLastName��5      $��150px��6/   5      �� 5      .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ 	dgvPeople��5   *   $��180px��6   	   AutoGenerateColumns$
	 True��6=   
   GridLinesVisibility$
 Vertical=�5          HeadersVisibility$	 All=�6:   
�������   RowBackground
 �����   AlternatingRowBackground
 ��ح�
�������$��5q�5#   .   5$      5%      5&      5(      