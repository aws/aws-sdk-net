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
    /// Container for the parameters to the UpdateFeature operation.
    /// Updates an existing feature.
    /// 
    ///  
    /// <para>
    /// You can't use this operation to update the tags of an existing feature. Instead, use
    /// <a href="https://docs.aws.amazon.com/cloudwatchevidently/latest/APIReference/API_TagResource.html">TagResource</a>.
    /// 
    /// </para>
    /// </summary>
    public partial class UpdateFeatureRequest : AmazonCloudWatchEvidentlyRequest
    {
        private List<VariationConfig> _addOrUpdateVariations = new List<VariationConfig>();
        private string _defaultVariation;
        private string _description;
        private Dictionary<string, string> _entityOverrides = new Dictionary<string, string>();
        private FeatureEvaluationStrategy _evaluationStrategy;
        private string _feature;
        private string _project;
        private List<string> _removeVariations = new List<string>();

        /// <summary>
        /// Gets and sets the property AddOrUpdateVariations. 
        /// <para>
        /// To update variation configurations for this feature, or add new ones, specify this
        /// structure. In this array, include any variations that you want to add or update. If
        /// the array includes a variation name that already exists for this feature, it is updated.
        /// If it includes a new variation name, it is added as a new variation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public List<VariationConfig> AddOrUpdateVariations
        {
            get { return this._addOrUpdateVariations; }
            set { this._addOrUpdateVariations = value; }
        }

        // Check to see if AddOrUpdateVariations property is set
        internal bool IsSetAddOrUpdateVariations()
        {
            return this._addOrUpdateVariations != null && this._addOrUpdateVariations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DefaultVariation. 
        /// <para>
        /// The name of the variation to use as the default variation. The default variation is
        /// served to users who are not allocated to any ongoing launches or experiments of this
        /// feature.
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
        /// An optional description of the feature.
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
        /// Specified users that should always be served a specific variation of a feature. Each
        /// user is specified by a key-value pair . For each key, specify a user by entering their
        /// user ID, account ID, or some other identifier. For the value, specify the name of
        /// the variation that they are to be served.
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
        /// Gets and sets the property EvaluationStrategy. 
        /// <para>
        /// Specify <code>ALL_RULES</code> to activate the traffic allocation specified by any
        /// ongoing launches or experiments. Specify <code>DEFAULT_VARIATION</code> to serve the
        /// default variation to all users instead.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Feature. 
        /// <para>
        /// The name of the feature to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=127)]
        public string Feature
        {
            get { return this._feature; }
            set { this._feature = value; }
        }

        // Check to see if Feature property is set
        internal bool IsSetFeature()
        {
            return this._feature != null;
        }

        /// <summary>
        /// Gets and sets the property Project. 
        /// <para>
        /// The name or ARN of the project that contains the feature to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
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
        /// Gets and sets the property RemoveVariations. 
        /// <para>
        /// Removes a variation from the feature. If the variation you specify doesn't exist,
        /// then this makes no change and does not report an error.
        /// </para>
        ///  
        /// <para>
        /// This operation fails if you try to remove a variation that is part of an ongoing launch
        /// or experiment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<string> RemoveVariations
        {
            get { return this._removeVariations; }
            set { this._removeVariations = value; }
        }

        // Check to see if RemoveVariations property is set
        internal bool IsSetRemoveVariations()
        {
            return this._removeVariations != null && this._removeVariations.Count > 0; 
        }

    }
}