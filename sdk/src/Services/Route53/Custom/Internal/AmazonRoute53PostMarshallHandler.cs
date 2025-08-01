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
    public class AmazonRoute53PostMarshallHandler : PipelineHandler
    {           
        private static readonly HashSet<string> FixPathLookup = new HashSet<string>(new string[] { "/hostedzone/", "/change/", "/delegationset/" });

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
        /// Remove duplicates in resource path which can happen if the exact return values from the CreateHostedZone
        /// operation are used.
        /// </summary>
        /// <param name="executionContext">Execution context.</param>
        private static void ProcessRequestHandlers(IExecutionContext executionContext)
        {
            var request = executionContext.RequestContext.Request;
            FixDuplicationInResourcePath(request.ResourcePath, request.PathResources);
        }

        /// <summary>
        /// Removes duplicated values out of the resourcePath in Route52 paths for the limited set
        /// of values: "/hostedzone/", "/change/", "/delegationset/". Example: /hostedzone/{id} 
        /// where {id} = /hostedzone/123456 would result in /hostedzone//hostedzone/123456
        /// but must result in /hostedzone/123456
        /// </summary>
        /// <param name="resourcePath">The patterned resource path</param>
        /// <param name="pathResources">The key/values to key replacement in the patterned resource path</param>
        private static void FixDuplicationInResourcePath(string resourcePath, IDictionary<string, string> pathResources)
        {            
            var segments = resourcePath.Split(new char[] { '/' }, StringSplitOptions.None);
            var testSegments = segments.Select(segment => segment.Length == 0 || segment.EndsWith("}", StringComparison.Ordinal) ? segment : "/" + segment + "/");
            var prevSegment = string.Empty;
                        
            foreach(var segment in testSegments)
            {                
                if(segment.Length == 0 || segment.StartsWith("/", StringComparison.Ordinal))
                {
                    //Not a {key} so don't need to check for duplication.
                    prevSegment = segment;
                    continue;
                }

                //Else this is a {key} which could contain previous segment duplication that must be removed.
                //Example: /hostedzone/{id} where {id} = /hostedzone/123456 would result in /hostedzone//hostedzone/123456
                var keyValue = pathResources[segment];
                if(FixPathLookup.Contains(prevSegment) && keyValue != null && keyValue.StartsWith(prevSegment, StringComparison.Ordinal))
                {
                    pathResources[segment] = prevSegment = keyValue.Substring(prevSegment.Length);                    
                }
            }
        }
    }
}
