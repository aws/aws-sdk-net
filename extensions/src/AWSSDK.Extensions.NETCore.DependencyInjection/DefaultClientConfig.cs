using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Amazon.Runtime;

namespace AWSSDK.Extensions.NETCore.DependencyInjection
{
    internal class DefaultClientConfig : ClientConfig
    {
        internal DefaultClientConfig()
        {

        }

        public override string RegionEndpointServiceName
        {
            get
            {
                return null;
            }
        }

        public override string ServiceVersion
        {
            get
            {
                return null;
            }
        }

        public override string UserAgent
        {
            get
            {
                return null;
            }
        }
    }
}
