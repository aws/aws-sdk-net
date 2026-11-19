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

namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// Container for the parameters to the DisassociateContextStore operation. Disassociates
    /// a transit gateway from a context store. The association must be in the <c>ASSOCIATED</c>
    /// or <c>FAILED</c> state. The association stays in the <c>DISASSOCIATING</c> state until
    /// the disassociation completes.
    /// </summary>
    public partial class DisassociateContextStoreRequest : AmazonNetworkManagerRequest
    {
        /// <summary>
        /// Gets and sets the property ContextStoreId. 
        /// <para>
        /// The ID of the context store.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 50)]
        public string ContextStoreId { get; set; }

        /// <summary>
        /// Checks to see if the ContextStoreId property is set.
        /// </summary>
        internal bool IsSetContextStoreId() => this.ContextStoreId != null;

        /// <summary>
        /// Gets and sets the property TransitGatewayArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the transit gateway to disassociate from the context
        /// store.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 500)]
        public string TransitGatewayArn { get; set; }

        /// <summary>
        /// Checks to see if the TransitGatewayArn property is set.
        /// </summary>
        internal bool IsSetTransitGatewayArn() => this.TransitGatewayArn != null;
    }
}
