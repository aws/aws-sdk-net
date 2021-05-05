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
 * Do not modify this file. This file is generated from the finspace-data-2020-07-13.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.FinSpaceData.Model;
using Amazon.FinSpaceData.Model.Internal.MarshallTransformations;
using Amazon.FinSpaceData.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.FinSpaceData
{
    /// <summary>
    /// Implementation for accessing FinSpaceData
    ///
    /// The FinSpace APIs let you take actions inside the FinSpace environment.
    /// </summary>
    public partial class AmazonFinSpaceDataClient : AmazonServiceClient, IAmazonFinSpaceData
    {
        private static IServiceMetadata serviceMetadata = new AmazonFinSpaceDataMetadata();

        #region Constructors

        /// <summary>
        /// Constructs AmazonFinSpaceDataClient with the credentials loaded from the application's
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
        public AmazonFinSpaceDataClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonFinSpaceDataConfig()) { }

        /// <summary>
        /// Constructs AmazonFinSpaceDataClient with the credentials loaded from the application's
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
        public AmazonFinSpaceDataClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonFinSpaceDataConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonFinSpaceDataClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonFinSpaceDataClient Configuration Object</param>
        public AmazonFinSpaceDataClient(AmazonFinSpaceDataConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonFinSpaceDataClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonFinSpaceDataClient(AWSCredentials credentials)
            : this(credentials, new AmazonFinSpaceDataConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonFinSpaceDataClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonFinSpaceDataClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonFinSpaceDataConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonFinSpaceDataClient with AWS Credentials and an
        /// AmazonFinSpaceDataClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonFinSpaceDataClient Configuration Object</param>
        public AmazonFinSpaceDataClient(AWSCredentials credentials, AmazonFinSpaceDataConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonFinSpaceDataClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonFinSpaceDataClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonFinSpaceDataConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonFinSpaceDataClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonFinSpaceDataClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonFinSpaceDataConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonFinSpaceDataClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonFinSpaceDataClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonFinSpaceDataClient Configuration Object</param>
        public AmazonFinSpaceDataClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonFinSpaceDataConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonFinSpaceDataClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonFinSpaceDataClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonFinSpaceDataConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonFinSpaceDataClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonFinSpaceDataClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonFinSpaceDataConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonFinSpaceDataClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonFinSpaceDataClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonFinSpaceDataClient Configuration Object</param>
        public AmazonFinSpaceDataClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonFinSpaceDataConfig clientConfig)
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


        #region  CreateChangeset

        /// <summary>
        /// Creates a new changeset in a FinSpace dataset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChangeset service method.</param>
        /// 
        /// <returns>The response from the CreateChangeset service method, as returned by FinSpaceData.</returns>
        /// <exception cref="Amazon.FinSpaceData.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ResourceNotFoundException">
        /// One or more resources can't be found.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/CreateChangeset">REST API Reference for CreateChangeset Operation</seealso>
        public virtual CreateChangesetResponse CreateChangeset(CreateChangesetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateChangesetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChangesetResponseUnmarshaller.Instance;

            return Invoke<CreateChangesetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateChangeset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateChangeset operation on AmazonFinSpaceDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateChangeset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/CreateChangeset">REST API Reference for CreateChangeset Operation</seealso>
        public virtual IAsyncResult BeginCreateChangeset(CreateChangesetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateChangesetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChangesetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateChangeset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateChangeset.</param>
        /// 
        /// <returns>Returns a  CreateChangesetResult from FinSpaceData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/CreateChangeset">REST API Reference for CreateChangeset Operation</seealso>
        public virtual CreateChangesetResponse EndCreateChangeset(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateChangesetResponse>(asyncResult);
        }

        #endregion
        
        #region  GetProgrammaticAccessCredentials

        /// <summary>
        /// Request programmatic credentials to use with Habanero SDK.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProgrammaticAccessCredentials service method.</param>
        /// 
        /// <returns>The response from the GetProgrammaticAccessCredentials service method, as returned by FinSpaceData.</returns>
        /// <exception cref="Amazon.FinSpaceData.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/GetProgrammaticAccessCredentials">REST API Reference for GetProgrammaticAccessCredentials Operation</seealso>
        public virtual GetProgrammaticAccessCredentialsResponse GetProgrammaticAccessCredentials(GetProgrammaticAccessCredentialsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetProgrammaticAccessCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProgrammaticAccessCredentialsResponseUnmarshaller.Instance;

            return Invoke<GetProgrammaticAccessCredentialsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetProgrammaticAccessCredentials operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetProgrammaticAccessCredentials operation on AmazonFinSpaceDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetProgrammaticAccessCredentials
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/GetProgrammaticAccessCredentials">REST API Reference for GetProgrammaticAccessCredentials Operation</seealso>
        public virtual IAsyncResult BeginGetProgrammaticAccessCredentials(GetProgrammaticAccessCredentialsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetProgrammaticAccessCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProgrammaticAccessCredentialsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetProgrammaticAccessCredentials operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetProgrammaticAccessCredentials.</param>
        /// 
        /// <returns>Returns a  GetProgrammaticAccessCredentialsResult from FinSpaceData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/GetProgrammaticAccessCredentials">REST API Reference for GetProgrammaticAccessCredentials Operation</seealso>
        public virtual GetProgrammaticAccessCredentialsResponse EndGetProgrammaticAccessCredentials(IAsyncResult asyncResult)
        {
            return EndInvoke<GetProgrammaticAccessCredentialsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetWorkingLocation

        /// <summary>
        /// A temporary Amazon S3 location to copy your files from a source location to stage
        /// or use as a scratch space in Habanero notebook.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkingLocation service method.</param>
        /// 
        /// <returns>The response from the GetWorkingLocation service method, as returned by FinSpaceData.</returns>
        /// <exception cref="Amazon.FinSpaceData.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.FinSpaceData.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/GetWorkingLocation">REST API Reference for GetWorkingLocation Operation</seealso>
        public virtual GetWorkingLocationResponse GetWorkingLocation(GetWorkingLocationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWorkingLocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkingLocationResponseUnmarshaller.Instance;

            return Invoke<GetWorkingLocationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetWorkingLocation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWorkingLocation operation on AmazonFinSpaceDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWorkingLocation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/GetWorkingLocation">REST API Reference for GetWorkingLocation Operation</seealso>
        public virtual IAsyncResult BeginGetWorkingLocation(GetWorkingLocationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWorkingLocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkingLocationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetWorkingLocation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWorkingLocation.</param>
        /// 
        /// <returns>Returns a  GetWorkingLocationResult from FinSpaceData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/finspace-2020-07-13/GetWorkingLocation">REST API Reference for GetWorkingLocation Operation</seealso>
        public virtual GetWorkingLocationResponse EndGetWorkingLocation(IAsyncResult asyncResult)
        {
            return EndInvoke<GetWorkingLocationResponse>(asyncResult);
        }

        #endregion
        
    }
}