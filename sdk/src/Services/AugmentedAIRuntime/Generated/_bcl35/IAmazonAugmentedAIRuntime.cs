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
 * Do not modify this file. This file is generated from the sagemaker-a2i-runtime-2019-11-07.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.AugmentedAIRuntime.Model;

namespace Amazon.AugmentedAIRuntime
{
    /// <summary>
    /// Interface for accessing AugmentedAIRuntime
    ///
    /// Amazon Augmented AI (Augmented AI) (Preview) is a service that adds human judgment
    /// to any machine learning application. Human reviewers can take over when an AI application
    /// can't evaluate data with a high degree of confidence.
    /// 
    ///  
    /// <para>
    /// From fraudulent bank transaction identification to document processing to image analysis,
    /// machine learning models can be trained to make decisions as well as or better than
    /// a human. Nevertheless, some decisions require contextual interpretation, such as when
    /// you need to decide whether an image is appropriate for a given audience. Content moderation
    /// guidelines are nuanced and highly dependent on context, and they vary between countries.
    /// When trying to apply AI in these situations, you can be forced to choose between "ML
    /// only" systems with unacceptably high error rates or "human only" systems that are
    /// expensive and difficult to scale, and that slow down decision making.
    /// </para>
    ///  
    /// <para>
    /// This API reference includes information about API actions and data types you can use
    /// to interact with Augmented AI programmatically. 
    /// </para>
    ///  
    /// <para>
    /// You can create a flow definition against the Augmented AI API. Provide the Amazon
    /// Resource Name (ARN) of a flow definition to integrate AI service APIs, such as <code>Textract.AnalyzeDocument</code>
    /// and <code>Rekognition.DetectModerationLabels</code>. These AI services, in turn, invoke
    /// the <a>StartHumanLoop</a> API, which evaluates conditions under which humans will
    /// be invoked. If humans are required, Augmented AI creates a human loop. Results of
    /// human work are available asynchronously in Amazon Simple Storage Service (Amazon S3).
    /// You can use Amazon CloudWatch Events to detect human work results.
    /// </para>
    ///  
    /// <para>
    /// You can find additional Augmented AI API documentation in the following reference
    /// guides: <a href="https://aws.amazon.com/rekognition/latest/dg/API_Reference.html">Amazon
    /// Rekognition</a>, <a href="https://aws.amazon.com/sagemaker/latest/dg/API_Reference.html">Amazon
    /// SageMaker</a>, and <a href="https://aws.amazon.com/textract/latest/dg/API_Reference.html">Amazon
    /// Textract</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonAugmentedAIRuntime : IAmazonService, IDisposable
    {

        
        #region  DeleteHumanLoop


        /// <summary>
        /// Deletes the specified human loop for a flow definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteHumanLoop service method.</param>
        /// 
        /// <returns>The response from the DeleteHumanLoop service method, as returned by AugmentedAIRuntime.</returns>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.InternalServerException">
        /// Your request could not be processed.
        /// </exception>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.ResourceNotFoundException">
        /// We were unable to find the requested resource.
        /// </exception>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.ThrottlingException">
        /// Your request has exceeded the allowed amount of requests.
        /// </exception>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.ValidationException">
        /// Your request was not valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-a2i-runtime-2019-11-07/DeleteHumanLoop">REST API Reference for DeleteHumanLoop Operation</seealso>
        DeleteHumanLoopResponse DeleteHumanLoop(DeleteHumanLoopRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteHumanLoop operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteHumanLoop operation on AmazonAugmentedAIRuntimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteHumanLoop
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-a2i-runtime-2019-11-07/DeleteHumanLoop">REST API Reference for DeleteHumanLoop Operation</seealso>
        IAsyncResult BeginDeleteHumanLoop(DeleteHumanLoopRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteHumanLoop operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteHumanLoop.</param>
        /// 
        /// <returns>Returns a  DeleteHumanLoopResult from AugmentedAIRuntime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-a2i-runtime-2019-11-07/DeleteHumanLoop">REST API Reference for DeleteHumanLoop Operation</seealso>
        DeleteHumanLoopResponse EndDeleteHumanLoop(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeHumanLoop


        /// <summary>
        /// Returns information about the specified human loop.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHumanLoop service method.</param>
        /// 
        /// <returns>The response from the DescribeHumanLoop service method, as returned by AugmentedAIRuntime.</returns>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.InternalServerException">
        /// Your request could not be processed.
        /// </exception>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.ResourceNotFoundException">
        /// We were unable to find the requested resource.
        /// </exception>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.ThrottlingException">
        /// Your request has exceeded the allowed amount of requests.
        /// </exception>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.ValidationException">
        /// Your request was not valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-a2i-runtime-2019-11-07/DescribeHumanLoop">REST API Reference for DescribeHumanLoop Operation</seealso>
        DescribeHumanLoopResponse DescribeHumanLoop(DescribeHumanLoopRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeHumanLoop operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeHumanLoop operation on AmazonAugmentedAIRuntimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeHumanLoop
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-a2i-runtime-2019-11-07/DescribeHumanLoop">REST API Reference for DescribeHumanLoop Operation</seealso>
        IAsyncResult BeginDescribeHumanLoop(DescribeHumanLoopRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeHumanLoop operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeHumanLoop.</param>
        /// 
        /// <returns>Returns a  DescribeHumanLoopResult from AugmentedAIRuntime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-a2i-runtime-2019-11-07/DescribeHumanLoop">REST API Reference for DescribeHumanLoop Operation</seealso>
        DescribeHumanLoopResponse EndDescribeHumanLoop(IAsyncResult asyncResult);

        #endregion
        
        #region  ListHumanLoops


        /// <summary>
        /// Returns information about human loops, given the specified parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHumanLoops service method.</param>
        /// 
        /// <returns>The response from the ListHumanLoops service method, as returned by AugmentedAIRuntime.</returns>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.InternalServerException">
        /// Your request could not be processed.
        /// </exception>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.ThrottlingException">
        /// Your request has exceeded the allowed amount of requests.
        /// </exception>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.ValidationException">
        /// Your request was not valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-a2i-runtime-2019-11-07/ListHumanLoops">REST API Reference for ListHumanLoops Operation</seealso>
        ListHumanLoopsResponse ListHumanLoops(ListHumanLoopsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListHumanLoops operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListHumanLoops operation on AmazonAugmentedAIRuntimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListHumanLoops
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-a2i-runtime-2019-11-07/ListHumanLoops">REST API Reference for ListHumanLoops Operation</seealso>
        IAsyncResult BeginListHumanLoops(ListHumanLoopsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListHumanLoops operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListHumanLoops.</param>
        /// 
        /// <returns>Returns a  ListHumanLoopsResult from AugmentedAIRuntime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-a2i-runtime-2019-11-07/ListHumanLoops">REST API Reference for ListHumanLoops Operation</seealso>
        ListHumanLoopsResponse EndListHumanLoops(IAsyncResult asyncResult);

        #endregion
        
        #region  StartHumanLoop


        /// <summary>
        /// Starts a human loop, provided that at least one activation condition is met.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartHumanLoop service method.</param>
        /// 
        /// <returns>The response from the StartHumanLoop service method, as returned by AugmentedAIRuntime.</returns>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.InternalServerException">
        /// Your request could not be processed.
        /// </exception>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota. To perform the requested action, remove some
        /// of the relevant resources, or request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.ThrottlingException">
        /// Your request has exceeded the allowed amount of requests.
        /// </exception>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.ValidationException">
        /// Your request was not valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-a2i-runtime-2019-11-07/StartHumanLoop">REST API Reference for StartHumanLoop Operation</seealso>
        StartHumanLoopResponse StartHumanLoop(StartHumanLoopRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartHumanLoop operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartHumanLoop operation on AmazonAugmentedAIRuntimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartHumanLoop
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-a2i-runtime-2019-11-07/StartHumanLoop">REST API Reference for StartHumanLoop Operation</seealso>
        IAsyncResult BeginStartHumanLoop(StartHumanLoopRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartHumanLoop operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartHumanLoop.</param>
        /// 
        /// <returns>Returns a  StartHumanLoopResult from AugmentedAIRuntime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-a2i-runtime-2019-11-07/StartHumanLoop">REST API Reference for StartHumanLoop Operation</seealso>
        StartHumanLoopResponse EndStartHumanLoop(IAsyncResult asyncResult);

        #endregion
        
        #region  StopHumanLoop


        /// <summary>
        /// Stops the specified human loop.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopHumanLoop service method.</param>
        /// 
        /// <returns>The response from the StopHumanLoop service method, as returned by AugmentedAIRuntime.</returns>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.InternalServerException">
        /// Your request could not be processed.
        /// </exception>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.ResourceNotFoundException">
        /// We were unable to find the requested resource.
        /// </exception>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.ThrottlingException">
        /// Your request has exceeded the allowed amount of requests.
        /// </exception>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.ValidationException">
        /// Your request was not valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-a2i-runtime-2019-11-07/StopHumanLoop">REST API Reference for StopHumanLoop Operation</seealso>
        StopHumanLoopResponse StopHumanLoop(StopHumanLoopRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopHumanLoop operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopHumanLoop operation on AmazonAugmentedAIRuntimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopHumanLoop
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-a2i-runtime-2019-11-07/StopHumanLoop">REST API Reference for StopHumanLoop Operation</seealso>
        IAsyncResult BeginStopHumanLoop(StopHumanLoopRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopHumanLoop operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopHumanLoop.</param>
        /// 
        /// <returns>Returns a  StopHumanLoopResult from AugmentedAIRuntime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-a2i-runtime-2019-11-07/StopHumanLoop">REST API Reference for StopHumanLoop Operation</seealso>
        StopHumanLoopResponse EndStopHumanLoop(IAsyncResult asyncResult);

        #endregion
        
    }
}