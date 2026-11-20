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

namespace Amazon.Route53.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateHostedZoneFeatures operation. Updates the
    /// features configuration for a hosted zone. This operation allows you to enable or disable
    /// specific features for your hosted zone, such as accelerated recovery and public DNS
    /// fallback. <para> Accelerated recovery enables you to update DNS records in your public
    /// hosted zone even when the us-east-1 region is unavailable. </para> <para> Public DNS
    /// fallback enables Route 53 to retry a query against public DNS when a query for a domain
    /// name in a private hosted zone matches no existing name (<c>NXDOMAIN</c>). Fallback
    /// does not occur when the name exists but has no record of the requested type. Public
    /// DNS fallback is supported only for private hosted zones. </para>
    /// </summary>
    public partial class UpdateHostedZoneFeaturesRequest : AmazonRoute53Request
    {
        /// <summary>
        /// Gets and sets the property HostedZoneId. 
        /// <para>
        /// The ID of the hosted zone for which you want to update features. This is the unique
        /// identifier for your hosted zone.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 32)]
        public string HostedZoneId { get; set; }

        /// <summary>
        /// Checks to see if the HostedZoneId property is set.
        /// </summary>
        internal bool IsSetHostedZoneId() => this.HostedZoneId != null;

        /// <summary>
        /// Gets and sets the property EnableAcceleratedRecovery. 
        /// <para>
        /// Specifies whether to enable accelerated recovery for the hosted zone. Set to <c>true</c>
        /// to enable accelerated recovery, or <c>false</c> to disable it.
        /// </para>
        /// </summary>
        public bool? EnableAcceleratedRecovery { get; set; }

        /// <summary>
        /// Checks to see if the EnableAcceleratedRecovery property is set.
        /// </summary>
        internal bool IsSetEnableAcceleratedRecovery() => this.EnableAcceleratedRecovery.HasValue;

        /// <summary>
        /// Gets and sets the property EnablePublicDNSFallback. 
        /// <para>
        /// Specifies whether to enable public DNS fallback for the hosted zone. Set to <c>true</c>
        /// to enable public DNS fallback, or <c>false</c> to disable it.
        /// </para>
        ///  
        /// <para>
        /// Public DNS fallback applies to the entire hosted zone and to all VPCs that are associated
        /// with it. To check whether a change has propagated, call <c>GetHostedZone</c> and review
        /// <c>PublicDNSFallbackStatus</c> in the response.
        /// </para>
        ///  
        /// <para>
        /// Public DNS fallback is supported only for private hosted zones.
        /// </para>
        /// </summary>
        public bool? EnablePublicDNSFallback { get; set; }

        /// <summary>
        /// Checks to see if the EnablePublicDNSFallback property is set.
        /// </summary>
        internal bool IsSetEnablePublicDNSFallback() => this.EnablePublicDNSFallback.HasValue;

        /// <summary>
        /// Gets and sets the property ChangeGuardrails. 
        /// <para>
        /// Specify the Change Guardrails to turn on or off for the hosted zone. Each entry specifies
        /// the name of a guardrail and one of the following statuses:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ENABLED</c>: Turns on the guardrail.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DISABLED</c>: Turns off the guardrail.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Guardrails that aren't in the request keep their current status.
        /// </para>
        ///  
        /// <para>
        /// You can turn on an optional guardrail only if the tier of the hosted zone offers it.
        /// You can't turn off a guardrail that the tier includes, such as <c>NS_FORMAT_CHECK</c>.
        /// In either case, Route 53 returns an <c>InvalidInput</c> error.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<ChangeGuardrail> ChangeGuardrails { get; set; } = AWSConfigs.InitializeCollections ? new List<ChangeGuardrail>() : null;

        /// <summary>
        /// Checks to see if the ChangeGuardrails property is set.
        /// </summary>
        internal bool IsSetChangeGuardrails() => this.ChangeGuardrails != null && (this.ChangeGuardrails.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Specifies whether to validate the request without changing any features. Route 53
        /// returns the same errors as for a real request, but doesn't change the hosted zone.
        /// The default is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;
    }
}
