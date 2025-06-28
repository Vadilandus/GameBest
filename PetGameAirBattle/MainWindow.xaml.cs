using PetGameAirBattle.Models;
using System.Numerics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace PetGameAirBattle
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        private List<BaseObject> gameObjects = new List<BaseObject>();
        private DispatcherTimer gameTimer;

        public MainWindow()
        {
            InitializeComponent();
            InitializeGame();
            StartGame();
        }

        private void InitializeGame()
        {
            // Здесь впоследствии буду расписывать нужные модели
            // всех необходимых сущностей)
            // Создаем игрока
            var player = new PlayerObject
            {
                X = 100,
                Y = 100,
                Width = 50,
                Height = 50
            };
            gameObjects.Add(player);
            // Можно добавить врагов и т.д.
        }
        private void StartGame()
        {
            // DispatcherTimer - это некий "таймер", задающий время, с которым обновляются события в WPF.
            gameTimer = new DispatcherTimer
            {
                Interval = TimeSpan.FromMilliseconds(16) // примерно 60 FPS
            };
            gameTimer.Tick += GameLoop;
            gameTimer.Start();
        }

        // Игровая логика)
        private void GameLoop(object? sender, EventArgs e)
        {
            // Очищаем Canvas от предыдущих элементов? 
            // Нет, потому что мы не создаем новые элементы, а обновляем существующие.
            // Очищаем Canvas, но осторожно: если мы удалим все дочерние элементы, то нам придется пересоздавать UiElement для каждого объекта.
            // Вместо этого мы не будем очищать Canvas, а будем обновлять позиции существующих элементов.
            // Обновляем состояние игровых объектов (например, перемещение)
            foreach (var gameObject in gameObjects)
            {
                // Здесь может быть логика перемещения
                gameObject.X += 1;
                // Затем отрисовываем
                gameObject.Draw(GameCanvas); // gameCanvas - это имя нашего Canvas в XAML
            }
        }
    }
}