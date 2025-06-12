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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
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
namespace Amazon.Deadline.Model
{
    /// <summary>
    /// Container for the parameters to the BatchGetJobEntity operation.
    /// Get batched job details for a worker.
    /// </summary>
    public partial class BatchGetJobEntityRequest : AmazonDeadlineRequest
    {
        private string _farmId;
        private string _fleetId;
        private List<JobEntityIdentifiersUnion> _identifiers = AWSConfigs.InitializeCollections ? new List<JobEntityIdentifiersUnion>() : null;
        private string _workerId;

        /// <summary>
        /// Gets and sets the property FarmId. 
        /// <para>
        /// The farm ID of the worker that's fetching job details. The worker must have an assignment
        /// on a job to fetch job details.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FarmId
        {
            get { return this._farmId; }
            set { this._farmId = value; }
        }

        // Check to see if FarmId property is set
        internal bool IsSetFarmId()
        {
            return this._farmId != null;
        }

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// The fleet ID of the worker that's fetching job details. The worker must have an assignment
        /// on a job to fetch job details.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FleetId
        {
            get { return this._fleetId; }
            set { this._fleetId = value; }
        }

        // Check to see if FleetId property is set
        internal bool IsSetFleetId()
        {
            return this._fleetId != null;
        }

        /// <summary>
        /// Gets and sets the property Identifiers. 
        /// <para>
        /// The job identifiers to include within the job entity batch details.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<JobEntityIdentifiersUnion> Identifiers
        {
            get { return this._identifiers; }
            set { this._identifiers = value; }
        }

        // Check to see if Identifiers property is set
        internal bool IsSetIdentifiers()
        {
            return this._identifiers != null && (this._identifiers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property WorkerId. 
        /// <para>
        /// The worker ID of the worker containing the job details to get.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string WorkerId
        {
            get { return this._workerId; }
            set { this._workerId = value; }
        }

        // Check to see if WorkerId property is set
        internal bool IsSetWorkerId()
        {
            return this._workerId != null;
        }

    }
}