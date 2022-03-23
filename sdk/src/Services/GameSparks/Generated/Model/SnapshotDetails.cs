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
 * Do not modify this file. This file is generated from the gamesparks-2021-08-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameSparks.Model
{
    /// <summary>
    /// Properties that provide details of a snapshot.
    /// </summary>
    public partial class SnapshotDetails
    {
        private DateTime? _created;
        private string _description;
        private string _id;
        private DateTime? _lastUpdated;
        private Dictionary<string, Section> _sections = new Dictionary<string, Section>();

        /// <summary>
        /// Gets and sets the property Created. 
        /// <para>
        /// The timestamp of when the snapshot was created.
        /// </para>
        /// </summary>
        public DateTime Created
        {
            get { return this._created.GetValueOrDefault(); }
            set { this._created = value; }
        }

        // Check to see if Created property is set
        internal bool IsSetCreated()
        {
            return this._created.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=250)]
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Min=33, Max=36)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdated. 
        /// <para>
        /// The timestamp of when the snapshot was last updated.
        /// </para>
        /// </summary>
        public DateTime LastUpdated
        {
            get { return this._lastUpdated.GetValueOrDefault(); }
            set { this._lastUpdated = value; }
        }

        // Check to see if LastUpdated property is set
        internal bool IsSetLastUpdated()
        {
            return this._lastUpdated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Sections. 
        /// <para>
        /// The sections in the snapshot.
        /// </para>
        /// </summary>
        public Dictionary<string, Section> Sections
        {
            get { return this._sections; }
            set { this._sections = value; }
        }

        // Check to see if Sections property is set
        internal bool IsSetSections()
        {
            return this._sections != null && this._sections.Count > 0; 
        }

    }
}