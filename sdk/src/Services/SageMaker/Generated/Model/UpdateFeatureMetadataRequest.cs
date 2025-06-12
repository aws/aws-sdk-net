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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateFeatureMetadata operation.
    /// Updates the description and parameters of the feature group.
    /// </summary>
    public partial class UpdateFeatureMetadataRequest : AmazonSageMakerRequest
    {
        private string _description;
        private string _featureGroupName;
        private string _featureName;
        private List<FeatureParameter> _parameterAdditions = AWSConfigs.InitializeCollections ? new List<FeatureParameter>() : null;
        private List<string> _parameterRemovals = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description that you can write to better describe the feature.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
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
        /// Gets and sets the property FeatureGroupName. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the feature group containing the feature
        /// that you're updating.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string FeatureGroupName
        {
            get { return this._featureGroupName; }
            set { this._featureGroupName = value; }
        }

        // Check to see if FeatureGroupName property is set
        internal bool IsSetFeatureGroupName()
        {
            return this._featureGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property FeatureName. 
        /// <para>
        /// The name of the feature that you're updating.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string FeatureName
        {
            get { return this._featureName; }
            set { this._featureName = value; }
        }

        // Check to see if FeatureName property is set
        internal bool IsSetFeatureName()
        {
            return this._featureName != null;
        }

        /// <summary>
        /// Gets and sets the property ParameterAdditions. 
        /// <para>
        /// A list of key-value pairs that you can add to better describe the feature.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=25)]
        public List<FeatureParameter> ParameterAdditions
        {
            get { return this._parameterAdditions; }
            set { this._parameterAdditions = value; }
        }

        // Check to see if ParameterAdditions property is set
        internal bool IsSetParameterAdditions()
        {
            return this._parameterAdditions != null && (this._parameterAdditions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ParameterRemovals. 
        /// <para>
        /// A list of parameter keys that you can specify to remove parameters that describe your
        /// feature.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=25)]
        public List<string> ParameterRemovals
        {
            get { return this._parameterRemovals; }
            set { this._parameterRemovals = value; }
        }

        // Check to see if ParameterRemovals property is set
        internal bool IsSetParameterRemovals()
        {
            return this._parameterRemovals != null && (this._parameterRemovals.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}