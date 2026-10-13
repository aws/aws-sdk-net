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

namespace Amazon.IdentityStore.Model
{
    /// <summary>
    /// A group object that contains the metadata and attributes for a specified group.
    /// </summary>
    public partial class Group
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time the group was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The identifier of the user or system that created the group.
        /// </para>
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A string containing a description of the specified group.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The display name value for the group. The length limit is 1,024 characters. This value
        /// can consist of letters, accented characters, symbols, numbers, punctuation, tab, new
        /// line, carriage return, space, and nonbreaking space in this attribute. This value
        /// is specified at the time the group is created and stored as an attribute of the group
        /// object in the identity store.
        /// </para>
        ///  
        /// <para>
        /// Prefix search supports a maximum of 1,000 characters for the string.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 1024)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property ExternalIds. 
        /// <para>
        /// A list of <c>ExternalId</c> objects that contains the identifiers issued to this resource
        /// by an external identity provider.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<ExternalId> ExternalIds { get; set; } = AWSConfigs.InitializeCollections ? new List<ExternalId>() : null;

        /// <summary>
        /// Checks to see if the ExternalIds property is set.
        /// </summary>
        internal bool IsSetExternalIds() => this.ExternalIds != null && (this.ExternalIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the group in the identity store. For example, <c>arn:aws:identitystore:::group/a1b2c3d4-5678-90ab-cdef-EXAMPLE22222</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 60, Max = 100)]
        public string GroupArn { get; set; }

        /// <summary>
        /// Checks to see if the GroupArn property is set.
        /// </summary>
        internal bool IsSetGroupArn() => this.GroupArn != null;

        /// <summary>
        /// Gets and sets the property GroupId. 
        /// <para>
        /// The identifier for a group in the identity store.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string GroupId { get; set; }

        /// <summary>
        /// Checks to see if the GroupId property is set.
        /// </summary>
        internal bool IsSetGroupId() => this.GroupId != null;

        /// <summary>
        /// Gets and sets the property IdentityStoreId. 
        /// <para>
        /// The globally unique identifier for the identity store.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 93)]
        public string IdentityStoreId { get; set; }

        /// <summary>
        /// Checks to see if the IdentityStoreId property is set.
        /// </summary>
        internal bool IsSetIdentityStoreId() => this.IdentityStoreId != null;

        /// <summary>
        /// Gets and sets the property Revision. 
        /// <para>
        /// The current revision of the group in the identity store. This value changes each time
        /// the group is modified. You can provide it as the <c>Revision</c> parameter of an <c>UpdateGroup</c>
        /// or <c>DeleteGroup</c> request to make the operation conditional on the group not having
        /// changed. Treat this value as an opaque token: don't parse it or rely on its format
        /// or ordering.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Revision { get; set; }

        /// <summary>
        /// Checks to see if the Revision property is set.
        /// </summary>
        internal bool IsSetRevision() => this.Revision != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time the group was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property UpdatedBy. 
        /// <para>
        /// The identifier of the user or system that last updated the group.
        /// </para>
        /// </summary>
        public string UpdatedBy { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedBy property is set.
        /// </summary>
        internal bool IsSetUpdatedBy() => this.UpdatedBy != null;
    }
}
