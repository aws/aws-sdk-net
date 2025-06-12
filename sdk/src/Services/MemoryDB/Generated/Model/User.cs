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
 * Do not modify this file. This file is generated from the memorydb-2021-01-01.normal.json service model.
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
namespace Amazon.MemoryDB.Model
{
    /// <summary>
    /// You create users and assign them specific permissions by using an access string. You
    /// assign the users to Access Control Lists aligned with a specific role (administrators,
    /// human resources) that are then deployed to one or more MemoryDB clusters.
    /// </summary>
    public partial class User
    {
        private string _accessString;
        private List<string> _aclNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _arn;
        private Authentication _authentication;
        private string _minimumEngineVersion;
        private string _name;
        private string _status;

        /// <summary>
        /// Gets and sets the property AccessString. 
        /// <para>
        /// Access permissions string used for this user.
        /// </para>
        /// </summary>
        public string AccessString
        {
            get { return this._accessString; }
            set { this._accessString = value; }
        }

        // Check to see if AccessString property is set
        internal bool IsSetAccessString()
        {
            return this._accessString != null;
        }

        /// <summary>
        /// Gets and sets the property ACLNames. 
        /// <para>
        /// The names of the Access Control Lists to which the user belongs
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ACLNames
        {
            get { return this._aclNames; }
            set { this._aclNames = value; }
        }

        // Check to see if ACLNames property is set
        internal bool IsSetACLNames()
        {
            return this._aclNames != null && (this._aclNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the user. 
        /// </para>
        /// </summary>
        public string ARN
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if ARN property is set
        internal bool IsSetARN()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Authentication. 
        /// <para>
        /// Denotes whether the user requires a password to authenticate.
        /// </para>
        /// </summary>
        public Authentication Authentication
        {
            get { return this._authentication; }
            set { this._authentication = value; }
        }

        // Check to see if Authentication property is set
        internal bool IsSetAuthentication()
        {
            return this._authentication != null;
        }

        /// <summary>
        /// Gets and sets the property MinimumEngineVersion. 
        /// <para>
        /// The minimum engine version supported for the user
        /// </para>
        /// </summary>
        public string MinimumEngineVersion
        {
            get { return this._minimumEngineVersion; }
            set { this._minimumEngineVersion = value; }
        }

        // Check to see if MinimumEngineVersion property is set
        internal bool IsSetMinimumEngineVersion()
        {
            return this._minimumEngineVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the user
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Indicates the user status. Can be "active", "modifying" or "deleting".
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}