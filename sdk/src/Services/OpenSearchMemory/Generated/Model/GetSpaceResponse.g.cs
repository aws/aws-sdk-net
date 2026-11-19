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

namespace Amazon.OpenSearchMemory.Model
{
    /// <summary>
    /// This is the response object from the GetSpace operation.
    /// </summary>
    public partial class GetSpaceResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the space.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// When the space was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// The AWS KMS key the space was created with. Absent when the space uses an AWS owned
        /// key.
        /// </para>
        /// </summary>
        public EncryptionConfiguration EncryptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionConfiguration property is set.
        /// </summary>
        internal bool IsSetEncryptionConfiguration() => this.EncryptionConfiguration != null;

        /// <summary>
        /// Gets and sets the property EventExpiryDays. 
        /// <para>
        /// How many days the space keeps each event. Absent when it was never set, in which case
        /// the default of 90 days applies.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 365)]
        public int? EventExpiryDays { get; set; }

        /// <summary>
        /// Checks to see if the EventExpiryDays property is set.
        /// </summary>
        internal bool IsSetEventExpiryDays() => this.EventExpiryDays.HasValue;

        /// <summary>
        /// Gets and sets the property ExtractionModelId. 
        /// <para>
        /// The model that extracts and consolidates memories for the space. Absent when it was
        /// never set, in which case the service default applies.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ExtractionModelId { get; set; }

        /// <summary>
        /// Checks to see if the ExtractionModelId property is set.
        /// </summary>
        internal bool IsSetExtractionModelId() => this.ExtractionModelId != null;

        /// <summary>
        /// Gets and sets the property MemoryExpiryDays. 
        /// <para>
        /// How many days the space keeps each memory. 0 means memories never expire. Absent when
        /// it was never set, in which case memories never expire.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 3650)]
        public int? MemoryExpiryDays { get; set; }

        /// <summary>
        /// Checks to see if the MemoryExpiryDays property is set.
        /// </summary>
        internal bool IsSetMemoryExpiryDays() => this.MemoryExpiryDays.HasValue;

        /// <summary>
        /// Gets and sets the property MemoryStrategies. 
        /// <para>
        /// The space's memory strategies, including the names the service generated for strategies
        /// created without one. Empty for a space that has no memory strategies.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 10)]
        public List<MemoryStrategy> MemoryStrategies { get; set; } = AWSConfigs.InitializeCollections ? new List<MemoryStrategy>() : null;

        /// <summary>
        /// Checks to see if the MemoryStrategies property is set.
        /// </summary>
        internal bool IsSetMemoryStrategies() => this.MemoryStrategies != null && (this.MemoryStrategies.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the space.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property SpaceId. 
        /// <para>
        /// The ID of the space.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string SpaceId { get; set; }

        /// <summary>
        /// Checks to see if the SpaceId property is set.
        /// </summary>
        internal bool IsSetSpaceId() => this.SpaceId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the space.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SpaceStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// Details about why the space is <c>FAILED</c>. Read it only when <c>status</c> is <c>FAILED</c>:
        /// it can still hold the reason for an earlier failure.
        /// </para>
        /// </summary>
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;
    }
}
