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

namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Information about about the account link.
    /// </summary>
    public partial class AccountLink
    {
        /// <summary>
        /// Gets and sets the property AccountLinkId. 
        /// <para>
        /// The identifier of the account link.
        /// </para>
        /// </summary>
        public string AccountLinkId { get; set; }

        /// <summary>
        /// Checks to see if the AccountLinkId property is set.
        /// </summary>
        internal bool IsSetAccountLinkId() => this.AccountLinkId != null;

        /// <summary>
        /// Gets and sets the property AccountLinkStatus. 
        /// <para>
        /// The status of the account link.
        /// </para>
        /// </summary>
        public AccountLinkStatusEnum AccountLinkStatus { get; set; }

        /// <summary>
        /// Checks to see if the AccountLinkStatus property is set.
        /// </summary>
        internal bool IsSetAccountLinkStatus() => this.AccountLinkStatus != null;

        /// <summary>
        /// Gets and sets the property SourceAccountId. 
        /// <para>
        /// The identifier of the source account.
        /// </para>
        /// </summary>
        public string SourceAccountId { get; set; }

        /// <summary>
        /// Checks to see if the SourceAccountId property is set.
        /// </summary>
        internal bool IsSetSourceAccountId() => this.SourceAccountId != null;

        /// <summary>
        /// Gets and sets the property TargetAccountId. 
        /// <para>
        /// The identifier of the target account.
        /// </para>
        /// </summary>
        public string TargetAccountId { get; set; }

        /// <summary>
        /// Checks to see if the TargetAccountId property is set.
        /// </summary>
        internal bool IsSetTargetAccountId() => this.TargetAccountId != null;
    }
}
