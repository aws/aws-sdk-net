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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
    /// This is the response object from the CreateCommand operation.
    /// </summary>
    public partial class CreateCommandResponse : AmazonWebServiceResponse
    {
        private string _commandArn;
        private string _commandId;

        /// <summary>
        /// Gets and sets the property CommandArn. 
        /// <para>
        /// The Amazon Resource Number (ARN) of the command. For example, <c>arn:aws:iot:&lt;region&gt;:&lt;accountid&gt;:command/&lt;commandId&gt;</c>
        /// 
        /// </para>
        /// </summary>
        public string CommandArn
        {
            get { return this._commandArn; }
            set { this._commandArn = value; }
        }

        // Check to see if CommandArn property is set
        internal bool IsSetCommandArn()
        {
            return this._commandArn != null;
        }

        /// <summary>
        /// Gets and sets the property CommandId. 
        /// <para>
        /// The unique identifier for the command.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string CommandId
        {
            get { return this._commandId; }
            set { this._commandId = value; }
        }

        // Check to see if CommandId property is set
        internal bool IsSetCommandId()
        {
            return this._commandId != null;
        }

    }
}