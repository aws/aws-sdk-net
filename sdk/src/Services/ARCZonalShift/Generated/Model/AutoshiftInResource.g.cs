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
    /// A complex structure that lists an autoshift that is currently active for a managed
    /// resource and information about the autoshift.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/arc-zonal-autoshift.how-it-works.html">How
    /// zonal autoshift and practice runs work</a> in the Amazon Application Recovery Controller
    /// Developer Guide.
    /// </para>
    /// </summary>
    public partial class AutoshiftInResource
    {
        /// <summary>
        /// Gets and sets the property AppliedStatus. 
        /// <para>
        /// The <c>appliedStatus</c> field specifies which application traffic shift is in effect
        /// for a resource when there is more than one active traffic shift. There can be more
        /// than one application traffic shift in progress at the same time - that is, practice
        /// run zonal shifts, customer-initiated zonal shifts, or an autoshift. The <c>appliedStatus</c>
        /// field for a shift that is in progress for a resource can have one of two values: <c>APPLIED</c>
        /// or <c>NOT_APPLIED</c>. The zonal shift or autoshift that is currently in effect for
        /// the resource has an <c>appliedStatus</c> set to <c>APPLIED</c>.
        /// </para>
        ///  
        /// <para>
        /// The overall principle for precedence is that zonal shifts that you start as a customer
        /// take precedence autoshifts, which take precedence over practice runs. That is, customer-initiated
        /// zonal shifts &gt; autoshifts &gt; practice run zonal shifts.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/arc-zonal-autoshift.how-it-works.html">How
        /// zonal autoshift and practice runs work</a> in the Amazon Application Recovery Controller
        /// Developer Guide.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AutoshiftAppliedStatus AppliedStatus { get; set; }

        /// <summary>
        /// Checks to see if the AppliedStatus property is set.
        /// </summary>
        internal bool IsSetAppliedStatus() => this.AppliedStatus != null;

        /// <summary>
        /// Gets and sets the property AwayFrom. 
        /// <para>
        /// The Availability Zone (for example, <c>use1-az1</c>) that traffic is shifted away
        /// from for a resource, when Amazon Web Services starts an autoshift. Until the autoshift
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
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time (UTC) when the autoshift started.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;
    }
}
