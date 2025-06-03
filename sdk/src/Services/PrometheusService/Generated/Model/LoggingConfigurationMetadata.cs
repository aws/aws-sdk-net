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
    /// Contains information about the current rules and alerting logging configuration for
    /// the workspace.
    /// 
    ///  <note> 
    /// <para>
    /// These logging configurations are only for rules and alerting logs.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class LoggingConfigurationMetadata
    {
        private DateTime? _createdAt;
        private string _logGroupArn;
        private DateTime? _modifiedAt;
        private LoggingConfigurationStatus _status;
        private string _workspace;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time that the logging configuration was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
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
        /// Gets and sets the property ModifiedAt. 
        /// <para>
        /// The date and time that the logging configuration was most recently changed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? ModifiedAt
        {
            get { return this._modifiedAt; }
            set { this._modifiedAt = value; }
        }

        // Check to see if ModifiedAt property is set
        internal bool IsSetModifiedAt()
        {
            return this._modifiedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the logging configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LoggingConfigurationStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Workspace. 
        /// <para>
        /// The ID of the workspace the logging configuration is for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Workspace
        {
            get { return this._workspace; }
            set { this._workspace = value; }
        }

        // Check to see if Workspace property is set
        internal bool IsSetWorkspace()
        {
            return this._workspace != null;
        }

    }
}