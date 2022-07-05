# Description

Given a JSON object with an array of objects defined as:

```
{
    "BookAuthors": [
        {
            "BookTitle": "Title1",
            "Author": "Author1",
            "Genres": ["genre1", "genre2"]
        },
        {
            "BookTitle": "Title2",
            "Author": "Author1",
            "Genres": ["genre2", "genre3"]
        },
        ...
    ]
}
```

Aggregate the array by the author such that each object
represents a unique author with the books they have written
and the unique genres they have written in. For example:

```
[
    {
        "author": "Author1",
        "books": ["Title1", "Title2"],
        "genres": ["genre1", "genre2", "genre3"]
    },
    ...
]
```