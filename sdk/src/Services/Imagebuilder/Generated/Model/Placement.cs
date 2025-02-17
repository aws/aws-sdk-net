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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
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
namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// By default, EC2 instances run on shared tenancy hardware. This means that multiple
    /// Amazon Web Services accounts might share the same physical hardware. When you use
    /// dedicated hardware, the physical server that hosts your instances is dedicated to
    /// your Amazon Web Services account. Instance placement settings contain the details
    /// for the physical hardware where instances that Image Builder launches during image
    /// creation will run.
    /// </summary>
    public partial class Placement
    {
        private string _availabilityZone;
        private string _hostId;
        private string _hostResourceGroupArn;
        private TenancyType _tenancy;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone where your build and test instances will launch.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property HostId. 
        /// <para>
        /// The ID of the Dedicated Host on which build and test instances run. This only applies
        /// if <c>tenancy</c> is <c>host</c>. If you specify the host ID, you must not specify
        /// the resource group ARN. If you specify both, Image Builder returns an error.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string HostId
        {
            get { return this._hostId; }
            set { this._hostId = value; }
        }

        // Check to see if HostId property is set
        internal bool IsSetHostId()
        {
            return this._hostId != null;
        }

        /// <summary>
        /// Gets and sets the property HostResourceGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the host resource group in which to launch build
        /// and test instances. This only applies if <c>tenancy</c> is <c>host</c>. If you specify
        /// the resource group ARN, you must not specify the host ID. If you specify both, Image
        /// Builder returns an error.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string HostResourceGroupArn
        {
            get { return this._hostResourceGroupArn; }
            set { this._hostResourceGroupArn = value; }
        }

        // Check to see if HostResourceGroupArn property is set
        internal bool IsSetHostResourceGroupArn()
        {
            return this._hostResourceGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property Tenancy. 
        /// <para>
        /// The tenancy of the instance. An instance with a tenancy of <c>dedicated</c> runs on
        /// single-tenant hardware. An instance with a tenancy of <c>host</c> runs on a Dedicated
        /// Host.
        /// </para>
        ///  
        /// <para>
        /// If tenancy is set to <c>host</c>, then you can optionally specify one target for placement
        /// – either host ID or host resource group ARN. If automatic placement is enabled for
        /// your host, and you don't specify any placement target, Amazon EC2 will try to find
        /// an available host for your build and test instances.
        /// </para>
        /// </summary>
        public TenancyType Tenancy
        {
            get { return this._tenancy; }
            set { this._tenancy = value; }
        }

        // Check to see if Tenancy property is set
        internal bool IsSetTenancy()
        {
            return this._tenancy != null;
        }

    }
}