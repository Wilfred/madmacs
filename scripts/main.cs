define((require) ->
  parser = require "parser"

  writeToMinibuffer = (message) ->
    minibuffer = document.getElementById "minibuffer"
    minibuffer.textContent = message

  getFrameContent = () ->
    frame = document.getElementById "frame"
    frame.value

  evalButton = document.getElementById "eval"
  evalButton.addEventListener('click', () ->
    result = parser.parse(getFrameContent())
    writeToMinibuffer(result)
    console.log(result)
  false)
)