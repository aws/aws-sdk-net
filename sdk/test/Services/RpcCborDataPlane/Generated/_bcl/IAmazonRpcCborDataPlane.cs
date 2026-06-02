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
 * Do not modify this file. This file is generated from the rpccbordataplane-1999-12-31.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.RpcCborDataPlane.Model;

#pragma warning disable CS1570
namespace Amazon.RpcCborDataPlane
{
    /// <summary>
    /// <para>Interface for accessing RpcCborDataPlane</para>
    ///
    /// 
    /// </summary>
    public partial interface IAmazonRpcCborDataPlane : IAmazonService, IDisposable
    {


        
        #region  GetItem


        /// <summary>
        /// <pre><c>From Amazon DynamoDB. Deserialization of recursive structures. </c></pre>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetItem service method.</param>
        /// 
        /// <returns>The response from the GetItem service method, as returned by RpcCborDataPlane.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpccbordataplane-1999-12-31/GetItem">REST API Reference for GetItem Operation</seealso>
        GetItemResponse GetItem(GetItemRequest request);



        /// <summary>
        /// <pre><c>From Amazon DynamoDB. Deserialization of recursive structures. </c></pre>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetItem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetItem service method, as returned by RpcCborDataPlane.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpccbordataplane-1999-12-31/GetItem">REST API Reference for GetItem Operation</seealso>
        Task<GetItemResponse> GetItemAsync(GetItemRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetMetricData


        /// <summary>
        /// <pre><c>As seen in Amazon CloudWatch </c></pre>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMetricData service method.</param>
        /// 
        /// <returns>The response from the GetMetricData service method, as returned by RpcCborDataPlane.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpccbordataplane-1999-12-31/GetMetricData">REST API Reference for GetMetricData Operation</seealso>
        GetMetricDataResponse GetMetricData(GetMetricDataRequest request);



        /// <summary>
        /// <pre><c>As seen in Amazon CloudWatch </c></pre>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMetricData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMetricData service method, as returned by RpcCborDataPlane.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpccbordataplane-1999-12-31/GetMetricData">REST API Reference for GetMetricData Operation</seealso>
        Task<GetMetricDataResponse> GetMetricDataAsync(GetMetricDataRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  Healthcheck


        /// <summary>
        /// <pre><c>A response that only says &quot;OK&quot;, if it can. </c></pre>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Healthcheck service method.</param>
        /// 
        /// <returns>The response from the Healthcheck service method, as returned by RpcCborDataPlane.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpccbordataplane-1999-12-31/Healthcheck">REST API Reference for Healthcheck Operation</seealso>
        HealthcheckResponse Healthcheck(HealthcheckRequest request);



        /// <summary>
        /// <pre><c>A response that only says &quot;OK&quot;, if it can. </c></pre>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Healthcheck service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Healthcheck service method, as returned by RpcCborDataPlane.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpccbordataplane-1999-12-31/Healthcheck">REST API Reference for Healthcheck Operation</seealso>
        Task<HealthcheckResponse> HealthcheckAsync(HealthcheckRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutItem


        /// <summary>
        /// <pre><c>From Amazon DynamoDB. Serialization of recursive structures. </c></pre>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutItem service method.</param>
        /// 
        /// <returns>The response from the PutItem service method, as returned by RpcCborDataPlane.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpccbordataplane-1999-12-31/PutItem">REST API Reference for PutItem Operation</seealso>
        PutItemResponse PutItem(PutItemRequest request);



        /// <summary>
        /// <pre><c>From Amazon DynamoDB. Serialization of recursive structures. </c></pre>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutItem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutItem service method, as returned by RpcCborDataPlane.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpccbordataplane-1999-12-31/PutItem">REST API Reference for PutItem Operation</seealso>
        Task<PutItemResponse> PutItemAsync(PutItemRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutMetricData


        /// <summary>
        /// <pre><c>As seen in Amazon CloudWatch. </c></pre>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutMetricData service method.</param>
        /// 
        /// <returns>The response from the PutMetricData service method, as returned by RpcCborDataPlane.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpccbordataplane-1999-12-31/PutMetricData">REST API Reference for PutMetricData Operation</seealso>
        PutMetricDataResponse PutMetricData(PutMetricDataRequest request);



        /// <summary>
        /// <pre><c>As seen in Amazon CloudWatch. </c></pre>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutMetricData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutMetricData service method, as returned by RpcCborDataPlane.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpccbordataplane-1999-12-31/PutMetricData">REST API Reference for PutMetricData Operation</seealso>
        Task<PutMetricDataResponse> PutMetricDataAsync(PutMetricDataRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}