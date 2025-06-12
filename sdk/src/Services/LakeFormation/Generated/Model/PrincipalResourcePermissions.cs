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
 * Do not modify this file. This file is generated from the lakeformation-2017-03-31.normal.json service model.
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
        private DetailsMap _additionalDetails;
        private Condition _condition;
        private DateTime? _lastUpdated;
        private string _lastUpdatedBy;
        private List<string> _permissions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _permissionsWithGrantOption = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DataLakePrincipal _principal;
        private Resource _resource;

        /// <summary>
        /// Gets and sets the property AdditionalDetails. 
        /// <para>
        /// This attribute can be used to return any additional details of <c>PrincipalResourcePermissions</c>.
        /// Currently returns only as a RAM resource share ARN.
        /// </para>
        /// </summary>
        public DetailsMap AdditionalDetails
        {
            get { return this._additionalDetails; }
            set { this._additionalDetails = value; }
        }

        // Check to see if AdditionalDetails property is set
        internal bool IsSetAdditionalDetails()
        {
            return this._additionalDetails != null;
        }

        /// <summary>
        /// Gets and sets the property Condition. 
        /// <para>
        /// A Lake Formation condition, which applies to permissions and opt-ins that contain
        /// an expression.
        /// </para>
        /// </summary>
        public Condition Condition
        {
            get { return this._condition; }
            set { this._condition = value; }
        }

        // Check to see if Condition property is set
        internal bool IsSetCondition()
        {
            return this._condition != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdated. 
        /// <para>
        /// The date and time when the resource was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdated
        {
            get { return this._lastUpdated; }
            set { this._lastUpdated = value; }
        }

        // Check to see if LastUpdated property is set
        internal bool IsSetLastUpdated()
        {
            return this._lastUpdated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedBy. 
        /// <para>
        /// The user who updated the record.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string LastUpdatedBy
        {
            get { return this._lastUpdatedBy; }
            set { this._lastUpdatedBy = value; }
        }

        // Check to see if LastUpdatedBy property is set
        internal bool IsSetLastUpdatedBy()
        {
            return this._lastUpdatedBy != null;
        }

        /// <summary>
        /// Gets and sets the property Permissions. 
        /// <para>
        /// The permissions to be granted or revoked on the resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Permissions
        {
            get { return this._permissions; }
            set { this._permissions = value; }
        }

        // Check to see if Permissions property is set
        internal bool IsSetPermissions()
        {
            return this._permissions != null && (this._permissions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PermissionsWithGrantOption. 
        /// <para>
        /// Indicates whether to grant the ability to grant permissions (as a subset of permissions
        /// granted).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PermissionsWithGrantOption
        {
            get { return this._permissionsWithGrantOption; }
            set { this._permissionsWithGrantOption = value; }
        }

        // Check to see if PermissionsWithGrantOption property is set
        internal bool IsSetPermissionsWithGrantOption()
        {
            return this._permissionsWithGrantOption != null && (this._permissionsWithGrantOption.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Principal. 
        /// <para>
        /// The Data Lake principal to be granted or revoked permissions.
        /// </para>
        /// </summary>
        public DataLakePrincipal Principal
        {
            get { return this._principal; }
            set { this._principal = value; }
        }

        // Check to see if Principal property is set
        internal bool IsSetPrincipal()
        {
            return this._principal != null;
        }

        /// <summary>
        /// Gets and sets the property Resource. 
        /// <para>
        /// The resource where permissions are to be granted or revoked.
        /// </para>
        /// </summary>
        public Resource Resource
        {
            get { return this._resource; }
            set { this._resource = value; }
        }

        // Check to see if Resource property is set
        internal bool IsSetResource()
        {
            return this._resource != null;
        }

    }
}