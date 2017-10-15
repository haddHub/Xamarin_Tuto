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

# 4.Images

- Deux types de sources. Les images shared (background etc...) et les platform spécifique (icon, splash screen...).
- Aspect de l'image. Fill Fit etc...

IMAGES DOWNLOAD :
- De base une image est dl et stocke en cache pendant 24h. Pour désactiver ca, on est obligé de passer par le code behind.
- ActivityIndicator. Image a IsLoading

EMBEDDED IMAGE :
- Changer dans les proprietes : Ressource incorporée
- De base on ne peut pas utiliser une ressource incorporée en XAML. Code behind ou custom markup (fait dans l'exemple).

PLATFORM SPECIFIC :
- Les platform on des conventions différentes.
- Les images platform spécifique sont appelée facilement. Image="clock.png" (si l'image est placée correctement en fonction de la convention)

# 5.Lists

- SeparatorVisiblity et Color
- ItemTemplate -> DataTemplate -> TextCell ou ImageCell, sont les tempaltes de base
- ""                 ""           ViewCell, est le custom template dans lequel on peut mettre n'importe quel layout
- HasUnevenRows
- Groupeage disponible grace au GroupDisplayBinding et la creation d'une classe spécifique qui hérite de List<X>.
- ItemTapped : Le tapped peut etre activé a chaque fois qu'on tap un item mais si il est deja seclectionné 
- ItemSelected : Item selectionné n'apparait que si l'item n'est pas encore selectionné
- Pour désactiver la séléction : Dans le ItemSelected mettre list.SelectedItem = null et ne pas gere le tapped event.

CONTEXT ACTION :
- <ContextAction> prop dans la quelle on peut mettre des MenuItem avec le clicked event a gerer.
- IsDestructive true pour faire apparaitre l'item en rouge
- CommandParameter="{Binding .}" pour passer du menu item au "contact".
- OBSERVABLECOLLECTION

PULL REFRESH :
- IsPullToRefreshEnabled à true et gerer l'event Refreshing
- A la fin de l'event call EndRefresh sur la listView

SHEARCH BAR :
- TextChangedEvent ou ButtonPressed.
- Filtrer la liste en fonction du text recu et l'appliquer a mon ItemsSource

# 6.Navigation

HIERARCHICAL NAVIGATION
- Fonctionne sur un system de stack. Les page sont empillée les une sur les autre et on peut revenir de 1 en arrière.
- Navigation.PushAsync pour naviger vers une autre page
- Navigation.PopAsync pour revenir une page en arrière.
- Dans app.xaml, la main page doit etre l'argument d'une NavigationPage. MainPage = new NavigationPage(new MyPage());
- Pour cacher la barre de navigation : NavigationPage.HasNavigationBar="False"
- Pour changer la couleur de la barre, c'est dans le app.xaml.cs au moment de l'init de MainPage. NavigationPage a des prop

MODAL PAGE
- N'affiche pas la barre de navigation pour forcer l'utilisateur a faire une action sur la page.
- Remplacer le PushAsync par PushModalAsync
- PopModalAsync
- Overrider le OnBackButtonPressed event pour forcer a utiliser notre boutton.

MASTER DETAILS
- Gerer l'event de selection d'item et pushAsync vers la page de details.
- Passer a la page de detial le contact
