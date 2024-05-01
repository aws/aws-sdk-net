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
 * Do not modify this file. This file is generated from the application-insights-2018-11-25.normal.json service model.
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
namespace Amazon.ApplicationInsights.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateComponentConfiguration operation.
    /// Updates the monitoring configurations for the component. The configuration input parameter
    /// is an escaped JSON of the configuration and should match the schema of what is returned
    /// by <c>DescribeComponentConfigurationRecommendation</c>.
    /// </summary>
    public partial class UpdateComponentConfigurationRequest : AmazonApplicationInsightsRequest
    {
        private bool? _autoConfigEnabled;
        private string _componentConfiguration;
        private string _componentName;
        private bool? _monitor;
        private string _resourceGroupName;
        private Tier _tier;

        /// <summary>
        /// Gets and sets the property AutoConfigEnabled. 
        /// <para>
        ///  Automatically configures the component by applying the recommended configurations.
        /// 
        /// </para>
        /// </summary>
        public bool? AutoConfigEnabled
        {
            get { return this._autoConfigEnabled; }
            set { this._autoConfigEnabled = value; }
        }

        // Check to see if AutoConfigEnabled property is set
        internal bool IsSetAutoConfigEnabled()
        {
            return this._autoConfigEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ComponentConfiguration. 
        /// <para>
        /// The configuration settings of the component. The value is the escaped JSON of the
        /// configuration. For more information about the JSON format, see <a href="https://docs.aws.amazon.com/sdk-for-javascript/v2/developer-guide/working-with-json.html">Working
        /// with JSON</a>. You can send a request to <c>DescribeComponentConfigurationRecommendation</c>
        /// to see the recommended configuration for a component. For the complete format of the
        /// component configuration file, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/component-config.html">Component
        /// Configuration</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10000)]
        public string ComponentConfiguration
        {
            get { return this._componentConfiguration; }
            set { this._componentConfiguration = value; }
        }

        // Check to see if ComponentConfiguration property is set
        internal bool IsSetComponentConfiguration()
        {
            return this._componentConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ComponentName. 
        /// <para>
        /// The name of the component.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1011)]
        public string ComponentName
        {
            get { return this._componentName; }
            set { this._componentName = value; }
        }

        // Check to see if ComponentName property is set
        internal bool IsSetComponentName()
        {
            return this._componentName != null;
        }

        /// <summary>
        /// Gets and sets the property Monitor. 
        /// <para>
        /// Indicates whether the application component is monitored.
        /// </para>
        /// </summary>
        public bool? Monitor
        {
            get { return this._monitor; }
            set { this._monitor = value; }
        }

        // Check to see if Monitor property is set
        internal bool IsSetMonitor()
        {
            return this._monitor.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceGroupName. 
        /// <para>
        /// The name of the resource group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ResourceGroupName
        {
            get { return this._resourceGroupName; }
            set { this._resourceGroupName = value; }
        }

        // Check to see if ResourceGroupName property is set
        internal bool IsSetResourceGroupName()
        {
            return this._resourceGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property Tier. 
        /// <para>
        /// The tier of the application component.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Tier Tier
        {
            get { return this._tier; }
            set { this._tier = value; }
        }

        // Check to see if Tier property is set
        internal bool IsSetTier()
        {
            return this._tier != null;
        }

    }
}