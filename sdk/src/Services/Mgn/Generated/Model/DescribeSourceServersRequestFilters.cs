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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Request to filter Source Servers list.
    /// </summary>
    public partial class DescribeSourceServersRequestFilters
    {
        private List<string> _applicationiDs = new List<string>();
        private bool? _isArchived;
        private List<string> _lifeCycleStates = new List<string>();
        private List<string> _replicationTypes = new List<string>();
        private List<string> _sourceServerIDs = new List<string>();

        /// <summary>
        /// Gets and sets the property ApplicationIDs. 
        /// <para>
        /// Request to filter Source Servers list by application IDs.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<string> ApplicationIDs
        {
            get { return this._applicationiDs; }
            set { this._applicationiDs = value; }
        }

        // Check to see if ApplicationIDs property is set
        internal bool IsSetApplicationIDs()
        {
            return this._applicationiDs != null && this._applicationiDs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IsArchived. 
        /// <para>
        /// Request to filter Source Servers list by archived.
        /// </para>
        /// </summary>
        public bool IsArchived
        {
            get { return this._isArchived.GetValueOrDefault(); }
            set { this._isArchived = value; }
        }

        // Check to see if IsArchived property is set
        internal bool IsSetIsArchived()
        {
            return this._isArchived.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LifeCycleStates. 
        /// <para>
        /// Request to filter Source Servers list by life cycle states.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<string> LifeCycleStates
        {
            get { return this._lifeCycleStates; }
            set { this._lifeCycleStates = value; }
        }

        // Check to see if LifeCycleStates property is set
        internal bool IsSetLifeCycleStates()
        {
            return this._lifeCycleStates != null && this._lifeCycleStates.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ReplicationTypes. 
        /// <para>
        /// Request to filter Source Servers list by replication type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2)]
        public List<string> ReplicationTypes
        {
            get { return this._replicationTypes; }
            set { this._replicationTypes = value; }
        }

        // Check to see if ReplicationTypes property is set
        internal bool IsSetReplicationTypes()
        {
            return this._replicationTypes != null && this._replicationTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SourceServerIDs. 
        /// <para>
        /// Request to filter Source Servers list by Source Server ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<string> SourceServerIDs
        {
            get { return this._sourceServerIDs; }
            set { this._sourceServerIDs = value; }
        }

        // Check to see if SourceServerIDs property is set
        internal bool IsSetSourceServerIDs()
        {
            return this._sourceServerIDs != null && this._sourceServerIDs.Count > 0; 
        }

    }
}