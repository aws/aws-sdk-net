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
    /// Container for the parameters to the DeleteNetworkConnector operation.
    /// Initiates deletion of a network connector. The connector transitions to <c>DELETING</c>
    /// state while elastic network interfaces are cleaned up asynchronously. After deletion
    /// completes, subsequent calls to <c>GetNetworkConnector</c> return <c>ResourceNotFoundException</c>.
    /// 
    ///  
    /// <para>
    /// This operation is idempotent — calling delete on a connector that is already deleting
    /// or has been deleted succeeds without error. You can delete connectors in <c>ACTIVE</c>
    /// or <c>FAILED</c> states. Before deleting a connector, ensure that no Lambda MicroVMs
    /// are using it, as they will lose VPC egress connectivity immediately.
    /// </para>
    /// </summary>
    public partial class DeleteNetworkConnectorRequest : AmazonLambdaCoreRequest
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