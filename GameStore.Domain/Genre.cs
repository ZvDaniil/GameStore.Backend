namespace GameStore.Domain;

internal class Genre
{
    public int Id { get; set; } // уникальный идентификатор жанра
    public string Name { get; set; } // название жанра
    public string Description { get; set; } // описание жанра
}