using Amazon.Route53.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon.Route53.Internal
{
    public class AmazonRoute53PreMarshallHandler : GenericHandler
    {
        protected override void PreInvoke(IExecutionContext executionContext)
        {
            ProcessRequestHandlers(executionContext);
        }

        /// <summary>
        /// Remove prefixes in resource ids.
        /// </summary>
        /// <param name="executionContext">Execution context.</param>
        private static void ProcessRequestHandlers(IExecutionContext executionContext)
        {
            var request = executionContext.RequestContext.OriginalRequest;

            var createHostedZoneRequest = request as CreateHostedZoneRequest;
            if (createHostedZoneRequest != null)
            {
                createHostedZoneRequest.DelegationSetId = ModifyId(createHostedZoneRequest.DelegationSetId);
                return;
            }

            var listHostedZonesRequest = request as ListHostedZonesRequest;
            if (listHostedZonesRequest != null)
            {
                listHostedZonesRequest.DelegationSetId = ModifyId(listHostedZonesRequest.DelegationSetId);
                return;
            }

            var createReusableDelegationSetRequest = request as CreateReusableDelegationSetRequest;
            if (createReusableDelegationSetRequest != null)
            {
                createReusableDelegationSetRequest.HostedZoneId = ModifyId(createReusableDelegationSetRequest.HostedZoneId);
                return;
            }
        }

        private const char slash = '/';
        private static string ModifyId(string id)
        {
            if (string.IsNullOrEmpty(id))
                return id;

            int slashIndex = id.LastIndexOf(slash);
            if (slashIndex < 0)
                return id;

            var newId = id.Substring(slashIndex + 1);
            return newId;
        }
    }
}
