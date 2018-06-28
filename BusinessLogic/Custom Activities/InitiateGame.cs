using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;
using BusinessObject.DtoModels;

namespace BusinessLogic.Custom_Activities
{

    public sealed class InitiateGame : NativeActivityContext<Game>
    {
        [RequiredArgument]
        public InArgument<string> BookmarkName { get; set; }

        protected override void Execute(NativeActivityContext context)
        {
            var guess = BookmarkName.Get(context);

            context.CreateBookmark(guess, new BookmarkCallback(OnResumeBookmark));

        }

        protected override bool CanInduceIdle
        {
            get { return true; }
        }

        public void OnResumeBookmark(NativeActivityContext context, Bookmark bookmark, object obj)
        {
            //When the bookmark is resumed, assign its value 
            Result.Set(context, ((ProcessRequest)obj));
        }
    }
}
