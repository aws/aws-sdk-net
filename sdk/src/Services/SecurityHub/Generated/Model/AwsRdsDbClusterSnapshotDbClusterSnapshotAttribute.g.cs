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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Contains the name and values of a manual Amazon Relational Database Service (RDS)
    /// DB cluster snapshot attribute.
    /// </summary>
    public partial class AwsRdsDbClusterSnapshotDbClusterSnapshotAttribute
    {
        /// <summary>
        /// Gets and sets the property AttributeName. 
        /// <para>
        ///  The name of the manual DB cluster snapshot attribute. The attribute named <c>restore</c>
        /// refers to the list of Amazon Web Services accounts that have permission to copy or
        /// restore the manual DB cluster snapshot. 
        /// </para>
        /// </summary>
        public string AttributeName { get; set; }

        /// <summary>
        /// Checks to see if the AttributeName property is set.
        /// </summary>
        internal bool IsSetAttributeName() => this.AttributeName != null;

        /// <summary>
        /// Gets and sets the property AttributeValues. 
        /// <para>
        ///  The value(s) for the manual DB cluster snapshot attribute. If the <c>AttributeName</c>
        /// field is set to <c>restore</c>, then this element returns a list of IDs of the Amazon
        /// Web Services accounts that are authorized to copy or restore the manual DB cluster
        /// snapshot. If a value of <c>all</c> is in the list, then the manual DB cluster snapshot
        /// is public and available for any Amazon Web Services account to copy or restore. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AttributeValues { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AttributeValues property is set.
        /// </summary>
        internal bool IsSetAttributeValues() => this.AttributeValues != null && (this.AttributeValues.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
