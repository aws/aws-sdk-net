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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ResilienceHub.Model
{
    /// <summary>
    /// Defines a recommendation template created with the <a>CreateRecommendationTemplate</a>
    /// action.
    /// </summary>
    public partial class RecommendationTemplate
    {
        private string _appArn;
        private string _assessmentArn;
        private DateTime? _endTime;
        private TemplateFormat _format;
        private string _message;
        private string _name;
        private bool? _needsReplacements;
        private List<string> _recommendationIds = new List<string>();
        private string _recommendationTemplateArn;
        private List<string> _recommendationTypes = new List<string>();
        private DateTime? _startTime;
        private RecommendationTemplateStatus _status;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private S3Location _templatesLocation;

        /// <summary>
        /// Gets and sets the property AppArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the application. The format for this ARN is: arn:<code>partition</code>:resiliencehub:<code>region</code>:<code>account</code>:app/<code>app-id</code>.
        /// For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">
        /// Amazon Resource Names (ARNs)</a> in the <i>AWS General Reference</i>.
        /// </para>
        /// </summary>
        public string AppArn
        {
            get { return this._appArn; }
            set { this._appArn = value; }
        }

        // Check to see if AppArn property is set
        internal bool IsSetAppArn()
        {
            return this._appArn != null;
        }

        /// <summary>
        /// Gets and sets the property AssessmentArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the assessment. The format for this ARN is: arn:<code>partition</code>:resiliencehub:<code>region</code>:<code>account</code>:app-assessment/<code>app-id</code>.
        /// For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">
        /// Amazon Resource Names (ARNs)</a> in the <i>AWS General Reference</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AssessmentArn
        {
            get { return this._assessmentArn; }
            set { this._assessmentArn = value; }
        }

        // Check to see if AssessmentArn property is set
        internal bool IsSetAssessmentArn()
        {
            return this._assessmentArn != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end time for the action.
        /// </para>
        /// </summary>
        public DateTime EndTime
        {
            get { return this._endTime.GetValueOrDefault(); }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// The format of the recommendation template.
        /// </para>
        ///  <dl> <dt>CfnJson</dt> <dd> 
        /// <para>
        /// The template is CloudFormation JSON.
        /// </para>
        ///  </dd> <dt>CfnYaml</dt> <dd> 
        /// <para>
        /// The template is CloudFormation YAML.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        [AWSProperty(Required=true)]
        public TemplateFormat Format
        {
            get { return this._format; }
            set { this._format = value; }
        }

        // Check to see if Format property is set
        internal bool IsSetFormat()
        {
            return this._format != null;
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The message for the recommendation template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for the recommendation template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property NeedsReplacements. 
        /// <para>
        /// Indicates if replacements are needed.
        /// </para>
        /// </summary>
        public bool NeedsReplacements
        {
            get { return this._needsReplacements.GetValueOrDefault(); }
            set { this._needsReplacements = value; }
        }

        // Check to see if NeedsReplacements property is set
        internal bool IsSetNeedsReplacements()
        {
            return this._needsReplacements.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RecommendationIds. 
        /// <para>
        /// Identifiers for the recommendations used in the recommendation template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public List<string> RecommendationIds
        {
            get { return this._recommendationIds; }
            set { this._recommendationIds = value; }
        }

        // Check to see if RecommendationIds property is set
        internal bool IsSetRecommendationIds()
        {
            return this._recommendationIds != null && this._recommendationIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RecommendationTemplateArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the recommendation template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RecommendationTemplateArn
        {
            get { return this._recommendationTemplateArn; }
            set { this._recommendationTemplateArn = value; }
        }

        // Check to see if RecommendationTemplateArn property is set
        internal bool IsSetRecommendationTemplateArn()
        {
            return this._recommendationTemplateArn != null;
        }

        /// <summary>
        /// Gets and sets the property RecommendationTypes. 
        /// <para>
        /// An array of strings that specify the recommendation template type or types.
        /// </para>
        ///  <dl> <dt>Alarm</dt> <dd> 
        /// <para>
        /// The template is an <a>AlarmRecommendation</a> template.
        /// </para>
        ///  </dd> <dt>Sop</dt> <dd> 
        /// <para>
        /// The template is a <a>SopRecommendation</a> template.
        /// </para>
        ///  </dd> <dt>Test</dt> <dd> 
        /// <para>
        /// The template is a <a>TestRecommendation</a> template.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=4)]
        public List<string> RecommendationTypes
        {
            get { return this._recommendationTypes; }
            set { this._recommendationTypes = value; }
        }

        // Check to see if RecommendationTypes property is set
        internal bool IsSetRecommendationTypes()
        {
            return this._recommendationTypes != null && this._recommendationTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start time for the action.
        /// </para>
        /// </summary>
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the action.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RecommendationTemplateStatus Status
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
        /// The tags assigned to the resource. A tag is a label that you assign to an Amazon Web
        /// Services resource. Each tag consists of a key/value pair.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TemplatesLocation. 
        /// <para>
        /// The file location of the template.
        /// </para>
        /// </summary>
        public S3Location TemplatesLocation
        {
            get { return this._templatesLocation; }
            set { this._templatesLocation = value; }
        }

        // Check to see if TemplatesLocation property is set
        internal bool IsSetTemplatesLocation()
        {
            return this._templatesLocation != null;
        }

    }
}