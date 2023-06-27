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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateFeatureGroup operation.
    /// Updates the feature group.
    /// </summary>
    public partial class UpdateFeatureGroupRequest : AmazonSageMakerRequest
    {
        private List<FeatureDefinition> _featureAdditions = new List<FeatureDefinition>();
        private string _featureGroupName;
        private OnlineStoreConfigUpdate _onlineStoreConfig;

        /// <summary>
        /// Gets and sets the property FeatureAdditions. 
        /// <para>
        /// Updates the feature group. Updating a feature group is an asynchronous operation.
        /// When you get an HTTP 200 response, you've made a valid request. It takes some time
        /// after you've made a valid request for Feature Store to update the feature group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<FeatureDefinition> FeatureAdditions
        {
            get { return this._featureAdditions; }
            set { this._featureAdditions = value; }
        }

        // Check to see if FeatureAdditions property is set
        internal bool IsSetFeatureAdditions()
        {
            return this._featureAdditions != null && this._featureAdditions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FeatureGroupName. 
        /// <para>
        /// The name of the feature group that you're updating.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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
        /// Gets and sets the property OnlineStoreConfig. 
        /// <para>
        /// Updates the feature group online store configuration.
        /// </para>
        /// </summary>
        public OnlineStoreConfigUpdate OnlineStoreConfig
        {
            get { return this._onlineStoreConfig; }
            set { this._onlineStoreConfig = value; }
        }

        // Check to see if OnlineStoreConfig property is set
        internal bool IsSetOnlineStoreConfig()
        {
            return this._onlineStoreConfig != null;
        }

    }
}