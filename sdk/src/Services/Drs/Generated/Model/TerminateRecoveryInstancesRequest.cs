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
 * Do not modify this file. This file is generated from the drs-2020-02-26.normal.json service model.
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
namespace Amazon.Drs.Model
{
    /// <summary>
    /// Container for the parameters to the TerminateRecoveryInstances operation.
    /// Initiates a Job for terminating the EC2 resources associated with the specified Recovery
    /// Instances, and then will delete the Recovery Instances from the Elastic Disaster Recovery
    /// service.
    /// </summary>
    public partial class TerminateRecoveryInstancesRequest : AmazonDrsRequest
    {
        private List<string> _recoveryInstanceIDs = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property RecoveryInstanceIDs. 
        /// <para>
        /// The IDs of the Recovery Instances that should be terminated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public List<string> RecoveryInstanceIDs
        {
            get { return this._recoveryInstanceIDs; }
            set { this._recoveryInstanceIDs = value; }
        }

        // Check to see if RecoveryInstanceIDs property is set
        internal bool IsSetRecoveryInstanceIDs()
        {
            return this._recoveryInstanceIDs != null && (this._recoveryInstanceIDs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}