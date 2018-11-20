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
 * Do not modify this file. This file is generated from the rds-data-2018-08-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.RDSDataService.Model;

namespace Amazon.RDSDataService
{
    /// <summary>
    /// Interface for accessing RDSDataService
    ///
    /// AWS RDS DataService provides Http Endpoint to query RDS databases.
    /// </summary>
    public partial interface IAmazonRDSDataService : IAmazonService, IDisposable
    {
                
        #region  ExecuteSql


        /// <summary>
        /// Initiates the asynchronous execution of the ExecuteSql operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExecuteSql operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-data-2018-08-01/ExecuteSql">REST API Reference for ExecuteSql Operation</seealso>
        Task<ExecuteSqlResponse> ExecuteSqlAsync(ExecuteSqlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}