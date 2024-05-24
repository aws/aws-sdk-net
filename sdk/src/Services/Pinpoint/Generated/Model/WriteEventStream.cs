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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
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
namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Specifies the Amazon Resource Name (ARN) of an event stream to publish events to and
    /// the AWS Identity and Access Management (IAM) role to use when publishing those events.
    /// </summary>
    public partial class WriteEventStream
    {
        private string _destinationStreamArn;
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property DestinationStreamArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Kinesis data stream or Amazon Kinesis
        /// Data Firehose delivery stream that you want to publish event data to.
        /// </para>
        ///  
        /// <para>
        /// For a Kinesis data stream, the ARN format is: arn:aws:kinesis:<replaceable>region</replaceable>:<replaceable>account-id</replaceable>:stream/<replaceable>stream_name</replaceable>
        ///               
        /// </para>
        ///  
        /// <para>
        /// For a Kinesis Data Firehose delivery stream, the ARN format is: arn:aws:firehose:<replaceable>region</replaceable>:<replaceable>account-id</replaceable>:deliverystream/<replaceable>stream_name</replaceable>
        ///               
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DestinationStreamArn
        {
            get { return this._destinationStreamArn; }
            set { this._destinationStreamArn = value; }
        }

        // Check to see if DestinationStreamArn property is set
        internal bool IsSetDestinationStreamArn()
        {
            return this._destinationStreamArn != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The AWS Identity and Access Management (IAM) role that authorizes Amazon Pinpoint
        /// to publish event data to the stream in your AWS account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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