using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inheritancedemo.obj
{
   
    public class ImagePost:Post
    {
         public string ImageURL {get;set;}
    public ImagePost(){
this.ID = 0;
this.Title= "";
this.SendByUsername="";
this.IsPublic =false;
this.ImageURL = ImageURL;
    }
    public ImagePost(string title,string sendByUsername,string ImageURL,bool isPublic){
        this.ID =GetNextID();
        this.Title = title;
        this.SendByUsername = sendByUsername;
        this.IsPublic = isPublic;
        this.ImageURL = ImageURL;
    }

    public override string ToString(){
        return string.Format("{0} - {1} - {2} - by {3}",this.ID,this.Title,this.ImageURL,this.SendByUsername);
    }
        
    }
}