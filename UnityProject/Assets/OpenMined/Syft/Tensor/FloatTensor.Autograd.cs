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
		private Dictionary<int, int> children;

		private FloatTensor grad;

	

		public void InitAutograd() {
			if(!autograd) {
				autograd=true;
				creators = new Dictionary<int, FloatTensor> ();
				children = new Dictionary<int, int> ();
			}

		}

		public void Backward(FloatTensor grad = null, FloatTensor grad_origin=null) {

			if (autograd) {
				if (grad == null) {

				}


			}



		}

	}
}
