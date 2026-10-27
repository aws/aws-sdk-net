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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the UpdateComponentConfiguration operation. Updates
    /// the monitoring configurations for the component. The configuration input parameter
    /// is an escaped JSON of the configuration and should match the schema of what is returned
    /// by <c>DescribeComponentConfigurationRecommendation</c>.
    /// </summary>
    public partial class UpdateComponentConfigurationRequest : AmazonApplicationInsightsRequest
    {
        /// <summary>
        /// Gets and sets the property AutoConfigEnabled. 
        /// <para>
        ///  Automatically configures the component by applying the recommended configurations.
        /// 
        /// </para>
        /// </summary>
        public bool? AutoConfigEnabled { get; set; }

        /// <summary>
        /// Checks to see if the AutoConfigEnabled property is set.
        /// </summary>
        internal bool IsSetAutoConfigEnabled() => this.AutoConfigEnabled.HasValue;

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
        [AWSProperty(Min = 1, Max = 10000)]
        public string ComponentConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ComponentConfiguration property is set.
        /// </summary>
        internal bool IsSetComponentConfiguration() => this.ComponentConfiguration != null;

        /// <summary>
        /// Gets and sets the property ComponentName. 
        /// <para>
        /// The name of the component.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1011)]
        public string ComponentName { get; set; }

        /// <summary>
        /// Checks to see if the ComponentName property is set.
        /// </summary>
        internal bool IsSetComponentName() => this.ComponentName != null;

        /// <summary>
        /// Gets and sets the property Monitor. 
        /// <para>
        /// Indicates whether the application component is monitored.
        /// </para>
        /// </summary>
        public bool? Monitor { get; set; }

        /// <summary>
        /// Checks to see if the Monitor property is set.
        /// </summary>
        internal bool IsSetMonitor() => this.Monitor.HasValue;

        /// <summary>
        /// Gets and sets the property ResourceGroupName. 
        /// <para>
        /// The name of the resource group.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ResourceGroupName { get; set; }

        /// <summary>
        /// Checks to see if the ResourceGroupName property is set.
        /// </summary>
        internal bool IsSetResourceGroupName() => this.ResourceGroupName != null;

        /// <summary>
        /// Gets and sets the property Tier. 
        /// <para>
        /// The tier of the application component.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Tier Tier { get; set; }

        /// <summary>
        /// Checks to see if the Tier property is set.
        /// </summary>
        internal bool IsSetTier() => this.Tier != null;
    }
}
