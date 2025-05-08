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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Properties associated with the integration.
    /// </summary>
    public partial class IntegrationConfig
    {
        private string _refreshInterval;

        /// <summary>
        /// Gets and sets the property RefreshInterval. 
        /// <para>
        /// Specifies the frequency at which CDC (Change Data Capture) pulls or incremental loads
        /// should occur. This parameter provides flexibility to align the refresh rate with your
        /// specific data update patterns, system load considerations, and performance optimization
        /// goals. Time increment can be set from 15 minutes to 8640 minutes (six days). Currently
        /// supports creation of <c>RefreshInterval</c> only.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string RefreshInterval
        {
            get { return this._refreshInterval; }
            set { this._refreshInterval = value; }
        }

        // Check to see if RefreshInterval property is set
        internal bool IsSetRefreshInterval()
        {
            return this._refreshInterval != null;
        }

    }
}