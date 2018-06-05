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
 * Do not modify this file. This file is generated from the polly-2016-06-10.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Polly.Model;
using Amazon.Polly.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Polly
{
    /// <summary>
    /// Implementation for accessing Polly
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
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

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
        /// Deletes the specified pronunciation lexicon stored in an AWS Region. A lexicon which
        /// has been deleted is not available for speech synthesis, nor is it possible to retrieve
        /// it using either the <code>GetLexicon</code> or <code>ListLexicon</code> APIs.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/polly/latest/dg/managing-lexicons.html">Managing
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
            var marshaller = DeleteLexiconRequestMarshaller.Instance;
            var unmarshaller = DeleteLexiconResponseUnmarshaller.Instance;

            return Invoke<DeleteLexiconRequest,DeleteLexiconResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteLexiconRequestMarshaller.Instance;
            var unmarshaller = DeleteLexiconResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteLexiconRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// When synthesizing speech ( <code>SynthesizeSpeech</code> ), you provide the voice
        /// ID for the voice you want from the list of voices returned by <code>DescribeVoices</code>.
        /// </para>
        ///  
        /// <para>
        /// For example, you want your news reader application to read news in a specific language,
        /// but giving a user the option to choose the voice. Using the <code>DescribeVoices</code>
        /// operation you can provide the user with a list of available voices to select from.
        /// </para>
        ///  
        /// <para>
        ///  You can optionally specify a language code to filter the available voices. For example,
        /// if you specify <code>en-US</code>, the operation returns a list of all available US
        /// English voices. 
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <code>polly:DescribeVoices</code>
        /// action.
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
            var marshaller = DescribeVoicesRequestMarshaller.Instance;
            var unmarshaller = DescribeVoicesResponseUnmarshaller.Instance;

            return Invoke<DescribeVoicesRequest,DescribeVoicesResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DescribeVoicesRequestMarshaller.Instance;
            var unmarshaller = DescribeVoicesResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeVoicesRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// Returns the content of the specified pronunciation lexicon stored in an AWS Region.
        /// For more information, see <a href="http://docs.aws.amazon.com/polly/latest/dg/managing-lexicons.html">Managing
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
            var marshaller = GetLexiconRequestMarshaller.Instance;
            var unmarshaller = GetLexiconResponseUnmarshaller.Instance;

            return Invoke<GetLexiconRequest,GetLexiconResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetLexiconRequestMarshaller.Instance;
            var unmarshaller = GetLexiconResponseUnmarshaller.Instance;

            return BeginInvoke<GetLexiconRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        
        #region  ListLexicons

        /// <summary>
        /// Returns a list of pronunciation lexicons stored in an AWS Region. For more information,
        /// see <a href="http://docs.aws.amazon.com/polly/latest/dg/managing-lexicons.html">Managing
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
            var marshaller = ListLexiconsRequestMarshaller.Instance;
            var unmarshaller = ListLexiconsResponseUnmarshaller.Instance;

            return Invoke<ListLexiconsRequest,ListLexiconsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = ListLexiconsRequestMarshaller.Instance;
            var unmarshaller = ListLexiconsResponseUnmarshaller.Instance;

            return BeginInvoke<ListLexiconsRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        
        #region  PutLexicon

        /// <summary>
        /// Stores a pronunciation lexicon in an AWS Region. If a lexicon with the same name already
        /// exists in the region, it is overwritten by the new lexicon. Lexicon operations have
        /// eventual consistency, therefore, it might take some time before the lexicon is available
        /// to the SynthesizeSpeech operation.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/polly/latest/dg/managing-lexicons.html">Managing
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
        /// <code>x-sampa</code> and <code>ipa</code>.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.UnsupportedPlsLanguageException">
        /// The language specified in the lexicon is unsupported. For a list of supported languages,
        /// see <a href="http://docs.aws.amazon.com/polly/latest/dg/API_LexiconAttributes.html">Lexicon
        /// Attributes</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/PutLexicon">REST API Reference for PutLexicon Operation</seealso>
        public virtual PutLexiconResponse PutLexicon(PutLexiconRequest request)
        {
            var marshaller = PutLexiconRequestMarshaller.Instance;
            var unmarshaller = PutLexiconResponseUnmarshaller.Instance;

            return Invoke<PutLexiconRequest,PutLexiconResponse>(request, marshaller, unmarshaller);
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
            var marshaller = PutLexiconRequestMarshaller.Instance;
            var unmarshaller = PutLexiconResponseUnmarshaller.Instance;

            return BeginInvoke<PutLexiconRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        
        #region  SynthesizeSpeech

        /// <summary>
        /// Synthesizes UTF-8 input, plain text or SSML, to a stream of bytes. SSML input must
        /// be valid, well-formed SSML. Some alphabets might not be available with all the voices
        /// (for example, Cyrillic might not be read at all by English voices) unless phoneme
        /// mapping is used. For more information, see <a href="http://docs.aws.amazon.com/polly/latest/dg/how-text-to-speech-works.html">How
        /// it Works</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SynthesizeSpeech service method.</param>
        /// 
        /// <returns>The response from the SynthesizeSpeech service method, as returned by Polly.</returns>
        /// <exception cref="Amazon.Polly.Model.InvalidSampleRateException">
        /// The specified sample rate is not valid.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.InvalidSsmlException">
        /// The SSML you provided is invalid. Verify the SSML syntax, spelling of tags and values,
        /// and then try again.
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
        /// Speech marks are not supported for the <code>OutputFormat</code> selected. Speech
        /// marks are only available for content in <code>json</code> format.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ServiceFailureException">
        /// An unknown condition has caused a service failure.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.SsmlMarksNotSupportedForTextTypeException">
        /// SSML speech marks are not supported for plain text-type input.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.TextLengthExceededException">
        /// The value of the "Text" parameter is longer than the accepted limits. The limit for
        /// input text is a maximum of 6000 characters total, of which no more than 3000 can be
        /// billed characters. SSML tags are not counted as billed characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/SynthesizeSpeech">REST API Reference for SynthesizeSpeech Operation</seealso>
        public virtual SynthesizeSpeechResponse SynthesizeSpeech(SynthesizeSpeechRequest request)
        {
            var marshaller = SynthesizeSpeechRequestMarshaller.Instance;
            var unmarshaller = SynthesizeSpeechResponseUnmarshaller.Instance;

            return Invoke<SynthesizeSpeechRequest,SynthesizeSpeechResponse>(request, marshaller, unmarshaller);
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
            var marshaller = SynthesizeSpeechRequestMarshaller.Instance;
            var unmarshaller = SynthesizeSpeechResponseUnmarshaller.Instance;

            return BeginInvoke<SynthesizeSpeechRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        
    }
}