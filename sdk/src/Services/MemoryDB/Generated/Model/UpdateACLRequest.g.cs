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

namespace Amazon.MemoryDB.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateACL operation. Changes the list of users
    /// that belong to the Access Control List.
    /// </summary>
    public partial class UpdateACLRequest : AmazonMemoryDBRequest
    {
        /// <summary>
        /// Gets and sets the property ACLName. 
        /// <para>
        /// The name of the Access Control List.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ACLName { get; set; }

        /// <summary>
        /// Checks to see if the ACLName property is set.
        /// </summary>
        internal bool IsSetACLName() => this.ACLName != null;

        /// <summary>
        /// Gets and sets the property UserNamesToAdd. 
        /// <para>
        /// The list of users to add to the Access Control List.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<string> UserNamesToAdd { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the UserNamesToAdd property is set.
        /// </summary>
        internal bool IsSetUserNamesToAdd() => this.UserNamesToAdd != null && (this.UserNamesToAdd.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UserNamesToRemove. 
        /// <para>
        /// The list of users to remove from the Access Control List.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<string> UserNamesToRemove { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the UserNamesToRemove property is set.
        /// </summary>
        internal bool IsSetUserNamesToRemove() => this.UserNamesToRemove != null && (this.UserNamesToRemove.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
