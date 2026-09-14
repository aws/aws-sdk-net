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

namespace Amazon.DSQL.Model
{
    /// <summary>
    /// Kinesis stream target configuration.
    /// </summary>
    public partial class KinesisTargetDefinition
    {
        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the IAM role that grants permission to write to the Kinesis stream. This
        /// can be a standard role (<c>arn:aws:iam::account-id:role/role-name</c>) or a role with
        /// a path prefix (<c>arn:aws:iam::account-id:role/service-role/role-name</c>), such as
        /// roles auto-created by the console.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property StreamArn. 
        /// <para>
        /// The ARN of the Kinesis stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string StreamArn { get; set; }

        /// <summary>
        /// Checks to see if the StreamArn property is set.
        /// </summary>
        internal bool IsSetStreamArn() => this.StreamArn != null;
    }
}
