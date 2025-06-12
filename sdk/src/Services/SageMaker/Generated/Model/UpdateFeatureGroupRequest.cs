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
    /// Container for the parameters to the UpdateFeatureGroup operation.
    /// Updates the feature group by either adding features or updating the online store configuration.
    /// Use one of the following request parameters at a time while using the <c>UpdateFeatureGroup</c>
    /// API.
    /// 
    ///  
    /// <para>
    /// You can add features for your feature group using the <c>FeatureAdditions</c> request
    /// parameter. Features cannot be removed from a feature group.
    /// </para>
    ///  
    /// <para>
    /// You can update the online store configuration by using the <c>OnlineStoreConfig</c>
    /// request parameter. If a <c>TtlDuration</c> is specified, the default <c>TtlDuration</c>
    /// applies for all records added to the feature group <i>after the feature group is updated</i>.
    /// If a record level <c>TtlDuration</c> exists from using the <c>PutRecord</c> API, the
    /// record level <c>TtlDuration</c> applies to that record instead of the default <c>TtlDuration</c>.
    /// To remove the default <c>TtlDuration</c> from an existing feature group, use the <c>UpdateFeatureGroup</c>
    /// API and set the <c>TtlDuration</c> <c>Unit</c> and <c>Value</c> to <c>null</c>.
    /// </para>
    /// </summary>
    public partial class UpdateFeatureGroupRequest : AmazonSageMakerRequest
    {
        private List<FeatureDefinition> _featureAdditions = AWSConfigs.InitializeCollections ? new List<FeatureDefinition>() : null;
        private string _featureGroupName;
        private OnlineStoreConfigUpdate _onlineStoreConfig;
        private ThroughputConfigUpdate _throughputConfig;

        /// <summary>
        /// Gets and sets the property FeatureAdditions. 
        /// <para>
        /// Updates the feature group. Updating a feature group is an asynchronous operation.
        /// When you get an HTTP 200 response, you've made a valid request. It takes some time
        /// after you've made a valid request for Feature Store to update the feature group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._featureAdditions != null && (this._featureAdditions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FeatureGroupName. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the feature group that you're updating.
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

        /// <summary>
        /// Gets and sets the property ThroughputConfig.
        /// </summary>
        public ThroughputConfigUpdate ThroughputConfig
        {
            get { return this._throughputConfig; }
            set { this._throughputConfig = value; }
        }

        // Check to see if ThroughputConfig property is set
        internal bool IsSetThroughputConfig()
        {
            return this._throughputConfig != null;
        }

    }
}