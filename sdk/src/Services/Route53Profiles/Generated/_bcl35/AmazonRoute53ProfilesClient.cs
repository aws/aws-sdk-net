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
 * Do not modify this file. This file is generated from the route53profiles-2018-05-10.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.Route53Profiles.Model;
using Amazon.Route53Profiles.Model.Internal.MarshallTransformations;
using Amazon.Route53Profiles.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Route53Profiles
{
    /// <summary>
    /// <para>Implementation for accessing Route53Profiles</para>
    ///
    /// With Amazon Route 53 Profiles you can share Route 53 configurations with VPCs and
    /// AWS accounts
    /// </summary>
    public partial class AmazonRoute53ProfilesClient : AmazonServiceClient, IAmazonRoute53Profiles
    {
        private static IServiceMetadata serviceMetadata = new AmazonRoute53ProfilesMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IRoute53ProfilesPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IRoute53ProfilesPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new Route53ProfilesPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonRoute53ProfilesClient with the credentials loaded from the application's
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
        public AmazonRoute53ProfilesClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRoute53ProfilesConfig()) { }

        /// <summary>
        /// Constructs AmazonRoute53ProfilesClient with the credentials loaded from the application's
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
        public AmazonRoute53ProfilesClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRoute53ProfilesConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonRoute53ProfilesClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonRoute53ProfilesClient Configuration Object</param>
        public AmazonRoute53ProfilesClient(AmazonRoute53ProfilesConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonRoute53ProfilesClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonRoute53ProfilesClient(AWSCredentials credentials)
            : this(credentials, new AmazonRoute53ProfilesConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53ProfilesClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRoute53ProfilesClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonRoute53ProfilesConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53ProfilesClient with AWS Credentials and an
        /// AmazonRoute53ProfilesClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonRoute53ProfilesClient Configuration Object</param>
        public AmazonRoute53ProfilesClient(AWSCredentials credentials, AmazonRoute53ProfilesConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53ProfilesClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonRoute53ProfilesClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRoute53ProfilesConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53ProfilesClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRoute53ProfilesClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRoute53ProfilesConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53ProfilesClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRoute53ProfilesClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonRoute53ProfilesClient Configuration Object</param>
        public AmazonRoute53ProfilesClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonRoute53ProfilesConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53ProfilesClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonRoute53ProfilesClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRoute53ProfilesConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53ProfilesClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRoute53ProfilesClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRoute53ProfilesConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53ProfilesClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRoute53ProfilesClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonRoute53ProfilesClient Configuration Object</param>
        public AmazonRoute53ProfilesClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonRoute53ProfilesConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonRoute53ProfilesEndpointResolver());
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


        #region  AssociateProfile

        /// <summary>
        /// Associates a Route 53 Profiles profile with a VPC. A VPC can have only one Profile
        /// associated with it, but a Profile can be associated with up to 5000 VPCs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateProfile service method.</param>
        /// 
        /// <returns>The response from the AssociateProfile service method, as returned by Route53Profiles.</returns>
        /// <exception cref="Amazon.Route53Profiles.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ConflictException">
        /// The request you submitted conflicts with an existing request.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.LimitExceededException">
        /// The request caused one or more limits to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ResourceExistsException">
        /// The resource you are trying to associate, has already been associated.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ResourceNotFoundException">
        /// The resource you are associating is not found.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ValidationException">
        /// You have provided an invalid command.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/AssociateProfile">REST API Reference for AssociateProfile Operation</seealso>
        public virtual AssociateProfileResponse AssociateProfile(AssociateProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateProfileResponseUnmarshaller.Instance;

            return Invoke<AssociateProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateProfile operation on AmazonRoute53ProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/AssociateProfile">REST API Reference for AssociateProfile Operation</seealso>
        public virtual IAsyncResult BeginAssociateProfile(AssociateProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateProfile.</param>
        /// 
        /// <returns>Returns a  AssociateProfileResult from Route53Profiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/AssociateProfile">REST API Reference for AssociateProfile Operation</seealso>
        public virtual AssociateProfileResponse EndAssociateProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateResourceToProfile

        /// <summary>
        /// Associates a DNS reource configuration to a Route 53 Profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateResourceToProfile service method.</param>
        /// 
        /// <returns>The response from the AssociateResourceToProfile service method, as returned by Route53Profiles.</returns>
        /// <exception cref="Amazon.Route53Profiles.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ConflictException">
        /// The request you submitted conflicts with an existing request.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.InternalServiceErrorException">
        /// An internal server error occured. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.LimitExceededException">
        /// The request caused one or more limits to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ResourceNotFoundException">
        /// The resource you are associating is not found.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ValidationException">
        /// You have provided an invalid command.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/AssociateResourceToProfile">REST API Reference for AssociateResourceToProfile Operation</seealso>
        public virtual AssociateResourceToProfileResponse AssociateResourceToProfile(AssociateResourceToProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateResourceToProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateResourceToProfileResponseUnmarshaller.Instance;

            return Invoke<AssociateResourceToProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateResourceToProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateResourceToProfile operation on AmazonRoute53ProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateResourceToProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/AssociateResourceToProfile">REST API Reference for AssociateResourceToProfile Operation</seealso>
        public virtual IAsyncResult BeginAssociateResourceToProfile(AssociateResourceToProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateResourceToProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateResourceToProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateResourceToProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateResourceToProfile.</param>
        /// 
        /// <returns>Returns a  AssociateResourceToProfileResult from Route53Profiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/AssociateResourceToProfile">REST API Reference for AssociateResourceToProfile Operation</seealso>
        public virtual AssociateResourceToProfileResponse EndAssociateResourceToProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateResourceToProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateProfile

        /// <summary>
        /// Creates an empty Route 53 Profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProfile service method.</param>
        /// 
        /// <returns>The response from the CreateProfile service method, as returned by Route53Profiles.</returns>
        /// <exception cref="Amazon.Route53Profiles.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.LimitExceededException">
        /// The request caused one or more limits to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ValidationException">
        /// You have provided an invalid command.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/CreateProfile">REST API Reference for CreateProfile Operation</seealso>
        public virtual CreateProfileResponse CreateProfile(CreateProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProfileResponseUnmarshaller.Instance;

            return Invoke<CreateProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProfile operation on AmazonRoute53ProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/CreateProfile">REST API Reference for CreateProfile Operation</seealso>
        public virtual IAsyncResult BeginCreateProfile(CreateProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateProfile.</param>
        /// 
        /// <returns>Returns a  CreateProfileResult from Route53Profiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/CreateProfile">REST API Reference for CreateProfile Operation</seealso>
        public virtual CreateProfileResponse EndCreateProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteProfile

        /// <summary>
        /// Deletes the specified Route 53 Profile. Before you can delete a profile, you must
        /// first disassociate it from all VPCs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProfile service method.</param>
        /// 
        /// <returns>The response from the DeleteProfile service method, as returned by Route53Profiles.</returns>
        /// <exception cref="Amazon.Route53Profiles.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ConflictException">
        /// The request you submitted conflicts with an existing request.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ResourceNotFoundException">
        /// The resource you are associating is not found.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ValidationException">
        /// You have provided an invalid command.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/DeleteProfile">REST API Reference for DeleteProfile Operation</seealso>
        public virtual DeleteProfileResponse DeleteProfile(DeleteProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProfileResponseUnmarshaller.Instance;

            return Invoke<DeleteProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProfile operation on AmazonRoute53ProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/DeleteProfile">REST API Reference for DeleteProfile Operation</seealso>
        public virtual IAsyncResult BeginDeleteProfile(DeleteProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteProfile.</param>
        /// 
        /// <returns>Returns a  DeleteProfileResult from Route53Profiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/DeleteProfile">REST API Reference for DeleteProfile Operation</seealso>
        public virtual DeleteProfileResponse EndDeleteProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateProfile

        /// <summary>
        /// Dissociates a specified Route 53 Profile from the specified VPC.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateProfile service method.</param>
        /// 
        /// <returns>The response from the DisassociateProfile service method, as returned by Route53Profiles.</returns>
        /// <exception cref="Amazon.Route53Profiles.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.LimitExceededException">
        /// The request caused one or more limits to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ResourceNotFoundException">
        /// The resource you are associating is not found.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ValidationException">
        /// You have provided an invalid command.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/DisassociateProfile">REST API Reference for DisassociateProfile Operation</seealso>
        public virtual DisassociateProfileResponse DisassociateProfile(DisassociateProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateProfileResponseUnmarshaller.Instance;

            return Invoke<DisassociateProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateProfile operation on AmazonRoute53ProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/DisassociateProfile">REST API Reference for DisassociateProfile Operation</seealso>
        public virtual IAsyncResult BeginDisassociateProfile(DisassociateProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateProfile.</param>
        /// 
        /// <returns>Returns a  DisassociateProfileResult from Route53Profiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/DisassociateProfile">REST API Reference for DisassociateProfile Operation</seealso>
        public virtual DisassociateProfileResponse EndDisassociateProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateResourceFromProfile

        /// <summary>
        /// Dissoaciated a specified resource, from the Route 53 Profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateResourceFromProfile service method.</param>
        /// 
        /// <returns>The response from the DisassociateResourceFromProfile service method, as returned by Route53Profiles.</returns>
        /// <exception cref="Amazon.Route53Profiles.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ConflictException">
        /// The request you submitted conflicts with an existing request.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.InternalServiceErrorException">
        /// An internal server error occured. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.LimitExceededException">
        /// The request caused one or more limits to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ResourceNotFoundException">
        /// The resource you are associating is not found.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ValidationException">
        /// You have provided an invalid command.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/DisassociateResourceFromProfile">REST API Reference for DisassociateResourceFromProfile Operation</seealso>
        public virtual DisassociateResourceFromProfileResponse DisassociateResourceFromProfile(DisassociateResourceFromProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateResourceFromProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateResourceFromProfileResponseUnmarshaller.Instance;

            return Invoke<DisassociateResourceFromProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateResourceFromProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateResourceFromProfile operation on AmazonRoute53ProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateResourceFromProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/DisassociateResourceFromProfile">REST API Reference for DisassociateResourceFromProfile Operation</seealso>
        public virtual IAsyncResult BeginDisassociateResourceFromProfile(DisassociateResourceFromProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateResourceFromProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateResourceFromProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateResourceFromProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateResourceFromProfile.</param>
        /// 
        /// <returns>Returns a  DisassociateResourceFromProfileResult from Route53Profiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/DisassociateResourceFromProfile">REST API Reference for DisassociateResourceFromProfile Operation</seealso>
        public virtual DisassociateResourceFromProfileResponse EndDisassociateResourceFromProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateResourceFromProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  GetProfile

        /// <summary>
        /// Returns information about a specified Route 53 Profile, such as whether whether the
        /// Profile is shared, and the current status of the Profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProfile service method.</param>
        /// 
        /// <returns>The response from the GetProfile service method, as returned by Route53Profiles.</returns>
        /// <exception cref="Amazon.Route53Profiles.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ResourceNotFoundException">
        /// The resource you are associating is not found.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ValidationException">
        /// You have provided an invalid command.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/GetProfile">REST API Reference for GetProfile Operation</seealso>
        public virtual GetProfileResponse GetProfile(GetProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProfileResponseUnmarshaller.Instance;

            return Invoke<GetProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetProfile operation on AmazonRoute53ProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/GetProfile">REST API Reference for GetProfile Operation</seealso>
        public virtual IAsyncResult BeginGetProfile(GetProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetProfile.</param>
        /// 
        /// <returns>Returns a  GetProfileResult from Route53Profiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/GetProfile">REST API Reference for GetProfile Operation</seealso>
        public virtual GetProfileResponse EndGetProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<GetProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  GetProfileAssociation

        /// <summary>
        /// Retrieves a Route 53 Profile association for a VPC. A VPC can have only one Profile
        /// association, but a Profile can be associated with up to 5000 VPCs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProfileAssociation service method.</param>
        /// 
        /// <returns>The response from the GetProfileAssociation service method, as returned by Route53Profiles.</returns>
        /// <exception cref="Amazon.Route53Profiles.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ResourceNotFoundException">
        /// The resource you are associating is not found.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ValidationException">
        /// You have provided an invalid command.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/GetProfileAssociation">REST API Reference for GetProfileAssociation Operation</seealso>
        public virtual GetProfileAssociationResponse GetProfileAssociation(GetProfileAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetProfileAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProfileAssociationResponseUnmarshaller.Instance;

            return Invoke<GetProfileAssociationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetProfileAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetProfileAssociation operation on AmazonRoute53ProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetProfileAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/GetProfileAssociation">REST API Reference for GetProfileAssociation Operation</seealso>
        public virtual IAsyncResult BeginGetProfileAssociation(GetProfileAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetProfileAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProfileAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetProfileAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetProfileAssociation.</param>
        /// 
        /// <returns>Returns a  GetProfileAssociationResult from Route53Profiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/GetProfileAssociation">REST API Reference for GetProfileAssociation Operation</seealso>
        public virtual GetProfileAssociationResponse EndGetProfileAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<GetProfileAssociationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetProfileResourceAssociation

        /// <summary>
        /// Returns information about a specified Route 53 Profile resource association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProfileResourceAssociation service method.</param>
        /// 
        /// <returns>The response from the GetProfileResourceAssociation service method, as returned by Route53Profiles.</returns>
        /// <exception cref="Amazon.Route53Profiles.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ResourceNotFoundException">
        /// The resource you are associating is not found.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ValidationException">
        /// You have provided an invalid command.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/GetProfileResourceAssociation">REST API Reference for GetProfileResourceAssociation Operation</seealso>
        public virtual GetProfileResourceAssociationResponse GetProfileResourceAssociation(GetProfileResourceAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetProfileResourceAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProfileResourceAssociationResponseUnmarshaller.Instance;

            return Invoke<GetProfileResourceAssociationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetProfileResourceAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetProfileResourceAssociation operation on AmazonRoute53ProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetProfileResourceAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/GetProfileResourceAssociation">REST API Reference for GetProfileResourceAssociation Operation</seealso>
        public virtual IAsyncResult BeginGetProfileResourceAssociation(GetProfileResourceAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetProfileResourceAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProfileResourceAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetProfileResourceAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetProfileResourceAssociation.</param>
        /// 
        /// <returns>Returns a  GetProfileResourceAssociationResult from Route53Profiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/GetProfileResourceAssociation">REST API Reference for GetProfileResourceAssociation Operation</seealso>
        public virtual GetProfileResourceAssociationResponse EndGetProfileResourceAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<GetProfileResourceAssociationResponse>(asyncResult);
        }

        #endregion
        
        #region  ListProfileAssociations

        /// <summary>
        /// Lists all the VPCs that the specified Route 53 Profile is associated with.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProfileAssociations service method.</param>
        /// 
        /// <returns>The response from the ListProfileAssociations service method, as returned by Route53Profiles.</returns>
        /// <exception cref="Amazon.Route53Profiles.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> you provided isn;t valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ValidationException">
        /// You have provided an invalid command.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/ListProfileAssociations">REST API Reference for ListProfileAssociations Operation</seealso>
        public virtual ListProfileAssociationsResponse ListProfileAssociations(ListProfileAssociationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProfileAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProfileAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListProfileAssociationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListProfileAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProfileAssociations operation on AmazonRoute53ProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProfileAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/ListProfileAssociations">REST API Reference for ListProfileAssociations Operation</seealso>
        public virtual IAsyncResult BeginListProfileAssociations(ListProfileAssociationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProfileAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProfileAssociationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListProfileAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProfileAssociations.</param>
        /// 
        /// <returns>Returns a  ListProfileAssociationsResult from Route53Profiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/ListProfileAssociations">REST API Reference for ListProfileAssociations Operation</seealso>
        public virtual ListProfileAssociationsResponse EndListProfileAssociations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListProfileAssociationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListProfileResourceAssociations

        /// <summary>
        /// Lists all the resource associations for the specified Route 53 Profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProfileResourceAssociations service method.</param>
        /// 
        /// <returns>The response from the ListProfileResourceAssociations service method, as returned by Route53Profiles.</returns>
        /// <exception cref="Amazon.Route53Profiles.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.InternalServiceErrorException">
        /// An internal server error occured. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> you provided isn;t valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ResourceNotFoundException">
        /// The resource you are associating is not found.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ValidationException">
        /// You have provided an invalid command.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/ListProfileResourceAssociations">REST API Reference for ListProfileResourceAssociations Operation</seealso>
        public virtual ListProfileResourceAssociationsResponse ListProfileResourceAssociations(ListProfileResourceAssociationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProfileResourceAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProfileResourceAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListProfileResourceAssociationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListProfileResourceAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProfileResourceAssociations operation on AmazonRoute53ProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProfileResourceAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/ListProfileResourceAssociations">REST API Reference for ListProfileResourceAssociations Operation</seealso>
        public virtual IAsyncResult BeginListProfileResourceAssociations(ListProfileResourceAssociationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProfileResourceAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProfileResourceAssociationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListProfileResourceAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProfileResourceAssociations.</param>
        /// 
        /// <returns>Returns a  ListProfileResourceAssociationsResult from Route53Profiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/ListProfileResourceAssociations">REST API Reference for ListProfileResourceAssociations Operation</seealso>
        public virtual ListProfileResourceAssociationsResponse EndListProfileResourceAssociations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListProfileResourceAssociationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListProfiles

        /// <summary>
        /// Lists all the Route 53 Profiles associated with your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProfiles service method.</param>
        /// 
        /// <returns>The response from the ListProfiles service method, as returned by Route53Profiles.</returns>
        /// <exception cref="Amazon.Route53Profiles.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> you provided isn;t valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ValidationException">
        /// You have provided an invalid command.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/ListProfiles">REST API Reference for ListProfiles Operation</seealso>
        public virtual ListProfilesResponse ListProfiles(ListProfilesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProfilesResponseUnmarshaller.Instance;

            return Invoke<ListProfilesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListProfiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProfiles operation on AmazonRoute53ProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProfiles
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/ListProfiles">REST API Reference for ListProfiles Operation</seealso>
        public virtual IAsyncResult BeginListProfiles(ListProfilesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProfilesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListProfiles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProfiles.</param>
        /// 
        /// <returns>Returns a  ListProfilesResult from Route53Profiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/ListProfiles">REST API Reference for ListProfiles Operation</seealso>
        public virtual ListProfilesResponse EndListProfiles(IAsyncResult asyncResult)
        {
            return EndInvoke<ListProfilesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Lists the tags that you associated with the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Route53Profiles.</returns>
        /// <exception cref="Amazon.Route53Profiles.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ConflictException">
        /// The request you submitted conflicts with an existing request.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ResourceNotFoundException">
        /// The resource you are associating is not found.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ValidationException">
        /// You have provided an invalid command.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonRoute53ProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  ListTagsForResourceResult from Route53Profiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Adds one or more tags to a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Route53Profiles.</returns>
        /// <exception cref="Amazon.Route53Profiles.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ResourceNotFoundException">
        /// The resource you are associating is not found.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ValidationException">
        /// You have provided an invalid command.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonRoute53ProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  TagResourceResult from Route53Profiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes one or more tags from a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Route53Profiles.</returns>
        /// <exception cref="Amazon.Route53Profiles.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ConflictException">
        /// The request you submitted conflicts with an existing request.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ResourceNotFoundException">
        /// The resource you are associating is not found.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ValidationException">
        /// You have provided an invalid command.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonRoute53ProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  UntagResourceResult from Route53Profiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateProfileResourceAssociation

        /// <summary>
        /// Updates the specified Route 53 Profile resourse association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProfileResourceAssociation service method.</param>
        /// 
        /// <returns>The response from the UpdateProfileResourceAssociation service method, as returned by Route53Profiles.</returns>
        /// <exception cref="Amazon.Route53Profiles.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ConflictException">
        /// The request you submitted conflicts with an existing request.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.InternalServiceErrorException">
        /// An internal server error occured. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.LimitExceededException">
        /// The request caused one or more limits to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ResourceNotFoundException">
        /// The resource you are associating is not found.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ValidationException">
        /// You have provided an invalid command.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/UpdateProfileResourceAssociation">REST API Reference for UpdateProfileResourceAssociation Operation</seealso>
        public virtual UpdateProfileResourceAssociationResponse UpdateProfileResourceAssociation(UpdateProfileResourceAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProfileResourceAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProfileResourceAssociationResponseUnmarshaller.Instance;

            return Invoke<UpdateProfileResourceAssociationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateProfileResourceAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateProfileResourceAssociation operation on AmazonRoute53ProfilesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateProfileResourceAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/UpdateProfileResourceAssociation">REST API Reference for UpdateProfileResourceAssociation Operation</seealso>
        public virtual IAsyncResult BeginUpdateProfileResourceAssociation(UpdateProfileResourceAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateProfileResourceAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProfileResourceAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateProfileResourceAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateProfileResourceAssociation.</param>
        /// 
        /// <returns>Returns a  UpdateProfileResourceAssociationResult from Route53Profiles.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/UpdateProfileResourceAssociation">REST API Reference for UpdateProfileResourceAssociation Operation</seealso>
        public virtual UpdateProfileResourceAssociationResponse EndUpdateProfileResourceAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateProfileResourceAssociationResponse>(asyncResult);
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
            var requestContext = new RequestContext(false, CreateSigner())
            {
                ClientConfig = Config,
                OriginalRequest = request,
                Request = new DefaultRequest(request, ServiceMetadata.ServiceId)
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            var resolver = new AmazonRoute53ProfilesEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}