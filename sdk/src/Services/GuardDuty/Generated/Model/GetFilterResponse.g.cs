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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// This is the response object from the GetFilter operation.
    /// </summary>
    public partial class GetFilterResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// Specifies the action that is to be applied to the findings that match the filter.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 300)]
        public FilterAction Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the filter was created. This field is not available for filters
        /// that were created before the lifecycle metadata feature was enabled (legacy filters).
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
        /// The description of the filter.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FindingCriteria. 
        /// <para>
        /// Represents the criteria to be used in the filter for querying findings.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FindingCriteria FindingCriteria { get; set; }

        /// <summary>
        /// Checks to see if the FindingCriteria property is set.
        /// </summary>
        internal bool IsSetFindingCriteria() => this.FindingCriteria != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the filter.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Rank. 
        /// <para>
        /// Specifies the position of the filter in the list of current filters. Also specifies
        /// the order in which this filter is applied to the findings.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? Rank { get; set; }

        /// <summary>
        /// Checks to see if the Rank property is set.
        /// </summary>
        internal bool IsSetRank() => this.Rank.HasValue;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags of the filter resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the filter was last updated. For legacy filters, this field is
        /// present only after the filter has been updated at least once since the lifecycle metadata
        /// feature was enabled.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the filter. Every time the filter is updated, the version increments
        /// by 1. This field is not available for legacy filters that were created before the
        /// lifecycle metadata feature was enabled.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public long? Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version.HasValue;
    }
}
