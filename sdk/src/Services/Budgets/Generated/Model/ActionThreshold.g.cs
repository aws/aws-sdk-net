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

namespace Amazon.Budgets.Model
{
    /// <summary>
    /// The trigger threshold of the action.
    /// </summary>
    public partial class ActionThreshold
    {
        /// <summary>
        /// Gets and sets the property ActionThresholdType.
        /// </summary>
        [AWSProperty(Required = true)]
        public ThresholdType ActionThresholdType { get; set; }

        /// <summary>
        /// Checks to see if the ActionThresholdType property is set.
        /// </summary>
        internal bool IsSetActionThresholdType() => this.ActionThresholdType != null;

        /// <summary>
        /// Gets and sets the property ActionThresholdValue.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 15000000000000)]
        public double? ActionThresholdValue { get; set; }

        /// <summary>
        /// Checks to see if the ActionThresholdValue property is set.
        /// </summary>
        internal bool IsSetActionThresholdValue() => this.ActionThresholdValue.HasValue;
    }
}
