using System.Collections.Generic;
using System.Linq;

namespace TestScroll.ViewModels;

public class MainViewModel : ViewModelBase
{
    public List<string> Items { get; } = new();

    public MainViewModel()
    {
        Items.AddRange(Enumerable.Range(0, 100).Select(i => i.ToString()));
    }
}
