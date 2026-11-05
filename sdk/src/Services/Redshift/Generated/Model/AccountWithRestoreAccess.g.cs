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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Describes an Amazon Web Services account authorized to restore a snapshot.
    /// </summary>
    public partial class AccountWithRestoreAccess
    {
        /// <summary>
        /// Gets and sets the property AccountAlias. 
        /// <para>
        /// The identifier of an Amazon Web Services support account authorized to restore a snapshot.
        /// For Amazon Web Services Support, the identifier is <c>amazon-redshift-support</c>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string AccountAlias { get; set; }

        /// <summary>
        /// Checks to see if the AccountAlias property is set.
        /// </summary>
        internal bool IsSetAccountAlias() => this.AccountAlias != null;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The identifier of an Amazon Web Services account authorized to restore a snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;
    }
}
