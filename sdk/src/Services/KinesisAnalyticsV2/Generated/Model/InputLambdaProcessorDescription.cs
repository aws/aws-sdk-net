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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// For an SQL-based Amazon Kinesis Data Analytics application, an object that contains
    /// the Amazon Resource Name (ARN) of the AWS Lambda function that is used to preprocess
    /// records in the stream.
    /// </summary>
    public partial class InputLambdaProcessorDescription
    {
        private string _resourceARN;
        private string _roleARN;

        /// <summary>
        /// Gets and sets the property ResourceARN. 
        /// <para>
        /// The ARN of the AWS Lambda function that is used to preprocess the records in the stream.
        /// </para>
        /// </summary>
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
        /// The ARN of the IAM role that is used to access the AWS Lambda function.
        /// </para>
        ///  <note> 
        /// <para>
        /// Provided for backward compatibility. Applications that are created with the current
        /// API version have an application-level service execution role rather than a resource-level
        /// role.
        /// </para>
        ///  </note>
        /// </summary>
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