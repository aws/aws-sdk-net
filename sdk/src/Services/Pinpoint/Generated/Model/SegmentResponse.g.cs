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

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Provides information about the configuration, dimension, and other settings for a
    /// segment.
    /// </summary>
    public partial class SegmentResponse
    {
        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The unique identifier for the application that the segment is associated with.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the segment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date and time when the segment was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate != null;

        /// <summary>
        /// Gets and sets the property Dimensions. 
        /// <para>
        /// The dimension settings for the segment.
        /// </para>
        /// </summary>
        public SegmentDimensions Dimensions { get; set; }

        /// <summary>
        /// Checks to see if the Dimensions property is set.
        /// </summary>
        internal bool IsSetDimensions() => this.Dimensions != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for the segment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property ImportDefinition. 
        /// <para>
        /// The settings for the import job that's associated with the segment.
        /// </para>
        /// </summary>
        public SegmentImportResource ImportDefinition { get; set; }

        /// <summary>
        /// Checks to see if the ImportDefinition property is set.
        /// </summary>
        internal bool IsSetImportDefinition() => this.ImportDefinition != null;

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date and time when the segment was last modified.
        /// </para>
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedDate property is set.
        /// </summary>
        internal bool IsSetLastModifiedDate() => this.LastModifiedDate != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the segment.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property SegmentGroups. 
        /// <para>
        /// A list of one or more segment groups that apply to the segment. Each segment group
        /// consists of zero or more base segments and the dimensions that are applied to those
        /// base segments.
        /// </para>
        /// </summary>
        public SegmentGroupList SegmentGroups { get; set; }

        /// <summary>
        /// Checks to see if the SegmentGroups property is set.
        /// </summary>
        internal bool IsSetSegmentGroups() => this.SegmentGroups != null;

        /// <summary>
        /// Gets and sets the property SegmentType. 
        /// <para>
        /// The segment type. Valid values are:
        /// </para>
        ///  <ul><li>
        /// <para>
        /// DIMENSIONAL - A dynamic segment, which is a segment that uses selection criteria that
        /// you specify and is based on endpoint data that's reported by your app. Dynamic segments
        /// can change over time.
        /// </para>
        /// </li> <li>
        /// <para>
        /// IMPORT - A static segment, which is a segment that uses selection criteria that you
        /// specify and is based on endpoint definitions that you import from a file. Imported
        /// segments are static; they don't change over time.
        /// </para>
        /// </li></ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public SegmentType SegmentType { get; set; }

        /// <summary>
        /// Checks to see if the SegmentType property is set.
        /// </summary>
        internal bool IsSetSegmentType() => this.SegmentType != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A string-to-string map of key-value pairs that identifies the tags that are associated
        /// with the segment. Each tag consists of a required tag key and an associated tag value.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version number of the segment.
        /// </para>
        /// </summary>
        public int? Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version.HasValue;
    }
}
