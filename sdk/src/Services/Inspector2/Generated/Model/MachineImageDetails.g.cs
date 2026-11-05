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

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// Details about a machine image resource scanned directly by Inspector.
    /// </summary>
    public partial class MachineImageDetails
    {
        /// <summary>
        /// Gets and sets the property Architecture. CPU architecture (x86_64/arm64)
        /// </summary>
        public Architecture Architecture { get; set; }

        /// <summary>
        /// Checks to see if the Architecture property is set.
        /// </summary>
        internal bool IsSetArchitecture() => this.Architecture != null;

        /// <summary>
        /// Gets and sets the property CreationDate. When the image was created
        /// </summary>
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property IsPublic. Whether the image is publicly shared
        /// </summary>
        public bool? IsPublic { get; set; }

        /// <summary>
        /// Checks to see if the IsPublic property is set.
        /// </summary>
        internal bool IsSetIsPublic() => this.IsPublic.HasValue;

        /// <summary>
        /// Gets and sets the property MachineImageId. The machine image ID (e.g., ami-0abcdef1234567890)
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string MachineImageId { get; set; }

        /// <summary>
        /// Checks to see if the MachineImageId property is set.
        /// </summary>
        internal bool IsSetMachineImageId() => this.MachineImageId != null;

        /// <summary>
        /// Gets and sets the property Name. Human-readable image name
        /// </summary>
        [AWSProperty(Min = 1)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OwnerAccountId. Account ID that owns the image
        /// </summary>
        [AWSProperty(Min = 12, Max = 36)]
        public string OwnerAccountId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerAccountId property is set.
        /// </summary>
        internal bool IsSetOwnerAccountId() => this.OwnerAccountId != null;

        /// <summary>
        /// Gets and sets the property Platform. OS platform (Linux/Windows)
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Platform { get; set; }

        /// <summary>
        /// Checks to see if the Platform property is set.
        /// </summary>
        internal bool IsSetPlatform() => this.Platform != null;

        /// <summary>
        /// Gets and sets the property RootDeviceType. Root device type (ebs/instance-store) —
        /// AWS-specific
        /// </summary>
        [AWSProperty(Min = 1)]
        public string RootDeviceType { get; set; }

        /// <summary>
        /// Checks to see if the RootDeviceType property is set.
        /// </summary>
        internal bool IsSetRootDeviceType() => this.RootDeviceType != null;

        /// <summary>
        /// Gets and sets the property SourceResourceId. Source resource the image was created
        /// from (nullable)
        /// </summary>
        [AWSProperty(Min = 1)]
        public string SourceResourceId { get; set; }

        /// <summary>
        /// Checks to see if the SourceResourceId property is set.
        /// </summary>
        internal bool IsSetSourceResourceId() => this.SourceResourceId != null;

        /// <summary>
        /// Gets and sets the property State. Image state (available/pending/deregistered)
        /// </summary>
        [AWSProperty(Min = 1)]
        public string State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property VirtualizationType. Virtualization type (hvm/paravirtual)
        /// — AWS-specific
        /// </summary>
        [AWSProperty(Min = 1)]
        public string VirtualizationType { get; set; }

        /// <summary>
        /// Checks to see if the VirtualizationType property is set.
        /// </summary>
        internal bool IsSetVirtualizationType() => this.VirtualizationType != null;
    }
}
