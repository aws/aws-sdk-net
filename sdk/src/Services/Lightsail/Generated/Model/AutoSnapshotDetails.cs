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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes an automatic snapshot.
    /// </summary>
    public partial class AutoSnapshotDetails
    {
        private DateTime? _createdAt;
        private string _date;
        private List<AttachedDisk> _fromAttachedDisks = new List<AttachedDisk>();
        private AutoSnapshotStatus _status;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the automatic snapshot was created.
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Date. 
        /// <para>
        /// The date of the automatic snapshot in <code>YYYY-MM-DD</code> format.
        /// </para>
        /// </summary>
        public string Date
        {
            get { return this._date; }
            set { this._date = value; }
        }

        // Check to see if Date property is set
        internal bool IsSetDate()
        {
            return this._date != null;
        }

        /// <summary>
        /// Gets and sets the property FromAttachedDisks. 
        /// <para>
        /// An array of objects that describe the block storage disks attached to the instance
        /// when the automatic snapshot was created.
        /// </para>
        /// </summary>
        public List<AttachedDisk> FromAttachedDisks
        {
            get { return this._fromAttachedDisks; }
            set { this._fromAttachedDisks = value; }
        }

        // Check to see if FromAttachedDisks property is set
        internal bool IsSetFromAttachedDisks()
        {
            return this._fromAttachedDisks != null && this._fromAttachedDisks.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the automatic snapshot.
        /// </para>
        /// </summary>
        public AutoSnapshotStatus Status
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