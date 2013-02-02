define((require) ->
  lexer = require "lexer"

  writeToMinibuffer = (message) ->
    minibuffer = document.getElementById "minibuffer"
    minibuffer.textContent = message

  getFrameContent = () ->
    frame = document.getElementById "frame"
    frame.value

  evalButton = document.getElementById "eval"
  evalButton.addEventListener('click', () ->
    writeToMinibuffer(lexer.lex(getFrameContent()))
  false)
)