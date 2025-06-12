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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.RDSDataService.Model
{
    /// <summary>
    /// The response elements represent the output of a SQL statement over an array of data.
    /// </summary>
    public partial class BatchExecuteStatementResponse : AmazonWebServiceResponse
    {
        private List<UpdateResult> _updateResults = AWSConfigs.InitializeCollections ? new List<UpdateResult>() : null;

        /// <summary>
        /// Gets and sets the property UpdateResults. 
        /// <para>
        /// The execution results of each batch entry.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UpdateResult> UpdateResults
        {
            get { return this._updateResults; }
            set { this._updateResults = value; }
        }

        // Check to see if UpdateResults property is set
        internal bool IsSetUpdateResults()
        {
            return this._updateResults != null && (this._updateResults.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}