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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the CreateIntegrationResourceProperty operation. This
    /// API can be used for setting up the <c>ResourceProperty</c> of the Glue connection
    /// (for the source) or Glue database ARN (for the target). These properties can include
    /// the role to access the connection or database. To set both source and target properties
    /// the same API needs to be invoked with the Glue connection ARN as <c>ResourceArn</c>
    /// with <c>SourceProcessingProperties</c> and the Glue database ARN as <c>ResourceArn</c>
    /// with <c>TargetProcessingProperties</c> respectively.
    /// </summary>
    public partial class CreateIntegrationResourcePropertyRequest : AmazonGlueRequest
    {
        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The connection ARN of the source, or the database ARN of the target.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;

        /// <summary>
        /// Gets and sets the property SourceProcessingProperties. 
        /// <para>
        /// The resource properties associated with the integration source.
        /// </para>
        /// </summary>
        public SourceProcessingProperties SourceProcessingProperties { get; set; }

        /// <summary>
        /// Checks to see if the SourceProcessingProperties property is set.
        /// </summary>
        internal bool IsSetSourceProcessingProperties() => this.SourceProcessingProperties != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Metadata assigned to the resource consisting of a list of key-value pairs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TargetProcessingProperties. 
        /// <para>
        /// The resource properties associated with the integration target.
        /// </para>
        /// </summary>
        public TargetProcessingProperties TargetProcessingProperties { get; set; }

        /// <summary>
        /// Checks to see if the TargetProcessingProperties property is set.
        /// </summary>
        internal bool IsSetTargetProcessingProperties() => this.TargetProcessingProperties != null;
    }
}
