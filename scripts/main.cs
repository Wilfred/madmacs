define((require) ->

  writeToMinibuffer = (message) ->
    minibuffer = document.getElementById "minibuffer"
    minibuffer.textContent = message
    
  writeToMinibuffer "hello world!"
)