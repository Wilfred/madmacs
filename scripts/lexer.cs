define((require) ->
  lex = (string) ->
    tokens = []
    
    comments = /;.*(\n|$)/g
    string = string.replace(comments, "")

    numbers = /[0-9]+/
    while true
      match = numbers.exec(string)

      if match == null
        break
      else
        token = match[0]
        tokens.push(token)
        string = string.slice(token.length)

    tokens

  return {"lex": lex}
)
