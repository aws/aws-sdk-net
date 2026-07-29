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
 * Do not modify this file. This file is generated from the lambda-core-2026-04-30.normal.json service model.
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
namespace Amazon.LambdaCore.Model
{
    /// <summary>
    /// Container for the parameters to the GetNetworkConnector operation.
    /// Retrieves the current configuration, state, and metadata of a network connector. The
    /// <c>Identifier</c> parameter accepts the connector ID, name, or full ARN. Use this
    /// operation to poll connector state after creation or update, or to inspect the current
    /// VPC configuration and any failure reasons.
    /// 
    ///  
    /// <para>
    /// The response includes the full connector configuration, current state, and — if the
    /// connector has been updated — the <c>LastUpdateStatus</c> and <c>LastUpdateStatusReasonCode</c>
    /// fields that indicate whether the most recent update succeeded or failed.
    /// </para>
    /// </summary>
    public partial class GetNetworkConnectorRequest : AmazonLambdaCoreRequest
    {
        private string _identifier;

        /// <summary>
        /// Gets and sets the property Identifier.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=140)]
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

    }
}