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
 * Do not modify this file. This file is generated from the evidently-2021-02-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatchEvidently.Model
{
    /// <summary>
    /// This structure contains information about one Evidently feature in your account.
    /// </summary>
    public partial class Feature
    {
        private string _arn;
        private DateTime? _createdTime;
        private string _defaultVariation;
        private string _description;
        private Dictionary<string, string> _entityOverrides = new Dictionary<string, string>();
        private List<EvaluationRule> _evaluationRules = new List<EvaluationRule>();
        private FeatureEvaluationStrategy _evaluationStrategy;
        private DateTime? _lastUpdatedTime;
        private string _name;
        private string _project;
        private FeatureStatus _status;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private VariationValueType _valueType;
        private List<Variation> _variations = new List<Variation>();

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the feature.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The date and time that the feature is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreatedTime
        {
            get { return this._createdTime.GetValueOrDefault(); }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DefaultVariation. 
        /// <para>
        /// The name of the variation that is used as the default variation. The default variation
        /// is served to users who are not allocated to any ongoing launches or experiments of
        /// this feature.
        /// </para>
        ///  
        /// <para>
        /// This variation must also be listed in the <code>variations</code> structure.
        /// </para>
        ///  
        /// <para>
        /// If you omit <code>defaultVariation</code>, the first variation listed in the <code>variations</code>
        /// structure is used as the default variation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=127)]
        public string DefaultVariation
        {
            get { return this._defaultVariation; }
            set { this._defaultVariation = value; }
        }

        // Check to see if DefaultVariation property is set
        internal bool IsSetDefaultVariation()
        {
            return this._defaultVariation != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the feature.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=160)]
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
        /// Gets and sets the property EntityOverrides. 
        /// <para>
        /// A set of key-value pairs that specify users who should always be served a specific
        /// variation of a feature. Each key specifies a user using their user ID, account ID,
        /// or some other identifier. The value specifies the name of the variation that the user
        /// is to be served.
        /// </para>
        ///  
        /// <para>
        /// For the override to be successful, the value of the key must match the <code>entityId</code>
        /// used in the <a href="https://docs.aws.amazon.com/cloudwatchevidently/latest/APIReference/API_EvaluateFeature.html">EvaluateFeature</a>
        /// operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2500)]
        public Dictionary<string, string> EntityOverrides
        {
            get { return this._entityOverrides; }
            set { this._entityOverrides = value; }
        }

        // Check to see if EntityOverrides property is set
        internal bool IsSetEntityOverrides()
        {
            return this._entityOverrides != null && this._entityOverrides.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EvaluationRules. 
        /// <para>
        /// An array of structures that define the evaluation rules for the feature.
        /// </para>
        /// </summary>
        public List<EvaluationRule> EvaluationRules
        {
            get { return this._evaluationRules; }
            set { this._evaluationRules = value; }
        }

        // Check to see if EvaluationRules property is set
        internal bool IsSetEvaluationRules()
        {
            return this._evaluationRules != null && this._evaluationRules.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EvaluationStrategy. 
        /// <para>
        /// If this value is <code>ALL_RULES</code>, the traffic allocation specified by any ongoing
        /// launches or experiments is being used. If this is <code>DEFAULT_VARIATION</code>,
        /// the default variation is being served to all users.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FeatureEvaluationStrategy EvaluationStrategy
        {
            get { return this._evaluationStrategy; }
            set { this._evaluationStrategy = value; }
        }

        // Check to see if EvaluationStrategy property is set
        internal bool IsSetEvaluationStrategy()
        {
            return this._evaluationStrategy != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The date and time that the feature was most recently updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime LastUpdatedTime
        {
            get { return this._lastUpdatedTime.GetValueOrDefault(); }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the feature.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=127)]
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
        /// Gets and sets the property Project. 
        /// <para>
        /// The name or ARN of the project that contains the feature.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string Project
        {
            get { return this._project; }
            set { this._project = value; }
        }

        // Check to see if Project property is set
        internal bool IsSetProject()
        {
            return this._project != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current state of the feature.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FeatureStatus Status
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
        /// The list of tag keys and values associated with this feature.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ValueType. 
        /// <para>
        /// Defines the type of value used to define the different feature variations. For more
        /// information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-Evidently-variationtypes.html">Variation
        /// types</a> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public VariationValueType ValueType
        {
            get { return this._valueType; }
            set { this._valueType = value; }
        }

        // Check to see if ValueType property is set
        internal bool IsSetValueType()
        {
            return this._valueType != null;
        }

        /// <summary>
        /// Gets and sets the property Variations. 
        /// <para>
        /// An array of structures that contain the configuration of the feature's different variations.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Variation> Variations
        {
            get { return this._variations; }
            set { this._variations = value; }
        }

        // Check to see if Variations property is set
        internal bool IsSetVariations()
        {
            return this._variations != null && this._variations.Count > 0; 
        }

    }
}