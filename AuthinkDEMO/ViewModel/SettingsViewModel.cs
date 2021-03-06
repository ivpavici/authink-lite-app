using System.ComponentModel;

using AuthinkDEMO.Services;
using AuthinkDEMO.Views;

using GalaSoft.MvvmLight;

using GalaSoft.MvvmLight.Command;
using Windows.Storage;
using AuthinkDEMO.Settings.Language;

namespace AuthinkDEMO.ViewModel
{
    public partial class SettingsViewModel : ViewModelBase
    {
        public RelayCommand<string> ChangeLanguage { get; private set; }
        private void LanguageSelectionChange(string language_abbreviation)
        {
            ApplicationData.Current.LocalSettings.Values["Language"] = language_abbreviation;

            this.EnglishLanguage                     = Language.SettingsPage.Language.English();
            this.CroatianLanguage                    = Language.SettingsPage.Language.Croatian();
            this.SettingsText                        = Language.SettingsPage.SettingsText();
            this.BackButtonContent                   = Language.SettingsPage.BackButtonContent();
            this.ChooseLangText                      = Language.SettingsPage.ChooseLanText();
            this.RewardSoundButtonContent_off        = Language.SettingsPage.SoundButtonContent_off();
            this.RewardSoundButtonContent_on         = Language.SettingsPage.SoundButtonContent_on();
            this.RewardSoundText                     = Language.SettingsPage.RewardSoundText();
            this.InstructionsSoundText               = Language.SettingsPage.InstructionSoundText();
            this.InstructionsSoundButtonContent_on   = Language.SettingsPage.SoundButtonContent_on();
            this.InstructionsSoundButtonContent_off  = Language.SettingsPage.SoundButtonContent_off();
        }

        public RelayCommand<string> ToggleRewardSoundEnableCommand { get; private set; }
        private void ToggleRewardSoundEnable(string isEnabled)
        {
            if(isEnabled =="true")
            {
                ApplicationData.Current.LocalSettings.Values["IsRewardSoundEnabled"] = true;
            }
            else
            {
                ApplicationData.Current.LocalSettings.Values["IsRewardSoundEnabled"] = false;
            }
        }

        public RelayCommand<string> ToggleInstructionSoundEnableCommand { get; private set; }
        private void ToggleInstructionSoundEnable(string isEnabled)
        {
            if (isEnabled == "true")
            {
                ApplicationData.Current.LocalSettings.Values["IsInstructionSoundEnabled"] = true;
            }
            else
            {
                ApplicationData.Current.LocalSettings.Values["IsInstructionSoundEnabled"] = false;
            }
        }

        public string CroatianLanguage
        {
            get { return _croatianLanguage; }
            set
            {
                if (_croatianLanguage == value)
                {
                    return;
                }

                _croatianLanguage = value;
                this.RaisePropertyChanged("CroatianLanguage");
            }
        }
        private string _croatianLanguage = Language.SettingsPage.Language.Croatian();
        public string EnglishLanguage
        {
            get { return _englishLanguage; }
            set
            {
                if (_englishLanguage == value)
                {
                    return;
                }

                _englishLanguage = value;
                this.RaisePropertyChanged("EnglishLanguage");
            }
        }
        private string _englishLanguage = Language.SettingsPage.Language.English();
        public string ChooseLangText
        {
            get { return _chooseLangText; }
            set
            {
                if (_chooseLangText == value)
                {
                    return;
                }

                _chooseLangText = value;
                this.RaisePropertyChanged("ChooseLangText");
            }
        }
        private string _chooseLangText = Language.SettingsPage.ChooseLanText();

        public string SettingsText
        {
            get { return _settingsText; }
            set
            {
                if (_settingsText == value)
                {
                    return;
                }

                _settingsText = value;
                this.RaisePropertyChanged("SettingsText");
            }
        }
        private string _settingsText = Language.SettingsPage.SettingsText();

        public string RewardSoundText
        {
            get { return _rewardSoundText; }
            set
            {
                if (_rewardSoundText == value)
                {
                    return;
                }

                _rewardSoundText = value;
                this.RaisePropertyChanged("RewardSoundText");
            }
        }
        private string _rewardSoundText = Language.SettingsPage.RewardSoundText();

        public string InstructionsSoundText
        {
            get { return _instructionsSoundText; }
            set
            {
                if (_instructionsSoundText == value)
                {
                    return;
                }

                _instructionsSoundText = value;
                this.RaisePropertyChanged("InstructionsSoundText");
            }
        }
        private string _instructionsSoundText = Language.SettingsPage.InstructionSoundText();

        public string RewardSoundButtonContent_on
        {
            get { return _rewardSoundButtonContent_on; }
            set
            {
                if (_rewardSoundButtonContent_on == value)
                {
                    return;
                }

                _rewardSoundButtonContent_on = value;
                this.RaisePropertyChanged("RewardSoundButtonContent_on");
            }
        }
        private string _rewardSoundButtonContent_on = Language.SettingsPage.SoundButtonContent_on();
        public string RewardSoundButtonContent_off
        {
            get { return _rewardSoundButtonContent_Off; }
            set
            {
                if (_rewardSoundButtonContent_Off == value)
                {
                    return;
                }

                _rewardSoundButtonContent_Off = value;
                this.RaisePropertyChanged("RewardSoundButtonContent_off");
            }
        }
        private string _rewardSoundButtonContent_Off = Language.SettingsPage.SoundButtonContent_off();

        public string InstructionsSoundButtonContent_on
        {
            get { return _instructionsSoundButtonContent_on; }
            set
            {
                if (_instructionsSoundButtonContent_on == value)
                {
                    return;
                }

                _instructionsSoundButtonContent_on = value;
                this.RaisePropertyChanged("InstructionsSoundButtonContent_on");
            }
        }
        private string _instructionsSoundButtonContent_on = Language.SettingsPage.SoundButtonContent_on();
        public string InstructionsSoundButtonContent_off
        {
            get { return _instructionsSoundButtonContent_off; }
            set
            {
                if (_instructionsSoundButtonContent_off == value)
                {
                    return;
                }

                _instructionsSoundButtonContent_off= value;
                this.RaisePropertyChanged("InstructionsSoundButtonContent_off");
            }
        }
        private string _instructionsSoundButtonContent_off = Language.SettingsPage.SoundButtonContent_off();

        public RelayCommand BackCommand { get; private set; }
        private void Back()
        {
            _navigationService.NavigateTo(typeof(MainPage));
        }

        public string BackButtonContent
        {
            get { return _backButtonContent; }
            set
            {
                if (_backButtonContent == value)
                {
                    return;
                }

                _backButtonContent = value;
                this.RaisePropertyChanged("BackButtonContent");
            }
        }
        private string _backButtonContent = Language.SettingsPage.BackButtonContent();

    }

    public partial class SettingsViewModel
    {
        private readonly NavigationService _navigationService;

        public SettingsViewModel
        (
            NavigationService navigationService
        )
        {
            _navigationService = navigationService;

            this.ChangeLanguage                      = new RelayCommand<string>(LanguageSelectionChange);
            this.ToggleRewardSoundEnableCommand      = new RelayCommand<string>(ToggleRewardSoundEnable);
            this.ToggleInstructionSoundEnableCommand = new RelayCommand<string>(ToggleInstructionSoundEnable);
            this.BackCommand                         = new RelayCommand(Back);

        }
    }
}