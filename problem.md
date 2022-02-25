Given a JSON object with an array of objects defined as:

```
[
    {
        "BookTitle": title1,
        "Author": name,
        "Genres": [genre1, genre2]
    },
    {
        "BookTitle": title2,
        "Author": name,
        "Genres": [genre2, genre3]
    },
    ...
]
```

Aggregate the array by the author such that each object
represents a unique author with the books they have written
and the unique genres they have written in.

```
[
    {
        "author": name,
        "books": [title1, title2],
        "genres": [genre1, genre2, genre3]
    },
    ...
]
```