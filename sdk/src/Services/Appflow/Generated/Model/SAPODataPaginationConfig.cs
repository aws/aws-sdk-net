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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
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
namespace Amazon.Appflow.Model
{
    /// <summary>
    /// Sets the page size for each <i>concurrent process</i> that transfers OData records
    /// from your SAP instance. A concurrent process is query that retrieves a batch of records
    /// as part of a flow run. Amazon AppFlow can run multiple concurrent processes in parallel
    /// to transfer data faster.
    /// </summary>
    public partial class SAPODataPaginationConfig
    {
        private int? _maxPageSize;

        /// <summary>
        /// Gets and sets the property MaxPageSize. 
        /// <para>
        /// The maximum number of records that Amazon AppFlow receives in each page of the response
        /// from your SAP application. For transfers of OData records, the maximum page size is
        /// 3,000. For transfers of data that comes from an ODP provider, the maximum page size
        /// is 10,000.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10000)]
        public int? MaxPageSize
        {
            get { return this._maxPageSize; }
            set { this._maxPageSize = value; }
        }

        // Check to see if MaxPageSize property is set
        internal bool IsSetMaxPageSize()
        {
            return this._maxPageSize.HasValue; 
        }

    }
}