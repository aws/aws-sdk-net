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
 * Do not modify this file. This file is generated from the workdocs-2016-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkDocs.Model
{
    /// <summary>
    /// Container for the parameters to the AddResourcePermissions operation.
    /// Creates a set of permissions for the specified folder or document. The resource permissions
    /// are overwritten if the principals already have different permissions.
    /// </summary>
    public partial class AddResourcePermissionsRequest : AmazonWorkDocsRequest
    {
        private string _authenticationToken;
        private NotificationOptions _notificationOptions;
        private List<SharePrincipal> _principals = new List<SharePrincipal>();
        private string _resourceId;

        /// <summary>
        /// Gets and sets the property AuthenticationToken. 
        /// <para>
        /// Amazon WorkDocs authentication token. Not required when using Amazon Web Services
        /// administrator credentials to access the API.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=8199)]
        public string AuthenticationToken
        {
            get { return this._authenticationToken; }
            set { this._authenticationToken = value; }
        }

        // Check to see if AuthenticationToken property is set
        internal bool IsSetAuthenticationToken()
        {
            return this._authenticationToken != null;
        }

        /// <summary>
        /// Gets and sets the property NotificationOptions. 
        /// <para>
        /// The notification options.
        /// </para>
        /// </summary>
        public NotificationOptions NotificationOptions
        {
            get { return this._notificationOptions; }
            set { this._notificationOptions = value; }
        }

        // Check to see if NotificationOptions property is set
        internal bool IsSetNotificationOptions()
        {
            return this._notificationOptions != null;
        }

        /// <summary>
        /// Gets and sets the property Principals. 
        /// <para>
        /// The users, groups, or organization being granted permission.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<SharePrincipal> Principals
        {
            get { return this._principals; }
            set { this._principals = value; }
        }

        // Check to see if Principals property is set
        internal bool IsSetPrincipals()
        {
            return this._principals != null && this._principals.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The ID of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

    }
}