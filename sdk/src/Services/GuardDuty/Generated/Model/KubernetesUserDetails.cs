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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Details about the Kubernetes user involved in a Kubernetes finding.
    /// </summary>
    public partial class KubernetesUserDetails
    {
        private List<string> _groups = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ImpersonatedUser _impersonatedUser;
        private List<string> _sessionName = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _uid;
        private string _username;

        /// <summary>
        /// Gets and sets the property Groups. 
        /// <para>
        /// The groups that include the user who called the Kubernetes API.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Groups
        {
            get { return this._groups; }
            set { this._groups = value; }
        }

        // Check to see if Groups property is set
        internal bool IsSetGroups()
        {
            return this._groups != null && (this._groups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ImpersonatedUser. 
        /// <para>
        /// Information about the impersonated user.
        /// </para>
        /// </summary>
        public ImpersonatedUser ImpersonatedUser
        {
            get { return this._impersonatedUser; }
            set { this._impersonatedUser = value; }
        }

        // Check to see if ImpersonatedUser property is set
        internal bool IsSetImpersonatedUser()
        {
            return this._impersonatedUser != null;
        }

        /// <summary>
        /// Gets and sets the property SessionName. 
        /// <para>
        /// Entity that assumes the IAM role when Kubernetes RBAC permissions are assigned to
        /// that role.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SessionName
        {
            get { return this._sessionName; }
            set { this._sessionName = value; }
        }

        // Check to see if SessionName property is set
        internal bool IsSetSessionName()
        {
            return this._sessionName != null && (this._sessionName.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Uid. 
        /// <para>
        /// The user ID of the user who called the Kubernetes API.
        /// </para>
        /// </summary>
        public string Uid
        {
            get { return this._uid; }
            set { this._uid = value; }
        }

        // Check to see if Uid property is set
        internal bool IsSetUid()
        {
            return this._uid != null;
        }

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// The username of the user who called the Kubernetes API.
        /// </para>
        /// </summary>
        public string Username
        {
            get { return this._username; }
            set { this._username = value; }
        }

        // Check to see if Username property is set
        internal bool IsSetUsername()
        {
            return this._username != null;
        }

    }
}