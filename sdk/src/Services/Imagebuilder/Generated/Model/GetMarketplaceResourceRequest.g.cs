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

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Container for the parameters to the GetMarketplaceResource operation. Verifies the
    /// subscription and performs resource dependency checks on the requested Amazon Web Services
    /// Marketplace resource. The caller must be entitled to the resource. For Amazon Web
    /// Services Marketplace components, the response contains fields to download the components
    /// and their artifacts.
    /// </summary>
    public partial class GetMarketplaceResourceRequest : AmazonImagebuilderRequest
    {
        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that uniquely identifies an Amazon Web Services Marketplace
        /// resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;

        /// <summary>
        /// Gets and sets the property ResourceLocation. 
        /// <para>
        /// The Amazon S3 location of the component artifact to retrieve, in <c>s3://bucket/key</c>
        /// form.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string ResourceLocation { get; set; }

        /// <summary>
        /// Checks to see if the ResourceLocation property is set.
        /// </summary>
        internal bool IsSetResourceLocation() => this.ResourceLocation != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// Specifies which type of Amazon Web Services Marketplace resource Image Builder retrieves.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MarketplaceResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;
    }
}
