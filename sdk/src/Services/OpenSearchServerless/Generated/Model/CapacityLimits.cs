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
 * Do not modify this file. This file is generated from the opensearchserverless-2021-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpenSearchServerless.Model
{
    /// <summary>
    /// The maximum capacity limits for all OpenSearch Serverless collections, in OpenSearch
    /// Compute Units (OCUs). These limits are used to scale your collections based on the
    /// current workload. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-overview.html#serverless-scaling">Autoscaling</a>.
    /// </summary>
    public partial class CapacityLimits
    {
        private int? _maxIndexingCapacityInOCU;
        private int? _maxSearchCapacityInOCU;

        /// <summary>
        /// Gets and sets the property MaxIndexingCapacityInOCU. 
        /// <para>
        /// The maximum indexing capacity for collections.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2)]
        public int MaxIndexingCapacityInOCU
        {
            get { return this._maxIndexingCapacityInOCU.GetValueOrDefault(); }
            set { this._maxIndexingCapacityInOCU = value; }
        }

        // Check to see if MaxIndexingCapacityInOCU property is set
        internal bool IsSetMaxIndexingCapacityInOCU()
        {
            return this._maxIndexingCapacityInOCU.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxSearchCapacityInOCU. 
        /// <para>
        /// The maximum search capacity for collections.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2)]
        public int MaxSearchCapacityInOCU
        {
            get { return this._maxSearchCapacityInOCU.GetValueOrDefault(); }
            set { this._maxSearchCapacityInOCU = value; }
        }

        // Check to see if MaxSearchCapacityInOCU property is set
        internal bool IsSetMaxSearchCapacityInOCU()
        {
            return this._maxSearchCapacityInOCU.HasValue; 
        }

    }
}