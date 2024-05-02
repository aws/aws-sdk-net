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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
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
namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// For a SQL-based Kinesis Data Analytics application's output, describes the Amazon
    /// Lambda function that is configured as its destination.
    /// </summary>
    public partial class LambdaOutputDescription
    {
        private string _resourceARN;
        private string _roleARN;

        /// <summary>
        /// Gets and sets the property ResourceARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the destination Lambda function.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string ResourceARN
        {
            get { return this._resourceARN; }
            set { this._resourceARN = value; }
        }

        // Check to see if ResourceARN property is set
        internal bool IsSetResourceARN()
        {
            return this._resourceARN != null;
        }

        /// <summary>
        /// Gets and sets the property RoleARN. 
        /// <para>
        /// The ARN of the IAM role that Kinesis Data Analytics can assume to write to the destination
        /// function.
        /// </para>
        ///  <note> 
        /// <para>
        /// Provided for backward compatibility. Applications that are created with the current
        /// API version have an application-level service execution role rather than a resource-level
        /// role.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string RoleARN
        {
            get { return this._roleARN; }
            set { this._roleARN = value; }
        }

        // Check to see if RoleARN property is set
        internal bool IsSetRoleARN()
        {
            return this._roleARN != null;
        }

    }
}