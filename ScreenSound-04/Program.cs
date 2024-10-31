using (HttpClient client = new HttpClient())
{
    client.Timeout = TimeSpan.FromMinutes(3);
    string resposta = await client.GetStringAsync("https://joffredias.github.io/api-csharp-songs/");

    ///////
    ///////
    Console.WriteLine(resposta);
}
