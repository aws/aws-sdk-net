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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteGlobalInferenceGateway operation. Delete
    /// a global inference gateway and its member inference gateways, which are then free
    /// to join another global inference gateway. Asynchronous: the global inference gateway
    /// is DELETING while its managed endpoint resources are torn down; poll DescribeGlobalInferenceGateway
    /// until it returns ResourceNotFound. Does not touch the customer's clusters. Idempotent:
    /// a Delete whose Identifier matches no global inference gateway succeeds and echoes
    /// what the Identifier says (Arn and Id for an ARN or Id, Name for a name).
    /// </summary>
    public partial class DeleteGlobalInferenceGatewayRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The name, Amazon Resource Name (ARN), or ID of the global inference gateway to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string Identifier { get; set; }

        /// <summary>
        /// Checks to see if the Identifier property is set.
        /// </summary>
        internal bool IsSetIdentifier() => this.Identifier != null;
    }
}
