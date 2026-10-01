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
 * Do not modify this file. This file is generated from the cloudwatchomni-2025-01-01.normal.json service model.
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
namespace Amazon.CloudWatchOmni.Model
{
    /// <summary>
    /// Container for the parameters to the StartTelemetryQuerySession operation.
    /// Starts a new telemetry query session.
    /// 
    ///  
    /// <para>
    /// A session provides a logical grouping for one or more telemetry queries. The returned
    /// session ID is required when starting queries via StartTelemetryQuery.
    /// </para>
    /// </summary>
    public partial class StartTelemetryQuerySessionRequest : AmazonCloudWatchOmniRequest
    {
        private string _sessionName;

        /// <summary>
        /// Gets and sets the property SessionName. 
        /// <para>
        /// A human-readable name for the session. Names under <c>/aws/</c> are reserved for service
        /// integrations.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string SessionName
        {
            get { return this._sessionName; }
            set { this._sessionName = value; }
        }

        // Check to see if SessionName property is set
        internal bool IsSetSessionName()
        {
            return this._sessionName != null;
        }

    }
}