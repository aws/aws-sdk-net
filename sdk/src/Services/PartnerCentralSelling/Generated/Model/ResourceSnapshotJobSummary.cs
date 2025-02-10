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
 * Do not modify this file. This file is generated from the partnercentral-selling-2022-07-26.normal.json service model.
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
namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// An object that contains a <c>Resource Snapshot Job</c>'s subset of fields.
    /// </summary>
    public partial class ResourceSnapshotJobSummary
    {
        private string _arn;
        private string _engagementId;
        private string _id;
        private ResourceSnapshotJobStatus _status;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) for the resource snapshot job. 
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property EngagementId. 
        /// <para>
        /// The unique identifier of the Engagement.
        /// </para>
        /// </summary>
        public string EngagementId
        {
            get { return this._engagementId; }
            set { this._engagementId = value; }
        }

        // Check to see if EngagementId property is set
        internal bool IsSetEngagementId()
        {
            return this._engagementId != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        ///  The unique identifier for the resource snapshot job within the AWS Partner Central
        /// system. This ID is used for direct references to the job within the service. 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the snapshot job.
        /// </para>
        ///  
        /// <para>
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  STOPPED: The job is not currently running. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  RUNNING: The job is actively executing. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ResourceSnapshotJobStatus Status
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