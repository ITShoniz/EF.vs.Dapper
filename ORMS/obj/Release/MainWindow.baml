   M S B A M L   `   `   `  ���� ?  ;ORMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ORMSORMS      ORMS.MainWindow   a ]DevExpress.Xpf.Core.v18.1, Version=18.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aR NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     $localclr-namespace:ORMS     c _DevExpress.Xpf.Charts.v18.1, Version=18.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a>dxc4http://schemas.devexpress.com/winfx/2008/xaml/charts  ;dx2http://schemas.devexpress.com/winfx/2008/xaml/core    � Title$  
MainWindow��$	��768��$
��1391��.���  � ColumnDefinitions �� $��1153* ��� $
��230* �.+�(  "DevExpress.Xpf.Charts.ChartControl     CrosshairOptions ,  &DevExpress.Xpf.Charts.CrosshairOptions     ShowArgumentLabels .    ShowValueLabels . 0  *DevExpress.Xpf.Charts.CrosshairOptionsBase   ShowValueLine .    Legend "  DevExpress.Xpf.Charts.Legend     Diagram. '  !DevExpress.Xpf.Charts.XYDiagram2D  -     Name$ Chart��#  DevExpress.Xpf.Charts.Diagram	   Series.	 1  +DevExpress.Xpf.Charts.BarSideBySideSeries2D  "  DevExpress.Xpf.Charts.Series
   DisplayName$#
 EntityFreamwork (WithTraking)��   LabelsVisibility .   $$
 EntityFreamwork (AsNoTracking)�� .   $!
 EntityFreamwork (Singleton)�� .   $'
 !EntityFreamworkCore (WithTraking)�� .   $(
 "EntityFreamworkCore (AsNoTracking)�� .   $%
 EntityFreamworkCore (Singleton)�� .   $
 Dapper�� .   $
 ADO.Net (DataTable)�� .   $
 ADO.Net (SqlDataReader)�� .   $%
 ADO.Net (SqlDataReader Generic)�� .   $)
 #ADO.Net (SqlDataReader TPL Generic)�� .   $
 ADO.Net (With Codedom)�� . &	   DevExpress.Xpf.Core.SimpleButton	  -    	 Name$ btnEF��$"��EntityFreamwork With Traking��$��1��$��36��$��
10,49,10,0q�$	��Top=� 	  
ButtonKind$ Repeat=�	  -   $ 
btnEFAsync��$"��EntityFreamwork As NoTraking��$��1��$��36��$��
10,89,10,0q�$	��Top=�$ Repeat=�	  -   $ 	btnEFCash��$!��EntityFreamwork (Singleton)��$��1��$��36��$��10,130,10,0q�$	��Top=�$ Repeat=�	  -   $ 	btnDapper��$��Dapper��$��1��$��36��$��10,294,10,0q�$	��Top=�$ Repeat=�	  -   $ btnADONetHandedCode��$��ADO.Net HandedCode��$��1��$��36��$��10,376,10,0q�$	��Top=�$ Repeat=�	  -   $ btnADONetTable��$��ADO.Net Table��$��1��$��36��$��10,334,10,0q�$	��Top=�$ Repeat=�	  -   $��Clean��$��1��$��
10,0,10,10q�$��Bottom=�$ Repeat=�$��33��	  -	   $��ADO.Net Reflaction��$��1��$��36��$��10,416,10,0q�$	��Top=�$ Repeat=�	  -
   $��ADO.Net TPL Reflaction��$��1��$��36��$��10,458,10,0q�$	��Top=�$ Repeat=�	  -   $��ADO.Net WithCodedom��$��1��$��36��$��10,498,10,0q�$	��Top=�$ Repeat=�	  -   $ 	btnEFCore��$&�� EntityFreamworkCore With Traking��$��1��$��36��$��10,172,10,0q�$	��Top=�$ Repeat=�	  -   $ btnEFCoerAsyn��$&�� EntityFreamworkCore As NoTraking��$��1��$��36��$��10,212,10,0q�$	��Top=�$ Repeat=�	  -   $ btnEFCoerCash��$%��EntityFreamworkCore (Singleton)��$��1��$��36��$��10,253,10,0q�$	��Top=�$ Repeat=��� -   $��txtTop��$��1��$
��Left=�$��34��$��	10,10,0,0q� �� TextWrapping$
 Wrap=�$��50000��$	��Top=�$	��210��$
��Bold"�$��Center=�$��Center=�