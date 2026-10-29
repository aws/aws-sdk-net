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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Information about an extraction definition.
    /// </summary>
    public partial class ExtractionDefinition
    {
        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The timestamp when the extraction definition was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTime property is set.
        /// </summary>
        internal bool IsSetCreatedTime() => this.CreatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Display. 
        /// <para>
        /// The display settings for the extraction definition.
        /// </para>
        /// </summary>
        public ExtractionDefinitionDisplay Display { get; set; }

        /// <summary>
        /// Checks to see if the Display property is set.
        /// </summary>
        internal bool IsSetDisplay() => this.Display != null;

        /// <summary>
        /// Gets and sets the property ExtractionConfiguration. 
        /// <para>
        /// The configuration that defines how data is extracted.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ExtractionConfiguration ExtractionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ExtractionConfiguration property is set.
        /// </summary>
        internal bool IsSetExtractionConfiguration() => this.ExtractionConfiguration != null;

        /// <summary>
        /// Gets and sets the property ExtractionDefinitionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the extraction definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ExtractionDefinitionArn { get; set; }

        /// <summary>
        /// Checks to see if the ExtractionDefinitionArn property is set.
        /// </summary>
        internal bool IsSetExtractionDefinitionArn() => this.ExtractionDefinitionArn != null;

        /// <summary>
        /// Gets and sets the property ExtractionDefinitionId. 
        /// <para>
        /// The identifier of the extraction definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ExtractionDefinitionId { get; set; }

        /// <summary>
        /// Checks to see if the ExtractionDefinitionId property is set.
        /// </summary>
        internal bool IsSetExtractionDefinitionId() => this.ExtractionDefinitionId != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedBy. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the user who last updated the extraction definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string LastUpdatedBy { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedBy property is set.
        /// </summary>
        internal bool IsSetLastUpdatedBy() => this.LastUpdatedBy != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The timestamp when the extraction definition was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastUpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTime() => this.LastUpdatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the extraction definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 200)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

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
