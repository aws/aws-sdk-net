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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateAssetFilter operation. Updates an asset
    /// filter. <para> Prerequisites: </para> <ul> <li> <para> The domain, asset, and asset
    /// filter identifier must all exist. </para> </li> <li> <para> The asset must contain
    /// the columns being referenced in the update. </para> </li> <li> <para> If applying
    /// a row filter, ensure the column referenced in the expression exists in the asset schema.
    /// </para> </li> </ul>
    /// </summary>
    public partial class UpdateAssetFilterRequest : AmazonDataZoneRequest
    {
        /// <summary>
        /// Gets and sets the property AssetIdentifier. 
        /// <para>
        /// The ID of the data asset.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AssetIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the AssetIdentifier property is set.
        /// </summary>
        internal bool IsSetAssetIdentifier() => this.AssetIdentifier != null;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The configuration of the asset filter.
        /// </para>
        /// </summary>
        public AssetFilterConfiguration Configuration { get; set; }

        /// <summary>
        /// Checks to see if the Configuration property is set.
        /// </summary>
        internal bool IsSetConfiguration() => this.Configuration != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the asset filter.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The ID of the domain where you want to update an asset filter.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DomainIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DomainIdentifier property is set.
        /// </summary>
        internal bool IsSetDomainIdentifier() => this.DomainIdentifier != null;

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The ID of the asset filter.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Identifier { get; set; }

        /// <summary>
        /// Checks to see if the Identifier property is set.
        /// </summary>
        internal bool IsSetIdentifier() => this.Identifier != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the asset filter.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
