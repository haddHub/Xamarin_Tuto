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
