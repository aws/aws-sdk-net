/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the dlm-2018-01-12.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.DLM.Model;
using Amazon.DLM.Model.Internal.MarshallTransformations;
using Amazon.DLM.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.DLM
{
    /// <summary>
    /// Implementation for accessing DLM
    ///
    /// Amazon Data Lifecycle Manager 
    /// <para>
    /// With Amazon Data Lifecycle Manager, you can manage the lifecycle of your AWS resources.
    /// You create lifecycle policies, which are used to automate operations on the specified
    /// resources.
    /// </para>
    ///  
    /// <para>
    /// Amazon DLM supports Amazon EBS volumes and snapshots. For information about using
    /// Amazon DLM with Amazon EBS, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/snapshot-lifecycle.html">Automating
    /// the Amazon EBS Snapshot Lifecycle</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    /// </summary>
    public partial class AmazonDLMClient : AmazonServiceClient, IAmazonDLM
    {
        private static IServiceMetadata serviceMetadata = new AmazonDLMMetadata();
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonDLMClient with the credentials loaded from the application's
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
        public AmazonDLMClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonDLMConfig()) { }

        /// <summary>
        /// Constructs AmazonDLMClient with the credentials loaded from the application's
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
        public AmazonDLMClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonDLMConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonDLMClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonDLMClient Configuration Object</param>
        public AmazonDLMClient(AmazonDLMConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonDLMClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonDLMClient(AWSCredentials credentials)
            : this(credentials, new AmazonDLMConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDLMClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDLMClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonDLMConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDLMClient with AWS Credentials and an
        /// AmazonDLMClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonDLMClient Configuration Object</param>
        public AmazonDLMClient(AWSCredentials credentials, AmazonDLMConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDLMClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonDLMClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDLMConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDLMClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDLMClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDLMConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonDLMClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDLMClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonDLMClient Configuration Object</param>
        public AmazonDLMClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonDLMConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDLMClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonDLMClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDLMConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDLMClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDLMClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDLMConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDLMClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDLMClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonDLMClient Configuration Object</param>
        public AmazonDLMClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonDLMConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
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


        #region  CreateLifecyclePolicy

        internal virtual CreateLifecyclePolicyResponse CreateLifecyclePolicy(CreateLifecyclePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLifecyclePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLifecyclePolicyResponseUnmarshaller.Instance;

            return Invoke<CreateLifecyclePolicyResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateLifecyclePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLifecyclePolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dlm-2018-01-12/CreateLifecyclePolicy">REST API Reference for CreateLifecyclePolicy Operation</seealso>
        public virtual Task<CreateLifecyclePolicyResponse> CreateLifecyclePolicyAsync(CreateLifecyclePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLifecyclePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLifecyclePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLifecyclePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteLifecyclePolicy

        internal virtual DeleteLifecyclePolicyResponse DeleteLifecyclePolicy(DeleteLifecyclePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLifecyclePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLifecyclePolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteLifecyclePolicyResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLifecyclePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLifecyclePolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dlm-2018-01-12/DeleteLifecyclePolicy">REST API Reference for DeleteLifecyclePolicy Operation</seealso>
        public virtual Task<DeleteLifecyclePolicyResponse> DeleteLifecyclePolicyAsync(DeleteLifecyclePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLifecyclePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLifecyclePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLifecyclePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetLifecyclePolicies

        internal virtual GetLifecyclePoliciesResponse GetLifecyclePolicies(GetLifecyclePoliciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLifecyclePoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLifecyclePoliciesResponseUnmarshaller.Instance;

            return Invoke<GetLifecyclePoliciesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetLifecyclePolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLifecyclePolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dlm-2018-01-12/GetLifecyclePolicies">REST API Reference for GetLifecyclePolicies Operation</seealso>
        public virtual Task<GetLifecyclePoliciesResponse> GetLifecyclePoliciesAsync(GetLifecyclePoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLifecyclePoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLifecyclePoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<GetLifecyclePoliciesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetLifecyclePolicy

        internal virtual GetLifecyclePolicyResponse GetLifecyclePolicy(GetLifecyclePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLifecyclePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLifecyclePolicyResponseUnmarshaller.Instance;

            return Invoke<GetLifecyclePolicyResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetLifecyclePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLifecyclePolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dlm-2018-01-12/GetLifecyclePolicy">REST API Reference for GetLifecyclePolicy Operation</seealso>
        public virtual Task<GetLifecyclePolicyResponse> GetLifecyclePolicyAsync(GetLifecyclePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLifecyclePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLifecyclePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetLifecyclePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateLifecyclePolicy

        internal virtual UpdateLifecyclePolicyResponse UpdateLifecyclePolicy(UpdateLifecyclePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLifecyclePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLifecyclePolicyResponseUnmarshaller.Instance;

            return Invoke<UpdateLifecyclePolicyResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLifecyclePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLifecyclePolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dlm-2018-01-12/UpdateLifecyclePolicy">REST API Reference for UpdateLifecyclePolicy Operation</seealso>
        public virtual Task<UpdateLifecyclePolicyResponse> UpdateLifecyclePolicyAsync(UpdateLifecyclePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLifecyclePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLifecyclePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateLifecyclePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}