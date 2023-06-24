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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateIpam operation.
    /// Create an IPAM. Amazon VPC IP Address Manager (IPAM) is a VPC feature that you can
    /// use to automate your IP address management workflows including assigning, tracking,
    /// troubleshooting, and auditing IP addresses across Amazon Web Services Regions and
    /// accounts throughout your Amazon Web Services Organization.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/ipam/create-ipam.html">Create
    /// an IPAM</a> in the <i>Amazon VPC IPAM User Guide</i>. 
    /// </para>
    /// </summary>
    public partial class CreateIpamRequest : AmazonEC2Request
    {
        private string _clientToken;
        private string _description;
        private List<AddIpamOperatingRegion> _operatingRegions = new List<AddIpamOperatingRegion>();
        private List<TagSpecification> _tagSpecifications = new List<TagSpecification>();

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// Idempotency</a>.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the IPAM.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property OperatingRegions. 
        /// <para>
        /// The operating Regions for the IPAM. Operating Regions are Amazon Web Services Regions
        /// where the IPAM is allowed to manage IP address CIDRs. IPAM only discovers and monitors
        /// resources in the Amazon Web Services Regions you select as operating Regions. 
        /// </para>
        ///  
        /// <para>
        /// For more information about operating Regions, see <a href="https://docs.aws.amazon.com/vpc/latest/ipam/create-ipam.html">Create
        /// an IPAM</a> in the <i>Amazon VPC IPAM User Guide</i>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<AddIpamOperatingRegion> OperatingRegions
        {
            get { return this._operatingRegions; }
            set { this._operatingRegions = value; }
        }

        // Check to see if OperatingRegions property is set
        internal bool IsSetOperatingRegions()
        {
            return this._operatingRegions != null && this._operatingRegions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The key/value combination of a tag assigned to the resource. Use the tag key in the
        /// filter name and the tag value as the filter value. For example, to find all resources
        /// that have a tag with the key <code>Owner</code> and the value <code>TeamA</code>,
        /// specify <code>tag:Owner</code> for the filter name and <code>TeamA</code> for the
        /// filter value.
        /// </para>
        /// </summary>
        public List<TagSpecification> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && this._tagSpecifications.Count > 0; 
        }

    }
}