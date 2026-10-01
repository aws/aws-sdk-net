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

namespace Amazon.SecurityIR.Model
{
    /// <summary>
    /// Container for the parameters to the BatchGetMemberAccountDetails operation. Provides
    /// information on whether the supplied account IDs are associated with a membership.
    /// <note> <para> AWS account ID's may appear less than 12 characters and need to be zero-prepended.
    /// An example would be <c>123123123</c> which is nine digits, and with zero-prepend would
    /// be <c>000123123123</c>. Not zero-prepending to 12 digits could result in errors. </para>
    /// </note>
    /// </summary>
    public partial class BatchGetMemberAccountDetailsRequest : AmazonSecurityIRRequest
    {
        /// <summary>
        /// Gets and sets the property AccountIds. 
        /// <para>
        /// Optional element to query the membership relationship status to a provided list of
        /// account IDs.
        /// </para>
        ///  <note> 
        /// <para>
        ///  AWS account ID's may appear less than 12 characters and need to be zero-prepended.
        /// An example would be <c>123123123</c> which is nine digits, and with zero-prepend would
        /// be <c>000123123123</c>. Not zero-prepending to 12 digits could result in errors. 
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public List<string> AccountIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AccountIds property is set.
        /// </summary>
        internal bool IsSetAccountIds() => this.AccountIds != null && (this.AccountIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MembershipId. 
        /// <para>
        /// Required element used in combination with BatchGetMemberAccountDetails to identify
        /// the membership ID to query. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 34)]
        public string MembershipId { get; set; }

        /// <summary>
        /// Checks to see if the MembershipId property is set.
        /// </summary>
        internal bool IsSetMembershipId() => this.MembershipId != null;
    }
}
