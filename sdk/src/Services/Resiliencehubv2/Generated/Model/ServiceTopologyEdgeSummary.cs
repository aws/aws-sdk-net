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
 * Do not modify this file. This file is generated from the resiliencehubv2-2026-02-17.normal.json service model.
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
namespace Amazon.Resiliencehubv2.Model
{
    /// <summary>
    /// Contains summary information about a service topology edge.
    /// </summary>
    public partial class ServiceTopologyEdgeSummary
    {
        private string _destinationResourceIdentifier;
        private List<EdgePropertySummary> _properties = AWSConfigs.InitializeCollections ? new List<EdgePropertySummary>() : null;
        private string _sourceResourceIdentifier;

        /// <summary>
        /// Gets and sets the property DestinationResourceIdentifier. 
        /// <para>
        /// The identifier of the destination resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DestinationResourceIdentifier
        {
            get { return this._destinationResourceIdentifier; }
            set { this._destinationResourceIdentifier = value; }
        }

        // Check to see if DestinationResourceIdentifier property is set
        internal bool IsSetDestinationResourceIdentifier()
        {
            return this._destinationResourceIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Properties. 
        /// <para>
        /// The properties of the topology edge.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=3)]
        public List<EdgePropertySummary> Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }

        // Check to see if Properties property is set
        internal bool IsSetProperties()
        {
            return this._properties != null && (this._properties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SourceResourceIdentifier. 
        /// <para>
        /// The identifier of the source resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SourceResourceIdentifier
        {
            get { return this._sourceResourceIdentifier; }
            set { this._sourceResourceIdentifier = value; }
        }

        // Check to see if SourceResourceIdentifier property is set
        internal bool IsSetSourceResourceIdentifier()
        {
            return this._sourceResourceIdentifier != null;
        }

    }
}