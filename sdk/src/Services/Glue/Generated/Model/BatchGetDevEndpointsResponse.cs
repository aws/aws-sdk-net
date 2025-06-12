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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// This is the response object from the BatchGetDevEndpoints operation.
    /// </summary>
    public partial class BatchGetDevEndpointsResponse : AmazonWebServiceResponse
    {
        private List<DevEndpoint> _devEndpoints = AWSConfigs.InitializeCollections ? new List<DevEndpoint>() : null;
        private List<string> _devEndpointsNotFound = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property DevEndpoints. 
        /// <para>
        /// A list of <c>DevEndpoint</c> definitions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DevEndpoint> DevEndpoints
        {
            get { return this._devEndpoints; }
            set { this._devEndpoints = value; }
        }

        // Check to see if DevEndpoints property is set
        internal bool IsSetDevEndpoints()
        {
            return this._devEndpoints != null && (this._devEndpoints.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DevEndpointsNotFound. 
        /// <para>
        /// A list of <c>DevEndpoints</c> not found.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=25)]
        public List<string> DevEndpointsNotFound
        {
            get { return this._devEndpointsNotFound; }
            set { this._devEndpointsNotFound = value; }
        }

        // Check to see if DevEndpointsNotFound property is set
        internal bool IsSetDevEndpointsNotFound()
        {
            return this._devEndpointsNotFound != null && (this._devEndpointsNotFound.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}