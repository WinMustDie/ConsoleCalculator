﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
	public partial class Calculator
	{
		private interface IState
		{
			void ProcessChar(CalculatorContext context, char c);
			void Complete(CalculatorContext context);
		}
	}
}
