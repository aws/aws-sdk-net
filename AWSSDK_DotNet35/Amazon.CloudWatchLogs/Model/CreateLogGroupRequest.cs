/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Container for the parameters to the CreateLogGroup operation.
    /// Creates a new log group with the specified name. The name of the log group must be
    /// unique within a region for an AWS account. You can create up to 500 log groups per
    /// account. 
    /// 
    ///  
    /// <para>
    ///  You must use the following guidelines when naming a log group: <ul> <li>Log group
    /// names can be between 1 and 512 characters long.</li> <li>Allowed characters are a-z,
    /// A-Z, 0-9, '_' (underscore), '-' (hyphen), '/' (forward slash), and '.' (period).</li>
    /// </ul> 
    /// </para>
    /// </summary>
    public partial class CreateLogGroupRequest : AmazonCloudWatchLogsRequest
    {
        private string _logGroupName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateLogGroupRequest() { }

        /// <summary>
        /// Instantiates CreateLogGroupRequest with the parameterized properties
        /// </summary>
        /// <param name="logGroupName">Sets the CreateLogGroupRequest LogGroupName property</param>
        public CreateLogGroupRequest(string logGroupName)
        {
            _logGroupName = logGroupName;
        }

        /// <summary>
        /// Gets and sets the property LogGroupName.
        /// </summary>
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

    }
}