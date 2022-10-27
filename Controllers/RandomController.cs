/*
Carlos Felipe
10/27/22
Magic 8 Ball - Endpoint
CODE: This program magically answers a yes or no question with a funny response
Peer review by Daniel Decoito: The api and the program both run well. I like the use of haveing a variable be entered to make it appear as if your asking the console a question. Everything works well dont forget the gitinogre 
*/

using Microsoft.AspNetCore.Mvc;

namespace FelipeCMagic8BallEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class RandomController : ControllerBase
{
    [HttpGet]
    [Route("{questiongoeshere}")]
    public string MagicResponse(string questiongoeshere){
        string[] responses = {"No way!", "Maybe...", "I wouldn't bet my left kidney on it", "In an alternate universe maybe","I would't bet on it", "That's a weird question...", "YES! YES! YES! ", "Try again", "Are you mad!? Of course not!!1!", "You can be a bit more creative :)", "Sure why not"};

        Random rnd = new Random();
        int index = rnd.Next(responses.Length);
        return responses[index];
    }
}
