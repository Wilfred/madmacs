define((require) ->
  lex = (string) ->
    tokens = []
    
    comments = /^;.*(\n|$)/
    numbers = /^[0-9]+/
    whitespace = /^\s+/
    while string.length
      numberMatch = numbers.exec(string)
      whitespaceMatch = whitespace.exec(string)
      commentsMatch = comments.exec(string)

      if numberMatch != null
        token = numberMatch[0]
        tokens.push(token)
        string = string.slice(token.length)
      else if whitespaceMatch != null
        # throw it away
        token = whitespaceMatch[0]
        string = string.slice(token.length)
      else if commentsMatch != null
        # throw it away
        token = commentsMatch[0]
        string = string.slice(token.length)
      else
        # todo: error if there's unlexed text
        break

    tokens

  return {"lex": lex}
)
