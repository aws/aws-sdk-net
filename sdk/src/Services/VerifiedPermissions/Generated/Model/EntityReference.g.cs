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

namespace Amazon.VerifiedPermissions.Model
{
    /// <summary>
    /// Contains information about a principal or resource that can be referenced in a Cedar
    /// policy.
    /// 
    ///  
    /// <para>
    /// This data type is used as part of the <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_PolicyFilter.html">PolicyFilter</a>
    /// structure that is used as a request parameter for the <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_ListPolicies.html">ListPolicies</a>
    /// operation..
    /// </para>
    /// </summary>
    public partial class EntityReference
    {
        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The identifier of the entity. It can consist of either an EntityType and EntityId,
        /// a principal, or a resource.
        /// </para>
        /// </summary>
        public EntityIdentifier Identifier { get; set; }

        /// <summary>
        /// Checks to see if the Identifier property is set.
        /// </summary>
        internal bool IsSetIdentifier() => this.Identifier != null;

        /// <summary>
        /// Gets and sets the property Unspecified. 
        /// <para>
        /// Used to indicate that a principal or resource is not specified. This can be used to
        /// search for policies that are not associated with a specific principal or resource.
        /// </para>
        /// </summary>
        public bool? Unspecified { get; set; }

        /// <summary>
        /// Checks to see if the Unspecified property is set.
        /// </summary>
        internal bool IsSetUnspecified() => this.Unspecified.HasValue;
    }
}
