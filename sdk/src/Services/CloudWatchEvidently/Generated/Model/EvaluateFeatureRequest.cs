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
    /// Container for the parameters to the EvaluateFeature operation.
    /// This operation assigns a feature variation to one given user session. You pass in
    /// an <code>entityID</code> that represents the user. Evidently then checks the evaluation
    /// rules and assigns the variation.
    /// 
    ///  
    /// <para>
    /// The first rules that are evaluated are the override rules. If the user's <code>entityID</code>
    /// matches an override rule, the user is served the variation specified by that rule.
    /// </para>
    ///  
    /// <para>
    /// If there is a current launch with this feature that uses segment overrides, and if
    /// the user session's <code>evaluationContext</code> matches a segment rule defined in
    /// a segment override, the configuration in the segment overrides is used. For more information
    /// about segments, see <a href="https://docs.aws.amazon.com/cloudwatchevidently/latest/APIReference/API_CreateSegment.html">CreateSegment</a>
    /// and <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-Evidently-segments.html">Use
    /// segments to focus your audience</a>.
    /// </para>
    ///  
    /// <para>
    /// If there is a launch with no segment overrides, the user might be assigned to a variation
    /// in the launch. The chance of this depends on the percentage of users that are allocated
    /// to that launch. If the user is enrolled in the launch, the variation they are served
    /// depends on the allocation of the various feature variations used for the launch.
    /// </para>
    ///  
    /// <para>
    /// If the user is not assigned to a launch, and there is an ongoing experiment for this
    /// feature, the user might be assigned to a variation in the experiment. The chance of
    /// this depends on the percentage of users that are allocated to that experiment.
    /// </para>
    ///  
    /// <para>
    /// If the experiment uses a segment, then only user sessions with <code>evaluationContext</code>
    /// values that match the segment rule are used in the experiment.
    /// </para>
    ///  
    /// <para>
    /// If the user is enrolled in the experiment, the variation they are served depends on
    /// the allocation of the various feature variations used for the experiment. 
    /// </para>
    ///  
    /// <para>
    /// If the user is not assigned to a launch or experiment, they are served the default
    /// variation.
    /// </para>
    /// </summary>
    public partial class EvaluateFeatureRequest : AmazonCloudWatchEvidentlyRequest
    {
        private string _entityId;
        private string _evaluationContext;
        private string _feature;
        private string _project;

        /// <summary>
        /// Gets and sets the property EntityId. 
        /// <para>
        /// An internal ID that represents a unique user of the application. This <code>entityID</code>
        /// is checked against any override rules assigned for this feature.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string EntityId
        {
            get { return this._entityId; }
            set { this._entityId = value; }
        }

        // Check to see if EntityId property is set
        internal bool IsSetEntityId()
        {
            return this._entityId != null;
        }

        /// <summary>
        /// Gets and sets the property EvaluationContext. 
        /// <para>
        /// A JSON object of attributes that you can optionally pass in as part of the evaluation
        /// event sent to Evidently from the user session. Evidently can use this value to match
        /// user sessions with defined audience segments. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-Evidently-segments.html">Use
        /// segments to focus your audience</a>.
        /// </para>
        ///  
        /// <para>
        /// If you include this parameter, the value must be a JSON object. A JSON array is not
        /// supported.
        /// </para>
        /// </summary>
        public string EvaluationContext
        {
            get { return this._evaluationContext; }
            set { this._evaluationContext = value; }
        }

        // Check to see if EvaluationContext property is set
        internal bool IsSetEvaluationContext()
        {
            return this._evaluationContext != null;
        }

        /// <summary>
        /// Gets and sets the property Feature. 
        /// <para>
        /// The name of the feature being evaluated.
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
        /// The name or ARN of the project that contains this feature.
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

    }
}