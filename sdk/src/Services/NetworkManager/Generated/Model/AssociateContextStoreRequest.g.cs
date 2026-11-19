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
    /// Container for the parameters to the AssociateContextStore operation. Associates a
    /// transit gateway with a context store. The transit gateway must be registered with
    /// the global network of the context store, and can't be associated with more than one
    /// context store. The context store must be in the <c>AVAILABLE</c> state. <para> The
    /// association is in the <c>ASSOCIATING</c> state when it's created, and changes to <c>ASSOCIATED</c>
    /// when it's complete. </para>
    /// </summary>
    public partial class AssociateContextStoreRequest : AmazonNetworkManagerRequest
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
        /// The Amazon Resource Name (ARN) of the transit gateway to associate with the context
        /// store.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public string TransitGatewayArn { get; set; }

        /// <summary>
        /// Checks to see if the TransitGatewayArn property is set.
        /// </summary>
        internal bool IsSetTransitGatewayArn() => this.TransitGatewayArn != null;
    }
}
