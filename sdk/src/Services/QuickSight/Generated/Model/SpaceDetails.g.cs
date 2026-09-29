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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The details of an Amazon QuickSight space.
    /// </summary>
    public partial class SpaceDetails
    {
        /// <summary>
        /// Gets and sets the property ConsumedSourceDocCount. 
        /// <para>
        /// The number of consumed source documents.
        /// </para>
        /// </summary>
        public int? ConsumedSourceDocCount { get; set; }

        /// <summary>
        /// Checks to see if the ConsumedSourceDocCount property is set.
        /// </summary>
        internal bool IsSetConsumedSourceDocCount() => this.ConsumedSourceDocCount.HasValue;

        /// <summary>
        /// Gets and sets the property ConsumedSourceSize. 
        /// <para>
        /// The total consumed source size in bytes.
        /// </para>
        /// </summary>
        public long? ConsumedSourceSize { get; set; }

        /// <summary>
        /// Checks to see if the ConsumedSourceSize property is set.
        /// </summary>
        internal bool IsSetConsumedSourceSize() => this.ConsumedSourceSize.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time that the space was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The user who created the space.
        /// </para>
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property CreatedByArn. 
        /// <para>
        /// The ARN of the user who created the space.
        /// </para>
        /// </summary>
        public string CreatedByArn { get; set; }

        /// <summary>
        /// Checks to see if the CreatedByArn property is set.
        /// </summary>
        internal bool IsSetCreatedByArn() => this.CreatedByArn != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the space.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 1000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The display name of the space.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Resources. 
        /// <para>
        /// The resources in the space.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SpaceQuickSightResource> Resources { get; set; } = AWSConfigs.InitializeCollections ? new List<SpaceQuickSightResource>() : null;

        /// <summary>
        /// Checks to see if the Resources property is set.
        /// </summary>
        internal bool IsSetResources() => this.Resources != null && (this.Resources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time that the space was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
