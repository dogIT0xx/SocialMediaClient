using Telerik.SvgIcons;

namespace SocialMediaClient.Layout;

public partial class NavMenu
{
    private List<MenuItem> MenuItems { get; set; }

    private class MenuItem
    {
        public string Text { get; set; }
        public ISvgIcon Icon { get; set; }
        public string Url { get; set; }
        public List<MenuItem> Items { get; set; }
    }

    protected override void OnInitialized()
    {
        MenuItems = new List<MenuItem>()
        {
            new ()
            {
                Text = "Home",
                Icon = SvgIcon.Home,
                Url = navManager.BaseUri + "Home"
            },
            new ()
            {
                Text = "Popular",
                Icon = SvgIcon.ArrowUp,
                Url = "https://maps.google.com"
            },
            new ()
            {
                Text = "All",
                Icon = SvgIcon.RedditBox,
                Url = "https://maps.google.com"
            },
            new ()
            {
                Text = "Communities",
                Icon = SvgIcon.Group,
                Items = new List<MenuItem>()
                {
                    new ()
                    {
                        Text = "FaceBook",
                        Icon = SvgIcon.Facebook,
                        Url = "https://facebook.com"
                    },
                    new ()
                    {
                        Text = "LinkedIn",
                        Icon = SvgIcon.Linkedin,
                        Url = "https://linkedin.com"
                    },
                    new ()
                    {
                        Text = "Twitter",
                        Icon = SvgIcon.Twitter,
                        Url = "https://twitter.com"
                    },
                }
            },
            new ()
            {
                Text = "Resources",
                Icon = SvgIcon.Group,
                Items = new List<MenuItem>()
                {
                    new ()
                    {
                        Text = "Abound Reddit",
                        Icon = SvgIcon.Facebook,
                        Url = "https://facebook.com"
                    },
                    new ()
                    {
                        Text = "Advertise",
                        Icon = SvgIcon.Linkedin,
                        Url = "https://linkedin.com"
                    },
                    new ()
                    {
                        Text = "Help",
                        Icon = SvgIcon.Twitter,
                        Url = "https://twitter.com"
                    },
                }
            }
        };

        base.OnInitialized();
    }
}