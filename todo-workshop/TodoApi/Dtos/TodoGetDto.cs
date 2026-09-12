namespace TododApi.Dtos;

public record TodoGetDto(
    int Id,
    string Title,
    bool IsCompleted
);