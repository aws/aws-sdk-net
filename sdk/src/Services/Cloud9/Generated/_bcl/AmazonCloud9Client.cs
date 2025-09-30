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
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.Cloud9
{
    /// <summary>
    /// <para>Implementation for accessing Cloud9</para>
    ///
    /// Cloud9 
    /// <para>
    /// Cloud9 is a collection of tools that you can use to code, build, run, test, debug,
    /// and release software in the cloud.
    /// </para>
    ///  
    /// <para>
    /// For more information about Cloud9, see the <a href="https://docs.aws.amazon.com/cloud9/latest/user-guide">Cloud9
    /// User Guide</a>.
    /// </para>
    ///  <important> 
    /// <para>
    /// Cloud9 is no longer available to new customers. Existing customers of Cloud9 can continue
    /// to use the service as normal. <a href="http://aws.amazon.com/blogs/devops/how-to-migrate-from-aws-cloud9-to-aws-ide-toolkits-or-aws-cloudshell/">Learn
    /// more"</a> 
    /// </para>
    ///  </important> 
    /// <para>
    /// Cloud9 supports these operations:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>CreateEnvironmentEC2</c>: Creates an Cloud9 development environment, launches
    /// an Amazon EC2 instance, and then connects from the instance to the environment.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>CreateEnvironmentMembership</c>: Adds an environment member to an environment.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>DeleteEnvironment</c>: Deletes an environment. If an Amazon EC2 instance is connected
    /// to the environment, also terminates the instance.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>DeleteEnvironmentMembership</c>: Deletes an environment member from an environment.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>DescribeEnvironmentMemberships</c>: Gets information about environment members
    /// for an environment.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>DescribeEnvironments</c>: Gets information about environments.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>DescribeEnvironmentStatus</c>: Gets status information for an environment.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ListEnvironments</c>: Gets a list of environment identifiers.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ListTagsForResource</c>: Gets the tags for an environment.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>TagResource</c>: Adds tags to an environment.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>UntagResource</c>: Removes tags from an environment.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>UpdateEnvironment</c>: Changes the settings of an existing environment.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>UpdateEnvironmentMembership</c>: Changes the settings of an existing environment
    /// member for an environment.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonCloud9Client : AmazonServiceClient, IAmazonCloud9
    {
        private static IServiceMetadata serviceMetadata = new AmazonCloud9Metadata();
        private ICloud9PaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ICloud9PaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new Cloud9PaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

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
            : base(new AmazonCloud9Config()) { }

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
            : base(new AmazonCloud9Config{RegionEndpoint = region}) { }

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
            : base(config) { }

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
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonCloud9EndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonCloud9AuthSchemeHandler());
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


        /// <summary>
        /// Creates an Cloud9 development environment, launches an Amazon Elastic Compute Cloud
        /// (Amazon EC2) instance, and then connects from the instance to the environment.
        /// 
        ///  <important> 
        /// <para>
        /// Cloud9 is no longer available to new customers. Existing customers of Cloud9 can continue
        /// to use the service as normal. <a href="http://aws.amazon.com/blogs/devops/how-to-migrate-from-aws-cloud9-to-aws-ide-toolkits-or-aws-cloudshell/">Learn
        /// more"</a> 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironmentEC2 service method.</param>
        /// 
        /// <returns>The response from the CreateEnvironmentEC2 service method, as returned by Cloud9.</returns>
        /// <exception cref="Amazon.Cloud9.Model.BadRequestException">
        /// The target request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.ConflictException">
        /// A conflict occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.ForbiddenException">
        /// An access permissions issue occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.LimitExceededException">
        /// A service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.NotFoundException">
        /// The target resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.TooManyRequestsException">
        /// Too many service requests were made over the given time period.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/CreateEnvironmentEC2">REST API Reference for CreateEnvironmentEC2 Operation</seealso>
        public virtual CreateEnvironmentEC2Response CreateEnvironmentEC2(CreateEnvironmentEC2Request request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEnvironmentEC2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnvironmentEC2ResponseUnmarshaller.Instance;

            return Invoke<CreateEnvironmentEC2Response>(request, options);
        }


        /// <summary>
        /// Creates an Cloud9 development environment, launches an Amazon Elastic Compute Cloud
        /// (Amazon EC2) instance, and then connects from the instance to the environment.
        /// 
        ///  <important> 
        /// <para>
        /// Cloud9 is no longer available to new customers. Existing customers of Cloud9 can continue
        /// to use the service as normal. <a href="http://aws.amazon.com/blogs/devops/how-to-migrate-from-aws-cloud9-to-aws-ide-toolkits-or-aws-cloudshell/">Learn
        /// more"</a> 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironmentEC2 service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEnvironmentEC2 service method, as returned by Cloud9.</returns>
        /// <exception cref="Amazon.Cloud9.Model.BadRequestException">
        /// The target request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.ConflictException">
        /// A conflict occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.ForbiddenException">
        /// An access permissions issue occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.LimitExceededException">
        /// A service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.NotFoundException">
        /// The target resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.TooManyRequestsException">
        /// Too many service requests were made over the given time period.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/CreateEnvironmentEC2">REST API Reference for CreateEnvironmentEC2 Operation</seealso>
        public virtual Task<CreateEnvironmentEC2Response> CreateEnvironmentEC2Async(CreateEnvironmentEC2Request request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEnvironmentEC2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnvironmentEC2ResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateEnvironmentEC2Response>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateEnvironmentMembership


        /// <summary>
        /// Adds an environment member to an Cloud9 development environment.
        /// 
        ///  <important> 
        /// <para>
        /// Cloud9 is no longer available to new customers. Existing customers of Cloud9 can continue
        /// to use the service as normal. <a href="http://aws.amazon.com/blogs/devops/how-to-migrate-from-aws-cloud9-to-aws-ide-toolkits-or-aws-cloudshell/">Learn
        /// more"</a> 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironmentMembership service method.</param>
        /// 
        /// <returns>The response from the CreateEnvironmentMembership service method, as returned by Cloud9.</returns>
        /// <exception cref="Amazon.Cloud9.Model.BadRequestException">
        /// The target request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.ConflictException">
        /// A conflict occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.ForbiddenException">
        /// An access permissions issue occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.LimitExceededException">
        /// A service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.NotFoundException">
        /// The target resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.TooManyRequestsException">
        /// Too many service requests were made over the given time period.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/CreateEnvironmentMembership">REST API Reference for CreateEnvironmentMembership Operation</seealso>
        public virtual CreateEnvironmentMembershipResponse CreateEnvironmentMembership(CreateEnvironmentMembershipRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEnvironmentMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnvironmentMembershipResponseUnmarshaller.Instance;

            return Invoke<CreateEnvironmentMembershipResponse>(request, options);
        }


        /// <summary>
        /// Adds an environment member to an Cloud9 development environment.
        /// 
        ///  <important> 
        /// <para>
        /// Cloud9 is no longer available to new customers. Existing customers of Cloud9 can continue
        /// to use the service as normal. <a href="http://aws.amazon.com/blogs/devops/how-to-migrate-from-aws-cloud9-to-aws-ide-toolkits-or-aws-cloudshell/">Learn
        /// more"</a> 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironmentMembership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEnvironmentMembership service method, as returned by Cloud9.</returns>
        /// <exception cref="Amazon.Cloud9.Model.BadRequestException">
        /// The target request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.ConflictException">
        /// A conflict occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.ForbiddenException">
        /// An access permissions issue occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.LimitExceededException">
        /// A service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.NotFoundException">
        /// The target resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.TooManyRequestsException">
        /// Too many service requests were made over the given time period.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/CreateEnvironmentMembership">REST API Reference for CreateEnvironmentMembership Operation</seealso>
        public virtual Task<CreateEnvironmentMembershipResponse> CreateEnvironmentMembershipAsync(CreateEnvironmentMembershipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEnvironmentMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnvironmentMembershipResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateEnvironmentMembershipResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteEnvironment


        /// <summary>
        /// Deletes an Cloud9 development environment. If an Amazon EC2 instance is connected
        /// to the environment, also terminates the instance.
        /// 
        ///  <important> 
        /// <para>
        /// Cloud9 is no longer available to new customers. Existing customers of Cloud9 can continue
        /// to use the service as normal. <a href="http://aws.amazon.com/blogs/devops/how-to-migrate-from-aws-cloud9-to-aws-ide-toolkits-or-aws-cloudshell/">Learn
        /// more"</a> 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironment service method.</param>
        /// 
        /// <returns>The response from the DeleteEnvironment service method, as returned by Cloud9.</returns>
        /// <exception cref="Amazon.Cloud9.Model.BadRequestException">
        /// The target request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.ConflictException">
        /// A conflict occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.ForbiddenException">
        /// An access permissions issue occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.LimitExceededException">
        /// A service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.NotFoundException">
        /// The target resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.TooManyRequestsException">
        /// Too many service requests were made over the given time period.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/DeleteEnvironment">REST API Reference for DeleteEnvironment Operation</seealso>
        public virtual DeleteEnvironmentResponse DeleteEnvironment(DeleteEnvironmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentResponseUnmarshaller.Instance;

            return Invoke<DeleteEnvironmentResponse>(request, options);
        }


        /// <summary>
        /// Deletes an Cloud9 development environment. If an Amazon EC2 instance is connected
        /// to the environment, also terminates the instance.
        /// 
        ///  <important> 
        /// <para>
        /// Cloud9 is no longer available to new customers. Existing customers of Cloud9 can continue
        /// to use the service as normal. <a href="http://aws.amazon.com/blogs/devops/how-to-migrate-from-aws-cloud9-to-aws-ide-toolkits-or-aws-cloudshell/">Learn
        /// more"</a> 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEnvironment service method, as returned by Cloud9.</returns>
        /// <exception cref="Amazon.Cloud9.Model.BadRequestException">
        /// The target request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.ConflictException">
        /// A conflict occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.ForbiddenException">
        /// An access permissions issue occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.LimitExceededException">
        /// A service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.NotFoundException">
        /// The target resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.TooManyRequestsException">
        /// Too many service requests were made over the given time period.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/DeleteEnvironment">REST API Reference for DeleteEnvironment Operation</seealso>
        public virtual Task<DeleteEnvironmentResponse> DeleteEnvironmentAsync(DeleteEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteEnvironmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteEnvironmentMembership


        /// <summary>
        /// Deletes an environment member from a development environment.
        /// 
        ///  <important> 
        /// <para>
        /// Cloud9 is no longer available to new customers. Existing customers of Cloud9 can continue
        /// to use the service as normal. <a href="http://aws.amazon.com/blogs/devops/how-to-migrate-from-aws-cloud9-to-aws-ide-toolkits-or-aws-cloudshell/">Learn
        /// more"</a> 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironmentMembership service method.</param>
        /// 
        /// <returns>The response from the DeleteEnvironmentMembership service method, as returned by Cloud9.</returns>
        /// <exception cref="Amazon.Cloud9.Model.BadRequestException">
        /// The target request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.ConflictException">
        /// A conflict occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.ForbiddenException">
        /// An access permissions issue occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.LimitExceededException">
        /// A service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.NotFoundException">
        /// The target resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.TooManyRequestsException">
        /// Too many service requests were made over the given time period.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/DeleteEnvironmentMembership">REST API Reference for DeleteEnvironmentMembership Operation</seealso>
        public virtual DeleteEnvironmentMembershipResponse DeleteEnvironmentMembership(DeleteEnvironmentMembershipRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentMembershipResponseUnmarshaller.Instance;

            return Invoke<DeleteEnvironmentMembershipResponse>(request, options);
        }


        /// <summary>
        /// Deletes an environment member from a development environment.
        /// 
        ///  <important> 
        /// <para>
        /// Cloud9 is no longer available to new customers. Existing customers of Cloud9 can continue
        /// to use the service as normal. <a href="http://aws.amazon.com/blogs/devops/how-to-migrate-from-aws-cloud9-to-aws-ide-toolkits-or-aws-cloudshell/">Learn
        /// more"</a> 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironmentMembership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEnvironmentMembership service method, as returned by Cloud9.</returns>
        /// <exception cref="Amazon.Cloud9.Model.BadRequestException">
        /// The target request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.ConflictException">
        /// A conflict occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.ForbiddenException">
        /// An access permissions issue occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.LimitExceededException">
        /// A service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.NotFoundException">
        /// The target resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.TooManyRequestsException">
        /// Too many service requests were made over the given time period.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/DeleteEnvironmentMembership">REST API Reference for DeleteEnvironmentMembership Operation</seealso>
        public virtual Task<DeleteEnvironmentMembershipResponse> DeleteEnvironmentMembershipAsync(DeleteEnvironmentMembershipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentMembershipResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteEnvironmentMembershipResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEnvironmentMemberships


        /// <summary>
        /// Gets information about environment members for an Cloud9 development environment.
        /// 
        ///  <important> 
        /// <para>
        /// Cloud9 is no longer available to new customers. Existing customers of Cloud9 can continue
        /// to use the service as normal. <a href="http://aws.amazon.com/blogs/devops/how-to-migrate-from-aws-cloud9-to-aws-ide-toolkits-or-aws-cloudshell/">Learn
        /// more"</a> 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironmentMemberships service method.</param>
        /// 
        /// <returns>The response from the DescribeEnvironmentMemberships service method, as returned by Cloud9.</returns>
        /// <exception cref="Amazon.Cloud9.Model.BadRequestException">
        /// The target request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.ConflictException">
        /// A conflict occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.ForbiddenException">
        /// An access permissions issue occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.LimitExceededException">
        /// A service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.NotFoundException">
        /// The target resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.TooManyRequestsException">
        /// Too many service requests were made over the given time period.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/DescribeEnvironmentMemberships">REST API Reference for DescribeEnvironmentMemberships Operation</seealso>
        public virtual DescribeEnvironmentMembershipsResponse DescribeEnvironmentMemberships(DescribeEnvironmentMembershipsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEnvironmentMembershipsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEnvironmentMembershipsResponseUnmarshaller.Instance;

            return Invoke<DescribeEnvironmentMembershipsResponse>(request, options);
        }


        /// <summary>
        /// Gets information about environment members for an Cloud9 development environment.
        /// 
        ///  <important> 
        /// <para>
        /// Cloud9 is no longer available to new customers. Existing customers of Cloud9 can continue
        /// to use the service as normal. <a href="http://aws.amazon.com/blogs/devops/how-to-migrate-from-aws-cloud9-to-aws-ide-toolkits-or-aws-cloudshell/">Learn
        /// more"</a> 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironmentMemberships service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEnvironmentMemberships service method, as returned by Cloud9.</returns>
        /// <exception cref="Amazon.Cloud9.Model.BadRequestException">
        /// The target request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.ConflictException">
        /// A conflict occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.ForbiddenException">
        /// An access permissions issue occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.LimitExceededException">
        /// A service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.NotFoundException">
        /// The target resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.TooManyRequestsException">
        /// Too many service requests were made over the given time period.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/DescribeEnvironmentMemberships">REST API Reference for DescribeEnvironmentMemberships Operation</seealso>
        public virtual Task<DescribeEnvironmentMembershipsResponse> DescribeEnvironmentMembershipsAsync(DescribeEnvironmentMembershipsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEnvironmentMembershipsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEnvironmentMembershipsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeEnvironmentMembershipsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEnvironments


        /// <summary>
        /// Gets information about Cloud9 development environments.
        /// 
        ///  <important> 
        /// <para>
        /// Cloud9 is no longer available to new customers. Existing customers of Cloud9 can continue
        /// to use the service as normal. <a href="http://aws.amazon.com/blogs/devops/how-to-migrate-from-aws-cloud9-to-aws-ide-toolkits-or-aws-cloudshell/">Learn
        /// more"</a> 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironments service method.</param>
        /// 
        /// <returns>The response from the DescribeEnvironments service method, as returned by Cloud9.</returns>
        /// <exception cref="Amazon.Cloud9.Model.BadRequestException">
        /// The target request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.ConflictException">
        /// A conflict occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.ForbiddenException">
        /// An access permissions issue occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.LimitExceededException">
        /// A service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.NotFoundException">
        /// The target resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.TooManyRequestsException">
        /// Too many service requests were made over the given time period.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/DescribeEnvironments">REST API Reference for DescribeEnvironments Operation</seealso>
        public virtual DescribeEnvironmentsResponse DescribeEnvironments(DescribeEnvironmentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEnvironmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEnvironmentsResponseUnmarshaller.Instance;

            return Invoke<DescribeEnvironmentsResponse>(request, options);
        }


        /// <summary>
        /// Gets information about Cloud9 development environments.
        /// 
        ///  <important> 
        /// <para>
        /// Cloud9 is no longer available to new customers. Existing customers of Cloud9 can continue
        /// to use the service as normal. <a href="http://aws.amazon.com/blogs/devops/how-to-migrate-from-aws-cloud9-to-aws-ide-toolkits-or-aws-cloudshell/">Learn
        /// more"</a> 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEnvironments service method, as returned by Cloud9.</returns>
        /// <exception cref="Amazon.Cloud9.Model.BadRequestException">
        /// The target request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.ConflictException">
        /// A conflict occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.ForbiddenException">
        /// An access permissions issue occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.LimitExceededException">
        /// A service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.NotFoundException">
        /// The target resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.TooManyRequestsException">
        /// Too many service requests were made over the given time period.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/DescribeEnvironments">REST API Reference for DescribeEnvironments Operation</seealso>
        public virtual Task<DescribeEnvironmentsResponse> DescribeEnvironmentsAsync(DescribeEnvironmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEnvironmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEnvironmentsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeEnvironmentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEnvironmentStatus


        /// <summary>
        /// Gets status information for an Cloud9 development environment.
        /// 
        ///  <important> 
        /// <para>
        /// Cloud9 is no longer available to new customers. Existing customers of Cloud9 can continue
        /// to use the service as normal. <a href="http://aws.amazon.com/blogs/devops/how-to-migrate-from-aws-cloud9-to-aws-ide-toolkits-or-aws-cloudshell/">Learn
        /// more"</a> 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironmentStatus service method.</param>
        /// 
        /// <returns>The response from the DescribeEnvironmentStatus service method, as returned by Cloud9.</returns>
        /// <exception cref="Amazon.Cloud9.Model.BadRequestException">
        /// The target request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.ConflictException">
        /// A conflict occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.ForbiddenException">
        /// An access permissions issue occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.LimitExceededException">
        /// A service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.NotFoundException">
        /// The target resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.TooManyRequestsException">
        /// Too many service requests were made over the given time period.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/DescribeEnvironmentStatus">REST API Reference for DescribeEnvironmentStatus Operation</seealso>
        public virtual DescribeEnvironmentStatusResponse DescribeEnvironmentStatus(DescribeEnvironmentStatusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEnvironmentStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEnvironmentStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeEnvironmentStatusResponse>(request, options);
        }


        /// <summary>
        /// Gets status information for an Cloud9 development environment.
        /// 
        ///  <important> 
        /// <para>
        /// Cloud9 is no longer available to new customers. Existing customers of Cloud9 can continue
        /// to use the service as normal. <a href="http://aws.amazon.com/blogs/devops/how-to-migrate-from-aws-cloud9-to-aws-ide-toolkits-or-aws-cloudshell/">Learn
        /// more"</a> 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironmentStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEnvironmentStatus service method, as returned by Cloud9.</returns>
        /// <exception cref="Amazon.Cloud9.Model.BadRequestException">
        /// The target request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.ConflictException">
        /// A conflict occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.ForbiddenException">
        /// An access permissions issue occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.LimitExceededException">
        /// A service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.NotFoundException">
        /// The target resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.TooManyRequestsException">
        /// Too many service requests were made over the given time period.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/DescribeEnvironmentStatus">REST API Reference for DescribeEnvironmentStatus Operation</seealso>
        public virtual Task<DescribeEnvironmentStatusResponse> DescribeEnvironmentStatusAsync(DescribeEnvironmentStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEnvironmentStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEnvironmentStatusResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeEnvironmentStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListEnvironments


        /// <summary>
        /// Gets a list of Cloud9 development environment identifiers.
        /// 
        ///  <important> 
        /// <para>
        /// Cloud9 is no longer available to new customers. Existing customers of Cloud9 can continue
        /// to use the service as normal. <a href="http://aws.amazon.com/blogs/devops/how-to-migrate-from-aws-cloud9-to-aws-ide-toolkits-or-aws-cloudshell/">Learn
        /// more"</a> 
        /// </para>
        ///  </important> <important> 
        /// <para>
        /// Cloud9 is no longer available to new customers. Existing customers of Cloud9 can continue
        /// to use the service as normal. <a href="http://aws.amazon.com/blogs/devops/how-to-migrate-from-aws-cloud9-to-aws-ide-toolkits-or-aws-cloudshell/">Learn
        /// more"</a> 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironments service method.</param>
        /// 
        /// <returns>The response from the ListEnvironments service method, as returned by Cloud9.</returns>
        /// <exception cref="Amazon.Cloud9.Model.BadRequestException">
        /// The target request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.ConflictException">
        /// A conflict occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.ForbiddenException">
        /// An access permissions issue occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.LimitExceededException">
        /// A service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.NotFoundException">
        /// The target resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.TooManyRequestsException">
        /// Too many service requests were made over the given time period.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/ListEnvironments">REST API Reference for ListEnvironments Operation</seealso>
        public virtual ListEnvironmentsResponse ListEnvironments(ListEnvironmentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEnvironmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentsResponseUnmarshaller.Instance;

            return Invoke<ListEnvironmentsResponse>(request, options);
        }


        /// <summary>
        /// Gets a list of Cloud9 development environment identifiers.
        /// 
        ///  <important> 
        /// <para>
        /// Cloud9 is no longer available to new customers. Existing customers of Cloud9 can continue
        /// to use the service as normal. <a href="http://aws.amazon.com/blogs/devops/how-to-migrate-from-aws-cloud9-to-aws-ide-toolkits-or-aws-cloudshell/">Learn
        /// more"</a> 
        /// </para>
        ///  </important> <important> 
        /// <para>
        /// Cloud9 is no longer available to new customers. Existing customers of Cloud9 can continue
        /// to use the service as normal. <a href="http://aws.amazon.com/blogs/devops/how-to-migrate-from-aws-cloud9-to-aws-ide-toolkits-or-aws-cloudshell/">Learn
        /// more"</a> 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEnvironments service method, as returned by Cloud9.</returns>
        /// <exception cref="Amazon.Cloud9.Model.BadRequestException">
        /// The target request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.ConflictException">
        /// A conflict occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.ForbiddenException">
        /// An access permissions issue occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.LimitExceededException">
        /// A service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.NotFoundException">
        /// The target resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.TooManyRequestsException">
        /// Too many service requests were made over the given time period.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/ListEnvironments">REST API Reference for ListEnvironments Operation</seealso>
        public virtual Task<ListEnvironmentsResponse> ListEnvironmentsAsync(ListEnvironmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEnvironmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListEnvironmentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Gets a list of the tags associated with an Cloud9 development environment.
        /// 
        ///  <important> 
        /// <para>
        /// Cloud9 is no longer available to new customers. Existing customers of Cloud9 can continue
        /// to use the service as normal. <a href="http://aws.amazon.com/blogs/devops/how-to-migrate-from-aws-cloud9-to-aws-ide-toolkits-or-aws-cloudshell/">Learn
        /// more"</a> 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Cloud9.</returns>
        /// <exception cref="Amazon.Cloud9.Model.BadRequestException">
        /// The target request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.NotFoundException">
        /// The target resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// Gets a list of the tags associated with an Cloud9 development environment.
        /// 
        ///  <important> 
        /// <para>
        /// Cloud9 is no longer available to new customers. Existing customers of Cloud9 can continue
        /// to use the service as normal. <a href="http://aws.amazon.com/blogs/devops/how-to-migrate-from-aws-cloud9-to-aws-ide-toolkits-or-aws-cloudshell/">Learn
        /// more"</a> 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Cloud9.</returns>
        /// <exception cref="Amazon.Cloud9.Model.BadRequestException">
        /// The target request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.NotFoundException">
        /// The target resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds tags to an Cloud9 development environment.
        /// 
        ///  <important> 
        /// <para>
        /// Cloud9 is no longer available to new customers. Existing customers of Cloud9 can continue
        /// to use the service as normal. <a href="http://aws.amazon.com/blogs/devops/how-to-migrate-from-aws-cloud9-to-aws-ide-toolkits-or-aws-cloudshell/">Learn
        /// more"</a> 
        /// </para>
        ///  </important> <important> 
        /// <para>
        /// Tags that you add to an Cloud9 environment by using this method will NOT be automatically
        /// propagated to underlying resources.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Cloud9.</returns>
        /// <exception cref="Amazon.Cloud9.Model.BadRequestException">
        /// The target request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.ConcurrentAccessException">
        /// A concurrent access issue occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.NotFoundException">
        /// The target resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Adds tags to an Cloud9 development environment.
        /// 
        ///  <important> 
        /// <para>
        /// Cloud9 is no longer available to new customers. Existing customers of Cloud9 can continue
        /// to use the service as normal. <a href="http://aws.amazon.com/blogs/devops/how-to-migrate-from-aws-cloud9-to-aws-ide-toolkits-or-aws-cloudshell/">Learn
        /// more"</a> 
        /// </para>
        ///  </important> <important> 
        /// <para>
        /// Tags that you add to an Cloud9 environment by using this method will NOT be automatically
        /// propagated to underlying resources.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Cloud9.</returns>
        /// <exception cref="Amazon.Cloud9.Model.BadRequestException">
        /// The target request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.ConcurrentAccessException">
        /// A concurrent access issue occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.NotFoundException">
        /// The target resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes tags from an Cloud9 development environment.
        /// 
        ///  <important> 
        /// <para>
        /// Cloud9 is no longer available to new customers. Existing customers of Cloud9 can continue
        /// to use the service as normal. <a href="http://aws.amazon.com/blogs/devops/how-to-migrate-from-aws-cloud9-to-aws-ide-toolkits-or-aws-cloudshell/">Learn
        /// more"</a> 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Cloud9.</returns>
        /// <exception cref="Amazon.Cloud9.Model.BadRequestException">
        /// The target request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.ConcurrentAccessException">
        /// A concurrent access issue occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.NotFoundException">
        /// The target resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Removes tags from an Cloud9 development environment.
        /// 
        ///  <important> 
        /// <para>
        /// Cloud9 is no longer available to new customers. Existing customers of Cloud9 can continue
        /// to use the service as normal. <a href="http://aws.amazon.com/blogs/devops/how-to-migrate-from-aws-cloud9-to-aws-ide-toolkits-or-aws-cloudshell/">Learn
        /// more"</a> 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Cloud9.</returns>
        /// <exception cref="Amazon.Cloud9.Model.BadRequestException">
        /// The target request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.ConcurrentAccessException">
        /// A concurrent access issue occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.NotFoundException">
        /// The target resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateEnvironment


        /// <summary>
        /// Changes the settings of an existing Cloud9 development environment.
        /// 
        ///  <important> 
        /// <para>
        /// Cloud9 is no longer available to new customers. Existing customers of Cloud9 can continue
        /// to use the service as normal. <a href="http://aws.amazon.com/blogs/devops/how-to-migrate-from-aws-cloud9-to-aws-ide-toolkits-or-aws-cloudshell/">Learn
        /// more"</a> 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironment service method.</param>
        /// 
        /// <returns>The response from the UpdateEnvironment service method, as returned by Cloud9.</returns>
        /// <exception cref="Amazon.Cloud9.Model.BadRequestException">
        /// The target request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.ConflictException">
        /// A conflict occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.ForbiddenException">
        /// An access permissions issue occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.LimitExceededException">
        /// A service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.NotFoundException">
        /// The target resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.TooManyRequestsException">
        /// Too many service requests were made over the given time period.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/UpdateEnvironment">REST API Reference for UpdateEnvironment Operation</seealso>
        public virtual UpdateEnvironmentResponse UpdateEnvironment(UpdateEnvironmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnvironmentResponseUnmarshaller.Instance;

            return Invoke<UpdateEnvironmentResponse>(request, options);
        }


        /// <summary>
        /// Changes the settings of an existing Cloud9 development environment.
        /// 
        ///  <important> 
        /// <para>
        /// Cloud9 is no longer available to new customers. Existing customers of Cloud9 can continue
        /// to use the service as normal. <a href="http://aws.amazon.com/blogs/devops/how-to-migrate-from-aws-cloud9-to-aws-ide-toolkits-or-aws-cloudshell/">Learn
        /// more"</a> 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEnvironment service method, as returned by Cloud9.</returns>
        /// <exception cref="Amazon.Cloud9.Model.BadRequestException">
        /// The target request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.ConflictException">
        /// A conflict occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.ForbiddenException">
        /// An access permissions issue occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.LimitExceededException">
        /// A service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.NotFoundException">
        /// The target resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.TooManyRequestsException">
        /// Too many service requests were made over the given time period.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/UpdateEnvironment">REST API Reference for UpdateEnvironment Operation</seealso>
        public virtual Task<UpdateEnvironmentResponse> UpdateEnvironmentAsync(UpdateEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnvironmentResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateEnvironmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateEnvironmentMembership


        /// <summary>
        /// Changes the settings of an existing environment member for an Cloud9 development environment.
        /// 
        ///  <important> 
        /// <para>
        /// Cloud9 is no longer available to new customers. Existing customers of Cloud9 can continue
        /// to use the service as normal. <a href="http://aws.amazon.com/blogs/devops/how-to-migrate-from-aws-cloud9-to-aws-ide-toolkits-or-aws-cloudshell/">Learn
        /// more"</a> 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironmentMembership service method.</param>
        /// 
        /// <returns>The response from the UpdateEnvironmentMembership service method, as returned by Cloud9.</returns>
        /// <exception cref="Amazon.Cloud9.Model.BadRequestException">
        /// The target request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.ConflictException">
        /// A conflict occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.ForbiddenException">
        /// An access permissions issue occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.LimitExceededException">
        /// A service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.NotFoundException">
        /// The target resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.TooManyRequestsException">
        /// Too many service requests were made over the given time period.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/UpdateEnvironmentMembership">REST API Reference for UpdateEnvironmentMembership Operation</seealso>
        public virtual UpdateEnvironmentMembershipResponse UpdateEnvironmentMembership(UpdateEnvironmentMembershipRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEnvironmentMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnvironmentMembershipResponseUnmarshaller.Instance;

            return Invoke<UpdateEnvironmentMembershipResponse>(request, options);
        }


        /// <summary>
        /// Changes the settings of an existing environment member for an Cloud9 development environment.
        /// 
        ///  <important> 
        /// <para>
        /// Cloud9 is no longer available to new customers. Existing customers of Cloud9 can continue
        /// to use the service as normal. <a href="http://aws.amazon.com/blogs/devops/how-to-migrate-from-aws-cloud9-to-aws-ide-toolkits-or-aws-cloudshell/">Learn
        /// more"</a> 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironmentMembership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEnvironmentMembership service method, as returned by Cloud9.</returns>
        /// <exception cref="Amazon.Cloud9.Model.BadRequestException">
        /// The target request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.ConflictException">
        /// A conflict occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.ForbiddenException">
        /// An access permissions issue occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.InternalServerErrorException">
        /// An internal server error occurred.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.LimitExceededException">
        /// A service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.NotFoundException">
        /// The target resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Cloud9.Model.TooManyRequestsException">
        /// Too many service requests were made over the given time period.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/UpdateEnvironmentMembership">REST API Reference for UpdateEnvironmentMembership Operation</seealso>
        public virtual Task<UpdateEnvironmentMembershipResponse> UpdateEnvironmentMembershipAsync(UpdateEnvironmentMembershipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEnvironmentMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnvironmentMembershipResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateEnvironmentMembershipResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        public Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request)
        {
            var parameters = new ServiceOperationEndpointParameters(request);
            return Config.DetermineServiceOperationEndpoint(parameters);
        }

        #endregion

    }
}