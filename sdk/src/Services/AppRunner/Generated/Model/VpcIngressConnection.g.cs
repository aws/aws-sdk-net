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

namespace Amazon.AppRunner.Model
{
    /// <summary>
    /// The App Runner resource that specifies an App Runner endpoint for incoming traffic.
    /// It establishes a connection between a VPC interface endpoint and a App Runner service,
    /// to make your App Runner service accessible from only within an Amazon VPC.
    /// </summary>
    public partial class VpcIngressConnection
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Account Id you use to create the VPC Ingress Connection resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time when the VPC Ingress Connection was created. It's in the Unix time stamp
        /// format.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  Type: Timestamp 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Required: Yes 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DeletedAt. 
        /// <para>
        /// The time when the App Runner service was deleted. It's in the Unix time stamp format.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  Type: Timestamp 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Required: No 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DateTime? DeletedAt { get; set; }

        /// <summary>
        /// Checks to see if the DeletedAt property is set.
        /// </summary>
        internal bool IsSetDeletedAt() => this.DeletedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The domain name associated with the VPC Ingress Connection resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property IngressVpcConfiguration. 
        /// <para>
        /// Specifications for the customer’s VPC and related PrivateLink VPC endpoint that are
        /// used to associate with the VPC Ingress Connection resource.
        /// </para>
        /// </summary>
        public IngressVpcConfiguration IngressVpcConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the IngressVpcConfiguration property is set.
        /// </summary>
        internal bool IsSetIngressVpcConfiguration() => this.IngressVpcConfiguration != null;

        /// <summary>
        /// Gets and sets the property ServiceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the service associated with the VPC Ingress Connection.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1011)]
        public string ServiceArn { get; set; }

        /// <summary>
        /// Checks to see if the ServiceArn property is set.
        /// </summary>
        internal bool IsSetServiceArn() => this.ServiceArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the VPC Ingress Connection. The VPC Ingress Connection displays
        /// one of the following statuses: <c>AVAILABLE</c>, <c>PENDING_CREATION</c>, <c>PENDING_UPDATE</c>,
        /// <c>PENDING_DELETION</c>,<c>FAILED_CREATION</c>, <c>FAILED_UPDATE</c>, <c>FAILED_DELETION</c>,
        /// and <c>DELETED</c>.. 
        /// </para>
        /// </summary>
        public VpcIngressConnectionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property VpcIngressConnectionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the VPC Ingress Connection. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1011)]
        public string VpcIngressConnectionArn { get; set; }

        /// <summary>
        /// Checks to see if the VpcIngressConnectionArn property is set.
        /// </summary>
        internal bool IsSetVpcIngressConnectionArn() => this.VpcIngressConnectionArn != null;

        /// <summary>
        /// Gets and sets the property VpcIngressConnectionName. 
        /// <para>
        /// The customer-provided VPC Ingress Connection name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 4, Max = 40)]
        public string VpcIngressConnectionName { get; set; }

        /// <summary>
        /// Checks to see if the VpcIngressConnectionName property is set.
        /// </summary>
        internal bool IsSetVpcIngressConnectionName() => this.VpcIngressConnectionName != null;
    }
}
