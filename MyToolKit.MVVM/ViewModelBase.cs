namespace MyToolKit.MVVM;

public class ViewModelBase : ObservableObject
{
    private static ViewModelBase? _instance;
    private static readonly object Lock = new object();

    public static ViewModelBase Instance
    {
        get
        {
            // First check outside of the lock
            if (_instance == null)
            {
                lock (Lock)
                {
                    // Second check inside the lock to ensure only one instance is created
                    if (_instance == null)
                    {
                        _instance = new ViewModelBase();
                    }
                }
            }
            return _instance;
        }
    }
}