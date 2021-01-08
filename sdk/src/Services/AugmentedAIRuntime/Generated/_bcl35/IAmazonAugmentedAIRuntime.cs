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
    /// <important> 
    /// <para>
    /// Amazon Augmented AI is in preview release and is subject to change. We do not recommend
    /// using this product in production environments.
    /// </para>
    ///  </important> 
    /// <para>
    /// Amazon Augmented AI (Amazon A2I) adds the benefit of human judgment to any machine
    /// learning application. When an AI application can't evaluate data with a high degree
    /// of confidence, human reviewers can take over. This human review is called a human
    /// review workflow. To create and start a human review workflow, you need three resources:
    /// a <i>worker task template</i>, a <i>flow definition</i>, and a <i>human loop</i>.
    /// </para>
    ///  
    /// <para>
    /// For information about these resources and prerequisites for using Amazon A2I, see
    /// <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/a2i-getting-started.html">Get
    /// Started with Amazon Augmented AI</a> in the Amazon SageMaker Developer Guide.
    /// </para>
    ///  
    /// <para>
    /// This API reference includes information about API actions and data types that you
    /// can use to interact with Amazon A2I programmatically. Use this guide to:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Start a human loop with the <code>StartHumanLoop</code> operation when using Amazon
    /// A2I with a <i>custom task type</i>. To learn more about the difference between custom
    /// and built-in task types, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/a2i-task-types-general.html">Use
    /// Task Types </a>. To learn how to start a human loop using this API, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/a2i-start-human-loop.html#a2i-instructions-starthumanloop">Create
    /// and Start a Human Loop for a Custom Task Type </a> in the Amazon SageMaker Developer
    /// Guide.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Manage your human loops. You can list all human loops that you have created, describe
    /// individual human loops, and stop and delete human loops. To learn more, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/a2i-monitor-humanloop-results.html">Monitor
    /// and Manage Your Human Loop </a> in the Amazon SageMaker Developer Guide.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Amazon A2I integrates APIs from various AWS services to create and start human review
    /// workflows for those services. To learn how Amazon A2I uses these APIs, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/a2i-api-references.html">Use
    /// APIs in Amazon A2I</a> in the Amazon SageMaker Developer Guide.
    /// </para>
    /// </summary>
    public partial interface IAmazonAugmentedAIRuntime : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IAugmentedAIRuntimePaginatorFactory Paginators { get; }
#endif


        
        #region  DeleteHumanLoop


        /// <summary>
        /// Deletes the specified human loop for a flow definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteHumanLoop service method.</param>
        /// 
        /// <returns>The response from the DeleteHumanLoop service method, as returned by AugmentedAIRuntime.</returns>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource.
        /// </exception>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
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
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource.
        /// </exception>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
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
        /// Returns information about human loops, given the specified parameters. If a human
        /// loop was deleted, it will not be included.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHumanLoops service method.</param>
        /// 
        /// <returns>The response from the ListHumanLoops service method, as returned by AugmentedAIRuntime.</returns>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource.
        /// </exception>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
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
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.ConflictException">
        /// Your request has the same name as another active human loop but has different input
        /// data. You cannot start two human loops with the same name and different input data.
        /// </exception>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Delete some resources or request an increase in your
        /// service quota.
        /// </exception>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
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
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource.
        /// </exception>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
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