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
    /// For a SQL-based Kinesis Data Analytics application, represents an update to the <a>InputLambdaProcessor</a>
    /// that is used to preprocess the records in the stream.
    /// </summary>
    public partial class InputLambdaProcessorUpdate
    {
        private string _resourceARNUpdate;

        /// <summary>
        /// Gets and sets the property ResourceARNUpdate. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the new Amazon Lambda function that is used to preprocess
        /// the records in the stream.
        /// </para>
        ///  <note> 
        /// <para>
        /// To specify an earlier version of the Lambda function than the latest, include the
        /// Lambda function version in the Lambda function ARN. For more information about Lambda
        /// ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html#arn-syntax-lambda">Example
        /// ARNs: Amazon Lambda</a> 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string ResourceARNUpdate
        {
            get { return this._resourceARNUpdate; }
            set { this._resourceARNUpdate = value; }
        }

        // Check to see if ResourceARNUpdate property is set
        internal bool IsSetResourceARNUpdate()
        {
            return this._resourceARNUpdate != null;
        }

    }
}