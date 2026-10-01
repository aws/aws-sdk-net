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

namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// Provides information about a group associated with the principal.
    /// </summary>
    public partial class PrincipalGroup
    {
        /// <summary>
        /// Gets and sets the property Access. 
        /// <para>
        /// Provides information about whether to allow or deny access to the principal.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ReadAccessType Access { get; set; }

        /// <summary>
        /// Checks to see if the Access property is set.
        /// </summary>
        internal bool IsSetAccess() => this.Access != null;

        /// <summary>
        /// Gets and sets the property MembershipType. 
        /// <para>
        /// The type of group.
        /// </para>
        /// </summary>
        public MembershipType MembershipType { get; set; }

        /// <summary>
        /// Checks to see if the MembershipType property is set.
        /// </summary>
        internal bool IsSetMembershipType() => this.MembershipType != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
