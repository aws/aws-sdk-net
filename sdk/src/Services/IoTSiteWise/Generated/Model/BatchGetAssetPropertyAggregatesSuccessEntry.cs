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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Contains success information for an entry that is associated with the <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_BatchGetAssetPropertyAggregates.html">BatchGetAssetPropertyAggregates</a>
    /// API.
    /// </summary>
    public partial class BatchGetAssetPropertyAggregatesSuccessEntry
    {
        private List<AggregatedValue> _aggregatedValues = new List<AggregatedValue>();
        private string _entryId;

        /// <summary>
        /// Gets and sets the property AggregatedValues. 
        /// <para>
        /// The requested aggregated asset property values (for example, average, minimum, and
        /// maximum).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<AggregatedValue> AggregatedValues
        {
            get { return this._aggregatedValues; }
            set { this._aggregatedValues = value; }
        }

        // Check to see if AggregatedValues property is set
        internal bool IsSetAggregatedValues()
        {
            return this._aggregatedValues != null && this._aggregatedValues.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EntryId. 
        /// <para>
        /// The ID of the entry.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string EntryId
        {
            get { return this._entryId; }
            set { this._entryId = value; }
        }

        // Check to see if EntryId property is set
        internal bool IsSetEntryId()
        {
            return this._entryId != null;
        }

    }
}