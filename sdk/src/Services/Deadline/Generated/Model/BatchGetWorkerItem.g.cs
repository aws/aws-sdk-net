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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// The details of a worker returned in a batch get operation.
    /// </summary>
    public partial class BatchGetWorkerItem
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. The date and time the resource was created.
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedBy. The user or system that created this resource.
        /// </summary>
        [AWSProperty(Required = true)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property FarmId. The farm ID of the worker.
        /// </summary>
        [AWSProperty(Required = true)]
        public string FarmId { get; set; }

        /// <summary>
        /// Checks to see if the FarmId property is set.
        /// </summary>
        internal bool IsSetFarmId() => this.FarmId != null;

        /// <summary>
        /// Gets and sets the property FleetId. The fleet ID of the worker.
        /// </summary>
        [AWSProperty(Required = true)]
        public string FleetId { get; set; }

        /// <summary>
        /// Checks to see if the FleetId property is set.
        /// </summary>
        internal bool IsSetFleetId() => this.FleetId != null;

        /// <summary>
        /// Gets and sets the property HostProperties. The host properties for the worker.
        /// </summary>
        public HostPropertiesResponse HostProperties { get; set; }

        /// <summary>
        /// Checks to see if the HostProperties property is set.
        /// </summary>
        internal bool IsSetHostProperties() => this.HostProperties != null;

        /// <summary>
        /// Gets and sets the property Log. The log configuration for the worker.
        /// </summary>
        public LogConfiguration Log { get; set; }

        /// <summary>
        /// Checks to see if the Log property is set.
        /// </summary>
        internal bool IsSetLog() => this.Log != null;

        /// <summary>
        /// Gets and sets the property Status. The status of the worker.
        /// </summary>
        [AWSProperty(Required = true)]
        public WorkerStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. The date and time the resource was updated.
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property UpdatedBy. The user or system that updated this resource.
        /// </summary>
        public string UpdatedBy { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedBy property is set.
        /// </summary>
        internal bool IsSetUpdatedBy() => this.UpdatedBy != null;

        /// <summary>
        /// Gets and sets the property WorkerId. The worker ID.
        /// </summary>
        [AWSProperty(Required = true)]
        public string WorkerId { get; set; }

        /// <summary>
        /// Checks to see if the WorkerId property is set.
        /// </summary>
        internal bool IsSetWorkerId() => this.WorkerId != null;
    }
}
