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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Athena.Model
{
    /// <summary>
    /// This is the response object from the GetQueryRuntimeStatistics operation.
    /// </summary>
    public partial class GetQueryRuntimeStatisticsResponse : AmazonWebServiceResponse
    {
        private QueryRuntimeStatistics _queryRuntimeStatistics;

        /// <summary>
        /// Gets and sets the property QueryRuntimeStatistics. 
        /// <para>
        /// Runtime statistics about the query execution.
        /// </para>
        /// </summary>
        public QueryRuntimeStatistics QueryRuntimeStatistics
        {
            get { return this._queryRuntimeStatistics; }
            set { this._queryRuntimeStatistics = value; }
        }

        // Check to see if QueryRuntimeStatistics property is set
        internal bool IsSetQueryRuntimeStatistics()
        {
            return this._queryRuntimeStatistics != null;
        }

    }
}