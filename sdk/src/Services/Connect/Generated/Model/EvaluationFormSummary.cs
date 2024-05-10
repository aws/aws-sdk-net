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
    /// Summary information about an evaluation form.
    /// </summary>
    public partial class EvaluationFormSummary
    {
        private int? _activeVersion;
        private string _createdBy;
        private DateTime? _createdTime;
        private string _evaluationFormArn;
        private string _evaluationFormId;
        private string _lastActivatedBy;
        private DateTime? _lastActivatedTime;
        private string _lastModifiedBy;
        private DateTime? _lastModifiedTime;
        private int? _latestVersion;
        private string _title;

        /// <summary>
        /// Gets and sets the property ActiveVersion. 
        /// <para>
        /// The version of the active evaluation form version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// Gets and sets the property LastActivatedBy. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the user who last activated the evaluation form.
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
        /// The timestamp for when the evaluation form was last activated.
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
        /// Gets and sets the property LatestVersion. 
        /// <para>
        /// The version number of the latest evaluation form version.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
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