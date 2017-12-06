using System;
using System.Collections.Generic;

namespace OpenMined.Syft.Tensor
{
	public partial class FloatTensor
	{

		private bool autograd;
		private bool keepgrads;

		private Dictionary<int, FloatTensor> creators;
		private string creation_op;
		private Dictionary<int, FloatTensor> children;

		private FloatTensor grad;




	}
}
