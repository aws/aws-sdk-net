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

namespace Amazon.RTBFabric.Model
{
    /// <summary>
    /// Describes a link application log sample.
    /// </summary>
    public partial class LinkApplicationLogSampling
    {
        /// <summary>
        /// Gets and sets the property ErrorLog. 
        /// <para>
        /// An error log entry.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 100)]
        public double? ErrorLog { get; set; }

        /// <summary>
        /// Checks to see if the ErrorLog property is set.
        /// </summary>
        internal bool IsSetErrorLog() => this.ErrorLog.HasValue;

        /// <summary>
        /// Gets and sets the property FilterLog. 
        /// <para>
        /// A filter log entry.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 100)]
        public double? FilterLog { get; set; }

        /// <summary>
        /// Checks to see if the FilterLog property is set.
        /// </summary>
        internal bool IsSetFilterLog() => this.FilterLog.HasValue;
    }
}
