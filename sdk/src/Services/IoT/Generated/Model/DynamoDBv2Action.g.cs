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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Describes an action to write to a DynamoDB table.
    /// 
    ///  
    /// <para>
    /// This DynamoDB action writes each attribute in the message payload into it's own column
    /// in the DynamoDB table.
    /// </para>
    /// </summary>
    public partial class DynamoDBv2Action
    {
        /// <summary>
        /// Gets and sets the property PutItem. 
        /// <para>
        /// Specifies the DynamoDB table to which the message data will be written. For example:
        /// </para>
        ///  
        /// <para>
        ///  <c>{ "dynamoDBv2": { "roleArn": "aws:iam:12341251:my-role" "putItem": { "tableName":
        /// "my-table" } } }</c> 
        /// </para>
        ///  
        /// <para>
        /// Each attribute in the message payload will be written to a separate column in the
        /// DynamoDB database.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PutItemInput PutItem { get; set; }

        /// <summary>
        /// Checks to see if the PutItem property is set.
        /// </summary>
        internal bool IsSetPutItem() => this.PutItem != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the IAM role that grants access to the DynamoDB table.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;
    }
}
