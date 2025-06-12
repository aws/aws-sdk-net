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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
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
namespace Amazon.S3Control.Model
{
    /// <summary>
    /// A container for the information associated with a <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateMultiRegionAccessPoint.html">CreateMultiRegionAccessPoint</a>
    /// request.
    /// </summary>
    public partial class CreateMultiRegionAccessPointInput
    {
        private string _name;
        private PublicAccessBlockConfiguration _publicAccessBlock;
        private List<Region> _regions = AWSConfigs.InitializeCollections ? new List<Region>() : null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the Multi-Region Access Point associated with this request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=50)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property PublicAccessBlock.
        /// </summary>
        public PublicAccessBlockConfiguration PublicAccessBlock
        {
            get { return this._publicAccessBlock; }
            set { this._publicAccessBlock = value; }
        }

        // Check to see if PublicAccessBlock property is set
        internal bool IsSetPublicAccessBlock()
        {
            return this._publicAccessBlock != null;
        }

        /// <summary>
        /// Gets and sets the property Regions. 
        /// <para>
        /// The buckets in different Regions that are associated with the Multi-Region Access
        /// Point.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Region> Regions
        {
            get { return this._regions; }
            set { this._regions = value; }
        }

        // Check to see if Regions property is set
        internal bool IsSetRegions()
        {
            return this._regions != null && (this._regions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}