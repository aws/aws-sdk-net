using System;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests
{
    /// <summary>
    /// Helper class for testing <see cref="AmazonServiceClient"/> plumbing.  Works by throwing
    /// an exception to halt pipeline execution, but preserving a reference to the final
    /// <see cref="IExecutionContext"/> so Tests can <see cref="Assert"/> against it. 
    /// </summary>
    /// <example>
    /// <code>
    /// <![CDATA[
    /// <summary>
    /// Wraps the real <see cref="AmazonBearerTokenAuthTestClient"/>, but tweaks said client to make it more test friendly
    /// by adding a <see cref="TerminatePipeline"/> handler to 1) prevent an actual outbound http request as well as
    /// 2) capturing the final request's <see cref="IExecutionContext"/> so Tests can assert against it.
    /// </summary>
    /// private class AmazonBearerTokenAuthTestClientTestFixture : AmazonBearerTokenAuthTestClient
    /// {
    ///     private readonly TerminatePipeline _terminatePipeline = new TerminatePipeline();
    /// 
    ///     public IExecutionContext CapturedContext => _terminatePipeline.CapturedContext;
    /// 
    ///     public AmazonBearerTokenAuthTestClientTestFixture(AmazonBearerTokenAuthTestConfig config) : base(config)
    ///     {
    ///         RuntimePipeline.AddHandlerBefore<HttpHandler<Stream>>(_terminatePipeline);
    ///     }
    /// }
    /// ]]>
    /// </code>
    /// </example>
    public class TerminatePipeline : PipelineHandler
    {
        public IExecutionContext CapturedContext { get; set; }
        
        public override void InvokeSync(IExecutionContext executionContext)
        {
            CapturedContext = executionContext;

            throw new Exception("Terminating Pipeline");
        }

        public override System.Threading.Tasks.Task<T> InvokeAsync<T>(IExecutionContext executionContext)
        {
            CapturedContext = executionContext;

            throw new Exception("Terminating Pipeline");
        }
    }
}