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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Configuration information of a Kinesis Data Firehose delivery stream.
    /// </summary>
    public partial class KinesisFirehoseConfig
    {
        private string _firehoseArn;

        /// <summary>
        /// Gets and sets the property FirehoseArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the delivery stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FirehoseArn
        {
            get { return this._firehoseArn; }
            set { this._firehoseArn = value; }
        }

        // Check to see if FirehoseArn property is set
        internal bool IsSetFirehoseArn()
        {
            return this._firehoseArn != null;
        }

    }
}