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

namespace Amazon.BackupGateway.Model
{
    /// <summary>
    /// These are the details of the specified hypervisor. A hypervisor is hardware, software,
    /// or firmware that creates and manages virtual machines, and allocates resources to
    /// them.
    /// </summary>
    public partial class HypervisorDetails
    {
        /// <summary>
        /// Gets and sets the property Host. 
        /// <para>
        /// The server host of the hypervisor. This can be either an IP address or a fully-qualified
        /// domain name (FQDN).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 128)]
        public string Host { get; set; }

        /// <summary>
        /// Checks to see if the Host property is set.
        /// </summary>
        internal bool IsSetHost() => this.Host != null;

        /// <summary>
        /// Gets and sets the property HypervisorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the hypervisor.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 50, Max = 500)]
        public string HypervisorArn { get; set; }

        /// <summary>
        /// Checks to see if the HypervisorArn property is set.
        /// </summary>
        internal bool IsSetHypervisorArn() => this.HypervisorArn != null;

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the KMS used to encrypt the hypervisor.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 50, Max = 500)]
        public string KmsKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyArn property is set.
        /// </summary>
        internal bool IsSetKmsKeyArn() => this.KmsKeyArn != null;

        /// <summary>
        /// Gets and sets the property LastSuccessfulMetadataSyncTime. 
        /// <para>
        /// This is the time when the most recent successful sync of metadata occurred.
        /// </para>
        /// </summary>
        public DateTime? LastSuccessfulMetadataSyncTime { get; set; }

        /// <summary>
        /// Checks to see if the LastSuccessfulMetadataSyncTime property is set.
        /// </summary>
        internal bool IsSetLastSuccessfulMetadataSyncTime() => this.LastSuccessfulMetadataSyncTime.HasValue;

        /// <summary>
        /// Gets and sets the property LatestMetadataSyncStatus. 
        /// <para>
        /// This is the most recent status for the indicated metadata sync.
        /// </para>
        /// </summary>
        public SyncMetadataStatus LatestMetadataSyncStatus { get; set; }

        /// <summary>
        /// Checks to see if the LatestMetadataSyncStatus property is set.
        /// </summary>
        internal bool IsSetLatestMetadataSyncStatus() => this.LatestMetadataSyncStatus != null;

        /// <summary>
        /// Gets and sets the property LatestMetadataSyncStatusMessage. 
        /// <para>
        /// This is the most recent status for the indicated metadata sync.
        /// </para>
        /// </summary>
        public string LatestMetadataSyncStatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the LatestMetadataSyncStatusMessage property is set.
        /// </summary>
        internal bool IsSetLatestMetadataSyncStatusMessage() => this.LatestMetadataSyncStatusMessage != null;

        /// <summary>
        /// Gets and sets the property LogGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the group of gateways within the requested log.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string LogGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the LogGroupArn property is set.
        /// </summary>
        internal bool IsSetLogGroupArn() => this.LogGroupArn != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// This is the name of the specified hypervisor.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// This is the current state of the specified hypervisor.
        /// </para>
        ///  
        /// <para>
        /// The possible states are <c>PENDING</c>, <c>ONLINE</c>, <c>OFFLINE</c>, or <c>ERROR</c>.
        /// </para>
        /// </summary>
        public HypervisorState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
