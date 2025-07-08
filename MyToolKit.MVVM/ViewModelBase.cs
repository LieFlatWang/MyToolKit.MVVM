using Study.Client.Common;

namespace MyToolKit.MVVM;

public class ViewModelBase<T> : ObservableObject where T : class
{

    private static T _instance;

    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = ServiceLocator.GetService<T>();
            }
            return _instance;
        }
    }

}