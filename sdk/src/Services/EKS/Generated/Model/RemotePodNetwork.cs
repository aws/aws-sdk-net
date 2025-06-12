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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
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
namespace Amazon.EKS.Model
{
    /// <summary>
    /// A network CIDR that can contain pods that run Kubernetes webhooks on hybrid nodes.
    /// 
    ///  
    /// <para>
    /// These CIDR blocks are determined by configuring your Container Network Interface (CNI)
    /// plugin. We recommend the Calico CNI or Cilium CNI. Note that the Amazon VPC CNI plugin
    /// for Kubernetes isn't available for on-premises and edge locations.
    /// </para>
    ///  
    /// <para>
    /// Enter one or more IPv4 CIDR blocks in decimal dotted-quad notation (for example, <c>
    /// 10.2.0.0/16</c>).
    /// </para>
    ///  
    /// <para>
    /// It must satisfy the following requirements:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Each block must be within an <c>IPv4</c> RFC-1918 network range. Minimum allowed size
    /// is /32, maximum allowed size is /8. Publicly-routable addresses aren't supported.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Each block cannot overlap with the range of the VPC CIDR blocks for your EKS resources,
    /// or the block of the Kubernetes service IP range.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class RemotePodNetwork
    {
        private List<string> _cidrs = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Cidrs. 
        /// <para>
        /// A network CIDR that can contain pods that run Kubernetes webhooks on hybrid nodes.
        /// </para>
        ///  
        /// <para>
        /// These CIDR blocks are determined by configuring your Container Network Interface (CNI)
        /// plugin. We recommend the Calico CNI or Cilium CNI. Note that the Amazon VPC CNI plugin
        /// for Kubernetes isn't available for on-premises and edge locations.
        /// </para>
        ///  
        /// <para>
        /// Enter one or more IPv4 CIDR blocks in decimal dotted-quad notation (for example, <c>
        /// 10.2.0.0/16</c>).
        /// </para>
        ///  
        /// <para>
        /// It must satisfy the following requirements:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Each block must be within an <c>IPv4</c> RFC-1918 network range. Minimum allowed size
        /// is /32, maximum allowed size is /8. Publicly-routable addresses aren't supported.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Each block cannot overlap with the range of the VPC CIDR blocks for your EKS resources,
        /// or the block of the Kubernetes service IP range.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
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