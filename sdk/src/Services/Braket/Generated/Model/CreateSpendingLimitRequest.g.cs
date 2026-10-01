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

namespace Amazon.Braket.Model
{
    /// <summary>
    /// Container for the parameters to the CreateSpendingLimit operation. Creates a spending
    /// limit for a specified quantum device. Spending limits help you control costs by setting
    /// maximum amounts that can be spent on quantum computing tasks within a specified time
    /// period. Simulators do not support spending limits.
    /// </summary>
    public partial class CreateSpendingLimitRequest : AmazonBraketRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure that the operation completes no more
        /// than one time. If this token matches a previous request, Amazon Braket ignores the
        /// request, but does not return an error.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property DeviceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the quantum device to apply the spending limit to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string DeviceArn { get; set; }

        /// <summary>
        /// Checks to see if the DeviceArn property is set.
        /// </summary>
        internal bool IsSetDeviceArn() => this.DeviceArn != null;

        /// <summary>
        /// Gets and sets the property SpendingLimit. 
        /// <para>
        /// The maximum amount that can be spent on the specified device, in USD.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string SpendingLimit { get; set; }

        /// <summary>
        /// Checks to see if the SpendingLimit property is set.
        /// </summary>
        internal bool IsSetSpendingLimit() => this.SpendingLimit != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to apply to the spending limit. Each tag consists of a key and an optional
        /// value.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TimePeriod. 
        /// <para>
        /// The time period during which the spending limit is active, including start and end
        /// dates.
        /// </para>
        /// </summary>
        public TimePeriod TimePeriod { get; set; }

        /// <summary>
        /// Checks to see if the TimePeriod property is set.
        /// </summary>
        internal bool IsSetTimePeriod() => this.TimePeriod != null;
    }
}
