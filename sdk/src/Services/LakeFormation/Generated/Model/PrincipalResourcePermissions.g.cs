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

namespace Amazon.LakeFormation.Model
{
    /// <summary>
    /// The permissions granted or revoked on a resource.
    /// </summary>
    public partial class PrincipalResourcePermissions
    {
        /// <summary>
        /// Gets and sets the property AdditionalDetails. 
        /// <para>
        /// This attribute can be used to return any additional details of <c>PrincipalResourcePermissions</c>.
        /// Currently returns only as a RAM resource share ARN.
        /// </para>
        /// </summary>
        public DetailsMap AdditionalDetails { get; set; }

        /// <summary>
        /// Checks to see if the AdditionalDetails property is set.
        /// </summary>
        internal bool IsSetAdditionalDetails() => this.AdditionalDetails != null;

        /// <summary>
        /// Gets and sets the property Condition. 
        /// <para>
        /// A Lake Formation condition, which applies to permissions and opt-ins that contain
        /// an expression.
        /// </para>
        /// </summary>
        public Condition Condition { get; set; }

        /// <summary>
        /// Checks to see if the Condition property is set.
        /// </summary>
        internal bool IsSetCondition() => this.Condition != null;

        /// <summary>
        /// Gets and sets the property LastUpdated. 
        /// <para>
        /// The date and time when the resource was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdated { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdated property is set.
        /// </summary>
        internal bool IsSetLastUpdated() => this.LastUpdated.HasValue;

        /// <summary>
        /// Gets and sets the property LastUpdatedBy. 
        /// <para>
        /// The user who updated the record.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string LastUpdatedBy { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedBy property is set.
        /// </summary>
        internal bool IsSetLastUpdatedBy() => this.LastUpdatedBy != null;

        /// <summary>
        /// Gets and sets the property Permissions. 
        /// <para>
        /// The permissions to be granted or revoked on the resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Permissions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Permissions property is set.
        /// </summary>
        internal bool IsSetPermissions() => this.Permissions != null && (this.Permissions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PermissionsWithGrantOption. 
        /// <para>
        /// Indicates whether to grant the ability to grant permissions (as a subset of permissions
        /// granted).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PermissionsWithGrantOption { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PermissionsWithGrantOption property is set.
        /// </summary>
        internal bool IsSetPermissionsWithGrantOption() => this.PermissionsWithGrantOption != null && (this.PermissionsWithGrantOption.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Principal. 
        /// <para>
        /// The Data Lake principal to be granted or revoked permissions.
        /// </para>
        /// </summary>
        public DataLakePrincipal Principal { get; set; }

        /// <summary>
        /// Checks to see if the Principal property is set.
        /// </summary>
        internal bool IsSetPrincipal() => this.Principal != null;

        /// <summary>
        /// Gets and sets the property Resource. 
        /// <para>
        /// The resource where permissions are to be granted or revoked.
        /// </para>
        /// </summary>
        public Resource Resource { get; set; }

        /// <summary>
        /// Checks to see if the Resource property is set.
        /// </summary>
        internal bool IsSetResource() => this.Resource != null;
    }
}
