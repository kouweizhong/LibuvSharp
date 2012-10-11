using System;

namespace LibuvSharp
{
	public interface IListener<TStream> where TStream : IUVStream
	{
		void Listen();
		event Action IncommingStream;
		TStream AcceptStream();
	}
}

