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
    /// Container for the parameters to the DeleteTrustAnchor operation. Deletes a trust anchor.
    /// <para> <b>Required permissions: </b> <c>rolesanywhere:DeleteTrustAnchor</c>. </para>
    /// </summary>
    public partial class DeleteTrustAnchorRequest : AmazonIAMRolesAnywhereRequest
    {
        /// <summary>
        /// Gets and sets the property TrustAnchorId. 
        /// <para>
        /// The trust anchor to act on. You can specify one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The trust anchor ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The trust anchor ARN.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The alias ARN of the trust anchor.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// An ARN must be for a trust anchor in your account and Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1011)]
        public string TrustAnchorId { get; set; }

        /// <summary>
        /// Checks to see if the TrustAnchorId property is set.
        /// </summary>
        internal bool IsSetTrustAnchorId() => this.TrustAnchorId != null;
    }
}
