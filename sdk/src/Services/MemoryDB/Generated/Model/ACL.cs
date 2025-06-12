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
    /// An Access Control List. You can authenticate users with Access Contol Lists. ACLs
    /// enable you to control cluster access by grouping users. These Access control lists
    /// are designed as a way to organize access to clusters.
    /// </summary>
    public partial class ACL
    {
        private string _arn;
        private List<string> _clusters = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _minimumEngineVersion;
        private string _name;
        private ACLPendingChanges _pendingChanges;
        private string _status;
        private List<string> _userNames = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the ACL
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
        /// Gets and sets the property Clusters. 
        /// <para>
        /// A list of clusters associated with the ACL.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Clusters
        {
            get { return this._clusters; }
            set { this._clusters = value; }
        }

        // Check to see if Clusters property is set
        internal bool IsSetClusters()
        {
            return this._clusters != null && (this._clusters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MinimumEngineVersion. 
        /// <para>
        /// The minimum engine version supported for the ACL
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
        /// The name of the Access Control List
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
        /// Gets and sets the property PendingChanges. 
        /// <para>
        /// A list of updates being applied to the ACL.
        /// </para>
        /// </summary>
        public ACLPendingChanges PendingChanges
        {
            get { return this._pendingChanges; }
            set { this._pendingChanges = value; }
        }

        // Check to see if PendingChanges property is set
        internal bool IsSetPendingChanges()
        {
            return this._pendingChanges != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Indicates ACL status. Can be "creating", "active", "modifying", "deleting".
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

        /// <summary>
        /// Gets and sets the property UserNames. 
        /// <para>
        /// The list of user names that belong to the ACL.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> UserNames
        {
            get { return this._userNames; }
            set { this._userNames = value; }
        }

        // Check to see if UserNames property is set
        internal bool IsSetUserNames()
        {
            return this._userNames != null && (this._userNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}