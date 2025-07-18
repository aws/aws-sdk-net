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
 * Do not modify this file. This file is generated from the opsworks-2013-02-18.normal.json service model.
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
namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Contains the response to a <c>DescribeStackProvisioningParameters</c> request.
    /// </summary>
    public partial class DescribeStackProvisioningParametersResponse : AmazonWebServiceResponse
    {
        private string _agentInstallerUrl;
        private Dictionary<string, string> _parameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property AgentInstallerUrl. 
        /// <para>
        /// The OpsWorks Stacks agent installer's URL.
        /// </para>
        /// </summary>
        public string AgentInstallerUrl
        {
            get { return this._agentInstallerUrl; }
            set { this._agentInstallerUrl = value; }
        }

        // Check to see if AgentInstallerUrl property is set
        internal bool IsSetAgentInstallerUrl()
        {
            return this._agentInstallerUrl != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// An embedded object that contains the provisioning parameters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && (this._parameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}