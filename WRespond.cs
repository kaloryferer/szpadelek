using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Szpadelek
{
    public class Embed 
    {
        public string type { get; set; }
        public string preview { get; set; }
        public string url { get; set; }
        public bool plus18 { get; set; }
        public string source { get; set; }
    }

    /// <summary>
    /// Klasa przechowuje odpowiedz z zawartoscia mikroblogu
    /// </summary>
    public class ResEntry 
    {
        public int id { get; set; }
        public string author { get; set; }
        public string author_avatar { get; set; }
        public string author_avatar_big { get; set; }
        public string author_avatar_med { get; set; }
        public string author_avatar_lo { get; set; }
        public int author_group { get; set; }
        public string author_sex { get; set; }
        public string date { get; set; }
        public string body { get; set; }
        public object source { get; set; }
        public string url { get; set; }
        public object receiver { get; set; }
        public object receiver_avatar { get; set; }
        public object receiver_avatar_big { get; set; }
        public object receiver_avatar_med { get; set; }
        public object receiver_avatar_lo { get; set; }
        public object receiver_group { get; set; }
        public object receiver_sex { get; set; }
        public List<object> comments { get; set; }
        public bool blocked { get; set; }
        public int vote_count { get; set; }
        public int user_vote { get; set; }
        public bool user_favorite { get; set; }
        public List<object> voters { get; set; }
        public string type { get; set; }
        public Embed embed { get; set; }
        public bool deleted { get; set; }
        public object violation_url { get; set; }
        public object can_comment { get; set; }
        public string app { get; set; }
        public int comment_count { get; set; }   

        //public event PropertyChangedEventHandler PropertyChanged;
}

    /// <summary>
    /// Klasa przechowuje odpowiedz z zawartoscia strony glownej
    /// </summary>
    public class ResLinks : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string tags { get; set; }
        public string url { get; set; }
        public string source_url { get; set; }

        private int Vote_count;
        public int vote_count 
        {
            get
            {
                return Vote_count;
            } 
            set
            {
                if(value != this.Vote_count)
                {
                    this.Vote_count = value;
                    NotifyPropertyChanged("vote_count");
                }
            }
             }
        public int comment_count { get; set; }
        public int report_count { get; set; }
        public int related_count { get; set; }
        public string date { get; set; }
        public string author { get; set; }
        public int author_group { get; set; }
        public string author_avatar { get; set; }
        public string author_avatar_big { get; set; }
        public string author_avatar_med { get; set; }
        public string author_avatar_lo { get; set; }
        public string author_sex { get; set; }
        public string type { get; set; }
        public string group { get; set; }
        public string preview { get; set; }
        public bool user_vote { get; set; }
        public bool user_favorite { get; set; }
        public bool user_observe { get; set; }
        public List<object> user_lists { get; set; }
        public bool plus18 { get; set; }
        public string status { get; set; }
        public bool can_vote { get; set; }
        public bool has_own_content { get; set; }
        public bool is_hot { get; set; }
        public string category { get; set; }
        public string category_name { get; set; }
        public object violation_url { get; set; }
        public object info { get; set; }
        public string app { get; set; }

        

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    public class ResLink : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        public class RootObject
        {
            public int id { get; set; }
            public string title { get; set; }
            public string description { get; set; }
            public string tags { get; set; }
            public string url { get; set; }
            public string source_url { get; set; }
            public int vote_count { get; set; }
            public int comment_count { get; set; }
            public int report_count { get; set; }
            public int related_count { get; set; }
            public string date { get; set; }
            public string author { get; set; }
            public int author_group { get; set; }
            public string author_avatar { get; set; }
            public string author_avatar_big { get; set; }
            public string author_avatar_med { get; set; }
            public string author_avatar_lo { get; set; }
            public string author_sex { get; set; }
            public string type { get; set; }
            public string group { get; set; }
            public string preview { get; set; }
            public bool user_vote { get; set; }
            public bool user_favorite { get; set; }
            public bool user_observe { get; set; }
            public List<object> user_lists { get; set; }
            public bool plus18 { get; set; }
            public string status { get; set; }
            public bool can_vote { get; set; }
            public bool has_own_content { get; set; }
            public bool is_hot { get; set; }
            public string category { get; set; }
            public string category_name { get; set; }
            public object violation_url { get; set; }
            public object info { get; set; }
            public object app { get; set; }
            public object own_content { get; set; }
        }

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
