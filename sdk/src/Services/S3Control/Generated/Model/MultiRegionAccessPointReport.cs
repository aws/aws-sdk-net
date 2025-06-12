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
    /// A collection of statuses for a Multi-Region Access Point in the various Regions it
    /// supports.
    /// </summary>
    public partial class MultiRegionAccessPointReport
    {
        private string _alias;
        private DateTime? _createdAt;
        private string _name;
        private PublicAccessBlockConfiguration _publicAccessBlock;
        private List<RegionReport> _regions = AWSConfigs.InitializeCollections ? new List<RegionReport>() : null;
        private MultiRegionAccessPointStatus _status;

        /// <summary>
        /// Gets and sets the property Alias. 
        /// <para>
        /// The alias for the Multi-Region Access Point. For more information about the distinction
        /// between the name and the alias of an Multi-Region Access Point, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/CreatingMultiRegionAccessPoints.html#multi-region-access-point-naming">Rules
        /// for naming Amazon S3 Multi-Region Access Points</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=63)]
        public string Alias
        {
            get { return this._alias; }
            set { this._alias = value; }
        }

        // Check to see if Alias property is set
        internal bool IsSetAlias()
        {
            return this._alias != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// When the Multi-Region Access Point create request was received.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the Multi-Region Access Point.
        /// </para>
        /// </summary>
        [AWSProperty(Max=50)]
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
        /// A collection of the Regions and buckets associated with the Multi-Region Access Point.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RegionReport> Regions
        {
            get { return this._regions; }
            set { this._regions = value; }
        }

        // Check to see if Regions property is set
        internal bool IsSetRegions()
        {
            return this._regions != null && (this._regions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the Multi-Region Access Point.
        /// </para>
        ///  
        /// <para>
        ///  <c>CREATING</c> and <c>DELETING</c> are temporary states that exist while the request
        /// is propagating and being completed. If a Multi-Region Access Point has a status of
        /// <c>PARTIALLY_CREATED</c>, you can retry creation or send a request to delete the Multi-Region
        /// Access Point. If a Multi-Region Access Point has a status of <c>PARTIALLY_DELETED</c>,
        /// you can retry a delete request to finish the deletion of the Multi-Region Access Point.
        /// </para>
        /// </summary>
        public MultiRegionAccessPointStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}