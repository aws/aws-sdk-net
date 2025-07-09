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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
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
namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Describes the access endpoint configuration for a WorkSpace.
    /// </summary>
    public partial class AccessEndpointConfig
    {
        private List<AccessEndpoint> _accessEndpoints = AWSConfigs.InitializeCollections ? new List<AccessEndpoint>() : null;
        private List<string> _internetFallbackProtocols = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AccessEndpoints. 
        /// <para>
        /// Indicates a list of access endpoints associated with this directory.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<AccessEndpoint> AccessEndpoints
        {
            get { return this._accessEndpoints; }
            set { this._accessEndpoints = value; }
        }

        // Check to see if AccessEndpoints property is set
        internal bool IsSetAccessEndpoints()
        {
            return this._accessEndpoints != null && (this._accessEndpoints.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InternetFallbackProtocols. 
        /// <para>
        /// Indicates a list of protocols that fallback to using the public Internet when streaming
        /// over a VPC endpoint is not available.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> InternetFallbackProtocols
        {
            get { return this._internetFallbackProtocols; }
            set { this._internetFallbackProtocols = value; }
        }

        // Check to see if InternetFallbackProtocols property is set
        internal bool IsSetInternetFallbackProtocols()
        {
            return this._internetFallbackProtocols != null && (this._internetFallbackProtocols.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}