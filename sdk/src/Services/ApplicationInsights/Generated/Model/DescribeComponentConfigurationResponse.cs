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
    /// This is the response object from the DescribeComponentConfiguration operation.
    /// </summary>
    public partial class DescribeComponentConfigurationResponse : AmazonWebServiceResponse
    {
        private string _componentConfiguration;
        private bool? _monitor;
        private Tier _tier;

        /// <summary>
        /// Gets and sets the property ComponentConfiguration. 
        /// <para>
        /// The configuration settings of the component. The value is the escaped JSON of the
        /// configuration.
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
        /// Gets and sets the property Tier. 
        /// <para>
        /// The tier of the application component. Supported tiers include <c>DOT_NET_CORE</c>,
        /// <c>DOT_NET_WORKER</c>, <c>DOT_NET_WEB</c>, <c>SQL_SERVER</c>, and <c>DEFAULT</c> 
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