using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace AuthinkDEMO.Controls
{
    public sealed class DraggableElement : Button
    {
        public DraggableElement()
        {
            this.DefaultStyleKey = typeof(DraggableElement);
        }

        public object PairId
        {
            get { return (object)GetValue(PairIdProperty); }
            set { SetValue(PairIdProperty, value); }
        }
        public static readonly DependencyProperty PairIdProperty =
            DependencyProperty.Register("PairId", typeof(object), typeof(DraggableElement), new PropertyMetadata(null));
    }
}
