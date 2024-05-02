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
 * Do not modify this file. This file is generated from the chime-sdk-identity-2021-04-20.normal.json service model.
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
namespace Amazon.ChimeSDKIdentity.Model
{
    /// <summary>
    /// This is the response object from the DescribeAppInstanceUserEndpoint operation.
    /// </summary>
    public partial class DescribeAppInstanceUserEndpointResponse : AmazonWebServiceResponse
    {
        private AppInstanceUserEndpoint _appInstanceUserEndpoint;

        /// <summary>
        /// Gets and sets the property AppInstanceUserEndpoint. 
        /// <para>
        /// The full details of an <c>AppInstanceUserEndpoint</c>: the <c>AppInstanceUserArn</c>,
        /// ID, name, type, resource ARN, attributes, allow messages, state, and created and last
        /// updated timestamps. All timestamps use epoch milliseconds.
        /// </para>
        /// </summary>
        public AppInstanceUserEndpoint AppInstanceUserEndpoint
        {
            get { return this._appInstanceUserEndpoint; }
            set { this._appInstanceUserEndpoint = value; }
        }

        // Check to see if AppInstanceUserEndpoint property is set
        internal bool IsSetAppInstanceUserEndpoint()
        {
            return this._appInstanceUserEndpoint != null;
        }

    }
}