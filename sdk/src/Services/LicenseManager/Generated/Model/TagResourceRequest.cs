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
 * Do not modify this file. This file is generated from the license-manager-2018-08-01.normal.json service model.
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
namespace Amazon.LicenseManager.Model
{
    /// <summary>
    /// Container for the parameters to the TagResource operation.
    /// Adds the specified tags to the specified resource. The following resources support
    /// tagging in License Manager:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Licenses
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Grants
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// License configurations
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Report generators
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class TagResourceRequest : AmazonLicenseManagerRequest
    {
        private string _resourceArn;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the resource. The following examples provide an example
        /// ARN for each supported resource in License Manager:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Licenses - <c>arn:aws:license-manager::111122223333:license:l-EXAMPLE2da7646d6861033667f20e895</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Grants - <c>arn:aws:license-manager::111122223333:grant:g-EXAMPLE7b19f4a0ab73679b0beb52707</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// License configurations - <c>arn:aws:license-manager:us-east-1:111122223333:license-configuration:lic-EXAMPLE6a788d4c8acd4264ff0ecf2ed2d</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Report generators - <c>arn:aws:license-manager:us-east-1:111122223333:report-generator:r-EXAMPLE825b4a4f8fe5a3e0c88824e5fc6</c>
        /// 
        /// </para>
        ///  </li> </ul>
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// One or more tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Tag> Tags
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