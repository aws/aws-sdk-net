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

namespace Amazon.VPCLattice.Model
{
    /// <summary>
    /// Specifies which account pays for a category of charges on a VPC endpoint association.
    /// </summary>
    public partial class PayerResponsibilityEntry
    {
        /// <summary>
        /// Gets and sets the property PayerResponsibilityType. 
        /// <para>
        /// The account that pays this category of charges. <c>VpcEndpointAccount</c> owns the
        /// VPC endpoint. <c>ResourceGatewayAccount</c> owns the resource gateway.
        /// </para>
        /// </summary>
        public PayerResponsibilityPayer PayerResponsibilityType { get; set; }

        /// <summary>
        /// Checks to see if the PayerResponsibilityType property is set.
        /// </summary>
        internal bool IsSetPayerResponsibilityType() => this.PayerResponsibilityType != null;

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// The category of charges that this entry applies to. <c>ResourceGatewayCharges</c>
        /// covers the resource gateway's data processing charge.
        /// </para>
        /// </summary>
        public PayerResponsibilityScope Scope { get; set; }

        /// <summary>
        /// Checks to see if the Scope property is set.
        /// </summary>
        internal bool IsSetScope() => this.Scope != null;
    }
}
