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

namespace Amazon.Batch.Model
{
    /// <summary>
    /// This is the response object from the DescribeConsumableResource operation.
    /// </summary>
    public partial class DescribeConsumableResourceResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AvailableQuantity. 
        /// <para>
        /// The amount of the consumable resource that is currently available to use.
        /// </para>
        /// </summary>
        public long? AvailableQuantity { get; set; }

        /// <summary>
        /// Checks to see if the AvailableQuantity property is set.
        /// </summary>
        internal bool IsSetAvailableQuantity() => this.AvailableQuantity.HasValue;

        /// <summary>
        /// Gets and sets the property ConsumableResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the consumable resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ConsumableResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ConsumableResourceArn property is set.
        /// </summary>
        internal bool IsSetConsumableResourceArn() => this.ConsumableResourceArn != null;

        /// <summary>
        /// Gets and sets the property ConsumableResourceName. 
        /// <para>
        /// The name of the consumable resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ConsumableResourceName { get; set; }

        /// <summary>
        /// Checks to see if the ConsumableResourceName property is set.
        /// </summary>
        internal bool IsSetConsumableResourceName() => this.ConsumableResourceName != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The Unix timestamp (in milliseconds) for when the consumable resource was created.
        /// </para>
        /// </summary>
        public long? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property InUseQuantity. 
        /// <para>
        /// The amount of the consumable resource that is currently in use.
        /// </para>
        /// </summary>
        public long? InUseQuantity { get; set; }

        /// <summary>
        /// Checks to see if the InUseQuantity property is set.
        /// </summary>
        internal bool IsSetInUseQuantity() => this.InUseQuantity.HasValue;

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
        public string ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags that you apply to the consumable resource to help you categorize and organize
        /// your resources. Each tag consists of a key and an optional value. For more information,
        /// see <a href="https://docs.aws.amazon.com/batch/latest/userguide/using-tags.html">Tagging
        /// your Batch resources</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TotalQuantity. 
        /// <para>
        /// The total amount of the consumable resource that is available.
        /// </para>
        /// </summary>
        public long? TotalQuantity { get; set; }

        /// <summary>
        /// Checks to see if the TotalQuantity property is set.
        /// </summary>
        internal bool IsSetTotalQuantity() => this.TotalQuantity.HasValue;
    }
}
