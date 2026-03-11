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
    /// Information about the returned evaluation forms.
    /// </summary>
    public partial class EvaluationFormSearchSummary
    {
        private int? _activeVersion;
        private bool? _autoEvaluationEnabled;
        private ContactInteractionType _contactInteractionType;
        private string _createdBy;
        private DateTime? _createdTime;
        private string _description;
        private string _evaluationFormArn;
        private string _evaluationFormId;
        private EvaluationFormLanguageCode _evaluationFormLanguage;
        private string _lastActivatedBy;
        private DateTime? _lastActivatedTime;
        private string _lastModifiedBy;
        private DateTime? _lastModifiedTime;
        private int? _latestVersion;
        private EvaluationFormVersionStatus _status;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _title;

        /// <summary>
        /// Gets and sets the property ActiveVersion. 
        /// <para>
        /// Active version of the evaluation form.
        /// </para>
        /// </summary>
        public int? ActiveVersion
        {
            get { return this._activeVersion; }
            set { this._activeVersion = value; }
        }

        // Check to see if ActiveVersion property is set
        internal bool IsSetActiveVersion()
        {
            return this._activeVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AutoEvaluationEnabled. 
        /// <para>
        /// Whether automated evaluation is enabled.
        /// </para>
        /// </summary>
        public bool? AutoEvaluationEnabled
        {
            get { return this._autoEvaluationEnabled; }
            set { this._autoEvaluationEnabled = value; }
        }

        // Check to see if AutoEvaluationEnabled property is set
        internal bool IsSetAutoEvaluationEnabled()
        {
            return this._autoEvaluationEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ContactInteractionType. 
        /// <para>
        /// The contact interaction type for this evaluation form.
        /// </para>
        /// </summary>
        public ContactInteractionType ContactInteractionType
        {
            get { return this._contactInteractionType; }
            set { this._contactInteractionType = value; }
        }

        // Check to see if ContactInteractionType property is set
        internal bool IsSetContactInteractionType()
        {
            return this._contactInteractionType != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// Who created the evaluation form.
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
        /// When the evaluation form was created.
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
        /// Gets and sets the property EvaluationFormLanguage. 
        /// <para>
        /// The language of the evaluation form.
        /// </para>
        /// </summary>
        public EvaluationFormLanguageCode EvaluationFormLanguage
        {
            get { return this._evaluationFormLanguage; }
            set { this._evaluationFormLanguage = value; }
        }

        // Check to see if EvaluationFormLanguage property is set
        internal bool IsSetEvaluationFormLanguage()
        {
            return this._evaluationFormLanguage != null;
        }

        /// <summary>
        /// Gets and sets the property LastActivatedBy. 
        /// <para>
        /// The ID of user who last activated evaluation form.
        /// </para>
        /// </summary>
        public string LastActivatedBy
        {
            get { return this._lastActivatedBy; }
            set { this._lastActivatedBy = value; }
        }

        // Check to see if LastActivatedBy property is set
        internal bool IsSetLastActivatedBy()
        {
            return this._lastActivatedBy != null;
        }

        /// <summary>
        /// Gets and sets the property LastActivatedTime. 
        /// <para>
        /// When the evaluation format was last activated.
        /// </para>
        /// </summary>
        public DateTime? LastActivatedTime
        {
            get { return this._lastActivatedTime; }
            set { this._lastActivatedTime = value; }
        }

        // Check to see if LastActivatedTime property is set
        internal bool IsSetLastActivatedTime()
        {
            return this._lastActivatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastModifiedBy. 
        /// <para>
        /// Who changed the evaluation form.
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
        /// When the evaluation form was last changed.
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
        /// Gets and sets the property LatestVersion. 
        /// <para>
        /// Latest version of the evaluation form.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? LatestVersion
        {
            get { return this._latestVersion; }
            set { this._latestVersion = value; }
        }

        // Check to see if LatestVersion property is set
        internal bool IsSetLatestVersion()
        {
            return this._latestVersion.HasValue; 
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
        /// The title of the evaluation form.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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