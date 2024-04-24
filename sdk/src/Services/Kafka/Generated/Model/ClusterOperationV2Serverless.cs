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
 * Do not modify this file. This file is generated from the kafka-2018-11-14.normal.json service model.
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
namespace Amazon.Kafka.Model
{
    /// <summary>
    /// Returns information about a serverless cluster operation.
    /// </summary>
    public partial class ClusterOperationV2Serverless
    {
        private VpcConnectionInfoServerless _vpcConnectionInfo;

        /// <summary>
        /// Gets and sets the property VpcConnectionInfo.             
        /// <para>
        /// Description of the VPC connection for CreateVpcConnection and DeleteVpcConnection
        /// operations.
        /// </para>
        /// </summary>
        public VpcConnectionInfoServerless VpcConnectionInfo
        {
            get { return this._vpcConnectionInfo; }
            set { this._vpcConnectionInfo = value; }
        }

        // Check to see if VpcConnectionInfo property is set
        internal bool IsSetVpcConnectionInfo()
        {
            return this._vpcConnectionInfo != null;
        }

    }
}