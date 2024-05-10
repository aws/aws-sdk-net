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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
        private string _cloudWatchLogsRoleArn;
        private bool? _excludeVerboseContent;
        private string _fieldLogLevel;

        /// <summary>
        /// Gets and sets the property CloudWatchLogsRoleArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the service role that AppSync assumes to publish
        /// to CloudWatch Logs in your account. 
        /// </para>
        /// </summary>
        public string CloudWatchLogsRoleArn
        {
            get { return this._cloudWatchLogsRoleArn; }
            set { this._cloudWatchLogsRoleArn = value; }
        }

        // Check to see if CloudWatchLogsRoleArn property is set
        internal bool IsSetCloudWatchLogsRoleArn()
        {
            return this._cloudWatchLogsRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property ExcludeVerboseContent. 
        /// <para>
        ///  Set to <c>TRUE</c> to exclude sections that contain information such as headers,
        /// context, and evaluated mapping templates, regardless of logging level. 
        /// </para>
        /// </summary>
        public bool? ExcludeVerboseContent
        {
            get { return this._excludeVerboseContent; }
            set { this._excludeVerboseContent = value; }
        }

        // Check to see if ExcludeVerboseContent property is set
        internal bool IsSetExcludeVerboseContent()
        {
            return this._excludeVerboseContent.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FieldLogLevel. 
        /// <para>
        ///  The field logging level. 
        /// </para>
        /// </summary>
        public string FieldLogLevel
        {
            get { return this._fieldLogLevel; }
            set { this._fieldLogLevel = value; }
        }

        // Check to see if FieldLogLevel property is set
        internal bool IsSetFieldLogLevel()
        {
            return this._fieldLogLevel != null;
        }

    }
}