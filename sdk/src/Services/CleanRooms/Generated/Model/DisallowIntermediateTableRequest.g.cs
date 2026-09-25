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

namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Container for the parameters to the DisallowIntermediateTable operation. Marks an
    /// intermediate table as invalid when it references the caller's base table. The data
    /// provider (base table owner) calls this operation, not the intermediate table owner.
    /// By default, the operation also marks all descendant intermediate tables as invalid.
    /// </summary>
    public partial class DisallowIntermediateTableRequest : AmazonCleanRoomsRequest
    {
        /// <summary>
        /// Gets and sets the property IncludeDescendants. 
        /// <para>
        /// Specifies whether to cascade the disallow action to descendant intermediate tables.
        /// Default is <c>true</c>.
        /// </para>
        /// </summary>
        public bool? IncludeDescendants { get; set; }

        /// <summary>
        /// Checks to see if the IncludeDescendants property is set.
        /// </summary>
        internal bool IsSetIncludeDescendants() => this.IncludeDescendants.HasValue;

        /// <summary>
        /// Gets and sets the property IntermediateTableName. 
        /// <para>
        /// The name of the intermediate table to disallow.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string IntermediateTableName { get; set; }

        /// <summary>
        /// Checks to see if the IntermediateTableName property is set.
        /// </summary>
        internal bool IsSetIntermediateTableName() => this.IntermediateTableName != null;

        /// <summary>
        /// Gets and sets the property MembershipIdentifier. 
        /// <para>
        /// The unique identifier of the membership that contains the intermediate table to disallow.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string MembershipIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the MembershipIdentifier property is set.
        /// </summary>
        internal bool IsSetMembershipIdentifier() => this.MembershipIdentifier != null;
    }
}
