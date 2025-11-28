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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
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
namespace Amazon.ECS.Model
{
    /// <summary>
    /// Specifies the Amazon CloudWatch Logs configuration for the Express service container.
    /// </summary>
    public partial class ExpressGatewayServiceAwsLogsConfiguration
    {
        private string _logGroup;
        private string _logStreamPrefix;

        /// <summary>
        /// Gets and sets the property LogGroup. 
        /// <para>
        /// The name of the CloudWatch Logs log group to send container logs to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LogGroup
        {
            get { return this._logGroup; }
            set { this._logGroup = value; }
        }

        // Check to see if LogGroup property is set
        internal bool IsSetLogGroup()
        {
            return this._logGroup != null;
        }

        /// <summary>
        /// Gets and sets the property LogStreamPrefix. 
        /// <para>
        /// The prefix for the CloudWatch Logs log stream names. The default for an Express service
        /// is <c>ecs</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LogStreamPrefix
        {
            get { return this._logStreamPrefix; }
            set { this._logStreamPrefix = value; }
        }

        // Check to see if LogStreamPrefix property is set
        internal bool IsSetLogStreamPrefix()
        {
            return this._logStreamPrefix != null;
        }

    }
}