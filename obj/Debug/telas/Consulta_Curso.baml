   M S B A M L   `   `   `  ����K  GSistema_Renascer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Sistema_Renascer.telasSistema_Renascer.telas  5   	   +    %Sistema_Renascer.telas.Consulta_Curso   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:Sistema_Renascer.telas     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ Consulta_Curso��5	   	   $	��450��6    $	��800��6-   .��5
      �  � ColumnDefinitions 5   
   �� 5      $	��150 �6   �� 5      $��* �6   .+�5   
   � $��0��6   ���#052D44 � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    .+�5      �� $��1��6   $��/imagens/icon_school.png��6!   $��30��6C   $��30��6N   $��10,15,114,114q�6Z   �� 5      $��1��6   $��Sistema��6!   $��Numans)�63   $��12(�6G   
�������$��36,10,-8,36q�6h   �� 5      $��1��6   $��Renascer��6!   $��Numans)�64   $��12(�6H   
�������$��37,27,-9,19q�6i   �� 5      -   5        $��1��5      $��	Dashboard��6"   
������ 
�������$��
10,120,0,0q�6b   $
��Left=�6v   $��0q�6�   $��Numans)�6�   $��14(�6�   6�   �� 5      -   5        $��2��5      $��Alunos��6"   
������ 
�������$��
10,10,0,10q�6_   $
��Left=�6s   $��0q�6�   $��Numans)�6�   $��14(�6�   6�   �� 5       -   5        $��3��5       $��Turmas��6"   
������ 
�������$��
10,10,0,10q�6_   $
��Left=�6s   $��0q�6�   $��Numans)�6�   $��14(�6�   6�   �� 5!      -   5        $��4��5!      $��Cursos��6"   
������ 
�������$��
10,10,0,10q�6_   $
��Left=�6s   $��0q�6�   $��Numans)�6�   $��14(�6�   6�   �� 5"      -   5        $��5��5"      $��Escolas��6"   
������ 
�������$��
10,10,0,10q�6`   $
��Left=�6t   $��0q�6�   $��Numans)�6�   $��14(�6�   6�   �� 5$      -   5        $��6��5$      $
��Exit��6"   
������ 
�������$��10,53,0,-53q�6]   $
��Left=�6r   $��0q�6�   $��Numans)�6�   $��14(�6�   6�   5%      � 5'   
   $��1��6   $��31,53,30,10q�6    5(      �� 5)      $
��Auto �6    �� 5*      $
��Auto �6    �� 5+      $
��Auto �6    �� 5,      $
��Auto �6    �� 5-      $
��Auto �6    .+�5/      �� $��0��6   $��Consulta de cursos��6!   $��
0,10,10,20q�6>   $��24(�6R   $��Numans)�6`   &   System.Windows.Controls.DataGrid  50      -   5          Name$ data_grid_curso��50   $   $��1��6   $��
0,10,10,20q�6=      Columns 51      0  *System.Windows.Controls.DataGridTextColumn  52      ,  &System.Windows.Controls.DataGridColumn   Header$
 Nome��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$	 130 67     53      $ Código��6)   $	 110 69     54      $ Descrição��6)   $	 130 6<     55      $ Coordernador��6)   $	 150 6?     56      $ Ativo��6)   $	 150 68   58      59      5;      5<      