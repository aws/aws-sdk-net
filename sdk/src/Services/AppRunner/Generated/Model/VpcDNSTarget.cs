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
    /// DNS Target record for a custom domain of this Amazon VPC.
    /// </summary>
    public partial class VpcDNSTarget
    {
        private string _domainName;
        private string _vpcId;
        private string _vpcIngressConnectionArn;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The domain name of your target DNS that is associated with the Amazon VPC.
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
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the Amazon VPC that is associated with the custom domain name of the target
        /// DNS.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=51200)]
        public string VpcId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this._vpcId != null;
        }

        /// <summary>
        /// Gets and sets the property VpcIngressConnectionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the VPC Ingress Connection that is associated with
        /// your service.
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

    }
}