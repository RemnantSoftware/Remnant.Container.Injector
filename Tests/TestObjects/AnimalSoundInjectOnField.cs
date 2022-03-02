﻿using Remnant.Dependency.Injector;

namespace Remnant.Dependeny.Injector.Tests.TestObjects
{
	public class AnimalSoundInjectOnField
	{
		private readonly IAnimal _animal = Container.Resolve<IAnimal>();

		public string MakeSound() => _animal.Sound;
	}
}
