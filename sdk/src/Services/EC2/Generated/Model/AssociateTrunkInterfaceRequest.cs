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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateTrunkInterface operation.
    /// Associates a branch network interface with a trunk network interface.
    /// 
    ///  
    /// <para>
    /// Before you create the association, use <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_CreateNetworkInterface.html">CreateNetworkInterface</a>
    /// command and set the interface type to <c>trunk</c>. You must also create a network
    /// interface for each branch network interface that you want to associate with the trunk
    /// network interface.
    /// </para>
    /// </summary>
    public partial class AssociateTrunkInterfaceRequest : AmazonEC2Request
    {
        private string _branchInterfaceId;
        private string _clientToken;
        private bool? _dryRun;
        private int? _greKey;
        private string _trunkInterfaceId;
        private int? _vlanId;

        /// <summary>
        /// Gets and sets the property BranchInterfaceId. 
        /// <para>
        /// The ID of the branch network interface.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BranchInterfaceId
        {
            get { return this._branchInterfaceId; }
            set { this._branchInterfaceId = value; }
        }

        // Check to see if BranchInterfaceId property is set
        internal bool IsSetBranchInterfaceId()
        {
            return this._branchInterfaceId != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request. For more information, see <a href="https://docs.aws.amazon.com/ec2/latest/devguide/ec2-api-idempotency.html">Ensuring
        /// idempotency</a>.
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
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GreKey. 
        /// <para>
        /// The application key. This applies to the GRE protocol.
        /// </para>
        /// </summary>
        public int? GreKey
        {
            get { return this._greKey; }
            set { this._greKey = value; }
        }

        // Check to see if GreKey property is set
        internal bool IsSetGreKey()
        {
            return this._greKey.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TrunkInterfaceId. 
        /// <para>
        /// The ID of the trunk network interface.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TrunkInterfaceId
        {
            get { return this._trunkInterfaceId; }
            set { this._trunkInterfaceId = value; }
        }

        // Check to see if TrunkInterfaceId property is set
        internal bool IsSetTrunkInterfaceId()
        {
            return this._trunkInterfaceId != null;
        }

        /// <summary>
        /// Gets and sets the property VlanId. 
        /// <para>
        /// The ID of the VLAN. This applies to the VLAN protocol.
        /// </para>
        /// </summary>
        public int? VlanId
        {
            get { return this._vlanId; }
            set { this._vlanId = value; }
        }

        // Check to see if VlanId property is set
        internal bool IsSetVlanId()
        {
            return this._vlanId.HasValue; 
        }

    }
}