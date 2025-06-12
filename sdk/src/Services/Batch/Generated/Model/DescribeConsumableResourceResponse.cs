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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
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
namespace Amazon.Batch.Model
{
    /// <summary>
    /// This is the response object from the DescribeConsumableResource operation.
    /// </summary>
    public partial class DescribeConsumableResourceResponse : AmazonWebServiceResponse
    {
        private long? _availableQuantity;
        private string _consumableResourceArn;
        private string _consumableResourceName;
        private long? _createdAt;
        private long? _inUseQuantity;
        private string _resourceType;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private long? _totalQuantity;

        /// <summary>
        /// Gets and sets the property AvailableQuantity. 
        /// <para>
        /// The amount of the consumable resource that is currently available to use.
        /// </para>
        /// </summary>
        public long? AvailableQuantity
        {
            get { return this._availableQuantity; }
            set { this._availableQuantity = value; }
        }

        // Check to see if AvailableQuantity property is set
        internal bool IsSetAvailableQuantity()
        {
            return this._availableQuantity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ConsumableResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the consumable resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ConsumableResourceArn
        {
            get { return this._consumableResourceArn; }
            set { this._consumableResourceArn = value; }
        }

        // Check to see if ConsumableResourceArn property is set
        internal bool IsSetConsumableResourceArn()
        {
            return this._consumableResourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property ConsumableResourceName. 
        /// <para>
        /// The name of the consumable resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ConsumableResourceName
        {
            get { return this._consumableResourceName; }
            set { this._consumableResourceName = value; }
        }

        // Check to see if ConsumableResourceName property is set
        internal bool IsSetConsumableResourceName()
        {
            return this._consumableResourceName != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The Unix timestamp (in milliseconds) for when the consumable resource was created.
        /// </para>
        /// </summary>
        public long? CreatedAt
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
        /// Gets and sets the property InUseQuantity. 
        /// <para>
        /// The amount of the consumable resource that is currently in use.
        /// </para>
        /// </summary>
        public long? InUseQuantity
        {
            get { return this._inUseQuantity; }
            set { this._inUseQuantity = value; }
        }

        // Check to see if InUseQuantity property is set
        internal bool IsSetInUseQuantity()
        {
            return this._inUseQuantity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// Indicates whether the resource is available to be re-used after a job completes. Can
        /// be one of: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>REPLENISHABLE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NON_REPLENISHABLE</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags that you apply to the consumable resource to help you categorize and organize
        /// your resources. Each tag consists of a key and an optional value. For more information,
        /// see <a href="https://docs.aws.amazon.com/batch/latest/userguide/using-tags.html">Tagging
        /// your Batch resources</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TotalQuantity. 
        /// <para>
        /// The total amount of the consumable resource that is available.
        /// </para>
        /// </summary>
        public long? TotalQuantity
        {
            get { return this._totalQuantity; }
            set { this._totalQuantity = value; }
        }

        // Check to see if TotalQuantity property is set
        internal bool IsSetTotalQuantity()
        {
            return this._totalQuantity.HasValue; 
        }

    }
}