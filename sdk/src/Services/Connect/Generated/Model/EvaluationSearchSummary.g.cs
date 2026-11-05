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
    /// Summary of evaluation obtained from the search operation.
    /// </summary>
    public partial class EvaluationSearchSummary
    {
        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The date and time when the evaluation was created, in UTC time.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTime property is set.
        /// </summary>
        internal bool IsSetCreatedTime() => this.CreatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property EvaluationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the contact evaluation resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string EvaluationArn { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationArn property is set.
        /// </summary>
        internal bool IsSetEvaluationArn() => this.EvaluationArn != null;

        /// <summary>
        /// Gets and sets the property EvaluationFormId. 
        /// <para>
        /// The unique identifier for the evaluation form.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public string EvaluationFormId { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationFormId property is set.
        /// </summary>
        internal bool IsSetEvaluationFormId() => this.EvaluationFormId != null;

        /// <summary>
        /// Gets and sets the property EvaluationFormTitle. 
        /// <para>
        /// Title of the evaluation form.
        /// </para>
        /// </summary>
        public string EvaluationFormTitle { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationFormTitle property is set.
        /// </summary>
        internal bool IsSetEvaluationFormTitle() => this.EvaluationFormTitle != null;

        /// <summary>
        /// Gets and sets the property EvaluationFormVersion. 
        /// <para>
        /// A version of the evaluation form.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? EvaluationFormVersion { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationFormVersion property is set.
        /// </summary>
        internal bool IsSetEvaluationFormVersion() => this.EvaluationFormVersion.HasValue;

        /// <summary>
        /// Gets and sets the property EvaluationId. 
        /// <para>
        /// A unique identifier for the contact evaluation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 500)]
        public string EvaluationId { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationId property is set.
        /// </summary>
        internal bool IsSetEvaluationId() => this.EvaluationId != null;

        /// <summary>
        /// Gets and sets the property EvaluationType. 
        /// <para>
        /// Type of the evaluation. 
        /// </para>
        /// </summary>
        public EvaluationType EvaluationType { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationType property is set.
        /// </summary>
        internal bool IsSetEvaluationType() => this.EvaluationType != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The date and time when the evaluation was modified last time, in UTC time.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// Summary information about the evaluation search.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EvaluationSearchMetadata Metadata { get; set; }

        /// <summary>
        /// Checks to see if the Metadata property is set.
        /// </summary>
        internal bool IsSetMetadata() => this.Metadata != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the evaluation. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EvaluationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags used to organize, track, or control access for this resource. For example,
        /// { "Tags": {"key1":"value1", "key2":"value2"} }.
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
