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

namespace Amazon.WorkMail.Model
{
    /// <summary>
    /// Filtering options for <i>ListUsers</i> operation. This is only used as input to Operation.
    /// </summary>
    public partial class ListUsersFilters
    {
        /// <summary>
        /// Gets and sets the property DisplayNamePrefix. 
        /// <para>
        /// Filters only users with the provided display name prefix.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 256)]
        public string DisplayNamePrefix { get; set; }

        /// <summary>
        /// Checks to see if the DisplayNamePrefix property is set.
        /// </summary>
        internal bool IsSetDisplayNamePrefix() => this.DisplayNamePrefix != null;

        /// <summary>
        /// Gets and sets the property IdentityProviderUserIdPrefix. 
        /// <para>
        /// Filters only users with the ID from the IAM Identity Center.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 47)]
        public string IdentityProviderUserIdPrefix { get; set; }

        /// <summary>
        /// Checks to see if the IdentityProviderUserIdPrefix property is set.
        /// </summary>
        internal bool IsSetIdentityProviderUserIdPrefix() => this.IdentityProviderUserIdPrefix != null;

        /// <summary>
        /// Gets and sets the property PrimaryEmailPrefix. 
        /// <para>
        /// Filters only users with the provided email prefix.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string PrimaryEmailPrefix { get; set; }

        /// <summary>
        /// Checks to see if the PrimaryEmailPrefix property is set.
        /// </summary>
        internal bool IsSetPrimaryEmailPrefix() => this.PrimaryEmailPrefix != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// Filters only users with the provided state.
        /// </para>
        /// </summary>
        public EntityState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property UsernamePrefix. 
        /// <para>
        /// Filters only users with the provided username prefix.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string UsernamePrefix { get; set; }

        /// <summary>
        /// Checks to see if the UsernamePrefix property is set.
        /// </summary>
        internal bool IsSetUsernamePrefix() => this.UsernamePrefix != null;
    }
}
