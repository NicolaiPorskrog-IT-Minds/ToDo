using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace ToDo
{
    public class LoginPage : ContentPage
    {
        private LoginViewModel _viewModel;
        public LoginPage()
        {
            _viewModel = new LoginViewModel();
            BindingContext = _viewModel;
            Title = "ToDo";
            Padding = new Thickness(10,0,10,0);
            Content = MainView();
        }

        private StackLayout MainView()
        {
            var layout = new StackLayout
            {
                Padding = new Thickness(0,25,0,0),
                Spacing = 25
            };

            var toDoLabel = new Label
            {
                Text = "ToDo",
                HorizontalOptions = LayoutOptions.Center,
                TextColor = Color.Black,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof (Label))
            };
            var usernameEntry = new RoundCornerEntry
            {
                Placeholder = "Username",
                HorizontalOptions = LayoutOptions.Fill,
            };
            usernameEntry.SetBinding(Entry.TextProperty, LoginViewModel.UsernameProperty);

            var passwordEntry = new RoundCornerEntry
            {
                Placeholder = "Password",
                HorizontalOptions = LayoutOptions.Fill,
                BackgroundColor = Color.White
            };
            passwordEntry.SetBinding(Entry.TextProperty, LoginViewModel.PasswordProperty);

            var loginButton = new Button
            {
                HorizontalOptions = LayoutOptions.Fill,
                BackgroundColor = Color.Black,
                TextColor = Color.White,
                Text = "Login"
            };

            loginButton.Clicked += (sender, args) =>
            {
                var validated = _viewModel.ValidateCredentials();
                if (validated)
                {
                    Navigation.PushAsync(new ToDoListPage());
                }
            };
                
            layout.Children.Add(toDoLabel);
            layout.Children.Add(usernameEntry);
            layout.Children.Add(passwordEntry);
            layout.Children.Add(loginButton);

            return layout;
        }
    }
}
