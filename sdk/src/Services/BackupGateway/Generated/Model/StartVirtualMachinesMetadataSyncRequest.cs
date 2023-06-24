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
 * Do not modify this file. This file is generated from the backup-gateway-2021-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.BackupGateway.Model
{
    /// <summary>
    /// Container for the parameters to the StartVirtualMachinesMetadataSync operation.
    /// This action sends a request to sync metadata across the specified virtual machines.
    /// </summary>
    public partial class StartVirtualMachinesMetadataSyncRequest : AmazonBackupGatewayRequest
    {
        private string _hypervisorArn;

        /// <summary>
        /// Gets and sets the property HypervisorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the hypervisor.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=50, Max=500)]
        public string HypervisorArn
        {
            get { return this._hypervisorArn; }
            set { this._hypervisorArn = value; }
        }

        // Check to see if HypervisorArn property is set
        internal bool IsSetHypervisorArn()
        {
            return this._hypervisorArn != null;
        }

    }
}