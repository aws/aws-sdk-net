/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Describes a <code>ClusterDbRevision</code>.
    /// </summary>
    public partial class ClusterDbRevision
    {
        private string _clusterIdentifier;
        private string _currentDatabaseRevision;
        private DateTime? _databaseRevisionReleaseDate;
        private List<RevisionTarget> _revisionTargets = new List<RevisionTarget>();

        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The unique identifier of the cluster.
        /// </para>
        /// </summary>
        public string ClusterIdentifier
        {
            get { return this._clusterIdentifier; }
            set { this._clusterIdentifier = value; }
        }

        // Check to see if ClusterIdentifier property is set
        internal bool IsSetClusterIdentifier()
        {
            return this._clusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property CurrentDatabaseRevision. 
        /// <para>
        /// A string representing the current cluster version.
        /// </para>
        /// </summary>
        public string CurrentDatabaseRevision
        {
            get { return this._currentDatabaseRevision; }
            set { this._currentDatabaseRevision = value; }
        }

        // Check to see if CurrentDatabaseRevision property is set
        internal bool IsSetCurrentDatabaseRevision()
        {
            return this._currentDatabaseRevision != null;
        }

        /// <summary>
        /// Gets and sets the property DatabaseRevisionReleaseDate. 
        /// <para>
        /// The date on which the database revision was released.
        /// </para>
        /// </summary>
        public DateTime DatabaseRevisionReleaseDate
        {
            get { return this._databaseRevisionReleaseDate.GetValueOrDefault(); }
            set { this._databaseRevisionReleaseDate = value; }
        }

        // Check to see if DatabaseRevisionReleaseDate property is set
        internal bool IsSetDatabaseRevisionReleaseDate()
        {
            return this._databaseRevisionReleaseDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RevisionTargets. 
        /// <para>
        /// A list of <code>RevisionTarget</code> objects, where each object describes the database
        /// revision that a cluster can be updated to.
        /// </para>
        /// </summary>
        public List<RevisionTarget> RevisionTargets
        {
            get { return this._revisionTargets; }
            set { this._revisionTargets = value; }
        }

        // Check to see if RevisionTargets property is set
        internal bool IsSetRevisionTargets()
        {
            return this._revisionTargets != null && this._revisionTargets.Count > 0; 
        }

    }
}