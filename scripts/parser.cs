define((require) ->
  lexer = require "lexer"
  
  parseTokensFrom = (tokens, from) ->
    # parse an array of tokens, starting at index FROM
    sexps = []

    # fixme: doesn't check parens are balanced
    i = from
    while i < tokens.length
      token = tokens[i]

      if token == "("
        parseResult = parseTokensFrom(tokens, i + 1)
        sexps.push(parseResult.sexp)
        i = parseResult.endIndex + 1
      else if token == ")"
        return {"sexp": sexps, "endIndex": i}
      else
        sexps.push(token)
        i += 1

    return {"sexp": sexps, "endIndex": i}

  parseTokens = (tokens) ->
    parseResult = parseTokensFrom(tokens, 0)
    parseResult.sexp

  parse = (string) ->
    tokens = lexer.lex(string)
    parseTokens(tokens)

  return {"parse": parse}
)
