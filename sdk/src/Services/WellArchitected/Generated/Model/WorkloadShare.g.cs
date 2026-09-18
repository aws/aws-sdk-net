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

namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// A workload share return object.
    /// </summary>
    public partial class WorkloadShare
    {
        /// <summary>
        /// Gets and sets the property PermissionType.
        /// </summary>
        public PermissionType PermissionType { get; set; }

        /// <summary>
        /// Checks to see if the PermissionType property is set.
        /// </summary>
        internal bool IsSetPermissionType() => this.PermissionType != null;

        /// <summary>
        /// Gets and sets the property ShareId.
        /// </summary>
        public string ShareId { get; set; }

        /// <summary>
        /// Checks to see if the ShareId property is set.
        /// </summary>
        internal bool IsSetShareId() => this.ShareId != null;

        /// <summary>
        /// Gets and sets the property SharedBy.
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string SharedBy { get; set; }

        /// <summary>
        /// Checks to see if the SharedBy property is set.
        /// </summary>
        internal bool IsSetSharedBy() => this.SharedBy != null;

        /// <summary>
        /// Gets and sets the property SharedWith.
        /// </summary>
        [AWSProperty(Min = 12, Max = 2048)]
        public string SharedWith { get; set; }

        /// <summary>
        /// Checks to see if the SharedWith property is set.
        /// </summary>
        internal bool IsSetSharedWith() => this.SharedWith != null;

        /// <summary>
        /// Gets and sets the property Status.
        /// </summary>
        public ShareStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property WorkloadId.
        /// </summary>
        [AWSProperty(Min = 32, Max = 32)]
        public string WorkloadId { get; set; }

        /// <summary>
        /// Checks to see if the WorkloadId property is set.
        /// </summary>
        internal bool IsSetWorkloadId() => this.WorkloadId != null;

        /// <summary>
        /// Gets and sets the property WorkloadName.
        /// </summary>
        [AWSProperty(Min = 3, Max = 100)]
        public string WorkloadName { get; set; }

        /// <summary>
        /// Checks to see if the WorkloadName property is set.
        /// </summary>
        internal bool IsSetWorkloadName() => this.WorkloadName != null;
    }
}
