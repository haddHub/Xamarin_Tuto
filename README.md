# Xamarin_Tuto

# 2.XAML Essentials

BASES :
- Comme en wpf on ne peut pas avoir plusieur children du contenant page. Il faut les mettre dans un "StackLayout" ou autre
- :F2 pour afficher que deux décimale
- Binding comme en wpf. {Binding Source={x:Reference slider}, Path=Value}
- Utiliser le BindingContext pour eviter de toujours repeter l'objet reference et le path
- Le binding context est hérité par les children

PLATFORM DEPENDENT :
- Sur IOS les elements commence en haut de l'écran (passe sur l'heure etc...). Sur Android c'est en haut de la PAGE.
- Device.OS ou Device.OnPlatform (code behind)
- x:TypeArguments, OnPlatform

XAML COMPILATION :
- La compilation permet de : voir les erreur a la compil et non run time, reduir le poids, charger plus vite.
- Pour l'activer : [assembly: XamlCompilation(XamlCompilationOptions.Compile)] dans Prop -> assemblyInfo.cs

# 3.Layouts
STACKLAYOUT :
- Rien de nouveau.
GRID :
- De base la grid "fill" le container. Idem pour les elements dans une cellule.
- On peut modifier l'espace de base entre les lignes et colonne avec RowSpacing et ColumnSpacing.
- ColumnSpan ou RowSpan pour définir combien de ligne ou colonne l'éléménet va prendre.
- Grid.RowDefinition etc...
ABSOLUTELAYOUT :
- De base "fill" le container
- Plus de control sur le positionement, ou pour ancrer des element a certains endroit de l'écran.
RELATIVELAYOUT :
- On peut definir la position d'un élément par rapport a un autre

