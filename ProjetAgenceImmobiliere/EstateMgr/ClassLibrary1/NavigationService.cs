using EstateMgrCore.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;


namespace EstateMgrCore
{
        public static class NavigationService
        {
            public static string ContextPropertyName = "DataContext";

            private static Dictionary<Type, object> _viewsCache =
                new Dictionary<Type, object>();
            private static Dictionary<Type, BaseNotifyPropertyChanged> _viewModelsCache =
                new Dictionary<Type, BaseNotifyPropertyChanged>();

            private static TViewModel GetViewModelInstance<TViewModel>(params object[] viewModelParameters)
                where TViewModel : BaseNotifyPropertyChanged
            {
                return (TViewModel)GetViewModelInstance(typeof(TViewModel), viewModelParameters);
            }
            private static object GetViewModelInstance(Type tViewModel, params object[] viewModelParameters)
            {
                object vm = null;
                if (_viewModelsCache.ContainsKey(tViewModel))
                    vm = _viewModelsCache[tViewModel];
                else
                {
                    vm = Activator.CreateInstance(tViewModel, viewModelParameters);
                    _viewModelsCache[tViewModel] = (BaseNotifyPropertyChanged)vm;
                }
                return vm;
            }

            private static TView GetViewInstance<TView>(object viewModel)
                where TView : class
            {
                return (TView)GetViewInstance(typeof(TView), viewModel);
            }
            private static object GetViewInstance(Type tView, object viewModel)
            {
                object view = null;
                bool isWindow = tView.BaseType.Name == "Window";
                if (!isWindow && _viewsCache.ContainsKey(tView))
                    view = _viewsCache[tView];
                else
                {
                    view = Activator.CreateInstance(tView);
                    var prop = tView.GetProperty(ContextPropertyName);
                    prop?.SetValue(view, viewModel);
                    if (!isWindow)
                        _viewsCache[tView] = view;
                }
                return view;
            }

            public static TView GetView<TView, TViewModel>(params object[] viewModelParameters)
                where TView : class
                where TViewModel : BaseNotifyPropertyChanged
            {
                return GetViewInstance<TView>(
                    GetViewModelInstance<TViewModel>(viewModelParameters));
            }
            public static object GetView<TViewModel>(Type tView, params object[] viewModelParameters)
                where TViewModel : BaseNotifyPropertyChanged
            {
                return GetViewInstance(
                    tView,
                    GetViewModelInstance<TViewModel>(viewModelParameters));
            }
            public static object GetView(Type tView, Type tViewModel, params object[] viewModelParameters)
            {
                return GetViewInstance(
                    tView,
                    GetViewModelInstance(tViewModel, viewModelParameters));
            }

            public static void Show<TView, TViewModel>(params object[] viewModelParameters)
                where TView : class
                where TViewModel : BaseNotifyPropertyChanged
            {
                var win = GetViewInstance<TView>(
                    GetViewModelInstance<TViewModel>(viewModelParameters));

                var method = win.GetType().GetMethod("Show");
                method?.Invoke(win, null);
            }
            public static void Show<TViewModel>(Type tView, params object[] viewModelParameters)
                where TViewModel : BaseNotifyPropertyChanged
            {
                var win = GetViewInstance(
                    tView,
                    GetViewModelInstance<TViewModel>(viewModelParameters));

                var method = win.GetType().GetMethod("Show");
                method?.Invoke(win, null);
            }
            public static void Show(Type tView, Type tViewModel, params object[] viewModelParameters)
            {
                var win = GetViewInstance(
                    tView,
                    GetViewModelInstance(tViewModel, viewModelParameters));

                var method = win.GetType().GetMethod("Show");
                method?.Invoke(win, null);
            }

            public static bool? ShowDialog<TView, TViewModel>(params object[] viewModelParameters)
                where TView : class
                where TViewModel : BaseNotifyPropertyChanged
            {
                var win = GetViewInstance<TView>(
                    GetViewModelInstance<TViewModel>(viewModelParameters));

                var method = win.GetType().GetMethod("ShowDialog");
                return (bool?)method?.Invoke(win, null);
            }
            public static bool? ShowDialog<TViewModel>(Type tView, params object[] viewModelParameters)
                where TViewModel : BaseNotifyPropertyChanged
            {
                var win = GetViewInstance(
                    tView,
                    GetViewModelInstance<TViewModel>(viewModelParameters));

                var method = win.GetType().GetMethod("ShowDialog");
                return (bool?)method?.Invoke(win, null);
            }
            public static bool? ShowDialog(Type tView, Type tViewModel, params object[] viewModelParameters)
            {
                var win = GetViewInstance(
                    tView,
                    GetViewModelInstance(tViewModel, viewModelParameters));

                var method = win.GetType().GetMethod("ShowDialog");
                return (bool?)method?.Invoke(win, null);
            }
        public static bool? ShowDialog(Type tView, BaseNotifyPropertyChanged vm)
        {
            var win = GetViewInstance(
                tView,
                vm);

            var method = win.GetType().GetMethod("ShowDialog");
            return (bool?)method?.Invoke(win, null);
        }

        public static void Close(object view, bool? result = null)
            {
                if (result != null)
                {
                    var property = view.GetType().GetProperty("DialogResult");
                    property?.SetValue(view, result);
                }
                var method = view.GetType().GetMethod("Close");
                method?.Invoke(view, null);
            }

            public static bool? GetResult(object view)
            {
                var property = view.GetType().GetProperty("DialogResult");
                return (bool?)property?.GetValue(view);
            }


        }
    }
