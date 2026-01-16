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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.DataZone.Model;
using Amazon.DataZone.Model.Internal.MarshallTransformations;
using Amazon.DataZone.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.DataZone
{
    /// <summary>
    /// <para>Implementation for accessing DataZone</para>
    ///
    /// Amazon DataZone is a data management service that enables you to catalog, discover,
    /// govern, share, and analyze your data. With Amazon DataZone, you can share and access
    /// your data across accounts and supported regions. Amazon DataZone simplifies your experience
    /// across Amazon Web Services services, including, but not limited to, Amazon Redshift,
    /// Amazon Athena, Amazon Web Services Glue, and Amazon Web Services Lake Formation.
    /// </summary>
    public partial class AmazonDataZoneClient : AmazonServiceClient, IAmazonDataZone
    {
        private static IServiceMetadata serviceMetadata = new AmazonDataZoneMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IDataZonePaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IDataZonePaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new DataZonePaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonDataZoneClient with the credentials loaded from the application's
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
        public AmazonDataZoneClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonDataZoneConfig()) { }

        /// <summary>
        /// Constructs AmazonDataZoneClient with the credentials loaded from the application's
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
        public AmazonDataZoneClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonDataZoneConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonDataZoneClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonDataZoneClient Configuration Object</param>
        public AmazonDataZoneClient(AmazonDataZoneConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonDataZoneClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonDataZoneClient(AWSCredentials credentials)
            : this(credentials, new AmazonDataZoneConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDataZoneClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDataZoneClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonDataZoneConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDataZoneClient with AWS Credentials and an
        /// AmazonDataZoneClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonDataZoneClient Configuration Object</param>
        public AmazonDataZoneClient(AWSCredentials credentials, AmazonDataZoneConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDataZoneClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonDataZoneClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDataZoneConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDataZoneClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDataZoneClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDataZoneConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonDataZoneClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDataZoneClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonDataZoneClient Configuration Object</param>
        public AmazonDataZoneClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonDataZoneConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDataZoneClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonDataZoneClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDataZoneConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDataZoneClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDataZoneClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDataZoneConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDataZoneClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDataZoneClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonDataZoneClient Configuration Object</param>
        public AmazonDataZoneClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonDataZoneConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonDataZoneEndpointResolver());
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


        #region  AcceptPredictions

        /// <summary>
        /// Accepts automatically generated business-friendly metadata for your Amazon DataZone
        /// assets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptPredictions service method.</param>
        /// 
        /// <returns>The response from the AcceptPredictions service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/AcceptPredictions">REST API Reference for AcceptPredictions Operation</seealso>
        public virtual AcceptPredictionsResponse AcceptPredictions(AcceptPredictionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AcceptPredictionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptPredictionsResponseUnmarshaller.Instance;

            return Invoke<AcceptPredictionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AcceptPredictions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptPredictions operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAcceptPredictions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/AcceptPredictions">REST API Reference for AcceptPredictions Operation</seealso>
        public virtual IAsyncResult BeginAcceptPredictions(AcceptPredictionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AcceptPredictionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptPredictionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AcceptPredictions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAcceptPredictions.</param>
        /// 
        /// <returns>Returns a  AcceptPredictionsResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/AcceptPredictions">REST API Reference for AcceptPredictions Operation</seealso>
        public virtual AcceptPredictionsResponse EndAcceptPredictions(IAsyncResult asyncResult)
        {
            return EndInvoke<AcceptPredictionsResponse>(asyncResult);
        }

        #endregion
        
        #region  AcceptSubscriptionRequest

        /// <summary>
        /// Accepts a subscription request to a specific asset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptSubscriptionRequest service method.</param>
        /// 
        /// <returns>The response from the AcceptSubscriptionRequest service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/AcceptSubscriptionRequest">REST API Reference for AcceptSubscriptionRequest Operation</seealso>
        public virtual AcceptSubscriptionRequestResponse AcceptSubscriptionRequest(AcceptSubscriptionRequestRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AcceptSubscriptionRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptSubscriptionRequestResponseUnmarshaller.Instance;

            return Invoke<AcceptSubscriptionRequestResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AcceptSubscriptionRequest operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptSubscriptionRequest operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAcceptSubscriptionRequest
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/AcceptSubscriptionRequest">REST API Reference for AcceptSubscriptionRequest Operation</seealso>
        public virtual IAsyncResult BeginAcceptSubscriptionRequest(AcceptSubscriptionRequestRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AcceptSubscriptionRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptSubscriptionRequestResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AcceptSubscriptionRequest operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAcceptSubscriptionRequest.</param>
        /// 
        /// <returns>Returns a  AcceptSubscriptionRequestResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/AcceptSubscriptionRequest">REST API Reference for AcceptSubscriptionRequest Operation</seealso>
        public virtual AcceptSubscriptionRequestResponse EndAcceptSubscriptionRequest(IAsyncResult asyncResult)
        {
            return EndInvoke<AcceptSubscriptionRequestResponse>(asyncResult);
        }

        #endregion
        
        #region  AddEntityOwner

        /// <summary>
        /// Adds the owner of an entity (a domain unit).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddEntityOwner service method.</param>
        /// 
        /// <returns>The response from the AddEntityOwner service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/AddEntityOwner">REST API Reference for AddEntityOwner Operation</seealso>
        public virtual AddEntityOwnerResponse AddEntityOwner(AddEntityOwnerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddEntityOwnerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddEntityOwnerResponseUnmarshaller.Instance;

            return Invoke<AddEntityOwnerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddEntityOwner operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddEntityOwner operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddEntityOwner
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/AddEntityOwner">REST API Reference for AddEntityOwner Operation</seealso>
        public virtual IAsyncResult BeginAddEntityOwner(AddEntityOwnerRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddEntityOwnerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddEntityOwnerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AddEntityOwner operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddEntityOwner.</param>
        /// 
        /// <returns>Returns a  AddEntityOwnerResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/AddEntityOwner">REST API Reference for AddEntityOwner Operation</seealso>
        public virtual AddEntityOwnerResponse EndAddEntityOwner(IAsyncResult asyncResult)
        {
            return EndInvoke<AddEntityOwnerResponse>(asyncResult);
        }

        #endregion
        
        #region  AddPolicyGrant

        /// <summary>
        /// Adds a policy grant (an authorization policy) to a specified entity, including domain
        /// units, environment blueprint configurations, or environment profiles.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddPolicyGrant service method.</param>
        /// 
        /// <returns>The response from the AddPolicyGrant service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/AddPolicyGrant">REST API Reference for AddPolicyGrant Operation</seealso>
        public virtual AddPolicyGrantResponse AddPolicyGrant(AddPolicyGrantRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddPolicyGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddPolicyGrantResponseUnmarshaller.Instance;

            return Invoke<AddPolicyGrantResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddPolicyGrant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddPolicyGrant operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddPolicyGrant
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/AddPolicyGrant">REST API Reference for AddPolicyGrant Operation</seealso>
        public virtual IAsyncResult BeginAddPolicyGrant(AddPolicyGrantRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AddPolicyGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddPolicyGrantResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AddPolicyGrant operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddPolicyGrant.</param>
        /// 
        /// <returns>Returns a  AddPolicyGrantResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/AddPolicyGrant">REST API Reference for AddPolicyGrant Operation</seealso>
        public virtual AddPolicyGrantResponse EndAddPolicyGrant(IAsyncResult asyncResult)
        {
            return EndInvoke<AddPolicyGrantResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateEnvironmentRole

        /// <summary>
        /// Associates the environment role in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateEnvironmentRole service method.</param>
        /// 
        /// <returns>The response from the AssociateEnvironmentRole service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/AssociateEnvironmentRole">REST API Reference for AssociateEnvironmentRole Operation</seealso>
        public virtual AssociateEnvironmentRoleResponse AssociateEnvironmentRole(AssociateEnvironmentRoleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateEnvironmentRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateEnvironmentRoleResponseUnmarshaller.Instance;

            return Invoke<AssociateEnvironmentRoleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateEnvironmentRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateEnvironmentRole operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateEnvironmentRole
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/AssociateEnvironmentRole">REST API Reference for AssociateEnvironmentRole Operation</seealso>
        public virtual IAsyncResult BeginAssociateEnvironmentRole(AssociateEnvironmentRoleRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateEnvironmentRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateEnvironmentRoleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateEnvironmentRole operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateEnvironmentRole.</param>
        /// 
        /// <returns>Returns a  AssociateEnvironmentRoleResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/AssociateEnvironmentRole">REST API Reference for AssociateEnvironmentRole Operation</seealso>
        public virtual AssociateEnvironmentRoleResponse EndAssociateEnvironmentRole(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateEnvironmentRoleResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateGovernedTerms

        /// <summary>
        /// Associates governed terms with an asset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateGovernedTerms service method.</param>
        /// 
        /// <returns>The response from the AssociateGovernedTerms service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/AssociateGovernedTerms">REST API Reference for AssociateGovernedTerms Operation</seealso>
        public virtual AssociateGovernedTermsResponse AssociateGovernedTerms(AssociateGovernedTermsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateGovernedTermsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateGovernedTermsResponseUnmarshaller.Instance;

            return Invoke<AssociateGovernedTermsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateGovernedTerms operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateGovernedTerms operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateGovernedTerms
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/AssociateGovernedTerms">REST API Reference for AssociateGovernedTerms Operation</seealso>
        public virtual IAsyncResult BeginAssociateGovernedTerms(AssociateGovernedTermsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateGovernedTermsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateGovernedTermsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateGovernedTerms operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateGovernedTerms.</param>
        /// 
        /// <returns>Returns a  AssociateGovernedTermsResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/AssociateGovernedTerms">REST API Reference for AssociateGovernedTerms Operation</seealso>
        public virtual AssociateGovernedTermsResponse EndAssociateGovernedTerms(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateGovernedTermsResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchGetAttributesMetadata

        /// <summary>
        /// Gets the attribute metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetAttributesMetadata service method.</param>
        /// 
        /// <returns>The response from the BatchGetAttributesMetadata service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/BatchGetAttributesMetadata">REST API Reference for BatchGetAttributesMetadata Operation</seealso>
        public virtual BatchGetAttributesMetadataResponse BatchGetAttributesMetadata(BatchGetAttributesMetadataRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetAttributesMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetAttributesMetadataResponseUnmarshaller.Instance;

            return Invoke<BatchGetAttributesMetadataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetAttributesMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetAttributesMetadata operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetAttributesMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/BatchGetAttributesMetadata">REST API Reference for BatchGetAttributesMetadata Operation</seealso>
        public virtual IAsyncResult BeginBatchGetAttributesMetadata(BatchGetAttributesMetadataRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetAttributesMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetAttributesMetadataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetAttributesMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetAttributesMetadata.</param>
        /// 
        /// <returns>Returns a  BatchGetAttributesMetadataResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/BatchGetAttributesMetadata">REST API Reference for BatchGetAttributesMetadata Operation</seealso>
        public virtual BatchGetAttributesMetadataResponse EndBatchGetAttributesMetadata(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchGetAttributesMetadataResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchPutAttributesMetadata

        /// <summary>
        /// Writes the attribute metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchPutAttributesMetadata service method.</param>
        /// 
        /// <returns>The response from the BatchPutAttributesMetadata service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/BatchPutAttributesMetadata">REST API Reference for BatchPutAttributesMetadata Operation</seealso>
        public virtual BatchPutAttributesMetadataResponse BatchPutAttributesMetadata(BatchPutAttributesMetadataRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchPutAttributesMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchPutAttributesMetadataResponseUnmarshaller.Instance;

            return Invoke<BatchPutAttributesMetadataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchPutAttributesMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchPutAttributesMetadata operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchPutAttributesMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/BatchPutAttributesMetadata">REST API Reference for BatchPutAttributesMetadata Operation</seealso>
        public virtual IAsyncResult BeginBatchPutAttributesMetadata(BatchPutAttributesMetadataRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchPutAttributesMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchPutAttributesMetadataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchPutAttributesMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchPutAttributesMetadata.</param>
        /// 
        /// <returns>Returns a  BatchPutAttributesMetadataResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/BatchPutAttributesMetadata">REST API Reference for BatchPutAttributesMetadata Operation</seealso>
        public virtual BatchPutAttributesMetadataResponse EndBatchPutAttributesMetadata(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchPutAttributesMetadataResponse>(asyncResult);
        }

        #endregion
        
        #region  CancelMetadataGenerationRun

        /// <summary>
        /// Cancels the metadata generation run.
        /// 
        ///  
        /// <para>
        /// Prerequisites:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The run must exist and be in a cancelable status (e.g., SUBMITTED, IN_PROGRESS). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Runs in SUCCEEDED status cannot be cancelled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// User must have access to the run and cancel permissions.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelMetadataGenerationRun service method.</param>
        /// 
        /// <returns>The response from the CancelMetadataGenerationRun service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CancelMetadataGenerationRun">REST API Reference for CancelMetadataGenerationRun Operation</seealso>
        public virtual CancelMetadataGenerationRunResponse CancelMetadataGenerationRun(CancelMetadataGenerationRunRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelMetadataGenerationRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelMetadataGenerationRunResponseUnmarshaller.Instance;

            return Invoke<CancelMetadataGenerationRunResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelMetadataGenerationRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelMetadataGenerationRun operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelMetadataGenerationRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CancelMetadataGenerationRun">REST API Reference for CancelMetadataGenerationRun Operation</seealso>
        public virtual IAsyncResult BeginCancelMetadataGenerationRun(CancelMetadataGenerationRunRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelMetadataGenerationRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelMetadataGenerationRunResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelMetadataGenerationRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelMetadataGenerationRun.</param>
        /// 
        /// <returns>Returns a  CancelMetadataGenerationRunResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CancelMetadataGenerationRun">REST API Reference for CancelMetadataGenerationRun Operation</seealso>
        public virtual CancelMetadataGenerationRunResponse EndCancelMetadataGenerationRun(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelMetadataGenerationRunResponse>(asyncResult);
        }

        #endregion
        
        #region  CancelSubscription

        /// <summary>
        /// Cancels the subscription to the specified asset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelSubscription service method.</param>
        /// 
        /// <returns>The response from the CancelSubscription service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CancelSubscription">REST API Reference for CancelSubscription Operation</seealso>
        public virtual CancelSubscriptionResponse CancelSubscription(CancelSubscriptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelSubscriptionResponseUnmarshaller.Instance;

            return Invoke<CancelSubscriptionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelSubscription operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CancelSubscription">REST API Reference for CancelSubscription Operation</seealso>
        public virtual IAsyncResult BeginCancelSubscription(CancelSubscriptionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelSubscriptionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelSubscription.</param>
        /// 
        /// <returns>Returns a  CancelSubscriptionResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CancelSubscription">REST API Reference for CancelSubscription Operation</seealso>
        public virtual CancelSubscriptionResponse EndCancelSubscription(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelSubscriptionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAccountPool

        /// <summary>
        /// Creates an account pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccountPool service method.</param>
        /// 
        /// <returns>The response from the CreateAccountPool service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateAccountPool">REST API Reference for CreateAccountPool Operation</seealso>
        public virtual CreateAccountPoolResponse CreateAccountPool(CreateAccountPoolRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAccountPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAccountPoolResponseUnmarshaller.Instance;

            return Invoke<CreateAccountPoolResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAccountPool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAccountPool operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAccountPool
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateAccountPool">REST API Reference for CreateAccountPool Operation</seealso>
        public virtual IAsyncResult BeginCreateAccountPool(CreateAccountPoolRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAccountPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAccountPoolResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAccountPool operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAccountPool.</param>
        /// 
        /// <returns>Returns a  CreateAccountPoolResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateAccountPool">REST API Reference for CreateAccountPool Operation</seealso>
        public virtual CreateAccountPoolResponse EndCreateAccountPool(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAccountPoolResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAsset

        /// <summary>
        /// Creates an asset in Amazon DataZone catalog.
        /// 
        ///  
        /// <para>
        /// Before creating assets, make sure that the following requirements are met:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>--domain-identifier</c> must refer to an existing domain.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>--owning-project-identifier</c> must be a valid project within the domain.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Asset type must be created beforehand using <c>create-asset-type</c>, or be a supported
        /// system-defined type. For more information, see <a href="https://docs.aws.amazon.com/cli/latest/reference/datazone/create-asset-type.html">create-asset-type</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>--type-revision</c> (if used) must match a valid revision of the asset type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>formsInput</c> is required when it is associated as required in the <c>asset-type</c>.
        /// For more information, see <a href="https://docs.aws.amazon.com/cli/latest/reference/datazone/create-form-type.html">create-form-type</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Form content must include all required fields as per the form schema (e.g., <c>bucketArn</c>).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You must invoke the following pre-requisite commands before invoking this API:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/datazone/latest/APIReference/API_CreateFormType.html">CreateFormType</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/datazone/latest/APIReference/API_CreateAssetType.html">CreateAssetType</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAsset service method.</param>
        /// 
        /// <returns>The response from the CreateAsset service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateAsset">REST API Reference for CreateAsset Operation</seealso>
        public virtual CreateAssetResponse CreateAsset(CreateAssetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssetResponseUnmarshaller.Instance;

            return Invoke<CreateAssetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAsset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAsset operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAsset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateAsset">REST API Reference for CreateAsset Operation</seealso>
        public virtual IAsyncResult BeginCreateAsset(CreateAssetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAsset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAsset.</param>
        /// 
        /// <returns>Returns a  CreateAssetResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateAsset">REST API Reference for CreateAsset Operation</seealso>
        public virtual CreateAssetResponse EndCreateAsset(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAssetResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAssetFilter

        /// <summary>
        /// Creates a data asset filter.
        /// 
        ///  
        /// <para>
        /// Asset filters provide a sophisticated way to create controlled views of data assets
        /// by selecting specific columns or applying row-level filters. This capability is crucial
        /// for organizations that need to share data while maintaining security and privacy controls.
        /// For example, your database might be filtered to show only non-PII fields to certain
        /// users, or sales data might be filtered by region for different regional teams. Asset
        /// filters enable fine-grained access control while maintaining a single source of truth.
        /// </para>
        ///  
        /// <para>
        /// Prerequisites:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A valid domain (<c>--domain-identifier</c>) must exist. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A data asset (<c>--asset-identifier</c>) must already be created under that domain.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The asset must have the referenced columns available in its schema for column-based
        /// filtering.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You cannot specify both (<c>columnConfiguration</c>, <c>rowConfiguration</c>)at the
        /// same time.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssetFilter service method.</param>
        /// 
        /// <returns>The response from the CreateAssetFilter service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateAssetFilter">REST API Reference for CreateAssetFilter Operation</seealso>
        public virtual CreateAssetFilterResponse CreateAssetFilter(CreateAssetFilterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAssetFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssetFilterResponseUnmarshaller.Instance;

            return Invoke<CreateAssetFilterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAssetFilter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAssetFilter operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAssetFilter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateAssetFilter">REST API Reference for CreateAssetFilter Operation</seealso>
        public virtual IAsyncResult BeginCreateAssetFilter(CreateAssetFilterRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAssetFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssetFilterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAssetFilter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAssetFilter.</param>
        /// 
        /// <returns>Returns a  CreateAssetFilterResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateAssetFilter">REST API Reference for CreateAssetFilter Operation</seealso>
        public virtual CreateAssetFilterResponse EndCreateAssetFilter(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAssetFilterResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAssetRevision

        /// <summary>
        /// Creates a revision of the asset.
        /// 
        ///  
        /// <para>
        /// Asset revisions represent new versions of existing assets, capturing changes to either
        /// the underlying data or its metadata. They maintain a historical record of how assets
        /// evolve over time, who made changes, and when those changes occurred. This versioning
        /// capability is crucial for governance and compliance, allowing organizations to track
        /// changes, understand their impact, and roll back if necessary.
        /// </para>
        ///  
        /// <para>
        /// Prerequisites:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Asset must already exist in the domain with identifier. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>formsInput</c> is required when asset has the form type. <c>typeRevision</c> should
        /// be the latest version of form type. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The form content must include all required fields (e.g., <c>bucketArn</c> for <c>S3ObjectCollectionForm</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The owning project of the original asset must still exist and be active.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// User must have write access to the project and domain.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssetRevision service method.</param>
        /// 
        /// <returns>The response from the CreateAssetRevision service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateAssetRevision">REST API Reference for CreateAssetRevision Operation</seealso>
        public virtual CreateAssetRevisionResponse CreateAssetRevision(CreateAssetRevisionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAssetRevisionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssetRevisionResponseUnmarshaller.Instance;

            return Invoke<CreateAssetRevisionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAssetRevision operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAssetRevision operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAssetRevision
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateAssetRevision">REST API Reference for CreateAssetRevision Operation</seealso>
        public virtual IAsyncResult BeginCreateAssetRevision(CreateAssetRevisionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAssetRevisionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssetRevisionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAssetRevision operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAssetRevision.</param>
        /// 
        /// <returns>Returns a  CreateAssetRevisionResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateAssetRevision">REST API Reference for CreateAssetRevision Operation</seealso>
        public virtual CreateAssetRevisionResponse EndCreateAssetRevision(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAssetRevisionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateAssetType

        /// <summary>
        /// Creates a custom asset type.
        /// 
        ///  
        /// <para>
        /// Prerequisites:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The <c>formsInput</c> field is required, however, can be passed as empty (e.g. <c>-forms-input
        /// {})</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must have <c>CreateAssetType</c> permissions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The domain-identifier and owning-project-identifier must be valid and active.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The name of the asset type must be unique within the domain — duplicate names will
        /// cause failure.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// JSON input must be valid — incorrect formatting causes Invalid JSON errors.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssetType service method.</param>
        /// 
        /// <returns>The response from the CreateAssetType service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateAssetType">REST API Reference for CreateAssetType Operation</seealso>
        public virtual CreateAssetTypeResponse CreateAssetType(CreateAssetTypeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAssetTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssetTypeResponseUnmarshaller.Instance;

            return Invoke<CreateAssetTypeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAssetType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAssetType operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAssetType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateAssetType">REST API Reference for CreateAssetType Operation</seealso>
        public virtual IAsyncResult BeginCreateAssetType(CreateAssetTypeRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAssetTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAssetTypeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAssetType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAssetType.</param>
        /// 
        /// <returns>Returns a  CreateAssetTypeResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateAssetType">REST API Reference for CreateAssetType Operation</seealso>
        public virtual CreateAssetTypeResponse EndCreateAssetType(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAssetTypeResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateConnection

        /// <summary>
        /// Creates a new connection. In Amazon DataZone, a connection enables you to connect
        /// your resources (domains, projects, and environments) to external resources and services.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConnection service method.</param>
        /// 
        /// <returns>The response from the CreateConnection service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateConnection">REST API Reference for CreateConnection Operation</seealso>
        public virtual CreateConnectionResponse CreateConnection(CreateConnectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConnectionResponseUnmarshaller.Instance;

            return Invoke<CreateConnectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConnection operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateConnection">REST API Reference for CreateConnection Operation</seealso>
        public virtual IAsyncResult BeginCreateConnection(CreateConnectionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConnectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConnection.</param>
        /// 
        /// <returns>Returns a  CreateConnectionResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateConnection">REST API Reference for CreateConnection Operation</seealso>
        public virtual CreateConnectionResponse EndCreateConnection(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateConnectionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDataProduct

        /// <summary>
        /// Creates a data product.
        /// 
        ///  
        /// <para>
        /// A data product is a comprehensive package that combines data assets with their associated
        /// metadata, documentation, and access controls. It's designed to serve specific business
        /// needs or use cases, making it easier for users to find and consume data appropriately.
        /// Data products include important information about data quality, freshness, and usage
        /// guidelines, effectively bridging the gap between data producers and consumers while
        /// ensuring proper governance.
        /// </para>
        ///  
        /// <para>
        /// Prerequisites:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The domain must exist and be accessible. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The owning project must be valid and active.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The name must be unique within the domain (no existing data product with the same
        /// name).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// User must have create permissions for data products in the project.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataProduct service method.</param>
        /// 
        /// <returns>The response from the CreateDataProduct service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateDataProduct">REST API Reference for CreateDataProduct Operation</seealso>
        public virtual CreateDataProductResponse CreateDataProduct(CreateDataProductRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDataProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataProductResponseUnmarshaller.Instance;

            return Invoke<CreateDataProductResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataProduct operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataProduct operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDataProduct
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateDataProduct">REST API Reference for CreateDataProduct Operation</seealso>
        public virtual IAsyncResult BeginCreateDataProduct(CreateDataProductRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDataProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataProductResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDataProduct operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDataProduct.</param>
        /// 
        /// <returns>Returns a  CreateDataProductResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateDataProduct">REST API Reference for CreateDataProduct Operation</seealso>
        public virtual CreateDataProductResponse EndCreateDataProduct(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDataProductResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDataProductRevision

        /// <summary>
        /// Creates a data product revision.
        /// 
        ///  
        /// <para>
        /// Prerequisites:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The original data product must exist in the given domain. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// User must have permissions on the data product.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The domain must be valid and accessible.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The new revision name must comply with naming constraints (if required).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataProductRevision service method.</param>
        /// 
        /// <returns>The response from the CreateDataProductRevision service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateDataProductRevision">REST API Reference for CreateDataProductRevision Operation</seealso>
        public virtual CreateDataProductRevisionResponse CreateDataProductRevision(CreateDataProductRevisionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDataProductRevisionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataProductRevisionResponseUnmarshaller.Instance;

            return Invoke<CreateDataProductRevisionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataProductRevision operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataProductRevision operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDataProductRevision
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateDataProductRevision">REST API Reference for CreateDataProductRevision Operation</seealso>
        public virtual IAsyncResult BeginCreateDataProductRevision(CreateDataProductRevisionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDataProductRevisionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataProductRevisionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDataProductRevision operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDataProductRevision.</param>
        /// 
        /// <returns>Returns a  CreateDataProductRevisionResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateDataProductRevision">REST API Reference for CreateDataProductRevision Operation</seealso>
        public virtual CreateDataProductRevisionResponse EndCreateDataProductRevision(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDataProductRevisionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDataSource

        /// <summary>
        /// Creates an Amazon DataZone data source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSource service method.</param>
        /// 
        /// <returns>The response from the CreateDataSource service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateDataSource">REST API Reference for CreateDataSource Operation</seealso>
        public virtual CreateDataSourceResponse CreateDataSource(CreateDataSourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataSourceResponseUnmarshaller.Instance;

            return Invoke<CreateDataSourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSource operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDataSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateDataSource">REST API Reference for CreateDataSource Operation</seealso>
        public virtual IAsyncResult BeginCreateDataSource(CreateDataSourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDataSourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDataSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDataSource.</param>
        /// 
        /// <returns>Returns a  CreateDataSourceResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateDataSource">REST API Reference for CreateDataSource Operation</seealso>
        public virtual CreateDataSourceResponse EndCreateDataSource(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDataSourceResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDomain

        /// <summary>
        /// Creates an Amazon DataZone domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomain service method.</param>
        /// 
        /// <returns>The response from the CreateDomain service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateDomain">REST API Reference for CreateDomain Operation</seealso>
        public virtual CreateDomainResponse CreateDomain(CreateDomainRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainResponseUnmarshaller.Instance;

            return Invoke<CreateDomainResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDomain operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateDomain">REST API Reference for CreateDomain Operation</seealso>
        public virtual IAsyncResult BeginCreateDomain(CreateDomainRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDomain.</param>
        /// 
        /// <returns>Returns a  CreateDomainResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateDomain">REST API Reference for CreateDomain Operation</seealso>
        public virtual CreateDomainResponse EndCreateDomain(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDomainResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDomainUnit

        /// <summary>
        /// Creates a domain unit in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomainUnit service method.</param>
        /// 
        /// <returns>The response from the CreateDomainUnit service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateDomainUnit">REST API Reference for CreateDomainUnit Operation</seealso>
        public virtual CreateDomainUnitResponse CreateDomainUnit(CreateDomainUnitRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDomainUnitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainUnitResponseUnmarshaller.Instance;

            return Invoke<CreateDomainUnitResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDomainUnit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDomainUnit operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDomainUnit
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateDomainUnit">REST API Reference for CreateDomainUnit Operation</seealso>
        public virtual IAsyncResult BeginCreateDomainUnit(CreateDomainUnitRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateDomainUnitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDomainUnitResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDomainUnit operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDomainUnit.</param>
        /// 
        /// <returns>Returns a  CreateDomainUnitResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateDomainUnit">REST API Reference for CreateDomainUnit Operation</seealso>
        public virtual CreateDomainUnitResponse EndCreateDomainUnit(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDomainUnitResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateEnvironment

        /// <summary>
        /// Create an Amazon DataZone environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironment service method.</param>
        /// 
        /// <returns>The response from the CreateEnvironment service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateEnvironment">REST API Reference for CreateEnvironment Operation</seealso>
        public virtual CreateEnvironmentResponse CreateEnvironment(CreateEnvironmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnvironmentResponseUnmarshaller.Instance;

            return Invoke<CreateEnvironmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironment operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateEnvironment">REST API Reference for CreateEnvironment Operation</seealso>
        public virtual IAsyncResult BeginCreateEnvironment(CreateEnvironmentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnvironmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEnvironment.</param>
        /// 
        /// <returns>Returns a  CreateEnvironmentResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateEnvironment">REST API Reference for CreateEnvironment Operation</seealso>
        public virtual CreateEnvironmentResponse EndCreateEnvironment(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateEnvironmentResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateEnvironmentAction

        /// <summary>
        /// Creates an action for the environment, for example, creates a console link for an
        /// analytics tool that is available in this environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironmentAction service method.</param>
        /// 
        /// <returns>The response from the CreateEnvironmentAction service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateEnvironmentAction">REST API Reference for CreateEnvironmentAction Operation</seealso>
        public virtual CreateEnvironmentActionResponse CreateEnvironmentAction(CreateEnvironmentActionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEnvironmentActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnvironmentActionResponseUnmarshaller.Instance;

            return Invoke<CreateEnvironmentActionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEnvironmentAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironmentAction operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEnvironmentAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateEnvironmentAction">REST API Reference for CreateEnvironmentAction Operation</seealso>
        public virtual IAsyncResult BeginCreateEnvironmentAction(CreateEnvironmentActionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEnvironmentActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnvironmentActionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEnvironmentAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEnvironmentAction.</param>
        /// 
        /// <returns>Returns a  CreateEnvironmentActionResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateEnvironmentAction">REST API Reference for CreateEnvironmentAction Operation</seealso>
        public virtual CreateEnvironmentActionResponse EndCreateEnvironmentAction(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateEnvironmentActionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateEnvironmentBlueprint

        /// <summary>
        /// Creates a Amazon DataZone blueprint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironmentBlueprint service method.</param>
        /// 
        /// <returns>The response from the CreateEnvironmentBlueprint service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateEnvironmentBlueprint">REST API Reference for CreateEnvironmentBlueprint Operation</seealso>
        public virtual CreateEnvironmentBlueprintResponse CreateEnvironmentBlueprint(CreateEnvironmentBlueprintRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEnvironmentBlueprintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnvironmentBlueprintResponseUnmarshaller.Instance;

            return Invoke<CreateEnvironmentBlueprintResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEnvironmentBlueprint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironmentBlueprint operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEnvironmentBlueprint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateEnvironmentBlueprint">REST API Reference for CreateEnvironmentBlueprint Operation</seealso>
        public virtual IAsyncResult BeginCreateEnvironmentBlueprint(CreateEnvironmentBlueprintRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEnvironmentBlueprintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnvironmentBlueprintResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEnvironmentBlueprint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEnvironmentBlueprint.</param>
        /// 
        /// <returns>Returns a  CreateEnvironmentBlueprintResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateEnvironmentBlueprint">REST API Reference for CreateEnvironmentBlueprint Operation</seealso>
        public virtual CreateEnvironmentBlueprintResponse EndCreateEnvironmentBlueprint(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateEnvironmentBlueprintResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateEnvironmentProfile

        /// <summary>
        /// Creates an Amazon DataZone environment profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironmentProfile service method.</param>
        /// 
        /// <returns>The response from the CreateEnvironmentProfile service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateEnvironmentProfile">REST API Reference for CreateEnvironmentProfile Operation</seealso>
        public virtual CreateEnvironmentProfileResponse CreateEnvironmentProfile(CreateEnvironmentProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEnvironmentProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnvironmentProfileResponseUnmarshaller.Instance;

            return Invoke<CreateEnvironmentProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEnvironmentProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironmentProfile operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEnvironmentProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateEnvironmentProfile">REST API Reference for CreateEnvironmentProfile Operation</seealso>
        public virtual IAsyncResult BeginCreateEnvironmentProfile(CreateEnvironmentProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEnvironmentProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnvironmentProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEnvironmentProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEnvironmentProfile.</param>
        /// 
        /// <returns>Returns a  CreateEnvironmentProfileResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateEnvironmentProfile">REST API Reference for CreateEnvironmentProfile Operation</seealso>
        public virtual CreateEnvironmentProfileResponse EndCreateEnvironmentProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateEnvironmentProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateFormType

        /// <summary>
        /// Creates a metadata form type.
        /// 
        ///  
        /// <para>
        /// Prerequisites:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The domain must exist and be in an <c>ENABLED</c> state. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The owning project must exist and be accessible.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The name must be unique within the domain.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For custom form types, to indicate that a field should be searchable, annotate it
        /// with <c>@amazon.datazone#searchable</c>. By default, searchable fields are indexed
        /// for semantic search, where related query terms will match the attribute value even
        /// if they are not stemmed or keyword matches. To indicate that a field should be indexed
        /// for lexical search (which disables semantic search but supports stemmed and partial
        /// matches), annotate it with <c>@amazon.datazone#searchable(modes:["LEXICAL"])</c>.
        /// To indicate that a field should be indexed for technical identifier search (for more
        /// information on technical identifier search, see: <a href="https://aws.amazon.com/blogs/big-data/streamline-data-discovery-with-precise-technical-identifier-search-in-amazon-sagemaker-unified-studio/">https://aws.amazon.com/blogs/big-data/streamline-data-discovery-with-precise-technical-identifier-search-in-amazon-sagemaker-unified-studio/</a>),
        /// annotate it with <c>@amazon.datazone#searchable(modes:["TECHNICAL"])</c>.
        /// </para>
        ///  
        /// <para>
        /// To denote that a field will store glossary term ids (which are filterable via the
        /// Search/SearchListings APIs), annotate it with <c>@amazon.datazone#glossaryterm("${GLOSSARY_ID}")</c>,
        /// where <c>${GLOSSARY_ID}</c> is the id of the glossary that the glossary terms stored
        /// in the field belong to. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFormType service method.</param>
        /// 
        /// <returns>The response from the CreateFormType service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateFormType">REST API Reference for CreateFormType Operation</seealso>
        public virtual CreateFormTypeResponse CreateFormType(CreateFormTypeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFormTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFormTypeResponseUnmarshaller.Instance;

            return Invoke<CreateFormTypeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFormType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFormType operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFormType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateFormType">REST API Reference for CreateFormType Operation</seealso>
        public virtual IAsyncResult BeginCreateFormType(CreateFormTypeRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFormTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFormTypeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFormType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFormType.</param>
        /// 
        /// <returns>Returns a  CreateFormTypeResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateFormType">REST API Reference for CreateFormType Operation</seealso>
        public virtual CreateFormTypeResponse EndCreateFormType(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateFormTypeResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateGlossary

        /// <summary>
        /// Creates an Amazon DataZone business glossary.
        /// 
        ///  
        /// <para>
        /// Specifies that this is a create glossary policy.
        /// </para>
        ///  
        /// <para>
        /// A glossary serves as the central repository for business terminology and definitions
        /// within an organization. It helps establish and maintain a common language across different
        /// departments and teams, reducing miscommunication and ensuring consistent interpretation
        /// of business concepts. Glossaries can include hierarchical relationships between terms,
        /// cross-references, and links to actual data assets, making them invaluable for both
        /// business users and technical teams trying to understand and use data correctly.
        /// </para>
        ///  
        /// <para>
        /// Prerequisites:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Domain must exist and be in an active state. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Owning project must exist and be accessible by the caller.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The glossary name must be unique within the domain.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGlossary service method.</param>
        /// 
        /// <returns>The response from the CreateGlossary service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateGlossary">REST API Reference for CreateGlossary Operation</seealso>
        public virtual CreateGlossaryResponse CreateGlossary(CreateGlossaryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGlossaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGlossaryResponseUnmarshaller.Instance;

            return Invoke<CreateGlossaryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGlossary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGlossary operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGlossary
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateGlossary">REST API Reference for CreateGlossary Operation</seealso>
        public virtual IAsyncResult BeginCreateGlossary(CreateGlossaryRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGlossaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGlossaryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateGlossary operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGlossary.</param>
        /// 
        /// <returns>Returns a  CreateGlossaryResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateGlossary">REST API Reference for CreateGlossary Operation</seealso>
        public virtual CreateGlossaryResponse EndCreateGlossary(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateGlossaryResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateGlossaryTerm

        /// <summary>
        /// Creates a business glossary term.
        /// 
        ///  
        /// <para>
        /// A glossary term represents an individual entry within the Amazon DataZone glossary,
        /// serving as a standardized definition for a specific business concept or data element.
        /// Each term can include rich metadata such as detailed definitions, synonyms, related
        /// terms, and usage examples. Glossary terms can be linked directly to data assets, providing
        /// business context to technical data elements. This linking capability helps users understand
        /// the business meaning of data fields and ensures consistent interpretation across different
        /// systems and teams. Terms can also have relationships with other terms, creating a
        /// semantic network that reflects the complexity of business concepts.
        /// </para>
        ///  
        /// <para>
        /// Prerequisites:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Domain must exist. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Glossary must exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The term name must be unique within the glossary.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Ensure term does not conflict with existing terms in hierarchy.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGlossaryTerm service method.</param>
        /// 
        /// <returns>The response from the CreateGlossaryTerm service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateGlossaryTerm">REST API Reference for CreateGlossaryTerm Operation</seealso>
        public virtual CreateGlossaryTermResponse CreateGlossaryTerm(CreateGlossaryTermRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGlossaryTermRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGlossaryTermResponseUnmarshaller.Instance;

            return Invoke<CreateGlossaryTermResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGlossaryTerm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGlossaryTerm operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGlossaryTerm
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateGlossaryTerm">REST API Reference for CreateGlossaryTerm Operation</seealso>
        public virtual IAsyncResult BeginCreateGlossaryTerm(CreateGlossaryTermRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGlossaryTermRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGlossaryTermResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateGlossaryTerm operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGlossaryTerm.</param>
        /// 
        /// <returns>Returns a  CreateGlossaryTermResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateGlossaryTerm">REST API Reference for CreateGlossaryTerm Operation</seealso>
        public virtual CreateGlossaryTermResponse EndCreateGlossaryTerm(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateGlossaryTermResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateGroupProfile

        /// <summary>
        /// Creates a group profile in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGroupProfile service method.</param>
        /// 
        /// <returns>The response from the CreateGroupProfile service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateGroupProfile">REST API Reference for CreateGroupProfile Operation</seealso>
        public virtual CreateGroupProfileResponse CreateGroupProfile(CreateGroupProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGroupProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGroupProfileResponseUnmarshaller.Instance;

            return Invoke<CreateGroupProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGroupProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGroupProfile operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGroupProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateGroupProfile">REST API Reference for CreateGroupProfile Operation</seealso>
        public virtual IAsyncResult BeginCreateGroupProfile(CreateGroupProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGroupProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGroupProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateGroupProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGroupProfile.</param>
        /// 
        /// <returns>Returns a  CreateGroupProfileResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateGroupProfile">REST API Reference for CreateGroupProfile Operation</seealso>
        public virtual CreateGroupProfileResponse EndCreateGroupProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateGroupProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateListingChangeSet

        /// <summary>
        /// Publishes a listing (a record of an asset at a given time) or removes a listing from
        /// the catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateListingChangeSet service method.</param>
        /// 
        /// <returns>The response from the CreateListingChangeSet service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateListingChangeSet">REST API Reference for CreateListingChangeSet Operation</seealso>
        public virtual CreateListingChangeSetResponse CreateListingChangeSet(CreateListingChangeSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateListingChangeSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateListingChangeSetResponseUnmarshaller.Instance;

            return Invoke<CreateListingChangeSetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateListingChangeSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateListingChangeSet operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateListingChangeSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateListingChangeSet">REST API Reference for CreateListingChangeSet Operation</seealso>
        public virtual IAsyncResult BeginCreateListingChangeSet(CreateListingChangeSetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateListingChangeSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateListingChangeSetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateListingChangeSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateListingChangeSet.</param>
        /// 
        /// <returns>Returns a  CreateListingChangeSetResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateListingChangeSet">REST API Reference for CreateListingChangeSet Operation</seealso>
        public virtual CreateListingChangeSetResponse EndCreateListingChangeSet(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateListingChangeSetResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateProject

        /// <summary>
        /// Creates an Amazon DataZone project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProject service method.</param>
        /// 
        /// <returns>The response from the CreateProject service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateProject">REST API Reference for CreateProject Operation</seealso>
        public virtual CreateProjectResponse CreateProject(CreateProjectRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProjectResponseUnmarshaller.Instance;

            return Invoke<CreateProjectResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProject operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateProject">REST API Reference for CreateProject Operation</seealso>
        public virtual IAsyncResult BeginCreateProject(CreateProjectRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProjectResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateProject.</param>
        /// 
        /// <returns>Returns a  CreateProjectResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateProject">REST API Reference for CreateProject Operation</seealso>
        public virtual CreateProjectResponse EndCreateProject(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateProjectResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateProjectMembership

        /// <summary>
        /// Creates a project membership in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProjectMembership service method.</param>
        /// 
        /// <returns>The response from the CreateProjectMembership service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateProjectMembership">REST API Reference for CreateProjectMembership Operation</seealso>
        public virtual CreateProjectMembershipResponse CreateProjectMembership(CreateProjectMembershipRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateProjectMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProjectMembershipResponseUnmarshaller.Instance;

            return Invoke<CreateProjectMembershipResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateProjectMembership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProjectMembership operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateProjectMembership
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateProjectMembership">REST API Reference for CreateProjectMembership Operation</seealso>
        public virtual IAsyncResult BeginCreateProjectMembership(CreateProjectMembershipRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateProjectMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProjectMembershipResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateProjectMembership operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateProjectMembership.</param>
        /// 
        /// <returns>Returns a  CreateProjectMembershipResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateProjectMembership">REST API Reference for CreateProjectMembership Operation</seealso>
        public virtual CreateProjectMembershipResponse EndCreateProjectMembership(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateProjectMembershipResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateProjectProfile

        /// <summary>
        /// Creates a project profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProjectProfile service method.</param>
        /// 
        /// <returns>The response from the CreateProjectProfile service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateProjectProfile">REST API Reference for CreateProjectProfile Operation</seealso>
        public virtual CreateProjectProfileResponse CreateProjectProfile(CreateProjectProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateProjectProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProjectProfileResponseUnmarshaller.Instance;

            return Invoke<CreateProjectProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateProjectProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProjectProfile operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateProjectProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateProjectProfile">REST API Reference for CreateProjectProfile Operation</seealso>
        public virtual IAsyncResult BeginCreateProjectProfile(CreateProjectProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateProjectProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProjectProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateProjectProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateProjectProfile.</param>
        /// 
        /// <returns>Returns a  CreateProjectProfileResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateProjectProfile">REST API Reference for CreateProjectProfile Operation</seealso>
        public virtual CreateProjectProfileResponse EndCreateProjectProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateProjectProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateRule

        /// <summary>
        /// Creates a rule in Amazon DataZone. A rule is a formal agreement that enforces specific
        /// requirements across user workflows (e.g., publishing assets to the catalog, requesting
        /// subscriptions, creating projects) within the Amazon DataZone data portal. These rules
        /// help maintain consistency, ensure compliance, and uphold governance standards in data
        /// management processes. For instance, a metadata enforcement rule can specify the required
        /// information for creating a subscription request or publishing a data asset to the
        /// catalog, ensuring alignment with organizational standards.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRule service method.</param>
        /// 
        /// <returns>The response from the CreateRule service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateRule">REST API Reference for CreateRule Operation</seealso>
        public virtual CreateRuleResponse CreateRule(CreateRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRuleResponseUnmarshaller.Instance;

            return Invoke<CreateRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRule operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateRule">REST API Reference for CreateRule Operation</seealso>
        public virtual IAsyncResult BeginCreateRule(CreateRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRule.</param>
        /// 
        /// <returns>Returns a  CreateRuleResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateRule">REST API Reference for CreateRule Operation</seealso>
        public virtual CreateRuleResponse EndCreateRule(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateSubscriptionGrant

        /// <summary>
        /// Creates a subsscription grant in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscriptionGrant service method.</param>
        /// 
        /// <returns>The response from the CreateSubscriptionGrant service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateSubscriptionGrant">REST API Reference for CreateSubscriptionGrant Operation</seealso>
        public virtual CreateSubscriptionGrantResponse CreateSubscriptionGrant(CreateSubscriptionGrantRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSubscriptionGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSubscriptionGrantResponseUnmarshaller.Instance;

            return Invoke<CreateSubscriptionGrantResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSubscriptionGrant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscriptionGrant operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSubscriptionGrant
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateSubscriptionGrant">REST API Reference for CreateSubscriptionGrant Operation</seealso>
        public virtual IAsyncResult BeginCreateSubscriptionGrant(CreateSubscriptionGrantRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSubscriptionGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSubscriptionGrantResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSubscriptionGrant operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSubscriptionGrant.</param>
        /// 
        /// <returns>Returns a  CreateSubscriptionGrantResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateSubscriptionGrant">REST API Reference for CreateSubscriptionGrant Operation</seealso>
        public virtual CreateSubscriptionGrantResponse EndCreateSubscriptionGrant(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSubscriptionGrantResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateSubscriptionRequest

        /// <summary>
        /// Creates a subscription request in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscriptionRequest service method.</param>
        /// 
        /// <returns>The response from the CreateSubscriptionRequest service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateSubscriptionRequest">REST API Reference for CreateSubscriptionRequest Operation</seealso>
        public virtual CreateSubscriptionRequestResponse CreateSubscriptionRequest(CreateSubscriptionRequestRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSubscriptionRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSubscriptionRequestResponseUnmarshaller.Instance;

            return Invoke<CreateSubscriptionRequestResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSubscriptionRequest operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscriptionRequest operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSubscriptionRequest
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateSubscriptionRequest">REST API Reference for CreateSubscriptionRequest Operation</seealso>
        public virtual IAsyncResult BeginCreateSubscriptionRequest(CreateSubscriptionRequestRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSubscriptionRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSubscriptionRequestResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSubscriptionRequest operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSubscriptionRequest.</param>
        /// 
        /// <returns>Returns a  CreateSubscriptionRequestResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateSubscriptionRequest">REST API Reference for CreateSubscriptionRequest Operation</seealso>
        public virtual CreateSubscriptionRequestResponse EndCreateSubscriptionRequest(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSubscriptionRequestResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateSubscriptionTarget

        /// <summary>
        /// Creates a subscription target in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscriptionTarget service method.</param>
        /// 
        /// <returns>The response from the CreateSubscriptionTarget service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateSubscriptionTarget">REST API Reference for CreateSubscriptionTarget Operation</seealso>
        public virtual CreateSubscriptionTargetResponse CreateSubscriptionTarget(CreateSubscriptionTargetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSubscriptionTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSubscriptionTargetResponseUnmarshaller.Instance;

            return Invoke<CreateSubscriptionTargetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSubscriptionTarget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscriptionTarget operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSubscriptionTarget
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateSubscriptionTarget">REST API Reference for CreateSubscriptionTarget Operation</seealso>
        public virtual IAsyncResult BeginCreateSubscriptionTarget(CreateSubscriptionTargetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSubscriptionTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSubscriptionTargetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSubscriptionTarget operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSubscriptionTarget.</param>
        /// 
        /// <returns>Returns a  CreateSubscriptionTargetResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateSubscriptionTarget">REST API Reference for CreateSubscriptionTarget Operation</seealso>
        public virtual CreateSubscriptionTargetResponse EndCreateSubscriptionTarget(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSubscriptionTargetResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateUserProfile

        /// <summary>
        /// Creates a user profile in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUserProfile service method.</param>
        /// 
        /// <returns>The response from the CreateUserProfile service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateUserProfile">REST API Reference for CreateUserProfile Operation</seealso>
        public virtual CreateUserProfileResponse CreateUserProfile(CreateUserProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateUserProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserProfileResponseUnmarshaller.Instance;

            return Invoke<CreateUserProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateUserProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUserProfile operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateUserProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateUserProfile">REST API Reference for CreateUserProfile Operation</seealso>
        public virtual IAsyncResult BeginCreateUserProfile(CreateUserProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateUserProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUserProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateUserProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateUserProfile.</param>
        /// 
        /// <returns>Returns a  CreateUserProfileResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateUserProfile">REST API Reference for CreateUserProfile Operation</seealso>
        public virtual CreateUserProfileResponse EndCreateUserProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateUserProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAccountPool

        /// <summary>
        /// Deletes an account pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountPool service method.</param>
        /// 
        /// <returns>The response from the DeleteAccountPool service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteAccountPool">REST API Reference for DeleteAccountPool Operation</seealso>
        public virtual DeleteAccountPoolResponse DeleteAccountPool(DeleteAccountPoolRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAccountPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccountPoolResponseUnmarshaller.Instance;

            return Invoke<DeleteAccountPoolResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccountPool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountPool operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAccountPool
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteAccountPool">REST API Reference for DeleteAccountPool Operation</seealso>
        public virtual IAsyncResult BeginDeleteAccountPool(DeleteAccountPoolRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAccountPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccountPoolResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAccountPool operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAccountPool.</param>
        /// 
        /// <returns>Returns a  DeleteAccountPoolResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteAccountPool">REST API Reference for DeleteAccountPool Operation</seealso>
        public virtual DeleteAccountPoolResponse EndDeleteAccountPool(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAccountPoolResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAsset

        /// <summary>
        /// Deletes an asset in Amazon DataZone.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// --domain-identifier must refer to a valid and existing domain. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// --identifier must refer to an existing asset in the specified domain.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Asset must not be referenced in any existing asset filters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Asset must not be linked to any draft or published data product.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// User must have delete permissions for the domain and project.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAsset service method.</param>
        /// 
        /// <returns>The response from the DeleteAsset service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteAsset">REST API Reference for DeleteAsset Operation</seealso>
        public virtual DeleteAssetResponse DeleteAsset(DeleteAssetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssetResponseUnmarshaller.Instance;

            return Invoke<DeleteAssetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAsset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAsset operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAsset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteAsset">REST API Reference for DeleteAsset Operation</seealso>
        public virtual IAsyncResult BeginDeleteAsset(DeleteAssetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAsset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAsset.</param>
        /// 
        /// <returns>Returns a  DeleteAssetResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteAsset">REST API Reference for DeleteAsset Operation</seealso>
        public virtual DeleteAssetResponse EndDeleteAsset(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAssetResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAssetFilter

        /// <summary>
        /// Deletes an asset filter.
        /// 
        ///  
        /// <para>
        /// Prerequisites:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The asset filter must exist. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The domain and asset must not have been deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Ensure the --identifier refers to a valid filter ID.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssetFilter service method.</param>
        /// 
        /// <returns>The response from the DeleteAssetFilter service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteAssetFilter">REST API Reference for DeleteAssetFilter Operation</seealso>
        public virtual DeleteAssetFilterResponse DeleteAssetFilter(DeleteAssetFilterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAssetFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssetFilterResponseUnmarshaller.Instance;

            return Invoke<DeleteAssetFilterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAssetFilter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssetFilter operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAssetFilter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteAssetFilter">REST API Reference for DeleteAssetFilter Operation</seealso>
        public virtual IAsyncResult BeginDeleteAssetFilter(DeleteAssetFilterRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAssetFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssetFilterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAssetFilter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAssetFilter.</param>
        /// 
        /// <returns>Returns a  DeleteAssetFilterResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteAssetFilter">REST API Reference for DeleteAssetFilter Operation</seealso>
        public virtual DeleteAssetFilterResponse EndDeleteAssetFilter(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAssetFilterResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAssetType

        /// <summary>
        /// Deletes an asset type in Amazon DataZone.
        /// 
        ///  
        /// <para>
        /// Prerequisites:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The asset type must exist in the domain. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must have DeleteAssetType permission.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The asset type must not be in use (e.g., assigned to any asset). If used, deletion
        /// will fail.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You should retrieve the asset type using get-asset-type to confirm its presence before
        /// deletion.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssetType service method.</param>
        /// 
        /// <returns>The response from the DeleteAssetType service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteAssetType">REST API Reference for DeleteAssetType Operation</seealso>
        public virtual DeleteAssetTypeResponse DeleteAssetType(DeleteAssetTypeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAssetTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssetTypeResponseUnmarshaller.Instance;

            return Invoke<DeleteAssetTypeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAssetType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssetType operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAssetType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteAssetType">REST API Reference for DeleteAssetType Operation</seealso>
        public virtual IAsyncResult BeginDeleteAssetType(DeleteAssetTypeRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAssetTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAssetTypeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAssetType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAssetType.</param>
        /// 
        /// <returns>Returns a  DeleteAssetTypeResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteAssetType">REST API Reference for DeleteAssetType Operation</seealso>
        public virtual DeleteAssetTypeResponse EndDeleteAssetType(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAssetTypeResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteConnection

        /// <summary>
        /// Deletes and connection. In Amazon DataZone, a connection enables you to connect your
        /// resources (domains, projects, and environments) to external resources and services.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnection service method.</param>
        /// 
        /// <returns>The response from the DeleteConnection service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteConnection">REST API Reference for DeleteConnection Operation</seealso>
        public virtual DeleteConnectionResponse DeleteConnection(DeleteConnectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConnectionResponseUnmarshaller.Instance;

            return Invoke<DeleteConnectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnection operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteConnection">REST API Reference for DeleteConnection Operation</seealso>
        public virtual IAsyncResult BeginDeleteConnection(DeleteConnectionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConnectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConnection.</param>
        /// 
        /// <returns>Returns a  DeleteConnectionResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteConnection">REST API Reference for DeleteConnection Operation</seealso>
        public virtual DeleteConnectionResponse EndDeleteConnection(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteConnectionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDataProduct

        /// <summary>
        /// Deletes a data product in Amazon DataZone.
        /// 
        ///  
        /// <para>
        /// Prerequisites:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The data product must exist and not be deleted or archived. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The user must have delete permissions for the data product.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Domain and project must be active.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataProduct service method.</param>
        /// 
        /// <returns>The response from the DeleteDataProduct service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteDataProduct">REST API Reference for DeleteDataProduct Operation</seealso>
        public virtual DeleteDataProductResponse DeleteDataProduct(DeleteDataProductRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDataProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataProductResponseUnmarshaller.Instance;

            return Invoke<DeleteDataProductResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDataProduct operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataProduct operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDataProduct
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteDataProduct">REST API Reference for DeleteDataProduct Operation</seealso>
        public virtual IAsyncResult BeginDeleteDataProduct(DeleteDataProductRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDataProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataProductResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDataProduct operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDataProduct.</param>
        /// 
        /// <returns>Returns a  DeleteDataProductResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteDataProduct">REST API Reference for DeleteDataProduct Operation</seealso>
        public virtual DeleteDataProductResponse EndDeleteDataProduct(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDataProductResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDataSource

        /// <summary>
        /// Deletes a data source in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataSource service method.</param>
        /// 
        /// <returns>The response from the DeleteDataSource service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteDataSource">REST API Reference for DeleteDataSource Operation</seealso>
        public virtual DeleteDataSourceResponse DeleteDataSource(DeleteDataSourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataSourceResponseUnmarshaller.Instance;

            return Invoke<DeleteDataSourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDataSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataSource operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDataSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteDataSource">REST API Reference for DeleteDataSource Operation</seealso>
        public virtual IAsyncResult BeginDeleteDataSource(DeleteDataSourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataSourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDataSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDataSource.</param>
        /// 
        /// <returns>Returns a  DeleteDataSourceResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteDataSource">REST API Reference for DeleteDataSource Operation</seealso>
        public virtual DeleteDataSourceResponse EndDeleteDataSource(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDataSourceResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDomain

        /// <summary>
        /// Deletes a Amazon DataZone domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain service method.</param>
        /// 
        /// <returns>The response from the DeleteDomain service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteDomain">REST API Reference for DeleteDomain Operation</seealso>
        public virtual DeleteDomainResponse DeleteDomain(DeleteDomainRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainResponseUnmarshaller.Instance;

            return Invoke<DeleteDomainResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteDomain">REST API Reference for DeleteDomain Operation</seealso>
        public virtual IAsyncResult BeginDeleteDomain(DeleteDomainRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDomain.</param>
        /// 
        /// <returns>Returns a  DeleteDomainResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteDomain">REST API Reference for DeleteDomain Operation</seealso>
        public virtual DeleteDomainResponse EndDeleteDomain(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDomainResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDomainUnit

        /// <summary>
        /// Deletes a domain unit.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomainUnit service method.</param>
        /// 
        /// <returns>The response from the DeleteDomainUnit service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteDomainUnit">REST API Reference for DeleteDomainUnit Operation</seealso>
        public virtual DeleteDomainUnitResponse DeleteDomainUnit(DeleteDomainUnitRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDomainUnitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainUnitResponseUnmarshaller.Instance;

            return Invoke<DeleteDomainUnitResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDomainUnit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomainUnit operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDomainUnit
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteDomainUnit">REST API Reference for DeleteDomainUnit Operation</seealso>
        public virtual IAsyncResult BeginDeleteDomainUnit(DeleteDomainUnitRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDomainUnitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDomainUnitResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDomainUnit operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDomainUnit.</param>
        /// 
        /// <returns>Returns a  DeleteDomainUnitResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteDomainUnit">REST API Reference for DeleteDomainUnit Operation</seealso>
        public virtual DeleteDomainUnitResponse EndDeleteDomainUnit(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDomainUnitResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteEnvironment

        /// <summary>
        /// Deletes an environment in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironment service method.</param>
        /// 
        /// <returns>The response from the DeleteEnvironment service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteEnvironment">REST API Reference for DeleteEnvironment Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironment operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteEnvironment">REST API Reference for DeleteEnvironment Operation</seealso>
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
        /// <returns>Returns a  DeleteEnvironmentResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteEnvironment">REST API Reference for DeleteEnvironment Operation</seealso>
        public virtual DeleteEnvironmentResponse EndDeleteEnvironment(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteEnvironmentResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteEnvironmentAction

        /// <summary>
        /// Deletes an action for the environment, for example, deletes a console link for an
        /// analytics tool that is available in this environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironmentAction service method.</param>
        /// 
        /// <returns>The response from the DeleteEnvironmentAction service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteEnvironmentAction">REST API Reference for DeleteEnvironmentAction Operation</seealso>
        public virtual DeleteEnvironmentActionResponse DeleteEnvironmentAction(DeleteEnvironmentActionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentActionResponseUnmarshaller.Instance;

            return Invoke<DeleteEnvironmentActionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEnvironmentAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironmentAction operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEnvironmentAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteEnvironmentAction">REST API Reference for DeleteEnvironmentAction Operation</seealso>
        public virtual IAsyncResult BeginDeleteEnvironmentAction(DeleteEnvironmentActionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentActionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEnvironmentAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEnvironmentAction.</param>
        /// 
        /// <returns>Returns a  DeleteEnvironmentActionResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteEnvironmentAction">REST API Reference for DeleteEnvironmentAction Operation</seealso>
        public virtual DeleteEnvironmentActionResponse EndDeleteEnvironmentAction(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteEnvironmentActionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteEnvironmentBlueprint

        /// <summary>
        /// Deletes a blueprint in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironmentBlueprint service method.</param>
        /// 
        /// <returns>The response from the DeleteEnvironmentBlueprint service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteEnvironmentBlueprint">REST API Reference for DeleteEnvironmentBlueprint Operation</seealso>
        public virtual DeleteEnvironmentBlueprintResponse DeleteEnvironmentBlueprint(DeleteEnvironmentBlueprintRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentBlueprintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentBlueprintResponseUnmarshaller.Instance;

            return Invoke<DeleteEnvironmentBlueprintResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEnvironmentBlueprint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironmentBlueprint operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEnvironmentBlueprint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteEnvironmentBlueprint">REST API Reference for DeleteEnvironmentBlueprint Operation</seealso>
        public virtual IAsyncResult BeginDeleteEnvironmentBlueprint(DeleteEnvironmentBlueprintRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentBlueprintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentBlueprintResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEnvironmentBlueprint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEnvironmentBlueprint.</param>
        /// 
        /// <returns>Returns a  DeleteEnvironmentBlueprintResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteEnvironmentBlueprint">REST API Reference for DeleteEnvironmentBlueprint Operation</seealso>
        public virtual DeleteEnvironmentBlueprintResponse EndDeleteEnvironmentBlueprint(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteEnvironmentBlueprintResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteEnvironmentBlueprintConfiguration

        /// <summary>
        /// Deletes the blueprint configuration in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironmentBlueprintConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteEnvironmentBlueprintConfiguration service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteEnvironmentBlueprintConfiguration">REST API Reference for DeleteEnvironmentBlueprintConfiguration Operation</seealso>
        public virtual DeleteEnvironmentBlueprintConfigurationResponse DeleteEnvironmentBlueprintConfiguration(DeleteEnvironmentBlueprintConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentBlueprintConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentBlueprintConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteEnvironmentBlueprintConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEnvironmentBlueprintConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironmentBlueprintConfiguration operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEnvironmentBlueprintConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteEnvironmentBlueprintConfiguration">REST API Reference for DeleteEnvironmentBlueprintConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDeleteEnvironmentBlueprintConfiguration(DeleteEnvironmentBlueprintConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentBlueprintConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentBlueprintConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEnvironmentBlueprintConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEnvironmentBlueprintConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteEnvironmentBlueprintConfigurationResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteEnvironmentBlueprintConfiguration">REST API Reference for DeleteEnvironmentBlueprintConfiguration Operation</seealso>
        public virtual DeleteEnvironmentBlueprintConfigurationResponse EndDeleteEnvironmentBlueprintConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteEnvironmentBlueprintConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteEnvironmentProfile

        /// <summary>
        /// Deletes an environment profile in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironmentProfile service method.</param>
        /// 
        /// <returns>The response from the DeleteEnvironmentProfile service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteEnvironmentProfile">REST API Reference for DeleteEnvironmentProfile Operation</seealso>
        public virtual DeleteEnvironmentProfileResponse DeleteEnvironmentProfile(DeleteEnvironmentProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentProfileResponseUnmarshaller.Instance;

            return Invoke<DeleteEnvironmentProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEnvironmentProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironmentProfile operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEnvironmentProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteEnvironmentProfile">REST API Reference for DeleteEnvironmentProfile Operation</seealso>
        public virtual IAsyncResult BeginDeleteEnvironmentProfile(DeleteEnvironmentProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEnvironmentProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEnvironmentProfile.</param>
        /// 
        /// <returns>Returns a  DeleteEnvironmentProfileResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteEnvironmentProfile">REST API Reference for DeleteEnvironmentProfile Operation</seealso>
        public virtual DeleteEnvironmentProfileResponse EndDeleteEnvironmentProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteEnvironmentProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteFormType

        /// <summary>
        /// Deletes and metadata form type in Amazon DataZone.
        /// 
        ///  
        /// <para>
        /// Prerequisites:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The form type must exist in the domain. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The form type must not be in use by any asset types or assets.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The domain must be valid and accessible.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// User must have delete permissions on the form type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Any dependencies (such as linked asset types) must be removed first.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFormType service method.</param>
        /// 
        /// <returns>The response from the DeleteFormType service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteFormType">REST API Reference for DeleteFormType Operation</seealso>
        public virtual DeleteFormTypeResponse DeleteFormType(DeleteFormTypeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFormTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFormTypeResponseUnmarshaller.Instance;

            return Invoke<DeleteFormTypeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFormType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFormType operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFormType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteFormType">REST API Reference for DeleteFormType Operation</seealso>
        public virtual IAsyncResult BeginDeleteFormType(DeleteFormTypeRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFormTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFormTypeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFormType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFormType.</param>
        /// 
        /// <returns>Returns a  DeleteFormTypeResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteFormType">REST API Reference for DeleteFormType Operation</seealso>
        public virtual DeleteFormTypeResponse EndDeleteFormType(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteFormTypeResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteGlossary

        /// <summary>
        /// Deletes a business glossary in Amazon DataZone.
        /// 
        ///  
        /// <para>
        /// Prerequisites:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The glossary must be in DISABLED state. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The glossary must not have any glossary terms associated with it.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The glossary must exist in the specified domain.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The caller must have the <c>datazone:DeleteGlossary</c> permission in the domain and
        /// glossary.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Glossary should not be linked to any active metadata forms.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGlossary service method.</param>
        /// 
        /// <returns>The response from the DeleteGlossary service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteGlossary">REST API Reference for DeleteGlossary Operation</seealso>
        public virtual DeleteGlossaryResponse DeleteGlossary(DeleteGlossaryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGlossaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGlossaryResponseUnmarshaller.Instance;

            return Invoke<DeleteGlossaryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGlossary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGlossary operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteGlossary
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteGlossary">REST API Reference for DeleteGlossary Operation</seealso>
        public virtual IAsyncResult BeginDeleteGlossary(DeleteGlossaryRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGlossaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGlossaryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGlossary operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGlossary.</param>
        /// 
        /// <returns>Returns a  DeleteGlossaryResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteGlossary">REST API Reference for DeleteGlossary Operation</seealso>
        public virtual DeleteGlossaryResponse EndDeleteGlossary(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteGlossaryResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteGlossaryTerm

        /// <summary>
        /// Deletes a business glossary term in Amazon DataZone.
        /// 
        ///  
        /// <para>
        /// Prerequisites:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Glossary term must exist and be active. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The term must not be linked to other assets or child terms.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Caller must have delete permissions in the domain/glossary.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Ensure all associations (such as to assets or parent terms) are removed before deletion.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGlossaryTerm service method.</param>
        /// 
        /// <returns>The response from the DeleteGlossaryTerm service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteGlossaryTerm">REST API Reference for DeleteGlossaryTerm Operation</seealso>
        public virtual DeleteGlossaryTermResponse DeleteGlossaryTerm(DeleteGlossaryTermRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGlossaryTermRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGlossaryTermResponseUnmarshaller.Instance;

            return Invoke<DeleteGlossaryTermResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGlossaryTerm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGlossaryTerm operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteGlossaryTerm
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteGlossaryTerm">REST API Reference for DeleteGlossaryTerm Operation</seealso>
        public virtual IAsyncResult BeginDeleteGlossaryTerm(DeleteGlossaryTermRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGlossaryTermRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGlossaryTermResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGlossaryTerm operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGlossaryTerm.</param>
        /// 
        /// <returns>Returns a  DeleteGlossaryTermResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteGlossaryTerm">REST API Reference for DeleteGlossaryTerm Operation</seealso>
        public virtual DeleteGlossaryTermResponse EndDeleteGlossaryTerm(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteGlossaryTermResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteListing

        /// <summary>
        /// Deletes a listing (a record of an asset at a given time).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteListing service method.</param>
        /// 
        /// <returns>The response from the DeleteListing service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteListing">REST API Reference for DeleteListing Operation</seealso>
        public virtual DeleteListingResponse DeleteListing(DeleteListingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteListingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteListingResponseUnmarshaller.Instance;

            return Invoke<DeleteListingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteListing operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteListing operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteListing
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteListing">REST API Reference for DeleteListing Operation</seealso>
        public virtual IAsyncResult BeginDeleteListing(DeleteListingRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteListingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteListingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteListing operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteListing.</param>
        /// 
        /// <returns>Returns a  DeleteListingResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteListing">REST API Reference for DeleteListing Operation</seealso>
        public virtual DeleteListingResponse EndDeleteListing(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteListingResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteProject

        /// <summary>
        /// Deletes a project in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProject service method.</param>
        /// 
        /// <returns>The response from the DeleteProject service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        public virtual DeleteProjectResponse DeleteProject(DeleteProjectRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProjectResponseUnmarshaller.Instance;

            return Invoke<DeleteProjectResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProject operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        public virtual IAsyncResult BeginDeleteProject(DeleteProjectRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProjectResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteProject.</param>
        /// 
        /// <returns>Returns a  DeleteProjectResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        public virtual DeleteProjectResponse EndDeleteProject(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteProjectResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteProjectMembership

        /// <summary>
        /// Deletes project membership in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProjectMembership service method.</param>
        /// 
        /// <returns>The response from the DeleteProjectMembership service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteProjectMembership">REST API Reference for DeleteProjectMembership Operation</seealso>
        public virtual DeleteProjectMembershipResponse DeleteProjectMembership(DeleteProjectMembershipRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProjectMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProjectMembershipResponseUnmarshaller.Instance;

            return Invoke<DeleteProjectMembershipResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProjectMembership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProjectMembership operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteProjectMembership
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteProjectMembership">REST API Reference for DeleteProjectMembership Operation</seealso>
        public virtual IAsyncResult BeginDeleteProjectMembership(DeleteProjectMembershipRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProjectMembershipRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProjectMembershipResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteProjectMembership operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteProjectMembership.</param>
        /// 
        /// <returns>Returns a  DeleteProjectMembershipResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteProjectMembership">REST API Reference for DeleteProjectMembership Operation</seealso>
        public virtual DeleteProjectMembershipResponse EndDeleteProjectMembership(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteProjectMembershipResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteProjectProfile

        /// <summary>
        /// Deletes a project profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProjectProfile service method.</param>
        /// 
        /// <returns>The response from the DeleteProjectProfile service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteProjectProfile">REST API Reference for DeleteProjectProfile Operation</seealso>
        public virtual DeleteProjectProfileResponse DeleteProjectProfile(DeleteProjectProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProjectProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProjectProfileResponseUnmarshaller.Instance;

            return Invoke<DeleteProjectProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProjectProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProjectProfile operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteProjectProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteProjectProfile">REST API Reference for DeleteProjectProfile Operation</seealso>
        public virtual IAsyncResult BeginDeleteProjectProfile(DeleteProjectProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProjectProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProjectProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteProjectProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteProjectProfile.</param>
        /// 
        /// <returns>Returns a  DeleteProjectProfileResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteProjectProfile">REST API Reference for DeleteProjectProfile Operation</seealso>
        public virtual DeleteProjectProfileResponse EndDeleteProjectProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteProjectProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteRule

        /// <summary>
        /// Deletes a rule in Amazon DataZone. A rule is a formal agreement that enforces specific
        /// requirements across user workflows (e.g., publishing assets to the catalog, requesting
        /// subscriptions, creating projects) within the Amazon DataZone data portal. These rules
        /// help maintain consistency, ensure compliance, and uphold governance standards in data
        /// management processes. For instance, a metadata enforcement rule can specify the required
        /// information for creating a subscription request or publishing a data asset to the
        /// catalog, ensuring alignment with organizational standards.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRule service method.</param>
        /// 
        /// <returns>The response from the DeleteRule service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteRule">REST API Reference for DeleteRule Operation</seealso>
        public virtual DeleteRuleResponse DeleteRule(DeleteRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRuleResponseUnmarshaller.Instance;

            return Invoke<DeleteRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRule operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteRule">REST API Reference for DeleteRule Operation</seealso>
        public virtual IAsyncResult BeginDeleteRule(DeleteRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRule.</param>
        /// 
        /// <returns>Returns a  DeleteRuleResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteRule">REST API Reference for DeleteRule Operation</seealso>
        public virtual DeleteRuleResponse EndDeleteRule(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteSubscriptionGrant

        /// <summary>
        /// Deletes and subscription grant in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubscriptionGrant service method.</param>
        /// 
        /// <returns>The response from the DeleteSubscriptionGrant service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteSubscriptionGrant">REST API Reference for DeleteSubscriptionGrant Operation</seealso>
        public virtual DeleteSubscriptionGrantResponse DeleteSubscriptionGrant(DeleteSubscriptionGrantRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSubscriptionGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSubscriptionGrantResponseUnmarshaller.Instance;

            return Invoke<DeleteSubscriptionGrantResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSubscriptionGrant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubscriptionGrant operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSubscriptionGrant
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteSubscriptionGrant">REST API Reference for DeleteSubscriptionGrant Operation</seealso>
        public virtual IAsyncResult BeginDeleteSubscriptionGrant(DeleteSubscriptionGrantRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSubscriptionGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSubscriptionGrantResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSubscriptionGrant operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSubscriptionGrant.</param>
        /// 
        /// <returns>Returns a  DeleteSubscriptionGrantResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteSubscriptionGrant">REST API Reference for DeleteSubscriptionGrant Operation</seealso>
        public virtual DeleteSubscriptionGrantResponse EndDeleteSubscriptionGrant(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSubscriptionGrantResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteSubscriptionRequest

        /// <summary>
        /// Deletes a subscription request in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubscriptionRequest service method.</param>
        /// 
        /// <returns>The response from the DeleteSubscriptionRequest service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteSubscriptionRequest">REST API Reference for DeleteSubscriptionRequest Operation</seealso>
        public virtual DeleteSubscriptionRequestResponse DeleteSubscriptionRequest(DeleteSubscriptionRequestRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSubscriptionRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSubscriptionRequestResponseUnmarshaller.Instance;

            return Invoke<DeleteSubscriptionRequestResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSubscriptionRequest operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubscriptionRequest operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSubscriptionRequest
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteSubscriptionRequest">REST API Reference for DeleteSubscriptionRequest Operation</seealso>
        public virtual IAsyncResult BeginDeleteSubscriptionRequest(DeleteSubscriptionRequestRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSubscriptionRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSubscriptionRequestResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSubscriptionRequest operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSubscriptionRequest.</param>
        /// 
        /// <returns>Returns a  DeleteSubscriptionRequestResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteSubscriptionRequest">REST API Reference for DeleteSubscriptionRequest Operation</seealso>
        public virtual DeleteSubscriptionRequestResponse EndDeleteSubscriptionRequest(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSubscriptionRequestResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteSubscriptionTarget

        /// <summary>
        /// Deletes a subscription target in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubscriptionTarget service method.</param>
        /// 
        /// <returns>The response from the DeleteSubscriptionTarget service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteSubscriptionTarget">REST API Reference for DeleteSubscriptionTarget Operation</seealso>
        public virtual DeleteSubscriptionTargetResponse DeleteSubscriptionTarget(DeleteSubscriptionTargetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSubscriptionTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSubscriptionTargetResponseUnmarshaller.Instance;

            return Invoke<DeleteSubscriptionTargetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSubscriptionTarget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubscriptionTarget operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSubscriptionTarget
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteSubscriptionTarget">REST API Reference for DeleteSubscriptionTarget Operation</seealso>
        public virtual IAsyncResult BeginDeleteSubscriptionTarget(DeleteSubscriptionTargetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSubscriptionTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSubscriptionTargetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSubscriptionTarget operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSubscriptionTarget.</param>
        /// 
        /// <returns>Returns a  DeleteSubscriptionTargetResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteSubscriptionTarget">REST API Reference for DeleteSubscriptionTarget Operation</seealso>
        public virtual DeleteSubscriptionTargetResponse EndDeleteSubscriptionTarget(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSubscriptionTargetResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteTimeSeriesDataPoints

        /// <summary>
        /// Deletes the specified time series form for the specified asset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTimeSeriesDataPoints service method.</param>
        /// 
        /// <returns>The response from the DeleteTimeSeriesDataPoints service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteTimeSeriesDataPoints">REST API Reference for DeleteTimeSeriesDataPoints Operation</seealso>
        public virtual DeleteTimeSeriesDataPointsResponse DeleteTimeSeriesDataPoints(DeleteTimeSeriesDataPointsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTimeSeriesDataPointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTimeSeriesDataPointsResponseUnmarshaller.Instance;

            return Invoke<DeleteTimeSeriesDataPointsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTimeSeriesDataPoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTimeSeriesDataPoints operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTimeSeriesDataPoints
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteTimeSeriesDataPoints">REST API Reference for DeleteTimeSeriesDataPoints Operation</seealso>
        public virtual IAsyncResult BeginDeleteTimeSeriesDataPoints(DeleteTimeSeriesDataPointsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTimeSeriesDataPointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTimeSeriesDataPointsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTimeSeriesDataPoints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTimeSeriesDataPoints.</param>
        /// 
        /// <returns>Returns a  DeleteTimeSeriesDataPointsResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteTimeSeriesDataPoints">REST API Reference for DeleteTimeSeriesDataPoints Operation</seealso>
        public virtual DeleteTimeSeriesDataPointsResponse EndDeleteTimeSeriesDataPoints(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteTimeSeriesDataPointsResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateEnvironmentRole

        /// <summary>
        /// Disassociates the environment role in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateEnvironmentRole service method.</param>
        /// 
        /// <returns>The response from the DisassociateEnvironmentRole service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DisassociateEnvironmentRole">REST API Reference for DisassociateEnvironmentRole Operation</seealso>
        public virtual DisassociateEnvironmentRoleResponse DisassociateEnvironmentRole(DisassociateEnvironmentRoleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateEnvironmentRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateEnvironmentRoleResponseUnmarshaller.Instance;

            return Invoke<DisassociateEnvironmentRoleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateEnvironmentRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateEnvironmentRole operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateEnvironmentRole
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DisassociateEnvironmentRole">REST API Reference for DisassociateEnvironmentRole Operation</seealso>
        public virtual IAsyncResult BeginDisassociateEnvironmentRole(DisassociateEnvironmentRoleRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateEnvironmentRoleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateEnvironmentRoleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateEnvironmentRole operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateEnvironmentRole.</param>
        /// 
        /// <returns>Returns a  DisassociateEnvironmentRoleResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DisassociateEnvironmentRole">REST API Reference for DisassociateEnvironmentRole Operation</seealso>
        public virtual DisassociateEnvironmentRoleResponse EndDisassociateEnvironmentRole(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateEnvironmentRoleResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateGovernedTerms

        /// <summary>
        /// Disassociates restricted terms from an asset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateGovernedTerms service method.</param>
        /// 
        /// <returns>The response from the DisassociateGovernedTerms service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DisassociateGovernedTerms">REST API Reference for DisassociateGovernedTerms Operation</seealso>
        public virtual DisassociateGovernedTermsResponse DisassociateGovernedTerms(DisassociateGovernedTermsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateGovernedTermsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateGovernedTermsResponseUnmarshaller.Instance;

            return Invoke<DisassociateGovernedTermsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateGovernedTerms operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateGovernedTerms operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateGovernedTerms
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DisassociateGovernedTerms">REST API Reference for DisassociateGovernedTerms Operation</seealso>
        public virtual IAsyncResult BeginDisassociateGovernedTerms(DisassociateGovernedTermsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateGovernedTermsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateGovernedTermsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateGovernedTerms operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateGovernedTerms.</param>
        /// 
        /// <returns>Returns a  DisassociateGovernedTermsResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DisassociateGovernedTerms">REST API Reference for DisassociateGovernedTerms Operation</seealso>
        public virtual DisassociateGovernedTermsResponse EndDisassociateGovernedTerms(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateGovernedTermsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAccountPool

        /// <summary>
        /// Gets the details of the account pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountPool service method.</param>
        /// 
        /// <returns>The response from the GetAccountPool service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetAccountPool">REST API Reference for GetAccountPool Operation</seealso>
        public virtual GetAccountPoolResponse GetAccountPool(GetAccountPoolRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAccountPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountPoolResponseUnmarshaller.Instance;

            return Invoke<GetAccountPoolResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccountPool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccountPool operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAccountPool
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetAccountPool">REST API Reference for GetAccountPool Operation</seealso>
        public virtual IAsyncResult BeginGetAccountPool(GetAccountPoolRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAccountPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountPoolResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAccountPool operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccountPool.</param>
        /// 
        /// <returns>Returns a  GetAccountPoolResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetAccountPool">REST API Reference for GetAccountPool Operation</seealso>
        public virtual GetAccountPoolResponse EndGetAccountPool(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAccountPoolResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAsset

        /// <summary>
        /// Gets an Amazon DataZone asset.
        /// 
        ///  
        /// <para>
        /// An asset is the fundamental building block in Amazon DataZone, representing any data
        /// resource that needs to be cataloged and managed. It can take many forms, from Amazon
        /// S3 buckets and database tables to dashboards and machine learning models. Each asset
        /// contains comprehensive metadata about the resource, including its location, schema,
        /// ownership, and lineage information. Assets are essential for organizing and managing
        /// data resources across an organization, making them discoverable and usable while maintaining
        /// proper governance.
        /// </para>
        ///  
        /// <para>
        /// Before using the Amazon DataZone GetAsset command, ensure the following prerequisites
        /// are met:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Domain identifier must exist and be valid
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Asset identifier must exist
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// User must have the required permissions to perform the action
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAsset service method.</param>
        /// 
        /// <returns>The response from the GetAsset service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetAsset">REST API Reference for GetAsset Operation</seealso>
        public virtual GetAssetResponse GetAsset(GetAssetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssetResponseUnmarshaller.Instance;

            return Invoke<GetAssetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAsset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAsset operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAsset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetAsset">REST API Reference for GetAsset Operation</seealso>
        public virtual IAsyncResult BeginGetAsset(GetAssetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAssetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAsset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAsset.</param>
        /// 
        /// <returns>Returns a  GetAssetResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetAsset">REST API Reference for GetAsset Operation</seealso>
        public virtual GetAssetResponse EndGetAsset(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAssetResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAssetFilter

        /// <summary>
        /// Gets an asset filter.
        /// 
        ///  
        /// <para>
        /// Prerequisites:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Domain (<c>--domain-identifier</c>), asset (<c>--asset-identifier</c>), and filter
        /// (<c>--identifier</c>) must all exist. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The asset filter should not have been deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The asset must still exist (since the filter is linked to it).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssetFilter service method.</param>
        /// 
        /// <returns>The response from the GetAssetFilter service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetAssetFilter">REST API Reference for GetAssetFilter Operation</seealso>
        public virtual GetAssetFilterResponse GetAssetFilter(GetAssetFilterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAssetFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssetFilterResponseUnmarshaller.Instance;

            return Invoke<GetAssetFilterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAssetFilter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAssetFilter operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAssetFilter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetAssetFilter">REST API Reference for GetAssetFilter Operation</seealso>
        public virtual IAsyncResult BeginGetAssetFilter(GetAssetFilterRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAssetFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssetFilterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAssetFilter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAssetFilter.</param>
        /// 
        /// <returns>Returns a  GetAssetFilterResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetAssetFilter">REST API Reference for GetAssetFilter Operation</seealso>
        public virtual GetAssetFilterResponse EndGetAssetFilter(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAssetFilterResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAssetType

        /// <summary>
        /// Gets an Amazon DataZone asset type.
        /// 
        ///  
        /// <para>
        /// Asset types define the categories and characteristics of different kinds of data assets
        /// within Amazon DataZone.. They determine what metadata fields are required, what operations
        /// are possible, and how the asset integrates with other Amazon Web Services services.
        /// Asset types can range from built-in types like Amazon S3 buckets and Amazon Web Services
        /// Glue tables to custom types defined for specific organizational needs. Understanding
        /// asset types is crucial for properly organizing and managing different kinds of data
        /// resources.
        /// </para>
        ///  
        /// <para>
        /// Prerequisites:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The asset type with identifier must exist in the domain. ResourceNotFoundException.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must have the GetAssetType permission.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Ensure the domain-identifier value is correct and accessible.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssetType service method.</param>
        /// 
        /// <returns>The response from the GetAssetType service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetAssetType">REST API Reference for GetAssetType Operation</seealso>
        public virtual GetAssetTypeResponse GetAssetType(GetAssetTypeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAssetTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssetTypeResponseUnmarshaller.Instance;

            return Invoke<GetAssetTypeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAssetType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAssetType operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAssetType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetAssetType">REST API Reference for GetAssetType Operation</seealso>
        public virtual IAsyncResult BeginGetAssetType(GetAssetTypeRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAssetTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAssetTypeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAssetType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAssetType.</param>
        /// 
        /// <returns>Returns a  GetAssetTypeResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetAssetType">REST API Reference for GetAssetType Operation</seealso>
        public virtual GetAssetTypeResponse EndGetAssetType(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAssetTypeResponse>(asyncResult);
        }

        #endregion
        
        #region  GetConnection

        /// <summary>
        /// Gets a connection. In Amazon DataZone, a connection enables you to connect your resources
        /// (domains, projects, and environments) to external resources and services.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnection service method.</param>
        /// 
        /// <returns>The response from the GetConnection service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetConnection">REST API Reference for GetConnection Operation</seealso>
        public virtual GetConnectionResponse GetConnection(GetConnectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectionResponseUnmarshaller.Instance;

            return Invoke<GetConnectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConnection operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetConnection">REST API Reference for GetConnection Operation</seealso>
        public virtual IAsyncResult BeginGetConnection(GetConnectionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConnection.</param>
        /// 
        /// <returns>Returns a  GetConnectionResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetConnection">REST API Reference for GetConnection Operation</seealso>
        public virtual GetConnectionResponse EndGetConnection(IAsyncResult asyncResult)
        {
            return EndInvoke<GetConnectionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDataExportConfiguration

        /// <summary>
        /// Gets data export configuration details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataExportConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetDataExportConfiguration service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetDataExportConfiguration">REST API Reference for GetDataExportConfiguration Operation</seealso>
        public virtual GetDataExportConfigurationResponse GetDataExportConfiguration(GetDataExportConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDataExportConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataExportConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetDataExportConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDataExportConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDataExportConfiguration operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDataExportConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetDataExportConfiguration">REST API Reference for GetDataExportConfiguration Operation</seealso>
        public virtual IAsyncResult BeginGetDataExportConfiguration(GetDataExportConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDataExportConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataExportConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDataExportConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDataExportConfiguration.</param>
        /// 
        /// <returns>Returns a  GetDataExportConfigurationResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetDataExportConfiguration">REST API Reference for GetDataExportConfiguration Operation</seealso>
        public virtual GetDataExportConfigurationResponse EndGetDataExportConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDataExportConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDataProduct

        /// <summary>
        /// Gets the data product.
        /// 
        ///  
        /// <para>
        /// Prerequisites:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The data product ID must exist. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The domain must be valid and accessible.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// User must have read or discovery permissions for the data product.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataProduct service method.</param>
        /// 
        /// <returns>The response from the GetDataProduct service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetDataProduct">REST API Reference for GetDataProduct Operation</seealso>
        public virtual GetDataProductResponse GetDataProduct(GetDataProductRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDataProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataProductResponseUnmarshaller.Instance;

            return Invoke<GetDataProductResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDataProduct operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDataProduct operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDataProduct
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetDataProduct">REST API Reference for GetDataProduct Operation</seealso>
        public virtual IAsyncResult BeginGetDataProduct(GetDataProductRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDataProductRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataProductResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDataProduct operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDataProduct.</param>
        /// 
        /// <returns>Returns a  GetDataProductResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetDataProduct">REST API Reference for GetDataProduct Operation</seealso>
        public virtual GetDataProductResponse EndGetDataProduct(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDataProductResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDataSource

        /// <summary>
        /// Gets an Amazon DataZone data source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataSource service method.</param>
        /// 
        /// <returns>The response from the GetDataSource service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetDataSource">REST API Reference for GetDataSource Operation</seealso>
        public virtual GetDataSourceResponse GetDataSource(GetDataSourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataSourceResponseUnmarshaller.Instance;

            return Invoke<GetDataSourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDataSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDataSource operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDataSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetDataSource">REST API Reference for GetDataSource Operation</seealso>
        public virtual IAsyncResult BeginGetDataSource(GetDataSourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataSourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDataSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDataSource.</param>
        /// 
        /// <returns>Returns a  GetDataSourceResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetDataSource">REST API Reference for GetDataSource Operation</seealso>
        public virtual GetDataSourceResponse EndGetDataSource(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDataSourceResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDataSourceRun

        /// <summary>
        /// Gets an Amazon DataZone data source run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataSourceRun service method.</param>
        /// 
        /// <returns>The response from the GetDataSourceRun service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetDataSourceRun">REST API Reference for GetDataSourceRun Operation</seealso>
        public virtual GetDataSourceRunResponse GetDataSourceRun(GetDataSourceRunRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDataSourceRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataSourceRunResponseUnmarshaller.Instance;

            return Invoke<GetDataSourceRunResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDataSourceRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDataSourceRun operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDataSourceRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetDataSourceRun">REST API Reference for GetDataSourceRun Operation</seealso>
        public virtual IAsyncResult BeginGetDataSourceRun(GetDataSourceRunRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDataSourceRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataSourceRunResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDataSourceRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDataSourceRun.</param>
        /// 
        /// <returns>Returns a  GetDataSourceRunResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetDataSourceRun">REST API Reference for GetDataSourceRun Operation</seealso>
        public virtual GetDataSourceRunResponse EndGetDataSourceRun(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDataSourceRunResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDomain

        /// <summary>
        /// Gets an Amazon DataZone domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomain service method.</param>
        /// 
        /// <returns>The response from the GetDomain service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetDomain">REST API Reference for GetDomain Operation</seealso>
        public virtual GetDomainResponse GetDomain(GetDomainRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainResponseUnmarshaller.Instance;

            return Invoke<GetDomainResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDomain operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetDomain">REST API Reference for GetDomain Operation</seealso>
        public virtual IAsyncResult BeginGetDomain(GetDomainRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDomain.</param>
        /// 
        /// <returns>Returns a  GetDomainResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetDomain">REST API Reference for GetDomain Operation</seealso>
        public virtual GetDomainResponse EndGetDomain(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDomainResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDomainUnit

        /// <summary>
        /// Gets the details of the specified domain unit.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainUnit service method.</param>
        /// 
        /// <returns>The response from the GetDomainUnit service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetDomainUnit">REST API Reference for GetDomainUnit Operation</seealso>
        public virtual GetDomainUnitResponse GetDomainUnit(GetDomainUnitRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDomainUnitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainUnitResponseUnmarshaller.Instance;

            return Invoke<GetDomainUnitResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDomainUnit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDomainUnit operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDomainUnit
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetDomainUnit">REST API Reference for GetDomainUnit Operation</seealso>
        public virtual IAsyncResult BeginGetDomainUnit(GetDomainUnitRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDomainUnitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDomainUnitResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDomainUnit operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDomainUnit.</param>
        /// 
        /// <returns>Returns a  GetDomainUnitResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetDomainUnit">REST API Reference for GetDomainUnit Operation</seealso>
        public virtual GetDomainUnitResponse EndGetDomainUnit(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDomainUnitResponse>(asyncResult);
        }

        #endregion
        
        #region  GetEnvironment

        /// <summary>
        /// Gets an Amazon DataZone environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironment service method.</param>
        /// 
        /// <returns>The response from the GetEnvironment service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetEnvironment">REST API Reference for GetEnvironment Operation</seealso>
        public virtual GetEnvironmentResponse GetEnvironment(GetEnvironmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnvironmentResponseUnmarshaller.Instance;

            return Invoke<GetEnvironmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironment operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetEnvironment">REST API Reference for GetEnvironment Operation</seealso>
        public virtual IAsyncResult BeginGetEnvironment(GetEnvironmentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnvironmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEnvironment.</param>
        /// 
        /// <returns>Returns a  GetEnvironmentResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetEnvironment">REST API Reference for GetEnvironment Operation</seealso>
        public virtual GetEnvironmentResponse EndGetEnvironment(IAsyncResult asyncResult)
        {
            return EndInvoke<GetEnvironmentResponse>(asyncResult);
        }

        #endregion
        
        #region  GetEnvironmentAction

        /// <summary>
        /// Gets the specified environment action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironmentAction service method.</param>
        /// 
        /// <returns>The response from the GetEnvironmentAction service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetEnvironmentAction">REST API Reference for GetEnvironmentAction Operation</seealso>
        public virtual GetEnvironmentActionResponse GetEnvironmentAction(GetEnvironmentActionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEnvironmentActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnvironmentActionResponseUnmarshaller.Instance;

            return Invoke<GetEnvironmentActionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetEnvironmentAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironmentAction operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEnvironmentAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetEnvironmentAction">REST API Reference for GetEnvironmentAction Operation</seealso>
        public virtual IAsyncResult BeginGetEnvironmentAction(GetEnvironmentActionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEnvironmentActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnvironmentActionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetEnvironmentAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEnvironmentAction.</param>
        /// 
        /// <returns>Returns a  GetEnvironmentActionResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetEnvironmentAction">REST API Reference for GetEnvironmentAction Operation</seealso>
        public virtual GetEnvironmentActionResponse EndGetEnvironmentAction(IAsyncResult asyncResult)
        {
            return EndInvoke<GetEnvironmentActionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetEnvironmentBlueprint

        /// <summary>
        /// Gets an Amazon DataZone blueprint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironmentBlueprint service method.</param>
        /// 
        /// <returns>The response from the GetEnvironmentBlueprint service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetEnvironmentBlueprint">REST API Reference for GetEnvironmentBlueprint Operation</seealso>
        public virtual GetEnvironmentBlueprintResponse GetEnvironmentBlueprint(GetEnvironmentBlueprintRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEnvironmentBlueprintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnvironmentBlueprintResponseUnmarshaller.Instance;

            return Invoke<GetEnvironmentBlueprintResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetEnvironmentBlueprint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironmentBlueprint operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEnvironmentBlueprint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetEnvironmentBlueprint">REST API Reference for GetEnvironmentBlueprint Operation</seealso>
        public virtual IAsyncResult BeginGetEnvironmentBlueprint(GetEnvironmentBlueprintRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEnvironmentBlueprintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnvironmentBlueprintResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetEnvironmentBlueprint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEnvironmentBlueprint.</param>
        /// 
        /// <returns>Returns a  GetEnvironmentBlueprintResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetEnvironmentBlueprint">REST API Reference for GetEnvironmentBlueprint Operation</seealso>
        public virtual GetEnvironmentBlueprintResponse EndGetEnvironmentBlueprint(IAsyncResult asyncResult)
        {
            return EndInvoke<GetEnvironmentBlueprintResponse>(asyncResult);
        }

        #endregion
        
        #region  GetEnvironmentBlueprintConfiguration

        /// <summary>
        /// Gets the blueprint configuration in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironmentBlueprintConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetEnvironmentBlueprintConfiguration service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetEnvironmentBlueprintConfiguration">REST API Reference for GetEnvironmentBlueprintConfiguration Operation</seealso>
        public virtual GetEnvironmentBlueprintConfigurationResponse GetEnvironmentBlueprintConfiguration(GetEnvironmentBlueprintConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEnvironmentBlueprintConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnvironmentBlueprintConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetEnvironmentBlueprintConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetEnvironmentBlueprintConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironmentBlueprintConfiguration operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEnvironmentBlueprintConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetEnvironmentBlueprintConfiguration">REST API Reference for GetEnvironmentBlueprintConfiguration Operation</seealso>
        public virtual IAsyncResult BeginGetEnvironmentBlueprintConfiguration(GetEnvironmentBlueprintConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEnvironmentBlueprintConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnvironmentBlueprintConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetEnvironmentBlueprintConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEnvironmentBlueprintConfiguration.</param>
        /// 
        /// <returns>Returns a  GetEnvironmentBlueprintConfigurationResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetEnvironmentBlueprintConfiguration">REST API Reference for GetEnvironmentBlueprintConfiguration Operation</seealso>
        public virtual GetEnvironmentBlueprintConfigurationResponse EndGetEnvironmentBlueprintConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetEnvironmentBlueprintConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetEnvironmentCredentials

        /// <summary>
        /// Gets the credentials of an environment in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironmentCredentials service method.</param>
        /// 
        /// <returns>The response from the GetEnvironmentCredentials service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetEnvironmentCredentials">REST API Reference for GetEnvironmentCredentials Operation</seealso>
        public virtual GetEnvironmentCredentialsResponse GetEnvironmentCredentials(GetEnvironmentCredentialsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEnvironmentCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnvironmentCredentialsResponseUnmarshaller.Instance;

            return Invoke<GetEnvironmentCredentialsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetEnvironmentCredentials operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironmentCredentials operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEnvironmentCredentials
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetEnvironmentCredentials">REST API Reference for GetEnvironmentCredentials Operation</seealso>
        public virtual IAsyncResult BeginGetEnvironmentCredentials(GetEnvironmentCredentialsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEnvironmentCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnvironmentCredentialsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetEnvironmentCredentials operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEnvironmentCredentials.</param>
        /// 
        /// <returns>Returns a  GetEnvironmentCredentialsResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetEnvironmentCredentials">REST API Reference for GetEnvironmentCredentials Operation</seealso>
        public virtual GetEnvironmentCredentialsResponse EndGetEnvironmentCredentials(IAsyncResult asyncResult)
        {
            return EndInvoke<GetEnvironmentCredentialsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetEnvironmentProfile

        /// <summary>
        /// Gets an evinronment profile in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironmentProfile service method.</param>
        /// 
        /// <returns>The response from the GetEnvironmentProfile service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetEnvironmentProfile">REST API Reference for GetEnvironmentProfile Operation</seealso>
        public virtual GetEnvironmentProfileResponse GetEnvironmentProfile(GetEnvironmentProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEnvironmentProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnvironmentProfileResponseUnmarshaller.Instance;

            return Invoke<GetEnvironmentProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetEnvironmentProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironmentProfile operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEnvironmentProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetEnvironmentProfile">REST API Reference for GetEnvironmentProfile Operation</seealso>
        public virtual IAsyncResult BeginGetEnvironmentProfile(GetEnvironmentProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEnvironmentProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnvironmentProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetEnvironmentProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEnvironmentProfile.</param>
        /// 
        /// <returns>Returns a  GetEnvironmentProfileResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetEnvironmentProfile">REST API Reference for GetEnvironmentProfile Operation</seealso>
        public virtual GetEnvironmentProfileResponse EndGetEnvironmentProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<GetEnvironmentProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  GetFormType

        /// <summary>
        /// Gets a metadata form type in Amazon DataZone.
        /// 
        ///  
        /// <para>
        /// Form types define the structure and validation rules for collecting metadata about
        /// assets in Amazon DataZone. They act as templates that ensure consistent metadata capture
        /// across similar types of assets, while allowing for customization to meet specific
        /// organizational needs. Form types can include required fields, validation rules, and
        /// dependencies, helping maintain high-quality metadata that makes data assets more discoverable
        /// and usable.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The form type with the specified identifier must exist in the given domain. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The domain must be valid and active.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// User must have permission on the form type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The form type should not be deleted or in an invalid state.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// One use case for this API is to determine whether a form field is indexed for search.
        /// 
        /// </para>
        ///  
        /// <para>
        /// A searchable field will be annotated with <c>@amazon.datazone#searchable</c>. By default,
        /// searchable fields are indexed for semantic search, where related query terms will
        /// match the attribute value even if they are not stemmed or keyword matches. If a field
        /// is indexed technical identifier search, it will be annotated with <c>@amazon.datazone#searchable(modes:["TECHNICAL"])</c>.
        /// If a field is indexed for lexical search (supports stemmed and prefix matches but
        /// not semantic matches), it will be annotated with <c>@amazon.datazone#searchable(modes:["LEXICAL"])</c>.
        /// </para>
        ///  
        /// <para>
        /// A field storing glossary term IDs (which is filterable) will be annotated with <c>@amazon.datazone#glossaryterm("${glossaryId}")</c>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFormType service method.</param>
        /// 
        /// <returns>The response from the GetFormType service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetFormType">REST API Reference for GetFormType Operation</seealso>
        public virtual GetFormTypeResponse GetFormType(GetFormTypeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFormTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFormTypeResponseUnmarshaller.Instance;

            return Invoke<GetFormTypeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetFormType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFormType operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFormType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetFormType">REST API Reference for GetFormType Operation</seealso>
        public virtual IAsyncResult BeginGetFormType(GetFormTypeRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFormTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFormTypeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetFormType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFormType.</param>
        /// 
        /// <returns>Returns a  GetFormTypeResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetFormType">REST API Reference for GetFormType Operation</seealso>
        public virtual GetFormTypeResponse EndGetFormType(IAsyncResult asyncResult)
        {
            return EndInvoke<GetFormTypeResponse>(asyncResult);
        }

        #endregion
        
        #region  GetGlossary

        /// <summary>
        /// Gets a business glossary in Amazon DataZone.
        /// 
        ///  
        /// <para>
        /// Prerequisites:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The specified glossary ID must exist and be associated with the given domain. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The caller must have the <c>datazone:GetGlossary</c> permission on the domain.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGlossary service method.</param>
        /// 
        /// <returns>The response from the GetGlossary service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetGlossary">REST API Reference for GetGlossary Operation</seealso>
        public virtual GetGlossaryResponse GetGlossary(GetGlossaryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGlossaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGlossaryResponseUnmarshaller.Instance;

            return Invoke<GetGlossaryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetGlossary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGlossary operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGlossary
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetGlossary">REST API Reference for GetGlossary Operation</seealso>
        public virtual IAsyncResult BeginGetGlossary(GetGlossaryRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGlossaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGlossaryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetGlossary operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGlossary.</param>
        /// 
        /// <returns>Returns a  GetGlossaryResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetGlossary">REST API Reference for GetGlossary Operation</seealso>
        public virtual GetGlossaryResponse EndGetGlossary(IAsyncResult asyncResult)
        {
            return EndInvoke<GetGlossaryResponse>(asyncResult);
        }

        #endregion
        
        #region  GetGlossaryTerm

        /// <summary>
        /// Gets a business glossary term in Amazon DataZone.
        /// 
        ///  
        /// <para>
        /// Prerequisites:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Glossary term with identifier must exist in the domain. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// User must have permission on the glossary term.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Domain must be accessible and active.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGlossaryTerm service method.</param>
        /// 
        /// <returns>The response from the GetGlossaryTerm service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetGlossaryTerm">REST API Reference for GetGlossaryTerm Operation</seealso>
        public virtual GetGlossaryTermResponse GetGlossaryTerm(GetGlossaryTermRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGlossaryTermRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGlossaryTermResponseUnmarshaller.Instance;

            return Invoke<GetGlossaryTermResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetGlossaryTerm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGlossaryTerm operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGlossaryTerm
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetGlossaryTerm">REST API Reference for GetGlossaryTerm Operation</seealso>
        public virtual IAsyncResult BeginGetGlossaryTerm(GetGlossaryTermRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGlossaryTermRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGlossaryTermResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetGlossaryTerm operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGlossaryTerm.</param>
        /// 
        /// <returns>Returns a  GetGlossaryTermResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetGlossaryTerm">REST API Reference for GetGlossaryTerm Operation</seealso>
        public virtual GetGlossaryTermResponse EndGetGlossaryTerm(IAsyncResult asyncResult)
        {
            return EndInvoke<GetGlossaryTermResponse>(asyncResult);
        }

        #endregion
        
        #region  GetGroupProfile

        /// <summary>
        /// Gets a group profile in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroupProfile service method.</param>
        /// 
        /// <returns>The response from the GetGroupProfile service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetGroupProfile">REST API Reference for GetGroupProfile Operation</seealso>
        public virtual GetGroupProfileResponse GetGroupProfile(GetGroupProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGroupProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGroupProfileResponseUnmarshaller.Instance;

            return Invoke<GetGroupProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetGroupProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGroupProfile operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGroupProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetGroupProfile">REST API Reference for GetGroupProfile Operation</seealso>
        public virtual IAsyncResult BeginGetGroupProfile(GetGroupProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGroupProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGroupProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetGroupProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGroupProfile.</param>
        /// 
        /// <returns>Returns a  GetGroupProfileResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetGroupProfile">REST API Reference for GetGroupProfile Operation</seealso>
        public virtual GetGroupProfileResponse EndGetGroupProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<GetGroupProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  GetIamPortalLoginUrl

        /// <summary>
        /// Gets the data portal URL for the specified Amazon DataZone domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIamPortalLoginUrl service method.</param>
        /// 
        /// <returns>The response from the GetIamPortalLoginUrl service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetIamPortalLoginUrl">REST API Reference for GetIamPortalLoginUrl Operation</seealso>
        public virtual GetIamPortalLoginUrlResponse GetIamPortalLoginUrl(GetIamPortalLoginUrlRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIamPortalLoginUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIamPortalLoginUrlResponseUnmarshaller.Instance;

            return Invoke<GetIamPortalLoginUrlResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetIamPortalLoginUrl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIamPortalLoginUrl operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetIamPortalLoginUrl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetIamPortalLoginUrl">REST API Reference for GetIamPortalLoginUrl Operation</seealso>
        public virtual IAsyncResult BeginGetIamPortalLoginUrl(GetIamPortalLoginUrlRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIamPortalLoginUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIamPortalLoginUrlResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetIamPortalLoginUrl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIamPortalLoginUrl.</param>
        /// 
        /// <returns>Returns a  GetIamPortalLoginUrlResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetIamPortalLoginUrl">REST API Reference for GetIamPortalLoginUrl Operation</seealso>
        public virtual GetIamPortalLoginUrlResponse EndGetIamPortalLoginUrl(IAsyncResult asyncResult)
        {
            return EndInvoke<GetIamPortalLoginUrlResponse>(asyncResult);
        }

        #endregion
        
        #region  GetJobRun

        /// <summary>
        /// The details of the job run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJobRun service method.</param>
        /// 
        /// <returns>The response from the GetJobRun service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetJobRun">REST API Reference for GetJobRun Operation</seealso>
        public virtual GetJobRunResponse GetJobRun(GetJobRunRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetJobRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobRunResponseUnmarshaller.Instance;

            return Invoke<GetJobRunResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetJobRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetJobRun operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetJobRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetJobRun">REST API Reference for GetJobRun Operation</seealso>
        public virtual IAsyncResult BeginGetJobRun(GetJobRunRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetJobRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobRunResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetJobRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetJobRun.</param>
        /// 
        /// <returns>Returns a  GetJobRunResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetJobRun">REST API Reference for GetJobRun Operation</seealso>
        public virtual GetJobRunResponse EndGetJobRun(IAsyncResult asyncResult)
        {
            return EndInvoke<GetJobRunResponse>(asyncResult);
        }

        #endregion
        
        #region  GetLineageEvent

        /// <summary>
        /// Describes the lineage event.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLineageEvent service method.</param>
        /// 
        /// <returns>The response from the GetLineageEvent service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetLineageEvent">REST API Reference for GetLineageEvent Operation</seealso>
        public virtual GetLineageEventResponse GetLineageEvent(GetLineageEventRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetLineageEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLineageEventResponseUnmarshaller.Instance;

            return Invoke<GetLineageEventResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetLineageEvent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLineageEvent operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLineageEvent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetLineageEvent">REST API Reference for GetLineageEvent Operation</seealso>
        public virtual IAsyncResult BeginGetLineageEvent(GetLineageEventRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetLineageEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLineageEventResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetLineageEvent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLineageEvent.</param>
        /// 
        /// <returns>Returns a  GetLineageEventResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetLineageEvent">REST API Reference for GetLineageEvent Operation</seealso>
        public virtual GetLineageEventResponse EndGetLineageEvent(IAsyncResult asyncResult)
        {
            return EndInvoke<GetLineageEventResponse>(asyncResult);
        }

        #endregion
        
        #region  GetLineageNode

        /// <summary>
        /// Gets the data lineage node.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLineageNode service method.</param>
        /// 
        /// <returns>The response from the GetLineageNode service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetLineageNode">REST API Reference for GetLineageNode Operation</seealso>
        public virtual GetLineageNodeResponse GetLineageNode(GetLineageNodeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetLineageNodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLineageNodeResponseUnmarshaller.Instance;

            return Invoke<GetLineageNodeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetLineageNode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLineageNode operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLineageNode
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetLineageNode">REST API Reference for GetLineageNode Operation</seealso>
        public virtual IAsyncResult BeginGetLineageNode(GetLineageNodeRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetLineageNodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLineageNodeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetLineageNode operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLineageNode.</param>
        /// 
        /// <returns>Returns a  GetLineageNodeResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetLineageNode">REST API Reference for GetLineageNode Operation</seealso>
        public virtual GetLineageNodeResponse EndGetLineageNode(IAsyncResult asyncResult)
        {
            return EndInvoke<GetLineageNodeResponse>(asyncResult);
        }

        #endregion
        
        #region  GetListing

        /// <summary>
        /// Gets a listing (a record of an asset at a given time). If you specify a listing version,
        /// only details that are specific to that version are returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetListing service method.</param>
        /// 
        /// <returns>The response from the GetListing service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetListing">REST API Reference for GetListing Operation</seealso>
        public virtual GetListingResponse GetListing(GetListingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetListingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetListingResponseUnmarshaller.Instance;

            return Invoke<GetListingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetListing operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetListing operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetListing
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetListing">REST API Reference for GetListing Operation</seealso>
        public virtual IAsyncResult BeginGetListing(GetListingRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetListingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetListingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetListing operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetListing.</param>
        /// 
        /// <returns>Returns a  GetListingResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetListing">REST API Reference for GetListing Operation</seealso>
        public virtual GetListingResponse EndGetListing(IAsyncResult asyncResult)
        {
            return EndInvoke<GetListingResponse>(asyncResult);
        }

        #endregion
        
        #region  GetMetadataGenerationRun

        /// <summary>
        /// Gets a metadata generation run in Amazon DataZone.
        /// 
        ///  
        /// <para>
        /// Prerequisites:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Valid domain and run identifier. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The metadata generation run must exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// User must have read access to the metadata run.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMetadataGenerationRun service method.</param>
        /// 
        /// <returns>The response from the GetMetadataGenerationRun service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetMetadataGenerationRun">REST API Reference for GetMetadataGenerationRun Operation</seealso>
        public virtual GetMetadataGenerationRunResponse GetMetadataGenerationRun(GetMetadataGenerationRunRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMetadataGenerationRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMetadataGenerationRunResponseUnmarshaller.Instance;

            return Invoke<GetMetadataGenerationRunResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetMetadataGenerationRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMetadataGenerationRun operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMetadataGenerationRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetMetadataGenerationRun">REST API Reference for GetMetadataGenerationRun Operation</seealso>
        public virtual IAsyncResult BeginGetMetadataGenerationRun(GetMetadataGenerationRunRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMetadataGenerationRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMetadataGenerationRunResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetMetadataGenerationRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMetadataGenerationRun.</param>
        /// 
        /// <returns>Returns a  GetMetadataGenerationRunResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetMetadataGenerationRun">REST API Reference for GetMetadataGenerationRun Operation</seealso>
        public virtual GetMetadataGenerationRunResponse EndGetMetadataGenerationRun(IAsyncResult asyncResult)
        {
            return EndInvoke<GetMetadataGenerationRunResponse>(asyncResult);
        }

        #endregion
        
        #region  GetProject

        /// <summary>
        /// Gets a project in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProject service method.</param>
        /// 
        /// <returns>The response from the GetProject service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetProject">REST API Reference for GetProject Operation</seealso>
        public virtual GetProjectResponse GetProject(GetProjectRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProjectResponseUnmarshaller.Instance;

            return Invoke<GetProjectResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetProject operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetProject">REST API Reference for GetProject Operation</seealso>
        public virtual IAsyncResult BeginGetProject(GetProjectRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProjectResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetProject.</param>
        /// 
        /// <returns>Returns a  GetProjectResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetProject">REST API Reference for GetProject Operation</seealso>
        public virtual GetProjectResponse EndGetProject(IAsyncResult asyncResult)
        {
            return EndInvoke<GetProjectResponse>(asyncResult);
        }

        #endregion
        
        #region  GetProjectProfile

        /// <summary>
        /// The details of the project profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProjectProfile service method.</param>
        /// 
        /// <returns>The response from the GetProjectProfile service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetProjectProfile">REST API Reference for GetProjectProfile Operation</seealso>
        public virtual GetProjectProfileResponse GetProjectProfile(GetProjectProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProjectProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProjectProfileResponseUnmarshaller.Instance;

            return Invoke<GetProjectProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetProjectProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetProjectProfile operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetProjectProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetProjectProfile">REST API Reference for GetProjectProfile Operation</seealso>
        public virtual IAsyncResult BeginGetProjectProfile(GetProjectProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProjectProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProjectProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetProjectProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetProjectProfile.</param>
        /// 
        /// <returns>Returns a  GetProjectProfileResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetProjectProfile">REST API Reference for GetProjectProfile Operation</seealso>
        public virtual GetProjectProfileResponse EndGetProjectProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<GetProjectProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRule

        /// <summary>
        /// Gets the details of a rule in Amazon DataZone. A rule is a formal agreement that enforces
        /// specific requirements across user workflows (e.g., publishing assets to the catalog,
        /// requesting subscriptions, creating projects) within the Amazon DataZone data portal.
        /// These rules help maintain consistency, ensure compliance, and uphold governance standards
        /// in data management processes. For instance, a metadata enforcement rule can specify
        /// the required information for creating a subscription request or publishing a data
        /// asset to the catalog, ensuring alignment with organizational standards.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRule service method.</param>
        /// 
        /// <returns>The response from the GetRule service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetRule">REST API Reference for GetRule Operation</seealso>
        public virtual GetRuleResponse GetRule(GetRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRuleResponseUnmarshaller.Instance;

            return Invoke<GetRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRule operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetRule">REST API Reference for GetRule Operation</seealso>
        public virtual IAsyncResult BeginGetRule(GetRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRule.</param>
        /// 
        /// <returns>Returns a  GetRuleResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetRule">REST API Reference for GetRule Operation</seealso>
        public virtual GetRuleResponse EndGetRule(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSubscription

        /// <summary>
        /// Gets a subscription in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSubscription service method.</param>
        /// 
        /// <returns>The response from the GetSubscription service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetSubscription">REST API Reference for GetSubscription Operation</seealso>
        public virtual GetSubscriptionResponse GetSubscription(GetSubscriptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSubscriptionResponseUnmarshaller.Instance;

            return Invoke<GetSubscriptionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSubscription operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetSubscription">REST API Reference for GetSubscription Operation</seealso>
        public virtual IAsyncResult BeginGetSubscription(GetSubscriptionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSubscriptionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSubscription.</param>
        /// 
        /// <returns>Returns a  GetSubscriptionResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetSubscription">REST API Reference for GetSubscription Operation</seealso>
        public virtual GetSubscriptionResponse EndGetSubscription(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSubscriptionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSubscriptionGrant

        /// <summary>
        /// Gets the subscription grant in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSubscriptionGrant service method.</param>
        /// 
        /// <returns>The response from the GetSubscriptionGrant service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetSubscriptionGrant">REST API Reference for GetSubscriptionGrant Operation</seealso>
        public virtual GetSubscriptionGrantResponse GetSubscriptionGrant(GetSubscriptionGrantRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSubscriptionGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSubscriptionGrantResponseUnmarshaller.Instance;

            return Invoke<GetSubscriptionGrantResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSubscriptionGrant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSubscriptionGrant operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSubscriptionGrant
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetSubscriptionGrant">REST API Reference for GetSubscriptionGrant Operation</seealso>
        public virtual IAsyncResult BeginGetSubscriptionGrant(GetSubscriptionGrantRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSubscriptionGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSubscriptionGrantResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSubscriptionGrant operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSubscriptionGrant.</param>
        /// 
        /// <returns>Returns a  GetSubscriptionGrantResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetSubscriptionGrant">REST API Reference for GetSubscriptionGrant Operation</seealso>
        public virtual GetSubscriptionGrantResponse EndGetSubscriptionGrant(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSubscriptionGrantResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSubscriptionRequestDetails

        /// <summary>
        /// Gets the details of the specified subscription request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSubscriptionRequestDetails service method.</param>
        /// 
        /// <returns>The response from the GetSubscriptionRequestDetails service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetSubscriptionRequestDetails">REST API Reference for GetSubscriptionRequestDetails Operation</seealso>
        public virtual GetSubscriptionRequestDetailsResponse GetSubscriptionRequestDetails(GetSubscriptionRequestDetailsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSubscriptionRequestDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSubscriptionRequestDetailsResponseUnmarshaller.Instance;

            return Invoke<GetSubscriptionRequestDetailsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSubscriptionRequestDetails operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSubscriptionRequestDetails operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSubscriptionRequestDetails
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetSubscriptionRequestDetails">REST API Reference for GetSubscriptionRequestDetails Operation</seealso>
        public virtual IAsyncResult BeginGetSubscriptionRequestDetails(GetSubscriptionRequestDetailsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSubscriptionRequestDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSubscriptionRequestDetailsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSubscriptionRequestDetails operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSubscriptionRequestDetails.</param>
        /// 
        /// <returns>Returns a  GetSubscriptionRequestDetailsResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetSubscriptionRequestDetails">REST API Reference for GetSubscriptionRequestDetails Operation</seealso>
        public virtual GetSubscriptionRequestDetailsResponse EndGetSubscriptionRequestDetails(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSubscriptionRequestDetailsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSubscriptionTarget

        /// <summary>
        /// Gets the subscription target in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSubscriptionTarget service method.</param>
        /// 
        /// <returns>The response from the GetSubscriptionTarget service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetSubscriptionTarget">REST API Reference for GetSubscriptionTarget Operation</seealso>
        public virtual GetSubscriptionTargetResponse GetSubscriptionTarget(GetSubscriptionTargetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSubscriptionTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSubscriptionTargetResponseUnmarshaller.Instance;

            return Invoke<GetSubscriptionTargetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSubscriptionTarget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSubscriptionTarget operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSubscriptionTarget
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetSubscriptionTarget">REST API Reference for GetSubscriptionTarget Operation</seealso>
        public virtual IAsyncResult BeginGetSubscriptionTarget(GetSubscriptionTargetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSubscriptionTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSubscriptionTargetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSubscriptionTarget operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSubscriptionTarget.</param>
        /// 
        /// <returns>Returns a  GetSubscriptionTargetResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetSubscriptionTarget">REST API Reference for GetSubscriptionTarget Operation</seealso>
        public virtual GetSubscriptionTargetResponse EndGetSubscriptionTarget(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSubscriptionTargetResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTimeSeriesDataPoint

        /// <summary>
        /// Gets the existing data point for the asset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTimeSeriesDataPoint service method.</param>
        /// 
        /// <returns>The response from the GetTimeSeriesDataPoint service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetTimeSeriesDataPoint">REST API Reference for GetTimeSeriesDataPoint Operation</seealso>
        public virtual GetTimeSeriesDataPointResponse GetTimeSeriesDataPoint(GetTimeSeriesDataPointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTimeSeriesDataPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTimeSeriesDataPointResponseUnmarshaller.Instance;

            return Invoke<GetTimeSeriesDataPointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTimeSeriesDataPoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTimeSeriesDataPoint operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTimeSeriesDataPoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetTimeSeriesDataPoint">REST API Reference for GetTimeSeriesDataPoint Operation</seealso>
        public virtual IAsyncResult BeginGetTimeSeriesDataPoint(GetTimeSeriesDataPointRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTimeSeriesDataPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTimeSeriesDataPointResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTimeSeriesDataPoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTimeSeriesDataPoint.</param>
        /// 
        /// <returns>Returns a  GetTimeSeriesDataPointResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetTimeSeriesDataPoint">REST API Reference for GetTimeSeriesDataPoint Operation</seealso>
        public virtual GetTimeSeriesDataPointResponse EndGetTimeSeriesDataPoint(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTimeSeriesDataPointResponse>(asyncResult);
        }

        #endregion
        
        #region  GetUserProfile

        /// <summary>
        /// Gets a user profile in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUserProfile service method.</param>
        /// 
        /// <returns>The response from the GetUserProfile service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetUserProfile">REST API Reference for GetUserProfile Operation</seealso>
        public virtual GetUserProfileResponse GetUserProfile(GetUserProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetUserProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserProfileResponseUnmarshaller.Instance;

            return Invoke<GetUserProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetUserProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUserProfile operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUserProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetUserProfile">REST API Reference for GetUserProfile Operation</seealso>
        public virtual IAsyncResult BeginGetUserProfile(GetUserProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetUserProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetUserProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUserProfile.</param>
        /// 
        /// <returns>Returns a  GetUserProfileResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetUserProfile">REST API Reference for GetUserProfile Operation</seealso>
        public virtual GetUserProfileResponse EndGetUserProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<GetUserProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAccountPools

        /// <summary>
        /// Lists existing account pools.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccountPools service method.</param>
        /// 
        /// <returns>The response from the ListAccountPools service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListAccountPools">REST API Reference for ListAccountPools Operation</seealso>
        public virtual ListAccountPoolsResponse ListAccountPools(ListAccountPoolsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAccountPoolsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccountPoolsResponseUnmarshaller.Instance;

            return Invoke<ListAccountPoolsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAccountPools operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAccountPools operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAccountPools
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListAccountPools">REST API Reference for ListAccountPools Operation</seealso>
        public virtual IAsyncResult BeginListAccountPools(ListAccountPoolsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAccountPoolsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccountPoolsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAccountPools operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAccountPools.</param>
        /// 
        /// <returns>Returns a  ListAccountPoolsResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListAccountPools">REST API Reference for ListAccountPools Operation</seealso>
        public virtual ListAccountPoolsResponse EndListAccountPools(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAccountPoolsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAccountsInAccountPool

        /// <summary>
        /// Lists the accounts in the specified account pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccountsInAccountPool service method.</param>
        /// 
        /// <returns>The response from the ListAccountsInAccountPool service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListAccountsInAccountPool">REST API Reference for ListAccountsInAccountPool Operation</seealso>
        public virtual ListAccountsInAccountPoolResponse ListAccountsInAccountPool(ListAccountsInAccountPoolRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAccountsInAccountPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccountsInAccountPoolResponseUnmarshaller.Instance;

            return Invoke<ListAccountsInAccountPoolResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAccountsInAccountPool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAccountsInAccountPool operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAccountsInAccountPool
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListAccountsInAccountPool">REST API Reference for ListAccountsInAccountPool Operation</seealso>
        public virtual IAsyncResult BeginListAccountsInAccountPool(ListAccountsInAccountPoolRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAccountsInAccountPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAccountsInAccountPoolResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAccountsInAccountPool operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAccountsInAccountPool.</param>
        /// 
        /// <returns>Returns a  ListAccountsInAccountPoolResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListAccountsInAccountPool">REST API Reference for ListAccountsInAccountPool Operation</seealso>
        public virtual ListAccountsInAccountPoolResponse EndListAccountsInAccountPool(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAccountsInAccountPoolResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAssetFilters

        /// <summary>
        /// Lists asset filters.
        /// 
        ///  
        /// <para>
        /// Prerequisites:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A valid domain and asset must exist. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The asset must have at least one filter created to return results. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssetFilters service method.</param>
        /// 
        /// <returns>The response from the ListAssetFilters service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListAssetFilters">REST API Reference for ListAssetFilters Operation</seealso>
        public virtual ListAssetFiltersResponse ListAssetFilters(ListAssetFiltersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAssetFiltersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssetFiltersResponseUnmarshaller.Instance;

            return Invoke<ListAssetFiltersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAssetFilters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssetFilters operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAssetFilters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListAssetFilters">REST API Reference for ListAssetFilters Operation</seealso>
        public virtual IAsyncResult BeginListAssetFilters(ListAssetFiltersRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAssetFiltersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssetFiltersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAssetFilters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAssetFilters.</param>
        /// 
        /// <returns>Returns a  ListAssetFiltersResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListAssetFilters">REST API Reference for ListAssetFilters Operation</seealso>
        public virtual ListAssetFiltersResponse EndListAssetFilters(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAssetFiltersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAssetRevisions

        /// <summary>
        /// Lists the revisions for the asset.
        /// 
        ///  
        /// <para>
        /// Prerequisites:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The asset must exist in the domain. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There must be at least one revision of the asset (which happens automatically after
        /// creation).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The domain must be valid and active.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// User must have permissions on the asset and domain.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssetRevisions service method.</param>
        /// 
        /// <returns>The response from the ListAssetRevisions service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListAssetRevisions">REST API Reference for ListAssetRevisions Operation</seealso>
        public virtual ListAssetRevisionsResponse ListAssetRevisions(ListAssetRevisionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAssetRevisionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssetRevisionsResponseUnmarshaller.Instance;

            return Invoke<ListAssetRevisionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAssetRevisions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssetRevisions operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAssetRevisions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListAssetRevisions">REST API Reference for ListAssetRevisions Operation</seealso>
        public virtual IAsyncResult BeginListAssetRevisions(ListAssetRevisionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAssetRevisionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssetRevisionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAssetRevisions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAssetRevisions.</param>
        /// 
        /// <returns>Returns a  ListAssetRevisionsResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListAssetRevisions">REST API Reference for ListAssetRevisions Operation</seealso>
        public virtual ListAssetRevisionsResponse EndListAssetRevisions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAssetRevisionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListConnections

        /// <summary>
        /// Lists connections. In Amazon DataZone, a connection enables you to connect your resources
        /// (domains, projects, and environments) to external resources and services.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConnections service method.</param>
        /// 
        /// <returns>The response from the ListConnections service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListConnections">REST API Reference for ListConnections Operation</seealso>
        public virtual ListConnectionsResponse ListConnections(ListConnectionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConnectionsResponseUnmarshaller.Instance;

            return Invoke<ListConnectionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListConnections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConnections operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListConnections
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListConnections">REST API Reference for ListConnections Operation</seealso>
        public virtual IAsyncResult BeginListConnections(ListConnectionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConnectionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListConnections operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListConnections.</param>
        /// 
        /// <returns>Returns a  ListConnectionsResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListConnections">REST API Reference for ListConnections Operation</seealso>
        public virtual ListConnectionsResponse EndListConnections(IAsyncResult asyncResult)
        {
            return EndInvoke<ListConnectionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDataProductRevisions

        /// <summary>
        /// Lists data product revisions.
        /// 
        ///  
        /// <para>
        /// Prerequisites:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The data product ID must exist within the domain. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// User must have view permissions on the data product.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The domain must be in a valid and accessible state.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataProductRevisions service method.</param>
        /// 
        /// <returns>The response from the ListDataProductRevisions service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListDataProductRevisions">REST API Reference for ListDataProductRevisions Operation</seealso>
        public virtual ListDataProductRevisionsResponse ListDataProductRevisions(ListDataProductRevisionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDataProductRevisionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataProductRevisionsResponseUnmarshaller.Instance;

            return Invoke<ListDataProductRevisionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDataProductRevisions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDataProductRevisions operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDataProductRevisions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListDataProductRevisions">REST API Reference for ListDataProductRevisions Operation</seealso>
        public virtual IAsyncResult BeginListDataProductRevisions(ListDataProductRevisionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDataProductRevisionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataProductRevisionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDataProductRevisions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDataProductRevisions.</param>
        /// 
        /// <returns>Returns a  ListDataProductRevisionsResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListDataProductRevisions">REST API Reference for ListDataProductRevisions Operation</seealso>
        public virtual ListDataProductRevisionsResponse EndListDataProductRevisions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDataProductRevisionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDataSourceRunActivities

        /// <summary>
        /// Lists data source run activities.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataSourceRunActivities service method.</param>
        /// 
        /// <returns>The response from the ListDataSourceRunActivities service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListDataSourceRunActivities">REST API Reference for ListDataSourceRunActivities Operation</seealso>
        public virtual ListDataSourceRunActivitiesResponse ListDataSourceRunActivities(ListDataSourceRunActivitiesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDataSourceRunActivitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataSourceRunActivitiesResponseUnmarshaller.Instance;

            return Invoke<ListDataSourceRunActivitiesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDataSourceRunActivities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDataSourceRunActivities operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDataSourceRunActivities
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListDataSourceRunActivities">REST API Reference for ListDataSourceRunActivities Operation</seealso>
        public virtual IAsyncResult BeginListDataSourceRunActivities(ListDataSourceRunActivitiesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDataSourceRunActivitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataSourceRunActivitiesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDataSourceRunActivities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDataSourceRunActivities.</param>
        /// 
        /// <returns>Returns a  ListDataSourceRunActivitiesResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListDataSourceRunActivities">REST API Reference for ListDataSourceRunActivities Operation</seealso>
        public virtual ListDataSourceRunActivitiesResponse EndListDataSourceRunActivities(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDataSourceRunActivitiesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDataSourceRuns

        /// <summary>
        /// Lists data source runs in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataSourceRuns service method.</param>
        /// 
        /// <returns>The response from the ListDataSourceRuns service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListDataSourceRuns">REST API Reference for ListDataSourceRuns Operation</seealso>
        public virtual ListDataSourceRunsResponse ListDataSourceRuns(ListDataSourceRunsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDataSourceRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataSourceRunsResponseUnmarshaller.Instance;

            return Invoke<ListDataSourceRunsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDataSourceRuns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDataSourceRuns operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDataSourceRuns
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListDataSourceRuns">REST API Reference for ListDataSourceRuns Operation</seealso>
        public virtual IAsyncResult BeginListDataSourceRuns(ListDataSourceRunsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDataSourceRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataSourceRunsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDataSourceRuns operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDataSourceRuns.</param>
        /// 
        /// <returns>Returns a  ListDataSourceRunsResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListDataSourceRuns">REST API Reference for ListDataSourceRuns Operation</seealso>
        public virtual ListDataSourceRunsResponse EndListDataSourceRuns(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDataSourceRunsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDataSources

        /// <summary>
        /// Lists data sources in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataSources service method.</param>
        /// 
        /// <returns>The response from the ListDataSources service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListDataSources">REST API Reference for ListDataSources Operation</seealso>
        public virtual ListDataSourcesResponse ListDataSources(ListDataSourcesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDataSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataSourcesResponseUnmarshaller.Instance;

            return Invoke<ListDataSourcesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDataSources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDataSources operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDataSources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListDataSources">REST API Reference for ListDataSources Operation</seealso>
        public virtual IAsyncResult BeginListDataSources(ListDataSourcesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDataSourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDataSourcesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDataSources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDataSources.</param>
        /// 
        /// <returns>Returns a  ListDataSourcesResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListDataSources">REST API Reference for ListDataSources Operation</seealso>
        public virtual ListDataSourcesResponse EndListDataSources(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDataSourcesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDomains

        /// <summary>
        /// Lists Amazon DataZone domains.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomains service method.</param>
        /// 
        /// <returns>The response from the ListDomains service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListDomains">REST API Reference for ListDomains Operation</seealso>
        public virtual ListDomainsResponse ListDomains(ListDomainsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainsResponseUnmarshaller.Instance;

            return Invoke<ListDomainsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDomains operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDomains operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDomains
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListDomains">REST API Reference for ListDomains Operation</seealso>
        public virtual IAsyncResult BeginListDomains(ListDomainsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDomains operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDomains.</param>
        /// 
        /// <returns>Returns a  ListDomainsResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListDomains">REST API Reference for ListDomains Operation</seealso>
        public virtual ListDomainsResponse EndListDomains(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDomainsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDomainUnitsForParent

        /// <summary>
        /// Lists child domain units for the specified parent domain unit.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomainUnitsForParent service method.</param>
        /// 
        /// <returns>The response from the ListDomainUnitsForParent service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListDomainUnitsForParent">REST API Reference for ListDomainUnitsForParent Operation</seealso>
        public virtual ListDomainUnitsForParentResponse ListDomainUnitsForParent(ListDomainUnitsForParentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDomainUnitsForParentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainUnitsForParentResponseUnmarshaller.Instance;

            return Invoke<ListDomainUnitsForParentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDomainUnitsForParent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDomainUnitsForParent operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDomainUnitsForParent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListDomainUnitsForParent">REST API Reference for ListDomainUnitsForParent Operation</seealso>
        public virtual IAsyncResult BeginListDomainUnitsForParent(ListDomainUnitsForParentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDomainUnitsForParentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainUnitsForParentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDomainUnitsForParent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDomainUnitsForParent.</param>
        /// 
        /// <returns>Returns a  ListDomainUnitsForParentResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListDomainUnitsForParent">REST API Reference for ListDomainUnitsForParent Operation</seealso>
        public virtual ListDomainUnitsForParentResponse EndListDomainUnitsForParent(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDomainUnitsForParentResponse>(asyncResult);
        }

        #endregion
        
        #region  ListEntityOwners

        /// <summary>
        /// Lists the entity (domain units) owners.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEntityOwners service method.</param>
        /// 
        /// <returns>The response from the ListEntityOwners service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListEntityOwners">REST API Reference for ListEntityOwners Operation</seealso>
        public virtual ListEntityOwnersResponse ListEntityOwners(ListEntityOwnersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEntityOwnersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEntityOwnersResponseUnmarshaller.Instance;

            return Invoke<ListEntityOwnersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListEntityOwners operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEntityOwners operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEntityOwners
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListEntityOwners">REST API Reference for ListEntityOwners Operation</seealso>
        public virtual IAsyncResult BeginListEntityOwners(ListEntityOwnersRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEntityOwnersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEntityOwnersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListEntityOwners operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEntityOwners.</param>
        /// 
        /// <returns>Returns a  ListEntityOwnersResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListEntityOwners">REST API Reference for ListEntityOwners Operation</seealso>
        public virtual ListEntityOwnersResponse EndListEntityOwners(IAsyncResult asyncResult)
        {
            return EndInvoke<ListEntityOwnersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListEnvironmentActions

        /// <summary>
        /// Lists existing environment actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironmentActions service method.</param>
        /// 
        /// <returns>The response from the ListEnvironmentActions service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListEnvironmentActions">REST API Reference for ListEnvironmentActions Operation</seealso>
        public virtual ListEnvironmentActionsResponse ListEnvironmentActions(ListEnvironmentActionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEnvironmentActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentActionsResponseUnmarshaller.Instance;

            return Invoke<ListEnvironmentActionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListEnvironmentActions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironmentActions operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEnvironmentActions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListEnvironmentActions">REST API Reference for ListEnvironmentActions Operation</seealso>
        public virtual IAsyncResult BeginListEnvironmentActions(ListEnvironmentActionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEnvironmentActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentActionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListEnvironmentActions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEnvironmentActions.</param>
        /// 
        /// <returns>Returns a  ListEnvironmentActionsResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListEnvironmentActions">REST API Reference for ListEnvironmentActions Operation</seealso>
        public virtual ListEnvironmentActionsResponse EndListEnvironmentActions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListEnvironmentActionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListEnvironmentBlueprintConfigurations

        /// <summary>
        /// Lists blueprint configurations for a Amazon DataZone environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironmentBlueprintConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListEnvironmentBlueprintConfigurations service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListEnvironmentBlueprintConfigurations">REST API Reference for ListEnvironmentBlueprintConfigurations Operation</seealso>
        public virtual ListEnvironmentBlueprintConfigurationsResponse ListEnvironmentBlueprintConfigurations(ListEnvironmentBlueprintConfigurationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEnvironmentBlueprintConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentBlueprintConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListEnvironmentBlueprintConfigurationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListEnvironmentBlueprintConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironmentBlueprintConfigurations operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEnvironmentBlueprintConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListEnvironmentBlueprintConfigurations">REST API Reference for ListEnvironmentBlueprintConfigurations Operation</seealso>
        public virtual IAsyncResult BeginListEnvironmentBlueprintConfigurations(ListEnvironmentBlueprintConfigurationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEnvironmentBlueprintConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentBlueprintConfigurationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListEnvironmentBlueprintConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEnvironmentBlueprintConfigurations.</param>
        /// 
        /// <returns>Returns a  ListEnvironmentBlueprintConfigurationsResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListEnvironmentBlueprintConfigurations">REST API Reference for ListEnvironmentBlueprintConfigurations Operation</seealso>
        public virtual ListEnvironmentBlueprintConfigurationsResponse EndListEnvironmentBlueprintConfigurations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListEnvironmentBlueprintConfigurationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListEnvironmentBlueprints

        /// <summary>
        /// Lists blueprints in an Amazon DataZone environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironmentBlueprints service method.</param>
        /// 
        /// <returns>The response from the ListEnvironmentBlueprints service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListEnvironmentBlueprints">REST API Reference for ListEnvironmentBlueprints Operation</seealso>
        public virtual ListEnvironmentBlueprintsResponse ListEnvironmentBlueprints(ListEnvironmentBlueprintsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEnvironmentBlueprintsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentBlueprintsResponseUnmarshaller.Instance;

            return Invoke<ListEnvironmentBlueprintsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListEnvironmentBlueprints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironmentBlueprints operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEnvironmentBlueprints
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListEnvironmentBlueprints">REST API Reference for ListEnvironmentBlueprints Operation</seealso>
        public virtual IAsyncResult BeginListEnvironmentBlueprints(ListEnvironmentBlueprintsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEnvironmentBlueprintsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentBlueprintsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListEnvironmentBlueprints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEnvironmentBlueprints.</param>
        /// 
        /// <returns>Returns a  ListEnvironmentBlueprintsResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListEnvironmentBlueprints">REST API Reference for ListEnvironmentBlueprints Operation</seealso>
        public virtual ListEnvironmentBlueprintsResponse EndListEnvironmentBlueprints(IAsyncResult asyncResult)
        {
            return EndInvoke<ListEnvironmentBlueprintsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListEnvironmentProfiles

        /// <summary>
        /// Lists Amazon DataZone environment profiles.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironmentProfiles service method.</param>
        /// 
        /// <returns>The response from the ListEnvironmentProfiles service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListEnvironmentProfiles">REST API Reference for ListEnvironmentProfiles Operation</seealso>
        public virtual ListEnvironmentProfilesResponse ListEnvironmentProfiles(ListEnvironmentProfilesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEnvironmentProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentProfilesResponseUnmarshaller.Instance;

            return Invoke<ListEnvironmentProfilesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListEnvironmentProfiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironmentProfiles operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEnvironmentProfiles
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListEnvironmentProfiles">REST API Reference for ListEnvironmentProfiles Operation</seealso>
        public virtual IAsyncResult BeginListEnvironmentProfiles(ListEnvironmentProfilesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListEnvironmentProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentProfilesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListEnvironmentProfiles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEnvironmentProfiles.</param>
        /// 
        /// <returns>Returns a  ListEnvironmentProfilesResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListEnvironmentProfiles">REST API Reference for ListEnvironmentProfiles Operation</seealso>
        public virtual ListEnvironmentProfilesResponse EndListEnvironmentProfiles(IAsyncResult asyncResult)
        {
            return EndInvoke<ListEnvironmentProfilesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListEnvironments

        /// <summary>
        /// Lists Amazon DataZone environments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironments service method.</param>
        /// 
        /// <returns>The response from the ListEnvironments service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListEnvironments">REST API Reference for ListEnvironments Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironments operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEnvironments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListEnvironments">REST API Reference for ListEnvironments Operation</seealso>
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
        /// <returns>Returns a  ListEnvironmentsResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListEnvironments">REST API Reference for ListEnvironments Operation</seealso>
        public virtual ListEnvironmentsResponse EndListEnvironments(IAsyncResult asyncResult)
        {
            return EndInvoke<ListEnvironmentsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListJobRuns

        /// <summary>
        /// Lists job runs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobRuns service method.</param>
        /// 
        /// <returns>The response from the ListJobRuns service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListJobRuns">REST API Reference for ListJobRuns Operation</seealso>
        public virtual ListJobRunsResponse ListJobRuns(ListJobRunsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListJobRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobRunsResponseUnmarshaller.Instance;

            return Invoke<ListJobRunsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListJobRuns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListJobRuns operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListJobRuns
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListJobRuns">REST API Reference for ListJobRuns Operation</seealso>
        public virtual IAsyncResult BeginListJobRuns(ListJobRunsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListJobRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobRunsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListJobRuns operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListJobRuns.</param>
        /// 
        /// <returns>Returns a  ListJobRunsResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListJobRuns">REST API Reference for ListJobRuns Operation</seealso>
        public virtual ListJobRunsResponse EndListJobRuns(IAsyncResult asyncResult)
        {
            return EndInvoke<ListJobRunsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListLineageEvents

        /// <summary>
        /// Lists lineage events.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLineageEvents service method.</param>
        /// 
        /// <returns>The response from the ListLineageEvents service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListLineageEvents">REST API Reference for ListLineageEvents Operation</seealso>
        public virtual ListLineageEventsResponse ListLineageEvents(ListLineageEventsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLineageEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLineageEventsResponseUnmarshaller.Instance;

            return Invoke<ListLineageEventsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListLineageEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLineageEvents operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLineageEvents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListLineageEvents">REST API Reference for ListLineageEvents Operation</seealso>
        public virtual IAsyncResult BeginListLineageEvents(ListLineageEventsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLineageEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLineageEventsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListLineageEvents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLineageEvents.</param>
        /// 
        /// <returns>Returns a  ListLineageEventsResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListLineageEvents">REST API Reference for ListLineageEvents Operation</seealso>
        public virtual ListLineageEventsResponse EndListLineageEvents(IAsyncResult asyncResult)
        {
            return EndInvoke<ListLineageEventsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListLineageNodeHistory

        /// <summary>
        /// Lists the history of the specified data lineage node.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLineageNodeHistory service method.</param>
        /// 
        /// <returns>The response from the ListLineageNodeHistory service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListLineageNodeHistory">REST API Reference for ListLineageNodeHistory Operation</seealso>
        public virtual ListLineageNodeHistoryResponse ListLineageNodeHistory(ListLineageNodeHistoryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLineageNodeHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLineageNodeHistoryResponseUnmarshaller.Instance;

            return Invoke<ListLineageNodeHistoryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListLineageNodeHistory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLineageNodeHistory operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLineageNodeHistory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListLineageNodeHistory">REST API Reference for ListLineageNodeHistory Operation</seealso>
        public virtual IAsyncResult BeginListLineageNodeHistory(ListLineageNodeHistoryRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLineageNodeHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLineageNodeHistoryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListLineageNodeHistory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLineageNodeHistory.</param>
        /// 
        /// <returns>Returns a  ListLineageNodeHistoryResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListLineageNodeHistory">REST API Reference for ListLineageNodeHistory Operation</seealso>
        public virtual ListLineageNodeHistoryResponse EndListLineageNodeHistory(IAsyncResult asyncResult)
        {
            return EndInvoke<ListLineageNodeHistoryResponse>(asyncResult);
        }

        #endregion
        
        #region  ListMetadataGenerationRuns

        /// <summary>
        /// Lists all metadata generation runs.
        /// 
        ///  
        /// <para>
        /// Metadata generation runs represent automated processes that leverage AI/ML capabilities
        /// to create or enhance asset metadata at scale. This feature helps organizations maintain
        /// comprehensive and consistent metadata across large numbers of assets without manual
        /// intervention. It can automatically generate business descriptions, tags, and other
        /// metadata elements, significantly reducing the time and effort required for metadata
        /// management while improving consistency and completeness.
        /// </para>
        ///  
        /// <para>
        /// Prerequisites:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Valid domain identifier. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// User must have access to metadata generation runs in the domain.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMetadataGenerationRuns service method.</param>
        /// 
        /// <returns>The response from the ListMetadataGenerationRuns service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListMetadataGenerationRuns">REST API Reference for ListMetadataGenerationRuns Operation</seealso>
        public virtual ListMetadataGenerationRunsResponse ListMetadataGenerationRuns(ListMetadataGenerationRunsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMetadataGenerationRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMetadataGenerationRunsResponseUnmarshaller.Instance;

            return Invoke<ListMetadataGenerationRunsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListMetadataGenerationRuns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMetadataGenerationRuns operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMetadataGenerationRuns
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListMetadataGenerationRuns">REST API Reference for ListMetadataGenerationRuns Operation</seealso>
        public virtual IAsyncResult BeginListMetadataGenerationRuns(ListMetadataGenerationRunsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMetadataGenerationRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMetadataGenerationRunsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListMetadataGenerationRuns operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMetadataGenerationRuns.</param>
        /// 
        /// <returns>Returns a  ListMetadataGenerationRunsResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListMetadataGenerationRuns">REST API Reference for ListMetadataGenerationRuns Operation</seealso>
        public virtual ListMetadataGenerationRunsResponse EndListMetadataGenerationRuns(IAsyncResult asyncResult)
        {
            return EndInvoke<ListMetadataGenerationRunsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListNotifications

        /// <summary>
        /// Lists all Amazon DataZone notifications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNotifications service method.</param>
        /// 
        /// <returns>The response from the ListNotifications service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListNotifications">REST API Reference for ListNotifications Operation</seealso>
        public virtual ListNotificationsResponse ListNotifications(ListNotificationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListNotificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNotificationsResponseUnmarshaller.Instance;

            return Invoke<ListNotificationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListNotifications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListNotifications operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListNotifications
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListNotifications">REST API Reference for ListNotifications Operation</seealso>
        public virtual IAsyncResult BeginListNotifications(ListNotificationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListNotificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNotificationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListNotifications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListNotifications.</param>
        /// 
        /// <returns>Returns a  ListNotificationsResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListNotifications">REST API Reference for ListNotifications Operation</seealso>
        public virtual ListNotificationsResponse EndListNotifications(IAsyncResult asyncResult)
        {
            return EndInvoke<ListNotificationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPolicyGrants

        /// <summary>
        /// Lists policy grants.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPolicyGrants service method.</param>
        /// 
        /// <returns>The response from the ListPolicyGrants service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListPolicyGrants">REST API Reference for ListPolicyGrants Operation</seealso>
        public virtual ListPolicyGrantsResponse ListPolicyGrants(ListPolicyGrantsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPolicyGrantsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPolicyGrantsResponseUnmarshaller.Instance;

            return Invoke<ListPolicyGrantsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPolicyGrants operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPolicyGrants operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPolicyGrants
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListPolicyGrants">REST API Reference for ListPolicyGrants Operation</seealso>
        public virtual IAsyncResult BeginListPolicyGrants(ListPolicyGrantsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPolicyGrantsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPolicyGrantsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPolicyGrants operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPolicyGrants.</param>
        /// 
        /// <returns>Returns a  ListPolicyGrantsResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListPolicyGrants">REST API Reference for ListPolicyGrants Operation</seealso>
        public virtual ListPolicyGrantsResponse EndListPolicyGrants(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPolicyGrantsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListProjectMemberships

        /// <summary>
        /// Lists all members of the specified project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProjectMemberships service method.</param>
        /// 
        /// <returns>The response from the ListProjectMemberships service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListProjectMemberships">REST API Reference for ListProjectMemberships Operation</seealso>
        public virtual ListProjectMembershipsResponse ListProjectMemberships(ListProjectMembershipsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProjectMembershipsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProjectMembershipsResponseUnmarshaller.Instance;

            return Invoke<ListProjectMembershipsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListProjectMemberships operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProjectMemberships operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProjectMemberships
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListProjectMemberships">REST API Reference for ListProjectMemberships Operation</seealso>
        public virtual IAsyncResult BeginListProjectMemberships(ListProjectMembershipsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProjectMembershipsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProjectMembershipsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListProjectMemberships operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProjectMemberships.</param>
        /// 
        /// <returns>Returns a  ListProjectMembershipsResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListProjectMemberships">REST API Reference for ListProjectMemberships Operation</seealso>
        public virtual ListProjectMembershipsResponse EndListProjectMemberships(IAsyncResult asyncResult)
        {
            return EndInvoke<ListProjectMembershipsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListProjectProfiles

        /// <summary>
        /// Lists project profiles.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProjectProfiles service method.</param>
        /// 
        /// <returns>The response from the ListProjectProfiles service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListProjectProfiles">REST API Reference for ListProjectProfiles Operation</seealso>
        public virtual ListProjectProfilesResponse ListProjectProfiles(ListProjectProfilesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProjectProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProjectProfilesResponseUnmarshaller.Instance;

            return Invoke<ListProjectProfilesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListProjectProfiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProjectProfiles operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProjectProfiles
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListProjectProfiles">REST API Reference for ListProjectProfiles Operation</seealso>
        public virtual IAsyncResult BeginListProjectProfiles(ListProjectProfilesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProjectProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProjectProfilesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListProjectProfiles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProjectProfiles.</param>
        /// 
        /// <returns>Returns a  ListProjectProfilesResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListProjectProfiles">REST API Reference for ListProjectProfiles Operation</seealso>
        public virtual ListProjectProfilesResponse EndListProjectProfiles(IAsyncResult asyncResult)
        {
            return EndInvoke<ListProjectProfilesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListProjects

        /// <summary>
        /// Lists Amazon DataZone projects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProjects service method.</param>
        /// 
        /// <returns>The response from the ListProjects service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListProjects">REST API Reference for ListProjects Operation</seealso>
        public virtual ListProjectsResponse ListProjects(ListProjectsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProjectsResponseUnmarshaller.Instance;

            return Invoke<ListProjectsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListProjects operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProjects operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProjects
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListProjects">REST API Reference for ListProjects Operation</seealso>
        public virtual IAsyncResult BeginListProjects(ListProjectsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProjectsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListProjects operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProjects.</param>
        /// 
        /// <returns>Returns a  ListProjectsResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListProjects">REST API Reference for ListProjects Operation</seealso>
        public virtual ListProjectsResponse EndListProjects(IAsyncResult asyncResult)
        {
            return EndInvoke<ListProjectsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRules

        /// <summary>
        /// Lists existing rules. In Amazon DataZone, a rule is a formal agreement that enforces
        /// specific requirements across user workflows (e.g., publishing assets to the catalog,
        /// requesting subscriptions, creating projects) within the Amazon DataZone data portal.
        /// These rules help maintain consistency, ensure compliance, and uphold governance standards
        /// in data management processes. For instance, a metadata enforcement rule can specify
        /// the required information for creating a subscription request or publishing a data
        /// asset to the catalog, ensuring alignment with organizational standards.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRules service method.</param>
        /// 
        /// <returns>The response from the ListRules service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListRules">REST API Reference for ListRules Operation</seealso>
        public virtual ListRulesResponse ListRules(ListRulesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRulesResponseUnmarshaller.Instance;

            return Invoke<ListRulesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRules operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRules
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListRules">REST API Reference for ListRules Operation</seealso>
        public virtual IAsyncResult BeginListRules(ListRulesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRulesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRules.</param>
        /// 
        /// <returns>Returns a  ListRulesResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListRules">REST API Reference for ListRules Operation</seealso>
        public virtual ListRulesResponse EndListRules(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRulesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSubscriptionGrants

        /// <summary>
        /// Lists subscription grants.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptionGrants service method.</param>
        /// 
        /// <returns>The response from the ListSubscriptionGrants service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListSubscriptionGrants">REST API Reference for ListSubscriptionGrants Operation</seealso>
        public virtual ListSubscriptionGrantsResponse ListSubscriptionGrants(ListSubscriptionGrantsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSubscriptionGrantsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSubscriptionGrantsResponseUnmarshaller.Instance;

            return Invoke<ListSubscriptionGrantsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSubscriptionGrants operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptionGrants operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSubscriptionGrants
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListSubscriptionGrants">REST API Reference for ListSubscriptionGrants Operation</seealso>
        public virtual IAsyncResult BeginListSubscriptionGrants(ListSubscriptionGrantsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSubscriptionGrantsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSubscriptionGrantsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSubscriptionGrants operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSubscriptionGrants.</param>
        /// 
        /// <returns>Returns a  ListSubscriptionGrantsResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListSubscriptionGrants">REST API Reference for ListSubscriptionGrants Operation</seealso>
        public virtual ListSubscriptionGrantsResponse EndListSubscriptionGrants(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSubscriptionGrantsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSubscriptionRequests

        /// <summary>
        /// Lists Amazon DataZone subscription requests.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptionRequests service method.</param>
        /// 
        /// <returns>The response from the ListSubscriptionRequests service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListSubscriptionRequests">REST API Reference for ListSubscriptionRequests Operation</seealso>
        public virtual ListSubscriptionRequestsResponse ListSubscriptionRequests(ListSubscriptionRequestsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSubscriptionRequestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSubscriptionRequestsResponseUnmarshaller.Instance;

            return Invoke<ListSubscriptionRequestsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSubscriptionRequests operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptionRequests operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSubscriptionRequests
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListSubscriptionRequests">REST API Reference for ListSubscriptionRequests Operation</seealso>
        public virtual IAsyncResult BeginListSubscriptionRequests(ListSubscriptionRequestsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSubscriptionRequestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSubscriptionRequestsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSubscriptionRequests operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSubscriptionRequests.</param>
        /// 
        /// <returns>Returns a  ListSubscriptionRequestsResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListSubscriptionRequests">REST API Reference for ListSubscriptionRequests Operation</seealso>
        public virtual ListSubscriptionRequestsResponse EndListSubscriptionRequests(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSubscriptionRequestsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSubscriptions

        /// <summary>
        /// Lists subscriptions in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptions service method.</param>
        /// 
        /// <returns>The response from the ListSubscriptions service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListSubscriptions">REST API Reference for ListSubscriptions Operation</seealso>
        public virtual ListSubscriptionsResponse ListSubscriptions(ListSubscriptionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSubscriptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSubscriptionsResponseUnmarshaller.Instance;

            return Invoke<ListSubscriptionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSubscriptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptions operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSubscriptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListSubscriptions">REST API Reference for ListSubscriptions Operation</seealso>
        public virtual IAsyncResult BeginListSubscriptions(ListSubscriptionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSubscriptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSubscriptionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSubscriptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSubscriptions.</param>
        /// 
        /// <returns>Returns a  ListSubscriptionsResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListSubscriptions">REST API Reference for ListSubscriptions Operation</seealso>
        public virtual ListSubscriptionsResponse EndListSubscriptions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSubscriptionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSubscriptionTargets

        /// <summary>
        /// Lists subscription targets in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptionTargets service method.</param>
        /// 
        /// <returns>The response from the ListSubscriptionTargets service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListSubscriptionTargets">REST API Reference for ListSubscriptionTargets Operation</seealso>
        public virtual ListSubscriptionTargetsResponse ListSubscriptionTargets(ListSubscriptionTargetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSubscriptionTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSubscriptionTargetsResponseUnmarshaller.Instance;

            return Invoke<ListSubscriptionTargetsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSubscriptionTargets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptionTargets operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSubscriptionTargets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListSubscriptionTargets">REST API Reference for ListSubscriptionTargets Operation</seealso>
        public virtual IAsyncResult BeginListSubscriptionTargets(ListSubscriptionTargetsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSubscriptionTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSubscriptionTargetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSubscriptionTargets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSubscriptionTargets.</param>
        /// 
        /// <returns>Returns a  ListSubscriptionTargetsResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListSubscriptionTargets">REST API Reference for ListSubscriptionTargets Operation</seealso>
        public virtual ListSubscriptionTargetsResponse EndListSubscriptionTargets(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSubscriptionTargetsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Lists tags for the specified resource in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTimeSeriesDataPoints

        /// <summary>
        /// Lists time series data points.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTimeSeriesDataPoints service method.</param>
        /// 
        /// <returns>The response from the ListTimeSeriesDataPoints service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListTimeSeriesDataPoints">REST API Reference for ListTimeSeriesDataPoints Operation</seealso>
        public virtual ListTimeSeriesDataPointsResponse ListTimeSeriesDataPoints(ListTimeSeriesDataPointsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTimeSeriesDataPointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTimeSeriesDataPointsResponseUnmarshaller.Instance;

            return Invoke<ListTimeSeriesDataPointsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTimeSeriesDataPoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTimeSeriesDataPoints operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTimeSeriesDataPoints
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListTimeSeriesDataPoints">REST API Reference for ListTimeSeriesDataPoints Operation</seealso>
        public virtual IAsyncResult BeginListTimeSeriesDataPoints(ListTimeSeriesDataPointsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTimeSeriesDataPointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTimeSeriesDataPointsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTimeSeriesDataPoints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTimeSeriesDataPoints.</param>
        /// 
        /// <returns>Returns a  ListTimeSeriesDataPointsResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListTimeSeriesDataPoints">REST API Reference for ListTimeSeriesDataPoints Operation</seealso>
        public virtual ListTimeSeriesDataPointsResponse EndListTimeSeriesDataPoints(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTimeSeriesDataPointsResponse>(asyncResult);
        }

        #endregion
        
        #region  PostLineageEvent

        /// <summary>
        /// Posts a data lineage event.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PostLineageEvent service method.</param>
        /// 
        /// <returns>The response from the PostLineageEvent service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/PostLineageEvent">REST API Reference for PostLineageEvent Operation</seealso>
        public virtual PostLineageEventResponse PostLineageEvent(PostLineageEventRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PostLineageEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PostLineageEventResponseUnmarshaller.Instance;

            return Invoke<PostLineageEventResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PostLineageEvent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PostLineageEvent operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPostLineageEvent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/PostLineageEvent">REST API Reference for PostLineageEvent Operation</seealso>
        public virtual IAsyncResult BeginPostLineageEvent(PostLineageEventRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PostLineageEventRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PostLineageEventResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PostLineageEvent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPostLineageEvent.</param>
        /// 
        /// <returns>Returns a  PostLineageEventResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/PostLineageEvent">REST API Reference for PostLineageEvent Operation</seealso>
        public virtual PostLineageEventResponse EndPostLineageEvent(IAsyncResult asyncResult)
        {
            return EndInvoke<PostLineageEventResponse>(asyncResult);
        }

        #endregion
        
        #region  PostTimeSeriesDataPoints

        /// <summary>
        /// Posts time series data points to Amazon DataZone for the specified asset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PostTimeSeriesDataPoints service method.</param>
        /// 
        /// <returns>The response from the PostTimeSeriesDataPoints service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/PostTimeSeriesDataPoints">REST API Reference for PostTimeSeriesDataPoints Operation</seealso>
        public virtual PostTimeSeriesDataPointsResponse PostTimeSeriesDataPoints(PostTimeSeriesDataPointsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PostTimeSeriesDataPointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PostTimeSeriesDataPointsResponseUnmarshaller.Instance;

            return Invoke<PostTimeSeriesDataPointsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PostTimeSeriesDataPoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PostTimeSeriesDataPoints operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPostTimeSeriesDataPoints
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/PostTimeSeriesDataPoints">REST API Reference for PostTimeSeriesDataPoints Operation</seealso>
        public virtual IAsyncResult BeginPostTimeSeriesDataPoints(PostTimeSeriesDataPointsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PostTimeSeriesDataPointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PostTimeSeriesDataPointsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PostTimeSeriesDataPoints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPostTimeSeriesDataPoints.</param>
        /// 
        /// <returns>Returns a  PostTimeSeriesDataPointsResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/PostTimeSeriesDataPoints">REST API Reference for PostTimeSeriesDataPoints Operation</seealso>
        public virtual PostTimeSeriesDataPointsResponse EndPostTimeSeriesDataPoints(IAsyncResult asyncResult)
        {
            return EndInvoke<PostTimeSeriesDataPointsResponse>(asyncResult);
        }

        #endregion
        
        #region  PutDataExportConfiguration

        /// <summary>
        /// Creates data export configuration details.
        /// 
        ///  
        /// <para>
        /// In the current release, you can enable exporting asset metadata only for one domain
        /// per Amazon Web Services account per region. If you disable exporting asset metadata
        /// feature for a domain where it's already enabled, you cannot enable this feature for
        /// another domain in the same Amazon Web Services account and region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDataExportConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutDataExportConfiguration service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/PutDataExportConfiguration">REST API Reference for PutDataExportConfiguration Operation</seealso>
        public virtual PutDataExportConfigurationResponse PutDataExportConfiguration(PutDataExportConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutDataExportConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDataExportConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutDataExportConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutDataExportConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutDataExportConfiguration operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutDataExportConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/PutDataExportConfiguration">REST API Reference for PutDataExportConfiguration Operation</seealso>
        public virtual IAsyncResult BeginPutDataExportConfiguration(PutDataExportConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutDataExportConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDataExportConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutDataExportConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutDataExportConfiguration.</param>
        /// 
        /// <returns>Returns a  PutDataExportConfigurationResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/PutDataExportConfiguration">REST API Reference for PutDataExportConfiguration Operation</seealso>
        public virtual PutDataExportConfigurationResponse EndPutDataExportConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<PutDataExportConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  PutEnvironmentBlueprintConfiguration

        /// <summary>
        /// Writes the configuration for the specified environment blueprint in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEnvironmentBlueprintConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutEnvironmentBlueprintConfiguration service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/PutEnvironmentBlueprintConfiguration">REST API Reference for PutEnvironmentBlueprintConfiguration Operation</seealso>
        public virtual PutEnvironmentBlueprintConfigurationResponse PutEnvironmentBlueprintConfiguration(PutEnvironmentBlueprintConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutEnvironmentBlueprintConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEnvironmentBlueprintConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutEnvironmentBlueprintConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutEnvironmentBlueprintConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutEnvironmentBlueprintConfiguration operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutEnvironmentBlueprintConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/PutEnvironmentBlueprintConfiguration">REST API Reference for PutEnvironmentBlueprintConfiguration Operation</seealso>
        public virtual IAsyncResult BeginPutEnvironmentBlueprintConfiguration(PutEnvironmentBlueprintConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutEnvironmentBlueprintConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEnvironmentBlueprintConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutEnvironmentBlueprintConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutEnvironmentBlueprintConfiguration.</param>
        /// 
        /// <returns>Returns a  PutEnvironmentBlueprintConfigurationResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/PutEnvironmentBlueprintConfiguration">REST API Reference for PutEnvironmentBlueprintConfiguration Operation</seealso>
        public virtual PutEnvironmentBlueprintConfigurationResponse EndPutEnvironmentBlueprintConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<PutEnvironmentBlueprintConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  RejectPredictions

        /// <summary>
        /// Rejects automatically generated business-friendly metadata for your Amazon DataZone
        /// assets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectPredictions service method.</param>
        /// 
        /// <returns>The response from the RejectPredictions service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/RejectPredictions">REST API Reference for RejectPredictions Operation</seealso>
        public virtual RejectPredictionsResponse RejectPredictions(RejectPredictionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RejectPredictionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectPredictionsResponseUnmarshaller.Instance;

            return Invoke<RejectPredictionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RejectPredictions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RejectPredictions operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRejectPredictions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/RejectPredictions">REST API Reference for RejectPredictions Operation</seealso>
        public virtual IAsyncResult BeginRejectPredictions(RejectPredictionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RejectPredictionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectPredictionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RejectPredictions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRejectPredictions.</param>
        /// 
        /// <returns>Returns a  RejectPredictionsResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/RejectPredictions">REST API Reference for RejectPredictions Operation</seealso>
        public virtual RejectPredictionsResponse EndRejectPredictions(IAsyncResult asyncResult)
        {
            return EndInvoke<RejectPredictionsResponse>(asyncResult);
        }

        #endregion
        
        #region  RejectSubscriptionRequest

        /// <summary>
        /// Rejects the specified subscription request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectSubscriptionRequest service method.</param>
        /// 
        /// <returns>The response from the RejectSubscriptionRequest service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/RejectSubscriptionRequest">REST API Reference for RejectSubscriptionRequest Operation</seealso>
        public virtual RejectSubscriptionRequestResponse RejectSubscriptionRequest(RejectSubscriptionRequestRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RejectSubscriptionRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectSubscriptionRequestResponseUnmarshaller.Instance;

            return Invoke<RejectSubscriptionRequestResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RejectSubscriptionRequest operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RejectSubscriptionRequest operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRejectSubscriptionRequest
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/RejectSubscriptionRequest">REST API Reference for RejectSubscriptionRequest Operation</seealso>
        public virtual IAsyncResult BeginRejectSubscriptionRequest(RejectSubscriptionRequestRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RejectSubscriptionRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectSubscriptionRequestResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RejectSubscriptionRequest operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRejectSubscriptionRequest.</param>
        /// 
        /// <returns>Returns a  RejectSubscriptionRequestResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/RejectSubscriptionRequest">REST API Reference for RejectSubscriptionRequest Operation</seealso>
        public virtual RejectSubscriptionRequestResponse EndRejectSubscriptionRequest(IAsyncResult asyncResult)
        {
            return EndInvoke<RejectSubscriptionRequestResponse>(asyncResult);
        }

        #endregion
        
        #region  RemoveEntityOwner

        /// <summary>
        /// Removes an owner from an entity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveEntityOwner service method.</param>
        /// 
        /// <returns>The response from the RemoveEntityOwner service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/RemoveEntityOwner">REST API Reference for RemoveEntityOwner Operation</seealso>
        public virtual RemoveEntityOwnerResponse RemoveEntityOwner(RemoveEntityOwnerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveEntityOwnerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveEntityOwnerResponseUnmarshaller.Instance;

            return Invoke<RemoveEntityOwnerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveEntityOwner operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveEntityOwner operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveEntityOwner
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/RemoveEntityOwner">REST API Reference for RemoveEntityOwner Operation</seealso>
        public virtual IAsyncResult BeginRemoveEntityOwner(RemoveEntityOwnerRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveEntityOwnerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveEntityOwnerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveEntityOwner operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveEntityOwner.</param>
        /// 
        /// <returns>Returns a  RemoveEntityOwnerResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/RemoveEntityOwner">REST API Reference for RemoveEntityOwner Operation</seealso>
        public virtual RemoveEntityOwnerResponse EndRemoveEntityOwner(IAsyncResult asyncResult)
        {
            return EndInvoke<RemoveEntityOwnerResponse>(asyncResult);
        }

        #endregion
        
        #region  RemovePolicyGrant

        /// <summary>
        /// Removes a policy grant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemovePolicyGrant service method.</param>
        /// 
        /// <returns>The response from the RemovePolicyGrant service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/RemovePolicyGrant">REST API Reference for RemovePolicyGrant Operation</seealso>
        public virtual RemovePolicyGrantResponse RemovePolicyGrant(RemovePolicyGrantRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemovePolicyGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemovePolicyGrantResponseUnmarshaller.Instance;

            return Invoke<RemovePolicyGrantResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemovePolicyGrant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemovePolicyGrant operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemovePolicyGrant
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/RemovePolicyGrant">REST API Reference for RemovePolicyGrant Operation</seealso>
        public virtual IAsyncResult BeginRemovePolicyGrant(RemovePolicyGrantRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemovePolicyGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemovePolicyGrantResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemovePolicyGrant operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemovePolicyGrant.</param>
        /// 
        /// <returns>Returns a  RemovePolicyGrantResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/RemovePolicyGrant">REST API Reference for RemovePolicyGrant Operation</seealso>
        public virtual RemovePolicyGrantResponse EndRemovePolicyGrant(IAsyncResult asyncResult)
        {
            return EndInvoke<RemovePolicyGrantResponse>(asyncResult);
        }

        #endregion
        
        #region  RevokeSubscription

        /// <summary>
        /// Revokes a specified subscription in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeSubscription service method.</param>
        /// 
        /// <returns>The response from the RevokeSubscription service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/RevokeSubscription">REST API Reference for RevokeSubscription Operation</seealso>
        public virtual RevokeSubscriptionResponse RevokeSubscription(RevokeSubscriptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RevokeSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeSubscriptionResponseUnmarshaller.Instance;

            return Invoke<RevokeSubscriptionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RevokeSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeSubscription operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRevokeSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/RevokeSubscription">REST API Reference for RevokeSubscription Operation</seealso>
        public virtual IAsyncResult BeginRevokeSubscription(RevokeSubscriptionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RevokeSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeSubscriptionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RevokeSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRevokeSubscription.</param>
        /// 
        /// <returns>Returns a  RevokeSubscriptionResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/RevokeSubscription">REST API Reference for RevokeSubscription Operation</seealso>
        public virtual RevokeSubscriptionResponse EndRevokeSubscription(IAsyncResult asyncResult)
        {
            return EndInvoke<RevokeSubscriptionResponse>(asyncResult);
        }

        #endregion
        
        #region  Search

        /// <summary>
        /// Searches for assets in Amazon DataZone.
        /// 
        ///  
        /// <para>
        /// Search in Amazon DataZone is a powerful capability that enables users to discover
        /// and explore data assets, glossary terms, and data products across their organization.
        /// It provides both basic and advanced search functionality, allowing users to find resources
        /// based on names, descriptions, metadata, and other attributes. Search can be scoped
        /// to specific types of resources (like assets, glossary terms, or data products) and
        /// can be filtered using various criteria such as creation date, owner, or status. The
        /// search functionality is essential for making the wealth of data resources in an organization
        /// discoverable and usable, helping users find the right data for their needs quickly
        /// and efficiently.
        /// </para>
        ///  
        /// <para>
        /// Many search commands in Amazon DataZone are paginated, including <c>search</c> and
        /// <c>search-types</c>. When the result set is large, Amazon DataZone returns a <c>nextToken</c>
        /// in the response. This token can be used to retrieve the next page of results. 
        /// </para>
        ///  
        /// <para>
        /// Prerequisites:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The --domain-identifier must refer to an existing Amazon DataZone domain. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// --search-scope must be one of: ASSET, GLOSSARY_TERM, DATA_PRODUCT, or GLOSSARY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The user must have search permissions in the specified domain.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If using --filters, ensure that the JSON is well-formed and that each filter includes
        /// valid attribute and value keys. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For paginated results, be prepared to use --next-token to fetch additional pages.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To run a standard free-text search, the <c>searchText</c> parameter must be supplied.
        /// By default, all searchable fields are indexed for semantic search and will return
        /// semantic matches for SearchListings queries. To prevent semantic search indexing for
        /// a custom form attribute, see the <a href="https://docs.aws.amazon.com/datazone/latest/APIReference/API_CreateFormType.html">CreateFormType
        /// API documentation</a>. To run a lexical search query, enclose the query with double
        /// quotes (""). This will disable semantic search even for fields that have semantic
        /// search enabled and will only return results that contain the keywords wrapped by double
        /// quotes (order of tokens in the query is not enforced). Free-text search is supported
        /// for all attributes annotated with @amazon.datazone#searchable.
        /// </para>
        ///  
        /// <para>
        /// To run a filtered search, provide filter clause using the <c>filters</c> parameter.
        /// To filter on glossary terms, use the special attribute <c>__DataZoneGlossaryTerms</c>.
        /// To filter on an indexed numeric attribute (i.e., a numeric attribute annotated with
        /// <c>@amazon.datazone#sortable</c>), provide a filter using the <c>intValue</c> parameter.
        /// The filters parameter can also be used to run more advanced free-text searches that
        /// target specific attributes (attributes must be annotated with <c>@amazon.datazone#searchable</c>
        /// for free-text search). Create/update timestamp filtering is supported using the special
        /// <c>creationTime</c>/<c>lastUpdatedTime</c> attributes. Filter types can be mixed and
        /// matched to power complex queries.
        /// </para>
        ///  
        /// <para>
        ///  To find out whether an attribute has been annotated and indexed for a given search
        /// type, use the GetFormType API to retrieve the form containing the attribute.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Search service method.</param>
        /// 
        /// <returns>The response from the Search service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/Search">REST API Reference for Search Operation</seealso>
        public virtual SearchResponse Search(SearchRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchResponseUnmarshaller.Instance;

            return Invoke<SearchResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the Search operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Search operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearch
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/Search">REST API Reference for Search Operation</seealso>
        public virtual IAsyncResult BeginSearch(SearchRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  Search operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearch.</param>
        /// 
        /// <returns>Returns a  SearchResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/Search">REST API Reference for Search Operation</seealso>
        public virtual SearchResponse EndSearch(IAsyncResult asyncResult)
        {
            return EndInvoke<SearchResponse>(asyncResult);
        }

        #endregion
        
        #region  SearchGroupProfiles

        /// <summary>
        /// Searches group profiles in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchGroupProfiles service method.</param>
        /// 
        /// <returns>The response from the SearchGroupProfiles service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/SearchGroupProfiles">REST API Reference for SearchGroupProfiles Operation</seealso>
        public virtual SearchGroupProfilesResponse SearchGroupProfiles(SearchGroupProfilesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchGroupProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchGroupProfilesResponseUnmarshaller.Instance;

            return Invoke<SearchGroupProfilesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SearchGroupProfiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchGroupProfiles operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchGroupProfiles
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/SearchGroupProfiles">REST API Reference for SearchGroupProfiles Operation</seealso>
        public virtual IAsyncResult BeginSearchGroupProfiles(SearchGroupProfilesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchGroupProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchGroupProfilesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SearchGroupProfiles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchGroupProfiles.</param>
        /// 
        /// <returns>Returns a  SearchGroupProfilesResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/SearchGroupProfiles">REST API Reference for SearchGroupProfiles Operation</seealso>
        public virtual SearchGroupProfilesResponse EndSearchGroupProfiles(IAsyncResult asyncResult)
        {
            return EndInvoke<SearchGroupProfilesResponse>(asyncResult);
        }

        #endregion
        
        #region  SearchListings

        /// <summary>
        /// Searches listings in Amazon DataZone.
        /// 
        ///  
        /// <para>
        /// SearchListings is a powerful capability that enables users to discover and explore
        /// published assets and data products across their organization. It provides both basic
        /// and advanced search functionality, allowing users to find resources based on names,
        /// descriptions, metadata, and other attributes. SearchListings also supports filtering
        /// using various criteria such as creation date, owner, or status. This API is essential
        /// for making the wealth of data resources in an organization discoverable and usable,
        /// helping users find the right data for their needs quickly and efficiently.
        /// </para>
        ///  
        /// <para>
        /// SearchListings returns results in a paginated format. When the result set is large,
        /// the response will include a nextToken, which can be used to retrieve the next page
        /// of results.
        /// </para>
        ///  
        /// <para>
        /// The SearchListings API gives users flexibility in specifying what kind of search is
        /// run.
        /// </para>
        ///  
        /// <para>
        /// To run a standard free-text search, the <c>searchText</c> parameter must be supplied.
        /// By default, all searchable fields are indexed for semantic search and will return
        /// semantic matches for SearchListings queries. To prevent semantic search indexing for
        /// a custom form attribute, see the <a href="https://docs.aws.amazon.com/datazone/latest/APIReference/API_CreateFormType.html">CreateFormType
        /// API documentation</a>. To run a lexical search query, enclose the query with double
        /// quotes (""). This will disable semantic search even for fields that have semantic
        /// search enabled and will only return results that contain the keywords wrapped by double
        /// quotes (order of tokens in the query is not enforced). Free-text search is supported
        /// for all attributes annotated with @amazon.datazone#searchable.
        /// </para>
        ///  
        /// <para>
        /// To run a filtered search, provide filter clause using the <c>filters</c> parameter.
        /// To filter on glossary terms, use the special attribute <c>__DataZoneGlossaryTerms</c>.
        /// To filter on an indexed numeric attribute (i.e., a numeric attribute annotated with
        /// <c>@amazon.datazone#sortable</c>), provide a filter using the <c>intValue</c> parameter.
        /// The filters parameter can also be used to run more advanced free-text searches that
        /// target specific attributes (attributes must be annotated with <c>@amazon.datazone#searchable</c>
        /// for free-text search). Create/update timestamp filtering is supported using the special
        /// <c>creationTime</c>/<c>lastUpdatedTime</c> attributes. Filter types can be mixed and
        /// matched to power complex queries.
        /// </para>
        ///  
        /// <para>
        ///  To find out whether an attribute has been annotated and indexed for a given search
        /// type, use the GetFormType API to retrieve the form containing the attribute.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchListings service method.</param>
        /// 
        /// <returns>The response from the SearchListings service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/SearchListings">REST API Reference for SearchListings Operation</seealso>
        public virtual SearchListingsResponse SearchListings(SearchListingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchListingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchListingsResponseUnmarshaller.Instance;

            return Invoke<SearchListingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SearchListings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchListings operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchListings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/SearchListings">REST API Reference for SearchListings Operation</seealso>
        public virtual IAsyncResult BeginSearchListings(SearchListingsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchListingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchListingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SearchListings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchListings.</param>
        /// 
        /// <returns>Returns a  SearchListingsResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/SearchListings">REST API Reference for SearchListings Operation</seealso>
        public virtual SearchListingsResponse EndSearchListings(IAsyncResult asyncResult)
        {
            return EndInvoke<SearchListingsResponse>(asyncResult);
        }

        #endregion
        
        #region  SearchTypes

        /// <summary>
        /// Searches for types in Amazon DataZone.
        /// 
        ///  
        /// <para>
        /// Prerequisites:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The --domain-identifier must refer to an existing Amazon DataZone domain. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// --search-scope must be one of the valid values including: ASSET_TYPE, GLOSSARY_TERM_TYPE,
        /// DATA_PRODUCT_TYPE.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The --managed flag must be present without a value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The user must have permissions for form or asset types in the domain.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If using --filters, ensure that the JSON is valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Filters contain correct structure (attribute, value, operator).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchTypes service method.</param>
        /// 
        /// <returns>The response from the SearchTypes service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/SearchTypes">REST API Reference for SearchTypes Operation</seealso>
        public virtual SearchTypesResponse SearchTypes(SearchTypesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchTypesResponseUnmarshaller.Instance;

            return Invoke<SearchTypesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SearchTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchTypes operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchTypes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/SearchTypes">REST API Reference for SearchTypes Operation</seealso>
        public virtual IAsyncResult BeginSearchTypes(SearchTypesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchTypesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SearchTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchTypes.</param>
        /// 
        /// <returns>Returns a  SearchTypesResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/SearchTypes">REST API Reference for SearchTypes Operation</seealso>
        public virtual SearchTypesResponse EndSearchTypes(IAsyncResult asyncResult)
        {
            return EndInvoke<SearchTypesResponse>(asyncResult);
        }

        #endregion
        
        #region  SearchUserProfiles

        /// <summary>
        /// Searches user profiles in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchUserProfiles service method.</param>
        /// 
        /// <returns>The response from the SearchUserProfiles service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/SearchUserProfiles">REST API Reference for SearchUserProfiles Operation</seealso>
        public virtual SearchUserProfilesResponse SearchUserProfiles(SearchUserProfilesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchUserProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchUserProfilesResponseUnmarshaller.Instance;

            return Invoke<SearchUserProfilesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SearchUserProfiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchUserProfiles operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchUserProfiles
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/SearchUserProfiles">REST API Reference for SearchUserProfiles Operation</seealso>
        public virtual IAsyncResult BeginSearchUserProfiles(SearchUserProfilesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchUserProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchUserProfilesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SearchUserProfiles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchUserProfiles.</param>
        /// 
        /// <returns>Returns a  SearchUserProfilesResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/SearchUserProfiles">REST API Reference for SearchUserProfiles Operation</seealso>
        public virtual SearchUserProfilesResponse EndSearchUserProfiles(IAsyncResult asyncResult)
        {
            return EndInvoke<SearchUserProfilesResponse>(asyncResult);
        }

        #endregion
        
        #region  StartDataSourceRun

        /// <summary>
        /// Start the run of the specified data source in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDataSourceRun service method.</param>
        /// 
        /// <returns>The response from the StartDataSourceRun service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/StartDataSourceRun">REST API Reference for StartDataSourceRun Operation</seealso>
        public virtual StartDataSourceRunResponse StartDataSourceRun(StartDataSourceRunRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartDataSourceRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDataSourceRunResponseUnmarshaller.Instance;

            return Invoke<StartDataSourceRunResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartDataSourceRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartDataSourceRun operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartDataSourceRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/StartDataSourceRun">REST API Reference for StartDataSourceRun Operation</seealso>
        public virtual IAsyncResult BeginStartDataSourceRun(StartDataSourceRunRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartDataSourceRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDataSourceRunResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartDataSourceRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartDataSourceRun.</param>
        /// 
        /// <returns>Returns a  StartDataSourceRunResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/StartDataSourceRun">REST API Reference for StartDataSourceRun Operation</seealso>
        public virtual StartDataSourceRunResponse EndStartDataSourceRun(IAsyncResult asyncResult)
        {
            return EndInvoke<StartDataSourceRunResponse>(asyncResult);
        }

        #endregion
        
        #region  StartMetadataGenerationRun

        /// <summary>
        /// Starts the metadata generation run.
        /// 
        ///  
        /// <para>
        /// Prerequisites:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Asset must be created and belong to the specified domain and project. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Asset type must be supported for metadata generation (e.g., Amazon Web Services Glue
        /// table).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Asset must have a structured schema with valid rows and columns.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Valid values for --type: BUSINESS_DESCRIPTIONS, BUSINESS_NAMES, BUSINESS_GLOSSARY_ASSOCIATIONS.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The user must have permission to run metadata generation in the domain/project.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMetadataGenerationRun service method.</param>
        /// 
        /// <returns>The response from the StartMetadataGenerationRun service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/StartMetadataGenerationRun">REST API Reference for StartMetadataGenerationRun Operation</seealso>
        public virtual StartMetadataGenerationRunResponse StartMetadataGenerationRun(StartMetadataGenerationRunRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartMetadataGenerationRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMetadataGenerationRunResponseUnmarshaller.Instance;

            return Invoke<StartMetadataGenerationRunResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartMetadataGenerationRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartMetadataGenerationRun operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartMetadataGenerationRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/StartMetadataGenerationRun">REST API Reference for StartMetadataGenerationRun Operation</seealso>
        public virtual IAsyncResult BeginStartMetadataGenerationRun(StartMetadataGenerationRunRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartMetadataGenerationRunRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMetadataGenerationRunResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartMetadataGenerationRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartMetadataGenerationRun.</param>
        /// 
        /// <returns>Returns a  StartMetadataGenerationRunResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/StartMetadataGenerationRun">REST API Reference for StartMetadataGenerationRun Operation</seealso>
        public virtual StartMetadataGenerationRunResponse EndStartMetadataGenerationRun(IAsyncResult asyncResult)
        {
            return EndInvoke<StartMetadataGenerationRunResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Tags a resource in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Untags a resource in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAccountPool

        /// <summary>
        /// Updates the account pool.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountPool service method.</param>
        /// 
        /// <returns>The response from the UpdateAccountPool service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateAccountPool">REST API Reference for UpdateAccountPool Operation</seealso>
        public virtual UpdateAccountPoolResponse UpdateAccountPool(UpdateAccountPoolRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAccountPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccountPoolResponseUnmarshaller.Instance;

            return Invoke<UpdateAccountPoolResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAccountPool operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountPool operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAccountPool
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateAccountPool">REST API Reference for UpdateAccountPool Operation</seealso>
        public virtual IAsyncResult BeginUpdateAccountPool(UpdateAccountPoolRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAccountPoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccountPoolResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAccountPool operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAccountPool.</param>
        /// 
        /// <returns>Returns a  UpdateAccountPoolResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateAccountPool">REST API Reference for UpdateAccountPool Operation</seealso>
        public virtual UpdateAccountPoolResponse EndUpdateAccountPool(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAccountPoolResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAssetFilter

        /// <summary>
        /// Updates an asset filter.
        /// 
        ///  
        /// <para>
        /// Prerequisites:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The domain, asset, and asset filter identifier must all exist. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The asset must contain the columns being referenced in the update.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If applying a row filter, ensure the column referenced in the expression exists in
        /// the asset schema.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssetFilter service method.</param>
        /// 
        /// <returns>The response from the UpdateAssetFilter service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateAssetFilter">REST API Reference for UpdateAssetFilter Operation</seealso>
        public virtual UpdateAssetFilterResponse UpdateAssetFilter(UpdateAssetFilterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAssetFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssetFilterResponseUnmarshaller.Instance;

            return Invoke<UpdateAssetFilterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAssetFilter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssetFilter operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAssetFilter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateAssetFilter">REST API Reference for UpdateAssetFilter Operation</seealso>
        public virtual IAsyncResult BeginUpdateAssetFilter(UpdateAssetFilterRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAssetFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAssetFilterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAssetFilter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAssetFilter.</param>
        /// 
        /// <returns>Returns a  UpdateAssetFilterResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateAssetFilter">REST API Reference for UpdateAssetFilter Operation</seealso>
        public virtual UpdateAssetFilterResponse EndUpdateAssetFilter(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAssetFilterResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateConnection

        /// <summary>
        /// Updates a connection. In Amazon DataZone, a connection enables you to connect your
        /// resources (domains, projects, and environments) to external resources and services.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnection service method.</param>
        /// 
        /// <returns>The response from the UpdateConnection service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateConnection">REST API Reference for UpdateConnection Operation</seealso>
        public virtual UpdateConnectionResponse UpdateConnection(UpdateConnectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConnectionResponseUnmarshaller.Instance;

            return Invoke<UpdateConnectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnection operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateConnection">REST API Reference for UpdateConnection Operation</seealso>
        public virtual IAsyncResult BeginUpdateConnection(UpdateConnectionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConnectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateConnection.</param>
        /// 
        /// <returns>Returns a  UpdateConnectionResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateConnection">REST API Reference for UpdateConnection Operation</seealso>
        public virtual UpdateConnectionResponse EndUpdateConnection(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateConnectionResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDataSource

        /// <summary>
        /// Updates the specified data source in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSource service method.</param>
        /// 
        /// <returns>The response from the UpdateDataSource service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateDataSource">REST API Reference for UpdateDataSource Operation</seealso>
        public virtual UpdateDataSourceResponse UpdateDataSource(UpdateDataSourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataSourceResponseUnmarshaller.Instance;

            return Invoke<UpdateDataSourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDataSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSource operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDataSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateDataSource">REST API Reference for UpdateDataSource Operation</seealso>
        public virtual IAsyncResult BeginUpdateDataSource(UpdateDataSourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDataSourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDataSourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDataSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDataSource.</param>
        /// 
        /// <returns>Returns a  UpdateDataSourceResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateDataSource">REST API Reference for UpdateDataSource Operation</seealso>
        public virtual UpdateDataSourceResponse EndUpdateDataSource(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDataSourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDomain

        /// <summary>
        /// Updates a Amazon DataZone domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomain service method.</param>
        /// 
        /// <returns>The response from the UpdateDomain service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateDomain">REST API Reference for UpdateDomain Operation</seealso>
        public virtual UpdateDomainResponse UpdateDomain(UpdateDomainRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDomainResponseUnmarshaller.Instance;

            return Invoke<UpdateDomainResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomain operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateDomain">REST API Reference for UpdateDomain Operation</seealso>
        public virtual IAsyncResult BeginUpdateDomain(UpdateDomainRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDomainResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDomain.</param>
        /// 
        /// <returns>Returns a  UpdateDomainResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateDomain">REST API Reference for UpdateDomain Operation</seealso>
        public virtual UpdateDomainResponse EndUpdateDomain(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDomainResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDomainUnit

        /// <summary>
        /// Updates the domain unit.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainUnit service method.</param>
        /// 
        /// <returns>The response from the UpdateDomainUnit service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateDomainUnit">REST API Reference for UpdateDomainUnit Operation</seealso>
        public virtual UpdateDomainUnitResponse UpdateDomainUnit(UpdateDomainUnitRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDomainUnitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDomainUnitResponseUnmarshaller.Instance;

            return Invoke<UpdateDomainUnitResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDomainUnit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainUnit operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDomainUnit
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateDomainUnit">REST API Reference for UpdateDomainUnit Operation</seealso>
        public virtual IAsyncResult BeginUpdateDomainUnit(UpdateDomainUnitRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateDomainUnitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDomainUnitResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDomainUnit operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDomainUnit.</param>
        /// 
        /// <returns>Returns a  UpdateDomainUnitResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateDomainUnit">REST API Reference for UpdateDomainUnit Operation</seealso>
        public virtual UpdateDomainUnitResponse EndUpdateDomainUnit(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDomainUnitResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateEnvironment

        /// <summary>
        /// Updates the specified environment in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironment service method.</param>
        /// 
        /// <returns>The response from the UpdateEnvironment service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateEnvironment">REST API Reference for UpdateEnvironment Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironment operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateEnvironment">REST API Reference for UpdateEnvironment Operation</seealso>
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
        /// <returns>Returns a  UpdateEnvironmentResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateEnvironment">REST API Reference for UpdateEnvironment Operation</seealso>
        public virtual UpdateEnvironmentResponse EndUpdateEnvironment(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateEnvironmentResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateEnvironmentAction

        /// <summary>
        /// Updates an environment action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironmentAction service method.</param>
        /// 
        /// <returns>The response from the UpdateEnvironmentAction service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateEnvironmentAction">REST API Reference for UpdateEnvironmentAction Operation</seealso>
        public virtual UpdateEnvironmentActionResponse UpdateEnvironmentAction(UpdateEnvironmentActionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEnvironmentActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnvironmentActionResponseUnmarshaller.Instance;

            return Invoke<UpdateEnvironmentActionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEnvironmentAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironmentAction operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEnvironmentAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateEnvironmentAction">REST API Reference for UpdateEnvironmentAction Operation</seealso>
        public virtual IAsyncResult BeginUpdateEnvironmentAction(UpdateEnvironmentActionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEnvironmentActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnvironmentActionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEnvironmentAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEnvironmentAction.</param>
        /// 
        /// <returns>Returns a  UpdateEnvironmentActionResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateEnvironmentAction">REST API Reference for UpdateEnvironmentAction Operation</seealso>
        public virtual UpdateEnvironmentActionResponse EndUpdateEnvironmentAction(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateEnvironmentActionResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateEnvironmentBlueprint

        /// <summary>
        /// Updates an environment blueprint in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironmentBlueprint service method.</param>
        /// 
        /// <returns>The response from the UpdateEnvironmentBlueprint service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateEnvironmentBlueprint">REST API Reference for UpdateEnvironmentBlueprint Operation</seealso>
        public virtual UpdateEnvironmentBlueprintResponse UpdateEnvironmentBlueprint(UpdateEnvironmentBlueprintRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEnvironmentBlueprintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnvironmentBlueprintResponseUnmarshaller.Instance;

            return Invoke<UpdateEnvironmentBlueprintResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEnvironmentBlueprint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironmentBlueprint operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEnvironmentBlueprint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateEnvironmentBlueprint">REST API Reference for UpdateEnvironmentBlueprint Operation</seealso>
        public virtual IAsyncResult BeginUpdateEnvironmentBlueprint(UpdateEnvironmentBlueprintRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEnvironmentBlueprintRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnvironmentBlueprintResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEnvironmentBlueprint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEnvironmentBlueprint.</param>
        /// 
        /// <returns>Returns a  UpdateEnvironmentBlueprintResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateEnvironmentBlueprint">REST API Reference for UpdateEnvironmentBlueprint Operation</seealso>
        public virtual UpdateEnvironmentBlueprintResponse EndUpdateEnvironmentBlueprint(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateEnvironmentBlueprintResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateEnvironmentProfile

        /// <summary>
        /// Updates the specified environment profile in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironmentProfile service method.</param>
        /// 
        /// <returns>The response from the UpdateEnvironmentProfile service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateEnvironmentProfile">REST API Reference for UpdateEnvironmentProfile Operation</seealso>
        public virtual UpdateEnvironmentProfileResponse UpdateEnvironmentProfile(UpdateEnvironmentProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEnvironmentProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnvironmentProfileResponseUnmarshaller.Instance;

            return Invoke<UpdateEnvironmentProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEnvironmentProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironmentProfile operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEnvironmentProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateEnvironmentProfile">REST API Reference for UpdateEnvironmentProfile Operation</seealso>
        public virtual IAsyncResult BeginUpdateEnvironmentProfile(UpdateEnvironmentProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEnvironmentProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnvironmentProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEnvironmentProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEnvironmentProfile.</param>
        /// 
        /// <returns>Returns a  UpdateEnvironmentProfileResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateEnvironmentProfile">REST API Reference for UpdateEnvironmentProfile Operation</seealso>
        public virtual UpdateEnvironmentProfileResponse EndUpdateEnvironmentProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateEnvironmentProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateGlossary

        /// <summary>
        /// Updates the business glossary in Amazon DataZone.
        /// 
        ///  
        /// <para>
        /// Prerequisites:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The glossary must exist in the given domain. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The caller must have the <c>datazone:UpdateGlossary</c> permission to update it.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When updating the name, the new name must be unique within the domain.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The glossary must not be deleted or in a terminal state.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGlossary service method.</param>
        /// 
        /// <returns>The response from the UpdateGlossary service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateGlossary">REST API Reference for UpdateGlossary Operation</seealso>
        public virtual UpdateGlossaryResponse UpdateGlossary(UpdateGlossaryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGlossaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGlossaryResponseUnmarshaller.Instance;

            return Invoke<UpdateGlossaryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGlossary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGlossary operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGlossary
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateGlossary">REST API Reference for UpdateGlossary Operation</seealso>
        public virtual IAsyncResult BeginUpdateGlossary(UpdateGlossaryRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGlossaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGlossaryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGlossary operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGlossary.</param>
        /// 
        /// <returns>Returns a  UpdateGlossaryResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateGlossary">REST API Reference for UpdateGlossary Operation</seealso>
        public virtual UpdateGlossaryResponse EndUpdateGlossary(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateGlossaryResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateGlossaryTerm

        /// <summary>
        /// Updates a business glossary term in Amazon DataZone.
        /// 
        ///  
        /// <para>
        /// Prerequisites:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Glossary term must exist in the specified domain. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// New name must not conflict with existing terms in the same glossary.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// User must have permissions on the term.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The term must not be in DELETED status.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGlossaryTerm service method.</param>
        /// 
        /// <returns>The response from the UpdateGlossaryTerm service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateGlossaryTerm">REST API Reference for UpdateGlossaryTerm Operation</seealso>
        public virtual UpdateGlossaryTermResponse UpdateGlossaryTerm(UpdateGlossaryTermRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGlossaryTermRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGlossaryTermResponseUnmarshaller.Instance;

            return Invoke<UpdateGlossaryTermResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGlossaryTerm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGlossaryTerm operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGlossaryTerm
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateGlossaryTerm">REST API Reference for UpdateGlossaryTerm Operation</seealso>
        public virtual IAsyncResult BeginUpdateGlossaryTerm(UpdateGlossaryTermRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGlossaryTermRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGlossaryTermResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGlossaryTerm operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGlossaryTerm.</param>
        /// 
        /// <returns>Returns a  UpdateGlossaryTermResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateGlossaryTerm">REST API Reference for UpdateGlossaryTerm Operation</seealso>
        public virtual UpdateGlossaryTermResponse EndUpdateGlossaryTerm(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateGlossaryTermResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateGroupProfile

        /// <summary>
        /// Updates the specified group profile in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroupProfile service method.</param>
        /// 
        /// <returns>The response from the UpdateGroupProfile service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateGroupProfile">REST API Reference for UpdateGroupProfile Operation</seealso>
        public virtual UpdateGroupProfileResponse UpdateGroupProfile(UpdateGroupProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGroupProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGroupProfileResponseUnmarshaller.Instance;

            return Invoke<UpdateGroupProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGroupProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroupProfile operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGroupProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateGroupProfile">REST API Reference for UpdateGroupProfile Operation</seealso>
        public virtual IAsyncResult BeginUpdateGroupProfile(UpdateGroupProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGroupProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGroupProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGroupProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGroupProfile.</param>
        /// 
        /// <returns>Returns a  UpdateGroupProfileResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateGroupProfile">REST API Reference for UpdateGroupProfile Operation</seealso>
        public virtual UpdateGroupProfileResponse EndUpdateGroupProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateGroupProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateProject

        /// <summary>
        /// Updates the specified project in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProject service method.</param>
        /// 
        /// <returns>The response from the UpdateProject service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateProject">REST API Reference for UpdateProject Operation</seealso>
        public virtual UpdateProjectResponse UpdateProject(UpdateProjectRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProjectResponseUnmarshaller.Instance;

            return Invoke<UpdateProjectResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateProject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateProject operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateProject
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateProject">REST API Reference for UpdateProject Operation</seealso>
        public virtual IAsyncResult BeginUpdateProject(UpdateProjectRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProjectResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateProject operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateProject.</param>
        /// 
        /// <returns>Returns a  UpdateProjectResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateProject">REST API Reference for UpdateProject Operation</seealso>
        public virtual UpdateProjectResponse EndUpdateProject(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateProjectResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateProjectProfile

        /// <summary>
        /// Updates a project profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProjectProfile service method.</param>
        /// 
        /// <returns>The response from the UpdateProjectProfile service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateProjectProfile">REST API Reference for UpdateProjectProfile Operation</seealso>
        public virtual UpdateProjectProfileResponse UpdateProjectProfile(UpdateProjectProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProjectProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProjectProfileResponseUnmarshaller.Instance;

            return Invoke<UpdateProjectProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateProjectProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateProjectProfile operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateProjectProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateProjectProfile">REST API Reference for UpdateProjectProfile Operation</seealso>
        public virtual IAsyncResult BeginUpdateProjectProfile(UpdateProjectProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProjectProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProjectProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateProjectProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateProjectProfile.</param>
        /// 
        /// <returns>Returns a  UpdateProjectProfileResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateProjectProfile">REST API Reference for UpdateProjectProfile Operation</seealso>
        public virtual UpdateProjectProfileResponse EndUpdateProjectProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateProjectProfileResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateRootDomainUnitOwner

        /// <summary>
        /// Updates the owner of the root domain unit.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRootDomainUnitOwner service method.</param>
        /// 
        /// <returns>The response from the UpdateRootDomainUnitOwner service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateRootDomainUnitOwner">REST API Reference for UpdateRootDomainUnitOwner Operation</seealso>
        public virtual UpdateRootDomainUnitOwnerResponse UpdateRootDomainUnitOwner(UpdateRootDomainUnitOwnerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRootDomainUnitOwnerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRootDomainUnitOwnerResponseUnmarshaller.Instance;

            return Invoke<UpdateRootDomainUnitOwnerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRootDomainUnitOwner operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRootDomainUnitOwner operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRootDomainUnitOwner
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateRootDomainUnitOwner">REST API Reference for UpdateRootDomainUnitOwner Operation</seealso>
        public virtual IAsyncResult BeginUpdateRootDomainUnitOwner(UpdateRootDomainUnitOwnerRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRootDomainUnitOwnerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRootDomainUnitOwnerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRootDomainUnitOwner operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRootDomainUnitOwner.</param>
        /// 
        /// <returns>Returns a  UpdateRootDomainUnitOwnerResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateRootDomainUnitOwner">REST API Reference for UpdateRootDomainUnitOwner Operation</seealso>
        public virtual UpdateRootDomainUnitOwnerResponse EndUpdateRootDomainUnitOwner(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateRootDomainUnitOwnerResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateRule

        /// <summary>
        /// Updates a rule. In Amazon DataZone, a rule is a formal agreement that enforces specific
        /// requirements across user workflows (e.g., publishing assets to the catalog, requesting
        /// subscriptions, creating projects) within the Amazon DataZone data portal. These rules
        /// help maintain consistency, ensure compliance, and uphold governance standards in data
        /// management processes. For instance, a metadata enforcement rule can specify the required
        /// information for creating a subscription request or publishing a data asset to the
        /// catalog, ensuring alignment with organizational standards.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRule service method.</param>
        /// 
        /// <returns>The response from the UpdateRule service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateRule">REST API Reference for UpdateRule Operation</seealso>
        public virtual UpdateRuleResponse UpdateRule(UpdateRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRuleResponseUnmarshaller.Instance;

            return Invoke<UpdateRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRule operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateRule">REST API Reference for UpdateRule Operation</seealso>
        public virtual IAsyncResult BeginUpdateRule(UpdateRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRule.</param>
        /// 
        /// <returns>Returns a  UpdateRuleResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateRule">REST API Reference for UpdateRule Operation</seealso>
        public virtual UpdateRuleResponse EndUpdateRule(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateSubscriptionGrantStatus

        /// <summary>
        /// Updates the status of the specified subscription grant status in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubscriptionGrantStatus service method.</param>
        /// 
        /// <returns>The response from the UpdateSubscriptionGrantStatus service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateSubscriptionGrantStatus">REST API Reference for UpdateSubscriptionGrantStatus Operation</seealso>
        public virtual UpdateSubscriptionGrantStatusResponse UpdateSubscriptionGrantStatus(UpdateSubscriptionGrantStatusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSubscriptionGrantStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSubscriptionGrantStatusResponseUnmarshaller.Instance;

            return Invoke<UpdateSubscriptionGrantStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSubscriptionGrantStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubscriptionGrantStatus operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSubscriptionGrantStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateSubscriptionGrantStatus">REST API Reference for UpdateSubscriptionGrantStatus Operation</seealso>
        public virtual IAsyncResult BeginUpdateSubscriptionGrantStatus(UpdateSubscriptionGrantStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSubscriptionGrantStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSubscriptionGrantStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSubscriptionGrantStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSubscriptionGrantStatus.</param>
        /// 
        /// <returns>Returns a  UpdateSubscriptionGrantStatusResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateSubscriptionGrantStatus">REST API Reference for UpdateSubscriptionGrantStatus Operation</seealso>
        public virtual UpdateSubscriptionGrantStatusResponse EndUpdateSubscriptionGrantStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateSubscriptionGrantStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateSubscriptionRequest

        /// <summary>
        /// Updates a specified subscription request in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubscriptionRequest service method.</param>
        /// 
        /// <returns>The response from the UpdateSubscriptionRequest service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateSubscriptionRequest">REST API Reference for UpdateSubscriptionRequest Operation</seealso>
        public virtual UpdateSubscriptionRequestResponse UpdateSubscriptionRequest(UpdateSubscriptionRequestRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSubscriptionRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSubscriptionRequestResponseUnmarshaller.Instance;

            return Invoke<UpdateSubscriptionRequestResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSubscriptionRequest operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubscriptionRequest operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSubscriptionRequest
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateSubscriptionRequest">REST API Reference for UpdateSubscriptionRequest Operation</seealso>
        public virtual IAsyncResult BeginUpdateSubscriptionRequest(UpdateSubscriptionRequestRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSubscriptionRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSubscriptionRequestResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSubscriptionRequest operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSubscriptionRequest.</param>
        /// 
        /// <returns>Returns a  UpdateSubscriptionRequestResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateSubscriptionRequest">REST API Reference for UpdateSubscriptionRequest Operation</seealso>
        public virtual UpdateSubscriptionRequestResponse EndUpdateSubscriptionRequest(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateSubscriptionRequestResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateSubscriptionTarget

        /// <summary>
        /// Updates the specified subscription target in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubscriptionTarget service method.</param>
        /// 
        /// <returns>The response from the UpdateSubscriptionTarget service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateSubscriptionTarget">REST API Reference for UpdateSubscriptionTarget Operation</seealso>
        public virtual UpdateSubscriptionTargetResponse UpdateSubscriptionTarget(UpdateSubscriptionTargetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSubscriptionTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSubscriptionTargetResponseUnmarshaller.Instance;

            return Invoke<UpdateSubscriptionTargetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSubscriptionTarget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubscriptionTarget operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSubscriptionTarget
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateSubscriptionTarget">REST API Reference for UpdateSubscriptionTarget Operation</seealso>
        public virtual IAsyncResult BeginUpdateSubscriptionTarget(UpdateSubscriptionTargetRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSubscriptionTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSubscriptionTargetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSubscriptionTarget operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSubscriptionTarget.</param>
        /// 
        /// <returns>Returns a  UpdateSubscriptionTargetResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateSubscriptionTarget">REST API Reference for UpdateSubscriptionTarget Operation</seealso>
        public virtual UpdateSubscriptionTargetResponse EndUpdateSubscriptionTarget(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateSubscriptionTargetResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateUserProfile

        /// <summary>
        /// Updates the specified user profile in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserProfile service method.</param>
        /// 
        /// <returns>The response from the UpdateUserProfile service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateUserProfile">REST API Reference for UpdateUserProfile Operation</seealso>
        public virtual UpdateUserProfileResponse UpdateUserProfile(UpdateUserProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateUserProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserProfileResponseUnmarshaller.Instance;

            return Invoke<UpdateUserProfileResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUserProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserProfile operation on AmazonDataZoneClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateUserProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateUserProfile">REST API Reference for UpdateUserProfile Operation</seealso>
        public virtual IAsyncResult BeginUpdateUserProfile(UpdateUserProfileRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateUserProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUserProfileResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateUserProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateUserProfile.</param>
        /// 
        /// <returns>Returns a  UpdateUserProfileResult from DataZone.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateUserProfile">REST API Reference for UpdateUserProfile Operation</seealso>
        public virtual UpdateUserProfileResponse EndUpdateUserProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateUserProfileResponse>(asyncResult);
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
            var resolver = new AmazonDataZoneEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}