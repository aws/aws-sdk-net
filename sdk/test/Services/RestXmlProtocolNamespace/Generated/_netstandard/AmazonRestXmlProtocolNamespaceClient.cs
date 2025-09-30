/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the rest-xml-protocol-namespace-2019-12-16.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.RestXmlProtocolNamespace.Model;
using Amazon.RestXmlProtocolNamespace.Model.Internal.MarshallTransformations;
using Amazon.RestXmlProtocolNamespace.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.RestXmlProtocolNamespace
{
    /// <summary>
    /// <para>Implementation for accessing RestXmlProtocolNamespace</para>
    ///
    /// A REST XML service that sends XML requests and responses.
    /// 
    ///  
    /// <para>
    /// This service and test case is complementary to the test cases in the <c>restXml</c>
    /// directory, but the service under test here has the <c>xmlNamespace</c> trait applied
    /// to it.
    /// </para>
    ///  
    /// <para>
    /// See https://github.com/smithy-lang/smithy/issues/616
    /// </para>
    /// </summary>
    public partial class AmazonRestXmlProtocolNamespaceClient : AmazonServiceClient, IAmazonRestXmlProtocolNamespace
    {
        private static IServiceMetadata serviceMetadata = new AmazonRestXmlProtocolNamespaceMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonRestXmlProtocolNamespaceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonRestXmlProtocolNamespaceClient()
            : base(new AmazonRestXmlProtocolNamespaceConfig()) { }

        /// <summary>
        /// Constructs AmazonRestXmlProtocolNamespaceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonRestXmlProtocolNamespaceClient(RegionEndpoint region)
            : base(new AmazonRestXmlProtocolNamespaceConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonRestXmlProtocolNamespaceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonRestXmlProtocolNamespaceClient Configuration Object</param>
        public AmazonRestXmlProtocolNamespaceClient(AmazonRestXmlProtocolNamespaceConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonRestXmlProtocolNamespaceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonRestXmlProtocolNamespaceClient(AWSCredentials credentials)
            : this(credentials, new AmazonRestXmlProtocolNamespaceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRestXmlProtocolNamespaceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRestXmlProtocolNamespaceClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonRestXmlProtocolNamespaceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRestXmlProtocolNamespaceClient with AWS Credentials and an
        /// AmazonRestXmlProtocolNamespaceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonRestXmlProtocolNamespaceClient Configuration Object</param>
        public AmazonRestXmlProtocolNamespaceClient(AWSCredentials credentials, AmazonRestXmlProtocolNamespaceConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRestXmlProtocolNamespaceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonRestXmlProtocolNamespaceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRestXmlProtocolNamespaceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRestXmlProtocolNamespaceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRestXmlProtocolNamespaceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRestXmlProtocolNamespaceConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonRestXmlProtocolNamespaceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRestXmlProtocolNamespaceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonRestXmlProtocolNamespaceClient Configuration Object</param>
        public AmazonRestXmlProtocolNamespaceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonRestXmlProtocolNamespaceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRestXmlProtocolNamespaceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonRestXmlProtocolNamespaceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRestXmlProtocolNamespaceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRestXmlProtocolNamespaceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRestXmlProtocolNamespaceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRestXmlProtocolNamespaceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRestXmlProtocolNamespaceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRestXmlProtocolNamespaceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonRestXmlProtocolNamespaceClient Configuration Object</param>
        public AmazonRestXmlProtocolNamespaceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonRestXmlProtocolNamespaceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonRestXmlProtocolNamespaceAuthSchemeHandler());
        }

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  SimpleScalarProperties

        internal virtual SimpleScalarPropertiesResponse SimpleScalarProperties(SimpleScalarPropertiesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SimpleScalarPropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SimpleScalarPropertiesResponseUnmarshaller.Instance;

            return Invoke<SimpleScalarPropertiesResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SimpleScalarProperties service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SimpleScalarProperties service method, as returned by RestXmlProtocolNamespace.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-namespace-2019-12-16/SimpleScalarProperties">REST API Reference for SimpleScalarProperties Operation</seealso>
        public virtual Task<SimpleScalarPropertiesResponse> SimpleScalarPropertiesAsync(SimpleScalarPropertiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SimpleScalarPropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SimpleScalarPropertiesResponseUnmarshaller.Instance;

            return InvokeAsync<SimpleScalarPropertiesResponse>(request, options, cancellationToken);
        }
        #endregion
        
    }
}