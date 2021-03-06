﻿using System.Collections.ObjectModel;
using Prism.Windows.Mvvm;
using Param_RootNamespace.Core.Models;
using Param_RootNamespace.Core.Services;

namespace Param_RootNamespace.ViewModels
{
    public class GridViewViewModel : ViewModelBase
    {
        private readonly ISampleDataService _sampleDataService;

        public GridViewViewModel(ISampleDataService sampleDataServiceInstance)
        {
            _sampleDataService = sampleDataServiceInstance;
        }

        public ObservableCollection<SampleOrder> Source => _sampleDataService.GetGridSampleData();
    }
}
