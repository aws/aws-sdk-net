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
 * Do not modify this file. This file is generated from the kinesisanalytics-2015-08-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisAnalytics.Model
{
    /// <summary>
    /// When updating application input configuration, provides information about an Amazon
    /// Kinesis stream as the streaming source.
    /// </summary>
    public partial class KinesisStreamsInputUpdate
    {
        private string _resourceARNUpdate;
        private string _roleARNUpdate;

        /// <summary>
        /// Gets and sets the property ResourceARNUpdate. 
        /// <para>
        /// Amazon Resource Name (ARN) of the input Amazon Kinesis stream to read.
        /// </para>
        /// </summary>
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