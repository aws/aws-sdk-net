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

namespace Amazon.IoTFleetWise.Model
{
    /// <summary>
    /// Specifies the condition under which a signal fetch occurs.
    /// </summary>
    public partial class ConditionBasedSignalFetchConfig
    {
        /// <summary>
        /// Gets and sets the property ConditionExpression. 
        /// <para>
        /// The condition that must be satisfied to trigger a signal fetch.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 400)]
        public string ConditionExpression { get; set; }

        /// <summary>
        /// Checks to see if the ConditionExpression property is set.
        /// </summary>
        internal bool IsSetConditionExpression() => this.ConditionExpression != null;

        /// <summary>
        /// Gets and sets the property TriggerMode. 
        /// <para>
        /// Indicates the mode in which the signal fetch is triggered.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TriggerMode TriggerMode { get; set; }

        /// <summary>
        /// Checks to see if the TriggerMode property is set.
        /// </summary>
        internal bool IsSetTriggerMode() => this.TriggerMode != null;
    }
}
