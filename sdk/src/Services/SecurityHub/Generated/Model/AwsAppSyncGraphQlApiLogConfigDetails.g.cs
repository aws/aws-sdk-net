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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Specifies the logging configuration when writing GraphQL operations and tracing to
    /// Amazon CloudWatch for an AppSync GraphQL API.
    /// </summary>
    public partial class AwsAppSyncGraphQlApiLogConfigDetails
    {
        /// <summary>
        /// Gets and sets the property CloudWatchLogsRoleArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the service role that AppSync assumes to publish
        /// to CloudWatch Logs in your account. 
        /// </para>
        /// </summary>
        public string CloudWatchLogsRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the CloudWatchLogsRoleArn property is set.
        /// </summary>
        internal bool IsSetCloudWatchLogsRoleArn() => this.CloudWatchLogsRoleArn != null;

        /// <summary>
        /// Gets and sets the property ExcludeVerboseContent. 
        /// <para>
        ///  Set to <c>TRUE</c> to exclude sections that contain information such as headers,
        /// context, and evaluated mapping templates, regardless of logging level. 
        /// </para>
        /// </summary>
        public bool? ExcludeVerboseContent { get; set; }

        /// <summary>
        /// Checks to see if the ExcludeVerboseContent property is set.
        /// </summary>
        internal bool IsSetExcludeVerboseContent() => this.ExcludeVerboseContent.HasValue;

        /// <summary>
        /// Gets and sets the property FieldLogLevel. 
        /// <para>
        ///  The field logging level. 
        /// </para>
        /// </summary>
        public string FieldLogLevel { get; set; }

        /// <summary>
        /// Checks to see if the FieldLogLevel property is set.
        /// </summary>
        internal bool IsSetFieldLogLevel() => this.FieldLogLevel != null;
    }
}
