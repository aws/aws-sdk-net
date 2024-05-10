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
 * Do not modify this file. This file is generated from the wellarchitected-2020-03-31.normal.json service model.
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
    /// Container for the parameters to the AssociateProfiles operation.
    /// Associate a profile with a workload.
    /// </summary>
    public partial class AssociateProfilesRequest : AmazonWellArchitectedRequest
    {
        private List<string> _profileArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _workloadId;

        /// <summary>
        /// Gets and sets the property ProfileArns. 
        /// <para>
        /// The list of profile ARNs to associate with the workload.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<string> ProfileArns
        {
            get { return this._profileArns; }
            set { this._profileArns = value; }
        }

        // Check to see if ProfileArns property is set
        internal bool IsSetProfileArns()
        {
            return this._profileArns != null && (this._profileArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property WorkloadId.
        /// </summary>
        [AWSProperty(Required=true, Min=32, Max=32)]
        public string WorkloadId
        {
            get { return this._workloadId; }
            set { this._workloadId = value; }
        }

        // Check to see if WorkloadId property is set
        internal bool IsSetWorkloadId()
        {
            return this._workloadId != null;
        }

    }
}