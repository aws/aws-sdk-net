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

namespace Amazon.Drs.Model
{
    /// <summary>
    /// Container for the parameters to the StartSourceNetworkRecovery operation.
    /// Deploy VPC for the specified Source Network and modify launch templates to use this
    /// network. The VPC will be deployed using a dedicated CloudFormation stack.
    /// </summary>
    public partial class StartSourceNetworkRecoveryRequest : AmazonDrsRequest
    {
        private bool? _deployAsNew;
        private List<StartSourceNetworkRecoveryRequestNetworkEntry> _sourceNetworks = new List<StartSourceNetworkRecoveryRequestNetworkEntry>();
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property DeployAsNew. 
        /// <para>
        /// Don't update existing CloudFormation Stack, recover the network using a new stack.
        /// </para>
        /// </summary>
        public bool DeployAsNew
        {
            get { return this._deployAsNew.GetValueOrDefault(); }
            set { this._deployAsNew = value; }
        }

        // Check to see if DeployAsNew property is set
        internal bool IsSetDeployAsNew()
        {
            return this._deployAsNew.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SourceNetworks. 
        /// <para>
        /// The Source Networks that we want to start a Recovery Job for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<StartSourceNetworkRecoveryRequestNetworkEntry> SourceNetworks
        {
            get { return this._sourceNetworks; }
            set { this._sourceNetworks = value; }
        }

        // Check to see if SourceNetworks property is set
        internal bool IsSetSourceNetworks()
        {
            return this._sourceNetworks != null && this._sourceNetworks.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to be associated with the Source Network recovery Job.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}