using BusinessObject.DtoModels;
using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Custom_Activities
{
    public class CreateBookmark : NativeActivity<Game>
    {

        [RequiredArgument]
        public InArgument<string> BookmarkName { get; set; }

        protected override void Execute(NativeActivityContext context)
        {
            var GAME  = BookmarkName.Get(context);

            //Create a bookmark and wait for it to be resumed.
            context.CreateBookmark(GAME, new BookmarkCallback(OnResumeBookmark));
        }

        protected override bool CanInduceIdle
        {
            get { return true; }
        }

        public void OnResumeBookmark(NativeActivityContext context, Bookmark bookmark, object obj)
        {
            //When the bookmark is resumed, assign its value 
            Result.Set(context, ((Game)obj));
        }
    }
}
