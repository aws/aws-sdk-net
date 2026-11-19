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

namespace Amazon.Kafka.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAssessment operation. Creates a new assessment
    /// for the specified cluster. Kicks off an asynchronous scan.
    /// </summary>
    public partial class CreateAssessmentRequest : AmazonKafkaRequest
    {
        /// <summary>
        /// Gets and sets the property AssessmentParameters. 
        /// <para>
        /// Optional type-specific parameters for the assessment.
        /// </para>
        /// </summary>
        public AssessmentParameters AssessmentParameters { get; set; }

        /// <summary>
        /// Checks to see if the AssessmentParameters property is set.
        /// </summary>
        internal bool IsSetAssessmentParameters() => this.AssessmentParameters != null;

        /// <summary>
        /// Gets and sets the property AssessmentType. 
        /// <para>
        /// The type of assessment to perform.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AssessmentType AssessmentType { get; set; }

        /// <summary>
        /// Checks to see if the AssessmentType property is set.
        /// </summary>
        internal bool IsSetAssessmentType() => this.AssessmentType != null;

        /// <summary>
        /// Gets and sets the property ClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the cluster to assess.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ClusterArn { get; set; }

        /// <summary>
        /// Checks to see if the ClusterArn property is set.
        /// </summary>
        internal bool IsSetClusterArn() => this.ClusterArn != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to attach to the assessment.
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
    }
}
