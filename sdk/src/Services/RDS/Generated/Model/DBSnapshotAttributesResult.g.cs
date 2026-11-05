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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Contains the results of a successful call to the <c>DescribeDBSnapshotAttributes</c>
    /// API action.
    /// 
    ///  
    /// <para>
    /// Manual DB snapshot attributes are used to authorize other Amazon Web Services accounts
    /// to copy or restore a manual DB snapshot. For more information, see the <c>ModifyDBSnapshotAttribute</c>
    /// API action.
    /// </para>
    /// </summary>
    public partial class DBSnapshotAttributesResult
    {
        /// <summary>
        /// Gets and sets the property DBSnapshotAttributes. 
        /// <para>
        /// The list of attributes and values for the manual DB snapshot.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DBSnapshotAttribute> DBSnapshotAttributes { get; set; } = AWSConfigs.InitializeCollections ? new List<DBSnapshotAttribute>() : null;

        /// <summary>
        /// Checks to see if the DBSnapshotAttributes property is set.
        /// </summary>
        internal bool IsSetDBSnapshotAttributes() => this.DBSnapshotAttributes != null && (this.DBSnapshotAttributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DBSnapshotIdentifier. 
        /// <para>
        /// The identifier of the manual DB snapshot that the attributes apply to.
        /// </para>
        /// </summary>
        public string DBSnapshotIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DBSnapshotIdentifier property is set.
        /// </summary>
        internal bool IsSetDBSnapshotIdentifier() => this.DBSnapshotIdentifier != null;
    }
}
