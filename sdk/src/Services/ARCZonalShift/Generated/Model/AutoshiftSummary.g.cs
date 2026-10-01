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

namespace Amazon.ARCZonalShift.Model
{
    /// <summary>
    /// Information about an autoshift. Amazon Web Services starts an autoshift to temporarily
    /// move traffic for a resource away from an Availability Zone in an Amazon Web Services
    /// Region when Amazon Web Services determines that there's an issue in the Availability
    /// Zone that could potentially affect customers. You can configure zonal autoshift in
    /// ARC for managed resources in your Amazon Web Services account in a Region. Supported
    /// Amazon Web Services resources are automatically registered with ARC.
    /// 
    ///  
    /// <para>
    /// Autoshifts are temporary. When the Availability Zone recovers, Amazon Web Services
    /// ends the autoshift, and traffic for the resource is no longer directed to the other
    /// Availability Zones in the Region.
    /// </para>
    ///  
    /// <para>
    /// You can stop an autoshift for a resource by disabling zonal autoshift.
    /// </para>
    /// </summary>
    public partial class AutoshiftSummary
    {
        /// <summary>
        /// Gets and sets the property AwayFrom. 
        /// <para>
        /// The Availability Zone (for example, <c>use1-az1</c>) that traffic is shifted away
        /// from for a resource when Amazon Web Services starts an autoshift. Until the autoshift
        /// ends, traffic for the resource is instead directed to other Availability Zones in
        /// the Amazon Web Services Region. An autoshift can end for a resource, for example,
        /// when Amazon Web Services ends the autoshift for the Availability Zone or when you
        /// disable zonal autoshift for the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 20)]
        public string AwayFrom { get; set; }

        /// <summary>
        /// Checks to see if the AwayFrom property is set.
        /// </summary>
        internal bool IsSetAwayFrom() => this.AwayFrom != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time (in UTC) when the autoshift ended.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time (in UTC) when the autoshift started.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status for an autoshift. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AutoshiftExecutionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
