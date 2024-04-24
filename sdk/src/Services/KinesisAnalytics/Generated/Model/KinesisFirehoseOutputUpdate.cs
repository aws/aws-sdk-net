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
 * Do not modify this file. This file is generated from the kinesisanalytics-2015-08-14.normal.json service model.
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
namespace Amazon.KinesisAnalytics.Model
{
    /// <summary>
    /// When updating an output configuration using the <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/dev/API_UpdateApplication.html">UpdateApplication</a>
    /// operation, provides information about an Amazon Kinesis Firehose delivery stream configured
    /// as the destination.
    /// </summary>
    public partial class KinesisFirehoseOutputUpdate
    {
        private string _resourceARNUpdate;
        private string _roleARNUpdate;

        /// <summary>
        /// Gets and sets the property ResourceARNUpdate. 
        /// <para>
        /// Amazon Resource Name (ARN) of the Amazon Kinesis Firehose delivery stream to write
        /// to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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

        /// <summary>
        /// Gets and sets the property RoleARNUpdate. 
        /// <para>
        /// ARN of the IAM role that Amazon Kinesis Analytics can assume to access the stream
        /// on your behalf. You need to grant the necessary permissions to this role.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string RoleARNUpdate
        {
            get { return this._roleARNUpdate; }
            set { this._roleARNUpdate = value; }
        }

        // Check to see if RoleARNUpdate property is set
        internal bool IsSetRoleARNUpdate()
        {
            return this._roleARNUpdate != null;
        }

    }
}