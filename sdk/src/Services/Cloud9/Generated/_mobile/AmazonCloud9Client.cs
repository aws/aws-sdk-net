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
 * Do not modify this file. This file is generated from the cloud9-2017-09-23.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Cloud9.Model;
using Amazon.Cloud9.Model.Internal.MarshallTransformations;
using Amazon.Cloud9.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Cloud9
{
    /// <summary>
    /// Implementation for accessing Cloud9
    ///
    /// AWS Cloud9 
    /// <para>
    /// AWS Cloud9 is a collection of tools that you can use to code, build, run, test, debug,
    /// and release software in the cloud.
    /// </para>
    ///  
    /// <para>
    /// For more information about AWS Cloud9, see the <a href="https://docs.aws.amazon.com/cloud9/latest/user-guide">AWS
    /// Cloud9 User Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// AWS Cloud9 supports these operations:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>CreateEnvironmentEC2</code>: Creates an AWS Cloud9 development environment,
    /// launches an Amazon EC2 instance, and then connects from the instance to the environment.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>CreateEnvironmentMembership</code>: Adds an environment member to an environment.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>DeleteEnvironment</code>: Deletes an environment. If an Amazon EC2 instance
    /// is connected to the environment, also terminates the instance.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>DeleteEnvironmentMembership</code>: Deletes an environment member from an environment.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>DescribeEnvironmentMemberships</code>: Gets information about environment members
    /// for an environment.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>DescribeEnvironments</code>: Gets information about environments.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>DescribeEnvironmentStatus</code>: Gets status information for an environment.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ListEnvironments</code>: Gets a list of environment identifiers.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>UpdateEnvironment</code>: Changes the settings of an existing environment.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>UpdateEnvironmentMembership</code>: Changes the settings of an existing environment
    /// member for an environment.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonCloud9Client : AmazonServiceClient, IAmazonCloud9
    {
        private static IServiceMetadata serviceMetadata = new AmazonCloud9Metadata();
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonCloud9Client with the credentials loaded from the application's
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
        public AmazonCloud9Client()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloud9Config()) { }

        /// <summary>
        /// Constructs AmazonCloud9Client with the credentials loaded from the application's
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
        public AmazonCloud9Client(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloud9Config{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonCloud9Client with the credentials loaded from the application's
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
        /// <param name="config">The AmazonCloud9Client Configuration Object</param>
        public AmazonCloud9Client(AmazonCloud9Config config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonCloud9Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCloud9Client(AWSCredentials credentials)
            : this(credentials, new AmazonCloud9Config())
        {
        }

        /// <summary>
        /// Constructs AmazonCloud9Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloud9Client(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCloud9Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloud9Client with AWS Credentials and an
        /// AmazonCloud9Client Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCloud9Client Configuration Object</param>
        public AmazonCloud9Client(AWSCredentials credentials, AmazonCloud9Config clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCloud9Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCloud9Client(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCloud9Config())
        {
        }

        /// <summary>
        /// Constructs AmazonCloud9Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloud9Client(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCloud9Config() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloud9Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloud9Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCloud9Client Configuration Object</param>
        public AmazonCloud9Client(string awsAccessKeyId, string awsSecretAccessKey, AmazonCloud9Config clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCloud9Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCloud9Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloud9Config())
        {
        }

        /// <summary>
        /// Constructs AmazonCloud9Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloud9Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloud9Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloud9Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloud9Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCloud9Client Configuration Object</param>
        public AmazonCloud9Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCloud9Config clientConfig)
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


        #region  CreateEnvironmentEC2

        internal virtual CreateEnvironmentEC2Response CreateEnvironmentEC2(CreateEnvironmentEC2Request request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEnvironmentEC2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnvironmentEC2ResponseUnmarshaller.Instance;

            return Invoke<CreateEnvironmentEC2Response>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateEnvironmentEC2 operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironmentEC2 operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/CreateEnvironmentEC2">REST API Reference for CreateEnvironmentEC2 Operation</seealso>
        public virtual Task<CreateEnvironmentEC2Response> CreateEnvironmentEC2Async(CreateEnvironmentEC2Request request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEnvironmentEC2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnvironmentEC2ResponseUnmarshaller.Instance;

            return InvokeAsync<CreateEnvironmentEC2Response>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateEnvironmentMembership

        internal virtual CreateEnvironmentMembershipResponse CreateEnvironmentMembership(CreateEnvironmentMembershipRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEnvironmentMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnvironmentMembershipResponseUnmarshaller.Instance;

            return Invoke<CreateEnvironmentMembershipResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateEnvironmentMembership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironmentMembership operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/CreateEnvironmentMembership">REST API Reference for CreateEnvironmentMembership Operation</seealso>
        public virtual Task<CreateEnvironmentMembershipResponse> CreateEnvironmentMembershipAsync(CreateEnvironmentMembershipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEnvironmentMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnvironmentMembershipResponseUnmarshaller.Instance;

            return InvokeAsync<CreateEnvironmentMembershipResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteEnvironment

        internal virtual DeleteEnvironmentResponse DeleteEnvironment(DeleteEnvironmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentResponseUnmarshaller.Instance;

            return Invoke<DeleteEnvironmentResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/DeleteEnvironment">REST API Reference for DeleteEnvironment Operation</seealso>
        public virtual Task<DeleteEnvironmentResponse> DeleteEnvironmentAsync(DeleteEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEnvironmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteEnvironmentMembership

        internal virtual DeleteEnvironmentMembershipResponse DeleteEnvironmentMembership(DeleteEnvironmentMembershipRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentMembershipResponseUnmarshaller.Instance;

            return Invoke<DeleteEnvironmentMembershipResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEnvironmentMembership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironmentMembership operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/DeleteEnvironmentMembership">REST API Reference for DeleteEnvironmentMembership Operation</seealso>
        public virtual Task<DeleteEnvironmentMembershipResponse> DeleteEnvironmentMembershipAsync(DeleteEnvironmentMembershipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentMembershipResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEnvironmentMembershipResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEnvironmentMemberships

        internal virtual DescribeEnvironmentMembershipsResponse DescribeEnvironmentMemberships(DescribeEnvironmentMembershipsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEnvironmentMembershipsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEnvironmentMembershipsResponseUnmarshaller.Instance;

            return Invoke<DescribeEnvironmentMembershipsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEnvironmentMemberships operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironmentMemberships operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/DescribeEnvironmentMemberships">REST API Reference for DescribeEnvironmentMemberships Operation</seealso>
        public virtual Task<DescribeEnvironmentMembershipsResponse> DescribeEnvironmentMembershipsAsync(DescribeEnvironmentMembershipsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEnvironmentMembershipsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEnvironmentMembershipsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEnvironmentMembershipsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEnvironments

        internal virtual DescribeEnvironmentsResponse DescribeEnvironments(DescribeEnvironmentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEnvironmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEnvironmentsResponseUnmarshaller.Instance;

            return Invoke<DescribeEnvironmentsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEnvironments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironments operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/DescribeEnvironments">REST API Reference for DescribeEnvironments Operation</seealso>
        public virtual Task<DescribeEnvironmentsResponse> DescribeEnvironmentsAsync(DescribeEnvironmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEnvironmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEnvironmentsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEnvironmentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEnvironmentStatus

        internal virtual DescribeEnvironmentStatusResponse DescribeEnvironmentStatus(DescribeEnvironmentStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEnvironmentStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEnvironmentStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeEnvironmentStatusResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEnvironmentStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironmentStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/DescribeEnvironmentStatus">REST API Reference for DescribeEnvironmentStatus Operation</seealso>
        public virtual Task<DescribeEnvironmentStatusResponse> DescribeEnvironmentStatusAsync(DescribeEnvironmentStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEnvironmentStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEnvironmentStatusResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEnvironmentStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListEnvironments

        internal virtual ListEnvironmentsResponse ListEnvironments(ListEnvironmentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEnvironmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentsResponseUnmarshaller.Instance;

            return Invoke<ListEnvironmentsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListEnvironments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironments operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/ListEnvironments">REST API Reference for ListEnvironments Operation</seealso>
        public virtual Task<ListEnvironmentsResponse> ListEnvironmentsAsync(ListEnvironmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEnvironmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListEnvironmentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateEnvironment

        internal virtual UpdateEnvironmentResponse UpdateEnvironment(UpdateEnvironmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnvironmentResponseUnmarshaller.Instance;

            return Invoke<UpdateEnvironmentResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/UpdateEnvironment">REST API Reference for UpdateEnvironment Operation</seealso>
        public virtual Task<UpdateEnvironmentResponse> UpdateEnvironmentAsync(UpdateEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnvironmentResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateEnvironmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateEnvironmentMembership

        internal virtual UpdateEnvironmentMembershipResponse UpdateEnvironmentMembership(UpdateEnvironmentMembershipRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEnvironmentMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnvironmentMembershipResponseUnmarshaller.Instance;

            return Invoke<UpdateEnvironmentMembershipResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEnvironmentMembership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironmentMembership operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/UpdateEnvironmentMembership">REST API Reference for UpdateEnvironmentMembership Operation</seealso>
        public virtual Task<UpdateEnvironmentMembershipResponse> UpdateEnvironmentMembershipAsync(UpdateEnvironmentMembershipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEnvironmentMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnvironmentMembershipResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateEnvironmentMembershipResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}