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
 * Do not modify this file. This file is generated from the eventbridge-2015-10-07.normal.json service model.
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
namespace Amazon.EventBridge.Model
{
    /// <summary>
    /// The primary Region of the endpoint.
    /// </summary>
    public partial class Primary
    {
        private string _healthCheck;

        /// <summary>
        /// Gets and sets the property HealthCheck. 
        /// <para>
        /// The ARN of the health check used by the endpoint to determine whether failover is
        /// triggered.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1600)]
        public string HealthCheck
        {
            get { return this._healthCheck; }
            set { this._healthCheck = value; }
        }

        // Check to see if HealthCheck property is set
        internal bool IsSetHealthCheck()
        {
            return this._healthCheck != null;
        }

    }
}