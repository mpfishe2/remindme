using Microsoft.AspNetCore.Mvc; 
using System.Text.Encodings.Web; 

namespace MvcMovie.Controllers { 
    public class HelloWorldController : Controller    
    { 
        string listOfTasks = ""; 
        string myList;
        // // GET: /HelloWorld/
        public string Index()         
        { 
            return "This is my default action..."; 
        } 
        // GET: /HelloWorld/AddTask/ 
        // Requires using System.Text.Encodings.Web; 
        public string AddTask(string task)         
        { 
            // sql action
            // sql("INSERT INTO TaskList VALUES({name}, {other parameters}))
            // listOfTasks = sql("SELECT * FROM TASKS")
            // ^^ above would need to be a list that could be displayed as like a list of bullet points
            // There has to be a HTMLEncoder way to do a list of things using <li> or something
            // return HtmlEncoder.Default.Encode($"Here is the list of tasks: {listOfTasks}")
            myList = GetTasks(task);
            return HtmlEncoder.Default.Encode($"Here are your tasks \n{task}");         
            
        }
        public string GetTasks(string TaskName) {
            listOfTasks += TaskName;
            return listOfTasks;
        }    
    } 
} 