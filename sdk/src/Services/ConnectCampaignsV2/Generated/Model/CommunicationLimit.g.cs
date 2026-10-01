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
    /// Communication Limit
    /// </summary>
    public partial class CommunicationLimit
    {
        /// <summary>
        /// Gets and sets the property Frequency. The number of days to consider with regards
        /// to this limit.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 30)]
        public int? Frequency { get; set; }

        /// <summary>
        /// Checks to see if the Frequency property is set.
        /// </summary>
        internal bool IsSetFrequency() => this.Frequency.HasValue;

        /// <summary>
        /// Gets and sets the property MaxCountPerRecipient. Maximum number of contacts allowed
        /// for a given target within the given frequency.
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public int? MaxCountPerRecipient { get; set; }

        /// <summary>
        /// Checks to see if the MaxCountPerRecipient property is set.
        /// </summary>
        internal bool IsSetMaxCountPerRecipient() => this.MaxCountPerRecipient.HasValue;

        /// <summary>
        /// Gets and sets the property Unit.
        /// </summary>
        [AWSProperty(Required = true)]
        public CommunicationLimitTimeUnit Unit { get; set; }

        /// <summary>
        /// Checks to see if the Unit property is set.
        /// </summary>
        internal bool IsSetUnit() => this.Unit != null;
    }
}
