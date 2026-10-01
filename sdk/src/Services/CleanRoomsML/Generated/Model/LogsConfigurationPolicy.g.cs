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

namespace Amazon.CleanRoomsML.Model
{
    /// <summary>
    /// Provides the information necessary for a user to access the logs.
    /// </summary>
    public partial class LogsConfigurationPolicy
    {
        /// <summary>
        /// Gets and sets the property AllowedAccountIds. 
        /// <para>
        /// A list of account IDs that are allowed to access the logs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 5)]
        public List<string> AllowedAccountIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AllowedAccountIds property is set.
        /// </summary>
        internal bool IsSetAllowedAccountIds() => this.AllowedAccountIds != null && (this.AllowedAccountIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FilterPattern. 
        /// <para>
        /// A regular expression pattern that is used to parse the logs and return information
        /// that matches the pattern.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string FilterPattern { get; set; }

        /// <summary>
        /// Checks to see if the FilterPattern property is set.
        /// </summary>
        internal bool IsSetFilterPattern() => this.FilterPattern != null;

        /// <summary>
        /// Gets and sets the property LogRedactionConfiguration. 
        /// <para>
        /// Specifies the log redaction configuration for this policy.
        /// </para>
        /// </summary>
        public LogRedactionConfiguration LogRedactionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LogRedactionConfiguration property is set.
        /// </summary>
        internal bool IsSetLogRedactionConfiguration() => this.LogRedactionConfiguration != null;

        /// <summary>
        /// Gets and sets the property LogType. 
        /// <para>
        /// Specifies the type of log this policy applies to. The currently supported policies
        /// are ALL or ERROR_SUMMARY.
        /// </para>
        /// </summary>
        public LogType LogType { get; set; }

        /// <summary>
        /// Checks to see if the LogType property is set.
        /// </summary>
        internal bool IsSetLogType() => this.LogType != null;
    }
}
