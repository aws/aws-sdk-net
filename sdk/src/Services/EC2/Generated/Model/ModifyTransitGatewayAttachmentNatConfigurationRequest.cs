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
    /// Container for the parameters to the ModifyTransitGatewayAttachmentNatConfiguration operation.
    /// Modifies the NAT configuration for the specified transit gateway attachment. Use this
    /// operation to do the following:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Enable or disable NAT gateway support for the attachment.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Specify whether the transit gateway installs routes for the NAT CIDRs.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Replace the NAT gateway rules for the attachment.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Only the owner of the transit gateway can modify the NAT configuration.
    /// </para>
    ///  
    /// <para>
    /// With NAT gateway support enabled, the transit gateway translates addresses in each
    /// rule's <c>MatchSourceCidr</c> range to the corresponding addresses in its <c>NatCidr</c>
    /// range.
    /// </para>
    ///  
    /// <para>
    /// The transit gateway applies changes asynchronously. To check the result, use <c>GetTransitGatewayAttachmentNatConfiguration</c>.
    /// </para>
    /// </summary>
    public partial class ModifyTransitGatewayAttachmentNatConfigurationRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private List<TransitGatewayNatRuleRequest> _natGatewayRules = AWSConfigs.InitializeCollections ? new List<TransitGatewayNatRuleRequest>() : null;
        private TransitGatewayAttachmentNatGatewaySupportValue _natGatewaySupport;
        private TransitGatewayAttachmentNatSystemRouteSupportValue _natSystemRouteSupport;
        private bool? _resetNatGatewayRules;
        private string _transitGatewayAttachmentId;

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
        /// Gets and sets the property NatGatewayRules. 
        /// <para>
        /// The NAT gateway rules for the attachment. The rules that you specify replace all existing
        /// NAT gateway rules for the attachment. You can specify up to 50 rules for an attachment.
        /// If you omit this parameter, the existing rules don't change. To remove all rules,
        /// use <c>ResetNatGatewayRules</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<TransitGatewayNatRuleRequest> NatGatewayRules
        {
            get { return this._natGatewayRules; }
            set { this._natGatewayRules = value; }
        }

        // Check to see if NatGatewayRules property is set
        internal bool IsSetNatGatewayRules()
        {
            return this._natGatewayRules != null && (this._natGatewayRules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NatGatewaySupport. 
        /// <para>
        /// Specifies whether to enable or disable NAT gateway support for the attachment. To
        /// enable NAT gateway support, the attachment must have at least one NAT gateway rule.
        /// You can't modify the NAT configuration while NAT gateway support is <c>enabling</c>
        /// or <c>disabling</c>. If you omit this parameter, the current value doesn't change.
        /// </para>
        /// </summary>
        public TransitGatewayAttachmentNatGatewaySupportValue NatGatewaySupport
        {
            get { return this._natGatewaySupport; }
            set { this._natGatewaySupport = value; }
        }

        // Check to see if NatGatewaySupport property is set
        internal bool IsSetNatGatewaySupport()
        {
            return this._natGatewaySupport != null;
        }

        /// <summary>
        /// Gets and sets the property NatSystemRouteSupport. 
        /// <para>
        /// Specifies whether the transit gateway installs routes for the NAT CIDRs in the route
        /// tables to which the attachment propagates. For VPC attachments, the transit gateway
        /// always installs these routes. You can enable or disable this option only for Amazon
        /// Web Services Direct Connect gateway attachments and Site-to-Site VPN attachments that
        /// use dynamic routing. For these attachments, the default is <c>enable</c>. If you omit
        /// this parameter, the current value doesn't change.
        /// </para>
        /// </summary>
        public TransitGatewayAttachmentNatSystemRouteSupportValue NatSystemRouteSupport
        {
            get { return this._natSystemRouteSupport; }
            set { this._natSystemRouteSupport = value; }
        }

        // Check to see if NatSystemRouteSupport property is set
        internal bool IsSetNatSystemRouteSupport()
        {
            return this._natSystemRouteSupport != null;
        }

        /// <summary>
        /// Gets and sets the property ResetNatGatewayRules. 
        /// <para>
        /// Specifies whether to remove all NAT gateway rules from the attachment. If you omit
        /// this parameter, the transit gateway doesn't remove any rules. You can't specify this
        /// parameter together with <c>NatGatewayRules</c>. Because you can't enable NAT gateway
        /// support without rules, also set <c>NatGatewaySupport</c> to <c>disable</c> in the
        /// same request if NAT gateway support is currently enabled.
        /// </para>
        /// </summary>
        public bool? ResetNatGatewayRules
        {
            get { return this._resetNatGatewayRules; }
            set { this._resetNatGatewayRules = value; }
        }

        // Check to see if ResetNatGatewayRules property is set
        internal bool IsSetResetNatGatewayRules()
        {
            return this._resetNatGatewayRules.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TransitGatewayAttachmentId. 
        /// <para>
        /// The ID of the transit gateway attachment.
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

    }
}