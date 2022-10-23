using ClientApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.Stores
{
    public class NavigationStore
    {
        private Avalonia.Controls.Window CurrentView;

        public NavigationStore()
        {

        }


        public NavigationStore(Avalonia.Controls.Window currentView)
        {
            CurrentView = currentView;
        }

        public void update(Avalonia.Controls.Window vmb)
        {
            CurrentView.Close();
            CurrentView = vmb;
        }
        public void setCV(Avalonia.Controls.Window cv)
        {
            CurrentView = cv;
        }
        public Avalonia.Controls.Window getCurrentViewModel()
        {
            return CurrentView;
        }
    }
}
