   M S B A M L   `   `   `  ����K  GSistema_Renascer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Sistema_Renascer.telasSistema_Renascer.telas  5   	   "    Sistema_Renascer.telas.Login   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:Sistema_Renascer.telas     5   	     � Title$  Login��5   	   $	��450��6   $	��800��6$    � WindowStartupLocation$ CenterScreen=�5	   	   .��5
      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��/imagens/logo.png��6    $��UniformToFill=�6;   $��-5,0,5,1q�6S   � 5   
   $��1��6   $��0,2,0,0q�6    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    .+�5      �� $��0��6   $��Acesse ao sistema��6!   $��
0, 60,0,10q�6=   $��Numans)�6Q   $��20(�6e   $��Center=�6s   6�   �� 5      $��0��6   $��Usuário��6!   $��20,130,10,0q�63   $��14(�6H   $��Numans)�6V   �� 5      -   5         ��Name$ user_txt��5   #   $��1��6   $��
20,0,37,10q�65   $��30��6I   .��6V    � 	Resources 5       �� 
TargetType �� Property �� Value��%_   '��       �� 5      " ��6   .�5       ��  �@��CornerRadius$ 10��69   5!      5"      .��6%   5#      �� 5%      $��2��6   $��Senha��6!   $��	20,0,10,0q�61   $��5,0,5,5q�6D   $��14(�6V   $��Numans)�6d   �� 5&      -   5        $ password_txt��5&   #   $��3��6   $��
20,0,37,10q�69   $��30��6M   .��6Z    5'      ��%_   '��       �� 5(      " ��6   .�5)      ��  �@��CornerRadius$ 10��69   5*      5+      .��6%   5,      �� 5.      $��4��6   	 �� Orientation$	 
Horizontal=�6&   $��Center=�6?   $��
0 40 0 140q�6\   .+�5/      �� -   5        $��Entrar��5/      $	��120��6*   ���#052D44
�������
������ $��16(�50   F   $��Numans)�6T    51      ��%_   '��       �� 52      " ��6    .�53      ��  �@��CornerRadius$ 10��6=   54      55      56      �� 57      -   5        $��Cancelar��57      $	��100��6,   $��	10, 0,0,0q�68   $��10q�6K   
������ $��16(�58   3   $��Numans)�6A   ���#CD5A5A
������� 59      ��%_   '��       �� 5:      " ��6    .�5;      ��  �@��CornerRadius$ 10��6=   5<      5=      5>      5?      �� 5@      $��5��6   $	 
Horizontal=�6&   $��Center=�6?   $��	0 90 0 80q�6\   .+�5A      �� -   5        $��Criar conta��5A      $	��120��6/   $��	10, 0,0,0q�6;   $��1q�6N   
������ $��14(�5B   /   $��Numans)�6=   ���#D9D9D9
���   � 5C      ��%_   '��       �� 5D      " ��6    .�5E      ��  �@��CornerRadius$ 10��6=   5F      5G      5H      5I      5J      5L      5M      