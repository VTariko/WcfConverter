   M S B A M L   `   `   `  ����K  GSimpleWcf.Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:SimpleWcf.ClientSimpleWcf.Client  5   	   !    SimpleWcf.Client.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:SimpleWcf.Client     5   	     � Title$  Currency Converter��5   	   $	��350��6$   $	��263��61    � 
ResizeMode$ NoResize=�6=    � WindowStartupLocation$ CenterScreen=�6S   .��5	      � ��5
      �� 5       �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6*   .��5      �  � Color$ Black��6    � Offset$ 0Q�6!   � 5      $ White��6   $ 1Q�6!   5      .+�5      �� -   5         ��Name$ tbCurrencyFrom��5      $��0��6$   $
��Left=�6-   $��23��6H   $��	10,72,0,0q�6T   $	��Top=�6g   $	��135��6    �� TextAlignment$ Right=�6�   6�   �� 5      -   5        $ tbCurrencyTo��5      $��0��6"   $
��Left=�6+   $��23��6F   $��
10,142,0,0q�6R   $	��Top=�6f   $	��135��6~   $ Right=�6�   	 �� 
IsReadOnly	 . 6�   �� 5      -   5        
 ��Name$
 cbCurrencyFrom��5      $
��Left=�6%   $��
160,72,0,0q�6@   $	��Top=�6T   $��75��6l    �� DisplayMemberPath$ CurrencyCode��6w   6�   �� 5      -   5        $
 cbCurrencyTo��5      $
��Left=�6#   $��160,142,0,0q�6>   $	��Top=�6S   $��75��6k   $ CurrencyCode��6v   6�   �� 5      -   5         ��Name$ 	lblCourse��5   
   $��	Курс:��6   $
��Left=�6-   $��
10,224,0,0q�6H   $	��Top=�6\   �� 5      -   5        $ tbCourse��5      $
��Left=�6   $��23��69   $��105,227,0,0q�6E   $	��Top=�6Z   $	��130��6r   	 . 6~   �� 5      -   5         ��Name$ btnChangeCurrency��5      $��↑↓��6&   $
��Left=�63   $��180,110,0,0q�6N   $	��Top=�6c   $��35��6{   6�   5      5      