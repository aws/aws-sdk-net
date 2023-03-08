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
 * Do not modify this file. This file is generated from the lakeformation-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LakeFormation.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDataCellsFilter operation.
    /// Updates a data cell filter.
    /// </summary>
    public partial class UpdateDataCellsFilterRequest : AmazonLakeFormationRequest
    {
        private DataCellsFilter _tableData;

        /// <summary>
        /// Gets and sets the property TableData. 
        /// <para>
        /// A <code>DataCellsFilter</code> structure containing information about the data cells
        /// filter.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DataCellsFilter TableData
        {
            get { return this._tableData; }
            set { this._tableData = value; }
        }

        // Check to see if TableData property is set
        internal bool IsSetTableData()
        {
            return this._tableData != null;
        }

    }
}