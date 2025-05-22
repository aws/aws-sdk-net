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
 * Do not modify this file. This file is generated from the amp-2020-08-01.normal.json service model.
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
namespace Amazon.PrometheusService.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateLoggingConfiguration operation.
    /// Updates the log group ARN or the workspace ID of the current rules and alerting logging
    /// configuration.
    /// 
    ///  <note> 
    /// <para>
    /// These logging configurations are only for rules and alerting logs.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class UpdateLoggingConfigurationRequest : AmazonPrometheusServiceRequest
    {
        private string _clientToken;
        private string _logGroupArn;
        private string _workspaceId;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique identifier that you can provide to ensure the idempotency of the request.
        /// Case-sensitive.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property LogGroupArn. 
        /// <para>
        /// The ARN of the CloudWatch log group to which the vended log data will be published.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LogGroupArn
        {
            get { return this._logGroupArn; }
            set { this._logGroupArn = value; }
        }

        // Check to see if LogGroupArn property is set
        internal bool IsSetLogGroupArn()
        {
            return this._logGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property WorkspaceId. 
        /// <para>
        /// The ID of the workspace to update the logging configuration for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string WorkspaceId
        {
            get { return this._workspaceId; }
            set { this._workspaceId = value; }
        }

        // Check to see if WorkspaceId property is set
        internal bool IsSetWorkspaceId()
        {
            return this._workspaceId != null;
        }

    }
}