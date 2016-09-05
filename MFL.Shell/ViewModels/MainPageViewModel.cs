using MFL.Integration.MyFantasyLeague.Retrieve;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFL.Shell.ViewModels
{
    public class MainPageViewModel : NotificationObject
    {
        public MainPageViewModel()
        {
            GetPlayersCommand = new DelegateCommand(OnGetPlayers);
            
        }

        public DelegateCommand GetPlayersCommand { get; private set; }

        private string _result = "None";
        public string Result
        {
            get
            {
                RaisePropertyChanged(() => GetPlayersCommand);
                return _result;
            }
            private set
            {
                _result = value;
                RaisePropertyChanged(() => Result);
            }
        }

        private async void OnGetPlayers()
        {
            var result = (await MFLClientApi.GetPlayers(true));

            Result = result.First().Name;
        }
    }
}
