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

namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// A ProfileObjectType instance.
    /// </summary>
    public partial class ListProfileObjectTypeItem
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp of when the domain was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Description of the profile object type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The timestamp of when the profile object type was most recently edited.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedAt property is set.
        /// </summary>
        internal bool IsSetLastUpdatedAt() => this.LastUpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property MaxAvailableProfileObjectCount. 
        /// <para>
        /// The amount of provisioned profile object max count available.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? MaxAvailableProfileObjectCount { get; set; }

        /// <summary>
        /// Checks to see if the MaxAvailableProfileObjectCount property is set.
        /// </summary>
        internal bool IsSetMaxAvailableProfileObjectCount() => this.MaxAvailableProfileObjectCount.HasValue;

        /// <summary>
        /// Gets and sets the property MaxProfileObjectCount. 
        /// <para>
        /// The amount of profile object max count assigned to the object type.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? MaxProfileObjectCount { get; set; }

        /// <summary>
        /// Checks to see if the MaxProfileObjectCount property is set.
        /// </summary>
        internal bool IsSetMaxProfileObjectCount() => this.MaxProfileObjectCount.HasValue;

        /// <summary>
        /// Gets and sets the property ObjectTypeName. 
        /// <para>
        /// The name of the profile object type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string ObjectTypeName { get; set; }

        /// <summary>
        /// Checks to see if the ObjectTypeName property is set.
        /// </summary>
        internal bool IsSetObjectTypeName() => this.ObjectTypeName != null;

        /// <summary>
        /// Gets and sets the property SourcePriority. 
        /// <para>
        /// An integer that determines the priority of this object type when data from multiple
        /// sources is ingested. Lower values take priority. Object types without a specified
        /// source priority default to the lowest priority.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? SourcePriority { get; set; }

        /// <summary>
        /// Checks to see if the SourcePriority property is set.
        /// </summary>
        internal bool IsSetSourcePriority() => this.SourcePriority.HasValue;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags used to organize, track, or control access for this resource.
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
    }
}
