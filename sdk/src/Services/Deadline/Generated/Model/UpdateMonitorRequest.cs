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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
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
    /// Container for the parameters to the UpdateMonitor operation.
    /// Modifies the settings for a Deadline Cloud monitor. You can modify one or all of the
    /// settings when you call <c>UpdateMonitor</c>.
    /// </summary>
    public partial class UpdateMonitorRequest : AmazonDeadlineRequest
    {
        private string _displayName;
        private string _monitorId;
        private string _roleArn;
        private string _subdomain;

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
        [AWSProperty(Min=1, Max=100)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property MonitorId. 
        /// <para>
        /// The unique identifier of the monitor to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string MonitorId
        {
            get { return this._monitorId; }
            set { this._monitorId = value; }
        }

        // Check to see if MonitorId property is set
        internal bool IsSetMonitorId()
        {
            return this._monitorId != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the new IAM role to use with the monitor.
        /// </para>
        /// </summary>
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Subdomain. 
        /// <para>
        /// The new value of the subdomain to use when forming the monitor URL.
        /// </para>
        /// </summary>
        public string Subdomain
        {
            get { return this._subdomain; }
            set { this._subdomain = value; }
        }

        // Check to see if Subdomain property is set
        internal bool IsSetSubdomain()
        {
            return this._subdomain != null;
        }

    }
}