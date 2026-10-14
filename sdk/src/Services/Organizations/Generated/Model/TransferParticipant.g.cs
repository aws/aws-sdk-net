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

namespace Amazon.Organizations.Model
{
    /// <summary>
    /// Contains details for a participant in a transfer. A <i>transfer</i> is the arrangement
    /// between two management accounts where one account designates the other with specified
    /// responsibilities for their organization.
    /// </summary>
    public partial class TransferParticipant
    {
        /// <summary>
        /// Gets and sets the property ManagementAccountEmail. 
        /// <para>
        /// Email address for the management account.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 6, Max = 64)]
        public string ManagementAccountEmail { get; set; }

        /// <summary>
        /// Checks to see if the ManagementAccountEmail property is set.
        /// </summary>
        internal bool IsSetManagementAccountEmail() => this.ManagementAccountEmail != null;

        /// <summary>
        /// Gets and sets the property ManagementAccountId. 
        /// <para>
        /// ID for the management account.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 12)]
        public string ManagementAccountId { get; set; }

        /// <summary>
        /// Checks to see if the ManagementAccountId property is set.
        /// </summary>
        internal bool IsSetManagementAccountId() => this.ManagementAccountId != null;
    }
}
