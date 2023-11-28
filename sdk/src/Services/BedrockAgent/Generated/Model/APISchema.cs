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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Contains information about the API Schema for the Action Group
    /// </summary>
    public partial class APISchema
    {
        private string _payload;
        private S3Identifier _s3;

        /// <summary>
        /// Gets and sets the property Payload.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string Payload
        {
            get { return this._payload; }
            set { this._payload = value; }
        }

        // Check to see if Payload property is set
        internal bool IsSetPayload()
        {
            return this._payload != null;
        }

        /// <summary>
        /// Gets and sets the property S3.
        /// </summary>
        public S3Identifier S3
        {
            get { return this._s3; }
            set { this._s3 = value; }
        }

        // Check to see if S3 property is set
        internal bool IsSetS3()
        {
            return this._s3 != null;
        }

    }
}