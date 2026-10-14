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
    /// An impersonation role for the given WorkMail organization.
    /// </summary>
    public partial class ImpersonationRole
    {
        /// <summary>
        /// Gets and sets the property DateCreated. 
        /// <para>
        /// The date when the impersonation role was created.
        /// </para>
        /// </summary>
        public DateTime? DateCreated { get; set; }

        /// <summary>
        /// Checks to see if the DateCreated property is set.
        /// </summary>
        internal bool IsSetDateCreated() => this.DateCreated.HasValue;

        /// <summary>
        /// Gets and sets the property DateModified. 
        /// <para>
        /// The date when the impersonation role was last modified.
        /// </para>
        /// </summary>
        public DateTime? DateModified { get; set; }

        /// <summary>
        /// Checks to see if the DateModified property is set.
        /// </summary>
        internal bool IsSetDateModified() => this.DateModified.HasValue;

        /// <summary>
        /// Gets and sets the property ImpersonationRoleId. 
        /// <para>
        /// The identifier of the impersonation role.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ImpersonationRoleId { get; set; }

        /// <summary>
        /// Checks to see if the ImpersonationRoleId property is set.
        /// </summary>
        internal bool IsSetImpersonationRoleId() => this.ImpersonationRoleId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The impersonation role name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The impersonation role type.
        /// </para>
        /// </summary>
        public ImpersonationRoleType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
