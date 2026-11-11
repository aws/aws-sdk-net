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

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// This processor converts logs into <a href="https://ocsf.io">Open Cybersecurity Schema
    /// Framework (OCSF)</a> events.
    /// 
    ///  
    /// <para>
    /// For more information about this processor including examples, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch-Logs-Transformation.html#CloudWatch-Logs-Transformation-parseToOCSF">parseToOCSF</a>
    /// in the <i>CloudWatch Logs User Guide</i>.
    /// </para>
    /// </summary>
    public partial class ParseToOCSF
    {
        /// <summary>
        /// Gets and sets the property EventSource. 
        /// <para>
        /// Specify the service or process that produces the log events that will be converted
        /// with this processor.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EventSource EventSource { get; set; }

        /// <summary>
        /// Checks to see if the EventSource property is set.
        /// </summary>
        internal bool IsSetEventSource() => this.EventSource != null;

        /// <summary>
        /// Gets and sets the property MappingVersion. 
        /// <para>
        /// The version of the OCSF mapping to use for parsing log data.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public string MappingVersion { get; set; }

        /// <summary>
        /// Checks to see if the MappingVersion property is set.
        /// </summary>
        internal bool IsSetMappingVersion() => this.MappingVersion != null;

        /// <summary>
        /// Gets and sets the property OcsfVersion. 
        /// <para>
        /// Specify which version of the OCSF schema to use for the transformed log events.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OCSFVersion OcsfVersion { get; set; }

        /// <summary>
        /// Checks to see if the OcsfVersion property is set.
        /// </summary>
        internal bool IsSetOcsfVersion() => this.OcsfVersion != null;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The path to the field in the log event that you want to parse. If you omit this value,
        /// the whole log message is parsed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;
    }
}
