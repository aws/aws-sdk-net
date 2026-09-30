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

namespace Amazon.ConnectCampaignsV2.Model
{
    /// <summary>
    /// Campaign entry limits config
    /// </summary>
    public partial class EntryLimitsConfig
    {
        /// <summary>
        /// Gets and sets the property MaxEntryCount. Maximum number of times a participant can
        /// enter the campaign. A value of 0 indicates unlimited entries. Values of 1 or greater
        /// specify the exact number of entries allowed.
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? MaxEntryCount { get; set; }

        /// <summary>
        /// Checks to see if the MaxEntryCount property is set.
        /// </summary>
        internal bool IsSetMaxEntryCount() => this.MaxEntryCount.HasValue;

        /// <summary>
        /// Gets and sets the property MinEntryInterval. Minimum time interval that must pass
        /// before a participant can enter the campaign again.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 50)]
        public string MinEntryInterval { get; set; }

        /// <summary>
        /// Checks to see if the MinEntryInterval property is set.
        /// </summary>
        internal bool IsSetMinEntryInterval() => this.MinEntryInterval != null;
    }
}
