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
 * Do not modify this file. This file is generated from the supplychain-2024-01-01.normal.json service model.
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
namespace Amazon.SupplyChain.Model
{
    /// <summary>
    /// The dataset options used in dataset source and target configurations.
    /// </summary>
    public partial class DataIntegrationFlowDatasetOptions
    {
        private bool? _dedupeRecords;
        private DataIntegrationFlowLoadType _loadType;

        /// <summary>
        /// Gets and sets the property DedupeRecords. 
        /// <para>
        /// The dataset load option to remove duplicates.
        /// </para>
        /// </summary>
        public bool DedupeRecords
        {
            get { return this._dedupeRecords.GetValueOrDefault(); }
            set { this._dedupeRecords = value; }
        }

        // Check to see if DedupeRecords property is set
        internal bool IsSetDedupeRecords()
        {
            return this._dedupeRecords.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LoadType. 
        /// <para>
        /// The dataset data load type in dataset options.
        /// </para>
        /// </summary>
        public DataIntegrationFlowLoadType LoadType
        {
            get { return this._loadType; }
            set { this._loadType = value; }
        }

        // Check to see if LoadType property is set
        internal bool IsSetLoadType()
        {
            return this._loadType != null;
        }

    }
}