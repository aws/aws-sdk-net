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

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateAccessPolicy operation. <important> <para>
    /// The IoT SiteWise Monitor feature will no longer be open to new customers starting
    /// November 7, 2025. If you would like to use the IoT SiteWise Monitor feature, sign
    /// up prior to that date. Existing customers can continue to use the service as normal.
    /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/appguide/iotsitewise-monitor-availability-change.html">IoT
    /// SiteWise Monitor availability change</a>. </para> </important> <para> Updates an existing
    /// access policy that specifies an identity's access to an IoT SiteWise Monitor portal
    /// or project resource. </para>
    /// </summary>
    public partial class UpdateAccessPolicyRequest : AmazonIoTSiteWiseRequest
    {
        /// <summary>
        /// Gets and sets the property AccessPolicyId. 
        /// <para>
        /// The ID of the access policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string AccessPolicyId { get; set; }

        /// <summary>
        /// Checks to see if the AccessPolicyId property is set.
        /// </summary>
        internal bool IsSetAccessPolicyId() => this.AccessPolicyId != null;

        /// <summary>
        /// Gets and sets the property AccessPolicyIdentity. 
        /// <para>
        /// The identity for this access policy. Choose an IAM Identity Center user, an IAM Identity
        /// Center group, or an IAM user.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Identity AccessPolicyIdentity { get; set; }

        /// <summary>
        /// Checks to see if the AccessPolicyIdentity property is set.
        /// </summary>
        internal bool IsSetAccessPolicyIdentity() => this.AccessPolicyIdentity != null;

        /// <summary>
        /// Gets and sets the property AccessPolicyPermission. 
        /// <para>
        /// The permission level for this access policy. Note that a project <c>ADMINISTRATOR</c>
        /// is also known as a project owner.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Permission AccessPolicyPermission { get; set; }

        /// <summary>
        /// Checks to see if the AccessPolicyPermission property is set.
        /// </summary>
        internal bool IsSetAccessPolicyPermission() => this.AccessPolicyPermission != null;

        /// <summary>
        /// Gets and sets the property AccessPolicyResource. 
        /// <para>
        /// The IoT SiteWise Monitor resource for this access policy. Choose either a portal or
        /// a project.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Resource AccessPolicyResource { get; set; }

        /// <summary>
        /// Checks to see if the AccessPolicyResource property is set.
        /// </summary>
        internal bool IsSetAccessPolicyResource() => this.AccessPolicyResource != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique case-sensitive identifier that you can provide to ensure the idempotency
        /// of the request. Don't reuse this client token if a new idempotent request is required.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;
    }
}
