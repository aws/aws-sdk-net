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
    /// Container for the parameters to the DisassociateTransitGatewayPolicyTable operation.
    /// Removes the association between an an attachment and a policy table.
    /// </summary>
    public partial class DisassociateTransitGatewayPolicyTableRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private string _transitGatewayAttachmentId;
        private string _transitGatewayPolicyTableId;

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
        /// Gets and sets the property TransitGatewayAttachmentId. 
        /// <para>
        /// The ID of the transit gateway attachment to disassociate from the policy table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TransitGatewayAttachmentId
        {
            get { return this._transitGatewayAttachmentId; }
            set { this._transitGatewayAttachmentId = value; }
        }

        // Check to see if TransitGatewayAttachmentId property is set
        internal bool IsSetTransitGatewayAttachmentId()
        {
            return this._transitGatewayAttachmentId != null;
        }

        /// <summary>
        /// Gets and sets the property TransitGatewayPolicyTableId. 
        /// <para>
        /// The ID of the disassociated policy table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TransitGatewayPolicyTableId
        {
            get { return this._transitGatewayPolicyTableId; }
            set { this._transitGatewayPolicyTableId = value; }
        }

        // Check to see if TransitGatewayPolicyTableId property is set
        internal bool IsSetTransitGatewayPolicyTableId()
        {
            return this._transitGatewayPolicyTableId != null;
        }

    }
}