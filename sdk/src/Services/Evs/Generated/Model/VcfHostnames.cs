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
 * Do not modify this file. This file is generated from the evs-2023-07-27.normal.json service model.
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
    /// </summary>
    public partial class VcfHostnames
    {
        private string _cloudBuilder;
        private string _nsx;
        private string _nsxEdge1;
        private string _nsxEdge2;
        private string _nsxManager1;
        private string _nsxManager2;
        private string _nsxManager3;
        private string _sddcManager;
        private string _vCenter;

        /// <summary>
        /// Gets and sets the property CloudBuilder. 
        /// <para>
        /// The hostname for VMware Cloud Builder.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CloudBuilder
        {
            get { return this._cloudBuilder; }
            set { this._cloudBuilder = value; }
        }

        // Check to see if CloudBuilder property is set
        internal bool IsSetCloudBuilder()
        {
            return this._cloudBuilder != null;
        }

        /// <summary>
        /// Gets and sets the property Nsx. 
        /// <para>
        /// The VMware NSX hostname.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Nsx
        {
            get { return this._nsx; }
            set { this._nsx = value; }
        }

        // Check to see if Nsx property is set
        internal bool IsSetNsx()
        {
            return this._nsx != null;
        }

        /// <summary>
        /// Gets and sets the property NsxEdge1. 
        /// <para>
        /// The hostname for the first NSX Edge node.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string NsxEdge1
        {
            get { return this._nsxEdge1; }
            set { this._nsxEdge1 = value; }
        }

        // Check to see if NsxEdge1 property is set
        internal bool IsSetNsxEdge1()
        {
            return this._nsxEdge1 != null;
        }

        /// <summary>
        /// Gets and sets the property NsxEdge2. 
        /// <para>
        /// The hostname for the second NSX Edge node.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string NsxEdge2
        {
            get { return this._nsxEdge2; }
            set { this._nsxEdge2 = value; }
        }

        // Check to see if NsxEdge2 property is set
        internal bool IsSetNsxEdge2()
        {
            return this._nsxEdge2 != null;
        }

        /// <summary>
        /// Gets and sets the property NsxManager1. 
        /// <para>
        /// The hostname for the first VMware NSX Manager virtual machine (VM).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string NsxManager1
        {
            get { return this._nsxManager1; }
            set { this._nsxManager1 = value; }
        }

        // Check to see if NsxManager1 property is set
        internal bool IsSetNsxManager1()
        {
            return this._nsxManager1 != null;
        }

        /// <summary>
        /// Gets and sets the property NsxManager2. 
        /// <para>
        /// The hostname for the second VMware NSX Manager virtual machine (VM).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string NsxManager2
        {
            get { return this._nsxManager2; }
            set { this._nsxManager2 = value; }
        }

        // Check to see if NsxManager2 property is set
        internal bool IsSetNsxManager2()
        {
            return this._nsxManager2 != null;
        }

        /// <summary>
        /// Gets and sets the property NsxManager3. 
        /// <para>
        /// The hostname for the third VMware NSX Manager virtual machine (VM).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string NsxManager3
        {
            get { return this._nsxManager3; }
            set { this._nsxManager3 = value; }
        }

        // Check to see if NsxManager3 property is set
        internal bool IsSetNsxManager3()
        {
            return this._nsxManager3 != null;
        }

        /// <summary>
        /// Gets and sets the property SddcManager. 
        /// <para>
        /// The hostname for SDDC Manager.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SddcManager
        {
            get { return this._sddcManager; }
            set { this._sddcManager = value; }
        }

        // Check to see if SddcManager property is set
        internal bool IsSetSddcManager()
        {
            return this._sddcManager != null;
        }

        /// <summary>
        /// Gets and sets the property VCenter. 
        /// <para>
        /// The VMware vCenter hostname.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VCenter
        {
            get { return this._vCenter; }
            set { this._vCenter = value; }
        }

        // Check to see if VCenter property is set
        internal bool IsSetVCenter()
        {
            return this._vCenter != null;
        }

    }
}