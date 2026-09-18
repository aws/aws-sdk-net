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

namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// An insight describing a usage pattern and the signals detected.
    /// </summary>
    public partial class Insight
    {
        /// <summary>
        /// Gets and sets the property SignalsDetected. 
        /// <para>
        /// A description of the signals detected.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 30, Max = 1500)]
        public string SignalsDetected { get; set; }

        /// <summary>
        /// Checks to see if the SignalsDetected property is set.
        /// </summary>
        internal bool IsSetSignalsDetected() => this.SignalsDetected != null;

        /// <summary>
        /// Gets and sets the property UsagePattern. 
        /// <para>
        /// A description of the usage pattern.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 100, Max = 2000)]
        public string UsagePattern { get; set; }

        /// <summary>
        /// Checks to see if the UsagePattern property is set.
        /// </summary>
        internal bool IsSetUsagePattern() => this.UsagePattern != null;
    }
}
