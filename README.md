# MyToolKit.MVVM
## 使用 

引入 dll 文件

## 命令的使用

###  1.不带泛型的使用

``` csharp 
public RelayCommand TestCommand { get; }
public MainWindowViewModel
{
    TestCommad = new RelayCommand(Method);
}
```



### 2. 带泛型的使用

```csharp
public RelayCommand<string> TestCommand { get; }
public MainWindowViewModel
{
    TestCommad = new RelayCommand<string>(Method);
}
private void Method(string str)
{
    // 逻辑代码
}
```

## ObservableObject的使用

```csharp
public class Model : ObservableObject
{
    private string _str;
    public string Str
    {
        get => _str;
        set
        {
            _str = value;
            OnPropertyChanged();
        }
    }
}
```

## ViewModelBase的使用

``` c#
public class IndexControlViewModel : ViewModelBase
{
    public IndexControlViewModel()
    {
        AppName = "My Tool";
    }
    
    private string? _appName;
    public string? AppName
    {
        get => _appName;
        set
        {
            _appName = value;
            OnPropertyChanged();
        }
    }
}
```



