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
    /// Provides information about a monitor in Deadline Cloud.
    /// </summary>
    public partial class MonitorSummary
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The UNIX timestamp of the date and time that the monitor was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The user name of the person that created the monitor.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The name of the monitor that displays on the Deadline Cloud console.
        /// </para>
        ///  <important> 
        /// <para>
        /// This field can store any content. Escape or encode this content before displaying
        /// it on a webpage or any other system that might interpret the content of this field.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property IdentityCenterApplicationArn. 
        /// <para>
        /// The Amazon Resource Name that the IAM Identity Center assigned to the monitor when
        /// it was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string IdentityCenterApplicationArn { get; set; }

        /// <summary>
        /// Checks to see if the IdentityCenterApplicationArn property is set.
        /// </summary>
        internal bool IsSetIdentityCenterApplicationArn() => this.IdentityCenterApplicationArn != null;

        /// <summary>
        /// Gets and sets the property IdentityCenterInstanceArn. 
        /// <para>
        /// The Amazon Resource Name of the IAM Identity Center instance responsible for authenticating
        /// monitor users.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string IdentityCenterInstanceArn { get; set; }

        /// <summary>
        /// Checks to see if the IdentityCenterInstanceArn property is set.
        /// </summary>
        internal bool IsSetIdentityCenterInstanceArn() => this.IdentityCenterInstanceArn != null;

        /// <summary>
        /// Gets and sets the property IdentityCenterRegion. 
        /// <para>
        /// The Region where IAM Identity Center is enabled.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 25)]
        public string IdentityCenterRegion { get; set; }

        /// <summary>
        /// Checks to see if the IdentityCenterRegion property is set.
        /// </summary>
        internal bool IsSetIdentityCenterRegion() => this.IdentityCenterRegion != null;

        /// <summary>
        /// Gets and sets the property MonitorId. 
        /// <para>
        /// The unique identifier for the monitor.
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
        /// The Amazon Resource Name of the IAM role for the monitor. Users of the monitor use
        /// this role to access Deadline Cloud resources.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property Subdomain. 
        /// <para>
        /// The subdomain used for the monitor URL. The full URL of the monitor is subdomain.Region.deadlinecloud.amazonaws.com.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Subdomain { get; set; }

        /// <summary>
        /// Checks to see if the Subdomain property is set.
        /// </summary>
        internal bool IsSetSubdomain() => this.Subdomain != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The UNIX timestamp of the date and time that the monitor was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property UpdatedBy. 
        /// <para>
        /// The user name of the person that last updated the monitor.
        /// </para>
        /// </summary>
        public string UpdatedBy { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedBy property is set.
        /// </summary>
        internal bool IsSetUpdatedBy() => this.UpdatedBy != null;

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The complete URL of the monitor. The full URL of the monitor is subdomain.Region.deadlinecloud.amazonaws.com.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Url { get; set; }

        /// <summary>
        /// Checks to see if the Url property is set.
        /// </summary>
        internal bool IsSetUrl() => this.Url != null;
    }
}
