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
 * Do not modify this file. This file is generated from the finspace-2021-03-12.normal.json service model.
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
namespace Amazon.Finspace.Model
{
    /// <summary>
    /// Details of changeset.
    /// </summary>
    public partial class KxChangesetListEntry
    {
        private DateTime? _activeFromTimestamp;
        private string _changesetId;
        private DateTime? _createdTimestamp;
        private DateTime? _lastModifiedTimestamp;
        private ChangesetStatus _status;

        /// <summary>
        /// Gets and sets the property ActiveFromTimestamp. 
        /// <para>
        /// Beginning time from which the changeset is active. The value is determined as epoch
        /// time in milliseconds. For example, the value for Monday, November 1, 2021 12:00:00
        /// PM UTC is specified as 1635768000000.
        /// </para>
        /// </summary>
        public DateTime? ActiveFromTimestamp
        {
            get { return this._activeFromTimestamp; }
            set { this._activeFromTimestamp = value; }
        }

        // Check to see if ActiveFromTimestamp property is set
        internal bool IsSetActiveFromTimestamp()
        {
            return this._activeFromTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ChangesetId. 
        /// <para>
        /// A unique identifier for the changeset.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=26)]
        public string ChangesetId
        {
            get { return this._changesetId; }
            set { this._changesetId = value; }
        }

        // Check to see if ChangesetId property is set
        internal bool IsSetChangesetId()
        {
            return this._changesetId != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The timestamp at which the changeset was created in FinSpace. The value is determined
        /// as epoch time in milliseconds. For example, the value for Monday, November 1, 2021
        /// 12:00:00 PM UTC is specified as 1635768000000.
        /// </para>
        /// </summary>
        public DateTime? CreatedTimestamp
        {
            get { return this._createdTimestamp; }
            set { this._createdTimestamp = value; }
        }

        // Check to see if CreatedTimestamp property is set
        internal bool IsSetCreatedTimestamp()
        {
            return this._createdTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTimestamp. 
        /// <para>
        /// The timestamp at which the changeset was modified. The value is determined as epoch
        /// time in milliseconds. For example, the value for Monday, November 1, 2021 12:00:00
        /// PM UTC is specified as 1635768000000.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTimestamp
        {
            get { return this._lastModifiedTimestamp; }
            set { this._lastModifiedTimestamp = value; }
        }

        // Check to see if LastModifiedTimestamp property is set
        internal bool IsSetLastModifiedTimestamp()
        {
            return this._lastModifiedTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  Status of the changeset.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Pending – Changeset creation is pending.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Processing – Changeset creation is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Failed – Changeset creation has failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Complete – Changeset creation has succeeded.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ChangesetStatus Status
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