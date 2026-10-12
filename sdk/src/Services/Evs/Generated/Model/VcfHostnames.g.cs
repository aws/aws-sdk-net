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

namespace Amazon.Evs.Model
{
    /// <summary>
    /// The DNS hostnames that Amazon EVS uses to install VMware vCenter Server, NSX, SDDC
    /// Manager, and Cloud Builder. Each hostname must be unique, and resolve to a domain
    /// name that you've registered in your DNS service of choice. Hostnames cannot be changed.
    /// 
    ///  
    /// <para>
    /// VMware VCF requires the deployment of two NSX Edge nodes, and three NSX Manager virtual
    /// machines.
    /// </para>
    ///  <note> 
    /// <para>
    /// Not supported when <c>vcfVersion</c> is <c>SELF_DEPLOYED</c>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class VcfHostnames
    {
        /// <summary>
        /// Gets and sets the property CloudBuilder. 
        /// <para>
        /// The hostname for VMware Cloud Builder.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CloudBuilder { get; set; }

        /// <summary>
        /// Checks to see if the CloudBuilder property is set.
        /// </summary>
        internal bool IsSetCloudBuilder() => this.CloudBuilder != null;

        /// <summary>
        /// Gets and sets the property Nsx. 
        /// <para>
        /// The VMware NSX Virtual IP (VIP) hostname.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Nsx { get; set; }

        /// <summary>
        /// Checks to see if the Nsx property is set.
        /// </summary>
        internal bool IsSetNsx() => this.Nsx != null;

        /// <summary>
        /// Gets and sets the property NsxEdge1. 
        /// <para>
        /// The hostname for the first NSX Edge node.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string NsxEdge1 { get; set; }

        /// <summary>
        /// Checks to see if the NsxEdge1 property is set.
        /// </summary>
        internal bool IsSetNsxEdge1() => this.NsxEdge1 != null;

        /// <summary>
        /// Gets and sets the property NsxEdge2. 
        /// <para>
        /// The hostname for the second NSX Edge node.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string NsxEdge2 { get; set; }

        /// <summary>
        /// Checks to see if the NsxEdge2 property is set.
        /// </summary>
        internal bool IsSetNsxEdge2() => this.NsxEdge2 != null;

        /// <summary>
        /// Gets and sets the property NsxManager1. 
        /// <para>
        /// The hostname for the first VMware NSX Manager virtual machine (VM).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string NsxManager1 { get; set; }

        /// <summary>
        /// Checks to see if the NsxManager1 property is set.
        /// </summary>
        internal bool IsSetNsxManager1() => this.NsxManager1 != null;

        /// <summary>
        /// Gets and sets the property NsxManager2. 
        /// <para>
        /// The hostname for the second VMware NSX Manager virtual machine (VM).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string NsxManager2 { get; set; }

        /// <summary>
        /// Checks to see if the NsxManager2 property is set.
        /// </summary>
        internal bool IsSetNsxManager2() => this.NsxManager2 != null;

        /// <summary>
        /// Gets and sets the property NsxManager3. 
        /// <para>
        /// The hostname for the third VMware NSX Manager virtual machine (VM).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string NsxManager3 { get; set; }

        /// <summary>
        /// Checks to see if the NsxManager3 property is set.
        /// </summary>
        internal bool IsSetNsxManager3() => this.NsxManager3 != null;

        /// <summary>
        /// Gets and sets the property SddcManager. 
        /// <para>
        /// The hostname for SDDC Manager.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SddcManager { get; set; }

        /// <summary>
        /// Checks to see if the SddcManager property is set.
        /// </summary>
        internal bool IsSetSddcManager() => this.SddcManager != null;

        /// <summary>
        /// Gets and sets the property VCenter. 
        /// <para>
        /// The VMware vCenter hostname.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string VCenter { get; set; }

        /// <summary>
        /// Checks to see if the VCenter property is set.
        /// </summary>
        internal bool IsSetVCenter() => this.VCenter != null;
    }
}
