mergeInto(LibraryManager.library, {
  _insertAdjacentHTML: function (position, text) {
    var content = document.getElementsByClassName('webgl-content')[0]
    content.insertAdjacentHTML(Pointer_stringify(position), Pointer_stringify(text));
  },
});