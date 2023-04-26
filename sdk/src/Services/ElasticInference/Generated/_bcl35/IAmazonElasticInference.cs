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
 * Do not modify this file. This file is generated from the elastic-inference-2017-07-25.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ElasticInference.Model;

namespace Amazon.ElasticInference
{
    /// <summary>
    /// Interface for accessing ElasticInference
    ///
    /// Elastic Inference public APIs. 
    /// 
    ///  
    /// <para>
    ///  February 15, 2023: Starting April 15, 2023, AWS will not onboard new customers to
    /// Amazon Elastic Inference (EI), and will help current customers migrate their workloads
    /// to options that offer better price and performance. After April 15, 2023, new customers
    /// will not be able to launch instances with Amazon EI accelerators in Amazon SageMaker,
    /// Amazon ECS, or Amazon EC2. However, customers who have used Amazon EI at least once
    /// during the past 30-day period are considered current customers and will be able to
    /// continue using the service. 
    /// </para>
    /// </summary>
    public partial interface IAmazonElasticInference : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IElasticInferencePaginatorFactory Paginators { get; }
#endif


        
        #region  DescribeAcceleratorOfferings


        /// <summary>
        /// Describes the locations in which a given accelerator type or set of types is present
        /// in a given region. 
        /// 
        ///  
        /// <para>
        ///  February 15, 2023: Starting April 15, 2023, AWS will not onboard new customers to
        /// Amazon Elastic Inference (EI), and will help current customers migrate their workloads
        /// to options that offer better price and performance. After April 15, 2023, new customers
        /// will not be able to launch instances with Amazon EI accelerators in Amazon SageMaker,
        /// Amazon ECS, or Amazon EC2. However, customers who have used Amazon EI at least once
        /// during the past 30-day period are considered current customers and will be able to
        /// continue using the service. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAcceleratorOfferings service method.</param>
        /// 
        /// <returns>The response from the DescribeAcceleratorOfferings service method, as returned by ElasticInference.</returns>
        /// <exception cref="Amazon.ElasticInference.Model.BadRequestException">
        /// Raised when a malformed input has been provided to the API.
        /// </exception>
        /// <exception cref="Amazon.ElasticInference.Model.InternalServerException">
        /// Raised when an unexpected error occurred during request processing.
        /// </exception>
        /// <exception cref="Amazon.ElasticInference.Model.ResourceNotFoundException">
        /// Raised when the requested resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastic-inference-2017-07-25/DescribeAcceleratorOfferings">REST API Reference for DescribeAcceleratorOfferings Operation</seealso>
        DescribeAcceleratorOfferingsResponse DescribeAcceleratorOfferings(DescribeAcceleratorOfferingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAcceleratorOfferings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAcceleratorOfferings operation on AmazonElasticInferenceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAcceleratorOfferings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastic-inference-2017-07-25/DescribeAcceleratorOfferings">REST API Reference for DescribeAcceleratorOfferings Operation</seealso>
        IAsyncResult BeginDescribeAcceleratorOfferings(DescribeAcceleratorOfferingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAcceleratorOfferings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAcceleratorOfferings.</param>
        /// 
        /// <returns>Returns a  DescribeAcceleratorOfferingsResult from ElasticInference.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastic-inference-2017-07-25/DescribeAcceleratorOfferings">REST API Reference for DescribeAcceleratorOfferings Operation</seealso>
        DescribeAcceleratorOfferingsResponse EndDescribeAcceleratorOfferings(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeAccelerators


        /// <summary>
        /// Describes information over a provided set of accelerators belonging to an account.
        /// 
        /// 
        ///  
        /// <para>
        ///  February 15, 2023: Starting April 15, 2023, AWS will not onboard new customers to
        /// Amazon Elastic Inference (EI), and will help current customers migrate their workloads
        /// to options that offer better price and performance. After April 15, 2023, new customers
        /// will not be able to launch instances with Amazon EI accelerators in Amazon SageMaker,
        /// Amazon ECS, or Amazon EC2. However, customers who have used Amazon EI at least once
        /// during the past 30-day period are considered current customers and will be able to
        /// continue using the service. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccelerators service method.</param>
        /// 
        /// <returns>The response from the DescribeAccelerators service method, as returned by ElasticInference.</returns>
        /// <exception cref="Amazon.ElasticInference.Model.BadRequestException">
        /// Raised when a malformed input has been provided to the API.
        /// </exception>
        /// <exception cref="Amazon.ElasticInference.Model.InternalServerException">
        /// Raised when an unexpected error occurred during request processing.
        /// </exception>
        /// <exception cref="Amazon.ElasticInference.Model.ResourceNotFoundException">
        /// Raised when the requested resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastic-inference-2017-07-25/DescribeAccelerators">REST API Reference for DescribeAccelerators Operation</seealso>
        DescribeAcceleratorsResponse DescribeAccelerators(DescribeAcceleratorsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAccelerators operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccelerators operation on AmazonElasticInferenceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAccelerators
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastic-inference-2017-07-25/DescribeAccelerators">REST API Reference for DescribeAccelerators Operation</seealso>
        IAsyncResult BeginDescribeAccelerators(DescribeAcceleratorsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAccelerators operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAccelerators.</param>
        /// 
        /// <returns>Returns a  DescribeAcceleratorsResult from ElasticInference.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastic-inference-2017-07-25/DescribeAccelerators">REST API Reference for DescribeAccelerators Operation</seealso>
        DescribeAcceleratorsResponse EndDescribeAccelerators(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeAcceleratorTypes


        /// <summary>
        /// Describes the accelerator types available in a given region, as well as their characteristics,
        /// such as memory and throughput. 
        /// 
        ///  
        /// <para>
        ///  February 15, 2023: Starting April 15, 2023, AWS will not onboard new customers to
        /// Amazon Elastic Inference (EI), and will help current customers migrate their workloads
        /// to options that offer better price and performance. After April 15, 2023, new customers
        /// will not be able to launch instances with Amazon EI accelerators in Amazon SageMaker,
        /// Amazon ECS, or Amazon EC2. However, customers who have used Amazon EI at least once
        /// during the past 30-day period are considered current customers and will be able to
        /// continue using the service. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAcceleratorTypes service method.</param>
        /// 
        /// <returns>The response from the DescribeAcceleratorTypes service method, as returned by ElasticInference.</returns>
        /// <exception cref="Amazon.ElasticInference.Model.InternalServerException">
        /// Raised when an unexpected error occurred during request processing.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastic-inference-2017-07-25/DescribeAcceleratorTypes">REST API Reference for DescribeAcceleratorTypes Operation</seealso>
        DescribeAcceleratorTypesResponse DescribeAcceleratorTypes(DescribeAcceleratorTypesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAcceleratorTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAcceleratorTypes operation on AmazonElasticInferenceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAcceleratorTypes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastic-inference-2017-07-25/DescribeAcceleratorTypes">REST API Reference for DescribeAcceleratorTypes Operation</seealso>
        IAsyncResult BeginDescribeAcceleratorTypes(DescribeAcceleratorTypesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAcceleratorTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAcceleratorTypes.</param>
        /// 
        /// <returns>Returns a  DescribeAcceleratorTypesResult from ElasticInference.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastic-inference-2017-07-25/DescribeAcceleratorTypes">REST API Reference for DescribeAcceleratorTypes Operation</seealso>
        DescribeAcceleratorTypesResponse EndDescribeAcceleratorTypes(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Returns all tags of an Elastic Inference Accelerator. 
        /// 
        ///  
        /// <para>
        ///  February 15, 2023: Starting April 15, 2023, AWS will not onboard new customers to
        /// Amazon Elastic Inference (EI), and will help current customers migrate their workloads
        /// to options that offer better price and performance. After April 15, 2023, new customers
        /// will not be able to launch instances with Amazon EI accelerators in Amazon SageMaker,
        /// Amazon ECS, or Amazon EC2. However, customers who have used Amazon EI at least once
        /// during the past 30-day period are considered current customers and will be able to
        /// continue using the service. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ElasticInference.</returns>
        /// <exception cref="Amazon.ElasticInference.Model.BadRequestException">
        /// Raised when a malformed input has been provided to the API.
        /// </exception>
        /// <exception cref="Amazon.ElasticInference.Model.InternalServerException">
        /// Raised when an unexpected error occurred during request processing.
        /// </exception>
        /// <exception cref="Amazon.ElasticInference.Model.ResourceNotFoundException">
        /// Raised when the requested resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastic-inference-2017-07-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonElasticInferenceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastic-inference-2017-07-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from ElasticInference.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastic-inference-2017-07-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds the specified tags to an Elastic Inference Accelerator. 
        /// 
        ///  
        /// <para>
        ///  February 15, 2023: Starting April 15, 2023, AWS will not onboard new customers to
        /// Amazon Elastic Inference (EI), and will help current customers migrate their workloads
        /// to options that offer better price and performance. After April 15, 2023, new customers
        /// will not be able to launch instances with Amazon EI accelerators in Amazon SageMaker,
        /// Amazon ECS, or Amazon EC2. However, customers who have used Amazon EI at least once
        /// during the past 30-day period are considered current customers and will be able to
        /// continue using the service. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ElasticInference.</returns>
        /// <exception cref="Amazon.ElasticInference.Model.BadRequestException">
        /// Raised when a malformed input has been provided to the API.
        /// </exception>
        /// <exception cref="Amazon.ElasticInference.Model.InternalServerException">
        /// Raised when an unexpected error occurred during request processing.
        /// </exception>
        /// <exception cref="Amazon.ElasticInference.Model.ResourceNotFoundException">
        /// Raised when the requested resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastic-inference-2017-07-25/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonElasticInferenceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastic-inference-2017-07-25/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from ElasticInference.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastic-inference-2017-07-25/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes the specified tags from an Elastic Inference Accelerator. 
        /// 
        ///  
        /// <para>
        ///  February 15, 2023: Starting April 15, 2023, AWS will not onboard new customers to
        /// Amazon Elastic Inference (EI), and will help current customers migrate their workloads
        /// to options that offer better price and performance. After April 15, 2023, new customers
        /// will not be able to launch instances with Amazon EI accelerators in Amazon SageMaker,
        /// Amazon ECS, or Amazon EC2. However, customers who have used Amazon EI at least once
        /// during the past 30-day period are considered current customers and will be able to
        /// continue using the service. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ElasticInference.</returns>
        /// <exception cref="Amazon.ElasticInference.Model.BadRequestException">
        /// Raised when a malformed input has been provided to the API.
        /// </exception>
        /// <exception cref="Amazon.ElasticInference.Model.InternalServerException">
        /// Raised when an unexpected error occurred during request processing.
        /// </exception>
        /// <exception cref="Amazon.ElasticInference.Model.ResourceNotFoundException">
        /// Raised when the requested resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastic-inference-2017-07-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonElasticInferenceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastic-inference-2017-07-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from ElasticInference.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elastic-inference-2017-07-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
    }
}