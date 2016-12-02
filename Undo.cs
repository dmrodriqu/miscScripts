using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Undo : MonoBehaviour {

	Stack undoStack = new Stack();
	Stack redoStack = new Stack();

	public void setUndoScore ()
	{
		var fix = undoStack.Peek ();
		var scoreKeeper = gameObject.GetComponent<InputField>();
		scoreKeeper.text = fix;
		var popped = undoStack.Pop ();
		redoStack.Push (popped);
	}


	public void setRedoScore ()
	{
		var unfix = redoStack.Peek ();
		var unfixableScoreKeeper = gameObject.GetComponent<InputField>();
		unfixableScoreKeeper.text = unfix;
		var repopped = redoStack.Pop ();
		undoStack.Push (repopped);
	}
 }

