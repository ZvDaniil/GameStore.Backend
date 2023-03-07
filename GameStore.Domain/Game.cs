namespace GameStore.Domain;

internal class Game
{
    public int Id { get; set; } // уникальный идентификатор игры
    public string Title { get; set; } // название игры
    public string Description { get; set; } // описание игры
    public decimal Price { get; set; } // цена игры
    public DateTime ReleaseDate { get; set; } // дата выпуска игры
    public int Rating { get; set; } // рейтинг игры
    public int NumberOfPlayers { get; set; } // количество игроков
    public Platform Platform { get; set; } // платформа, на которой работает игра
    public Genre Genre { get; set; } // жанр игры
    public Developer Developer { get; set; } // разработчик игры
    public Publisher Publisher { get; set; } // издатель игры
}
