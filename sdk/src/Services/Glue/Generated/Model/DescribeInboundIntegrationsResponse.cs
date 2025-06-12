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
    /// This is the response object from the DescribeInboundIntegrations operation.
    /// </summary>
    public partial class DescribeInboundIntegrationsResponse : AmazonWebServiceResponse
    {
        private List<InboundIntegration> _inboundIntegrations = AWSConfigs.InitializeCollections ? new List<InboundIntegration>() : null;
        private string _marker;

        /// <summary>
        /// Gets and sets the property InboundIntegrations. 
        /// <para>
        /// A list of inbound integrations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InboundIntegration> InboundIntegrations
        {
            get { return this._inboundIntegrations; }
            set { this._inboundIntegrations = value; }
        }

        // Check to see if InboundIntegrations property is set
        internal bool IsSetInboundIntegrations()
        {
            return this._inboundIntegrations != null && (this._inboundIntegrations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// A value that indicates the starting point for the next set of response records in
        /// a subsequent request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

    }
}