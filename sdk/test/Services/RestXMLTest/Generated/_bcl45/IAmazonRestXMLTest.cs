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
 * Do not modify this file. This file is generated from the rest-xml-test-2014-01-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.RestXMLTest.Model;

namespace Amazon.RestXMLTest
{
    /// <summary>
    /// Interface for accessing RestXMLTest
    ///
    /// 
    /// </summary>
    public partial interface IAmazonRestXMLTest : IAmazonService, IDisposable
    {


        
        #region  TestOperation


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestOperation service method.</param>
        /// 
        /// <returns>The response from the TestOperation service method, as returned by RestXMLTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2014-01-01/TestOperation">REST API Reference for TestOperation Operation</seealso>
        TestOperationResponse TestOperation(TestOperationRequest request);



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TestOperation service method, as returned by RestXMLTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/test-2014-01-01/TestOperation">REST API Reference for TestOperation Operation</seealso>
        Task<TestOperationResponse> TestOperationAsync(TestOperationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}