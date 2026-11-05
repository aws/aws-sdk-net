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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Parameters used when defining a mitigation action that enable Amazon Web Services
    /// IoT Core logging.
    /// </summary>
    public partial class EnableIoTLoggingParams
    {
        /// <summary>
        /// Gets and sets the property LogLevel. 
        /// <para>
        /// Specifies the type of information to be logged.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public LogLevel LogLevel { get; set; }

        /// <summary>
        /// Checks to see if the LogLevel property is set.
        /// </summary>
        internal bool IsSetLogLevel() => this.LogLevel != null;

        /// <summary>
        /// Gets and sets the property RoleArnForLogging. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role used for logging.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string RoleArnForLogging { get; set; }

        /// <summary>
        /// Checks to see if the RoleArnForLogging property is set.
        /// </summary>
        internal bool IsSetRoleArnForLogging() => this.RoleArnForLogging != null;
    }
}
