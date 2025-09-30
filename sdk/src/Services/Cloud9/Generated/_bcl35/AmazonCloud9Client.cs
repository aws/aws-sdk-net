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
using System.Collections.Generic;
using System.Net;

using Amazon.Cloud9.Model;
using Amazon.Cloud9.Model.Internal.MarshallTransformations;
using Amazon.Cloud9.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

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

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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
#endif
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
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
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
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonCloud9EndpointResolver());
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
        /// Initiates the asynchronous execution of the CreateEnvironmentEC2 operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironmentEC2 operation on AmazonCloud9Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEnvironmentEC2
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/CreateEnvironmentEC2">REST API Reference for CreateEnvironmentEC2 Operation</seealso>
        public virtual IAsyncResult BeginCreateEnvironmentEC2(CreateEnvironmentEC2Request request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEnvironmentEC2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnvironmentEC2ResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEnvironmentEC2 operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEnvironmentEC2.</param>
        /// 
        /// <returns>Returns a  CreateEnvironmentEC2Result from Cloud9.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/CreateEnvironmentEC2">REST API Reference for CreateEnvironmentEC2 Operation</seealso>
        public virtual CreateEnvironmentEC2Response EndCreateEnvironmentEC2(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateEnvironmentEC2Response>(asyncResult);
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
        /// Initiates the asynchronous execution of the CreateEnvironmentMembership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironmentMembership operation on AmazonCloud9Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEnvironmentMembership
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/CreateEnvironmentMembership">REST API Reference for CreateEnvironmentMembership Operation</seealso>
        public virtual IAsyncResult BeginCreateEnvironmentMembership(CreateEnvironmentMembershipRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEnvironmentMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnvironmentMembershipResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEnvironmentMembership operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEnvironmentMembership.</param>
        /// 
        /// <returns>Returns a  CreateEnvironmentMembershipResult from Cloud9.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/CreateEnvironmentMembership">REST API Reference for CreateEnvironmentMembership Operation</seealso>
        public virtual CreateEnvironmentMembershipResponse EndCreateEnvironmentMembership(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateEnvironmentMembershipResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DeleteEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironment operation on AmazonCloud9Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/DeleteEnvironment">REST API Reference for DeleteEnvironment Operation</seealso>
        public virtual IAsyncResult BeginDeleteEnvironment(DeleteEnvironmentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEnvironment.</param>
        /// 
        /// <returns>Returns a  DeleteEnvironmentResult from Cloud9.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/DeleteEnvironment">REST API Reference for DeleteEnvironment Operation</seealso>
        public virtual DeleteEnvironmentResponse EndDeleteEnvironment(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteEnvironmentResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DeleteEnvironmentMembership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironmentMembership operation on AmazonCloud9Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEnvironmentMembership
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/DeleteEnvironmentMembership">REST API Reference for DeleteEnvironmentMembership Operation</seealso>
        public virtual IAsyncResult BeginDeleteEnvironmentMembership(DeleteEnvironmentMembershipRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentMembershipResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEnvironmentMembership operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEnvironmentMembership.</param>
        /// 
        /// <returns>Returns a  DeleteEnvironmentMembershipResult from Cloud9.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/DeleteEnvironmentMembership">REST API Reference for DeleteEnvironmentMembership Operation</seealso>
        public virtual DeleteEnvironmentMembershipResponse EndDeleteEnvironmentMembership(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteEnvironmentMembershipResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DescribeEnvironmentMemberships operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironmentMemberships operation on AmazonCloud9Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEnvironmentMemberships
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/DescribeEnvironmentMemberships">REST API Reference for DescribeEnvironmentMemberships Operation</seealso>
        public virtual IAsyncResult BeginDescribeEnvironmentMemberships(DescribeEnvironmentMembershipsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEnvironmentMembershipsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEnvironmentMembershipsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEnvironmentMemberships operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEnvironmentMemberships.</param>
        /// 
        /// <returns>Returns a  DescribeEnvironmentMembershipsResult from Cloud9.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/DescribeEnvironmentMemberships">REST API Reference for DescribeEnvironmentMemberships Operation</seealso>
        public virtual DescribeEnvironmentMembershipsResponse EndDescribeEnvironmentMemberships(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeEnvironmentMembershipsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DescribeEnvironments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironments operation on AmazonCloud9Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEnvironments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/DescribeEnvironments">REST API Reference for DescribeEnvironments Operation</seealso>
        public virtual IAsyncResult BeginDescribeEnvironments(DescribeEnvironmentsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEnvironmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEnvironmentsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEnvironments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEnvironments.</param>
        /// 
        /// <returns>Returns a  DescribeEnvironmentsResult from Cloud9.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/DescribeEnvironments">REST API Reference for DescribeEnvironments Operation</seealso>
        public virtual DescribeEnvironmentsResponse EndDescribeEnvironments(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeEnvironmentsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DescribeEnvironmentStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironmentStatus operation on AmazonCloud9Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEnvironmentStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/DescribeEnvironmentStatus">REST API Reference for DescribeEnvironmentStatus Operation</seealso>
        public virtual IAsyncResult BeginDescribeEnvironmentStatus(DescribeEnvironmentStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEnvironmentStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEnvironmentStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEnvironmentStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEnvironmentStatus.</param>
        /// 
        /// <returns>Returns a  DescribeEnvironmentStatusResult from Cloud9.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/DescribeEnvironmentStatus">REST API Reference for DescribeEnvironmentStatus Operation</seealso>
        public virtual DescribeEnvironmentStatusResponse EndDescribeEnvironmentStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeEnvironmentStatusResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListEnvironments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironments operation on AmazonCloud9Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEnvironments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/ListEnvironments">REST API Reference for ListEnvironments Operation</seealso>
        public virtual IAsyncResult BeginListEnvironments(ListEnvironmentsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEnvironmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListEnvironments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEnvironments.</param>
        /// 
        /// <returns>Returns a  ListEnvironmentsResult from Cloud9.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/ListEnvironments">REST API Reference for ListEnvironments Operation</seealso>
        public virtual ListEnvironmentsResponse EndListEnvironments(IAsyncResult asyncResult)
        {
            return EndInvoke<ListEnvironmentsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonCloud9Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from Cloud9.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonCloud9Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from Cloud9.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonCloud9Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from Cloud9.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the UpdateEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironment operation on AmazonCloud9Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/UpdateEnvironment">REST API Reference for UpdateEnvironment Operation</seealso>
        public virtual IAsyncResult BeginUpdateEnvironment(UpdateEnvironmentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnvironmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEnvironment.</param>
        /// 
        /// <returns>Returns a  UpdateEnvironmentResult from Cloud9.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/UpdateEnvironment">REST API Reference for UpdateEnvironment Operation</seealso>
        public virtual UpdateEnvironmentResponse EndUpdateEnvironment(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateEnvironmentResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the UpdateEnvironmentMembership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironmentMembership operation on AmazonCloud9Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEnvironmentMembership
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/UpdateEnvironmentMembership">REST API Reference for UpdateEnvironmentMembership Operation</seealso>
        public virtual IAsyncResult BeginUpdateEnvironmentMembership(UpdateEnvironmentMembershipRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEnvironmentMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnvironmentMembershipResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEnvironmentMembership operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEnvironmentMembership.</param>
        /// 
        /// <returns>Returns a  UpdateEnvironmentMembershipResult from Cloud9.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloud9-2017-09-23/UpdateEnvironmentMembership">REST API Reference for UpdateEnvironmentMembership Operation</seealso>
        public virtual UpdateEnvironmentMembershipResponse EndUpdateEnvironmentMembership(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateEnvironmentMembershipResponse>(asyncResult);
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
            var requestContext = new Amazon.Runtime.Internal.RequestContext(false, CreateSigner())
            {
                ClientConfig = Config,
                OriginalRequest = request,
                Request = new Amazon.Runtime.Internal.DefaultRequest(request, ServiceMetadata.ServiceId)
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            var resolver = new AmazonCloud9EndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}