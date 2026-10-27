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

namespace Amazon.Drs.Model
{
    /// <summary>
    /// Container for the parameters to the CreateSourceNetwork operation. Create a new Source
    /// Network resource for a provided VPC ID.
    /// </summary>
    public partial class CreateSourceNetworkRequest : AmazonDrsRequest
    {
        /// <summary>
        /// Gets and sets the property OriginAccountID. 
        /// <para>
        /// Account containing the VPC to protect.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 12)]
        public string OriginAccountID { get; set; }

        /// <summary>
        /// Checks to see if the OriginAccountID property is set.
        /// </summary>
        internal bool IsSetOriginAccountID() => this.OriginAccountID != null;

        /// <summary>
        /// Gets and sets the property OriginRegion. 
        /// <para>
        /// Region containing the VPC to protect.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 255)]
        public string OriginRegion { get; set; }

        /// <summary>
        /// Checks to see if the OriginRegion property is set.
        /// </summary>
        internal bool IsSetOriginRegion() => this.OriginRegion != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A set of tags to be associated with the Source Network resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VpcID. 
        /// <para>
        /// Which VPC ID to protect.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 21)]
        public string VpcID { get; set; }

        /// <summary>
        /// Checks to see if the VpcID property is set.
        /// </summary>
        internal bool IsSetVpcID() => this.VpcID != null;
    }
}
