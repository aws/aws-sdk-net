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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Input source for processing. Specify exactly one option.
    /// </summary>
    public partial class ProcessingInput
    {
        /// <summary>
        /// Gets and sets the property Dataset. 
        /// <para>
        /// A dataset containing multiple items to process.
        /// </para>
        /// </summary>
        public DatasetItem Dataset { get; set; }

        /// <summary>
        /// Checks to see if the Dataset property is set.
        /// </summary>
        internal bool IsSetDataset() => this.Dataset != null;

        /// <summary>
        /// Gets and sets the property Timeseries. 
        /// <para>
        /// List of individual timeseries items to process.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<TimeseriesItem> Timeseries { get; set; } = AWSConfigs.InitializeCollections ? new List<TimeseriesItem>() : null;

        /// <summary>
        /// Checks to see if the Timeseries property is set.
        /// </summary>
        internal bool IsSetTimeseries() => this.Timeseries != null && (this.Timeseries.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
