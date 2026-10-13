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
    /// The representation of an organization.
    /// </summary>
    public partial class OrganizationSummary
    {
        /// <summary>
        /// Gets and sets the property Alias. 
        /// <para>
        /// The alias associated with the organization.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 62)]
        public string Alias { get; set; }

        /// <summary>
        /// Checks to see if the Alias property is set.
        /// </summary>
        internal bool IsSetAlias() => this.Alias != null;

        /// <summary>
        /// Gets and sets the property DefaultMailDomain. 
        /// <para>
        /// The default email domain associated with the organization.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 255)]
        public string DefaultMailDomain { get; set; }

        /// <summary>
        /// Checks to see if the DefaultMailDomain property is set.
        /// </summary>
        internal bool IsSetDefaultMailDomain() => this.DefaultMailDomain != null;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// The error message associated with the organization. It is only present if unexpected
        /// behavior has occurred with regards to the organization. It provides insight or solutions
        /// regarding unexpected behavior.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property OrganizationId. 
        /// <para>
        /// The identifier associated with the organization.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 34, Max = 34)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationId property is set.
        /// </summary>
        internal bool IsSetOrganizationId() => this.OrganizationId != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state associated with the organization.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
