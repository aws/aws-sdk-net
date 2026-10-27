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

namespace Amazon.ECS.Model
{
    /// <summary>
    /// Configuration for Service Connect access logging. Access logs provide detailed information
    /// about requests made to your service, including request patterns, response codes, and
    /// timing data for debugging and monitoring purposes.
    /// 
    ///  <note> 
    /// <para>
    /// To enable access logs, you must also specify a <c>logConfiguration</c> in the <c>serviceConnectConfiguration</c>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ServiceConnectAccessLogConfiguration
    {
        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// The format for Service Connect access log output. Choose TEXT for human-readable logs
        /// or JSON for structured data that integrates well with log analysis tools.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ServiceConnectAccessLoggingFormat Format { get; set; }

        /// <summary>
        /// Checks to see if the Format property is set.
        /// </summary>
        internal bool IsSetFormat() => this.Format != null;

        /// <summary>
        /// Gets and sets the property IncludeQueryParameters. 
        /// <para>
        /// Specifies whether to include query parameters in Service Connect access logs.
        /// </para>
        ///  
        /// <para>
        /// When enabled, query parameters from HTTP requests are included in the access logs.
        /// Consider security and privacy implications when enabling this feature, as query parameters
        /// may contain sensitive information such as request IDs and tokens. By default, this
        /// parameter is <c>DISABLED</c>.
        /// </para>
        /// </summary>
        public ServiceConnectIncludeQueryParameters IncludeQueryParameters { get; set; }

        /// <summary>
        /// Checks to see if the IncludeQueryParameters property is set.
        /// </summary>
        internal bool IsSetIncludeQueryParameters() => this.IncludeQueryParameters != null;
    }
}
