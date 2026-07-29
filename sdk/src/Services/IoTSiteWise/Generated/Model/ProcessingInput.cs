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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// &lt;p&gt;Input source for processing. Specify exactly one option.&lt;/p&gt;
    /// </summary>
    public partial class ProcessingInput
    {
        private DatasetItem _dataset;
        private List<TimeseriesItem> _timeseries = AWSConfigs.InitializeCollections ? new List<TimeseriesItem>() : null;

        /// <summary>
        /// Gets and sets the property Dataset. &lt;p&gt;A dataset containing multiple items to
        /// process.&lt;/p&gt;
        /// </summary>
        public DatasetItem Dataset
        {
            get { return this._dataset; }
            set { this._dataset = value; }
        }

        // Check to see if Dataset property is set
        internal bool IsSetDataset()
        {
            return this._dataset != null;
        }

        /// <summary>
        /// Gets and sets the property Timeseries. &lt;p&gt;List of individual timeseries items
        /// to process.&lt;/p&gt;
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<TimeseriesItem> Timeseries
        {
            get { return this._timeseries; }
            set { this._timeseries = value; }
        }

        // Check to see if Timeseries property is set
        internal bool IsSetTimeseries()
        {
            return this._timeseries != null && (this._timeseries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}