using Amazon.Route53.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon.Route53.Internal
{
    /// <summary>
    /// Custom pipeline handler
    /// </summary>
    public class AmazonRoute53PreMarshallHandler : PipelineHandler
    {
        /// <summary>
        /// Calls pre invoke logic before calling the next handler 
        /// in the pipeline.
        /// </summary>
        /// <param name="executionContext">The execution context which contains both the
        /// requests and response context.</param>
        public override void InvokeSync(IExecutionContext executionContext)
        {
            PreInvoke(executionContext);
            base.InvokeSync(executionContext);
        }

        /// <summary>
        /// Calls pre invoke logic before calling the next handler 
        /// in the pipeline.
        /// </summary>
        /// <typeparam name="T">The response type for the current request.</typeparam>
        /// <param name="executionContext">The execution context, it contains the
        /// request and response context.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        public override System.Threading.Tasks.Task<T> InvokeAsync<T>(IExecutionContext executionContext)
        {
            PreInvoke(executionContext);
            return base.InvokeAsync<T>(executionContext);                        
        }

        /// <summary>
        /// Custom pipeline handler
        /// </summary>
        /// <param name="executionContext"></param>
        protected virtual void PreInvoke(IExecutionContext executionContext)
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
