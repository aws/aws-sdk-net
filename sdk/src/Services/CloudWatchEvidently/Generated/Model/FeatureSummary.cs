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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CloudWatchEvidently.Model
{
    /// <summary>
    /// This structure contains information about one Evidently feature in your account.
    /// </summary>
    public partial class FeatureSummary
    {
        private string _arn;
        private DateTime? _createdTime;
        private string _defaultVariation;
        private List<EvaluationRule> _evaluationRules = AWSConfigs.InitializeCollections ? new List<EvaluationRule>() : null;
        private FeatureEvaluationStrategy _evaluationStrategy;
        private DateTime? _lastUpdatedTime;
        private string _name;
        private string _project;
        private FeatureStatus _status;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

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
        /// Gets and sets the property DefaultVariation. 
        /// <para>
        /// The name of the variation that is used as the default variation. The default variation
        /// is served to users who are not allocated to any ongoing launches or experiments of
        /// this feature.
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
        /// Gets and sets the property EvaluationRules. 
        /// <para>
        /// An array of structures that define
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EvaluationRule> EvaluationRules
        {
            get { return this._evaluationRules; }
            set { this._evaluationRules = value; }
        }

        // Check to see if EvaluationRules property is set
        internal bool IsSetEvaluationRules()
        {
            return this._evaluationRules != null && (this._evaluationRules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EvaluationStrategy. 
        /// <para>
        /// If this value is <c>ALL_RULES</c>, the traffic allocation specified by any ongoing
        /// launches or experiments is being used. If this is <c>DEFAULT_VARIATION</c>, the default
        /// variation is being served to all users.
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
        public DateTime? LastUpdatedTime
        {
            get { return this._lastUpdatedTime; }
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
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