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
    /// Sets the number of <i>concurrent processes</i> that transfer OData records from your
    /// SAP instance. A concurrent process is query that retrieves a batch of records as part
    /// of a flow run. Amazon AppFlow can run multiple concurrent processes in parallel to
    /// transfer data faster.
    /// </summary>
    public partial class SAPODataParallelismConfig
    {
        private int? _maxParallelism;

        /// <summary>
        /// Gets and sets the property MaxParallelism. 
        /// <para>
        /// The maximum number of processes that Amazon AppFlow runs at the same time when it
        /// retrieves your data from your SAP application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public int? MaxParallelism
        {
            get { return this._maxParallelism; }
            set { this._maxParallelism = value; }
        }

        // Check to see if MaxParallelism property is set
        internal bool IsSetMaxParallelism()
        {
            return this._maxParallelism.HasValue; 
        }

    }
}