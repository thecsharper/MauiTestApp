namespace MauiTestApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }


        private void OnCounterEntryCompleted(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        // From: https://www.telerik.com/blogs/beyond-basics-getting-started-media-picker-net-maui
        private async void TakePhoto(object sender, EventArgs e)
        {
            var photo = await MediaPicker.Default.PickPhotoAsync(new MediaPickerOptions
            {
                Title = "Select your photo"
            });

            if (photo != null)
            {
                // Getting the file result information
                using Stream sourceStream = await photo.OpenReadAsync();

                // Saving the file in your local storage
                string localFilePath = Path.Combine(FileSystem.CacheDirectory, photo.FileName);

                await sourceStream.CopyToAsync(File.OpenWrite(localFilePath));
            }
        }
    }
}
