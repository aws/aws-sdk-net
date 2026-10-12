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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the DeleteNetworkConnector operation. Initiates deletion
    /// of a network connector. The connector transitions to <c>DELETING</c> state while elastic
    /// network interfaces are cleaned up asynchronously. After deletion completes, subsequent
    /// calls to <c>GetNetworkConnector</c> return <c>ResourceNotFoundException</c>. <para>
    /// This operation is idempotent — calling delete on a connector that is already deleting
    /// or has been deleted succeeds without error. You can delete connectors in <c>ACTIVE</c>
    /// or <c>FAILED</c> states. Before deleting a connector, ensure that no Lambda compute
    /// resources are using it, as they will lose VPC egress connectivity immediately. </para>
    /// <para> Deleting with an unqualified identifier removes the connector and all of its
    /// versions. To remove a single historical version, supply its version-qualified ARN;
    /// the connector and its remaining versions are unaffected. You can't delete the latest
    /// version on its own — delete the connector to remove it. </para>
    /// </summary>
    public partial class DeleteNetworkConnectorRequest : AmazonLambdaCoreRequest
    {
        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The identifier of the network connector to delete. Provide an unqualified ARN (or
        /// an ID or name) to delete the entire connector and all of its versions, or a version-qualified
        /// ARN — one that includes the immutable version suffix — to delete a specific historical
        /// version. You can't delete the latest version with a version-qualified identifier;
        /// delete the connector instead.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 140)]
        public string Identifier { get; set; }

        /// <summary>
        /// Checks to see if the Identifier property is set.
        /// </summary>
        internal bool IsSetIdentifier() => this.Identifier != null;
    }
}
