using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Templated Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234235

namespace AuthinkDEMO.Controls
{
    public sealed class DropPlaceholder : Button
    {
        public DropPlaceholder()
        {
            this.DefaultStyleKey = typeof (DropPlaceholder);
        }


        public object ExpectedPairId
        {
            get { return (object) GetValue(ExpectedPairIdProperty); }
            set { SetValue(ExpectedPairIdProperty, value); }
        }

        public static readonly DependencyProperty ExpectedPairIdProperty =
            DependencyProperty.Register("ExpectedPairId", typeof (object), typeof (DropPlaceholder),
                                        new PropertyMetadata(null));

        public bool IsFull { get; private set; }

        public delegate void DropSuccessful(object sender, EventArgs e);
        public event DropSuccessful OnDropSuccessful;

        private void _OnDropSuccessful()
        {
            if (this.OnDropSuccessful != null)
            {
                this.OnDropSuccessful.Invoke(this, EventArgs.Empty);
            }
        }

        public bool DropElement(object draggableElementContent)
        {
            if (!this.IsFull)
            {
                this.Content = draggableElementContent;

                this.IsFull = true;

                _OnDropSuccessful();

                return true;
            }

            return false;
        }
    }
}
