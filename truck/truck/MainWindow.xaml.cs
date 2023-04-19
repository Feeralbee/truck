using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace truck
{
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private readonly ThicknessAnimation _left_wheel_animation = new();
    private readonly ThicknessAnimation _rigth_wheel_animation = new();
    private readonly ThicknessAnimation _truck_animation = new();

    public MainWindow()
    {
        InitializeComponent();
    }

    private void SetupStartAnimationStartingPoint()
    {
        _left_wheel_animation.From = new Thickness(18, 16, 0, 0);
        _rigth_wheel_animation.From = new Thickness(73, 16, 0, 0);
        _truck_animation.From = new Thickness(18, 185, 0, 0);
    }

    private void SetupStartAnimationEndPoint()
    {
        _left_wheel_animation.To = new Thickness(642, 16, 0, 0);
        _rigth_wheel_animation.To = new Thickness(697, 16, 0, 0);
        _truck_animation.To = new Thickness(642, 185, 0, 0);
    }

    private void SetupStartAnimationDuration()
    {
        _left_wheel_animation.Duration = TimeSpan.FromSeconds(0.5);
        _rigth_wheel_animation.Duration = TimeSpan.FromSeconds(0.5);
        _truck_animation.Duration = TimeSpan.FromSeconds(0.5);
    }

    private void BeginAnimation()
    {
        left_wheel.BeginAnimation(MarginProperty, _left_wheel_animation);
        rigth_wheel.BeginAnimation(MarginProperty, _rigth_wheel_animation);
        truck.BeginAnimation(MarginProperty, _truck_animation);
    }

    public void StartButtonClick(object sender, RoutedEventArgs e)
    {
        SetupStartAnimationStartingPoint();
        SetupStartAnimationEndPoint();
        SetupStartAnimationDuration();
        BeginAnimation();
    }

    public void ClearButtonClick(object sender, RoutedEventArgs e)
    {
        SetupClearAnimationEndPoint();
        SetupClearAnimationDuration();
        BeginAnimation();
    }

    private void SetupClearAnimationEndPoint()
    {
        _left_wheel_animation.To = new Thickness(18, 16, 0, 0);
        _rigth_wheel_animation.To = new Thickness(73, 16, 0, 0);
        _truck_animation.To = new Thickness(18, 185, 0, 0);
    }

    private void SetupClearAnimationDuration()
    {
        _left_wheel_animation.Duration = TimeSpan.FromSeconds(0.01);
        _rigth_wheel_animation.Duration = TimeSpan.FromSeconds(0.01);
        _truck_animation.Duration = TimeSpan.FromSeconds(0.01);
    }
}
}
