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
 * Do not modify this file. This file is generated from the polly-2016-06-10.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.Polly.Model;
using Amazon.Polly.Model.Internal.MarshallTransformations;
using Amazon.Polly.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.Polly
{
    /// <summary>
    /// <para>Implementation for accessing Polly</para>
    ///
    /// Amazon Polly is a web service that makes it easy to synthesize speech from text.
    /// 
    ///  
    /// <para>
    /// The Amazon Polly service provides API operations for synthesizing high-quality speech
    /// from plain text and Speech Synthesis Markup Language (SSML), along with managing pronunciations
    /// lexicons that enable you to get the best results for your application domain.
    /// </para>
    /// </summary>
    public partial class AmazonPollyClient : AmazonServiceClient, IAmazonPolly
    {
        private static IServiceMetadata serviceMetadata = new AmazonPollyMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IPollyPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IPollyPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new PollyPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonPollyClient with the credentials loaded from the application's
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
        public AmazonPollyClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonPollyConfig()) { }

        /// <summary>
        /// Constructs AmazonPollyClient with the credentials loaded from the application's
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
        public AmazonPollyClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonPollyConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonPollyClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonPollyClient Configuration Object</param>
        public AmazonPollyClient(AmazonPollyConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonPollyClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonPollyClient(AWSCredentials credentials)
            : this(credentials, new AmazonPollyConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPollyClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPollyClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonPollyConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPollyClient with AWS Credentials and an
        /// AmazonPollyClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonPollyClient Configuration Object</param>
        public AmazonPollyClient(AWSCredentials credentials, AmazonPollyConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPollyClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonPollyClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPollyConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPollyClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPollyClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPollyConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonPollyClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPollyClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonPollyClient Configuration Object</param>
        public AmazonPollyClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonPollyConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPollyClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonPollyClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPollyConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPollyClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPollyClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPollyConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPollyClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPollyClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonPollyClient Configuration Object</param>
        public AmazonPollyClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonPollyConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonPollyEndpointResolver());
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


        #region  DeleteLexicon

        /// <summary>
        /// Deletes the specified pronunciation lexicon stored in an Amazon Web Services Region.
        /// A lexicon which has been deleted is not available for speech synthesis, nor is it
        /// possible to retrieve it using either the <c>GetLexicon</c> or <c>ListLexicon</c> APIs.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/polly/latest/dg/managing-lexicons.html">Managing
        /// Lexicons</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLexicon service method.</param>
        /// 
        /// <returns>The response from the DeleteLexicon service method, as returned by Polly.</returns>
        /// <exception cref="Amazon.Polly.Model.LexiconNotFoundException">
        /// Amazon Polly can't find the specified lexicon. This could be caused by a lexicon that
        /// is missing, its name is misspelled or specifying a lexicon that is in a different
        /// region.
        /// 
        ///  
        /// <para>
        /// Verify that the lexicon exists, is in the region (see <a>ListLexicons</a>) and that
        /// you spelled its name is spelled correctly. Then try again.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ServiceFailureException">
        /// An unknown condition has caused a service failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/DeleteLexicon">REST API Reference for DeleteLexicon Operation</seealso>
        public virtual DeleteLexiconResponse DeleteLexicon(DeleteLexiconRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteLexiconRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLexiconResponseUnmarshaller.Instance;

            return Invoke<DeleteLexiconResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLexicon operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLexicon operation on AmazonPollyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLexicon
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/DeleteLexicon">REST API Reference for DeleteLexicon Operation</seealso>
        public virtual IAsyncResult BeginDeleteLexicon(DeleteLexiconRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteLexiconRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLexiconResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLexicon operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLexicon.</param>
        /// 
        /// <returns>Returns a  DeleteLexiconResult from Polly.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/DeleteLexicon">REST API Reference for DeleteLexicon Operation</seealso>
        public virtual DeleteLexiconResponse EndDeleteLexicon(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteLexiconResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeVoices

        /// <summary>
        /// Returns the list of voices that are available for use when requesting speech synthesis.
        /// Each voice speaks a specified language, is either male or female, and is identified
        /// by an ID, which is the ASCII version of the voice name. 
        /// 
        ///  
        /// <para>
        /// When synthesizing speech ( <c>SynthesizeSpeech</c> ), you provide the voice ID for
        /// the voice you want from the list of voices returned by <c>DescribeVoices</c>.
        /// </para>
        ///  
        /// <para>
        /// For example, you want your news reader application to read news in a specific language,
        /// but giving a user the option to choose the voice. Using the <c>DescribeVoices</c>
        /// operation you can provide the user with a list of available voices to select from.
        /// </para>
        ///  
        /// <para>
        ///  You can optionally specify a language code to filter the available voices. For example,
        /// if you specify <c>en-US</c>, the operation returns a list of all available US English
        /// voices. 
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <c>polly:DescribeVoices</c> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVoices service method.</param>
        /// 
        /// <returns>The response from the DescribeVoices service method, as returned by Polly.</returns>
        /// <exception cref="Amazon.Polly.Model.InvalidNextTokenException">
        /// The NextToken is invalid. Verify that it's spelled correctly, and then try again.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ServiceFailureException">
        /// An unknown condition has caused a service failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/DescribeVoices">REST API Reference for DescribeVoices Operation</seealso>
        public virtual DescribeVoicesResponse DescribeVoices(DescribeVoicesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeVoicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVoicesResponseUnmarshaller.Instance;

            return Invoke<DescribeVoicesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVoices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVoices operation on AmazonPollyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVoices
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/DescribeVoices">REST API Reference for DescribeVoices Operation</seealso>
        public virtual IAsyncResult BeginDescribeVoices(DescribeVoicesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeVoicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVoicesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVoices operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVoices.</param>
        /// 
        /// <returns>Returns a  DescribeVoicesResult from Polly.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/DescribeVoices">REST API Reference for DescribeVoices Operation</seealso>
        public virtual DescribeVoicesResponse EndDescribeVoices(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeVoicesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetLexicon

        /// <summary>
        /// Returns the content of the specified pronunciation lexicon stored in an Amazon Web
        /// Services Region. For more information, see <a href="https://docs.aws.amazon.com/polly/latest/dg/managing-lexicons.html">Managing
        /// Lexicons</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLexicon service method.</param>
        /// 
        /// <returns>The response from the GetLexicon service method, as returned by Polly.</returns>
        /// <exception cref="Amazon.Polly.Model.LexiconNotFoundException">
        /// Amazon Polly can't find the specified lexicon. This could be caused by a lexicon that
        /// is missing, its name is misspelled or specifying a lexicon that is in a different
        /// region.
        /// 
        ///  
        /// <para>
        /// Verify that the lexicon exists, is in the region (see <a>ListLexicons</a>) and that
        /// you spelled its name is spelled correctly. Then try again.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ServiceFailureException">
        /// An unknown condition has caused a service failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/GetLexicon">REST API Reference for GetLexicon Operation</seealso>
        public virtual GetLexiconResponse GetLexicon(GetLexiconRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetLexiconRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLexiconResponseUnmarshaller.Instance;

            return Invoke<GetLexiconResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetLexicon operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLexicon operation on AmazonPollyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLexicon
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/GetLexicon">REST API Reference for GetLexicon Operation</seealso>
        public virtual IAsyncResult BeginGetLexicon(GetLexiconRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetLexiconRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLexiconResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetLexicon operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLexicon.</param>
        /// 
        /// <returns>Returns a  GetLexiconResult from Polly.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/GetLexicon">REST API Reference for GetLexicon Operation</seealso>
        public virtual GetLexiconResponse EndGetLexicon(IAsyncResult asyncResult)
        {
            return EndInvoke<GetLexiconResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSpeechSynthesisTask

        /// <summary>
        /// Retrieves a specific SpeechSynthesisTask object based on its TaskID. This object contains
        /// information about the given speech synthesis task, including the status of the task,
        /// and a link to the S3 bucket containing the output of the task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSpeechSynthesisTask service method.</param>
        /// 
        /// <returns>The response from the GetSpeechSynthesisTask service method, as returned by Polly.</returns>
        /// <exception cref="Amazon.Polly.Model.InvalidTaskIdException">
        /// The provided Task ID is not valid. Please provide a valid Task ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ServiceFailureException">
        /// An unknown condition has caused a service failure.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.SynthesisTaskNotFoundException">
        /// The Speech Synthesis task with requested Task ID cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/GetSpeechSynthesisTask">REST API Reference for GetSpeechSynthesisTask Operation</seealso>
        public virtual GetSpeechSynthesisTaskResponse GetSpeechSynthesisTask(GetSpeechSynthesisTaskRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSpeechSynthesisTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSpeechSynthesisTaskResponseUnmarshaller.Instance;

            return Invoke<GetSpeechSynthesisTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSpeechSynthesisTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSpeechSynthesisTask operation on AmazonPollyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSpeechSynthesisTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/GetSpeechSynthesisTask">REST API Reference for GetSpeechSynthesisTask Operation</seealso>
        public virtual IAsyncResult BeginGetSpeechSynthesisTask(GetSpeechSynthesisTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSpeechSynthesisTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSpeechSynthesisTaskResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSpeechSynthesisTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSpeechSynthesisTask.</param>
        /// 
        /// <returns>Returns a  GetSpeechSynthesisTaskResult from Polly.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/GetSpeechSynthesisTask">REST API Reference for GetSpeechSynthesisTask Operation</seealso>
        public virtual GetSpeechSynthesisTaskResponse EndGetSpeechSynthesisTask(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSpeechSynthesisTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  ListLexicons

        /// <summary>
        /// Returns a list of pronunciation lexicons stored in an Amazon Web Services Region.
        /// For more information, see <a href="https://docs.aws.amazon.com/polly/latest/dg/managing-lexicons.html">Managing
        /// Lexicons</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLexicons service method.</param>
        /// 
        /// <returns>The response from the ListLexicons service method, as returned by Polly.</returns>
        /// <exception cref="Amazon.Polly.Model.InvalidNextTokenException">
        /// The NextToken is invalid. Verify that it's spelled correctly, and then try again.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ServiceFailureException">
        /// An unknown condition has caused a service failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/ListLexicons">REST API Reference for ListLexicons Operation</seealso>
        public virtual ListLexiconsResponse ListLexicons(ListLexiconsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLexiconsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLexiconsResponseUnmarshaller.Instance;

            return Invoke<ListLexiconsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListLexicons operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLexicons operation on AmazonPollyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLexicons
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/ListLexicons">REST API Reference for ListLexicons Operation</seealso>
        public virtual IAsyncResult BeginListLexicons(ListLexiconsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLexiconsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLexiconsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListLexicons operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLexicons.</param>
        /// 
        /// <returns>Returns a  ListLexiconsResult from Polly.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/ListLexicons">REST API Reference for ListLexicons Operation</seealso>
        public virtual ListLexiconsResponse EndListLexicons(IAsyncResult asyncResult)
        {
            return EndInvoke<ListLexiconsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSpeechSynthesisTasks

        /// <summary>
        /// Returns a list of SpeechSynthesisTask objects ordered by their creation date. This
        /// operation can filter the tasks by their status, for example, allowing users to list
        /// only tasks that are completed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSpeechSynthesisTasks service method.</param>
        /// 
        /// <returns>The response from the ListSpeechSynthesisTasks service method, as returned by Polly.</returns>
        /// <exception cref="Amazon.Polly.Model.InvalidNextTokenException">
        /// The NextToken is invalid. Verify that it's spelled correctly, and then try again.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ServiceFailureException">
        /// An unknown condition has caused a service failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/ListSpeechSynthesisTasks">REST API Reference for ListSpeechSynthesisTasks Operation</seealso>
        public virtual ListSpeechSynthesisTasksResponse ListSpeechSynthesisTasks(ListSpeechSynthesisTasksRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSpeechSynthesisTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSpeechSynthesisTasksResponseUnmarshaller.Instance;

            return Invoke<ListSpeechSynthesisTasksResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSpeechSynthesisTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSpeechSynthesisTasks operation on AmazonPollyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSpeechSynthesisTasks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/ListSpeechSynthesisTasks">REST API Reference for ListSpeechSynthesisTasks Operation</seealso>
        public virtual IAsyncResult BeginListSpeechSynthesisTasks(ListSpeechSynthesisTasksRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSpeechSynthesisTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSpeechSynthesisTasksResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSpeechSynthesisTasks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSpeechSynthesisTasks.</param>
        /// 
        /// <returns>Returns a  ListSpeechSynthesisTasksResult from Polly.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/ListSpeechSynthesisTasks">REST API Reference for ListSpeechSynthesisTasks Operation</seealso>
        public virtual ListSpeechSynthesisTasksResponse EndListSpeechSynthesisTasks(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSpeechSynthesisTasksResponse>(asyncResult);
        }

        #endregion
        
        #region  PutLexicon

        /// <summary>
        /// Stores a pronunciation lexicon in an Amazon Web Services Region. If a lexicon with
        /// the same name already exists in the region, it is overwritten by the new lexicon.
        /// Lexicon operations have eventual consistency, therefore, it might take some time before
        /// the lexicon is available to the SynthesizeSpeech operation.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/polly/latest/dg/managing-lexicons.html">Managing
        /// Lexicons</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutLexicon service method.</param>
        /// 
        /// <returns>The response from the PutLexicon service method, as returned by Polly.</returns>
        /// <exception cref="Amazon.Polly.Model.InvalidLexiconException">
        /// Amazon Polly can't find the specified lexicon. Verify that the lexicon's name is spelled
        /// correctly, and then try again.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.LexiconSizeExceededException">
        /// The maximum size of the specified lexicon would be exceeded by this operation.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.MaxLexemeLengthExceededException">
        /// The maximum size of the lexeme would be exceeded by this operation.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.MaxLexiconsNumberExceededException">
        /// The maximum number of lexicons would be exceeded by this operation.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ServiceFailureException">
        /// An unknown condition has caused a service failure.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.UnsupportedPlsAlphabetException">
        /// The alphabet specified by the lexicon is not a supported alphabet. Valid values are
        /// <c>x-sampa</c> and <c>ipa</c>.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.UnsupportedPlsLanguageException">
        /// The language specified in the lexicon is unsupported. For a list of supported languages,
        /// see <a href="https://docs.aws.amazon.com/polly/latest/dg/API_LexiconAttributes.html">Lexicon
        /// Attributes</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/PutLexicon">REST API Reference for PutLexicon Operation</seealso>
        public virtual PutLexiconResponse PutLexicon(PutLexiconRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutLexiconRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutLexiconResponseUnmarshaller.Instance;

            return Invoke<PutLexiconResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutLexicon operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutLexicon operation on AmazonPollyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutLexicon
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/PutLexicon">REST API Reference for PutLexicon Operation</seealso>
        public virtual IAsyncResult BeginPutLexicon(PutLexiconRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutLexiconRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutLexiconResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutLexicon operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutLexicon.</param>
        /// 
        /// <returns>Returns a  PutLexiconResult from Polly.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/PutLexicon">REST API Reference for PutLexicon Operation</seealso>
        public virtual PutLexiconResponse EndPutLexicon(IAsyncResult asyncResult)
        {
            return EndInvoke<PutLexiconResponse>(asyncResult);
        }

        #endregion
        
        #region  StartSpeechSynthesisTask

        /// <summary>
        /// Allows the creation of an asynchronous synthesis task, by starting a new <c>SpeechSynthesisTask</c>.
        /// This operation requires all the standard information needed for speech synthesis,
        /// plus the name of an Amazon S3 bucket for the service to store the output of the synthesis
        /// task and two optional parameters (<c>OutputS3KeyPrefix</c> and <c>SnsTopicArn</c>).
        /// Once the synthesis task is created, this operation will return a <c>SpeechSynthesisTask</c>
        /// object, which will include an identifier of this task as well as the current status.
        /// The <c>SpeechSynthesisTask</c> object is available for 72 hours after starting the
        /// asynchronous synthesis task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSpeechSynthesisTask service method.</param>
        /// 
        /// <returns>The response from the StartSpeechSynthesisTask service method, as returned by Polly.</returns>
        /// <exception cref="Amazon.Polly.Model.EngineNotSupportedException">
        /// This engine is not compatible with the voice that you have designated. Choose a new
        /// voice that is compatible with the engine or change the engine and restart the operation.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.InvalidS3BucketException">
        /// The provided Amazon S3 bucket name is invalid. Please check your input with S3 bucket
        /// naming requirements and try again.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.InvalidS3KeyException">
        /// The provided Amazon S3 key prefix is invalid. Please provide a valid S3 object key
        /// name.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.InvalidSampleRateException">
        /// The specified sample rate is not valid.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.InvalidSnsTopicArnException">
        /// The provided SNS topic ARN is invalid. Please provide a valid SNS topic ARN and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.InvalidSsmlException">
        /// The SSML you provided is invalid. Verify the SSML syntax, spelling of tags and values,
        /// and then try again.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.LanguageNotSupportedException">
        /// The language specified is not currently supported by Amazon Polly in this capacity.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.LexiconNotFoundException">
        /// Amazon Polly can't find the specified lexicon. This could be caused by a lexicon that
        /// is missing, its name is misspelled or specifying a lexicon that is in a different
        /// region.
        /// 
        ///  
        /// <para>
        /// Verify that the lexicon exists, is in the region (see <a>ListLexicons</a>) and that
        /// you spelled its name is spelled correctly. Then try again.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.MarksNotSupportedForFormatException">
        /// Speech marks are not supported for the <c>OutputFormat</c> selected. Speech marks
        /// are only available for content in <c>json</c> format.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ServiceFailureException">
        /// An unknown condition has caused a service failure.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.SsmlMarksNotSupportedForTextTypeException">
        /// SSML speech marks are not supported for plain text-type input.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.TextLengthExceededException">
        /// The value of the "Text" parameter is longer than the accepted limits. For the <c>SynthesizeSpeech</c>
        /// API, the limit for input text is a maximum of 6000 characters total, of which no more
        /// than 3000 can be billed characters. For the <c>StartSpeechSynthesisTask</c> API, the
        /// maximum is 200,000 characters, of which no more than 100,000 can be billed characters.
        /// SSML tags are not counted as billed characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/StartSpeechSynthesisTask">REST API Reference for StartSpeechSynthesisTask Operation</seealso>
        public virtual StartSpeechSynthesisTaskResponse StartSpeechSynthesisTask(StartSpeechSynthesisTaskRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartSpeechSynthesisTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSpeechSynthesisTaskResponseUnmarshaller.Instance;

            return Invoke<StartSpeechSynthesisTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartSpeechSynthesisTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartSpeechSynthesisTask operation on AmazonPollyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartSpeechSynthesisTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/StartSpeechSynthesisTask">REST API Reference for StartSpeechSynthesisTask Operation</seealso>
        public virtual IAsyncResult BeginStartSpeechSynthesisTask(StartSpeechSynthesisTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartSpeechSynthesisTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSpeechSynthesisTaskResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartSpeechSynthesisTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartSpeechSynthesisTask.</param>
        /// 
        /// <returns>Returns a  StartSpeechSynthesisTaskResult from Polly.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/StartSpeechSynthesisTask">REST API Reference for StartSpeechSynthesisTask Operation</seealso>
        public virtual StartSpeechSynthesisTaskResponse EndStartSpeechSynthesisTask(IAsyncResult asyncResult)
        {
            return EndInvoke<StartSpeechSynthesisTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  SynthesizeSpeech

        /// <summary>
        /// Synthesizes UTF-8 input, plain text or SSML, to a stream of bytes. SSML input must
        /// be valid, well-formed SSML. Some alphabets might not be available with all the voices
        /// (for example, Cyrillic might not be read at all by English voices) unless phoneme
        /// mapping is used. For more information, see <a href="https://docs.aws.amazon.com/polly/latest/dg/how-text-to-speech-works.html">How
        /// it Works</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SynthesizeSpeech service method.</param>
        /// 
        /// <returns>The response from the SynthesizeSpeech service method, as returned by Polly.</returns>
        /// <exception cref="Amazon.Polly.Model.EngineNotSupportedException">
        /// This engine is not compatible with the voice that you have designated. Choose a new
        /// voice that is compatible with the engine or change the engine and restart the operation.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.InvalidSampleRateException">
        /// The specified sample rate is not valid.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.InvalidSsmlException">
        /// The SSML you provided is invalid. Verify the SSML syntax, spelling of tags and values,
        /// and then try again.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.LanguageNotSupportedException">
        /// The language specified is not currently supported by Amazon Polly in this capacity.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.LexiconNotFoundException">
        /// Amazon Polly can't find the specified lexicon. This could be caused by a lexicon that
        /// is missing, its name is misspelled or specifying a lexicon that is in a different
        /// region.
        /// 
        ///  
        /// <para>
        /// Verify that the lexicon exists, is in the region (see <a>ListLexicons</a>) and that
        /// you spelled its name is spelled correctly. Then try again.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.MarksNotSupportedForFormatException">
        /// Speech marks are not supported for the <c>OutputFormat</c> selected. Speech marks
        /// are only available for content in <c>json</c> format.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ServiceFailureException">
        /// An unknown condition has caused a service failure.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.SsmlMarksNotSupportedForTextTypeException">
        /// SSML speech marks are not supported for plain text-type input.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.TextLengthExceededException">
        /// The value of the "Text" parameter is longer than the accepted limits. For the <c>SynthesizeSpeech</c>
        /// API, the limit for input text is a maximum of 6000 characters total, of which no more
        /// than 3000 can be billed characters. For the <c>StartSpeechSynthesisTask</c> API, the
        /// maximum is 200,000 characters, of which no more than 100,000 can be billed characters.
        /// SSML tags are not counted as billed characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/SynthesizeSpeech">REST API Reference for SynthesizeSpeech Operation</seealso>
        public virtual SynthesizeSpeechResponse SynthesizeSpeech(SynthesizeSpeechRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SynthesizeSpeechRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SynthesizeSpeechResponseUnmarshaller.Instance;

            return Invoke<SynthesizeSpeechResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SynthesizeSpeech operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SynthesizeSpeech operation on AmazonPollyClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSynthesizeSpeech
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/SynthesizeSpeech">REST API Reference for SynthesizeSpeech Operation</seealso>
        public virtual IAsyncResult BeginSynthesizeSpeech(SynthesizeSpeechRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SynthesizeSpeechRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SynthesizeSpeechResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SynthesizeSpeech operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSynthesizeSpeech.</param>
        /// 
        /// <returns>Returns a  SynthesizeSpeechResult from Polly.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/SynthesizeSpeech">REST API Reference for SynthesizeSpeech Operation</seealso>
        public virtual SynthesizeSpeechResponse EndSynthesizeSpeech(IAsyncResult asyncResult)
        {
            return EndInvoke<SynthesizeSpeechResponse>(asyncResult);
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
            var resolver = new AmazonPollyEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}