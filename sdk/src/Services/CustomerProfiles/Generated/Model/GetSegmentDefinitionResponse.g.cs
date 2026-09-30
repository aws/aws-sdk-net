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
    /// This is the response object from the GetSegmentDefinition operation.
    /// </summary>
    public partial class GetSegmentDefinitionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp of when the segment definition was created.
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
        /// The description of the segment definition.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 4000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The display name of the segment definition.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property SegmentDefinitionArn. 
        /// <para>
        /// The arn of the segment definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string SegmentDefinitionArn { get; set; }

        /// <summary>
        /// Checks to see if the SegmentDefinitionArn property is set.
        /// </summary>
        internal bool IsSetSegmentDefinitionArn() => this.SegmentDefinitionArn != null;

        /// <summary>
        /// Gets and sets the property SegmentDefinitionName. 
        /// <para>
        /// The name of the segment definition.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string SegmentDefinitionName { get; set; }

        /// <summary>
        /// Checks to see if the SegmentDefinitionName property is set.
        /// </summary>
        internal bool IsSetSegmentDefinitionName() => this.SegmentDefinitionName != null;

        /// <summary>
        /// Gets and sets the property SegmentGroups. 
        /// <para>
        /// The segment criteria associated with this definition.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public SegmentGroup SegmentGroups { get; set; }

        /// <summary>
        /// Checks to see if the SegmentGroups property is set.
        /// </summary>
        internal bool IsSetSegmentGroups() => this.SegmentGroups != null;

        /// <summary>
        /// Gets and sets the property SegmentSort. 
        /// <para>
        /// The segment sort.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public SegmentSort SegmentSort { get; set; }

        /// <summary>
        /// Checks to see if the SegmentSort property is set.
        /// </summary>
        internal bool IsSetSegmentSort() => this.SegmentSort != null;

        /// <summary>
        /// Gets and sets the property SegmentSqlQuery. 
        /// <para>
        /// The segment SQL query.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 50000)]
        public string SegmentSqlQuery { get; set; }

        /// <summary>
        /// Checks to see if the SegmentSqlQuery property is set.
        /// </summary>
        internal bool IsSetSegmentSqlQuery() => this.SegmentSqlQuery != null;

        /// <summary>
        /// Gets and sets the property SegmentType. 
        /// <para>
        /// The segment type.
        /// </para>
        ///  
        /// <para>
        ///  Classic : Segments created using traditional SegmentGroup structure
        /// </para>
        ///  
        /// <para>
        ///  Enhanced : Segments created using SQL queries 
        /// </para>
        /// </summary>
        public SegmentType SegmentType { get; set; }

        /// <summary>
        /// Checks to see if the SegmentType property is set.
        /// </summary>
        internal bool IsSetSegmentType() => this.SegmentType != null;

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
