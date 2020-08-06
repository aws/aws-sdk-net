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
 * Do not modify this file. This file is generated from the rds-data-2018-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDSDataService.Model
{
    /// <summary>
    /// The response elements represent the output of a SQL statement over an array of data.
    /// </summary>
    public partial class BatchExecuteStatementResponse : AmazonWebServiceResponse
    {
        private List<UpdateResult> _updateResults = new List<UpdateResult>();

        /// <summary>
        /// Gets and sets the property UpdateResults. 
        /// <para>
        /// The execution results of each batch entry.
        /// </para>
        /// </summary>
        public List<UpdateResult> UpdateResults
        {
            get { return this._updateResults; }
            set { this._updateResults = value; }
        }

        // Check to see if UpdateResults property is set
        internal bool IsSetUpdateResults()
        {
            return this._updateResults != null && this._updateResults.Count > 0; 
        }

    }
}