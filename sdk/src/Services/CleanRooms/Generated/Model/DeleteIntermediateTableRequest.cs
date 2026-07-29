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
    /// Container for the parameters to the DeleteIntermediateTable operation.
    /// Deletes an intermediate table. When you delete the table, the service marks it as
    /// DELETED, removes its analysis rule and schema, and triggers storage cleanup. This
    /// operation is idempotent. Only the intermediate table owner can call this operation.
    /// </summary>
    public partial class DeleteIntermediateTableRequest : AmazonCleanRoomsRequest
    {
        private string _intermediateTableIdentifier;
        private string _membershipIdentifier;

        /// <summary>
        /// Gets and sets the property IntermediateTableIdentifier. 
        /// <para>
        /// The unique identifier of the intermediate table to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string IntermediateTableIdentifier
        {
            get { return this._intermediateTableIdentifier; }
            set { this._intermediateTableIdentifier = value; }
        }

        // Check to see if IntermediateTableIdentifier property is set
        internal bool IsSetIntermediateTableIdentifier()
        {
            return this._intermediateTableIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property MembershipIdentifier. 
        /// <para>
        /// The unique identifier of the membership that contains the intermediate table.
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