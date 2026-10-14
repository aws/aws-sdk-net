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

namespace Amazon.CloudWatchOmni.Model
{
    /// <summary>
    /// The principal receiving the grant. Specify principalId, principalAttributes, or both.
    /// </summary>
    public partial class AccessGrantPrincipal
    {
        /// <summary>
        /// Gets and sets the property PrincipalAttributes. Attribute conditions for attribute-based
        /// access. When provided, the grant targets any principal matching all specified conditions.
        /// Supported only for IDC_USER principals.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 10)]
        public List<AccessGrantPrincipalAttribute> PrincipalAttributes { get; set; } = AWSConfigs.InitializeCollections ? new List<AccessGrantPrincipalAttribute>() : null;

        /// <summary>
        /// Checks to see if the PrincipalAttributes property is set.
        /// </summary>
        internal bool IsSetPrincipalAttributes() => this.PrincipalAttributes != null && (this.PrincipalAttributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PrincipalId. The ID of the principal receiving the grant.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string PrincipalId { get; set; }

        /// <summary>
        /// Checks to see if the PrincipalId property is set.
        /// </summary>
        internal bool IsSetPrincipalId() => this.PrincipalId != null;

        /// <summary>
        /// Gets and sets the property PrincipalType. The type of principal receiving the grant.
        /// </summary>
        [AWSProperty(Required = true)]
        public AccessGrantPrincipalType PrincipalType { get; set; }

        /// <summary>
        /// Checks to see if the PrincipalType property is set.
        /// </summary>
        internal bool IsSetPrincipalType() => this.PrincipalType != null;
    }
}
