?using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Reflection;
using System;
public class State : IStateMachine {
	StateMachine machine;

	public State(StateMachine Machine)
	{
		machine = Machine;
	}

	public void UpdateState ()
	{
		if (something) {ToNextState();}

	}

	public void ToNextState ()
	{
		machine.currentState = (IStateMachine)Activator.CreateInstance(typeof(StateName),new object[]{machine});
	}
