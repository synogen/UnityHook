
using System;
using System.Reflection;

namespace Hooks
{
	[RuntimeHook]
	class ShowCustomerSpecs
	{
		// This variable is used to control the interception of the hooked method.
		// When TRUE, we return null to allow normal execution of the function.
		// When FALSE, we hook into the call.
		// This switch allows us to call the original method from within this hook class.
		private bool reentrant;

		public ShowCustomerSpecs()
		{
			HookRegistry.Register(OnCall);
			reentrant = false;
		}

		// Expects an object of type `bgs.BattleNetCSharp` and arguments to pass into the
		// `bgs.BattleNetCSharp::Init(..)` method.
		// This method invokes the Init function dynamically.
		//private object ProxyBNetInit(ref object bnetObject, object[] args)
		//{
			// Dynamically invoke the Init method as defined by the type
			//MethodInfo initMethod = typeof(BattleNetCSharp).GetMethod("Init");
			//return initMethod.Invoke(bnetObject, args);
		//s}

		// Returns a list of methods (full names) this hook expects.
		// The Hooker will cross reference all returned methods with the methods it tries to hook.
		public static string[] GetExpectedMethods()
		{
			return new string[] { "Job::GetBody" };
		}

		object OnCall(string typeName, string methodName, object thisObj, object[] args, IntPtr[] refArgs, int[] refIdxMatch)
		{
			return "LOL";
		}
	}
}
