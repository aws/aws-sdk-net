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
 * Do not modify this file. This file is generated from the codestar-connections-2019-12-01.normal.json service model.
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
namespace Amazon.CodeStarconnections.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateHost operation.
    /// Updates a specified host with the provided configurations.
    /// </summary>
    public partial class UpdateHostRequest : AmazonCodeStarconnectionsRequest
    {
        private string _hostArn;
        private string _providerEndpoint;
        private VpcConfiguration _vpcConfiguration;

        /// <summary>
        /// Gets and sets the property HostArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the host to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string HostArn
        {
            get { return this._hostArn; }
            set { this._hostArn = value; }
        }

        // Check to see if HostArn property is set
        internal bool IsSetHostArn()
        {
            return this._hostArn != null;
        }

        /// <summary>
        /// Gets and sets the property ProviderEndpoint. 
        /// <para>
        /// The URL or endpoint of the host to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string ProviderEndpoint
        {
            get { return this._providerEndpoint; }
            set { this._providerEndpoint = value; }
        }

        // Check to see if ProviderEndpoint property is set
        internal bool IsSetProviderEndpoint()
        {
            return this._providerEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property VpcConfiguration. 
        /// <para>
        /// The VPC configuration of the host to be updated. A VPC must be configured and the
        /// infrastructure to be represented by the host must already be connected to the VPC.
        /// </para>
        /// </summary>
        public VpcConfiguration VpcConfiguration
        {
            get { return this._vpcConfiguration; }
            set { this._vpcConfiguration = value; }
        }

        // Check to see if VpcConfiguration property is set
        internal bool IsSetVpcConfiguration()
        {
            return this._vpcConfiguration != null;
        }

    }
}