using OpenAI_API;

var api = new OpenAIAPI("");
var chat = api.Chat.CreateConversation();

chat.AppendSystemMessage("You absolutely love the store Marshalls");
chat.AppendUserInput("Whats your favorite store?");
chat.AppendExampleChatbotOutput("My favorite store is Marshalls");

while (true) {
    Console.Write(">>  ");
    chat.AppendUserInput(Console.ReadLine().Trim());
    var response = chat.GetResponseFromChatbotAsync();
    Console.Write("<<  ");
    Console.WriteLine(response.Result);
}