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

namespace Amazon.PcaConnectorAd.Model
{
    /// <summary>
    /// Summary of group access control entries that allow or deny Active Directory groups
    /// based on their security identifiers (SIDs) from enrolling and/or autofenrolling with
    /// the template.
    /// </summary>
    public partial class AccessControlEntrySummary
    {
        /// <summary>
        /// Gets and sets the property AccessRights. 
        /// <para>
        /// Allow or deny an Active Directory group from enrolling and autoenrolling certificates
        /// issued against a template.
        /// </para>
        /// </summary>
        public AccessRights AccessRights { get; set; }

        /// <summary>
        /// Checks to see if the AccessRights property is set.
        /// </summary>
        internal bool IsSetAccessRights() => this.AccessRights != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time that the Access Control Entry was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property GroupDisplayName. 
        /// <para>
        /// Name of the Active Directory group. This name does not need to match the group name
        /// in Active Directory.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string GroupDisplayName { get; set; }

        /// <summary>
        /// Checks to see if the GroupDisplayName property is set.
        /// </summary>
        internal bool IsSetGroupDisplayName() => this.GroupDisplayName != null;

        /// <summary>
        /// Gets and sets the property GroupSecurityIdentifier. 
        /// <para>
        /// Security identifier (SID) of the group object from Active Directory. The SID starts
        /// with "S-".
        /// </para>
        /// </summary>
        [AWSProperty(Min = 7, Max = 256)]
        public string GroupSecurityIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the GroupSecurityIdentifier property is set.
        /// </summary>
        internal bool IsSetGroupSecurityIdentifier() => this.GroupSecurityIdentifier != null;

        /// <summary>
        /// Gets and sets the property TemplateArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that was returned when you called <a href="https://docs.aws.amazon.com/pca-connector-ad/latest/APIReference/API_CreateTemplate.html">CreateTemplate</a>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5, Max = 200)]
        public string TemplateArn { get; set; }

        /// <summary>
        /// Checks to see if the TemplateArn property is set.
        /// </summary>
        internal bool IsSetTemplateArn() => this.TemplateArn != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time that the Access Control Entry was updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
