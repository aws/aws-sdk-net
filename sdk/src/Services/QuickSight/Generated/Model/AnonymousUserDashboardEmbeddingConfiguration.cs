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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Information about the dashboard that you want to embed.
    /// </summary>
    public partial class AnonymousUserDashboardEmbeddingConfiguration
    {
        private List<string> _disabledFeatures = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _enabledFeatures = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private AnonymousUserDashboardFeatureConfigurations _featureConfigurations;
        private string _initialDashboardId;

        /// <summary>
        /// Gets and sets the property DisabledFeatures. 
        /// <para>
        /// A list of all disabled features of a specified anonymous dashboard.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DisabledFeatures
        {
            get { return this._disabledFeatures; }
            set { this._disabledFeatures = value; }
        }

        // Check to see if DisabledFeatures property is set
        internal bool IsSetDisabledFeatures()
        {
            return this._disabledFeatures != null && (this._disabledFeatures.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EnabledFeatures. 
        /// <para>
        /// A list of all enabled features of a specified anonymous dashboard.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EnabledFeatures
        {
            get { return this._enabledFeatures; }
            set { this._enabledFeatures = value; }
        }

        // Check to see if EnabledFeatures property is set
        internal bool IsSetEnabledFeatures()
        {
            return this._enabledFeatures != null && (this._enabledFeatures.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FeatureConfigurations. 
        /// <para>
        /// The feature configuration for an embedded dashboard.
        /// </para>
        /// </summary>
        public AnonymousUserDashboardFeatureConfigurations FeatureConfigurations
        {
            get { return this._featureConfigurations; }
            set { this._featureConfigurations = value; }
        }

        // Check to see if FeatureConfigurations property is set
        internal bool IsSetFeatureConfigurations()
        {
            return this._featureConfigurations != null;
        }

        /// <summary>
        /// Gets and sets the property InitialDashboardId. 
        /// <para>
        /// The dashboard ID for the dashboard that you want the user to see first. This ID is
        /// included in the output URL. When the URL in response is accessed, QuickSight renders
        /// this dashboard.
        /// </para>
        ///  
        /// <para>
        /// The Amazon Resource Name (ARN) of this dashboard must be included in the <c>AuthorizedResourceArns</c>
        /// parameter. Otherwise, the request will fail with <c>InvalidParameterValueException</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string InitialDashboardId
        {
            get { return this._initialDashboardId; }
            set { this._initialDashboardId = value; }
        }

        // Check to see if InitialDashboardId property is set
        internal bool IsSetInitialDashboardId()
        {
            return this._initialDashboardId != null;
        }

    }
}