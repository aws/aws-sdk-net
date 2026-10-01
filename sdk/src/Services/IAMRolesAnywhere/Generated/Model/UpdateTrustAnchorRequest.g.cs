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

namespace Amazon.IAMRolesAnywhere.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateTrustAnchor operation. Updates a trust anchor.
    /// You establish trust between IAM Roles Anywhere and your certificate authority (CA)
    /// by configuring a trust anchor. You can define a trust anchor as a reference to an
    /// Private Certificate Authority (Private CA) or by uploading a CA certificate. Your
    /// Amazon Web Services workloads can authenticate with the trust anchor using certificates
    /// issued by the CA in exchange for temporary Amazon Web Services credentials. <para>
    /// <b>Required permissions: </b> <c>rolesanywhere:UpdateTrustAnchor</c>. </para>
    /// </summary>
    public partial class UpdateTrustAnchorRequest : AmazonIAMRolesAnywhereRequest
    {
        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the trust anchor.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The trust anchor type and its related certificate data.
        /// </para>
        /// </summary>
        public Source Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

        /// <summary>
        /// Gets and sets the property TrustAnchorId. 
        /// <para>
        /// The unique identifier of the trust anchor.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string TrustAnchorId { get; set; }

        /// <summary>
        /// Checks to see if the TrustAnchorId property is set.
        /// </summary>
        internal bool IsSetTrustAnchorId() => this.TrustAnchorId != null;
    }
}
