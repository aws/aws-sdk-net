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
 * Do not modify this file. This file is generated from the translate-2017-07-01.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.Translate.Model;
using Amazon.Translate.Model.Internal.MarshallTransformations;
using Amazon.Translate.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Translate
{
    /// <summary>
    /// Implementation for accessing Translate
    ///
    /// Provides translation between one source language and another of the same set of languages.
    /// </summary>
    public partial class AmazonTranslateClient : AmazonServiceClient, IAmazonTranslate
    {
        private static IServiceMetadata serviceMetadata = new AmazonTranslateMetadata();

        #region Constructors

        /// <summary>
        /// Constructs AmazonTranslateClient with the credentials loaded from the application's
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
        public AmazonTranslateClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonTranslateConfig()) { }

        /// <summary>
        /// Constructs AmazonTranslateClient with the credentials loaded from the application's
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
        public AmazonTranslateClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonTranslateConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonTranslateClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonTranslateClient Configuration Object</param>
        public AmazonTranslateClient(AmazonTranslateConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonTranslateClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonTranslateClient(AWSCredentials credentials)
            : this(credentials, new AmazonTranslateConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonTranslateClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonTranslateClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonTranslateConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonTranslateClient with AWS Credentials and an
        /// AmazonTranslateClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonTranslateClient Configuration Object</param>
        public AmazonTranslateClient(AWSCredentials credentials, AmazonTranslateConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonTranslateClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonTranslateClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonTranslateConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonTranslateClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonTranslateClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonTranslateConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonTranslateClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonTranslateClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonTranslateClient Configuration Object</param>
        public AmazonTranslateClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonTranslateConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonTranslateClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonTranslateClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonTranslateConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonTranslateClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonTranslateClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonTranslateConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonTranslateClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonTranslateClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonTranslateClient Configuration Object</param>
        public AmazonTranslateClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonTranslateConfig clientConfig)
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


        #region  CreateParallelData

        /// <summary>
        /// Creates a parallel data resource in Amazon Translate by importing an input file from
        /// Amazon S3. Parallel data files contain examples of source phrases and their translations
        /// from your translation memory. By adding parallel data, you can influence the style,
        /// tone, and word choice in your translation output.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateParallelData service method.</param>
        /// 
        /// <returns>The response from the CreateParallelData service method, as returned by Translate.</returns>
        /// <exception cref="Amazon.Translate.Model.ConflictException">
        /// There was a conflict processing the request. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InvalidParameterValueException">
        /// The value of the parameter is invalid. Review the value of the parameter you are using
        /// to correct it, and then retry your operation.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InvalidRequestException">
        /// The request that you made is invalid. Check your request to determine why it's invalid
        /// and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.LimitExceededException">
        /// The specified limit has been exceeded. Review your request and retry it with a quantity
        /// below the stated limit.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/CreateParallelData">REST API Reference for CreateParallelData Operation</seealso>
        public virtual CreateParallelDataResponse CreateParallelData(CreateParallelDataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateParallelDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateParallelDataResponseUnmarshaller.Instance;

            return Invoke<CreateParallelDataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateParallelData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateParallelData operation on AmazonTranslateClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateParallelData
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/CreateParallelData">REST API Reference for CreateParallelData Operation</seealso>
        public virtual IAsyncResult BeginCreateParallelData(CreateParallelDataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateParallelDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateParallelDataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateParallelData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateParallelData.</param>
        /// 
        /// <returns>Returns a  CreateParallelDataResult from Translate.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/CreateParallelData">REST API Reference for CreateParallelData Operation</seealso>
        public virtual CreateParallelDataResponse EndCreateParallelData(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateParallelDataResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteParallelData

        /// <summary>
        /// Deletes a parallel data resource in Amazon Translate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteParallelData service method.</param>
        /// 
        /// <returns>The response from the DeleteParallelData service method, as returned by Translate.</returns>
        /// <exception cref="Amazon.Translate.Model.ConcurrentModificationException">
        /// Another modification is being made. That modification must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.ResourceNotFoundException">
        /// The resource you are looking for has not been found. Review the resource you're looking
        /// for and see if a different resource will accomplish your needs before retrying the
        /// revised request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/DeleteParallelData">REST API Reference for DeleteParallelData Operation</seealso>
        public virtual DeleteParallelDataResponse DeleteParallelData(DeleteParallelDataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteParallelDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteParallelDataResponseUnmarshaller.Instance;

            return Invoke<DeleteParallelDataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteParallelData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteParallelData operation on AmazonTranslateClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteParallelData
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/DeleteParallelData">REST API Reference for DeleteParallelData Operation</seealso>
        public virtual IAsyncResult BeginDeleteParallelData(DeleteParallelDataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteParallelDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteParallelDataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteParallelData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteParallelData.</param>
        /// 
        /// <returns>Returns a  DeleteParallelDataResult from Translate.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/DeleteParallelData">REST API Reference for DeleteParallelData Operation</seealso>
        public virtual DeleteParallelDataResponse EndDeleteParallelData(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteParallelDataResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteTerminology

        /// <summary>
        /// A synchronous action that deletes a custom terminology.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTerminology service method.</param>
        /// 
        /// <returns>The response from the DeleteTerminology service method, as returned by Translate.</returns>
        /// <exception cref="Amazon.Translate.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InvalidParameterValueException">
        /// The value of the parameter is invalid. Review the value of the parameter you are using
        /// to correct it, and then retry your operation.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.ResourceNotFoundException">
        /// The resource you are looking for has not been found. Review the resource you're looking
        /// for and see if a different resource will accomplish your needs before retrying the
        /// revised request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/DeleteTerminology">REST API Reference for DeleteTerminology Operation</seealso>
        public virtual DeleteTerminologyResponse DeleteTerminology(DeleteTerminologyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTerminologyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTerminologyResponseUnmarshaller.Instance;

            return Invoke<DeleteTerminologyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTerminology operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTerminology operation on AmazonTranslateClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTerminology
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/DeleteTerminology">REST API Reference for DeleteTerminology Operation</seealso>
        public virtual IAsyncResult BeginDeleteTerminology(DeleteTerminologyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTerminologyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTerminologyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTerminology operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTerminology.</param>
        /// 
        /// <returns>Returns a  DeleteTerminologyResult from Translate.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/DeleteTerminology">REST API Reference for DeleteTerminology Operation</seealso>
        public virtual DeleteTerminologyResponse EndDeleteTerminology(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteTerminologyResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeTextTranslationJob

        /// <summary>
        /// Gets the properties associated with an asycnhronous batch translation job including
        /// name, ID, status, source and target languages, input/output S3 buckets, and so on.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTextTranslationJob service method.</param>
        /// 
        /// <returns>The response from the DescribeTextTranslationJob service method, as returned by Translate.</returns>
        /// <exception cref="Amazon.Translate.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.ResourceNotFoundException">
        /// The resource you are looking for has not been found. Review the resource you're looking
        /// for and see if a different resource will accomplish your needs before retrying the
        /// revised request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/DescribeTextTranslationJob">REST API Reference for DescribeTextTranslationJob Operation</seealso>
        public virtual DescribeTextTranslationJobResponse DescribeTextTranslationJob(DescribeTextTranslationJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTextTranslationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTextTranslationJobResponseUnmarshaller.Instance;

            return Invoke<DescribeTextTranslationJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTextTranslationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTextTranslationJob operation on AmazonTranslateClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTextTranslationJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/DescribeTextTranslationJob">REST API Reference for DescribeTextTranslationJob Operation</seealso>
        public virtual IAsyncResult BeginDescribeTextTranslationJob(DescribeTextTranslationJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTextTranslationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTextTranslationJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTextTranslationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTextTranslationJob.</param>
        /// 
        /// <returns>Returns a  DescribeTextTranslationJobResult from Translate.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/DescribeTextTranslationJob">REST API Reference for DescribeTextTranslationJob Operation</seealso>
        public virtual DescribeTextTranslationJobResponse EndDescribeTextTranslationJob(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeTextTranslationJobResponse>(asyncResult);
        }

        #endregion
        
        #region  GetParallelData

        /// <summary>
        /// Provides information about a parallel data resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetParallelData service method.</param>
        /// 
        /// <returns>The response from the GetParallelData service method, as returned by Translate.</returns>
        /// <exception cref="Amazon.Translate.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InvalidParameterValueException">
        /// The value of the parameter is invalid. Review the value of the parameter you are using
        /// to correct it, and then retry your operation.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.ResourceNotFoundException">
        /// The resource you are looking for has not been found. Review the resource you're looking
        /// for and see if a different resource will accomplish your needs before retrying the
        /// revised request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/GetParallelData">REST API Reference for GetParallelData Operation</seealso>
        public virtual GetParallelDataResponse GetParallelData(GetParallelDataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetParallelDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetParallelDataResponseUnmarshaller.Instance;

            return Invoke<GetParallelDataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetParallelData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetParallelData operation on AmazonTranslateClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetParallelData
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/GetParallelData">REST API Reference for GetParallelData Operation</seealso>
        public virtual IAsyncResult BeginGetParallelData(GetParallelDataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetParallelDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetParallelDataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetParallelData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetParallelData.</param>
        /// 
        /// <returns>Returns a  GetParallelDataResult from Translate.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/GetParallelData">REST API Reference for GetParallelData Operation</seealso>
        public virtual GetParallelDataResponse EndGetParallelData(IAsyncResult asyncResult)
        {
            return EndInvoke<GetParallelDataResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTerminology

        /// <summary>
        /// Retrieves a custom terminology.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTerminology service method.</param>
        /// 
        /// <returns>The response from the GetTerminology service method, as returned by Translate.</returns>
        /// <exception cref="Amazon.Translate.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InvalidParameterValueException">
        /// The value of the parameter is invalid. Review the value of the parameter you are using
        /// to correct it, and then retry your operation.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.ResourceNotFoundException">
        /// The resource you are looking for has not been found. Review the resource you're looking
        /// for and see if a different resource will accomplish your needs before retrying the
        /// revised request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/GetTerminology">REST API Reference for GetTerminology Operation</seealso>
        public virtual GetTerminologyResponse GetTerminology(GetTerminologyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTerminologyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTerminologyResponseUnmarshaller.Instance;

            return Invoke<GetTerminologyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTerminology operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTerminology operation on AmazonTranslateClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTerminology
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/GetTerminology">REST API Reference for GetTerminology Operation</seealso>
        public virtual IAsyncResult BeginGetTerminology(GetTerminologyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTerminologyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTerminologyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTerminology operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTerminology.</param>
        /// 
        /// <returns>Returns a  GetTerminologyResult from Translate.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/GetTerminology">REST API Reference for GetTerminology Operation</seealso>
        public virtual GetTerminologyResponse EndGetTerminology(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTerminologyResponse>(asyncResult);
        }

        #endregion
        
        #region  ImportTerminology

        /// <summary>
        /// Creates or updates a custom terminology, depending on whether or not one already exists
        /// for the given terminology name. Importing a terminology with the same name as an existing
        /// one will merge the terminologies based on the chosen merge strategy. Currently, the
        /// only supported merge strategy is OVERWRITE, and so the imported terminology will overwrite
        /// an existing terminology of the same name.
        /// 
        ///  
        /// <para>
        /// If you import a terminology that overwrites an existing one, the new terminology take
        /// up to 10 minutes to fully propagate and be available for use in a translation due
        /// to cache policies with the DataPlane service that performs the translations.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportTerminology service method.</param>
        /// 
        /// <returns>The response from the ImportTerminology service method, as returned by Translate.</returns>
        /// <exception cref="Amazon.Translate.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InvalidParameterValueException">
        /// The value of the parameter is invalid. Review the value of the parameter you are using
        /// to correct it, and then retry your operation.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.LimitExceededException">
        /// The specified limit has been exceeded. Review your request and retry it with a quantity
        /// below the stated limit.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/ImportTerminology">REST API Reference for ImportTerminology Operation</seealso>
        public virtual ImportTerminologyResponse ImportTerminology(ImportTerminologyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportTerminologyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportTerminologyResponseUnmarshaller.Instance;

            return Invoke<ImportTerminologyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ImportTerminology operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportTerminology operation on AmazonTranslateClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportTerminology
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/ImportTerminology">REST API Reference for ImportTerminology Operation</seealso>
        public virtual IAsyncResult BeginImportTerminology(ImportTerminologyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportTerminologyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportTerminologyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ImportTerminology operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportTerminology.</param>
        /// 
        /// <returns>Returns a  ImportTerminologyResult from Translate.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/ImportTerminology">REST API Reference for ImportTerminology Operation</seealso>
        public virtual ImportTerminologyResponse EndImportTerminology(IAsyncResult asyncResult)
        {
            return EndInvoke<ImportTerminologyResponse>(asyncResult);
        }

        #endregion
        
        #region  ListParallelData

        /// <summary>
        /// Provides a list of your parallel data resources in Amazon Translate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListParallelData service method.</param>
        /// 
        /// <returns>The response from the ListParallelData service method, as returned by Translate.</returns>
        /// <exception cref="Amazon.Translate.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InvalidParameterValueException">
        /// The value of the parameter is invalid. Review the value of the parameter you are using
        /// to correct it, and then retry your operation.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/ListParallelData">REST API Reference for ListParallelData Operation</seealso>
        public virtual ListParallelDataResponse ListParallelData(ListParallelDataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListParallelDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListParallelDataResponseUnmarshaller.Instance;

            return Invoke<ListParallelDataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListParallelData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListParallelData operation on AmazonTranslateClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListParallelData
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/ListParallelData">REST API Reference for ListParallelData Operation</seealso>
        public virtual IAsyncResult BeginListParallelData(ListParallelDataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListParallelDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListParallelDataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListParallelData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListParallelData.</param>
        /// 
        /// <returns>Returns a  ListParallelDataResult from Translate.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/ListParallelData">REST API Reference for ListParallelData Operation</seealso>
        public virtual ListParallelDataResponse EndListParallelData(IAsyncResult asyncResult)
        {
            return EndInvoke<ListParallelDataResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTerminologies

        /// <summary>
        /// Provides a list of custom terminologies associated with your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTerminologies service method.</param>
        /// 
        /// <returns>The response from the ListTerminologies service method, as returned by Translate.</returns>
        /// <exception cref="Amazon.Translate.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InvalidParameterValueException">
        /// The value of the parameter is invalid. Review the value of the parameter you are using
        /// to correct it, and then retry your operation.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/ListTerminologies">REST API Reference for ListTerminologies Operation</seealso>
        public virtual ListTerminologiesResponse ListTerminologies(ListTerminologiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTerminologiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTerminologiesResponseUnmarshaller.Instance;

            return Invoke<ListTerminologiesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTerminologies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTerminologies operation on AmazonTranslateClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTerminologies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/ListTerminologies">REST API Reference for ListTerminologies Operation</seealso>
        public virtual IAsyncResult BeginListTerminologies(ListTerminologiesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTerminologiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTerminologiesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTerminologies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTerminologies.</param>
        /// 
        /// <returns>Returns a  ListTerminologiesResult from Translate.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/ListTerminologies">REST API Reference for ListTerminologies Operation</seealso>
        public virtual ListTerminologiesResponse EndListTerminologies(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTerminologiesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTextTranslationJobs

        /// <summary>
        /// Gets a list of the batch translation jobs that you have submitted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTextTranslationJobs service method.</param>
        /// 
        /// <returns>The response from the ListTextTranslationJobs service method, as returned by Translate.</returns>
        /// <exception cref="Amazon.Translate.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InvalidFilterException">
        /// The filter specified for the operation is invalid. Specify a different filter.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InvalidRequestException">
        /// The request that you made is invalid. Check your request to determine why it's invalid
        /// and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/ListTextTranslationJobs">REST API Reference for ListTextTranslationJobs Operation</seealso>
        public virtual ListTextTranslationJobsResponse ListTextTranslationJobs(ListTextTranslationJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTextTranslationJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTextTranslationJobsResponseUnmarshaller.Instance;

            return Invoke<ListTextTranslationJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTextTranslationJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTextTranslationJobs operation on AmazonTranslateClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTextTranslationJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/ListTextTranslationJobs">REST API Reference for ListTextTranslationJobs Operation</seealso>
        public virtual IAsyncResult BeginListTextTranslationJobs(ListTextTranslationJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTextTranslationJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTextTranslationJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTextTranslationJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTextTranslationJobs.</param>
        /// 
        /// <returns>Returns a  ListTextTranslationJobsResult from Translate.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/ListTextTranslationJobs">REST API Reference for ListTextTranslationJobs Operation</seealso>
        public virtual ListTextTranslationJobsResponse EndListTextTranslationJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTextTranslationJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  StartTextTranslationJob

        /// <summary>
        /// Starts an asynchronous batch translation job. Batch translation jobs can be used to
        /// translate large volumes of text across multiple documents at once. For more information,
        /// see <a>async</a>.
        /// 
        ///  
        /// <para>
        /// Batch translation jobs can be described with the <a>DescribeTextTranslationJob</a>
        /// operation, listed with the <a>ListTextTranslationJobs</a> operation, and stopped with
        /// the <a>StopTextTranslationJob</a> operation.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Translate does not support batch translation of multiple source languages at
        /// once.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTextTranslationJob service method.</param>
        /// 
        /// <returns>The response from the StartTextTranslationJob service method, as returned by Translate.</returns>
        /// <exception cref="Amazon.Translate.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InvalidRequestException">
        /// The request that you made is invalid. Check your request to determine why it's invalid
        /// and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.ResourceNotFoundException">
        /// The resource you are looking for has not been found. Review the resource you're looking
        /// for and see if a different resource will accomplish your needs before retrying the
        /// revised request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.UnsupportedLanguagePairException">
        /// Amazon Translate does not support translation from the language of the source text
        /// into the requested target language. For more information, see <a>how-to-error-msg</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/StartTextTranslationJob">REST API Reference for StartTextTranslationJob Operation</seealso>
        public virtual StartTextTranslationJobResponse StartTextTranslationJob(StartTextTranslationJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartTextTranslationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTextTranslationJobResponseUnmarshaller.Instance;

            return Invoke<StartTextTranslationJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartTextTranslationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartTextTranslationJob operation on AmazonTranslateClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartTextTranslationJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/StartTextTranslationJob">REST API Reference for StartTextTranslationJob Operation</seealso>
        public virtual IAsyncResult BeginStartTextTranslationJob(StartTextTranslationJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartTextTranslationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTextTranslationJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartTextTranslationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartTextTranslationJob.</param>
        /// 
        /// <returns>Returns a  StartTextTranslationJobResult from Translate.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/StartTextTranslationJob">REST API Reference for StartTextTranslationJob Operation</seealso>
        public virtual StartTextTranslationJobResponse EndStartTextTranslationJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StartTextTranslationJobResponse>(asyncResult);
        }

        #endregion
        
        #region  StopTextTranslationJob

        /// <summary>
        /// Stops an asynchronous batch translation job that is in progress.
        /// 
        ///  
        /// <para>
        /// If the job's state is <code>IN_PROGRESS</code>, the job will be marked for termination
        /// and put into the <code>STOP_REQUESTED</code> state. If the job completes before it
        /// can be stopped, it is put into the <code>COMPLETED</code> state. Otherwise, the job
        /// is put into the <code>STOPPED</code> state.
        /// </para>
        ///  
        /// <para>
        /// Asynchronous batch translation jobs are started with the <a>StartTextTranslationJob</a>
        /// operation. You can use the <a>DescribeTextTranslationJob</a> or <a>ListTextTranslationJobs</a>
        /// operations to get a batch translation job's <code>JobId</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopTextTranslationJob service method.</param>
        /// 
        /// <returns>The response from the StopTextTranslationJob service method, as returned by Translate.</returns>
        /// <exception cref="Amazon.Translate.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.ResourceNotFoundException">
        /// The resource you are looking for has not been found. Review the resource you're looking
        /// for and see if a different resource will accomplish your needs before retrying the
        /// revised request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/StopTextTranslationJob">REST API Reference for StopTextTranslationJob Operation</seealso>
        public virtual StopTextTranslationJobResponse StopTextTranslationJob(StopTextTranslationJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopTextTranslationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopTextTranslationJobResponseUnmarshaller.Instance;

            return Invoke<StopTextTranslationJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopTextTranslationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopTextTranslationJob operation on AmazonTranslateClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopTextTranslationJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/StopTextTranslationJob">REST API Reference for StopTextTranslationJob Operation</seealso>
        public virtual IAsyncResult BeginStopTextTranslationJob(StopTextTranslationJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopTextTranslationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopTextTranslationJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopTextTranslationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopTextTranslationJob.</param>
        /// 
        /// <returns>Returns a  StopTextTranslationJobResult from Translate.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/StopTextTranslationJob">REST API Reference for StopTextTranslationJob Operation</seealso>
        public virtual StopTextTranslationJobResponse EndStopTextTranslationJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StopTextTranslationJobResponse>(asyncResult);
        }

        #endregion
        
        #region  TranslateText

        /// <summary>
        /// Translates input text from the source language to the target language. For a list
        /// of available languages and language codes, see <a>what-is-languages</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TranslateText service method.</param>
        /// 
        /// <returns>The response from the TranslateText service method, as returned by Translate.</returns>
        /// <exception cref="Amazon.Translate.Model.DetectedLanguageLowConfidenceException">
        /// The confidence that Amazon Comprehend accurately detected the source language is low.
        /// If a low confidence level is acceptable for your application, you can use the language
        /// in the exception to call Amazon Translate again. For more information, see the <a
        /// href="https://docs.aws.amazon.com/comprehend/latest/dg/API_DetectDominantLanguage.html">DetectDominantLanguage</a>
        /// operation in the <i>Amazon Comprehend Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InvalidRequestException">
        /// The request that you made is invalid. Check your request to determine why it's invalid
        /// and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.ResourceNotFoundException">
        /// The resource you are looking for has not been found. Review the resource you're looking
        /// for and see if a different resource will accomplish your needs before retrying the
        /// revised request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.ServiceUnavailableException">
        /// The Amazon Translate service is temporarily unavailable. Please wait a bit and then
        /// retry your request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.TextSizeLimitExceededException">
        /// The size of the text you submitted exceeds the size limit. Reduce the size of the
        /// text or use a smaller document and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.UnsupportedLanguagePairException">
        /// Amazon Translate does not support translation from the language of the source text
        /// into the requested target language. For more information, see <a>how-to-error-msg</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/TranslateText">REST API Reference for TranslateText Operation</seealso>
        public virtual TranslateTextResponse TranslateText(TranslateTextRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TranslateTextRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TranslateTextResponseUnmarshaller.Instance;

            return Invoke<TranslateTextResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TranslateText operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TranslateText operation on AmazonTranslateClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTranslateText
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/TranslateText">REST API Reference for TranslateText Operation</seealso>
        public virtual IAsyncResult BeginTranslateText(TranslateTextRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TranslateTextRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TranslateTextResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TranslateText operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTranslateText.</param>
        /// 
        /// <returns>Returns a  TranslateTextResult from Translate.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/TranslateText">REST API Reference for TranslateText Operation</seealso>
        public virtual TranslateTextResponse EndTranslateText(IAsyncResult asyncResult)
        {
            return EndInvoke<TranslateTextResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateParallelData

        /// <summary>
        /// Updates a previously created parallel data resource by importing a new input file
        /// from Amazon S3.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateParallelData service method.</param>
        /// 
        /// <returns>The response from the UpdateParallelData service method, as returned by Translate.</returns>
        /// <exception cref="Amazon.Translate.Model.ConcurrentModificationException">
        /// Another modification is being made. That modification must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.ConflictException">
        /// There was a conflict processing the request. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InvalidParameterValueException">
        /// The value of the parameter is invalid. Review the value of the parameter you are using
        /// to correct it, and then retry your operation.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InvalidRequestException">
        /// The request that you made is invalid. Check your request to determine why it's invalid
        /// and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.LimitExceededException">
        /// The specified limit has been exceeded. Review your request and retry it with a quantity
        /// below the stated limit.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.ResourceNotFoundException">
        /// The resource you are looking for has not been found. Review the resource you're looking
        /// for and see if a different resource will accomplish your needs before retrying the
        /// revised request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/UpdateParallelData">REST API Reference for UpdateParallelData Operation</seealso>
        public virtual UpdateParallelDataResponse UpdateParallelData(UpdateParallelDataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateParallelDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateParallelDataResponseUnmarshaller.Instance;

            return Invoke<UpdateParallelDataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateParallelData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateParallelData operation on AmazonTranslateClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateParallelData
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/UpdateParallelData">REST API Reference for UpdateParallelData Operation</seealso>
        public virtual IAsyncResult BeginUpdateParallelData(UpdateParallelDataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateParallelDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateParallelDataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateParallelData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateParallelData.</param>
        /// 
        /// <returns>Returns a  UpdateParallelDataResult from Translate.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/UpdateParallelData">REST API Reference for UpdateParallelData Operation</seealso>
        public virtual UpdateParallelDataResponse EndUpdateParallelData(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateParallelDataResponse>(asyncResult);
        }

        #endregion
        
    }
}