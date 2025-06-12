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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// A list of IP address ranges (<a href="https://docs.aws.amazon.com/vpc/latest/userguide/VPC_Subnets.html">CIDRs</a>).
    /// Used to create an allow list of IP addresses for a private workforce. Workers will
    /// only be able to log in to their worker portal from an IP address within this range.
    /// By default, a workforce isn't restricted to specific IP addresses.
    /// </summary>
    public partial class SourceIpConfig
    {
        private List<string> _cidrs = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Cidrs. 
        /// <para>
        /// A list of one to ten <a href="https://docs.aws.amazon.com/vpc/latest/userguide/VPC_Subnets.html">Classless
        /// Inter-Domain Routing</a> (CIDR) values.
        /// </para>
        ///  
        /// <para>
        /// Maximum: Ten CIDR values
        /// </para>
        ///  <note> 
        /// <para>
        /// The following Length Constraints apply to individual CIDR values in the CIDR value
        /// list.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Cidrs
        {
            get { return this._cidrs; }
            set { this._cidrs = value; }
        }

        // Check to see if Cidrs property is set
        internal bool IsSetCidrs()
        {
            return this._cidrs != null && (this._cidrs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}