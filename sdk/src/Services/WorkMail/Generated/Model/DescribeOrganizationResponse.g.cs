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
    /// This is the response object from the DescribeOrganization operation.
    /// </summary>
    public partial class DescribeOrganizationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the organization.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1011)]
        public string ARN { get; set; }

        /// <summary>
        /// Checks to see if the ARN property is set.
        /// </summary>
        internal bool IsSetARN() => this.ARN != null;

        /// <summary>
        /// Gets and sets the property Alias. 
        /// <para>
        /// The alias for an organization.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 62)]
        public string Alias { get; set; }

        /// <summary>
        /// Checks to see if the Alias property is set.
        /// </summary>
        internal bool IsSetAlias() => this.Alias != null;

        /// <summary>
        /// Gets and sets the property CompletedDate. 
        /// <para>
        /// The date at which the organization became usable in the WorkMail context, in UNIX
        /// epoch time format.
        /// </para>
        /// </summary>
        public DateTime? CompletedDate { get; set; }

        /// <summary>
        /// Checks to see if the CompletedDate property is set.
        /// </summary>
        internal bool IsSetCompletedDate() => this.CompletedDate.HasValue;

        /// <summary>
        /// Gets and sets the property DefaultMailDomain. 
        /// <para>
        /// The default mail domain associated with the organization.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string DefaultMailDomain { get; set; }

        /// <summary>
        /// Checks to see if the DefaultMailDomain property is set.
        /// </summary>
        internal bool IsSetDefaultMailDomain() => this.DefaultMailDomain != null;

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// The identifier for the directory associated with an WorkMail organization.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// Checks to see if the DirectoryId property is set.
        /// </summary>
        internal bool IsSetDirectoryId() => this.DirectoryId != null;

        /// <summary>
        /// Gets and sets the property DirectoryType. 
        /// <para>
        /// The type of directory associated with the WorkMail organization.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string DirectoryType { get; set; }

        /// <summary>
        /// Checks to see if the DirectoryType property is set.
        /// </summary>
        internal bool IsSetDirectoryType() => this.DirectoryType != null;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// (Optional) The error message indicating if unexpected behavior was encountered with
        /// regards to the organization.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property InteroperabilityEnabled. 
        /// <para>
        /// Indicates if interoperability is enabled for this organization.
        /// </para>
        /// </summary>
        public bool? InteroperabilityEnabled { get; set; }

        /// <summary>
        /// Checks to see if the InteroperabilityEnabled property is set.
        /// </summary>
        internal bool IsSetInteroperabilityEnabled() => this.InteroperabilityEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property MigrationAdmin. 
        /// <para>
        /// The user ID of the migration admin if migration is enabled for the organization.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 256)]
        public string MigrationAdmin { get; set; }

        /// <summary>
        /// Checks to see if the MigrationAdmin property is set.
        /// </summary>
        internal bool IsSetMigrationAdmin() => this.MigrationAdmin != null;

        /// <summary>
        /// Gets and sets the property OrganizationId. 
        /// <para>
        /// The identifier of an organization.
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
        /// The state of an organization.
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
