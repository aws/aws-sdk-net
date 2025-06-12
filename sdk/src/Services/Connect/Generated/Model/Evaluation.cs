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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
    /// Information about a contact evaluation.
    /// </summary>
    public partial class Evaluation
    {
        private Dictionary<string, EvaluationAnswerOutput> _answers = AWSConfigs.InitializeCollections ? new Dictionary<string, EvaluationAnswerOutput>() : null;
        private DateTime? _createdTime;
        private string _evaluationArn;
        private string _evaluationId;
        private DateTime? _lastModifiedTime;
        private EvaluationMetadata _metadata;
        private Dictionary<string, EvaluationNote> _notes = AWSConfigs.InitializeCollections ? new Dictionary<string, EvaluationNote>() : null;
        private Dictionary<string, EvaluationScore> _scores = AWSConfigs.InitializeCollections ? new Dictionary<string, EvaluationScore>() : null;
        private EvaluationStatus _status;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Answers. 
        /// <para>
        /// A map of question identifiers to answer value.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Max=100)]
        public Dictionary<string, EvaluationAnswerOutput> Answers
        {
            get { return this._answers; }
            set { this._answers = value; }
        }

        // Check to see if Answers property is set
        internal bool IsSetAnswers()
        {
            return this._answers != null && (this._answers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The timestamp for when the evaluation was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedTime
        {
            get { return this._createdTime; }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EvaluationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the contact evaluation resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EvaluationArn
        {
            get { return this._evaluationArn; }
            set { this._evaluationArn = value; }
        }

        // Check to see if EvaluationArn property is set
        internal bool IsSetEvaluationArn()
        {
            return this._evaluationArn != null;
        }

        /// <summary>
        /// Gets and sets the property EvaluationId. 
        /// <para>
        /// A unique identifier for the contact evaluation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=500)]
        public string EvaluationId
        {
            get { return this._evaluationId; }
            set { this._evaluationId = value; }
        }

        // Check to see if EvaluationId property is set
        internal bool IsSetEvaluationId()
        {
            return this._evaluationId != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The timestamp for when the evaluation was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// Metadata about the contact evaluation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EvaluationMetadata Metadata
        {
            get { return this._metadata; }
            set { this._metadata = value; }
        }

        // Check to see if Metadata property is set
        internal bool IsSetMetadata()
        {
            return this._metadata != null;
        }

        /// <summary>
        /// Gets and sets the property Notes. 
        /// <para>
        /// A map of question identifiers to note value.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Max=100)]
        public Dictionary<string, EvaluationNote> Notes
        {
            get { return this._notes; }
            set { this._notes = value; }
        }

        // Check to see if Notes property is set
        internal bool IsSetNotes()
        {
            return this._notes != null && (this._notes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Scores. 
        /// <para>
        /// A map of item (section or question) identifiers to score value.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=100)]
        public Dictionary<string, EvaluationScore> Scores
        {
            get { return this._scores; }
            set { this._scores = value; }
        }

        // Check to see if Scores property is set
        internal bool IsSetScores()
        {
            return this._scores != null && (this._scores.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the contact evaluation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EvaluationStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags used to organize, track, or control access for this resource. For example,
        /// { "Tags": {"key1":"value1", "key2":"value2"} }.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}