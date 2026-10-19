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
    /// Contains a configuration setting for the Service Connect proxy container, such as
    /// the log level. Specify exactly one member in each object.
    /// </summary>
    public partial class ServiceConnectContainerConfiguration
    {
        private ServiceConnectContainerLogLevel _logLevel;

        /// <summary>
        /// Gets and sets the property LogLevel. 
        /// <para>
        /// The log level of the Service Connect proxy container. Set the log level to <c>debug</c>
        /// to collect more detailed proxy logs when you troubleshoot connectivity issues between
        /// services, and set it back to <c>info</c> when you finish. Debug logging increases
        /// the volume of logs that the proxy container writes. If you don't specify a log level,
        /// the default is <c>info</c>.
        /// </para>
        /// </summary>
        public ServiceConnectContainerLogLevel LogLevel
        {
            get { return this._logLevel; }
            set { this._logLevel = value; }
        }

        // Check to see if LogLevel property is set
        internal bool IsSetLogLevel()
        {
            return this._logLevel != null;
        }

    }
}