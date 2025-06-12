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
 * Do not modify this file. This file is generated from the mediapackagev2-2022-12-25.normal.json service model.
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
namespace Amazon.MediaPackageV2.Model
{
    /// <summary>
    /// The failover settings for the endpoint.
    /// </summary>
    public partial class ForceEndpointErrorConfiguration
    {
        private List<string> _endpointErrorConditions = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property EndpointErrorConditions. 
        /// <para>
        /// The failover conditions for the endpoint. The options are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>STALE_MANIFEST</c> - The manifest stalled and there are no new segments or parts.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INCOMPLETE_MANIFEST</c> - There is a gap in the manifest.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MISSING_DRM_KEY</c> - Key rotation is enabled but we're unable to fetch the key
        /// for the current key period.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SLATE_INPUT</c> - The segments which contain slate content are considered to be
        /// missing content.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EndpointErrorConditions
        {
            get { return this._endpointErrorConditions; }
            set { this._endpointErrorConditions = value; }
        }

        // Check to see if EndpointErrorConditions property is set
        internal bool IsSetEndpointErrorConditions()
        {
            return this._endpointErrorConditions != null && (this._endpointErrorConditions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}