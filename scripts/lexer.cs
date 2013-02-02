define((require) ->
  lex = (string) ->
    comments = /;.*(\n|$)/g
    string = string.replace(comments, "")

    string

  return {"lex": lex}
)
