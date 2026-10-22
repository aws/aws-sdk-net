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

namespace Amazon.Deadline.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateMonitor operation. Modifies the settings
    /// for a Deadline Cloud monitor. You can modify one or all of the settings when you call
    /// <c>UpdateMonitor</c>.
    /// </summary>
    public partial class UpdateMonitorRequest : AmazonDeadlineRequest
    {
        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The new value to use for the monitor's display name.
        /// </para>
        ///  <important> 
        /// <para>
        /// This field can store any content. Escape or encode this content before displaying
        /// it on a webpage or any other system that might interpret the content of this field.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property MonitorId. 
        /// <para>
        /// The unique identifier of the monitor to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string MonitorId { get; set; }

        /// <summary>
        /// Checks to see if the MonitorId property is set.
        /// </summary>
        internal bool IsSetMonitorId() => this.MonitorId != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name of the new IAM role to use with the monitor.
        /// </para>
        /// </summary>
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property Subdomain. 
        /// <para>
        /// The new value of the subdomain to use when forming the monitor URL.
        /// </para>
        /// </summary>
        public string Subdomain { get; set; }

        /// <summary>
        /// Checks to see if the Subdomain property is set.
        /// </summary>
        internal bool IsSetSubdomain() => this.Subdomain != null;
    }
}
