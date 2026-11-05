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
    /// Container for the parameters to the SetV2LoggingOptions operation. Sets the logging
    /// options for the V2 logging service. <para> Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">SetV2LoggingOptions</a>
    /// action. </para>
    /// </summary>
    public partial class SetV2LoggingOptionsRequest : AmazonIoTRequest
    {
        /// <summary>
        /// Gets and sets the property DefaultLogLevel. 
        /// <para>
        /// The default logging level.
        /// </para>
        /// </summary>
        public LogLevel DefaultLogLevel { get; set; }

        /// <summary>
        /// Checks to see if the DefaultLogLevel property is set.
        /// </summary>
        internal bool IsSetDefaultLogLevel() => this.DefaultLogLevel != null;

        /// <summary>
        /// Gets and sets the property DisableAllLogs. 
        /// <para>
        /// If true all logs are disabled. The default is false.
        /// </para>
        /// </summary>
        public bool? DisableAllLogs { get; set; }

        /// <summary>
        /// Checks to see if the DisableAllLogs property is set.
        /// </summary>
        internal bool IsSetDisableAllLogs() => this.DisableAllLogs.HasValue;

        /// <summary>
        /// Gets and sets the property EventConfigurations. 
        /// <para>
        ///  The list of event configurations that override account-level logging. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LogEventConfiguration> EventConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<LogEventConfiguration>() : null;

        /// <summary>
        /// Checks to see if the EventConfigurations property is set.
        /// </summary>
        internal bool IsSetEventConfigurations() => this.EventConfigurations != null && (this.EventConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the role that allows IoT to write to Cloudwatch logs.
        /// </para>
        /// </summary>
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;
    }
}
