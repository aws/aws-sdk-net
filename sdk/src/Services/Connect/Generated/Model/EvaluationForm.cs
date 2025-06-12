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
    /// Information about the evaluation form.
    /// </summary>
    public partial class EvaluationForm
    {
        private string _createdBy;
        private DateTime? _createdTime;
        private string _description;
        private string _evaluationFormArn;
        private string _evaluationFormId;
        private int? _evaluationFormVersion;
        private List<EvaluationFormItem> _items = AWSConfigs.InitializeCollections ? new List<EvaluationFormItem>() : null;
        private string _lastModifiedBy;
        private DateTime? _lastModifiedTime;
        private bool? _locked;
        private EvaluationFormScoringStrategy _scoringStrategy;
        private EvaluationFormVersionStatus _status;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _title;

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the user who created the evaluation form.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CreatedBy
        {
            get { return this._createdBy; }
            set { this._createdBy = value; }
        }

        // Check to see if CreatedBy property is set
        internal bool IsSetCreatedBy()
        {
            return this._createdBy != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The timestamp for when the evaluation form was created.
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the evaluation form.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property EvaluationFormArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the evaluation form resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EvaluationFormArn
        {
            get { return this._evaluationFormArn; }
            set { this._evaluationFormArn = value; }
        }

        // Check to see if EvaluationFormArn property is set
        internal bool IsSetEvaluationFormArn()
        {
            return this._evaluationFormArn != null;
        }

        /// <summary>
        /// Gets and sets the property EvaluationFormId. 
        /// <para>
        /// The unique identifier for the evaluation form.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=500)]
        public string EvaluationFormId
        {
            get { return this._evaluationFormId; }
            set { this._evaluationFormId = value; }
        }

        // Check to see if EvaluationFormId property is set
        internal bool IsSetEvaluationFormId()
        {
            return this._evaluationFormId != null;
        }

        /// <summary>
        /// Gets and sets the property EvaluationFormVersion. 
        /// <para>
        /// A version of the evaluation form.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public int? EvaluationFormVersion
        {
            get { return this._evaluationFormVersion; }
            set { this._evaluationFormVersion = value; }
        }

        // Check to see if EvaluationFormVersion property is set
        internal bool IsSetEvaluationFormVersion()
        {
            return this._evaluationFormVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Items. 
        /// <para>
        /// Items that are part of the evaluation form. The total number of sections and questions
        /// must not exceed 100 each. Questions must be contained in a section.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<EvaluationFormItem> Items
        {
            get { return this._items; }
            set { this._items = value; }
        }

        // Check to see if Items property is set
        internal bool IsSetItems()
        {
            return this._items != null && (this._items.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LastModifiedBy. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the user who last updated the evaluation form.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LastModifiedBy
        {
            get { return this._lastModifiedBy; }
            set { this._lastModifiedBy = value; }
        }

        // Check to see if LastModifiedBy property is set
        internal bool IsSetLastModifiedBy()
        {
            return this._lastModifiedBy != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The timestamp for when the evaluation form was last updated.
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
        /// Gets and sets the property Locked. 
        /// <para>
        /// The flag indicating whether the evaluation form is locked for changes.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Locked
        {
            get { return this._locked; }
            set { this._locked = value; }
        }

        // Check to see if Locked property is set
        internal bool IsSetLocked()
        {
            return this._locked.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ScoringStrategy. 
        /// <para>
        /// A scoring strategy of the evaluation form.
        /// </para>
        /// </summary>
        public EvaluationFormScoringStrategy ScoringStrategy
        {
            get { return this._scoringStrategy; }
            set { this._scoringStrategy = value; }
        }

        // Check to see if ScoringStrategy property is set
        internal bool IsSetScoringStrategy()
        {
            return this._scoringStrategy != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the evaluation form.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EvaluationFormVersionStatus Status
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

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// A title of the evaluation form.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

    }
}