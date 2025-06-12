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
 * Do not modify this file. This file is generated from the codeconnections-2023-12-01.normal.json service model.
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
namespace Amazon.CodeConnections.Model
{
    /// <summary>
    /// Information about a repository sync attempt for a repository with a sync configuration.
    /// </summary>
    public partial class RepositorySyncAttempt
    {
        private List<RepositorySyncEvent> _events = AWSConfigs.InitializeCollections ? new List<RepositorySyncEvent>() : null;
        private DateTime? _startedAt;
        private RepositorySyncStatus _status;

        /// <summary>
        /// Gets and sets the property Events. 
        /// <para>
        /// The events associated with a specific sync attempt.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<RepositorySyncEvent> Events
        {
            get { return this._events; }
            set { this._events = value; }
        }

        // Check to see if Events property is set
        internal bool IsSetEvents()
        {
            return this._events != null && (this._events.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The start time of a specific sync attempt.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? StartedAt
        {
            get { return this._startedAt; }
            set { this._startedAt = value; }
        }

        // Check to see if StartedAt property is set
        internal bool IsSetStartedAt()
        {
            return this._startedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of a specific sync attempt. The following are valid statuses:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// INITIATED - A repository sync attempt has been created and will begin soon.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IN_PROGRESS - A repository sync attempt has started and work is being done to reconcile
        /// the branch.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SUCCEEDED - The repository sync attempt has completed successfully.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FAILED - The repository sync attempt has failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// QUEUED - The repository sync attempt didn't execute and was queued.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public RepositorySyncStatus Status
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