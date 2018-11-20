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
        /// Executes any SQL statement on the target database synchronously
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteSql service method.</param>
        /// 
        /// <returns>The response from the ExecuteSql service method, as returned by RDSDataService.</returns>
        /// <exception cref="Amazon.RDSDataService.Model.BadRequestException">
        /// Invalid Request exception
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.ForbiddenException">
        /// Access denied exception
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.InternalServerErrorException">
        /// Internal service error
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.ServiceUnavailableErrorException">
        /// Internal service unavailable error
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-data-2018-08-01/ExecuteSql">REST API Reference for ExecuteSql Operation</seealso>
        ExecuteSqlResponse ExecuteSql(ExecuteSqlRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ExecuteSql operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExecuteSql operation on AmazonRDSDataServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExecuteSql
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-data-2018-08-01/ExecuteSql">REST API Reference for ExecuteSql Operation</seealso>
        IAsyncResult BeginExecuteSql(ExecuteSqlRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ExecuteSql operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExecuteSql.</param>
        /// 
        /// <returns>Returns a  ExecuteSqlResult from RDSDataService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-data-2018-08-01/ExecuteSql">REST API Reference for ExecuteSql Operation</seealso>
        ExecuteSqlResponse EndExecuteSql(IAsyncResult asyncResult);

        #endregion
        
    }
}