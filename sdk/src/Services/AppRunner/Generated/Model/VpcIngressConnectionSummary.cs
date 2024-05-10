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
    /// Provides summary information about an VPC Ingress Connection, which includes its VPC
    /// Ingress Connection ARN and its associated Service ARN.
    /// </summary>
    public partial class VpcIngressConnectionSummary
    {
        private string _serviceArn;
        private string _vpcIngressConnectionArn;

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

    }
}