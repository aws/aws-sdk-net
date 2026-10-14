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
    /// A virtual machine that is on a hypervisor.
    /// </summary>
    public partial class VirtualMachine
    {
        /// <summary>
        /// Gets and sets the property HostName. 
        /// <para>
        /// The host name of the virtual machine.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string HostName { get; set; }

        /// <summary>
        /// Checks to see if the HostName property is set.
        /// </summary>
        internal bool IsSetHostName() => this.HostName != null;

        /// <summary>
        /// Gets and sets the property HypervisorId. 
        /// <para>
        /// The ID of the virtual machine's hypervisor.
        /// </para>
        /// </summary>
        public string HypervisorId { get; set; }

        /// <summary>
        /// Checks to see if the HypervisorId property is set.
        /// </summary>
        internal bool IsSetHypervisorId() => this.HypervisorId != null;

        /// <summary>
        /// Gets and sets the property LastBackupDate. 
        /// <para>
        /// The most recent date a virtual machine was backed up, in Unix format and UTC time.
        /// </para>
        /// </summary>
        public DateTime? LastBackupDate { get; set; }

        /// <summary>
        /// Checks to see if the LastBackupDate property is set.
        /// </summary>
        internal bool IsSetLastBackupDate() => this.LastBackupDate.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the virtual machine.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The path of the virtual machine.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string Path { get; set; }

        /// <summary>
        /// Checks to see if the Path property is set.
        /// </summary>
        internal bool IsSetPath() => this.Path != null;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the virtual machine. For example, <c>arn:aws:backup-gateway:us-west-1:0000000000000:vm/vm-0000ABCDEFGIJKL</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 50, Max = 500)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;
    }
}
