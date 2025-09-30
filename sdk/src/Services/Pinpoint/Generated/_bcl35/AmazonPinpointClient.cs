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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.Pinpoint.Model;
using Amazon.Pinpoint.Model.Internal.MarshallTransformations;
using Amazon.Pinpoint.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.Pinpoint
{
    /// <summary>
    /// <para>Implementation for accessing Pinpoint</para>
    ///
    /// Doc Engage API - Amazon Pinpoint API
    /// </summary>
    public partial class AmazonPinpointClient : AmazonServiceClient, IAmazonPinpoint
    {
        private static IServiceMetadata serviceMetadata = new AmazonPinpointMetadata();

        #region Constructors

        /// <summary>
        /// Constructs AmazonPinpointClient with the credentials loaded from the application's
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
        public AmazonPinpointClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonPinpointConfig()) { }

        /// <summary>
        /// Constructs AmazonPinpointClient with the credentials loaded from the application's
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
        public AmazonPinpointClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonPinpointConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonPinpointClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonPinpointClient Configuration Object</param>
        public AmazonPinpointClient(AmazonPinpointConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonPinpointClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonPinpointClient(AWSCredentials credentials)
            : this(credentials, new AmazonPinpointConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPinpointClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPinpointClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonPinpointConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPinpointClient with AWS Credentials and an
        /// AmazonPinpointClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonPinpointClient Configuration Object</param>
        public AmazonPinpointClient(AWSCredentials credentials, AmazonPinpointConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPinpointClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonPinpointClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPinpointConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPinpointClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPinpointClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPinpointConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonPinpointClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPinpointClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonPinpointClient Configuration Object</param>
        public AmazonPinpointClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonPinpointConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPinpointClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonPinpointClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPinpointConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPinpointClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPinpointClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPinpointConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPinpointClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPinpointClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonPinpointClient Configuration Object</param>
        public AmazonPinpointClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonPinpointConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonPinpointEndpointResolver());
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


        #region  CreateApp

        /// <summary>
        /// Creates an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApp service method.</param>
        /// 
        /// <returns>The response from the CreateApp service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/CreateApp">REST API Reference for CreateApp Operation</seealso>
        public virtual CreateAppResponse CreateApp(CreateAppRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAppResponseUnmarshaller.Instance;

            return Invoke<CreateAppResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApp operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateApp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/CreateApp">REST API Reference for CreateApp Operation</seealso>
        public virtual IAsyncResult BeginCreateApp(CreateAppRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAppResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateApp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateApp.</param>
        /// 
        /// <returns>Returns a  CreateAppResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/CreateApp">REST API Reference for CreateApp Operation</seealso>
        public virtual CreateAppResponse EndCreateApp(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateAppResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateCampaign

        /// <summary>
        /// Creates a new campaign for an application or updates the settings of an existing campaign
        /// for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCampaign service method.</param>
        /// 
        /// <returns>The response from the CreateCampaign service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/CreateCampaign">REST API Reference for CreateCampaign Operation</seealso>
        public virtual CreateCampaignResponse CreateCampaign(CreateCampaignRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCampaignResponseUnmarshaller.Instance;

            return Invoke<CreateCampaignResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCampaign operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCampaign operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCampaign
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/CreateCampaign">REST API Reference for CreateCampaign Operation</seealso>
        public virtual IAsyncResult BeginCreateCampaign(CreateCampaignRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCampaignResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCampaign operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCampaign.</param>
        /// 
        /// <returns>Returns a  CreateCampaignResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/CreateCampaign">REST API Reference for CreateCampaign Operation</seealso>
        public virtual CreateCampaignResponse EndCreateCampaign(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateCampaignResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateEmailTemplate

        /// <summary>
        /// Creates a message template for messages that are sent through the email channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEmailTemplate service method.</param>
        /// 
        /// <returns>The response from the CreateEmailTemplate service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/CreateEmailTemplate">REST API Reference for CreateEmailTemplate Operation</seealso>
        public virtual CreateEmailTemplateResponse CreateEmailTemplate(CreateEmailTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEmailTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEmailTemplateResponseUnmarshaller.Instance;

            return Invoke<CreateEmailTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEmailTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEmailTemplate operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEmailTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/CreateEmailTemplate">REST API Reference for CreateEmailTemplate Operation</seealso>
        public virtual IAsyncResult BeginCreateEmailTemplate(CreateEmailTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEmailTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEmailTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEmailTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEmailTemplate.</param>
        /// 
        /// <returns>Returns a  CreateEmailTemplateResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/CreateEmailTemplate">REST API Reference for CreateEmailTemplate Operation</seealso>
        public virtual CreateEmailTemplateResponse EndCreateEmailTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateEmailTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateExportJob

        /// <summary>
        /// Creates an export job for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateExportJob service method.</param>
        /// 
        /// <returns>The response from the CreateExportJob service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/CreateExportJob">REST API Reference for CreateExportJob Operation</seealso>
        public virtual CreateExportJobResponse CreateExportJob(CreateExportJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateExportJobResponseUnmarshaller.Instance;

            return Invoke<CreateExportJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateExportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateExportJob operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateExportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/CreateExportJob">REST API Reference for CreateExportJob Operation</seealso>
        public virtual IAsyncResult BeginCreateExportJob(CreateExportJobRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateExportJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateExportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateExportJob.</param>
        /// 
        /// <returns>Returns a  CreateExportJobResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/CreateExportJob">REST API Reference for CreateExportJob Operation</seealso>
        public virtual CreateExportJobResponse EndCreateExportJob(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateExportJobResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateImportJob

        /// <summary>
        /// Creates an import job for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateImportJob service method.</param>
        /// 
        /// <returns>The response from the CreateImportJob service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/CreateImportJob">REST API Reference for CreateImportJob Operation</seealso>
        public virtual CreateImportJobResponse CreateImportJob(CreateImportJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateImportJobResponseUnmarshaller.Instance;

            return Invoke<CreateImportJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateImportJob operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/CreateImportJob">REST API Reference for CreateImportJob Operation</seealso>
        public virtual IAsyncResult BeginCreateImportJob(CreateImportJobRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateImportJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateImportJob.</param>
        /// 
        /// <returns>Returns a  CreateImportJobResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/CreateImportJob">REST API Reference for CreateImportJob Operation</seealso>
        public virtual CreateImportJobResponse EndCreateImportJob(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateImportJobResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateInAppTemplate

        /// <summary>
        /// Creates a new message template for messages using the in-app message channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInAppTemplate service method.</param>
        /// 
        /// <returns>The response from the CreateInAppTemplate service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/CreateInAppTemplate">REST API Reference for CreateInAppTemplate Operation</seealso>
        public virtual CreateInAppTemplateResponse CreateInAppTemplate(CreateInAppTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateInAppTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInAppTemplateResponseUnmarshaller.Instance;

            return Invoke<CreateInAppTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInAppTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInAppTemplate operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateInAppTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/CreateInAppTemplate">REST API Reference for CreateInAppTemplate Operation</seealso>
        public virtual IAsyncResult BeginCreateInAppTemplate(CreateInAppTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateInAppTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInAppTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateInAppTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateInAppTemplate.</param>
        /// 
        /// <returns>Returns a  CreateInAppTemplateResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/CreateInAppTemplate">REST API Reference for CreateInAppTemplate Operation</seealso>
        public virtual CreateInAppTemplateResponse EndCreateInAppTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateInAppTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateJourney

        /// <summary>
        /// Creates a journey for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateJourney service method.</param>
        /// 
        /// <returns>The response from the CreateJourney service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/CreateJourney">REST API Reference for CreateJourney Operation</seealso>
        public virtual CreateJourneyResponse CreateJourney(CreateJourneyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateJourneyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateJourneyResponseUnmarshaller.Instance;

            return Invoke<CreateJourneyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateJourney operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateJourney operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateJourney
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/CreateJourney">REST API Reference for CreateJourney Operation</seealso>
        public virtual IAsyncResult BeginCreateJourney(CreateJourneyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateJourneyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateJourneyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateJourney operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateJourney.</param>
        /// 
        /// <returns>Returns a  CreateJourneyResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/CreateJourney">REST API Reference for CreateJourney Operation</seealso>
        public virtual CreateJourneyResponse EndCreateJourney(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateJourneyResponse>(asyncResult);
        }

        #endregion
        
        #region  CreatePushTemplate

        /// <summary>
        /// Creates a message template for messages that are sent through a push notification
        /// channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePushTemplate service method.</param>
        /// 
        /// <returns>The response from the CreatePushTemplate service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/CreatePushTemplate">REST API Reference for CreatePushTemplate Operation</seealso>
        public virtual CreatePushTemplateResponse CreatePushTemplate(CreatePushTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePushTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePushTemplateResponseUnmarshaller.Instance;

            return Invoke<CreatePushTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePushTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePushTemplate operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePushTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/CreatePushTemplate">REST API Reference for CreatePushTemplate Operation</seealso>
        public virtual IAsyncResult BeginCreatePushTemplate(CreatePushTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePushTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePushTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePushTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePushTemplate.</param>
        /// 
        /// <returns>Returns a  CreatePushTemplateResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/CreatePushTemplate">REST API Reference for CreatePushTemplate Operation</seealso>
        public virtual CreatePushTemplateResponse EndCreatePushTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<CreatePushTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateRecommenderConfiguration

        /// <summary>
        /// Creates an Amazon Pinpoint configuration for a recommender model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRecommenderConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateRecommenderConfiguration service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/CreateRecommenderConfiguration">REST API Reference for CreateRecommenderConfiguration Operation</seealso>
        public virtual CreateRecommenderConfigurationResponse CreateRecommenderConfiguration(CreateRecommenderConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRecommenderConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRecommenderConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateRecommenderConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRecommenderConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRecommenderConfiguration operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRecommenderConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/CreateRecommenderConfiguration">REST API Reference for CreateRecommenderConfiguration Operation</seealso>
        public virtual IAsyncResult BeginCreateRecommenderConfiguration(CreateRecommenderConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRecommenderConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRecommenderConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRecommenderConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRecommenderConfiguration.</param>
        /// 
        /// <returns>Returns a  CreateRecommenderConfigurationResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/CreateRecommenderConfiguration">REST API Reference for CreateRecommenderConfiguration Operation</seealso>
        public virtual CreateRecommenderConfigurationResponse EndCreateRecommenderConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateRecommenderConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateSegment

        /// <summary>
        /// Creates a new segment for an application or updates the configuration, dimension,
        /// and other settings for an existing segment that's associated with an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSegment service method.</param>
        /// 
        /// <returns>The response from the CreateSegment service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/CreateSegment">REST API Reference for CreateSegment Operation</seealso>
        public virtual CreateSegmentResponse CreateSegment(CreateSegmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSegmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSegmentResponseUnmarshaller.Instance;

            return Invoke<CreateSegmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSegment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSegment operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSegment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/CreateSegment">REST API Reference for CreateSegment Operation</seealso>
        public virtual IAsyncResult BeginCreateSegment(CreateSegmentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSegmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSegmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSegment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSegment.</param>
        /// 
        /// <returns>Returns a  CreateSegmentResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/CreateSegment">REST API Reference for CreateSegment Operation</seealso>
        public virtual CreateSegmentResponse EndCreateSegment(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSegmentResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateSmsTemplate

        /// <summary>
        /// Creates a message template for messages that are sent through the SMS channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSmsTemplate service method.</param>
        /// 
        /// <returns>The response from the CreateSmsTemplate service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/CreateSmsTemplate">REST API Reference for CreateSmsTemplate Operation</seealso>
        public virtual CreateSmsTemplateResponse CreateSmsTemplate(CreateSmsTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSmsTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSmsTemplateResponseUnmarshaller.Instance;

            return Invoke<CreateSmsTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSmsTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSmsTemplate operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSmsTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/CreateSmsTemplate">REST API Reference for CreateSmsTemplate Operation</seealso>
        public virtual IAsyncResult BeginCreateSmsTemplate(CreateSmsTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSmsTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSmsTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSmsTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSmsTemplate.</param>
        /// 
        /// <returns>Returns a  CreateSmsTemplateResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/CreateSmsTemplate">REST API Reference for CreateSmsTemplate Operation</seealso>
        public virtual CreateSmsTemplateResponse EndCreateSmsTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSmsTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateVoiceTemplate

        /// <summary>
        /// Creates a message template for messages that are sent through the voice channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVoiceTemplate service method.</param>
        /// 
        /// <returns>The response from the CreateVoiceTemplate service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/CreateVoiceTemplate">REST API Reference for CreateVoiceTemplate Operation</seealso>
        public virtual CreateVoiceTemplateResponse CreateVoiceTemplate(CreateVoiceTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateVoiceTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVoiceTemplateResponseUnmarshaller.Instance;

            return Invoke<CreateVoiceTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVoiceTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVoiceTemplate operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVoiceTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/CreateVoiceTemplate">REST API Reference for CreateVoiceTemplate Operation</seealso>
        public virtual IAsyncResult BeginCreateVoiceTemplate(CreateVoiceTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateVoiceTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVoiceTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVoiceTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVoiceTemplate.</param>
        /// 
        /// <returns>Returns a  CreateVoiceTemplateResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/CreateVoiceTemplate">REST API Reference for CreateVoiceTemplate Operation</seealso>
        public virtual CreateVoiceTemplateResponse EndCreateVoiceTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateVoiceTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAdmChannel

        /// <summary>
        /// Disables the ADM channel for an application and deletes any existing settings for
        /// the channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAdmChannel service method.</param>
        /// 
        /// <returns>The response from the DeleteAdmChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteAdmChannel">REST API Reference for DeleteAdmChannel Operation</seealso>
        public virtual DeleteAdmChannelResponse DeleteAdmChannel(DeleteAdmChannelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAdmChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAdmChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteAdmChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAdmChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAdmChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAdmChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteAdmChannel">REST API Reference for DeleteAdmChannel Operation</seealso>
        public virtual IAsyncResult BeginDeleteAdmChannel(DeleteAdmChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAdmChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAdmChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAdmChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAdmChannel.</param>
        /// 
        /// <returns>Returns a  DeleteAdmChannelResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteAdmChannel">REST API Reference for DeleteAdmChannel Operation</seealso>
        public virtual DeleteAdmChannelResponse EndDeleteAdmChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAdmChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteApnsChannel

        /// <summary>
        /// Disables the APNs channel for an application and deletes any existing settings for
        /// the channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApnsChannel service method.</param>
        /// 
        /// <returns>The response from the DeleteApnsChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteApnsChannel">REST API Reference for DeleteApnsChannel Operation</seealso>
        public virtual DeleteApnsChannelResponse DeleteApnsChannel(DeleteApnsChannelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteApnsChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApnsChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteApnsChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApnsChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApnsChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApnsChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteApnsChannel">REST API Reference for DeleteApnsChannel Operation</seealso>
        public virtual IAsyncResult BeginDeleteApnsChannel(DeleteApnsChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteApnsChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApnsChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApnsChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApnsChannel.</param>
        /// 
        /// <returns>Returns a  DeleteApnsChannelResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteApnsChannel">REST API Reference for DeleteApnsChannel Operation</seealso>
        public virtual DeleteApnsChannelResponse EndDeleteApnsChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteApnsChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteApnsSandboxChannel

        /// <summary>
        /// Disables the APNs sandbox channel for an application and deletes any existing settings
        /// for the channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApnsSandboxChannel service method.</param>
        /// 
        /// <returns>The response from the DeleteApnsSandboxChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteApnsSandboxChannel">REST API Reference for DeleteApnsSandboxChannel Operation</seealso>
        public virtual DeleteApnsSandboxChannelResponse DeleteApnsSandboxChannel(DeleteApnsSandboxChannelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteApnsSandboxChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApnsSandboxChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteApnsSandboxChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApnsSandboxChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApnsSandboxChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApnsSandboxChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteApnsSandboxChannel">REST API Reference for DeleteApnsSandboxChannel Operation</seealso>
        public virtual IAsyncResult BeginDeleteApnsSandboxChannel(DeleteApnsSandboxChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteApnsSandboxChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApnsSandboxChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApnsSandboxChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApnsSandboxChannel.</param>
        /// 
        /// <returns>Returns a  DeleteApnsSandboxChannelResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteApnsSandboxChannel">REST API Reference for DeleteApnsSandboxChannel Operation</seealso>
        public virtual DeleteApnsSandboxChannelResponse EndDeleteApnsSandboxChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteApnsSandboxChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteApnsVoipChannel

        /// <summary>
        /// Disables the APNs VoIP channel for an application and deletes any existing settings
        /// for the channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApnsVoipChannel service method.</param>
        /// 
        /// <returns>The response from the DeleteApnsVoipChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteApnsVoipChannel">REST API Reference for DeleteApnsVoipChannel Operation</seealso>
        public virtual DeleteApnsVoipChannelResponse DeleteApnsVoipChannel(DeleteApnsVoipChannelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteApnsVoipChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApnsVoipChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteApnsVoipChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApnsVoipChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApnsVoipChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApnsVoipChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteApnsVoipChannel">REST API Reference for DeleteApnsVoipChannel Operation</seealso>
        public virtual IAsyncResult BeginDeleteApnsVoipChannel(DeleteApnsVoipChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteApnsVoipChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApnsVoipChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApnsVoipChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApnsVoipChannel.</param>
        /// 
        /// <returns>Returns a  DeleteApnsVoipChannelResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteApnsVoipChannel">REST API Reference for DeleteApnsVoipChannel Operation</seealso>
        public virtual DeleteApnsVoipChannelResponse EndDeleteApnsVoipChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteApnsVoipChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteApnsVoipSandboxChannel

        /// <summary>
        /// Disables the APNs VoIP sandbox channel for an application and deletes any existing
        /// settings for the channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApnsVoipSandboxChannel service method.</param>
        /// 
        /// <returns>The response from the DeleteApnsVoipSandboxChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteApnsVoipSandboxChannel">REST API Reference for DeleteApnsVoipSandboxChannel Operation</seealso>
        public virtual DeleteApnsVoipSandboxChannelResponse DeleteApnsVoipSandboxChannel(DeleteApnsVoipSandboxChannelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteApnsVoipSandboxChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApnsVoipSandboxChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteApnsVoipSandboxChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApnsVoipSandboxChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApnsVoipSandboxChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApnsVoipSandboxChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteApnsVoipSandboxChannel">REST API Reference for DeleteApnsVoipSandboxChannel Operation</seealso>
        public virtual IAsyncResult BeginDeleteApnsVoipSandboxChannel(DeleteApnsVoipSandboxChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteApnsVoipSandboxChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApnsVoipSandboxChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApnsVoipSandboxChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApnsVoipSandboxChannel.</param>
        /// 
        /// <returns>Returns a  DeleteApnsVoipSandboxChannelResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteApnsVoipSandboxChannel">REST API Reference for DeleteApnsVoipSandboxChannel Operation</seealso>
        public virtual DeleteApnsVoipSandboxChannelResponse EndDeleteApnsVoipSandboxChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteApnsVoipSandboxChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteApp

        /// <summary>
        /// Deletes an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApp service method.</param>
        /// 
        /// <returns>The response from the DeleteApp service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteApp">REST API Reference for DeleteApp Operation</seealso>
        public virtual DeleteAppResponse DeleteApp(DeleteAppRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppResponseUnmarshaller.Instance;

            return Invoke<DeleteAppResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApp operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteApp">REST API Reference for DeleteApp Operation</seealso>
        public virtual IAsyncResult BeginDeleteApp(DeleteAppRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApp.</param>
        /// 
        /// <returns>Returns a  DeleteAppResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteApp">REST API Reference for DeleteApp Operation</seealso>
        public virtual DeleteAppResponse EndDeleteApp(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAppResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteBaiduChannel

        /// <summary>
        /// Disables the Baidu channel for an application and deletes any existing settings for
        /// the channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBaiduChannel service method.</param>
        /// 
        /// <returns>The response from the DeleteBaiduChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteBaiduChannel">REST API Reference for DeleteBaiduChannel Operation</seealso>
        public virtual DeleteBaiduChannelResponse DeleteBaiduChannel(DeleteBaiduChannelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteBaiduChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBaiduChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteBaiduChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBaiduChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBaiduChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBaiduChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteBaiduChannel">REST API Reference for DeleteBaiduChannel Operation</seealso>
        public virtual IAsyncResult BeginDeleteBaiduChannel(DeleteBaiduChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteBaiduChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBaiduChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBaiduChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBaiduChannel.</param>
        /// 
        /// <returns>Returns a  DeleteBaiduChannelResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteBaiduChannel">REST API Reference for DeleteBaiduChannel Operation</seealso>
        public virtual DeleteBaiduChannelResponse EndDeleteBaiduChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteBaiduChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteCampaign

        /// <summary>
        /// Deletes a campaign from an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCampaign service method.</param>
        /// 
        /// <returns>The response from the DeleteCampaign service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteCampaign">REST API Reference for DeleteCampaign Operation</seealso>
        public virtual DeleteCampaignResponse DeleteCampaign(DeleteCampaignRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCampaignResponseUnmarshaller.Instance;

            return Invoke<DeleteCampaignResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCampaign operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCampaign operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCampaign
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteCampaign">REST API Reference for DeleteCampaign Operation</seealso>
        public virtual IAsyncResult BeginDeleteCampaign(DeleteCampaignRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCampaignResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCampaign operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCampaign.</param>
        /// 
        /// <returns>Returns a  DeleteCampaignResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteCampaign">REST API Reference for DeleteCampaign Operation</seealso>
        public virtual DeleteCampaignResponse EndDeleteCampaign(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteCampaignResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteEmailChannel

        /// <summary>
        /// Disables the email channel for an application and deletes any existing settings for
        /// the channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEmailChannel service method.</param>
        /// 
        /// <returns>The response from the DeleteEmailChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteEmailChannel">REST API Reference for DeleteEmailChannel Operation</seealso>
        public virtual DeleteEmailChannelResponse DeleteEmailChannel(DeleteEmailChannelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEmailChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEmailChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteEmailChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEmailChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEmailChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEmailChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteEmailChannel">REST API Reference for DeleteEmailChannel Operation</seealso>
        public virtual IAsyncResult BeginDeleteEmailChannel(DeleteEmailChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEmailChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEmailChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEmailChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEmailChannel.</param>
        /// 
        /// <returns>Returns a  DeleteEmailChannelResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteEmailChannel">REST API Reference for DeleteEmailChannel Operation</seealso>
        public virtual DeleteEmailChannelResponse EndDeleteEmailChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteEmailChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteEmailTemplate

        /// <summary>
        /// Deletes a message template for messages that were sent through the email channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEmailTemplate service method.</param>
        /// 
        /// <returns>The response from the DeleteEmailTemplate service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteEmailTemplate">REST API Reference for DeleteEmailTemplate Operation</seealso>
        public virtual DeleteEmailTemplateResponse DeleteEmailTemplate(DeleteEmailTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEmailTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEmailTemplateResponseUnmarshaller.Instance;

            return Invoke<DeleteEmailTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEmailTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEmailTemplate operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEmailTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteEmailTemplate">REST API Reference for DeleteEmailTemplate Operation</seealso>
        public virtual IAsyncResult BeginDeleteEmailTemplate(DeleteEmailTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEmailTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEmailTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEmailTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEmailTemplate.</param>
        /// 
        /// <returns>Returns a  DeleteEmailTemplateResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteEmailTemplate">REST API Reference for DeleteEmailTemplate Operation</seealso>
        public virtual DeleteEmailTemplateResponse EndDeleteEmailTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteEmailTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteEndpoint

        /// <summary>
        /// Deletes an endpoint from an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpoint service method.</param>
        /// 
        /// <returns>The response from the DeleteEndpoint service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteEndpoint">REST API Reference for DeleteEndpoint Operation</seealso>
        public virtual DeleteEndpointResponse DeleteEndpoint(DeleteEndpointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEndpointResponseUnmarshaller.Instance;

            return Invoke<DeleteEndpointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpoint operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteEndpoint">REST API Reference for DeleteEndpoint Operation</seealso>
        public virtual IAsyncResult BeginDeleteEndpoint(DeleteEndpointRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEndpointResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEndpoint.</param>
        /// 
        /// <returns>Returns a  DeleteEndpointResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteEndpoint">REST API Reference for DeleteEndpoint Operation</seealso>
        public virtual DeleteEndpointResponse EndDeleteEndpoint(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteEndpointResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteEventStream

        /// <summary>
        /// Deletes the event stream for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventStream service method.</param>
        /// 
        /// <returns>The response from the DeleteEventStream service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteEventStream">REST API Reference for DeleteEventStream Operation</seealso>
        public virtual DeleteEventStreamResponse DeleteEventStream(DeleteEventStreamRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEventStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventStreamResponseUnmarshaller.Instance;

            return Invoke<DeleteEventStreamResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEventStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventStream operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEventStream
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteEventStream">REST API Reference for DeleteEventStream Operation</seealso>
        public virtual IAsyncResult BeginDeleteEventStream(DeleteEventStreamRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEventStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventStreamResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEventStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEventStream.</param>
        /// 
        /// <returns>Returns a  DeleteEventStreamResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteEventStream">REST API Reference for DeleteEventStream Operation</seealso>
        public virtual DeleteEventStreamResponse EndDeleteEventStream(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteEventStreamResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteGcmChannel

        /// <summary>
        /// Disables the GCM channel for an application and deletes any existing settings for
        /// the channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGcmChannel service method.</param>
        /// 
        /// <returns>The response from the DeleteGcmChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteGcmChannel">REST API Reference for DeleteGcmChannel Operation</seealso>
        public virtual DeleteGcmChannelResponse DeleteGcmChannel(DeleteGcmChannelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGcmChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGcmChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteGcmChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGcmChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGcmChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteGcmChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteGcmChannel">REST API Reference for DeleteGcmChannel Operation</seealso>
        public virtual IAsyncResult BeginDeleteGcmChannel(DeleteGcmChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteGcmChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGcmChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGcmChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGcmChannel.</param>
        /// 
        /// <returns>Returns a  DeleteGcmChannelResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteGcmChannel">REST API Reference for DeleteGcmChannel Operation</seealso>
        public virtual DeleteGcmChannelResponse EndDeleteGcmChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteGcmChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteInAppTemplate

        /// <summary>
        /// Deletes a message template for messages sent using the in-app message channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInAppTemplate service method.</param>
        /// 
        /// <returns>The response from the DeleteInAppTemplate service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteInAppTemplate">REST API Reference for DeleteInAppTemplate Operation</seealso>
        public virtual DeleteInAppTemplateResponse DeleteInAppTemplate(DeleteInAppTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteInAppTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInAppTemplateResponseUnmarshaller.Instance;

            return Invoke<DeleteInAppTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInAppTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInAppTemplate operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteInAppTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteInAppTemplate">REST API Reference for DeleteInAppTemplate Operation</seealso>
        public virtual IAsyncResult BeginDeleteInAppTemplate(DeleteInAppTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteInAppTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInAppTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteInAppTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteInAppTemplate.</param>
        /// 
        /// <returns>Returns a  DeleteInAppTemplateResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteInAppTemplate">REST API Reference for DeleteInAppTemplate Operation</seealso>
        public virtual DeleteInAppTemplateResponse EndDeleteInAppTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteInAppTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteJourney

        /// <summary>
        /// Deletes a journey from an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteJourney service method.</param>
        /// 
        /// <returns>The response from the DeleteJourney service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteJourney">REST API Reference for DeleteJourney Operation</seealso>
        public virtual DeleteJourneyResponse DeleteJourney(DeleteJourneyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteJourneyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteJourneyResponseUnmarshaller.Instance;

            return Invoke<DeleteJourneyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteJourney operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteJourney operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteJourney
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteJourney">REST API Reference for DeleteJourney Operation</seealso>
        public virtual IAsyncResult BeginDeleteJourney(DeleteJourneyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteJourneyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteJourneyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteJourney operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteJourney.</param>
        /// 
        /// <returns>Returns a  DeleteJourneyResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteJourney">REST API Reference for DeleteJourney Operation</seealso>
        public virtual DeleteJourneyResponse EndDeleteJourney(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteJourneyResponse>(asyncResult);
        }

        #endregion
        
        #region  DeletePushTemplate

        /// <summary>
        /// Deletes a message template for messages that were sent through a push notification
        /// channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePushTemplate service method.</param>
        /// 
        /// <returns>The response from the DeletePushTemplate service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeletePushTemplate">REST API Reference for DeletePushTemplate Operation</seealso>
        public virtual DeletePushTemplateResponse DeletePushTemplate(DeletePushTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePushTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePushTemplateResponseUnmarshaller.Instance;

            return Invoke<DeletePushTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePushTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePushTemplate operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePushTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeletePushTemplate">REST API Reference for DeletePushTemplate Operation</seealso>
        public virtual IAsyncResult BeginDeletePushTemplate(DeletePushTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePushTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePushTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePushTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePushTemplate.</param>
        /// 
        /// <returns>Returns a  DeletePushTemplateResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeletePushTemplate">REST API Reference for DeletePushTemplate Operation</seealso>
        public virtual DeletePushTemplateResponse EndDeletePushTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<DeletePushTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteRecommenderConfiguration

        /// <summary>
        /// Deletes an Amazon Pinpoint configuration for a recommender model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRecommenderConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteRecommenderConfiguration service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteRecommenderConfiguration">REST API Reference for DeleteRecommenderConfiguration Operation</seealso>
        public virtual DeleteRecommenderConfigurationResponse DeleteRecommenderConfiguration(DeleteRecommenderConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRecommenderConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRecommenderConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteRecommenderConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRecommenderConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRecommenderConfiguration operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRecommenderConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteRecommenderConfiguration">REST API Reference for DeleteRecommenderConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDeleteRecommenderConfiguration(DeleteRecommenderConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRecommenderConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRecommenderConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRecommenderConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRecommenderConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteRecommenderConfigurationResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteRecommenderConfiguration">REST API Reference for DeleteRecommenderConfiguration Operation</seealso>
        public virtual DeleteRecommenderConfigurationResponse EndDeleteRecommenderConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRecommenderConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteSegment

        /// <summary>
        /// Deletes a segment from an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSegment service method.</param>
        /// 
        /// <returns>The response from the DeleteSegment service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteSegment">REST API Reference for DeleteSegment Operation</seealso>
        public virtual DeleteSegmentResponse DeleteSegment(DeleteSegmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSegmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSegmentResponseUnmarshaller.Instance;

            return Invoke<DeleteSegmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSegment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSegment operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSegment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteSegment">REST API Reference for DeleteSegment Operation</seealso>
        public virtual IAsyncResult BeginDeleteSegment(DeleteSegmentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSegmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSegmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSegment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSegment.</param>
        /// 
        /// <returns>Returns a  DeleteSegmentResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteSegment">REST API Reference for DeleteSegment Operation</seealso>
        public virtual DeleteSegmentResponse EndDeleteSegment(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSegmentResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteSmsChannel

        /// <summary>
        /// Disables the SMS channel for an application and deletes any existing settings for
        /// the channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSmsChannel service method.</param>
        /// 
        /// <returns>The response from the DeleteSmsChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteSmsChannel">REST API Reference for DeleteSmsChannel Operation</seealso>
        public virtual DeleteSmsChannelResponse DeleteSmsChannel(DeleteSmsChannelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSmsChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSmsChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteSmsChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSmsChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSmsChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSmsChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteSmsChannel">REST API Reference for DeleteSmsChannel Operation</seealso>
        public virtual IAsyncResult BeginDeleteSmsChannel(DeleteSmsChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSmsChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSmsChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSmsChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSmsChannel.</param>
        /// 
        /// <returns>Returns a  DeleteSmsChannelResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteSmsChannel">REST API Reference for DeleteSmsChannel Operation</seealso>
        public virtual DeleteSmsChannelResponse EndDeleteSmsChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSmsChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteSmsTemplate

        /// <summary>
        /// Deletes a message template for messages that were sent through the SMS channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSmsTemplate service method.</param>
        /// 
        /// <returns>The response from the DeleteSmsTemplate service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteSmsTemplate">REST API Reference for DeleteSmsTemplate Operation</seealso>
        public virtual DeleteSmsTemplateResponse DeleteSmsTemplate(DeleteSmsTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSmsTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSmsTemplateResponseUnmarshaller.Instance;

            return Invoke<DeleteSmsTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSmsTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSmsTemplate operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSmsTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteSmsTemplate">REST API Reference for DeleteSmsTemplate Operation</seealso>
        public virtual IAsyncResult BeginDeleteSmsTemplate(DeleteSmsTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSmsTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSmsTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSmsTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSmsTemplate.</param>
        /// 
        /// <returns>Returns a  DeleteSmsTemplateResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteSmsTemplate">REST API Reference for DeleteSmsTemplate Operation</seealso>
        public virtual DeleteSmsTemplateResponse EndDeleteSmsTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSmsTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteUserEndpoints

        /// <summary>
        /// Deletes all the endpoints that are associated with a specific user ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserEndpoints service method.</param>
        /// 
        /// <returns>The response from the DeleteUserEndpoints service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteUserEndpoints">REST API Reference for DeleteUserEndpoints Operation</seealso>
        public virtual DeleteUserEndpointsResponse DeleteUserEndpoints(DeleteUserEndpointsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteUserEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserEndpointsResponseUnmarshaller.Instance;

            return Invoke<DeleteUserEndpointsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUserEndpoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserEndpoints operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteUserEndpoints
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteUserEndpoints">REST API Reference for DeleteUserEndpoints Operation</seealso>
        public virtual IAsyncResult BeginDeleteUserEndpoints(DeleteUserEndpointsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteUserEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUserEndpointsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUserEndpoints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUserEndpoints.</param>
        /// 
        /// <returns>Returns a  DeleteUserEndpointsResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteUserEndpoints">REST API Reference for DeleteUserEndpoints Operation</seealso>
        public virtual DeleteUserEndpointsResponse EndDeleteUserEndpoints(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteUserEndpointsResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteVoiceChannel

        /// <summary>
        /// Disables the voice channel for an application and deletes any existing settings for
        /// the channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceChannel service method.</param>
        /// 
        /// <returns>The response from the DeleteVoiceChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteVoiceChannel">REST API Reference for DeleteVoiceChannel Operation</seealso>
        public virtual DeleteVoiceChannelResponse DeleteVoiceChannel(DeleteVoiceChannelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteVoiceChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVoiceChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteVoiceChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVoiceChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVoiceChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteVoiceChannel">REST API Reference for DeleteVoiceChannel Operation</seealso>
        public virtual IAsyncResult BeginDeleteVoiceChannel(DeleteVoiceChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteVoiceChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVoiceChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVoiceChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVoiceChannel.</param>
        /// 
        /// <returns>Returns a  DeleteVoiceChannelResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteVoiceChannel">REST API Reference for DeleteVoiceChannel Operation</seealso>
        public virtual DeleteVoiceChannelResponse EndDeleteVoiceChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteVoiceChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteVoiceTemplate

        /// <summary>
        /// Deletes a message template for messages that were sent through the voice channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceTemplate service method.</param>
        /// 
        /// <returns>The response from the DeleteVoiceTemplate service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteVoiceTemplate">REST API Reference for DeleteVoiceTemplate Operation</seealso>
        public virtual DeleteVoiceTemplateResponse DeleteVoiceTemplate(DeleteVoiceTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteVoiceTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVoiceTemplateResponseUnmarshaller.Instance;

            return Invoke<DeleteVoiceTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVoiceTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceTemplate operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVoiceTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteVoiceTemplate">REST API Reference for DeleteVoiceTemplate Operation</seealso>
        public virtual IAsyncResult BeginDeleteVoiceTemplate(DeleteVoiceTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteVoiceTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVoiceTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVoiceTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVoiceTemplate.</param>
        /// 
        /// <returns>Returns a  DeleteVoiceTemplateResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/DeleteVoiceTemplate">REST API Reference for DeleteVoiceTemplate Operation</seealso>
        public virtual DeleteVoiceTemplateResponse EndDeleteVoiceTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteVoiceTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAdmChannel

        /// <summary>
        /// Retrieves information about the status and settings of the ADM channel for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAdmChannel service method.</param>
        /// 
        /// <returns>The response from the GetAdmChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetAdmChannel">REST API Reference for GetAdmChannel Operation</seealso>
        public virtual GetAdmChannelResponse GetAdmChannel(GetAdmChannelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAdmChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAdmChannelResponseUnmarshaller.Instance;

            return Invoke<GetAdmChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAdmChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAdmChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAdmChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetAdmChannel">REST API Reference for GetAdmChannel Operation</seealso>
        public virtual IAsyncResult BeginGetAdmChannel(GetAdmChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAdmChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAdmChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAdmChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAdmChannel.</param>
        /// 
        /// <returns>Returns a  GetAdmChannelResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetAdmChannel">REST API Reference for GetAdmChannel Operation</seealso>
        public virtual GetAdmChannelResponse EndGetAdmChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAdmChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  GetApnsChannel

        /// <summary>
        /// Retrieves information about the status and settings of the APNs channel for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApnsChannel service method.</param>
        /// 
        /// <returns>The response from the GetApnsChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetApnsChannel">REST API Reference for GetApnsChannel Operation</seealso>
        public virtual GetApnsChannelResponse GetApnsChannel(GetApnsChannelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApnsChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApnsChannelResponseUnmarshaller.Instance;

            return Invoke<GetApnsChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetApnsChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApnsChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApnsChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetApnsChannel">REST API Reference for GetApnsChannel Operation</seealso>
        public virtual IAsyncResult BeginGetApnsChannel(GetApnsChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApnsChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApnsChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetApnsChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApnsChannel.</param>
        /// 
        /// <returns>Returns a  GetApnsChannelResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetApnsChannel">REST API Reference for GetApnsChannel Operation</seealso>
        public virtual GetApnsChannelResponse EndGetApnsChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<GetApnsChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  GetApnsSandboxChannel

        /// <summary>
        /// Retrieves information about the status and settings of the APNs sandbox channel for
        /// an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApnsSandboxChannel service method.</param>
        /// 
        /// <returns>The response from the GetApnsSandboxChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetApnsSandboxChannel">REST API Reference for GetApnsSandboxChannel Operation</seealso>
        public virtual GetApnsSandboxChannelResponse GetApnsSandboxChannel(GetApnsSandboxChannelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApnsSandboxChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApnsSandboxChannelResponseUnmarshaller.Instance;

            return Invoke<GetApnsSandboxChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetApnsSandboxChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApnsSandboxChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApnsSandboxChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetApnsSandboxChannel">REST API Reference for GetApnsSandboxChannel Operation</seealso>
        public virtual IAsyncResult BeginGetApnsSandboxChannel(GetApnsSandboxChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApnsSandboxChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApnsSandboxChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetApnsSandboxChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApnsSandboxChannel.</param>
        /// 
        /// <returns>Returns a  GetApnsSandboxChannelResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetApnsSandboxChannel">REST API Reference for GetApnsSandboxChannel Operation</seealso>
        public virtual GetApnsSandboxChannelResponse EndGetApnsSandboxChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<GetApnsSandboxChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  GetApnsVoipChannel

        /// <summary>
        /// Retrieves information about the status and settings of the APNs VoIP channel for an
        /// application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApnsVoipChannel service method.</param>
        /// 
        /// <returns>The response from the GetApnsVoipChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetApnsVoipChannel">REST API Reference for GetApnsVoipChannel Operation</seealso>
        public virtual GetApnsVoipChannelResponse GetApnsVoipChannel(GetApnsVoipChannelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApnsVoipChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApnsVoipChannelResponseUnmarshaller.Instance;

            return Invoke<GetApnsVoipChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetApnsVoipChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApnsVoipChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApnsVoipChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetApnsVoipChannel">REST API Reference for GetApnsVoipChannel Operation</seealso>
        public virtual IAsyncResult BeginGetApnsVoipChannel(GetApnsVoipChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApnsVoipChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApnsVoipChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetApnsVoipChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApnsVoipChannel.</param>
        /// 
        /// <returns>Returns a  GetApnsVoipChannelResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetApnsVoipChannel">REST API Reference for GetApnsVoipChannel Operation</seealso>
        public virtual GetApnsVoipChannelResponse EndGetApnsVoipChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<GetApnsVoipChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  GetApnsVoipSandboxChannel

        /// <summary>
        /// Retrieves information about the status and settings of the APNs VoIP sandbox channel
        /// for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApnsVoipSandboxChannel service method.</param>
        /// 
        /// <returns>The response from the GetApnsVoipSandboxChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetApnsVoipSandboxChannel">REST API Reference for GetApnsVoipSandboxChannel Operation</seealso>
        public virtual GetApnsVoipSandboxChannelResponse GetApnsVoipSandboxChannel(GetApnsVoipSandboxChannelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApnsVoipSandboxChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApnsVoipSandboxChannelResponseUnmarshaller.Instance;

            return Invoke<GetApnsVoipSandboxChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetApnsVoipSandboxChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApnsVoipSandboxChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApnsVoipSandboxChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetApnsVoipSandboxChannel">REST API Reference for GetApnsVoipSandboxChannel Operation</seealso>
        public virtual IAsyncResult BeginGetApnsVoipSandboxChannel(GetApnsVoipSandboxChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApnsVoipSandboxChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApnsVoipSandboxChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetApnsVoipSandboxChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApnsVoipSandboxChannel.</param>
        /// 
        /// <returns>Returns a  GetApnsVoipSandboxChannelResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetApnsVoipSandboxChannel">REST API Reference for GetApnsVoipSandboxChannel Operation</seealso>
        public virtual GetApnsVoipSandboxChannelResponse EndGetApnsVoipSandboxChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<GetApnsVoipSandboxChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  GetApp

        /// <summary>
        /// Retrieves information about an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApp service method.</param>
        /// 
        /// <returns>The response from the GetApp service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetApp">REST API Reference for GetApp Operation</seealso>
        public virtual GetAppResponse GetApp(GetAppRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAppResponseUnmarshaller.Instance;

            return Invoke<GetAppResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetApp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApp operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetApp">REST API Reference for GetApp Operation</seealso>
        public virtual IAsyncResult BeginGetApp(GetAppRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAppResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetApp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApp.</param>
        /// 
        /// <returns>Returns a  GetAppResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetApp">REST API Reference for GetApp Operation</seealso>
        public virtual GetAppResponse EndGetApp(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAppResponse>(asyncResult);
        }

        #endregion
        
        #region  GetApplicationDateRangeKpi

        /// <summary>
        /// Retrieves (queries) pre-aggregated data for a standard metric that applies to an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplicationDateRangeKpi service method.</param>
        /// 
        /// <returns>The response from the GetApplicationDateRangeKpi service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetApplicationDateRangeKpi">REST API Reference for GetApplicationDateRangeKpi Operation</seealso>
        public virtual GetApplicationDateRangeKpiResponse GetApplicationDateRangeKpi(GetApplicationDateRangeKpiRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApplicationDateRangeKpiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApplicationDateRangeKpiResponseUnmarshaller.Instance;

            return Invoke<GetApplicationDateRangeKpiResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetApplicationDateRangeKpi operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApplicationDateRangeKpi operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApplicationDateRangeKpi
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetApplicationDateRangeKpi">REST API Reference for GetApplicationDateRangeKpi Operation</seealso>
        public virtual IAsyncResult BeginGetApplicationDateRangeKpi(GetApplicationDateRangeKpiRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApplicationDateRangeKpiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApplicationDateRangeKpiResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetApplicationDateRangeKpi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApplicationDateRangeKpi.</param>
        /// 
        /// <returns>Returns a  GetApplicationDateRangeKpiResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetApplicationDateRangeKpi">REST API Reference for GetApplicationDateRangeKpi Operation</seealso>
        public virtual GetApplicationDateRangeKpiResponse EndGetApplicationDateRangeKpi(IAsyncResult asyncResult)
        {
            return EndInvoke<GetApplicationDateRangeKpiResponse>(asyncResult);
        }

        #endregion
        
        #region  GetApplicationSettings

        /// <summary>
        /// Retrieves information about the settings for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplicationSettings service method.</param>
        /// 
        /// <returns>The response from the GetApplicationSettings service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetApplicationSettings">REST API Reference for GetApplicationSettings Operation</seealso>
        public virtual GetApplicationSettingsResponse GetApplicationSettings(GetApplicationSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApplicationSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApplicationSettingsResponseUnmarshaller.Instance;

            return Invoke<GetApplicationSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetApplicationSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApplicationSettings operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApplicationSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetApplicationSettings">REST API Reference for GetApplicationSettings Operation</seealso>
        public virtual IAsyncResult BeginGetApplicationSettings(GetApplicationSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApplicationSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApplicationSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetApplicationSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApplicationSettings.</param>
        /// 
        /// <returns>Returns a  GetApplicationSettingsResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetApplicationSettings">REST API Reference for GetApplicationSettings Operation</seealso>
        public virtual GetApplicationSettingsResponse EndGetApplicationSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<GetApplicationSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetApps

        /// <summary>
        /// Retrieves information about all the applications that are associated with your Amazon
        /// Pinpoint account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApps service method.</param>
        /// 
        /// <returns>The response from the GetApps service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetApps">REST API Reference for GetApps Operation</seealso>
        public virtual GetAppsResponse GetApps(GetAppsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAppsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAppsResponseUnmarshaller.Instance;

            return Invoke<GetAppsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetApps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApps operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApps
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetApps">REST API Reference for GetApps Operation</seealso>
        public virtual IAsyncResult BeginGetApps(GetAppsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAppsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAppsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetApps operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApps.</param>
        /// 
        /// <returns>Returns a  GetAppsResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetApps">REST API Reference for GetApps Operation</seealso>
        public virtual GetAppsResponse EndGetApps(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAppsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetBaiduChannel

        /// <summary>
        /// Retrieves information about the status and settings of the Baidu channel for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBaiduChannel service method.</param>
        /// 
        /// <returns>The response from the GetBaiduChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetBaiduChannel">REST API Reference for GetBaiduChannel Operation</seealso>
        public virtual GetBaiduChannelResponse GetBaiduChannel(GetBaiduChannelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBaiduChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBaiduChannelResponseUnmarshaller.Instance;

            return Invoke<GetBaiduChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetBaiduChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBaiduChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBaiduChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetBaiduChannel">REST API Reference for GetBaiduChannel Operation</seealso>
        public virtual IAsyncResult BeginGetBaiduChannel(GetBaiduChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBaiduChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBaiduChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetBaiduChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBaiduChannel.</param>
        /// 
        /// <returns>Returns a  GetBaiduChannelResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetBaiduChannel">REST API Reference for GetBaiduChannel Operation</seealso>
        public virtual GetBaiduChannelResponse EndGetBaiduChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<GetBaiduChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCampaign

        /// <summary>
        /// Retrieves information about the status, configuration, and other settings for a campaign.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCampaign service method.</param>
        /// 
        /// <returns>The response from the GetCampaign service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetCampaign">REST API Reference for GetCampaign Operation</seealso>
        public virtual GetCampaignResponse GetCampaign(GetCampaignRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCampaignResponseUnmarshaller.Instance;

            return Invoke<GetCampaignResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCampaign operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCampaign operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCampaign
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetCampaign">REST API Reference for GetCampaign Operation</seealso>
        public virtual IAsyncResult BeginGetCampaign(GetCampaignRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCampaignResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCampaign operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCampaign.</param>
        /// 
        /// <returns>Returns a  GetCampaignResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetCampaign">REST API Reference for GetCampaign Operation</seealso>
        public virtual GetCampaignResponse EndGetCampaign(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCampaignResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCampaignActivities

        /// <summary>
        /// Retrieves information about all the activities for a campaign.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCampaignActivities service method.</param>
        /// 
        /// <returns>The response from the GetCampaignActivities service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetCampaignActivities">REST API Reference for GetCampaignActivities Operation</seealso>
        public virtual GetCampaignActivitiesResponse GetCampaignActivities(GetCampaignActivitiesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCampaignActivitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCampaignActivitiesResponseUnmarshaller.Instance;

            return Invoke<GetCampaignActivitiesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCampaignActivities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCampaignActivities operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCampaignActivities
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetCampaignActivities">REST API Reference for GetCampaignActivities Operation</seealso>
        public virtual IAsyncResult BeginGetCampaignActivities(GetCampaignActivitiesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCampaignActivitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCampaignActivitiesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCampaignActivities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCampaignActivities.</param>
        /// 
        /// <returns>Returns a  GetCampaignActivitiesResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetCampaignActivities">REST API Reference for GetCampaignActivities Operation</seealso>
        public virtual GetCampaignActivitiesResponse EndGetCampaignActivities(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCampaignActivitiesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCampaignDateRangeKpi

        /// <summary>
        /// Retrieves (queries) pre-aggregated data for a standard metric that applies to a campaign.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCampaignDateRangeKpi service method.</param>
        /// 
        /// <returns>The response from the GetCampaignDateRangeKpi service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetCampaignDateRangeKpi">REST API Reference for GetCampaignDateRangeKpi Operation</seealso>
        public virtual GetCampaignDateRangeKpiResponse GetCampaignDateRangeKpi(GetCampaignDateRangeKpiRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCampaignDateRangeKpiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCampaignDateRangeKpiResponseUnmarshaller.Instance;

            return Invoke<GetCampaignDateRangeKpiResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCampaignDateRangeKpi operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCampaignDateRangeKpi operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCampaignDateRangeKpi
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetCampaignDateRangeKpi">REST API Reference for GetCampaignDateRangeKpi Operation</seealso>
        public virtual IAsyncResult BeginGetCampaignDateRangeKpi(GetCampaignDateRangeKpiRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCampaignDateRangeKpiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCampaignDateRangeKpiResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCampaignDateRangeKpi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCampaignDateRangeKpi.</param>
        /// 
        /// <returns>Returns a  GetCampaignDateRangeKpiResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetCampaignDateRangeKpi">REST API Reference for GetCampaignDateRangeKpi Operation</seealso>
        public virtual GetCampaignDateRangeKpiResponse EndGetCampaignDateRangeKpi(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCampaignDateRangeKpiResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCampaigns

        /// <summary>
        /// Retrieves information about the status, configuration, and other settings for all
        /// the campaigns that are associated with an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCampaigns service method.</param>
        /// 
        /// <returns>The response from the GetCampaigns service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetCampaigns">REST API Reference for GetCampaigns Operation</seealso>
        public virtual GetCampaignsResponse GetCampaigns(GetCampaignsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCampaignsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCampaignsResponseUnmarshaller.Instance;

            return Invoke<GetCampaignsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCampaigns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCampaigns operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCampaigns
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetCampaigns">REST API Reference for GetCampaigns Operation</seealso>
        public virtual IAsyncResult BeginGetCampaigns(GetCampaignsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCampaignsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCampaignsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCampaigns operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCampaigns.</param>
        /// 
        /// <returns>Returns a  GetCampaignsResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetCampaigns">REST API Reference for GetCampaigns Operation</seealso>
        public virtual GetCampaignsResponse EndGetCampaigns(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCampaignsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCampaignVersion

        /// <summary>
        /// Retrieves information about the status, configuration, and other settings for a specific
        /// version of a campaign.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCampaignVersion service method.</param>
        /// 
        /// <returns>The response from the GetCampaignVersion service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetCampaignVersion">REST API Reference for GetCampaignVersion Operation</seealso>
        public virtual GetCampaignVersionResponse GetCampaignVersion(GetCampaignVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCampaignVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCampaignVersionResponseUnmarshaller.Instance;

            return Invoke<GetCampaignVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCampaignVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCampaignVersion operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCampaignVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetCampaignVersion">REST API Reference for GetCampaignVersion Operation</seealso>
        public virtual IAsyncResult BeginGetCampaignVersion(GetCampaignVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCampaignVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCampaignVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCampaignVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCampaignVersion.</param>
        /// 
        /// <returns>Returns a  GetCampaignVersionResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetCampaignVersion">REST API Reference for GetCampaignVersion Operation</seealso>
        public virtual GetCampaignVersionResponse EndGetCampaignVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCampaignVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCampaignVersions

        /// <summary>
        /// Retrieves information about the status, configuration, and other settings for all
        /// versions of a campaign.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCampaignVersions service method.</param>
        /// 
        /// <returns>The response from the GetCampaignVersions service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetCampaignVersions">REST API Reference for GetCampaignVersions Operation</seealso>
        public virtual GetCampaignVersionsResponse GetCampaignVersions(GetCampaignVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCampaignVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCampaignVersionsResponseUnmarshaller.Instance;

            return Invoke<GetCampaignVersionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCampaignVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCampaignVersions operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCampaignVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetCampaignVersions">REST API Reference for GetCampaignVersions Operation</seealso>
        public virtual IAsyncResult BeginGetCampaignVersions(GetCampaignVersionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCampaignVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCampaignVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCampaignVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCampaignVersions.</param>
        /// 
        /// <returns>Returns a  GetCampaignVersionsResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetCampaignVersions">REST API Reference for GetCampaignVersions Operation</seealso>
        public virtual GetCampaignVersionsResponse EndGetCampaignVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCampaignVersionsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetChannels

        /// <summary>
        /// Retrieves information about the history and status of each channel for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChannels service method.</param>
        /// 
        /// <returns>The response from the GetChannels service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetChannels">REST API Reference for GetChannels Operation</seealso>
        public virtual GetChannelsResponse GetChannels(GetChannelsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetChannelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetChannelsResponseUnmarshaller.Instance;

            return Invoke<GetChannelsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetChannels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetChannels operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetChannels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetChannels">REST API Reference for GetChannels Operation</seealso>
        public virtual IAsyncResult BeginGetChannels(GetChannelsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetChannelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetChannelsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetChannels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetChannels.</param>
        /// 
        /// <returns>Returns a  GetChannelsResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetChannels">REST API Reference for GetChannels Operation</seealso>
        public virtual GetChannelsResponse EndGetChannels(IAsyncResult asyncResult)
        {
            return EndInvoke<GetChannelsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetEmailChannel

        /// <summary>
        /// Retrieves information about the status and settings of the email channel for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEmailChannel service method.</param>
        /// 
        /// <returns>The response from the GetEmailChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetEmailChannel">REST API Reference for GetEmailChannel Operation</seealso>
        public virtual GetEmailChannelResponse GetEmailChannel(GetEmailChannelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEmailChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEmailChannelResponseUnmarshaller.Instance;

            return Invoke<GetEmailChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetEmailChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEmailChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEmailChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetEmailChannel">REST API Reference for GetEmailChannel Operation</seealso>
        public virtual IAsyncResult BeginGetEmailChannel(GetEmailChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEmailChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEmailChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetEmailChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEmailChannel.</param>
        /// 
        /// <returns>Returns a  GetEmailChannelResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetEmailChannel">REST API Reference for GetEmailChannel Operation</seealso>
        public virtual GetEmailChannelResponse EndGetEmailChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<GetEmailChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  GetEmailTemplate

        /// <summary>
        /// Retrieves the content and settings of a message template for messages that are sent
        /// through the email channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEmailTemplate service method.</param>
        /// 
        /// <returns>The response from the GetEmailTemplate service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetEmailTemplate">REST API Reference for GetEmailTemplate Operation</seealso>
        public virtual GetEmailTemplateResponse GetEmailTemplate(GetEmailTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEmailTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEmailTemplateResponseUnmarshaller.Instance;

            return Invoke<GetEmailTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetEmailTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEmailTemplate operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEmailTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetEmailTemplate">REST API Reference for GetEmailTemplate Operation</seealso>
        public virtual IAsyncResult BeginGetEmailTemplate(GetEmailTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEmailTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEmailTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetEmailTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEmailTemplate.</param>
        /// 
        /// <returns>Returns a  GetEmailTemplateResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetEmailTemplate">REST API Reference for GetEmailTemplate Operation</seealso>
        public virtual GetEmailTemplateResponse EndGetEmailTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<GetEmailTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  GetEndpoint

        /// <summary>
        /// Retrieves information about the settings and attributes of a specific endpoint for
        /// an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEndpoint service method.</param>
        /// 
        /// <returns>The response from the GetEndpoint service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetEndpoint">REST API Reference for GetEndpoint Operation</seealso>
        public virtual GetEndpointResponse GetEndpoint(GetEndpointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEndpointResponseUnmarshaller.Instance;

            return Invoke<GetEndpointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEndpoint operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetEndpoint">REST API Reference for GetEndpoint Operation</seealso>
        public virtual IAsyncResult BeginGetEndpoint(GetEndpointRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEndpointResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEndpoint.</param>
        /// 
        /// <returns>Returns a  GetEndpointResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetEndpoint">REST API Reference for GetEndpoint Operation</seealso>
        public virtual GetEndpointResponse EndGetEndpoint(IAsyncResult asyncResult)
        {
            return EndInvoke<GetEndpointResponse>(asyncResult);
        }

        #endregion
        
        #region  GetEventStream

        /// <summary>
        /// Retrieves information about the event stream settings for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEventStream service method.</param>
        /// 
        /// <returns>The response from the GetEventStream service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetEventStream">REST API Reference for GetEventStream Operation</seealso>
        public virtual GetEventStreamResponse GetEventStream(GetEventStreamRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEventStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEventStreamResponseUnmarshaller.Instance;

            return Invoke<GetEventStreamResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetEventStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEventStream operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEventStream
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetEventStream">REST API Reference for GetEventStream Operation</seealso>
        public virtual IAsyncResult BeginGetEventStream(GetEventStreamRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEventStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEventStreamResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetEventStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEventStream.</param>
        /// 
        /// <returns>Returns a  GetEventStreamResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetEventStream">REST API Reference for GetEventStream Operation</seealso>
        public virtual GetEventStreamResponse EndGetEventStream(IAsyncResult asyncResult)
        {
            return EndInvoke<GetEventStreamResponse>(asyncResult);
        }

        #endregion
        
        #region  GetExportJob

        /// <summary>
        /// Retrieves information about the status and settings of a specific export job for an
        /// application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExportJob service method.</param>
        /// 
        /// <returns>The response from the GetExportJob service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetExportJob">REST API Reference for GetExportJob Operation</seealso>
        public virtual GetExportJobResponse GetExportJob(GetExportJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExportJobResponseUnmarshaller.Instance;

            return Invoke<GetExportJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetExportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetExportJob operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetExportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetExportJob">REST API Reference for GetExportJob Operation</seealso>
        public virtual IAsyncResult BeginGetExportJob(GetExportJobRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetExportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExportJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetExportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetExportJob.</param>
        /// 
        /// <returns>Returns a  GetExportJobResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetExportJob">REST API Reference for GetExportJob Operation</seealso>
        public virtual GetExportJobResponse EndGetExportJob(IAsyncResult asyncResult)
        {
            return EndInvoke<GetExportJobResponse>(asyncResult);
        }

        #endregion
        
        #region  GetExportJobs

        /// <summary>
        /// Retrieves information about the status and settings of all the export jobs for an
        /// application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExportJobs service method.</param>
        /// 
        /// <returns>The response from the GetExportJobs service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetExportJobs">REST API Reference for GetExportJobs Operation</seealso>
        public virtual GetExportJobsResponse GetExportJobs(GetExportJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetExportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExportJobsResponseUnmarshaller.Instance;

            return Invoke<GetExportJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetExportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetExportJobs operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetExportJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetExportJobs">REST API Reference for GetExportJobs Operation</seealso>
        public virtual IAsyncResult BeginGetExportJobs(GetExportJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetExportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetExportJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetExportJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetExportJobs.</param>
        /// 
        /// <returns>Returns a  GetExportJobsResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetExportJobs">REST API Reference for GetExportJobs Operation</seealso>
        public virtual GetExportJobsResponse EndGetExportJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<GetExportJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetGcmChannel

        /// <summary>
        /// Retrieves information about the status and settings of the GCM channel for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGcmChannel service method.</param>
        /// 
        /// <returns>The response from the GetGcmChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetGcmChannel">REST API Reference for GetGcmChannel Operation</seealso>
        public virtual GetGcmChannelResponse GetGcmChannel(GetGcmChannelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGcmChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGcmChannelResponseUnmarshaller.Instance;

            return Invoke<GetGcmChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetGcmChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGcmChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGcmChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetGcmChannel">REST API Reference for GetGcmChannel Operation</seealso>
        public virtual IAsyncResult BeginGetGcmChannel(GetGcmChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetGcmChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGcmChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetGcmChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGcmChannel.</param>
        /// 
        /// <returns>Returns a  GetGcmChannelResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetGcmChannel">REST API Reference for GetGcmChannel Operation</seealso>
        public virtual GetGcmChannelResponse EndGetGcmChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<GetGcmChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  GetImportJob

        /// <summary>
        /// Retrieves information about the status and settings of a specific import job for an
        /// application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetImportJob service method.</param>
        /// 
        /// <returns>The response from the GetImportJob service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetImportJob">REST API Reference for GetImportJob Operation</seealso>
        public virtual GetImportJobResponse GetImportJob(GetImportJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImportJobResponseUnmarshaller.Instance;

            return Invoke<GetImportJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetImportJob operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetImportJob">REST API Reference for GetImportJob Operation</seealso>
        public virtual IAsyncResult BeginGetImportJob(GetImportJobRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetImportJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImportJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetImportJob.</param>
        /// 
        /// <returns>Returns a  GetImportJobResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetImportJob">REST API Reference for GetImportJob Operation</seealso>
        public virtual GetImportJobResponse EndGetImportJob(IAsyncResult asyncResult)
        {
            return EndInvoke<GetImportJobResponse>(asyncResult);
        }

        #endregion
        
        #region  GetImportJobs

        /// <summary>
        /// Retrieves information about the status and settings of all the import jobs for an
        /// application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetImportJobs service method.</param>
        /// 
        /// <returns>The response from the GetImportJobs service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetImportJobs">REST API Reference for GetImportJobs Operation</seealso>
        public virtual GetImportJobsResponse GetImportJobs(GetImportJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImportJobsResponseUnmarshaller.Instance;

            return Invoke<GetImportJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetImportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetImportJobs operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetImportJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetImportJobs">REST API Reference for GetImportJobs Operation</seealso>
        public virtual IAsyncResult BeginGetImportJobs(GetImportJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetImportJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetImportJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetImportJobs.</param>
        /// 
        /// <returns>Returns a  GetImportJobsResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetImportJobs">REST API Reference for GetImportJobs Operation</seealso>
        public virtual GetImportJobsResponse EndGetImportJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<GetImportJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetInAppMessages

        /// <summary>
        /// Retrieves the in-app messages targeted for the provided endpoint ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInAppMessages service method.</param>
        /// 
        /// <returns>The response from the GetInAppMessages service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetInAppMessages">REST API Reference for GetInAppMessages Operation</seealso>
        public virtual GetInAppMessagesResponse GetInAppMessages(GetInAppMessagesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetInAppMessagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInAppMessagesResponseUnmarshaller.Instance;

            return Invoke<GetInAppMessagesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetInAppMessages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInAppMessages operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInAppMessages
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetInAppMessages">REST API Reference for GetInAppMessages Operation</seealso>
        public virtual IAsyncResult BeginGetInAppMessages(GetInAppMessagesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetInAppMessagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInAppMessagesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetInAppMessages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInAppMessages.</param>
        /// 
        /// <returns>Returns a  GetInAppMessagesResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetInAppMessages">REST API Reference for GetInAppMessages Operation</seealso>
        public virtual GetInAppMessagesResponse EndGetInAppMessages(IAsyncResult asyncResult)
        {
            return EndInvoke<GetInAppMessagesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetInAppTemplate

        /// <summary>
        /// Retrieves the content and settings of a message template for messages sent through
        /// the in-app channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInAppTemplate service method.</param>
        /// 
        /// <returns>The response from the GetInAppTemplate service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetInAppTemplate">REST API Reference for GetInAppTemplate Operation</seealso>
        public virtual GetInAppTemplateResponse GetInAppTemplate(GetInAppTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetInAppTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInAppTemplateResponseUnmarshaller.Instance;

            return Invoke<GetInAppTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetInAppTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInAppTemplate operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInAppTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetInAppTemplate">REST API Reference for GetInAppTemplate Operation</seealso>
        public virtual IAsyncResult BeginGetInAppTemplate(GetInAppTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetInAppTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInAppTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetInAppTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInAppTemplate.</param>
        /// 
        /// <returns>Returns a  GetInAppTemplateResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetInAppTemplate">REST API Reference for GetInAppTemplate Operation</seealso>
        public virtual GetInAppTemplateResponse EndGetInAppTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<GetInAppTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  GetJourney

        /// <summary>
        /// Retrieves information about the status, configuration, and other settings for a journey.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJourney service method.</param>
        /// 
        /// <returns>The response from the GetJourney service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetJourney">REST API Reference for GetJourney Operation</seealso>
        public virtual GetJourneyResponse GetJourney(GetJourneyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetJourneyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJourneyResponseUnmarshaller.Instance;

            return Invoke<GetJourneyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetJourney operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetJourney operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetJourney
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetJourney">REST API Reference for GetJourney Operation</seealso>
        public virtual IAsyncResult BeginGetJourney(GetJourneyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetJourneyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJourneyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetJourney operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetJourney.</param>
        /// 
        /// <returns>Returns a  GetJourneyResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetJourney">REST API Reference for GetJourney Operation</seealso>
        public virtual GetJourneyResponse EndGetJourney(IAsyncResult asyncResult)
        {
            return EndInvoke<GetJourneyResponse>(asyncResult);
        }

        #endregion
        
        #region  GetJourneyDateRangeKpi

        /// <summary>
        /// Retrieves (queries) pre-aggregated data for a standard engagement metric that applies
        /// to a journey.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJourneyDateRangeKpi service method.</param>
        /// 
        /// <returns>The response from the GetJourneyDateRangeKpi service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetJourneyDateRangeKpi">REST API Reference for GetJourneyDateRangeKpi Operation</seealso>
        public virtual GetJourneyDateRangeKpiResponse GetJourneyDateRangeKpi(GetJourneyDateRangeKpiRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetJourneyDateRangeKpiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJourneyDateRangeKpiResponseUnmarshaller.Instance;

            return Invoke<GetJourneyDateRangeKpiResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetJourneyDateRangeKpi operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetJourneyDateRangeKpi operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetJourneyDateRangeKpi
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetJourneyDateRangeKpi">REST API Reference for GetJourneyDateRangeKpi Operation</seealso>
        public virtual IAsyncResult BeginGetJourneyDateRangeKpi(GetJourneyDateRangeKpiRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetJourneyDateRangeKpiRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJourneyDateRangeKpiResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetJourneyDateRangeKpi operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetJourneyDateRangeKpi.</param>
        /// 
        /// <returns>Returns a  GetJourneyDateRangeKpiResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetJourneyDateRangeKpi">REST API Reference for GetJourneyDateRangeKpi Operation</seealso>
        public virtual GetJourneyDateRangeKpiResponse EndGetJourneyDateRangeKpi(IAsyncResult asyncResult)
        {
            return EndInvoke<GetJourneyDateRangeKpiResponse>(asyncResult);
        }

        #endregion
        
        #region  GetJourneyExecutionActivityMetrics

        /// <summary>
        /// Retrieves (queries) pre-aggregated data for a standard execution metric that applies
        /// to a journey activity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJourneyExecutionActivityMetrics service method.</param>
        /// 
        /// <returns>The response from the GetJourneyExecutionActivityMetrics service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetJourneyExecutionActivityMetrics">REST API Reference for GetJourneyExecutionActivityMetrics Operation</seealso>
        public virtual GetJourneyExecutionActivityMetricsResponse GetJourneyExecutionActivityMetrics(GetJourneyExecutionActivityMetricsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetJourneyExecutionActivityMetricsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJourneyExecutionActivityMetricsResponseUnmarshaller.Instance;

            return Invoke<GetJourneyExecutionActivityMetricsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetJourneyExecutionActivityMetrics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetJourneyExecutionActivityMetrics operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetJourneyExecutionActivityMetrics
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetJourneyExecutionActivityMetrics">REST API Reference for GetJourneyExecutionActivityMetrics Operation</seealso>
        public virtual IAsyncResult BeginGetJourneyExecutionActivityMetrics(GetJourneyExecutionActivityMetricsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetJourneyExecutionActivityMetricsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJourneyExecutionActivityMetricsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetJourneyExecutionActivityMetrics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetJourneyExecutionActivityMetrics.</param>
        /// 
        /// <returns>Returns a  GetJourneyExecutionActivityMetricsResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetJourneyExecutionActivityMetrics">REST API Reference for GetJourneyExecutionActivityMetrics Operation</seealso>
        public virtual GetJourneyExecutionActivityMetricsResponse EndGetJourneyExecutionActivityMetrics(IAsyncResult asyncResult)
        {
            return EndInvoke<GetJourneyExecutionActivityMetricsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetJourneyExecutionMetrics

        /// <summary>
        /// Retrieves (queries) pre-aggregated data for a standard execution metric that applies
        /// to a journey.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJourneyExecutionMetrics service method.</param>
        /// 
        /// <returns>The response from the GetJourneyExecutionMetrics service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetJourneyExecutionMetrics">REST API Reference for GetJourneyExecutionMetrics Operation</seealso>
        public virtual GetJourneyExecutionMetricsResponse GetJourneyExecutionMetrics(GetJourneyExecutionMetricsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetJourneyExecutionMetricsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJourneyExecutionMetricsResponseUnmarshaller.Instance;

            return Invoke<GetJourneyExecutionMetricsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetJourneyExecutionMetrics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetJourneyExecutionMetrics operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetJourneyExecutionMetrics
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetJourneyExecutionMetrics">REST API Reference for GetJourneyExecutionMetrics Operation</seealso>
        public virtual IAsyncResult BeginGetJourneyExecutionMetrics(GetJourneyExecutionMetricsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetJourneyExecutionMetricsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJourneyExecutionMetricsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetJourneyExecutionMetrics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetJourneyExecutionMetrics.</param>
        /// 
        /// <returns>Returns a  GetJourneyExecutionMetricsResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetJourneyExecutionMetrics">REST API Reference for GetJourneyExecutionMetrics Operation</seealso>
        public virtual GetJourneyExecutionMetricsResponse EndGetJourneyExecutionMetrics(IAsyncResult asyncResult)
        {
            return EndInvoke<GetJourneyExecutionMetricsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetJourneyRunExecutionActivityMetrics

        /// <summary>
        /// Retrieves (queries) pre-aggregated data for a standard run execution metric that applies
        /// to a journey activity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJourneyRunExecutionActivityMetrics service method.</param>
        /// 
        /// <returns>The response from the GetJourneyRunExecutionActivityMetrics service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetJourneyRunExecutionActivityMetrics">REST API Reference for GetJourneyRunExecutionActivityMetrics Operation</seealso>
        public virtual GetJourneyRunExecutionActivityMetricsResponse GetJourneyRunExecutionActivityMetrics(GetJourneyRunExecutionActivityMetricsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetJourneyRunExecutionActivityMetricsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJourneyRunExecutionActivityMetricsResponseUnmarshaller.Instance;

            return Invoke<GetJourneyRunExecutionActivityMetricsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetJourneyRunExecutionActivityMetrics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetJourneyRunExecutionActivityMetrics operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetJourneyRunExecutionActivityMetrics
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetJourneyRunExecutionActivityMetrics">REST API Reference for GetJourneyRunExecutionActivityMetrics Operation</seealso>
        public virtual IAsyncResult BeginGetJourneyRunExecutionActivityMetrics(GetJourneyRunExecutionActivityMetricsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetJourneyRunExecutionActivityMetricsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJourneyRunExecutionActivityMetricsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetJourneyRunExecutionActivityMetrics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetJourneyRunExecutionActivityMetrics.</param>
        /// 
        /// <returns>Returns a  GetJourneyRunExecutionActivityMetricsResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetJourneyRunExecutionActivityMetrics">REST API Reference for GetJourneyRunExecutionActivityMetrics Operation</seealso>
        public virtual GetJourneyRunExecutionActivityMetricsResponse EndGetJourneyRunExecutionActivityMetrics(IAsyncResult asyncResult)
        {
            return EndInvoke<GetJourneyRunExecutionActivityMetricsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetJourneyRunExecutionMetrics

        /// <summary>
        /// Retrieves (queries) pre-aggregated data for a standard run execution metric that applies
        /// to a journey.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJourneyRunExecutionMetrics service method.</param>
        /// 
        /// <returns>The response from the GetJourneyRunExecutionMetrics service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetJourneyRunExecutionMetrics">REST API Reference for GetJourneyRunExecutionMetrics Operation</seealso>
        public virtual GetJourneyRunExecutionMetricsResponse GetJourneyRunExecutionMetrics(GetJourneyRunExecutionMetricsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetJourneyRunExecutionMetricsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJourneyRunExecutionMetricsResponseUnmarshaller.Instance;

            return Invoke<GetJourneyRunExecutionMetricsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetJourneyRunExecutionMetrics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetJourneyRunExecutionMetrics operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetJourneyRunExecutionMetrics
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetJourneyRunExecutionMetrics">REST API Reference for GetJourneyRunExecutionMetrics Operation</seealso>
        public virtual IAsyncResult BeginGetJourneyRunExecutionMetrics(GetJourneyRunExecutionMetricsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetJourneyRunExecutionMetricsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJourneyRunExecutionMetricsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetJourneyRunExecutionMetrics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetJourneyRunExecutionMetrics.</param>
        /// 
        /// <returns>Returns a  GetJourneyRunExecutionMetricsResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetJourneyRunExecutionMetrics">REST API Reference for GetJourneyRunExecutionMetrics Operation</seealso>
        public virtual GetJourneyRunExecutionMetricsResponse EndGetJourneyRunExecutionMetrics(IAsyncResult asyncResult)
        {
            return EndInvoke<GetJourneyRunExecutionMetricsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetJourneyRuns

        /// <summary>
        /// Provides information about the runs of a journey.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJourneyRuns service method.</param>
        /// 
        /// <returns>The response from the GetJourneyRuns service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetJourneyRuns">REST API Reference for GetJourneyRuns Operation</seealso>
        public virtual GetJourneyRunsResponse GetJourneyRuns(GetJourneyRunsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetJourneyRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJourneyRunsResponseUnmarshaller.Instance;

            return Invoke<GetJourneyRunsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetJourneyRuns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetJourneyRuns operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetJourneyRuns
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetJourneyRuns">REST API Reference for GetJourneyRuns Operation</seealso>
        public virtual IAsyncResult BeginGetJourneyRuns(GetJourneyRunsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetJourneyRunsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJourneyRunsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetJourneyRuns operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetJourneyRuns.</param>
        /// 
        /// <returns>Returns a  GetJourneyRunsResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetJourneyRuns">REST API Reference for GetJourneyRuns Operation</seealso>
        public virtual GetJourneyRunsResponse EndGetJourneyRuns(IAsyncResult asyncResult)
        {
            return EndInvoke<GetJourneyRunsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPushTemplate

        /// <summary>
        /// Retrieves the content and settings of a message template for messages that are sent
        /// through a push notification channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPushTemplate service method.</param>
        /// 
        /// <returns>The response from the GetPushTemplate service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetPushTemplate">REST API Reference for GetPushTemplate Operation</seealso>
        public virtual GetPushTemplateResponse GetPushTemplate(GetPushTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPushTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPushTemplateResponseUnmarshaller.Instance;

            return Invoke<GetPushTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPushTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPushTemplate operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPushTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetPushTemplate">REST API Reference for GetPushTemplate Operation</seealso>
        public virtual IAsyncResult BeginGetPushTemplate(GetPushTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPushTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPushTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPushTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPushTemplate.</param>
        /// 
        /// <returns>Returns a  GetPushTemplateResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetPushTemplate">REST API Reference for GetPushTemplate Operation</seealso>
        public virtual GetPushTemplateResponse EndGetPushTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPushTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRecommenderConfiguration

        /// <summary>
        /// Retrieves information about an Amazon Pinpoint configuration for a recommender model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRecommenderConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetRecommenderConfiguration service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetRecommenderConfiguration">REST API Reference for GetRecommenderConfiguration Operation</seealso>
        public virtual GetRecommenderConfigurationResponse GetRecommenderConfiguration(GetRecommenderConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRecommenderConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRecommenderConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetRecommenderConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRecommenderConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRecommenderConfiguration operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRecommenderConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetRecommenderConfiguration">REST API Reference for GetRecommenderConfiguration Operation</seealso>
        public virtual IAsyncResult BeginGetRecommenderConfiguration(GetRecommenderConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRecommenderConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRecommenderConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRecommenderConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRecommenderConfiguration.</param>
        /// 
        /// <returns>Returns a  GetRecommenderConfigurationResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetRecommenderConfiguration">REST API Reference for GetRecommenderConfiguration Operation</seealso>
        public virtual GetRecommenderConfigurationResponse EndGetRecommenderConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRecommenderConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRecommenderConfigurations

        /// <summary>
        /// Retrieves information about all the recommender model configurations that are associated
        /// with your Amazon Pinpoint account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRecommenderConfigurations service method.</param>
        /// 
        /// <returns>The response from the GetRecommenderConfigurations service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetRecommenderConfigurations">REST API Reference for GetRecommenderConfigurations Operation</seealso>
        public virtual GetRecommenderConfigurationsResponse GetRecommenderConfigurations(GetRecommenderConfigurationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRecommenderConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRecommenderConfigurationsResponseUnmarshaller.Instance;

            return Invoke<GetRecommenderConfigurationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRecommenderConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRecommenderConfigurations operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRecommenderConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetRecommenderConfigurations">REST API Reference for GetRecommenderConfigurations Operation</seealso>
        public virtual IAsyncResult BeginGetRecommenderConfigurations(GetRecommenderConfigurationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRecommenderConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRecommenderConfigurationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRecommenderConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRecommenderConfigurations.</param>
        /// 
        /// <returns>Returns a  GetRecommenderConfigurationsResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetRecommenderConfigurations">REST API Reference for GetRecommenderConfigurations Operation</seealso>
        public virtual GetRecommenderConfigurationsResponse EndGetRecommenderConfigurations(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRecommenderConfigurationsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSegment

        /// <summary>
        /// Retrieves information about the configuration, dimension, and other settings for a
        /// specific segment that's associated with an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSegment service method.</param>
        /// 
        /// <returns>The response from the GetSegment service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetSegment">REST API Reference for GetSegment Operation</seealso>
        public virtual GetSegmentResponse GetSegment(GetSegmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSegmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSegmentResponseUnmarshaller.Instance;

            return Invoke<GetSegmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSegment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSegment operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSegment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetSegment">REST API Reference for GetSegment Operation</seealso>
        public virtual IAsyncResult BeginGetSegment(GetSegmentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSegmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSegmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSegment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSegment.</param>
        /// 
        /// <returns>Returns a  GetSegmentResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetSegment">REST API Reference for GetSegment Operation</seealso>
        public virtual GetSegmentResponse EndGetSegment(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSegmentResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSegmentExportJobs

        /// <summary>
        /// Retrieves information about the status and settings of the export jobs for a segment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentExportJobs service method.</param>
        /// 
        /// <returns>The response from the GetSegmentExportJobs service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetSegmentExportJobs">REST API Reference for GetSegmentExportJobs Operation</seealso>
        public virtual GetSegmentExportJobsResponse GetSegmentExportJobs(GetSegmentExportJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSegmentExportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSegmentExportJobsResponseUnmarshaller.Instance;

            return Invoke<GetSegmentExportJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSegmentExportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentExportJobs operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSegmentExportJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetSegmentExportJobs">REST API Reference for GetSegmentExportJobs Operation</seealso>
        public virtual IAsyncResult BeginGetSegmentExportJobs(GetSegmentExportJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSegmentExportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSegmentExportJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSegmentExportJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSegmentExportJobs.</param>
        /// 
        /// <returns>Returns a  GetSegmentExportJobsResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetSegmentExportJobs">REST API Reference for GetSegmentExportJobs Operation</seealso>
        public virtual GetSegmentExportJobsResponse EndGetSegmentExportJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSegmentExportJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSegmentImportJobs

        /// <summary>
        /// Retrieves information about the status and settings of the import jobs for a segment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentImportJobs service method.</param>
        /// 
        /// <returns>The response from the GetSegmentImportJobs service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetSegmentImportJobs">REST API Reference for GetSegmentImportJobs Operation</seealso>
        public virtual GetSegmentImportJobsResponse GetSegmentImportJobs(GetSegmentImportJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSegmentImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSegmentImportJobsResponseUnmarshaller.Instance;

            return Invoke<GetSegmentImportJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSegmentImportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentImportJobs operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSegmentImportJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetSegmentImportJobs">REST API Reference for GetSegmentImportJobs Operation</seealso>
        public virtual IAsyncResult BeginGetSegmentImportJobs(GetSegmentImportJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSegmentImportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSegmentImportJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSegmentImportJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSegmentImportJobs.</param>
        /// 
        /// <returns>Returns a  GetSegmentImportJobsResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetSegmentImportJobs">REST API Reference for GetSegmentImportJobs Operation</seealso>
        public virtual GetSegmentImportJobsResponse EndGetSegmentImportJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSegmentImportJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSegments

        /// <summary>
        /// Retrieves information about the configuration, dimension, and other settings for all
        /// the segments that are associated with an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSegments service method.</param>
        /// 
        /// <returns>The response from the GetSegments service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetSegments">REST API Reference for GetSegments Operation</seealso>
        public virtual GetSegmentsResponse GetSegments(GetSegmentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSegmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSegmentsResponseUnmarshaller.Instance;

            return Invoke<GetSegmentsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSegments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSegments operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSegments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetSegments">REST API Reference for GetSegments Operation</seealso>
        public virtual IAsyncResult BeginGetSegments(GetSegmentsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSegmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSegmentsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSegments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSegments.</param>
        /// 
        /// <returns>Returns a  GetSegmentsResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetSegments">REST API Reference for GetSegments Operation</seealso>
        public virtual GetSegmentsResponse EndGetSegments(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSegmentsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSegmentVersion

        /// <summary>
        /// Retrieves information about the configuration, dimension, and other settings for a
        /// specific version of a segment that's associated with an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentVersion service method.</param>
        /// 
        /// <returns>The response from the GetSegmentVersion service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetSegmentVersion">REST API Reference for GetSegmentVersion Operation</seealso>
        public virtual GetSegmentVersionResponse GetSegmentVersion(GetSegmentVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSegmentVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSegmentVersionResponseUnmarshaller.Instance;

            return Invoke<GetSegmentVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSegmentVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentVersion operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSegmentVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetSegmentVersion">REST API Reference for GetSegmentVersion Operation</seealso>
        public virtual IAsyncResult BeginGetSegmentVersion(GetSegmentVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSegmentVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSegmentVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSegmentVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSegmentVersion.</param>
        /// 
        /// <returns>Returns a  GetSegmentVersionResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetSegmentVersion">REST API Reference for GetSegmentVersion Operation</seealso>
        public virtual GetSegmentVersionResponse EndGetSegmentVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSegmentVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSegmentVersions

        /// <summary>
        /// Retrieves information about the configuration, dimension, and other settings for all
        /// the versions of a specific segment that's associated with an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentVersions service method.</param>
        /// 
        /// <returns>The response from the GetSegmentVersions service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetSegmentVersions">REST API Reference for GetSegmentVersions Operation</seealso>
        public virtual GetSegmentVersionsResponse GetSegmentVersions(GetSegmentVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSegmentVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSegmentVersionsResponseUnmarshaller.Instance;

            return Invoke<GetSegmentVersionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSegmentVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSegmentVersions operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSegmentVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetSegmentVersions">REST API Reference for GetSegmentVersions Operation</seealso>
        public virtual IAsyncResult BeginGetSegmentVersions(GetSegmentVersionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSegmentVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSegmentVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSegmentVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSegmentVersions.</param>
        /// 
        /// <returns>Returns a  GetSegmentVersionsResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetSegmentVersions">REST API Reference for GetSegmentVersions Operation</seealso>
        public virtual GetSegmentVersionsResponse EndGetSegmentVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSegmentVersionsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSmsChannel

        /// <summary>
        /// Retrieves information about the status and settings of the SMS channel for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSmsChannel service method.</param>
        /// 
        /// <returns>The response from the GetSmsChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetSmsChannel">REST API Reference for GetSmsChannel Operation</seealso>
        public virtual GetSmsChannelResponse GetSmsChannel(GetSmsChannelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSmsChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSmsChannelResponseUnmarshaller.Instance;

            return Invoke<GetSmsChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSmsChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSmsChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSmsChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetSmsChannel">REST API Reference for GetSmsChannel Operation</seealso>
        public virtual IAsyncResult BeginGetSmsChannel(GetSmsChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSmsChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSmsChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSmsChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSmsChannel.</param>
        /// 
        /// <returns>Returns a  GetSmsChannelResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetSmsChannel">REST API Reference for GetSmsChannel Operation</seealso>
        public virtual GetSmsChannelResponse EndGetSmsChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSmsChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSmsTemplate

        /// <summary>
        /// Retrieves the content and settings of a message template for messages that are sent
        /// through the SMS channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSmsTemplate service method.</param>
        /// 
        /// <returns>The response from the GetSmsTemplate service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetSmsTemplate">REST API Reference for GetSmsTemplate Operation</seealso>
        public virtual GetSmsTemplateResponse GetSmsTemplate(GetSmsTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSmsTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSmsTemplateResponseUnmarshaller.Instance;

            return Invoke<GetSmsTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSmsTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSmsTemplate operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSmsTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetSmsTemplate">REST API Reference for GetSmsTemplate Operation</seealso>
        public virtual IAsyncResult BeginGetSmsTemplate(GetSmsTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSmsTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSmsTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSmsTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSmsTemplate.</param>
        /// 
        /// <returns>Returns a  GetSmsTemplateResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetSmsTemplate">REST API Reference for GetSmsTemplate Operation</seealso>
        public virtual GetSmsTemplateResponse EndGetSmsTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSmsTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  GetUserEndpoints

        /// <summary>
        /// Retrieves information about all the endpoints that are associated with a specific
        /// user ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUserEndpoints service method.</param>
        /// 
        /// <returns>The response from the GetUserEndpoints service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetUserEndpoints">REST API Reference for GetUserEndpoints Operation</seealso>
        public virtual GetUserEndpointsResponse GetUserEndpoints(GetUserEndpointsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetUserEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserEndpointsResponseUnmarshaller.Instance;

            return Invoke<GetUserEndpointsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetUserEndpoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUserEndpoints operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUserEndpoints
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetUserEndpoints">REST API Reference for GetUserEndpoints Operation</seealso>
        public virtual IAsyncResult BeginGetUserEndpoints(GetUserEndpointsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetUserEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUserEndpointsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetUserEndpoints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUserEndpoints.</param>
        /// 
        /// <returns>Returns a  GetUserEndpointsResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetUserEndpoints">REST API Reference for GetUserEndpoints Operation</seealso>
        public virtual GetUserEndpointsResponse EndGetUserEndpoints(IAsyncResult asyncResult)
        {
            return EndInvoke<GetUserEndpointsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetVoiceChannel

        /// <summary>
        /// Retrieves information about the status and settings of the voice channel for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceChannel service method.</param>
        /// 
        /// <returns>The response from the GetVoiceChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetVoiceChannel">REST API Reference for GetVoiceChannel Operation</seealso>
        public virtual GetVoiceChannelResponse GetVoiceChannel(GetVoiceChannelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetVoiceChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVoiceChannelResponseUnmarshaller.Instance;

            return Invoke<GetVoiceChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetVoiceChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVoiceChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetVoiceChannel">REST API Reference for GetVoiceChannel Operation</seealso>
        public virtual IAsyncResult BeginGetVoiceChannel(GetVoiceChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetVoiceChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVoiceChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetVoiceChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVoiceChannel.</param>
        /// 
        /// <returns>Returns a  GetVoiceChannelResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetVoiceChannel">REST API Reference for GetVoiceChannel Operation</seealso>
        public virtual GetVoiceChannelResponse EndGetVoiceChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<GetVoiceChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  GetVoiceTemplate

        /// <summary>
        /// Retrieves the content and settings of a message template for messages that are sent
        /// through the voice channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceTemplate service method.</param>
        /// 
        /// <returns>The response from the GetVoiceTemplate service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetVoiceTemplate">REST API Reference for GetVoiceTemplate Operation</seealso>
        public virtual GetVoiceTemplateResponse GetVoiceTemplate(GetVoiceTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetVoiceTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVoiceTemplateResponseUnmarshaller.Instance;

            return Invoke<GetVoiceTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetVoiceTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVoiceTemplate operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVoiceTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetVoiceTemplate">REST API Reference for GetVoiceTemplate Operation</seealso>
        public virtual IAsyncResult BeginGetVoiceTemplate(GetVoiceTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetVoiceTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVoiceTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetVoiceTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVoiceTemplate.</param>
        /// 
        /// <returns>Returns a  GetVoiceTemplateResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/GetVoiceTemplate">REST API Reference for GetVoiceTemplate Operation</seealso>
        public virtual GetVoiceTemplateResponse EndGetVoiceTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<GetVoiceTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  ListJourneys

        /// <summary>
        /// Retrieves information about the status, configuration, and other settings for all
        /// the journeys that are associated with an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJourneys service method.</param>
        /// 
        /// <returns>The response from the ListJourneys service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/ListJourneys">REST API Reference for ListJourneys Operation</seealso>
        public virtual ListJourneysResponse ListJourneys(ListJourneysRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListJourneysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJourneysResponseUnmarshaller.Instance;

            return Invoke<ListJourneysResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListJourneys operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListJourneys operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListJourneys
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/ListJourneys">REST API Reference for ListJourneys Operation</seealso>
        public virtual IAsyncResult BeginListJourneys(ListJourneysRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListJourneysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJourneysResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListJourneys operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListJourneys.</param>
        /// 
        /// <returns>Returns a  ListJourneysResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/ListJourneys">REST API Reference for ListJourneys Operation</seealso>
        public virtual ListJourneysResponse EndListJourneys(IAsyncResult asyncResult)
        {
            return EndInvoke<ListJourneysResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Retrieves all the tags (keys and values) that are associated with an application,
        /// campaign, message template, or segment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTemplates

        /// <summary>
        /// Retrieves information about all the message templates that are associated with your
        /// Amazon Pinpoint account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTemplates service method.</param>
        /// 
        /// <returns>The response from the ListTemplates service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/ListTemplates">REST API Reference for ListTemplates Operation</seealso>
        public virtual ListTemplatesResponse ListTemplates(ListTemplatesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTemplatesResponseUnmarshaller.Instance;

            return Invoke<ListTemplatesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTemplates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTemplates operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTemplates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/ListTemplates">REST API Reference for ListTemplates Operation</seealso>
        public virtual IAsyncResult BeginListTemplates(ListTemplatesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTemplatesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTemplates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTemplates.</param>
        /// 
        /// <returns>Returns a  ListTemplatesResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/ListTemplates">REST API Reference for ListTemplates Operation</seealso>
        public virtual ListTemplatesResponse EndListTemplates(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTemplatesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTemplateVersions

        /// <summary>
        /// Retrieves information about all the versions of a specific message template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTemplateVersions service method.</param>
        /// 
        /// <returns>The response from the ListTemplateVersions service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/ListTemplateVersions">REST API Reference for ListTemplateVersions Operation</seealso>
        public virtual ListTemplateVersionsResponse ListTemplateVersions(ListTemplateVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTemplateVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTemplateVersionsResponseUnmarshaller.Instance;

            return Invoke<ListTemplateVersionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTemplateVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTemplateVersions operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTemplateVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/ListTemplateVersions">REST API Reference for ListTemplateVersions Operation</seealso>
        public virtual IAsyncResult BeginListTemplateVersions(ListTemplateVersionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTemplateVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTemplateVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTemplateVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTemplateVersions.</param>
        /// 
        /// <returns>Returns a  ListTemplateVersionsResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/ListTemplateVersions">REST API Reference for ListTemplateVersions Operation</seealso>
        public virtual ListTemplateVersionsResponse EndListTemplateVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTemplateVersionsResponse>(asyncResult);
        }

        #endregion
        
        #region  PhoneNumberValidate

        /// <summary>
        /// Retrieves information about a phone number.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PhoneNumberValidate service method.</param>
        /// 
        /// <returns>The response from the PhoneNumberValidate service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/PhoneNumberValidate">REST API Reference for PhoneNumberValidate Operation</seealso>
        public virtual PhoneNumberValidateResponse PhoneNumberValidate(PhoneNumberValidateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PhoneNumberValidateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PhoneNumberValidateResponseUnmarshaller.Instance;

            return Invoke<PhoneNumberValidateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PhoneNumberValidate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PhoneNumberValidate operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPhoneNumberValidate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/PhoneNumberValidate">REST API Reference for PhoneNumberValidate Operation</seealso>
        public virtual IAsyncResult BeginPhoneNumberValidate(PhoneNumberValidateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PhoneNumberValidateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PhoneNumberValidateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PhoneNumberValidate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPhoneNumberValidate.</param>
        /// 
        /// <returns>Returns a  PhoneNumberValidateResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/PhoneNumberValidate">REST API Reference for PhoneNumberValidate Operation</seealso>
        public virtual PhoneNumberValidateResponse EndPhoneNumberValidate(IAsyncResult asyncResult)
        {
            return EndInvoke<PhoneNumberValidateResponse>(asyncResult);
        }

        #endregion
        
        #region  PutEvents

        /// <summary>
        /// Creates a new event to record for endpoints, or creates or updates endpoint data that
        /// existing events are associated with.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEvents service method.</param>
        /// 
        /// <returns>The response from the PutEvents service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/PutEvents">REST API Reference for PutEvents Operation</seealso>
        public virtual PutEventsResponse PutEvents(PutEventsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEventsResponseUnmarshaller.Instance;

            return Invoke<PutEventsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutEvents operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutEvents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/PutEvents">REST API Reference for PutEvents Operation</seealso>
        public virtual IAsyncResult BeginPutEvents(PutEventsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEventsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutEvents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutEvents.</param>
        /// 
        /// <returns>Returns a  PutEventsResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/PutEvents">REST API Reference for PutEvents Operation</seealso>
        public virtual PutEventsResponse EndPutEvents(IAsyncResult asyncResult)
        {
            return EndInvoke<PutEventsResponse>(asyncResult);
        }

        #endregion
        
        #region  PutEventStream

        /// <summary>
        /// Creates a new event stream for an application or updates the settings of an existing
        /// event stream for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEventStream service method.</param>
        /// 
        /// <returns>The response from the PutEventStream service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/PutEventStream">REST API Reference for PutEventStream Operation</seealso>
        public virtual PutEventStreamResponse PutEventStream(PutEventStreamRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutEventStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEventStreamResponseUnmarshaller.Instance;

            return Invoke<PutEventStreamResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutEventStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutEventStream operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutEventStream
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/PutEventStream">REST API Reference for PutEventStream Operation</seealso>
        public virtual IAsyncResult BeginPutEventStream(PutEventStreamRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutEventStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEventStreamResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutEventStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutEventStream.</param>
        /// 
        /// <returns>Returns a  PutEventStreamResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/PutEventStream">REST API Reference for PutEventStream Operation</seealso>
        public virtual PutEventStreamResponse EndPutEventStream(IAsyncResult asyncResult)
        {
            return EndInvoke<PutEventStreamResponse>(asyncResult);
        }

        #endregion
        
        #region  RemoveAttributes

        /// <summary>
        /// Removes one or more custom attributes, of the same attribute type, from the application.
        /// Existing endpoints still have the attributes but Amazon Pinpoint will stop capturing
        /// new or changed values for these attributes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveAttributes service method.</param>
        /// 
        /// <returns>The response from the RemoveAttributes service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/RemoveAttributes">REST API Reference for RemoveAttributes Operation</seealso>
        public virtual RemoveAttributesResponse RemoveAttributes(RemoveAttributesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveAttributesResponseUnmarshaller.Instance;

            return Invoke<RemoveAttributesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveAttributes operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/RemoveAttributes">REST API Reference for RemoveAttributes Operation</seealso>
        public virtual IAsyncResult BeginRemoveAttributes(RemoveAttributesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RemoveAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveAttributesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveAttributes.</param>
        /// 
        /// <returns>Returns a  RemoveAttributesResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/RemoveAttributes">REST API Reference for RemoveAttributes Operation</seealso>
        public virtual RemoveAttributesResponse EndRemoveAttributes(IAsyncResult asyncResult)
        {
            return EndInvoke<RemoveAttributesResponse>(asyncResult);
        }

        #endregion
        
        #region  SendMessages

        /// <summary>
        /// Creates and sends a direct message.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendMessages service method.</param>
        /// 
        /// <returns>The response from the SendMessages service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/SendMessages">REST API Reference for SendMessages Operation</seealso>
        public virtual SendMessagesResponse SendMessages(SendMessagesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SendMessagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendMessagesResponseUnmarshaller.Instance;

            return Invoke<SendMessagesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SendMessages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendMessages operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendMessages
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/SendMessages">REST API Reference for SendMessages Operation</seealso>
        public virtual IAsyncResult BeginSendMessages(SendMessagesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SendMessagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendMessagesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SendMessages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendMessages.</param>
        /// 
        /// <returns>Returns a  SendMessagesResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/SendMessages">REST API Reference for SendMessages Operation</seealso>
        public virtual SendMessagesResponse EndSendMessages(IAsyncResult asyncResult)
        {
            return EndInvoke<SendMessagesResponse>(asyncResult);
        }

        #endregion
        
        #region  SendOTPMessage

        /// <summary>
        /// Send an OTP message
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendOTPMessage service method.</param>
        /// 
        /// <returns>The response from the SendOTPMessage service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/SendOTPMessage">REST API Reference for SendOTPMessage Operation</seealso>
        public virtual SendOTPMessageResponse SendOTPMessage(SendOTPMessageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SendOTPMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendOTPMessageResponseUnmarshaller.Instance;

            return Invoke<SendOTPMessageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SendOTPMessage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendOTPMessage operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendOTPMessage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/SendOTPMessage">REST API Reference for SendOTPMessage Operation</seealso>
        public virtual IAsyncResult BeginSendOTPMessage(SendOTPMessageRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SendOTPMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendOTPMessageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SendOTPMessage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendOTPMessage.</param>
        /// 
        /// <returns>Returns a  SendOTPMessageResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/SendOTPMessage">REST API Reference for SendOTPMessage Operation</seealso>
        public virtual SendOTPMessageResponse EndSendOTPMessage(IAsyncResult asyncResult)
        {
            return EndInvoke<SendOTPMessageResponse>(asyncResult);
        }

        #endregion
        
        #region  SendUsersMessages

        /// <summary>
        /// Creates and sends a message to a list of users.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendUsersMessages service method.</param>
        /// 
        /// <returns>The response from the SendUsersMessages service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/SendUsersMessages">REST API Reference for SendUsersMessages Operation</seealso>
        public virtual SendUsersMessagesResponse SendUsersMessages(SendUsersMessagesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SendUsersMessagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendUsersMessagesResponseUnmarshaller.Instance;

            return Invoke<SendUsersMessagesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SendUsersMessages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendUsersMessages operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendUsersMessages
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/SendUsersMessages">REST API Reference for SendUsersMessages Operation</seealso>
        public virtual IAsyncResult BeginSendUsersMessages(SendUsersMessagesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SendUsersMessagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendUsersMessagesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SendUsersMessages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendUsersMessages.</param>
        /// 
        /// <returns>Returns a  SendUsersMessagesResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/SendUsersMessages">REST API Reference for SendUsersMessages Operation</seealso>
        public virtual SendUsersMessagesResponse EndSendUsersMessages(IAsyncResult asyncResult)
        {
            return EndInvoke<SendUsersMessagesResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Adds one or more tags (keys and values) to an application, campaign, message template,
        /// or segment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes one or more tags (keys and values) from an application, campaign, message
        /// template, or segment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAdmChannel

        /// <summary>
        /// Enables the ADM channel for an application or updates the status and settings of the
        /// ADM channel for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAdmChannel service method.</param>
        /// 
        /// <returns>The response from the UpdateAdmChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateAdmChannel">REST API Reference for UpdateAdmChannel Operation</seealso>
        public virtual UpdateAdmChannelResponse UpdateAdmChannel(UpdateAdmChannelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAdmChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAdmChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateAdmChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAdmChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAdmChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAdmChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateAdmChannel">REST API Reference for UpdateAdmChannel Operation</seealso>
        public virtual IAsyncResult BeginUpdateAdmChannel(UpdateAdmChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAdmChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAdmChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAdmChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAdmChannel.</param>
        /// 
        /// <returns>Returns a  UpdateAdmChannelResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateAdmChannel">REST API Reference for UpdateAdmChannel Operation</seealso>
        public virtual UpdateAdmChannelResponse EndUpdateAdmChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAdmChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateApnsChannel

        /// <summary>
        /// Enables the APNs channel for an application or updates the status and settings of
        /// the APNs channel for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApnsChannel service method.</param>
        /// 
        /// <returns>The response from the UpdateApnsChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateApnsChannel">REST API Reference for UpdateApnsChannel Operation</seealso>
        public virtual UpdateApnsChannelResponse UpdateApnsChannel(UpdateApnsChannelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApnsChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApnsChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateApnsChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApnsChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApnsChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApnsChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateApnsChannel">REST API Reference for UpdateApnsChannel Operation</seealso>
        public virtual IAsyncResult BeginUpdateApnsChannel(UpdateApnsChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApnsChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApnsChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApnsChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApnsChannel.</param>
        /// 
        /// <returns>Returns a  UpdateApnsChannelResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateApnsChannel">REST API Reference for UpdateApnsChannel Operation</seealso>
        public virtual UpdateApnsChannelResponse EndUpdateApnsChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateApnsChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateApnsSandboxChannel

        /// <summary>
        /// Enables the APNs sandbox channel for an application or updates the status and settings
        /// of the APNs sandbox channel for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApnsSandboxChannel service method.</param>
        /// 
        /// <returns>The response from the UpdateApnsSandboxChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateApnsSandboxChannel">REST API Reference for UpdateApnsSandboxChannel Operation</seealso>
        public virtual UpdateApnsSandboxChannelResponse UpdateApnsSandboxChannel(UpdateApnsSandboxChannelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApnsSandboxChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApnsSandboxChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateApnsSandboxChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApnsSandboxChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApnsSandboxChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApnsSandboxChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateApnsSandboxChannel">REST API Reference for UpdateApnsSandboxChannel Operation</seealso>
        public virtual IAsyncResult BeginUpdateApnsSandboxChannel(UpdateApnsSandboxChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApnsSandboxChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApnsSandboxChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApnsSandboxChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApnsSandboxChannel.</param>
        /// 
        /// <returns>Returns a  UpdateApnsSandboxChannelResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateApnsSandboxChannel">REST API Reference for UpdateApnsSandboxChannel Operation</seealso>
        public virtual UpdateApnsSandboxChannelResponse EndUpdateApnsSandboxChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateApnsSandboxChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateApnsVoipChannel

        /// <summary>
        /// Enables the APNs VoIP channel for an application or updates the status and settings
        /// of the APNs VoIP channel for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApnsVoipChannel service method.</param>
        /// 
        /// <returns>The response from the UpdateApnsVoipChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateApnsVoipChannel">REST API Reference for UpdateApnsVoipChannel Operation</seealso>
        public virtual UpdateApnsVoipChannelResponse UpdateApnsVoipChannel(UpdateApnsVoipChannelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApnsVoipChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApnsVoipChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateApnsVoipChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApnsVoipChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApnsVoipChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApnsVoipChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateApnsVoipChannel">REST API Reference for UpdateApnsVoipChannel Operation</seealso>
        public virtual IAsyncResult BeginUpdateApnsVoipChannel(UpdateApnsVoipChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApnsVoipChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApnsVoipChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApnsVoipChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApnsVoipChannel.</param>
        /// 
        /// <returns>Returns a  UpdateApnsVoipChannelResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateApnsVoipChannel">REST API Reference for UpdateApnsVoipChannel Operation</seealso>
        public virtual UpdateApnsVoipChannelResponse EndUpdateApnsVoipChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateApnsVoipChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateApnsVoipSandboxChannel

        /// <summary>
        /// Enables the APNs VoIP sandbox channel for an application or updates the status and
        /// settings of the APNs VoIP sandbox channel for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApnsVoipSandboxChannel service method.</param>
        /// 
        /// <returns>The response from the UpdateApnsVoipSandboxChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateApnsVoipSandboxChannel">REST API Reference for UpdateApnsVoipSandboxChannel Operation</seealso>
        public virtual UpdateApnsVoipSandboxChannelResponse UpdateApnsVoipSandboxChannel(UpdateApnsVoipSandboxChannelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApnsVoipSandboxChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApnsVoipSandboxChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateApnsVoipSandboxChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApnsVoipSandboxChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApnsVoipSandboxChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApnsVoipSandboxChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateApnsVoipSandboxChannel">REST API Reference for UpdateApnsVoipSandboxChannel Operation</seealso>
        public virtual IAsyncResult BeginUpdateApnsVoipSandboxChannel(UpdateApnsVoipSandboxChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApnsVoipSandboxChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApnsVoipSandboxChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApnsVoipSandboxChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApnsVoipSandboxChannel.</param>
        /// 
        /// <returns>Returns a  UpdateApnsVoipSandboxChannelResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateApnsVoipSandboxChannel">REST API Reference for UpdateApnsVoipSandboxChannel Operation</seealso>
        public virtual UpdateApnsVoipSandboxChannelResponse EndUpdateApnsVoipSandboxChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateApnsVoipSandboxChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateApplicationSettings

        /// <summary>
        /// Updates the settings for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplicationSettings service method.</param>
        /// 
        /// <returns>The response from the UpdateApplicationSettings service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateApplicationSettings">REST API Reference for UpdateApplicationSettings Operation</seealso>
        public virtual UpdateApplicationSettingsResponse UpdateApplicationSettings(UpdateApplicationSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApplicationSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApplicationSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdateApplicationSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApplicationSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplicationSettings operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApplicationSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateApplicationSettings">REST API Reference for UpdateApplicationSettings Operation</seealso>
        public virtual IAsyncResult BeginUpdateApplicationSettings(UpdateApplicationSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApplicationSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApplicationSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApplicationSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApplicationSettings.</param>
        /// 
        /// <returns>Returns a  UpdateApplicationSettingsResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateApplicationSettings">REST API Reference for UpdateApplicationSettings Operation</seealso>
        public virtual UpdateApplicationSettingsResponse EndUpdateApplicationSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateApplicationSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateBaiduChannel

        /// <summary>
        /// Enables the Baidu channel for an application or updates the status and settings of
        /// the Baidu channel for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBaiduChannel service method.</param>
        /// 
        /// <returns>The response from the UpdateBaiduChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateBaiduChannel">REST API Reference for UpdateBaiduChannel Operation</seealso>
        public virtual UpdateBaiduChannelResponse UpdateBaiduChannel(UpdateBaiduChannelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBaiduChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBaiduChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateBaiduChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBaiduChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBaiduChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateBaiduChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateBaiduChannel">REST API Reference for UpdateBaiduChannel Operation</seealso>
        public virtual IAsyncResult BeginUpdateBaiduChannel(UpdateBaiduChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBaiduChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBaiduChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBaiduChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBaiduChannel.</param>
        /// 
        /// <returns>Returns a  UpdateBaiduChannelResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateBaiduChannel">REST API Reference for UpdateBaiduChannel Operation</seealso>
        public virtual UpdateBaiduChannelResponse EndUpdateBaiduChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateBaiduChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateCampaign

        /// <summary>
        /// Updates the configuration and other settings for a campaign.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaign service method.</param>
        /// 
        /// <returns>The response from the UpdateCampaign service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateCampaign">REST API Reference for UpdateCampaign Operation</seealso>
        public virtual UpdateCampaignResponse UpdateCampaign(UpdateCampaignRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCampaignResponseUnmarshaller.Instance;

            return Invoke<UpdateCampaignResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCampaign operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCampaign operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCampaign
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateCampaign">REST API Reference for UpdateCampaign Operation</seealso>
        public virtual IAsyncResult BeginUpdateCampaign(UpdateCampaignRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCampaignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCampaignResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCampaign operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCampaign.</param>
        /// 
        /// <returns>Returns a  UpdateCampaignResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateCampaign">REST API Reference for UpdateCampaign Operation</seealso>
        public virtual UpdateCampaignResponse EndUpdateCampaign(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateCampaignResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateEmailChannel

        /// <summary>
        /// Enables the email channel for an application or updates the status and settings of
        /// the email channel for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEmailChannel service method.</param>
        /// 
        /// <returns>The response from the UpdateEmailChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateEmailChannel">REST API Reference for UpdateEmailChannel Operation</seealso>
        public virtual UpdateEmailChannelResponse UpdateEmailChannel(UpdateEmailChannelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEmailChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEmailChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateEmailChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEmailChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEmailChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEmailChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateEmailChannel">REST API Reference for UpdateEmailChannel Operation</seealso>
        public virtual IAsyncResult BeginUpdateEmailChannel(UpdateEmailChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEmailChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEmailChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEmailChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEmailChannel.</param>
        /// 
        /// <returns>Returns a  UpdateEmailChannelResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateEmailChannel">REST API Reference for UpdateEmailChannel Operation</seealso>
        public virtual UpdateEmailChannelResponse EndUpdateEmailChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateEmailChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateEmailTemplate

        /// <summary>
        /// Updates an existing message template for messages that are sent through the email
        /// channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEmailTemplate service method.</param>
        /// 
        /// <returns>The response from the UpdateEmailTemplate service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateEmailTemplate">REST API Reference for UpdateEmailTemplate Operation</seealso>
        public virtual UpdateEmailTemplateResponse UpdateEmailTemplate(UpdateEmailTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEmailTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEmailTemplateResponseUnmarshaller.Instance;

            return Invoke<UpdateEmailTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEmailTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEmailTemplate operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEmailTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateEmailTemplate">REST API Reference for UpdateEmailTemplate Operation</seealso>
        public virtual IAsyncResult BeginUpdateEmailTemplate(UpdateEmailTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEmailTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEmailTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEmailTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEmailTemplate.</param>
        /// 
        /// <returns>Returns a  UpdateEmailTemplateResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateEmailTemplate">REST API Reference for UpdateEmailTemplate Operation</seealso>
        public virtual UpdateEmailTemplateResponse EndUpdateEmailTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateEmailTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateEndpoint

        /// <summary>
        /// Creates a new endpoint for an application or updates the settings and attributes of
        /// an existing endpoint for an application. You can also use this operation to define
        /// custom attributes for an endpoint. If an update includes one or more values for a
        /// custom attribute, Amazon Pinpoint replaces (overwrites) any existing values with the
        /// new values.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEndpoint service method.</param>
        /// 
        /// <returns>The response from the UpdateEndpoint service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateEndpoint">REST API Reference for UpdateEndpoint Operation</seealso>
        public virtual UpdateEndpointResponse UpdateEndpoint(UpdateEndpointRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEndpointResponseUnmarshaller.Instance;

            return Invoke<UpdateEndpointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEndpoint operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateEndpoint">REST API Reference for UpdateEndpoint Operation</seealso>
        public virtual IAsyncResult BeginUpdateEndpoint(UpdateEndpointRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEndpointResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEndpoint.</param>
        /// 
        /// <returns>Returns a  UpdateEndpointResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateEndpoint">REST API Reference for UpdateEndpoint Operation</seealso>
        public virtual UpdateEndpointResponse EndUpdateEndpoint(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateEndpointResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateEndpointsBatch

        /// <summary>
        /// Creates a new batch of endpoints for an application or updates the settings and attributes
        /// of a batch of existing endpoints for an application. You can also use this operation
        /// to define custom attributes for a batch of endpoints. If an update includes one or
        /// more values for a custom attribute, Amazon Pinpoint replaces (overwrites) any existing
        /// values with the new values.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEndpointsBatch service method.</param>
        /// 
        /// <returns>The response from the UpdateEndpointsBatch service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateEndpointsBatch">REST API Reference for UpdateEndpointsBatch Operation</seealso>
        public virtual UpdateEndpointsBatchResponse UpdateEndpointsBatch(UpdateEndpointsBatchRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEndpointsBatchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEndpointsBatchResponseUnmarshaller.Instance;

            return Invoke<UpdateEndpointsBatchResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEndpointsBatch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEndpointsBatch operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEndpointsBatch
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateEndpointsBatch">REST API Reference for UpdateEndpointsBatch Operation</seealso>
        public virtual IAsyncResult BeginUpdateEndpointsBatch(UpdateEndpointsBatchRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEndpointsBatchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEndpointsBatchResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEndpointsBatch operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEndpointsBatch.</param>
        /// 
        /// <returns>Returns a  UpdateEndpointsBatchResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateEndpointsBatch">REST API Reference for UpdateEndpointsBatch Operation</seealso>
        public virtual UpdateEndpointsBatchResponse EndUpdateEndpointsBatch(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateEndpointsBatchResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateGcmChannel

        /// <summary>
        /// Enables the GCM channel for an application or updates the status and settings of the
        /// GCM channel for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGcmChannel service method.</param>
        /// 
        /// <returns>The response from the UpdateGcmChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateGcmChannel">REST API Reference for UpdateGcmChannel Operation</seealso>
        public virtual UpdateGcmChannelResponse UpdateGcmChannel(UpdateGcmChannelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGcmChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGcmChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateGcmChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGcmChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGcmChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGcmChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateGcmChannel">REST API Reference for UpdateGcmChannel Operation</seealso>
        public virtual IAsyncResult BeginUpdateGcmChannel(UpdateGcmChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGcmChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGcmChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGcmChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGcmChannel.</param>
        /// 
        /// <returns>Returns a  UpdateGcmChannelResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateGcmChannel">REST API Reference for UpdateGcmChannel Operation</seealso>
        public virtual UpdateGcmChannelResponse EndUpdateGcmChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateGcmChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateInAppTemplate

        /// <summary>
        /// Updates an existing message template for messages sent through the in-app message
        /// channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateInAppTemplate service method.</param>
        /// 
        /// <returns>The response from the UpdateInAppTemplate service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateInAppTemplate">REST API Reference for UpdateInAppTemplate Operation</seealso>
        public virtual UpdateInAppTemplateResponse UpdateInAppTemplate(UpdateInAppTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateInAppTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateInAppTemplateResponseUnmarshaller.Instance;

            return Invoke<UpdateInAppTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateInAppTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateInAppTemplate operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateInAppTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateInAppTemplate">REST API Reference for UpdateInAppTemplate Operation</seealso>
        public virtual IAsyncResult BeginUpdateInAppTemplate(UpdateInAppTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateInAppTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateInAppTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateInAppTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateInAppTemplate.</param>
        /// 
        /// <returns>Returns a  UpdateInAppTemplateResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateInAppTemplate">REST API Reference for UpdateInAppTemplate Operation</seealso>
        public virtual UpdateInAppTemplateResponse EndUpdateInAppTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateInAppTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateJourney

        /// <summary>
        /// Updates the configuration and other settings for a journey.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateJourney service method.</param>
        /// 
        /// <returns>The response from the UpdateJourney service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ConflictException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateJourney">REST API Reference for UpdateJourney Operation</seealso>
        public virtual UpdateJourneyResponse UpdateJourney(UpdateJourneyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateJourneyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateJourneyResponseUnmarshaller.Instance;

            return Invoke<UpdateJourneyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateJourney operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateJourney operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateJourney
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateJourney">REST API Reference for UpdateJourney Operation</seealso>
        public virtual IAsyncResult BeginUpdateJourney(UpdateJourneyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateJourneyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateJourneyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateJourney operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateJourney.</param>
        /// 
        /// <returns>Returns a  UpdateJourneyResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateJourney">REST API Reference for UpdateJourney Operation</seealso>
        public virtual UpdateJourneyResponse EndUpdateJourney(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateJourneyResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateJourneyState

        /// <summary>
        /// Cancels (stops) an active journey.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateJourneyState service method.</param>
        /// 
        /// <returns>The response from the UpdateJourneyState service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateJourneyState">REST API Reference for UpdateJourneyState Operation</seealso>
        public virtual UpdateJourneyStateResponse UpdateJourneyState(UpdateJourneyStateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateJourneyStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateJourneyStateResponseUnmarshaller.Instance;

            return Invoke<UpdateJourneyStateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateJourneyState operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateJourneyState operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateJourneyState
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateJourneyState">REST API Reference for UpdateJourneyState Operation</seealso>
        public virtual IAsyncResult BeginUpdateJourneyState(UpdateJourneyStateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateJourneyStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateJourneyStateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateJourneyState operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateJourneyState.</param>
        /// 
        /// <returns>Returns a  UpdateJourneyStateResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateJourneyState">REST API Reference for UpdateJourneyState Operation</seealso>
        public virtual UpdateJourneyStateResponse EndUpdateJourneyState(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateJourneyStateResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdatePushTemplate

        /// <summary>
        /// Updates an existing message template for messages that are sent through a push notification
        /// channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePushTemplate service method.</param>
        /// 
        /// <returns>The response from the UpdatePushTemplate service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdatePushTemplate">REST API Reference for UpdatePushTemplate Operation</seealso>
        public virtual UpdatePushTemplateResponse UpdatePushTemplate(UpdatePushTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePushTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePushTemplateResponseUnmarshaller.Instance;

            return Invoke<UpdatePushTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePushTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePushTemplate operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePushTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdatePushTemplate">REST API Reference for UpdatePushTemplate Operation</seealso>
        public virtual IAsyncResult BeginUpdatePushTemplate(UpdatePushTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePushTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePushTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePushTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePushTemplate.</param>
        /// 
        /// <returns>Returns a  UpdatePushTemplateResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdatePushTemplate">REST API Reference for UpdatePushTemplate Operation</seealso>
        public virtual UpdatePushTemplateResponse EndUpdatePushTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdatePushTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateRecommenderConfiguration

        /// <summary>
        /// Updates an Amazon Pinpoint configuration for a recommender model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRecommenderConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateRecommenderConfiguration service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateRecommenderConfiguration">REST API Reference for UpdateRecommenderConfiguration Operation</seealso>
        public virtual UpdateRecommenderConfigurationResponse UpdateRecommenderConfiguration(UpdateRecommenderConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRecommenderConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRecommenderConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateRecommenderConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRecommenderConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRecommenderConfiguration operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRecommenderConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateRecommenderConfiguration">REST API Reference for UpdateRecommenderConfiguration Operation</seealso>
        public virtual IAsyncResult BeginUpdateRecommenderConfiguration(UpdateRecommenderConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRecommenderConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRecommenderConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRecommenderConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRecommenderConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateRecommenderConfigurationResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateRecommenderConfiguration">REST API Reference for UpdateRecommenderConfiguration Operation</seealso>
        public virtual UpdateRecommenderConfigurationResponse EndUpdateRecommenderConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateRecommenderConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateSegment

        /// <summary>
        /// Creates a new segment for an application or updates the configuration, dimension,
        /// and other settings for an existing segment that's associated with an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSegment service method.</param>
        /// 
        /// <returns>The response from the UpdateSegment service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateSegment">REST API Reference for UpdateSegment Operation</seealso>
        public virtual UpdateSegmentResponse UpdateSegment(UpdateSegmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSegmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSegmentResponseUnmarshaller.Instance;

            return Invoke<UpdateSegmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSegment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSegment operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSegment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateSegment">REST API Reference for UpdateSegment Operation</seealso>
        public virtual IAsyncResult BeginUpdateSegment(UpdateSegmentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSegmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSegmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSegment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSegment.</param>
        /// 
        /// <returns>Returns a  UpdateSegmentResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateSegment">REST API Reference for UpdateSegment Operation</seealso>
        public virtual UpdateSegmentResponse EndUpdateSegment(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateSegmentResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateSmsChannel

        /// <summary>
        /// Enables the SMS channel for an application or updates the status and settings of the
        /// SMS channel for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSmsChannel service method.</param>
        /// 
        /// <returns>The response from the UpdateSmsChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateSmsChannel">REST API Reference for UpdateSmsChannel Operation</seealso>
        public virtual UpdateSmsChannelResponse UpdateSmsChannel(UpdateSmsChannelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSmsChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSmsChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateSmsChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSmsChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSmsChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSmsChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateSmsChannel">REST API Reference for UpdateSmsChannel Operation</seealso>
        public virtual IAsyncResult BeginUpdateSmsChannel(UpdateSmsChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSmsChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSmsChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSmsChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSmsChannel.</param>
        /// 
        /// <returns>Returns a  UpdateSmsChannelResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateSmsChannel">REST API Reference for UpdateSmsChannel Operation</seealso>
        public virtual UpdateSmsChannelResponse EndUpdateSmsChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateSmsChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateSmsTemplate

        /// <summary>
        /// Updates an existing message template for messages that are sent through the SMS channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSmsTemplate service method.</param>
        /// 
        /// <returns>The response from the UpdateSmsTemplate service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateSmsTemplate">REST API Reference for UpdateSmsTemplate Operation</seealso>
        public virtual UpdateSmsTemplateResponse UpdateSmsTemplate(UpdateSmsTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSmsTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSmsTemplateResponseUnmarshaller.Instance;

            return Invoke<UpdateSmsTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSmsTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSmsTemplate operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSmsTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateSmsTemplate">REST API Reference for UpdateSmsTemplate Operation</seealso>
        public virtual IAsyncResult BeginUpdateSmsTemplate(UpdateSmsTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSmsTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSmsTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSmsTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSmsTemplate.</param>
        /// 
        /// <returns>Returns a  UpdateSmsTemplateResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateSmsTemplate">REST API Reference for UpdateSmsTemplate Operation</seealso>
        public virtual UpdateSmsTemplateResponse EndUpdateSmsTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateSmsTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateTemplateActiveVersion

        /// <summary>
        /// Changes the status of a specific version of a message template to <i>active</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTemplateActiveVersion service method.</param>
        /// 
        /// <returns>The response from the UpdateTemplateActiveVersion service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateTemplateActiveVersion">REST API Reference for UpdateTemplateActiveVersion Operation</seealso>
        public virtual UpdateTemplateActiveVersionResponse UpdateTemplateActiveVersion(UpdateTemplateActiveVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTemplateActiveVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTemplateActiveVersionResponseUnmarshaller.Instance;

            return Invoke<UpdateTemplateActiveVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTemplateActiveVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTemplateActiveVersion operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTemplateActiveVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateTemplateActiveVersion">REST API Reference for UpdateTemplateActiveVersion Operation</seealso>
        public virtual IAsyncResult BeginUpdateTemplateActiveVersion(UpdateTemplateActiveVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTemplateActiveVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTemplateActiveVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTemplateActiveVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTemplateActiveVersion.</param>
        /// 
        /// <returns>Returns a  UpdateTemplateActiveVersionResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateTemplateActiveVersion">REST API Reference for UpdateTemplateActiveVersion Operation</seealso>
        public virtual UpdateTemplateActiveVersionResponse EndUpdateTemplateActiveVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateTemplateActiveVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateVoiceChannel

        /// <summary>
        /// Enables the voice channel for an application or updates the status and settings of
        /// the voice channel for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVoiceChannel service method.</param>
        /// 
        /// <returns>The response from the UpdateVoiceChannel service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateVoiceChannel">REST API Reference for UpdateVoiceChannel Operation</seealso>
        public virtual UpdateVoiceChannelResponse UpdateVoiceChannel(UpdateVoiceChannelRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateVoiceChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVoiceChannelResponseUnmarshaller.Instance;

            return Invoke<UpdateVoiceChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateVoiceChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateVoiceChannel operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateVoiceChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateVoiceChannel">REST API Reference for UpdateVoiceChannel Operation</seealso>
        public virtual IAsyncResult BeginUpdateVoiceChannel(UpdateVoiceChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateVoiceChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVoiceChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateVoiceChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateVoiceChannel.</param>
        /// 
        /// <returns>Returns a  UpdateVoiceChannelResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateVoiceChannel">REST API Reference for UpdateVoiceChannel Operation</seealso>
        public virtual UpdateVoiceChannelResponse EndUpdateVoiceChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateVoiceChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateVoiceTemplate

        /// <summary>
        /// Updates an existing message template for messages that are sent through the voice
        /// channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVoiceTemplate service method.</param>
        /// 
        /// <returns>The response from the UpdateVoiceTemplate service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateVoiceTemplate">REST API Reference for UpdateVoiceTemplate Operation</seealso>
        public virtual UpdateVoiceTemplateResponse UpdateVoiceTemplate(UpdateVoiceTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateVoiceTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVoiceTemplateResponseUnmarshaller.Instance;

            return Invoke<UpdateVoiceTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateVoiceTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateVoiceTemplate operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateVoiceTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateVoiceTemplate">REST API Reference for UpdateVoiceTemplate Operation</seealso>
        public virtual IAsyncResult BeginUpdateVoiceTemplate(UpdateVoiceTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateVoiceTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVoiceTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateVoiceTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateVoiceTemplate.</param>
        /// 
        /// <returns>Returns a  UpdateVoiceTemplateResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/UpdateVoiceTemplate">REST API Reference for UpdateVoiceTemplate Operation</seealso>
        public virtual UpdateVoiceTemplateResponse EndUpdateVoiceTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateVoiceTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  VerifyOTPMessage

        /// <summary>
        /// Verify an OTP
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the VerifyOTPMessage service method.</param>
        /// 
        /// <returns>The response from the VerifyOTPMessage service method, as returned by Pinpoint.</returns>
        /// <exception cref="Amazon.Pinpoint.Model.BadRequestException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.ForbiddenException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.InternalServerErrorException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.MethodNotAllowedException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.NotFoundException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.PayloadTooLargeException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <exception cref="Amazon.Pinpoint.Model.TooManyRequestsException">
        /// Provides information about an API request or response.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/VerifyOTPMessage">REST API Reference for VerifyOTPMessage Operation</seealso>
        public virtual VerifyOTPMessageResponse VerifyOTPMessage(VerifyOTPMessageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = VerifyOTPMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = VerifyOTPMessageResponseUnmarshaller.Instance;

            return Invoke<VerifyOTPMessageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the VerifyOTPMessage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the VerifyOTPMessage operation on AmazonPinpointClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndVerifyOTPMessage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/VerifyOTPMessage">REST API Reference for VerifyOTPMessage Operation</seealso>
        public virtual IAsyncResult BeginVerifyOTPMessage(VerifyOTPMessageRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = VerifyOTPMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = VerifyOTPMessageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  VerifyOTPMessage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginVerifyOTPMessage.</param>
        /// 
        /// <returns>Returns a  VerifyOTPMessageResult from Pinpoint.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-2016-12-01/VerifyOTPMessage">REST API Reference for VerifyOTPMessage Operation</seealso>
        public virtual VerifyOTPMessageResponse EndVerifyOTPMessage(IAsyncResult asyncResult)
        {
            return EndInvoke<VerifyOTPMessageResponse>(asyncResult);
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
            var resolver = new AmazonPinpointEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}