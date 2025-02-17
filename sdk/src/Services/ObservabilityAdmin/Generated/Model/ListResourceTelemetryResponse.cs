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
 * Do not modify this file. This file is generated from the observabilityadmin-2018-05-10.normal.json service model.
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
namespace Amazon.ObservabilityAdmin.Model
{
    /// <summary>
    /// This is the response object from the ListResourceTelemetry operation.
    /// </summary>
    public partial class ListResourceTelemetryResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<TelemetryConfiguration> _telemetryConfigurations = AWSConfigs.InitializeCollections ? new List<TelemetryConfiguration>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  The token for the next set of items to return. A previous call generates this token.
        /// 
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property TelemetryConfigurations. 
        /// <para>
        ///  A list of telemetry configurations for AWS resources supported by telemetry config
        /// in the caller's account. 
        /// </para>
        /// </summary>
        public List<TelemetryConfiguration> TelemetryConfigurations
        {
            get { return this._telemetryConfigurations; }
            set { this._telemetryConfigurations = value; }
        }

        // Check to see if TelemetryConfigurations property is set
        internal bool IsSetTelemetryConfigurations()
        {
            return this._telemetryConfigurations != null && (this._telemetryConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}