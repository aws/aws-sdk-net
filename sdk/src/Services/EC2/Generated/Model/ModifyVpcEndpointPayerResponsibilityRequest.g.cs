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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyVpcEndpointPayerResponsibility operation.
    /// Modifies the billing account for VPC endpoint usage/charges.
    /// </summary>
    public partial class ModifyVpcEndpointPayerResponsibilityRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property PayerResponsibility. 
        /// <para>
        /// The Amazon Web Services account to which the usage of VPC endpoint is charged.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PayerResponsibilityType PayerResponsibility { get; set; }

        /// <summary>
        /// Checks to see if the PayerResponsibility property is set.
        /// </summary>
        internal bool IsSetPayerResponsibility() => this.PayerResponsibility != null;

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// The scope of usage/charges for which the billing account is being modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PayerResponsibilityScope Scope { get; set; }

        /// <summary>
        /// Checks to see if the Scope property is set.
        /// </summary>
        internal bool IsSetScope() => this.Scope != null;

        /// <summary>
        /// Gets and sets the property ServiceId. 
        /// <para>
        /// The ID of the VPC endpoint service.
        /// </para>
        /// </summary>
        public string ServiceId { get; set; }

        /// <summary>
        /// Checks to see if the ServiceId property is set.
        /// </summary>
        internal bool IsSetServiceId() => this.ServiceId != null;

        /// <summary>
        /// Gets and sets the property VpcEndpointId. 
        /// <para>
        /// The ID of the VPC endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string VpcEndpointId { get; set; }

        /// <summary>
        /// Checks to see if the VpcEndpointId property is set.
        /// </summary>
        internal bool IsSetVpcEndpointId() => this.VpcEndpointId != null;
    }
}
