using System.Windows.Input;

namespace MyToolKit.MVVM;

public class RelayCommand<T> : ICommand
{
    private Action<T> _execute;
    
    public RelayCommand(Action<T> execute)
    {
        _execute = execute ?? throw new ArgumentNullException(nameof(execute));
    }
    
    public bool CanExecute(object? parameter)
    {
        return true;
    }

    public void Execute(object? parameter)
    {
        _execute((T)parameter!);
    }

    public event EventHandler? CanExecuteChanged;
}

public class RelayCommand : ICommand
{
    private Action<object> _execute;
    
    public RelayCommand(Action<object> execute)
    {
        _execute = execute ?? throw new ArgumentNullException(nameof(execute));
    }
    
    public bool CanExecute(object? parameter)
    {
        return true;
    }

    public void Execute(object? parameter)
    {
        _execute(parameter!);
    }

    public event EventHandler? CanExecuteChanged;
}