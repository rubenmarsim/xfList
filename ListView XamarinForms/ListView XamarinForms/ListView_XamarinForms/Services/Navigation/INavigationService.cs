﻿using System;

namespace ListView_XamarinForms.Services.Navigation
{
    public interface INavigationService
    {
        void NavigateTo<TDestinationViewModel>(object navigationContext = null);

        void NavigateTo(Type destinationType, object navigationContext = null);

        void NavigateBack();
    }
}
