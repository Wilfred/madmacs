define((require) ->

  writeToMinibuffer = (message) ->
    minibuffer = document.getElementById "minibuffer"
    minibuffer.textContent = message

  evalButton = document.getElementById "eval"
  evalButton.addEventListener('click', () ->
    writeToMinibuffer "hello again world"
  false)
)