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
    /// This is the response object from the GetMonitor operation.
    /// </summary>
    public partial class GetMonitorResponse : AmazonWebServiceResponse
    {
        private DateTime? _createdAt;
        private string _createdBy;
        private string _displayName;
        private string _identityCenterApplicationArn;
        private string _identityCenterInstanceArn;
        private string _monitorId;
        private string _roleArn;
        private string _subdomain;
        private DateTime? _updatedAt;
        private string _updatedBy;
        private string _url;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The UNIX timestamp of the date and time that the monitor was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The user name of the person that created the monitor.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CreatedBy
        {
            get { return this._createdBy; }
            set { this._createdBy = value; }
        }

        // Check to see if CreatedBy property is set
        internal bool IsSetCreatedBy()
        {
            return this._createdBy != null;
        }

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The name used to identify the monitor on the Deadline Cloud console.
        /// </para>
        ///  <important> 
        /// <para>
        /// This field can store any content. Escape or encode this content before displaying
        /// it on a webpage or any other system that might interpret the content of this field.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
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
        /// Gets and sets the property IdentityCenterApplicationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that the IAM Identity Center assigned to the monitor
        /// when it was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string IdentityCenterApplicationArn
        {
            get { return this._identityCenterApplicationArn; }
            set { this._identityCenterApplicationArn = value; }
        }

        // Check to see if IdentityCenterApplicationArn property is set
        internal bool IsSetIdentityCenterApplicationArn()
        {
            return this._identityCenterApplicationArn != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityCenterInstanceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM Identity Center instance responsible for
        /// authenticating monitor users.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string IdentityCenterInstanceArn
        {
            get { return this._identityCenterInstanceArn; }
            set { this._identityCenterInstanceArn = value; }
        }

        // Check to see if IdentityCenterInstanceArn property is set
        internal bool IsSetIdentityCenterInstanceArn()
        {
            return this._identityCenterInstanceArn != null;
        }

        /// <summary>
        /// Gets and sets the property MonitorId. 
        /// <para>
        /// The unique identifier for the monitor.
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
        /// The Amazon Resource Name (ARN) of the IAM role for the monitor. Users of the monitor
        /// use this role to access Deadline Cloud resources.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The subdomain used for the monitor URL. The full URL of the monitor is subdomain.Region.deadlinecloud.amazonaws.com.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The UNIX timestamp of the last date and time that the monitor was updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UpdatedBy. 
        /// <para>
        /// The user name of the person that last updated the monitor.
        /// </para>
        /// </summary>
        public string UpdatedBy
        {
            get { return this._updatedBy; }
            set { this._updatedBy = value; }
        }

        // Check to see if UpdatedBy property is set
        internal bool IsSetUpdatedBy()
        {
            return this._updatedBy != null;
        }

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The complete URL of the monitor. The full URL of the monitor is subdomain.Region.deadlinecloud.amazonaws.com.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Url
        {
            get { return this._url; }
            set { this._url = value; }
        }

        // Check to see if Url property is set
        internal bool IsSetUrl()
        {
            return this._url != null;
        }

    }
}