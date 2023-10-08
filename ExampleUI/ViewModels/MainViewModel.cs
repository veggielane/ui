using DynamicData;
using ReactiveUI;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Xml.Linq;

namespace ExampleUI.ViewModels;

public class MainViewModel : ViewModelBase, INotifyPropertyChanged
{
    public string Greeting => "Welcome to Avalonia!";

    public ObservableCollection<Node> Nodes { get; }

    private Node _selectedNode;

    public Node SelectedNode
    {
        get => _selectedNode;
        set => this.RaiseAndSetIfChanged(ref _selectedNode, value);
    }

 
    public MainViewModel()
    {
        Nodes = new ObservableCollection<Node>
        {
            new Node("Lion"), new Node("Cat"), new Node("Zebra")
        };

        SelectedNode = Nodes.First();
    }
}

public class Node
{

    public string Title { get; }

    public string Description { get; }

    public Node(string title)
    {
        Title = title;
        Description = title + title;
    }
}
