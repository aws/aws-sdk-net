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
 * Do not modify this file. This file is generated from the bedrock-agent-runtime-2023-07-26.normal.json service model.
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
namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// Contains details about the OpenAPI schema for the action group. For more information,
    /// see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/agents-api-schema.html">Action
    /// group OpenAPI schemas</a>. You can either include the schema directly in the payload
    /// field or you can upload it to an S3 bucket and specify the S3 bucket location in the
    /// s3 field.
    /// </summary>
    public partial class APISchema
    {
        private string _payload;
        private S3Identifier _s3;

        /// <summary>
        /// Gets and sets the property Payload. 
        /// <para>
        ///  The JSON or YAML-formatted payload defining the OpenAPI schema for the action group.
        /// 
        /// </para>
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
        /// <para>
        ///  Contains details about the S3 object containing the OpenAPI schema for the action
        /// group. 
        /// </para>
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