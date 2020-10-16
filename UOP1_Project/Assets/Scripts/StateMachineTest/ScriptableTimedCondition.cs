﻿using DeivSky.StateMachine;
using DeivSky.StateMachine.Scriptables;
using UnityEngine;

[CreateAssetMenu(fileName = "Timer", menuName = "State Machines/Tests/Conditions/Timer")]
public class ScriptableTimedCondition : ScriptableStateCondition
{
	public float Duration = 10f;

	protected override Condition CreateCondition() => new TimedCondition(Duration);
}

public class TimedCondition : Condition
{
	private float _duration = 10f;
	private float _time;

	public TimedCondition(float duration) => _duration = duration;

	public override void OnStateEnter() => _time = Time.time + _duration;

	public override bool Statement() => Time.time >= _time;
}
