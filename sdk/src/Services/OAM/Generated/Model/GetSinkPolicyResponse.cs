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
 * Do not modify this file. This file is generated from the oam-2022-06-10.normal.json service model.
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
namespace Amazon.OAM.Model
{
    /// <summary>
    /// This is the response object from the GetSinkPolicy operation.
    /// </summary>
    public partial class GetSinkPolicyResponse : AmazonWebServiceResponse
    {
        private string _policy;
        private string _sinkArn;
        private string _sinkId;

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// The policy that you specified, in JSON format.
        /// </para>
        /// </summary>
        public string Policy
        {
            get { return this._policy; }
            set { this._policy = value; }
        }

        // Check to see if Policy property is set
        internal bool IsSetPolicy()
        {
            return this._policy != null;
        }

        /// <summary>
        /// Gets and sets the property SinkArn. 
        /// <para>
        /// The ARN of the sink.
        /// </para>
        /// </summary>
        public string SinkArn
        {
            get { return this._sinkArn; }
            set { this._sinkArn = value; }
        }

        // Check to see if SinkArn property is set
        internal bool IsSetSinkArn()
        {
            return this._sinkArn != null;
        }

        /// <summary>
        /// Gets and sets the property SinkId. 
        /// <para>
        /// The random ID string that Amazon Web Services generated as part of the sink ARN.
        /// </para>
        /// </summary>
        public string SinkId
        {
            get { return this._sinkId; }
            set { this._sinkId = value; }
        }

        // Check to see if SinkId property is set
        internal bool IsSetSinkId()
        {
            return this._sinkId != null;
        }

    }
}