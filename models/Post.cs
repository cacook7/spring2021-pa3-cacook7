using spring2021_pa3_cacook7.Database;
using spring2021_pa3_cacook7.Interfaces;

namespace spring2021_pa3_cacook7.models
{
    public class Post
    {
        public int Id{get; set;}
        public string Text{get; set;}

        public string Date{get; set;}

        public ISavePost Save {get; set;}

        public Post()
        {
            Save = new SavePost();
        }

        public override string ToString()
        {
            return Text + " created on " + Date;
        }

    }
}