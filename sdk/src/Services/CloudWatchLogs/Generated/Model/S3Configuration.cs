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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
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
    /// Configuration details for delivering scheduled query results to an Amazon S3 bucket.
    /// </summary>
    public partial class S3Configuration
    {
        private string _destinationIdentifier;
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property DestinationIdentifier. 
        /// <para>
        /// The S3 URI where query results will be stored (e.g., s3://bucket-name/prefix/).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=1024)]
        public string DestinationIdentifier
        {
            get { return this._destinationIdentifier; }
            set { this._destinationIdentifier = value; }
        }

        // Check to see if DestinationIdentifier property is set
        internal bool IsSetDestinationIdentifier()
        {
            return this._destinationIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the IAM role that CloudWatch Logs will assume to write results to the S3
        /// bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

    }
}