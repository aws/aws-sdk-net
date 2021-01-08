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
 * Do not modify this file. This file is generated from the sso-admin-2020-07-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SSOAdmin.Model
{
    /// <summary>
    /// Container for the parameters to the UpdatePermissionSet operation.
    /// Updates an existing permission set.
    /// </summary>
    public partial class UpdatePermissionSetRequest : AmazonSSOAdminRequest
    {
        private string _description;
        private string _instanceArn;
        private string _permissionSetArn;
        private string _relayState;
        private string _sessionDuration;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the <a>PermissionSet</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=700)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceArn. 
        /// <para>
        /// The ARN of the SSO instance under which the operation will be executed. For more information
        /// about ARNs, see <a href="/general/latest/gr/aws-arns-and-namespaces.html">Amazon Resource
        /// Names (ARNs) and AWS Service Namespaces</a> in the <i>AWS General Reference</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=1224)]
        public string InstanceArn
        {
            get { return this._instanceArn; }
            set { this._instanceArn = value; }
        }

        // Check to see if InstanceArn property is set
        internal bool IsSetInstanceArn()
        {
            return this._instanceArn != null;
        }

        /// <summary>
        /// Gets and sets the property PermissionSetArn. 
        /// <para>
        /// The ARN of the permission set.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=1224)]
        public string PermissionSetArn
        {
            get { return this._permissionSetArn; }
            set { this._permissionSetArn = value; }
        }

        // Check to see if PermissionSetArn property is set
        internal bool IsSetPermissionSetArn()
        {
            return this._permissionSetArn != null;
        }

        /// <summary>
        /// Gets and sets the property RelayState. 
        /// <para>
        /// Used to redirect users within the application during the federation authentication
        /// process.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=240)]
        public string RelayState
        {
            get { return this._relayState; }
            set { this._relayState = value; }
        }

        // Check to see if RelayState property is set
        internal bool IsSetRelayState()
        {
            return this._relayState != null;
        }

        /// <summary>
        /// Gets and sets the property SessionDuration. 
        /// <para>
        /// The length of time that the application user sessions are valid for in the ISO-8601
        /// standard.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string SessionDuration
        {
            get { return this._sessionDuration; }
            set { this._sessionDuration = value; }
        }

        // Check to see if SessionDuration property is set
        internal bool IsSetSessionDuration()
        {
            return this._sessionDuration != null;
        }

    }
}