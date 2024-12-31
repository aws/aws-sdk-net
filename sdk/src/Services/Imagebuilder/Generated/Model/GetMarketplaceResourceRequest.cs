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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
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
    /// Container for the parameters to the GetMarketplaceResource operation.
    /// Verify the subscription and perform resource dependency checks on the requested Amazon
    /// Web Services Marketplace resource. For Amazon Web Services Marketplace components,
    /// the response contains fields to download the components and their artifacts.
    /// </summary>
    public partial class GetMarketplaceResourceRequest : AmazonImagebuilderRequest
    {
        private string _resourceArn;
        private string _resourceLocation;
        private MarketplaceResourceType _resourceType;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that uniquely identifies an Amazon Web Services Marketplace
        /// resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceLocation. 
        /// <para>
        /// The bucket path that you can specify to download the resource from Amazon S3.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string ResourceLocation
        {
            get { return this._resourceLocation; }
            set { this._resourceLocation = value; }
        }

        // Check to see if ResourceLocation property is set
        internal bool IsSetResourceLocation()
        {
            return this._resourceLocation != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// Specifies which type of Amazon Web Services Marketplace resource Image Builder retrieves.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MarketplaceResourceType ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

    }
}