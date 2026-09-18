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
    /// Container for the parameters to the UpdateWorkloadShare operation. Update a workload
    /// share.
    /// </summary>
    public partial class UpdateWorkloadShareRequest : AmazonWellArchitectedRequest
    {
        /// <summary>
        /// Gets and sets the property PermissionType.
        /// </summary>
        [AWSProperty(Required = true)]
        public PermissionType PermissionType { get; set; }

        /// <summary>
        /// Checks to see if the PermissionType property is set.
        /// </summary>
        internal bool IsSetPermissionType() => this.PermissionType != null;

        /// <summary>
        /// Gets and sets the property ShareId.
        /// </summary>
        [AWSProperty(Required = true)]
        public string ShareId { get; set; }

        /// <summary>
        /// Checks to see if the ShareId property is set.
        /// </summary>
        internal bool IsSetShareId() => this.ShareId != null;

        /// <summary>
        /// Gets and sets the property WorkloadId.
        /// </summary>
        [AWSProperty(Required = true, Min = 32, Max = 32)]
        public string WorkloadId { get; set; }

        /// <summary>
        /// Checks to see if the WorkloadId property is set.
        /// </summary>
        internal bool IsSetWorkloadId() => this.WorkloadId != null;
    }
}
