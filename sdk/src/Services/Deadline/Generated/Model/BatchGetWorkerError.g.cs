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
    /// The error details for a worker that could not be retrieved in a batch get operation.
    /// </summary>
    public partial class BatchGetWorkerError
    {
        /// <summary>
        /// Gets and sets the property Code. The error code.
        /// </summary>
        [AWSProperty(Required = true)]
        public BatchGetWorkerErrorCode Code { get; set; }

        /// <summary>
        /// Checks to see if the Code property is set.
        /// </summary>
        internal bool IsSetCode() => this.Code != null;

        /// <summary>
        /// Gets and sets the property FarmId. The farm ID of the worker that could not be retrieved.
        /// </summary>
        [AWSProperty(Required = true)]
        public string FarmId { get; set; }

        /// <summary>
        /// Checks to see if the FarmId property is set.
        /// </summary>
        internal bool IsSetFarmId() => this.FarmId != null;

        /// <summary>
        /// Gets and sets the property FleetId. The fleet ID of the worker that could not be retrieved.
        /// </summary>
        [AWSProperty(Required = true)]
        public string FleetId { get; set; }

        /// <summary>
        /// Checks to see if the FleetId property is set.
        /// </summary>
        internal bool IsSetFleetId() => this.FleetId != null;

        /// <summary>
        /// Gets and sets the property Message. The error message.
        /// </summary>
        [AWSProperty(Required = true)]
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property WorkerId. The worker ID of the worker that could not be
        /// retrieved.
        /// </summary>
        [AWSProperty(Required = true)]
        public string WorkerId { get; set; }

        /// <summary>
        /// Checks to see if the WorkerId property is set.
        /// </summary>
        internal bool IsSetWorkerId() => this.WorkerId != null;
    }
}
