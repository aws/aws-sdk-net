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
 * Do not modify this file. This file is generated from the privatenetworks-2021-12-03.normal.json service model.
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
namespace Amazon.Private5G.Model
{
    /// <summary>
    /// This is the response object from the GetNetworkResource operation.
    /// </summary>
    public partial class GetNetworkResourceResponse : AmazonWebServiceResponse
    {
        private NetworkResource _networkResource;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property NetworkResource. 
        /// <para>
        /// Information about the network resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public NetworkResource NetworkResource
        {
            get { return this._networkResource; }
            set { this._networkResource = value; }
        }

        // Check to see if NetworkResource property is set
        internal bool IsSetNetworkResource()
        {
            return this._networkResource != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        ///  The network resource tags. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}