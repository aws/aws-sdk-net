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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
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
    /// Container for the parameters to the DisallowIntermediateTable operation.
    /// Invalidates a specific intermediate table that references the caller's base table.
    /// The data provider (base table owner) calls this operation, not the intermediate table
    /// owner. By default, invalidation cascades to descendant intermediate tables.
    /// </summary>
    public partial class DisallowIntermediateTableRequest : AmazonCleanRoomsRequest
    {
        private bool? _includeDescendants;
        private string _intermediateTableName;
        private string _membershipIdentifier;

        /// <summary>
        /// Gets and sets the property IncludeDescendants. 
        /// <para>
        /// Specifies whether to cascade the disallow action to descendant intermediate tables.
        /// Default is <c>true</c>.
        /// </para>
        /// </summary>
        public bool? IncludeDescendants
        {
            get { return this._includeDescendants; }
            set { this._includeDescendants = value; }
        }

        // Check to see if IncludeDescendants property is set
        internal bool IsSetIncludeDescendants()
        {
            return this._includeDescendants.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IntermediateTableName. 
        /// <para>
        /// The name of the intermediate table to disallow.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string IntermediateTableName
        {
            get { return this._intermediateTableName; }
            set { this._intermediateTableName = value; }
        }

        // Check to see if IntermediateTableName property is set
        internal bool IsSetIntermediateTableName()
        {
            return this._intermediateTableName != null;
        }

        /// <summary>
        /// Gets and sets the property MembershipIdentifier. 
        /// <para>
        /// The unique identifier of the membership that contains the intermediate table to disallow.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string MembershipIdentifier
        {
            get { return this._membershipIdentifier; }
            set { this._membershipIdentifier = value; }
        }

        // Check to see if MembershipIdentifier property is set
        internal bool IsSetMembershipIdentifier()
        {
            return this._membershipIdentifier != null;
        }

    }
}