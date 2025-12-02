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
 * Do not modify this file. This file is generated from the savingsplans-2019-06-28.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.SavingsPlans.Model;

#pragma warning disable CS1570
namespace Amazon.SavingsPlans
{
    /// <summary>
    /// <para>Interface for accessing SavingsPlans</para>
    ///
    /// Savings Plans are a pricing model that offer significant savings on Amazon Web Services
    /// usage (for example, on Amazon EC2 instances). You commit to a consistent amount of
    /// usage per hour, in the specified currency, for a term of one or three years, and receive
    /// a lower price for that usage. For more information, see the <a href="https://docs.aws.amazon.com/savingsplans/latest/userguide/">Amazon
    /// Web Services Savings Plans User Guide</a>.
    /// </summary>
    public partial interface IAmazonSavingsPlans : IAmazonService, IDisposable
    {




        
        #region  CreateSavingsPlan


        /// <summary>
        /// Creates a Savings Plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSavingsPlan service method.</param>
        /// 
        /// <returns>The response from the CreateSavingsPlan service method, as returned by SavingsPlans.</returns>
        /// <exception cref="Amazon.SavingsPlans.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ServiceQuotaExceededException">
        /// A service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ValidationException">
        /// One of the input parameters is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/CreateSavingsPlan">REST API Reference for CreateSavingsPlan Operation</seealso>
        CreateSavingsPlanResponse CreateSavingsPlan(CreateSavingsPlanRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSavingsPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSavingsPlan operation on AmazonSavingsPlansClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSavingsPlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/CreateSavingsPlan">REST API Reference for CreateSavingsPlan Operation</seealso>
        IAsyncResult BeginCreateSavingsPlan(CreateSavingsPlanRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSavingsPlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSavingsPlan.</param>
        /// 
        /// <returns>Returns a  CreateSavingsPlanResult from SavingsPlans.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/CreateSavingsPlan">REST API Reference for CreateSavingsPlan Operation</seealso>
        CreateSavingsPlanResponse EndCreateSavingsPlan(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteQueuedSavingsPlan


        /// <summary>
        /// Deletes the queued purchase for the specified Savings Plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteQueuedSavingsPlan service method.</param>
        /// 
        /// <returns>The response from the DeleteQueuedSavingsPlan service method, as returned by SavingsPlans.</returns>
        /// <exception cref="Amazon.SavingsPlans.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ServiceQuotaExceededException">
        /// A service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ValidationException">
        /// One of the input parameters is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/DeleteQueuedSavingsPlan">REST API Reference for DeleteQueuedSavingsPlan Operation</seealso>
        DeleteQueuedSavingsPlanResponse DeleteQueuedSavingsPlan(DeleteQueuedSavingsPlanRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteQueuedSavingsPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteQueuedSavingsPlan operation on AmazonSavingsPlansClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteQueuedSavingsPlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/DeleteQueuedSavingsPlan">REST API Reference for DeleteQueuedSavingsPlan Operation</seealso>
        IAsyncResult BeginDeleteQueuedSavingsPlan(DeleteQueuedSavingsPlanRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteQueuedSavingsPlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteQueuedSavingsPlan.</param>
        /// 
        /// <returns>Returns a  DeleteQueuedSavingsPlanResult from SavingsPlans.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/DeleteQueuedSavingsPlan">REST API Reference for DeleteQueuedSavingsPlan Operation</seealso>
        DeleteQueuedSavingsPlanResponse EndDeleteQueuedSavingsPlan(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeSavingsPlanRates


        /// <summary>
        /// Describes the rates for a specific, existing Savings Plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSavingsPlanRates service method.</param>
        /// 
        /// <returns>The response from the DescribeSavingsPlanRates service method, as returned by SavingsPlans.</returns>
        /// <exception cref="Amazon.SavingsPlans.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ValidationException">
        /// One of the input parameters is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/DescribeSavingsPlanRates">REST API Reference for DescribeSavingsPlanRates Operation</seealso>
        DescribeSavingsPlanRatesResponse DescribeSavingsPlanRates(DescribeSavingsPlanRatesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSavingsPlanRates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSavingsPlanRates operation on AmazonSavingsPlansClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSavingsPlanRates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/DescribeSavingsPlanRates">REST API Reference for DescribeSavingsPlanRates Operation</seealso>
        IAsyncResult BeginDescribeSavingsPlanRates(DescribeSavingsPlanRatesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSavingsPlanRates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSavingsPlanRates.</param>
        /// 
        /// <returns>Returns a  DescribeSavingsPlanRatesResult from SavingsPlans.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/DescribeSavingsPlanRates">REST API Reference for DescribeSavingsPlanRates Operation</seealso>
        DescribeSavingsPlanRatesResponse EndDescribeSavingsPlanRates(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeSavingsPlans


        /// <summary>
        /// Describes the specified Savings Plans.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSavingsPlans service method.</param>
        /// 
        /// <returns>The response from the DescribeSavingsPlans service method, as returned by SavingsPlans.</returns>
        /// <exception cref="Amazon.SavingsPlans.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ValidationException">
        /// One of the input parameters is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/DescribeSavingsPlans">REST API Reference for DescribeSavingsPlans Operation</seealso>
        DescribeSavingsPlansResponse DescribeSavingsPlans(DescribeSavingsPlansRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSavingsPlans operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSavingsPlans operation on AmazonSavingsPlansClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSavingsPlans
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/DescribeSavingsPlans">REST API Reference for DescribeSavingsPlans Operation</seealso>
        IAsyncResult BeginDescribeSavingsPlans(DescribeSavingsPlansRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSavingsPlans operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSavingsPlans.</param>
        /// 
        /// <returns>Returns a  DescribeSavingsPlansResult from SavingsPlans.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/DescribeSavingsPlans">REST API Reference for DescribeSavingsPlans Operation</seealso>
        DescribeSavingsPlansResponse EndDescribeSavingsPlans(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeSavingsPlansOfferingRates


        /// <summary>
        /// Describes the offering rates for Savings Plans you might want to purchase.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSavingsPlansOfferingRates service method.</param>
        /// 
        /// <returns>The response from the DescribeSavingsPlansOfferingRates service method, as returned by SavingsPlans.</returns>
        /// <exception cref="Amazon.SavingsPlans.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ValidationException">
        /// One of the input parameters is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/DescribeSavingsPlansOfferingRates">REST API Reference for DescribeSavingsPlansOfferingRates Operation</seealso>
        DescribeSavingsPlansOfferingRatesResponse DescribeSavingsPlansOfferingRates(DescribeSavingsPlansOfferingRatesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSavingsPlansOfferingRates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSavingsPlansOfferingRates operation on AmazonSavingsPlansClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSavingsPlansOfferingRates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/DescribeSavingsPlansOfferingRates">REST API Reference for DescribeSavingsPlansOfferingRates Operation</seealso>
        IAsyncResult BeginDescribeSavingsPlansOfferingRates(DescribeSavingsPlansOfferingRatesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSavingsPlansOfferingRates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSavingsPlansOfferingRates.</param>
        /// 
        /// <returns>Returns a  DescribeSavingsPlansOfferingRatesResult from SavingsPlans.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/DescribeSavingsPlansOfferingRates">REST API Reference for DescribeSavingsPlansOfferingRates Operation</seealso>
        DescribeSavingsPlansOfferingRatesResponse EndDescribeSavingsPlansOfferingRates(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeSavingsPlansOfferings


        /// <summary>
        /// Describes the offerings for the specified Savings Plans.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSavingsPlansOfferings service method.</param>
        /// 
        /// <returns>The response from the DescribeSavingsPlansOfferings service method, as returned by SavingsPlans.</returns>
        /// <exception cref="Amazon.SavingsPlans.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ValidationException">
        /// One of the input parameters is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/DescribeSavingsPlansOfferings">REST API Reference for DescribeSavingsPlansOfferings Operation</seealso>
        DescribeSavingsPlansOfferingsResponse DescribeSavingsPlansOfferings(DescribeSavingsPlansOfferingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSavingsPlansOfferings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSavingsPlansOfferings operation on AmazonSavingsPlansClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSavingsPlansOfferings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/DescribeSavingsPlansOfferings">REST API Reference for DescribeSavingsPlansOfferings Operation</seealso>
        IAsyncResult BeginDescribeSavingsPlansOfferings(DescribeSavingsPlansOfferingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSavingsPlansOfferings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSavingsPlansOfferings.</param>
        /// 
        /// <returns>Returns a  DescribeSavingsPlansOfferingsResult from SavingsPlans.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/DescribeSavingsPlansOfferings">REST API Reference for DescribeSavingsPlansOfferings Operation</seealso>
        DescribeSavingsPlansOfferingsResponse EndDescribeSavingsPlansOfferings(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by SavingsPlans.</returns>
        /// <exception cref="Amazon.SavingsPlans.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ValidationException">
        /// One of the input parameters is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonSavingsPlansClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from SavingsPlans.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ReturnSavingsPlan


        /// <summary>
        /// Returns the specified Savings Plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReturnSavingsPlan service method.</param>
        /// 
        /// <returns>The response from the ReturnSavingsPlan service method, as returned by SavingsPlans.</returns>
        /// <exception cref="Amazon.SavingsPlans.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ServiceQuotaExceededException">
        /// A service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ValidationException">
        /// One of the input parameters is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/ReturnSavingsPlan">REST API Reference for ReturnSavingsPlan Operation</seealso>
        ReturnSavingsPlanResponse ReturnSavingsPlan(ReturnSavingsPlanRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ReturnSavingsPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReturnSavingsPlan operation on AmazonSavingsPlansClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndReturnSavingsPlan
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/ReturnSavingsPlan">REST API Reference for ReturnSavingsPlan Operation</seealso>
        IAsyncResult BeginReturnSavingsPlan(ReturnSavingsPlanRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ReturnSavingsPlan operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReturnSavingsPlan.</param>
        /// 
        /// <returns>Returns a  ReturnSavingsPlanResult from SavingsPlans.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/ReturnSavingsPlan">REST API Reference for ReturnSavingsPlan Operation</seealso>
        ReturnSavingsPlanResponse EndReturnSavingsPlan(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds the specified tags to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by SavingsPlans.</returns>
        /// <exception cref="Amazon.SavingsPlans.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ServiceQuotaExceededException">
        /// A service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ValidationException">
        /// One of the input parameters is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonSavingsPlansClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from SavingsPlans.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes the specified tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by SavingsPlans.</returns>
        /// <exception cref="Amazon.SavingsPlans.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SavingsPlans.Model.ValidationException">
        /// One of the input parameters is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonSavingsPlansClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from SavingsPlans.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/savingsplans-2019-06-28/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

    }
}