using AutoTrade.Model.Views;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
namespace AutoTrade.ViewModel.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}
        }
        protected string LastType { get; set; } = "Red.xaml";
        private RelayCommand<string> _switchSkinCmd;
        public RelayCommand<string> SwitchSkinCommand
        {
            get
            {
                if (_switchSkinCmd == null)
                {
                    _switchSkinCmd = new RelayCommand<string>(type =>
                    {
                        var lastDic = Application.Current.Resources.MergedDictionaries.Where(dic => dic.Source.ToString().Contains(LastType)).LastOrDefault();
                        if (lastDic != null)
                        {
                            Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary() { Source = new System.Uri(string.Format(@"pack://application:,,,/MahApps.Metro;component/Styles/Accents/{0}", type),System.UriKind.RelativeOrAbsolute) });
                            Application.Current.Resources.MergedDictionaries.Remove(lastDic);
                            LastType = type;
                        }
                    });
                }
                return _switchSkinCmd;
            }
        }
    }
}