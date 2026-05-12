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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
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
namespace Amazon.Mgn.Model
{
    /// <summary>
    /// The target resource information for an analysis result.
    /// </summary>
    public partial class NetworkMigrationAnalysisResultTarget
    {
        private string _subnetid;
        private string _vpcid;

        /// <summary>
        /// Gets and sets the property SubnetID. 
        /// <para>
        /// The subnet ID of the target resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string SubnetID
        {
            get { return this._subnetid; }
            set { this._subnetid = value; }
        }

        // Check to see if SubnetID property is set
        internal bool IsSetSubnetID()
        {
            return this._subnetid != null;
        }

        /// <summary>
        /// Gets and sets the property VpcID. 
        /// <para>
        /// The VPC ID of the target resource.
        /// </para>
        /// </summary>
        public string VpcID
        {
            get { return this._vpcid; }
            set { this._vpcid = value; }
        }

        // Check to see if VpcID property is set
        internal bool IsSetVpcID()
        {
            return this._vpcid != null;
        }

    }
}