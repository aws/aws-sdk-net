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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Contains logging configuration information for a type.
    /// </summary>
    public partial class LoggingConfig
    {
        private string _logGroupName;
        private string _logRoleArn;

        /// <summary>
        /// Gets and sets the property LogGroupName. 
        /// <para>
        /// The Amazon CloudWatch log group to which CloudFormation sends error logging information
        /// when invoking the type's handlers.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string LogGroupName
        {
            get { return this._logGroupName; }
            set { this._logGroupName = value; }
        }

        // Check to see if LogGroupName property is set
        internal bool IsSetLogGroupName()
        {
            return this._logGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property LogRoleArn. 
        /// <para>
        /// The ARN of the role that CloudFormation should assume when sending log entries to
        /// CloudWatch logs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string LogRoleArn
        {
            get { return this._logRoleArn; }
            set { this._logRoleArn = value; }
        }

        // Check to see if LogRoleArn property is set
        internal bool IsSetLogRoleArn()
        {
            return this._logRoleArn != null;
        }

    }
}