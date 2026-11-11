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

namespace Amazon.AppMesh.Model
{
    /// <summary>
    /// An object that represents the outlier detection for a virtual node's listener.
    /// </summary>
    public partial class OutlierDetection
    {
        /// <summary>
        /// Gets and sets the property BaseEjectionDuration. 
        /// <para>
        /// The base amount of time for which a host is ejected.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Duration BaseEjectionDuration { get; set; }

        /// <summary>
        /// Checks to see if the BaseEjectionDuration property is set.
        /// </summary>
        internal bool IsSetBaseEjectionDuration() => this.BaseEjectionDuration != null;

        /// <summary>
        /// Gets and sets the property Interval. 
        /// <para>
        /// The time interval between ejection sweep analysis.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Duration Interval { get; set; }

        /// <summary>
        /// Checks to see if the Interval property is set.
        /// </summary>
        internal bool IsSetInterval() => this.Interval != null;

        /// <summary>
        /// Gets and sets the property MaxEjectionPercent. 
        /// <para>
        /// Maximum percentage of hosts in load balancing pool for upstream service that can be
        /// ejected. Will eject at least one host regardless of the value.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 100)]
        public int? MaxEjectionPercent { get; set; }

        /// <summary>
        /// Checks to see if the MaxEjectionPercent property is set.
        /// </summary>
        internal bool IsSetMaxEjectionPercent() => this.MaxEjectionPercent.HasValue;

        /// <summary>
        /// Gets and sets the property MaxServerErrors. 
        /// <para>
        /// Number of consecutive <c>5xx</c> errors required for ejection. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public long? MaxServerErrors { get; set; }

        /// <summary>
        /// Checks to see if the MaxServerErrors property is set.
        /// </summary>
        internal bool IsSetMaxServerErrors() => this.MaxServerErrors.HasValue;
    }
}
