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
 * Do not modify this file. This file is generated from the apprunner-2020-05-15.normal.json service model.
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
        private string _accountId;
        private DateTime? _createdAt;
        private DateTime? _deletedAt;
        private string _domainName;
        private IngressVpcConfiguration _ingressVpcConfiguration;
        private string _serviceArn;
        private VpcIngressConnectionStatus _status;
        private string _vpcIngressConnectionArn;
        private string _vpcIngressConnectionName;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Account Id you use to create the VPC Ingress Connection resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

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
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

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
        public DateTime? DeletedAt
        {
            get { return this._deletedAt; }
            set { this._deletedAt = value; }
        }

        // Check to see if DeletedAt property is set
        internal bool IsSetDeletedAt()
        {
            return this._deletedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The domain name associated with the VPC Ingress Connection resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

        /// <summary>
        /// Gets and sets the property IngressVpcConfiguration. 
        /// <para>
        /// Specifications for the customer’s VPC and related PrivateLink VPC endpoint that are
        /// used to associate with the VPC Ingress Connection resource.
        /// </para>
        /// </summary>
        public IngressVpcConfiguration IngressVpcConfiguration
        {
            get { return this._ingressVpcConfiguration; }
            set { this._ingressVpcConfiguration = value; }
        }

        // Check to see if IngressVpcConfiguration property is set
        internal bool IsSetIngressVpcConfiguration()
        {
            return this._ingressVpcConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the service associated with the VPC Ingress Connection.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1011)]
        public string ServiceArn
        {
            get { return this._serviceArn; }
            set { this._serviceArn = value; }
        }

        // Check to see if ServiceArn property is set
        internal bool IsSetServiceArn()
        {
            return this._serviceArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the VPC Ingress Connection. The VPC Ingress Connection displays
        /// one of the following statuses: <c>AVAILABLE</c>, <c>PENDING_CREATION</c>, <c>PENDING_UPDATE</c>,
        /// <c>PENDING_DELETION</c>,<c>FAILED_CREATION</c>, <c>FAILED_UPDATE</c>, <c>FAILED_DELETION</c>,
        /// and <c>DELETED</c>.. 
        /// </para>
        /// </summary>
        public VpcIngressConnectionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property VpcIngressConnectionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the VPC Ingress Connection. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1011)]
        public string VpcIngressConnectionArn
        {
            get { return this._vpcIngressConnectionArn; }
            set { this._vpcIngressConnectionArn = value; }
        }

        // Check to see if VpcIngressConnectionArn property is set
        internal bool IsSetVpcIngressConnectionArn()
        {
            return this._vpcIngressConnectionArn != null;
        }

        /// <summary>
        /// Gets and sets the property VpcIngressConnectionName. 
        /// <para>
        /// The customer-provided VPC Ingress Connection name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=40)]
        public string VpcIngressConnectionName
        {
            get { return this._vpcIngressConnectionName; }
            set { this._vpcIngressConnectionName = value; }
        }

        // Check to see if VpcIngressConnectionName property is set
        internal bool IsSetVpcIngressConnectionName()
        {
            return this._vpcIngressConnectionName != null;
        }

    }
}