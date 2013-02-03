define((require) ->
  lex = (string) ->
    tokens = []

    # the tokens we recognise
    symbol = /^[a-zA-Z*/+-]+/
    comments = /^;.*(\n|$)/
    numbers = /^[0-9]+/
    openParen = /^\(/
    closeParen = /^\)/
    whitespace = /^\s+/
    
    while string.length
      symbolMatch = symbol.exec(string)
      numberMatch = numbers.exec(string)
      openParenMatch = openParen.exec(string)
      closeParenMatch = closeParen.exec(string)
      whitespaceMatch = whitespace.exec(string)
      commentsMatch = comments.exec(string)

      if symbolMatch != null
        token = symbolMatch[0]
        tokens.push(token)
        string = string.slice(token.length)
      else if numberMatch != null
        token = numberMatch[0]
        tokens.push(token)
        string = string.slice(token.length)
      else if openParenMatch != null
        token = openParenMatch[0]
        tokens.push(token)
        string = string.slice(token.length)
      else if closeParenMatch != null
        token = closeParenMatch[0]
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
