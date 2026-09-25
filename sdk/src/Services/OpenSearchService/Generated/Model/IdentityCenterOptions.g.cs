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

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Settings container for integrating IAM Identity Center with OpenSearch UI applications,
    /// which enables enabling secure user authentication and access control across multiple
    /// data sources. This setup supports single sign-on (SSO) through IAM Identity Center,
    /// allowing centralized user management.
    /// </summary>
    public partial class IdentityCenterOptions
    {
        /// <summary>
        /// Gets and sets the property EnabledAPIAccess. 
        /// <para>
        /// Indicates whether IAM Identity Center is enabled for the application.
        /// </para>
        /// </summary>
        public bool? EnabledAPIAccess { get; set; }

        /// <summary>
        /// Checks to see if the EnabledAPIAccess property is set.
        /// </summary>
        internal bool IsSetEnabledAPIAccess() => this.EnabledAPIAccess.HasValue;

        /// <summary>
        /// Gets and sets the property IdentityCenterApplicationARN. 
        /// <para>
        /// The ARN of the IAM Identity Center application that integrates with Amazon OpenSearch
        /// Service.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string IdentityCenterApplicationARN { get; set; }

        /// <summary>
        /// Checks to see if the IdentityCenterApplicationARN property is set.
        /// </summary>
        internal bool IsSetIdentityCenterApplicationARN() => this.IdentityCenterApplicationARN != null;

        /// <summary>
        /// Gets and sets the property IdentityCenterInstanceARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM Identity Center instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string IdentityCenterInstanceARN { get; set; }

        /// <summary>
        /// Checks to see if the IdentityCenterInstanceARN property is set.
        /// </summary>
        internal bool IsSetIdentityCenterInstanceARN() => this.IdentityCenterInstanceARN != null;

        /// <summary>
        /// Gets and sets the property IdentityCenterInstanceRegion. 
        /// <para>
        /// The Region of the IAM Identity Center instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5, Max = 30)]
        public string IdentityCenterInstanceRegion { get; set; }

        /// <summary>
        /// Checks to see if the IdentityCenterInstanceRegion property is set.
        /// </summary>
        internal bool IsSetIdentityCenterInstanceRegion() => this.IdentityCenterInstanceRegion != null;

        /// <summary>
        /// Gets and sets the property IdentityStoreId. 
        /// <para>
        /// The identifier of the IAM Identity Store.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string IdentityStoreId { get; set; }

        /// <summary>
        /// Checks to see if the IdentityStoreId property is set.
        /// </summary>
        internal bool IsSetIdentityStoreId() => this.IdentityStoreId != null;

        /// <summary>
        /// Gets and sets the property RolesKey. 
        /// <para>
        /// Specifies the attribute that contains the backend role identifier (such as group name
        /// or group ID) in IAM Identity Center.
        /// </para>
        /// </summary>
        public RolesKeyIdCOption RolesKey { get; set; }

        /// <summary>
        /// Checks to see if the RolesKey property is set.
        /// </summary>
        internal bool IsSetRolesKey() => this.RolesKey != null;

        /// <summary>
        /// Gets and sets the property SubjectKey. 
        /// <para>
        /// Specifies the attribute that contains the subject identifier (such as username, user
        /// ID, or email) in IAM Identity Center.
        /// </para>
        /// </summary>
        public SubjectKeyIdCOption SubjectKey { get; set; }

        /// <summary>
        /// Checks to see if the SubjectKey property is set.
        /// </summary>
        internal bool IsSetSubjectKey() => this.SubjectKey != null;
    }
}
