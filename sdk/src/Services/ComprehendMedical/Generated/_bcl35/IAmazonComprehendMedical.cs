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
 * Do not modify this file. This file is generated from the comprehendmedical-2018-10-30.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ComprehendMedical.Model;

namespace Amazon.ComprehendMedical
{
    /// <summary>
    /// Interface for accessing ComprehendMedical
    ///
    /// Amazon Comprehend Medical extracts structured information from unstructured clinical
    /// text. Use these actions to gain insight in your documents. Amazon Comprehend Medical
    /// only detects entities in English language texts. Amazon Comprehend Medical places
    /// limits on the sizes of files allowed for different API operations. To learn more,
    /// see <a href="https://docs.aws.amazon.com/comprehend-medical/latest/dev/comprehendmedical-quotas.html">Guidelines
    /// and quotas</a> in the <i>Amazon Comprehend Medical Developer Guide</i>.
    /// </summary>
    public partial interface IAmazonComprehendMedical : IAmazonService, IDisposable
    {




        
        #region  DescribeEntitiesDetectionV2Job


        /// <summary>
        /// Gets the properties associated with a medical entities detection job. Use this operation
        /// to get the status of a detection job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEntitiesDetectionV2Job service method.</param>
        /// 
        /// <returns>The response from the DescribeEntitiesDetectionV2Job service method, as returned by ComprehendMedical.</returns>
        /// <exception cref="Amazon.ComprehendMedical.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.InvalidRequestException">
        /// The request that you made is invalid. Check your request to determine why it's invalid
        /// and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.ResourceNotFoundException">
        /// The resource identified by the specified Amazon Resource Name (ARN) was not found.
        /// Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again. Contact customer support for more information about
        /// a service limit increase.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/DescribeEntitiesDetectionV2Job">REST API Reference for DescribeEntitiesDetectionV2Job Operation</seealso>
        DescribeEntitiesDetectionV2JobResponse DescribeEntitiesDetectionV2Job(DescribeEntitiesDetectionV2JobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEntitiesDetectionV2Job operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEntitiesDetectionV2Job operation on AmazonComprehendMedicalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEntitiesDetectionV2Job
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/DescribeEntitiesDetectionV2Job">REST API Reference for DescribeEntitiesDetectionV2Job Operation</seealso>
        IAsyncResult BeginDescribeEntitiesDetectionV2Job(DescribeEntitiesDetectionV2JobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEntitiesDetectionV2Job operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEntitiesDetectionV2Job.</param>
        /// 
        /// <returns>Returns a  DescribeEntitiesDetectionV2JobResult from ComprehendMedical.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/DescribeEntitiesDetectionV2Job">REST API Reference for DescribeEntitiesDetectionV2Job Operation</seealso>
        DescribeEntitiesDetectionV2JobResponse EndDescribeEntitiesDetectionV2Job(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeICD10CMInferenceJob


        /// <summary>
        /// Gets the properties associated with an InferICD10CM job. Use this operation to get
        /// the status of an inference job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeICD10CMInferenceJob service method.</param>
        /// 
        /// <returns>The response from the DescribeICD10CMInferenceJob service method, as returned by ComprehendMedical.</returns>
        /// <exception cref="Amazon.ComprehendMedical.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.InvalidRequestException">
        /// The request that you made is invalid. Check your request to determine why it's invalid
        /// and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.ResourceNotFoundException">
        /// The resource identified by the specified Amazon Resource Name (ARN) was not found.
        /// Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again. Contact customer support for more information about
        /// a service limit increase.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/DescribeICD10CMInferenceJob">REST API Reference for DescribeICD10CMInferenceJob Operation</seealso>
        DescribeICD10CMInferenceJobResponse DescribeICD10CMInferenceJob(DescribeICD10CMInferenceJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeICD10CMInferenceJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeICD10CMInferenceJob operation on AmazonComprehendMedicalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeICD10CMInferenceJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/DescribeICD10CMInferenceJob">REST API Reference for DescribeICD10CMInferenceJob Operation</seealso>
        IAsyncResult BeginDescribeICD10CMInferenceJob(DescribeICD10CMInferenceJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeICD10CMInferenceJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeICD10CMInferenceJob.</param>
        /// 
        /// <returns>Returns a  DescribeICD10CMInferenceJobResult from ComprehendMedical.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/DescribeICD10CMInferenceJob">REST API Reference for DescribeICD10CMInferenceJob Operation</seealso>
        DescribeICD10CMInferenceJobResponse EndDescribeICD10CMInferenceJob(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribePHIDetectionJob


        /// <summary>
        /// Gets the properties associated with a protected health information (PHI) detection
        /// job. Use this operation to get the status of a detection job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePHIDetectionJob service method.</param>
        /// 
        /// <returns>The response from the DescribePHIDetectionJob service method, as returned by ComprehendMedical.</returns>
        /// <exception cref="Amazon.ComprehendMedical.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.InvalidRequestException">
        /// The request that you made is invalid. Check your request to determine why it's invalid
        /// and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.ResourceNotFoundException">
        /// The resource identified by the specified Amazon Resource Name (ARN) was not found.
        /// Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again. Contact customer support for more information about
        /// a service limit increase.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/DescribePHIDetectionJob">REST API Reference for DescribePHIDetectionJob Operation</seealso>
        DescribePHIDetectionJobResponse DescribePHIDetectionJob(DescribePHIDetectionJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePHIDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePHIDetectionJob operation on AmazonComprehendMedicalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePHIDetectionJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/DescribePHIDetectionJob">REST API Reference for DescribePHIDetectionJob Operation</seealso>
        IAsyncResult BeginDescribePHIDetectionJob(DescribePHIDetectionJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePHIDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePHIDetectionJob.</param>
        /// 
        /// <returns>Returns a  DescribePHIDetectionJobResult from ComprehendMedical.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/DescribePHIDetectionJob">REST API Reference for DescribePHIDetectionJob Operation</seealso>
        DescribePHIDetectionJobResponse EndDescribePHIDetectionJob(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeRxNormInferenceJob


        /// <summary>
        /// Gets the properties associated with an InferRxNorm job. Use this operation to get
        /// the status of an inference job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRxNormInferenceJob service method.</param>
        /// 
        /// <returns>The response from the DescribeRxNormInferenceJob service method, as returned by ComprehendMedical.</returns>
        /// <exception cref="Amazon.ComprehendMedical.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.InvalidRequestException">
        /// The request that you made is invalid. Check your request to determine why it's invalid
        /// and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.ResourceNotFoundException">
        /// The resource identified by the specified Amazon Resource Name (ARN) was not found.
        /// Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again. Contact customer support for more information about
        /// a service limit increase.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/DescribeRxNormInferenceJob">REST API Reference for DescribeRxNormInferenceJob Operation</seealso>
        DescribeRxNormInferenceJobResponse DescribeRxNormInferenceJob(DescribeRxNormInferenceJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRxNormInferenceJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRxNormInferenceJob operation on AmazonComprehendMedicalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRxNormInferenceJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/DescribeRxNormInferenceJob">REST API Reference for DescribeRxNormInferenceJob Operation</seealso>
        IAsyncResult BeginDescribeRxNormInferenceJob(DescribeRxNormInferenceJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRxNormInferenceJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRxNormInferenceJob.</param>
        /// 
        /// <returns>Returns a  DescribeRxNormInferenceJobResult from ComprehendMedical.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/DescribeRxNormInferenceJob">REST API Reference for DescribeRxNormInferenceJob Operation</seealso>
        DescribeRxNormInferenceJobResponse EndDescribeRxNormInferenceJob(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeSNOMEDCTInferenceJob


        /// <summary>
        /// Gets the properties associated with an InferSNOMEDCT job. Use this operation to get
        /// the status of an inference job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSNOMEDCTInferenceJob service method.</param>
        /// 
        /// <returns>The response from the DescribeSNOMEDCTInferenceJob service method, as returned by ComprehendMedical.</returns>
        /// <exception cref="Amazon.ComprehendMedical.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.InvalidRequestException">
        /// The request that you made is invalid. Check your request to determine why it's invalid
        /// and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.ResourceNotFoundException">
        /// The resource identified by the specified Amazon Resource Name (ARN) was not found.
        /// Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again. Contact customer support for more information about
        /// a service limit increase.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/DescribeSNOMEDCTInferenceJob">REST API Reference for DescribeSNOMEDCTInferenceJob Operation</seealso>
        DescribeSNOMEDCTInferenceJobResponse DescribeSNOMEDCTInferenceJob(DescribeSNOMEDCTInferenceJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSNOMEDCTInferenceJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSNOMEDCTInferenceJob operation on AmazonComprehendMedicalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSNOMEDCTInferenceJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/DescribeSNOMEDCTInferenceJob">REST API Reference for DescribeSNOMEDCTInferenceJob Operation</seealso>
        IAsyncResult BeginDescribeSNOMEDCTInferenceJob(DescribeSNOMEDCTInferenceJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSNOMEDCTInferenceJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSNOMEDCTInferenceJob.</param>
        /// 
        /// <returns>Returns a  DescribeSNOMEDCTInferenceJobResult from ComprehendMedical.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/DescribeSNOMEDCTInferenceJob">REST API Reference for DescribeSNOMEDCTInferenceJob Operation</seealso>
        DescribeSNOMEDCTInferenceJobResponse EndDescribeSNOMEDCTInferenceJob(IAsyncResult asyncResult);

        #endregion
        
        #region  DetectEntities


        /// <summary>
        /// The <code>DetectEntities</code> operation is deprecated. You should use the <a>DetectEntitiesV2</a>
        /// operation instead.
        /// 
        ///  
        /// <para>
        /// Inspects the clinical text for a variety of medical entities and returns specific
        /// information about them such as entity category, location, and confidence score on
        /// that information.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetectEntities service method.</param>
        /// 
        /// <returns>The response from the DetectEntities service method, as returned by ComprehendMedical.</returns>
        /// <exception cref="Amazon.ComprehendMedical.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.InvalidEncodingException">
        /// The input text was not in valid UTF-8 character encoding. Check your text then retry
        /// your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.InvalidRequestException">
        /// The request that you made is invalid. Check your request to determine why it's invalid
        /// and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.ServiceUnavailableException">
        /// The Amazon Comprehend Medical service is temporarily unavailable. Please wait and
        /// then retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.TextSizeLimitExceededException">
        /// The size of the text you submitted exceeds the size limit. Reduce the size of the
        /// text or use a smaller document and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again. Contact customer support for more information about
        /// a service limit increase.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/DetectEntities">REST API Reference for DetectEntities Operation</seealso>
        [Obsolete("This operation is deprecated, use DetectEntitiesV2 instead.")]
        DetectEntitiesResponse DetectEntities(DetectEntitiesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DetectEntities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetectEntities operation on AmazonComprehendMedicalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetectEntities
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/DetectEntities">REST API Reference for DetectEntities Operation</seealso>
        [Obsolete("This operation is deprecated, use DetectEntitiesV2 instead.")]
        IAsyncResult BeginDetectEntities(DetectEntitiesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DetectEntities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetectEntities.</param>
        /// 
        /// <returns>Returns a  DetectEntitiesResult from ComprehendMedical.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/DetectEntities">REST API Reference for DetectEntities Operation</seealso>
        [Obsolete("This operation is deprecated, use DetectEntitiesV2 instead.")]
        DetectEntitiesResponse EndDetectEntities(IAsyncResult asyncResult);

        #endregion
        
        #region  DetectEntitiesV2


        /// <summary>
        /// Inspects the clinical text for a variety of medical entities and returns specific
        /// information about them such as entity category, location, and confidence score on
        /// that information. Amazon Comprehend Medical only detects medical entities in English
        /// language texts.
        /// 
        ///  
        /// <para>
        /// The <code>DetectEntitiesV2</code> operation replaces the <a>DetectEntities</a> operation.
        /// This new action uses a different model for determining the entities in your medical
        /// text and changes the way that some entities are returned in the output. You should
        /// use the <code>DetectEntitiesV2</code> operation in all new applications.
        /// </para>
        ///  
        /// <para>
        /// The <code>DetectEntitiesV2</code> operation returns the <code>Acuity</code> and <code>Direction</code>
        /// entities as attributes instead of types. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetectEntitiesV2 service method.</param>
        /// 
        /// <returns>The response from the DetectEntitiesV2 service method, as returned by ComprehendMedical.</returns>
        /// <exception cref="Amazon.ComprehendMedical.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.InvalidEncodingException">
        /// The input text was not in valid UTF-8 character encoding. Check your text then retry
        /// your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.InvalidRequestException">
        /// The request that you made is invalid. Check your request to determine why it's invalid
        /// and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.ServiceUnavailableException">
        /// The Amazon Comprehend Medical service is temporarily unavailable. Please wait and
        /// then retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.TextSizeLimitExceededException">
        /// The size of the text you submitted exceeds the size limit. Reduce the size of the
        /// text or use a smaller document and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again. Contact customer support for more information about
        /// a service limit increase.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/DetectEntitiesV2">REST API Reference for DetectEntitiesV2 Operation</seealso>
        DetectEntitiesV2Response DetectEntitiesV2(DetectEntitiesV2Request request);

        /// <summary>
        /// Initiates the asynchronous execution of the DetectEntitiesV2 operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetectEntitiesV2 operation on AmazonComprehendMedicalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetectEntitiesV2
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/DetectEntitiesV2">REST API Reference for DetectEntitiesV2 Operation</seealso>
        IAsyncResult BeginDetectEntitiesV2(DetectEntitiesV2Request request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DetectEntitiesV2 operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetectEntitiesV2.</param>
        /// 
        /// <returns>Returns a  DetectEntitiesV2Result from ComprehendMedical.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/DetectEntitiesV2">REST API Reference for DetectEntitiesV2 Operation</seealso>
        DetectEntitiesV2Response EndDetectEntitiesV2(IAsyncResult asyncResult);

        #endregion
        
        #region  DetectPHI


        /// <summary>
        /// Inspects the clinical text for protected health information (PHI) entities and returns
        /// the entity category, location, and confidence score for each entity. Amazon Comprehend
        /// Medical only detects entities in English language texts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetectPHI service method.</param>
        /// 
        /// <returns>The response from the DetectPHI service method, as returned by ComprehendMedical.</returns>
        /// <exception cref="Amazon.ComprehendMedical.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.InvalidEncodingException">
        /// The input text was not in valid UTF-8 character encoding. Check your text then retry
        /// your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.InvalidRequestException">
        /// The request that you made is invalid. Check your request to determine why it's invalid
        /// and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.ServiceUnavailableException">
        /// The Amazon Comprehend Medical service is temporarily unavailable. Please wait and
        /// then retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.TextSizeLimitExceededException">
        /// The size of the text you submitted exceeds the size limit. Reduce the size of the
        /// text or use a smaller document and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again. Contact customer support for more information about
        /// a service limit increase.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/DetectPHI">REST API Reference for DetectPHI Operation</seealso>
        DetectPHIResponse DetectPHI(DetectPHIRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DetectPHI operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetectPHI operation on AmazonComprehendMedicalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetectPHI
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/DetectPHI">REST API Reference for DetectPHI Operation</seealso>
        IAsyncResult BeginDetectPHI(DetectPHIRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DetectPHI operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetectPHI.</param>
        /// 
        /// <returns>Returns a  DetectPHIResult from ComprehendMedical.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/DetectPHI">REST API Reference for DetectPHI Operation</seealso>
        DetectPHIResponse EndDetectPHI(IAsyncResult asyncResult);

        #endregion
        
        #region  InferICD10CM


        /// <summary>
        /// InferICD10CM detects medical conditions as entities listed in a patient record and
        /// links those entities to normalized concept identifiers in the ICD-10-CM knowledge
        /// base from the Centers for Disease Control. Amazon Comprehend Medical only detects
        /// medical entities in English language texts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InferICD10CM service method.</param>
        /// 
        /// <returns>The response from the InferICD10CM service method, as returned by ComprehendMedical.</returns>
        /// <exception cref="Amazon.ComprehendMedical.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.InvalidEncodingException">
        /// The input text was not in valid UTF-8 character encoding. Check your text then retry
        /// your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.InvalidRequestException">
        /// The request that you made is invalid. Check your request to determine why it's invalid
        /// and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.ServiceUnavailableException">
        /// The Amazon Comprehend Medical service is temporarily unavailable. Please wait and
        /// then retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.TextSizeLimitExceededException">
        /// The size of the text you submitted exceeds the size limit. Reduce the size of the
        /// text or use a smaller document and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again. Contact customer support for more information about
        /// a service limit increase.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/InferICD10CM">REST API Reference for InferICD10CM Operation</seealso>
        InferICD10CMResponse InferICD10CM(InferICD10CMRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the InferICD10CM operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InferICD10CM operation on AmazonComprehendMedicalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndInferICD10CM
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/InferICD10CM">REST API Reference for InferICD10CM Operation</seealso>
        IAsyncResult BeginInferICD10CM(InferICD10CMRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  InferICD10CM operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginInferICD10CM.</param>
        /// 
        /// <returns>Returns a  InferICD10CMResult from ComprehendMedical.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/InferICD10CM">REST API Reference for InferICD10CM Operation</seealso>
        InferICD10CMResponse EndInferICD10CM(IAsyncResult asyncResult);

        #endregion
        
        #region  InferRxNorm


        /// <summary>
        /// InferRxNorm detects medications as entities listed in a patient record and links to
        /// the normalized concept identifiers in the RxNorm database from the National Library
        /// of Medicine. Amazon Comprehend Medical only detects medical entities in English language
        /// texts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InferRxNorm service method.</param>
        /// 
        /// <returns>The response from the InferRxNorm service method, as returned by ComprehendMedical.</returns>
        /// <exception cref="Amazon.ComprehendMedical.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.InvalidEncodingException">
        /// The input text was not in valid UTF-8 character encoding. Check your text then retry
        /// your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.InvalidRequestException">
        /// The request that you made is invalid. Check your request to determine why it's invalid
        /// and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.ServiceUnavailableException">
        /// The Amazon Comprehend Medical service is temporarily unavailable. Please wait and
        /// then retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.TextSizeLimitExceededException">
        /// The size of the text you submitted exceeds the size limit. Reduce the size of the
        /// text or use a smaller document and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again. Contact customer support for more information about
        /// a service limit increase.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/InferRxNorm">REST API Reference for InferRxNorm Operation</seealso>
        InferRxNormResponse InferRxNorm(InferRxNormRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the InferRxNorm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InferRxNorm operation on AmazonComprehendMedicalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndInferRxNorm
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/InferRxNorm">REST API Reference for InferRxNorm Operation</seealso>
        IAsyncResult BeginInferRxNorm(InferRxNormRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  InferRxNorm operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginInferRxNorm.</param>
        /// 
        /// <returns>Returns a  InferRxNormResult from ComprehendMedical.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/InferRxNorm">REST API Reference for InferRxNorm Operation</seealso>
        InferRxNormResponse EndInferRxNorm(IAsyncResult asyncResult);

        #endregion
        
        #region  InferSNOMEDCT


        /// <summary>
        /// InferSNOMEDCT detects possible medical concepts as entities and links them to codes
        /// from the Systematized Nomenclature of Medicine, Clinical Terms (SNOMED-CT) ontology
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InferSNOMEDCT service method.</param>
        /// 
        /// <returns>The response from the InferSNOMEDCT service method, as returned by ComprehendMedical.</returns>
        /// <exception cref="Amazon.ComprehendMedical.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.InvalidEncodingException">
        /// The input text was not in valid UTF-8 character encoding. Check your text then retry
        /// your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.InvalidRequestException">
        /// The request that you made is invalid. Check your request to determine why it's invalid
        /// and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.ServiceUnavailableException">
        /// The Amazon Comprehend Medical service is temporarily unavailable. Please wait and
        /// then retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.TextSizeLimitExceededException">
        /// The size of the text you submitted exceeds the size limit. Reduce the size of the
        /// text or use a smaller document and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again. Contact customer support for more information about
        /// a service limit increase.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/InferSNOMEDCT">REST API Reference for InferSNOMEDCT Operation</seealso>
        InferSNOMEDCTResponse InferSNOMEDCT(InferSNOMEDCTRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the InferSNOMEDCT operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InferSNOMEDCT operation on AmazonComprehendMedicalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndInferSNOMEDCT
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/InferSNOMEDCT">REST API Reference for InferSNOMEDCT Operation</seealso>
        IAsyncResult BeginInferSNOMEDCT(InferSNOMEDCTRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  InferSNOMEDCT operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginInferSNOMEDCT.</param>
        /// 
        /// <returns>Returns a  InferSNOMEDCTResult from ComprehendMedical.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/InferSNOMEDCT">REST API Reference for InferSNOMEDCT Operation</seealso>
        InferSNOMEDCTResponse EndInferSNOMEDCT(IAsyncResult asyncResult);

        #endregion
        
        #region  ListEntitiesDetectionV2Jobs


        /// <summary>
        /// Gets a list of medical entity detection jobs that you have submitted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEntitiesDetectionV2Jobs service method.</param>
        /// 
        /// <returns>The response from the ListEntitiesDetectionV2Jobs service method, as returned by ComprehendMedical.</returns>
        /// <exception cref="Amazon.ComprehendMedical.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.InvalidRequestException">
        /// The request that you made is invalid. Check your request to determine why it's invalid
        /// and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again. Contact customer support for more information about
        /// a service limit increase.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.ValidationException">
        /// The filter that you specified for the operation is invalid. Check the filter values
        /// that you entered and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/ListEntitiesDetectionV2Jobs">REST API Reference for ListEntitiesDetectionV2Jobs Operation</seealso>
        ListEntitiesDetectionV2JobsResponse ListEntitiesDetectionV2Jobs(ListEntitiesDetectionV2JobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListEntitiesDetectionV2Jobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEntitiesDetectionV2Jobs operation on AmazonComprehendMedicalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEntitiesDetectionV2Jobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/ListEntitiesDetectionV2Jobs">REST API Reference for ListEntitiesDetectionV2Jobs Operation</seealso>
        IAsyncResult BeginListEntitiesDetectionV2Jobs(ListEntitiesDetectionV2JobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListEntitiesDetectionV2Jobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEntitiesDetectionV2Jobs.</param>
        /// 
        /// <returns>Returns a  ListEntitiesDetectionV2JobsResult from ComprehendMedical.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/ListEntitiesDetectionV2Jobs">REST API Reference for ListEntitiesDetectionV2Jobs Operation</seealso>
        ListEntitiesDetectionV2JobsResponse EndListEntitiesDetectionV2Jobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListICD10CMInferenceJobs


        /// <summary>
        /// Gets a list of InferICD10CM jobs that you have submitted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListICD10CMInferenceJobs service method.</param>
        /// 
        /// <returns>The response from the ListICD10CMInferenceJobs service method, as returned by ComprehendMedical.</returns>
        /// <exception cref="Amazon.ComprehendMedical.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.InvalidRequestException">
        /// The request that you made is invalid. Check your request to determine why it's invalid
        /// and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again. Contact customer support for more information about
        /// a service limit increase.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.ValidationException">
        /// The filter that you specified for the operation is invalid. Check the filter values
        /// that you entered and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/ListICD10CMInferenceJobs">REST API Reference for ListICD10CMInferenceJobs Operation</seealso>
        ListICD10CMInferenceJobsResponse ListICD10CMInferenceJobs(ListICD10CMInferenceJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListICD10CMInferenceJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListICD10CMInferenceJobs operation on AmazonComprehendMedicalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListICD10CMInferenceJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/ListICD10CMInferenceJobs">REST API Reference for ListICD10CMInferenceJobs Operation</seealso>
        IAsyncResult BeginListICD10CMInferenceJobs(ListICD10CMInferenceJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListICD10CMInferenceJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListICD10CMInferenceJobs.</param>
        /// 
        /// <returns>Returns a  ListICD10CMInferenceJobsResult from ComprehendMedical.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/ListICD10CMInferenceJobs">REST API Reference for ListICD10CMInferenceJobs Operation</seealso>
        ListICD10CMInferenceJobsResponse EndListICD10CMInferenceJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPHIDetectionJobs


        /// <summary>
        /// Gets a list of protected health information (PHI) detection jobs you have submitted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPHIDetectionJobs service method.</param>
        /// 
        /// <returns>The response from the ListPHIDetectionJobs service method, as returned by ComprehendMedical.</returns>
        /// <exception cref="Amazon.ComprehendMedical.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.InvalidRequestException">
        /// The request that you made is invalid. Check your request to determine why it's invalid
        /// and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again. Contact customer support for more information about
        /// a service limit increase.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.ValidationException">
        /// The filter that you specified for the operation is invalid. Check the filter values
        /// that you entered and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/ListPHIDetectionJobs">REST API Reference for ListPHIDetectionJobs Operation</seealso>
        ListPHIDetectionJobsResponse ListPHIDetectionJobs(ListPHIDetectionJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPHIDetectionJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPHIDetectionJobs operation on AmazonComprehendMedicalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPHIDetectionJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/ListPHIDetectionJobs">REST API Reference for ListPHIDetectionJobs Operation</seealso>
        IAsyncResult BeginListPHIDetectionJobs(ListPHIDetectionJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPHIDetectionJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPHIDetectionJobs.</param>
        /// 
        /// <returns>Returns a  ListPHIDetectionJobsResult from ComprehendMedical.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/ListPHIDetectionJobs">REST API Reference for ListPHIDetectionJobs Operation</seealso>
        ListPHIDetectionJobsResponse EndListPHIDetectionJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListRxNormInferenceJobs


        /// <summary>
        /// Gets a list of InferRxNorm jobs that you have submitted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRxNormInferenceJobs service method.</param>
        /// 
        /// <returns>The response from the ListRxNormInferenceJobs service method, as returned by ComprehendMedical.</returns>
        /// <exception cref="Amazon.ComprehendMedical.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.InvalidRequestException">
        /// The request that you made is invalid. Check your request to determine why it's invalid
        /// and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again. Contact customer support for more information about
        /// a service limit increase.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.ValidationException">
        /// The filter that you specified for the operation is invalid. Check the filter values
        /// that you entered and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/ListRxNormInferenceJobs">REST API Reference for ListRxNormInferenceJobs Operation</seealso>
        ListRxNormInferenceJobsResponse ListRxNormInferenceJobs(ListRxNormInferenceJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRxNormInferenceJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRxNormInferenceJobs operation on AmazonComprehendMedicalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRxNormInferenceJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/ListRxNormInferenceJobs">REST API Reference for ListRxNormInferenceJobs Operation</seealso>
        IAsyncResult BeginListRxNormInferenceJobs(ListRxNormInferenceJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRxNormInferenceJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRxNormInferenceJobs.</param>
        /// 
        /// <returns>Returns a  ListRxNormInferenceJobsResult from ComprehendMedical.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/ListRxNormInferenceJobs">REST API Reference for ListRxNormInferenceJobs Operation</seealso>
        ListRxNormInferenceJobsResponse EndListRxNormInferenceJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSNOMEDCTInferenceJobs


        /// <summary>
        /// Gets a list of InferSNOMEDCT jobs a user has submitted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSNOMEDCTInferenceJobs service method.</param>
        /// 
        /// <returns>The response from the ListSNOMEDCTInferenceJobs service method, as returned by ComprehendMedical.</returns>
        /// <exception cref="Amazon.ComprehendMedical.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.InvalidRequestException">
        /// The request that you made is invalid. Check your request to determine why it's invalid
        /// and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again. Contact customer support for more information about
        /// a service limit increase.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.ValidationException">
        /// The filter that you specified for the operation is invalid. Check the filter values
        /// that you entered and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/ListSNOMEDCTInferenceJobs">REST API Reference for ListSNOMEDCTInferenceJobs Operation</seealso>
        ListSNOMEDCTInferenceJobsResponse ListSNOMEDCTInferenceJobs(ListSNOMEDCTInferenceJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSNOMEDCTInferenceJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSNOMEDCTInferenceJobs operation on AmazonComprehendMedicalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSNOMEDCTInferenceJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/ListSNOMEDCTInferenceJobs">REST API Reference for ListSNOMEDCTInferenceJobs Operation</seealso>
        IAsyncResult BeginListSNOMEDCTInferenceJobs(ListSNOMEDCTInferenceJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSNOMEDCTInferenceJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSNOMEDCTInferenceJobs.</param>
        /// 
        /// <returns>Returns a  ListSNOMEDCTInferenceJobsResult from ComprehendMedical.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/ListSNOMEDCTInferenceJobs">REST API Reference for ListSNOMEDCTInferenceJobs Operation</seealso>
        ListSNOMEDCTInferenceJobsResponse EndListSNOMEDCTInferenceJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  StartEntitiesDetectionV2Job


        /// <summary>
        /// Starts an asynchronous medical entity detection job for a collection of documents.
        /// Use the <code>DescribeEntitiesDetectionV2Job</code> operation to track the status
        /// of a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartEntitiesDetectionV2Job service method.</param>
        /// 
        /// <returns>The response from the StartEntitiesDetectionV2Job service method, as returned by ComprehendMedical.</returns>
        /// <exception cref="Amazon.ComprehendMedical.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.InvalidRequestException">
        /// The request that you made is invalid. Check your request to determine why it's invalid
        /// and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.ResourceNotFoundException">
        /// The resource identified by the specified Amazon Resource Name (ARN) was not found.
        /// Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again. Contact customer support for more information about
        /// a service limit increase.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/StartEntitiesDetectionV2Job">REST API Reference for StartEntitiesDetectionV2Job Operation</seealso>
        StartEntitiesDetectionV2JobResponse StartEntitiesDetectionV2Job(StartEntitiesDetectionV2JobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartEntitiesDetectionV2Job operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartEntitiesDetectionV2Job operation on AmazonComprehendMedicalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartEntitiesDetectionV2Job
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/StartEntitiesDetectionV2Job">REST API Reference for StartEntitiesDetectionV2Job Operation</seealso>
        IAsyncResult BeginStartEntitiesDetectionV2Job(StartEntitiesDetectionV2JobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartEntitiesDetectionV2Job operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartEntitiesDetectionV2Job.</param>
        /// 
        /// <returns>Returns a  StartEntitiesDetectionV2JobResult from ComprehendMedical.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/StartEntitiesDetectionV2Job">REST API Reference for StartEntitiesDetectionV2Job Operation</seealso>
        StartEntitiesDetectionV2JobResponse EndStartEntitiesDetectionV2Job(IAsyncResult asyncResult);

        #endregion
        
        #region  StartICD10CMInferenceJob


        /// <summary>
        /// Starts an asynchronous job to detect medical conditions and link them to the ICD-10-CM
        /// ontology. Use the <code>DescribeICD10CMInferenceJob</code> operation to track the
        /// status of a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartICD10CMInferenceJob service method.</param>
        /// 
        /// <returns>The response from the StartICD10CMInferenceJob service method, as returned by ComprehendMedical.</returns>
        /// <exception cref="Amazon.ComprehendMedical.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.InvalidRequestException">
        /// The request that you made is invalid. Check your request to determine why it's invalid
        /// and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.ResourceNotFoundException">
        /// The resource identified by the specified Amazon Resource Name (ARN) was not found.
        /// Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again. Contact customer support for more information about
        /// a service limit increase.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/StartICD10CMInferenceJob">REST API Reference for StartICD10CMInferenceJob Operation</seealso>
        StartICD10CMInferenceJobResponse StartICD10CMInferenceJob(StartICD10CMInferenceJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartICD10CMInferenceJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartICD10CMInferenceJob operation on AmazonComprehendMedicalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartICD10CMInferenceJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/StartICD10CMInferenceJob">REST API Reference for StartICD10CMInferenceJob Operation</seealso>
        IAsyncResult BeginStartICD10CMInferenceJob(StartICD10CMInferenceJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartICD10CMInferenceJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartICD10CMInferenceJob.</param>
        /// 
        /// <returns>Returns a  StartICD10CMInferenceJobResult from ComprehendMedical.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/StartICD10CMInferenceJob">REST API Reference for StartICD10CMInferenceJob Operation</seealso>
        StartICD10CMInferenceJobResponse EndStartICD10CMInferenceJob(IAsyncResult asyncResult);

        #endregion
        
        #region  StartPHIDetectionJob


        /// <summary>
        /// Starts an asynchronous job to detect protected health information (PHI). Use the <code>DescribePHIDetectionJob</code>
        /// operation to track the status of a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartPHIDetectionJob service method.</param>
        /// 
        /// <returns>The response from the StartPHIDetectionJob service method, as returned by ComprehendMedical.</returns>
        /// <exception cref="Amazon.ComprehendMedical.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.InvalidRequestException">
        /// The request that you made is invalid. Check your request to determine why it's invalid
        /// and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.ResourceNotFoundException">
        /// The resource identified by the specified Amazon Resource Name (ARN) was not found.
        /// Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again. Contact customer support for more information about
        /// a service limit increase.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/StartPHIDetectionJob">REST API Reference for StartPHIDetectionJob Operation</seealso>
        StartPHIDetectionJobResponse StartPHIDetectionJob(StartPHIDetectionJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartPHIDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartPHIDetectionJob operation on AmazonComprehendMedicalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartPHIDetectionJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/StartPHIDetectionJob">REST API Reference for StartPHIDetectionJob Operation</seealso>
        IAsyncResult BeginStartPHIDetectionJob(StartPHIDetectionJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartPHIDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartPHIDetectionJob.</param>
        /// 
        /// <returns>Returns a  StartPHIDetectionJobResult from ComprehendMedical.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/StartPHIDetectionJob">REST API Reference for StartPHIDetectionJob Operation</seealso>
        StartPHIDetectionJobResponse EndStartPHIDetectionJob(IAsyncResult asyncResult);

        #endregion
        
        #region  StartRxNormInferenceJob


        /// <summary>
        /// Starts an asynchronous job to detect medication entities and link them to the RxNorm
        /// ontology. Use the <code>DescribeRxNormInferenceJob</code> operation to track the status
        /// of a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartRxNormInferenceJob service method.</param>
        /// 
        /// <returns>The response from the StartRxNormInferenceJob service method, as returned by ComprehendMedical.</returns>
        /// <exception cref="Amazon.ComprehendMedical.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.InvalidRequestException">
        /// The request that you made is invalid. Check your request to determine why it's invalid
        /// and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.ResourceNotFoundException">
        /// The resource identified by the specified Amazon Resource Name (ARN) was not found.
        /// Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again. Contact customer support for more information about
        /// a service limit increase.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/StartRxNormInferenceJob">REST API Reference for StartRxNormInferenceJob Operation</seealso>
        StartRxNormInferenceJobResponse StartRxNormInferenceJob(StartRxNormInferenceJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartRxNormInferenceJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartRxNormInferenceJob operation on AmazonComprehendMedicalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartRxNormInferenceJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/StartRxNormInferenceJob">REST API Reference for StartRxNormInferenceJob Operation</seealso>
        IAsyncResult BeginStartRxNormInferenceJob(StartRxNormInferenceJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartRxNormInferenceJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartRxNormInferenceJob.</param>
        /// 
        /// <returns>Returns a  StartRxNormInferenceJobResult from ComprehendMedical.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/StartRxNormInferenceJob">REST API Reference for StartRxNormInferenceJob Operation</seealso>
        StartRxNormInferenceJobResponse EndStartRxNormInferenceJob(IAsyncResult asyncResult);

        #endregion
        
        #region  StartSNOMEDCTInferenceJob


        /// <summary>
        /// Starts an asynchronous job to detect medical concepts and link them to the SNOMED-CT
        /// ontology. Use the DescribeSNOMEDCTInferenceJob operation to track the status of a
        /// job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSNOMEDCTInferenceJob service method.</param>
        /// 
        /// <returns>The response from the StartSNOMEDCTInferenceJob service method, as returned by ComprehendMedical.</returns>
        /// <exception cref="Amazon.ComprehendMedical.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.InvalidRequestException">
        /// The request that you made is invalid. Check your request to determine why it's invalid
        /// and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.ResourceNotFoundException">
        /// The resource identified by the specified Amazon Resource Name (ARN) was not found.
        /// Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again. Contact customer support for more information about
        /// a service limit increase.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/StartSNOMEDCTInferenceJob">REST API Reference for StartSNOMEDCTInferenceJob Operation</seealso>
        StartSNOMEDCTInferenceJobResponse StartSNOMEDCTInferenceJob(StartSNOMEDCTInferenceJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartSNOMEDCTInferenceJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartSNOMEDCTInferenceJob operation on AmazonComprehendMedicalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartSNOMEDCTInferenceJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/StartSNOMEDCTInferenceJob">REST API Reference for StartSNOMEDCTInferenceJob Operation</seealso>
        IAsyncResult BeginStartSNOMEDCTInferenceJob(StartSNOMEDCTInferenceJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartSNOMEDCTInferenceJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartSNOMEDCTInferenceJob.</param>
        /// 
        /// <returns>Returns a  StartSNOMEDCTInferenceJobResult from ComprehendMedical.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/StartSNOMEDCTInferenceJob">REST API Reference for StartSNOMEDCTInferenceJob Operation</seealso>
        StartSNOMEDCTInferenceJobResponse EndStartSNOMEDCTInferenceJob(IAsyncResult asyncResult);

        #endregion
        
        #region  StopEntitiesDetectionV2Job


        /// <summary>
        /// Stops a medical entities detection job in progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopEntitiesDetectionV2Job service method.</param>
        /// 
        /// <returns>The response from the StopEntitiesDetectionV2Job service method, as returned by ComprehendMedical.</returns>
        /// <exception cref="Amazon.ComprehendMedical.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.InvalidRequestException">
        /// The request that you made is invalid. Check your request to determine why it's invalid
        /// and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.ResourceNotFoundException">
        /// The resource identified by the specified Amazon Resource Name (ARN) was not found.
        /// Check the ARN and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/StopEntitiesDetectionV2Job">REST API Reference for StopEntitiesDetectionV2Job Operation</seealso>
        StopEntitiesDetectionV2JobResponse StopEntitiesDetectionV2Job(StopEntitiesDetectionV2JobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopEntitiesDetectionV2Job operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopEntitiesDetectionV2Job operation on AmazonComprehendMedicalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopEntitiesDetectionV2Job
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/StopEntitiesDetectionV2Job">REST API Reference for StopEntitiesDetectionV2Job Operation</seealso>
        IAsyncResult BeginStopEntitiesDetectionV2Job(StopEntitiesDetectionV2JobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopEntitiesDetectionV2Job operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopEntitiesDetectionV2Job.</param>
        /// 
        /// <returns>Returns a  StopEntitiesDetectionV2JobResult from ComprehendMedical.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/StopEntitiesDetectionV2Job">REST API Reference for StopEntitiesDetectionV2Job Operation</seealso>
        StopEntitiesDetectionV2JobResponse EndStopEntitiesDetectionV2Job(IAsyncResult asyncResult);

        #endregion
        
        #region  StopICD10CMInferenceJob


        /// <summary>
        /// Stops an InferICD10CM inference job in progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopICD10CMInferenceJob service method.</param>
        /// 
        /// <returns>The response from the StopICD10CMInferenceJob service method, as returned by ComprehendMedical.</returns>
        /// <exception cref="Amazon.ComprehendMedical.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.InvalidRequestException">
        /// The request that you made is invalid. Check your request to determine why it's invalid
        /// and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.ResourceNotFoundException">
        /// The resource identified by the specified Amazon Resource Name (ARN) was not found.
        /// Check the ARN and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/StopICD10CMInferenceJob">REST API Reference for StopICD10CMInferenceJob Operation</seealso>
        StopICD10CMInferenceJobResponse StopICD10CMInferenceJob(StopICD10CMInferenceJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopICD10CMInferenceJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopICD10CMInferenceJob operation on AmazonComprehendMedicalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopICD10CMInferenceJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/StopICD10CMInferenceJob">REST API Reference for StopICD10CMInferenceJob Operation</seealso>
        IAsyncResult BeginStopICD10CMInferenceJob(StopICD10CMInferenceJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopICD10CMInferenceJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopICD10CMInferenceJob.</param>
        /// 
        /// <returns>Returns a  StopICD10CMInferenceJobResult from ComprehendMedical.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/StopICD10CMInferenceJob">REST API Reference for StopICD10CMInferenceJob Operation</seealso>
        StopICD10CMInferenceJobResponse EndStopICD10CMInferenceJob(IAsyncResult asyncResult);

        #endregion
        
        #region  StopPHIDetectionJob


        /// <summary>
        /// Stops a protected health information (PHI) detection job in progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopPHIDetectionJob service method.</param>
        /// 
        /// <returns>The response from the StopPHIDetectionJob service method, as returned by ComprehendMedical.</returns>
        /// <exception cref="Amazon.ComprehendMedical.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.InvalidRequestException">
        /// The request that you made is invalid. Check your request to determine why it's invalid
        /// and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.ResourceNotFoundException">
        /// The resource identified by the specified Amazon Resource Name (ARN) was not found.
        /// Check the ARN and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/StopPHIDetectionJob">REST API Reference for StopPHIDetectionJob Operation</seealso>
        StopPHIDetectionJobResponse StopPHIDetectionJob(StopPHIDetectionJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopPHIDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopPHIDetectionJob operation on AmazonComprehendMedicalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopPHIDetectionJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/StopPHIDetectionJob">REST API Reference for StopPHIDetectionJob Operation</seealso>
        IAsyncResult BeginStopPHIDetectionJob(StopPHIDetectionJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopPHIDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopPHIDetectionJob.</param>
        /// 
        /// <returns>Returns a  StopPHIDetectionJobResult from ComprehendMedical.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/StopPHIDetectionJob">REST API Reference for StopPHIDetectionJob Operation</seealso>
        StopPHIDetectionJobResponse EndStopPHIDetectionJob(IAsyncResult asyncResult);

        #endregion
        
        #region  StopRxNormInferenceJob


        /// <summary>
        /// Stops an InferRxNorm inference job in progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopRxNormInferenceJob service method.</param>
        /// 
        /// <returns>The response from the StopRxNormInferenceJob service method, as returned by ComprehendMedical.</returns>
        /// <exception cref="Amazon.ComprehendMedical.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.InvalidRequestException">
        /// The request that you made is invalid. Check your request to determine why it's invalid
        /// and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.ResourceNotFoundException">
        /// The resource identified by the specified Amazon Resource Name (ARN) was not found.
        /// Check the ARN and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/StopRxNormInferenceJob">REST API Reference for StopRxNormInferenceJob Operation</seealso>
        StopRxNormInferenceJobResponse StopRxNormInferenceJob(StopRxNormInferenceJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopRxNormInferenceJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopRxNormInferenceJob operation on AmazonComprehendMedicalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopRxNormInferenceJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/StopRxNormInferenceJob">REST API Reference for StopRxNormInferenceJob Operation</seealso>
        IAsyncResult BeginStopRxNormInferenceJob(StopRxNormInferenceJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopRxNormInferenceJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopRxNormInferenceJob.</param>
        /// 
        /// <returns>Returns a  StopRxNormInferenceJobResult from ComprehendMedical.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/StopRxNormInferenceJob">REST API Reference for StopRxNormInferenceJob Operation</seealso>
        StopRxNormInferenceJobResponse EndStopRxNormInferenceJob(IAsyncResult asyncResult);

        #endregion
        
        #region  StopSNOMEDCTInferenceJob


        /// <summary>
        /// Stops an InferSNOMEDCT inference job in progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopSNOMEDCTInferenceJob service method.</param>
        /// 
        /// <returns>The response from the StopSNOMEDCTInferenceJob service method, as returned by ComprehendMedical.</returns>
        /// <exception cref="Amazon.ComprehendMedical.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.InvalidRequestException">
        /// The request that you made is invalid. Check your request to determine why it's invalid
        /// and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.ResourceNotFoundException">
        /// The resource identified by the specified Amazon Resource Name (ARN) was not found.
        /// Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.ComprehendMedical.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again. Contact customer support for more information about
        /// a service limit increase.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/StopSNOMEDCTInferenceJob">REST API Reference for StopSNOMEDCTInferenceJob Operation</seealso>
        StopSNOMEDCTInferenceJobResponse StopSNOMEDCTInferenceJob(StopSNOMEDCTInferenceJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopSNOMEDCTInferenceJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopSNOMEDCTInferenceJob operation on AmazonComprehendMedicalClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopSNOMEDCTInferenceJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/StopSNOMEDCTInferenceJob">REST API Reference for StopSNOMEDCTInferenceJob Operation</seealso>
        IAsyncResult BeginStopSNOMEDCTInferenceJob(StopSNOMEDCTInferenceJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopSNOMEDCTInferenceJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopSNOMEDCTInferenceJob.</param>
        /// 
        /// <returns>Returns a  StopSNOMEDCTInferenceJobResult from ComprehendMedical.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehendmedical-2018-10-30/StopSNOMEDCTInferenceJob">REST API Reference for StopSNOMEDCTInferenceJob Operation</seealso>
        StopSNOMEDCTInferenceJobResponse EndStopSNOMEDCTInferenceJob(IAsyncResult asyncResult);

        #endregion
        
    }
}