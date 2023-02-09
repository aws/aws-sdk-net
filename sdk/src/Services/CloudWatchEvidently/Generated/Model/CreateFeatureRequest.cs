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
    /// Container for the parameters to the CreateFeature operation.
    /// Creates an Evidently <i>feature</i> that you want to launch or test. You can define
    /// up to five variations of a feature, and use these variations in your launches and
    /// experiments. A feature must be created in a project. For information about creating
    /// a project, see <a href="https://docs.aws.amazon.com/cloudwatchevidently/latest/APIReference/API_CreateProject.html">CreateProject</a>.
    /// 
    ///  
    /// <para>
    /// Don't use this operation to update an existing feature. Instead, use <a href="https://docs.aws.amazon.com/cloudwatchevidently/latest/APIReference/API_UpdateFeature.html">UpdateFeature</a>.
    /// 
    /// </para>
    /// </summary>
    public partial class CreateFeatureRequest : AmazonCloudWatchEvidentlyRequest
    {
        private string _defaultVariation;
        private string _description;
        private Dictionary<string, string> _entityOverrides = new Dictionary<string, string>();
        private FeatureEvaluationStrategy _evaluationStrategy;
        private string _name;
        private string _project;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private List<VariationConfig> _variations = new List<VariationConfig>();

        /// <summary>
        /// Gets and sets the property DefaultVariation. 
        /// <para>
        /// The name of the variation to use as the default variation. The default variation is
        /// served to users who are not allocated to any ongoing launches or experiments of this
        /// feature.
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
        /// Specify users that should always be served a specific variation of a feature. Each
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for the new feature.
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
        /// The name or ARN of the project that is to contain the new feature.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Assigns one or more tags (key-value pairs) to the feature.
        /// </para>
        ///  
        /// <para>
        /// Tags can help you organize and categorize your resources. You can also use them to
        /// scope user permissions by granting a user permission to access or change only resources
        /// with certain tag values.
        /// </para>
        ///  
        /// <para>
        /// Tags don't have any semantic meaning to Amazon Web Services and are interpreted strictly
        /// as strings of characters.
        /// </para>
        ///  
        /// <para>
        /// You can associate as many as 50 tags with a feature.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// Amazon Web Services resources</a>.
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
        /// Gets and sets the property Variations. 
        /// <para>
        /// An array of structures that contain the configuration of the feature's different variations.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public List<VariationConfig> Variations
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