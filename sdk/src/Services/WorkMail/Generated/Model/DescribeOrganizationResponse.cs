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
 * Do not modify this file. This file is generated from the workmail-2017-10-01.normal.json service model.
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
        private string _alias;
        private string _arn;
        private DateTime? _completedDate;
        private string _defaultMailDomain;
        private string _directoryId;
        private string _directoryType;
        private string _errorMessage;
        private bool? _interoperabilityEnabled;
        private string _migrationAdmin;
        private string _organizationId;
        private string _state;

        /// <summary>
        /// Gets and sets the property Alias. 
        /// <para>
        /// The alias for an organization.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=62)]
        public string Alias
        {
            get { return this._alias; }
            set { this._alias = value; }
        }

        // Check to see if Alias property is set
        internal bool IsSetAlias()
        {
            return this._alias != null;
        }

        /// <summary>
        /// Gets and sets the property ARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the organization.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1011)]
        public string ARN
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if ARN property is set
        internal bool IsSetARN()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CompletedDate. 
        /// <para>
        /// The date at which the organization became usable in the WorkMail context, in UNIX
        /// epoch time format.
        /// </para>
        /// </summary>
        public DateTime? CompletedDate
        {
            get { return this._completedDate; }
            set { this._completedDate = value; }
        }

        // Check to see if CompletedDate property is set
        internal bool IsSetCompletedDate()
        {
            return this._completedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DefaultMailDomain. 
        /// <para>
        /// The default mail domain associated with the organization.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string DefaultMailDomain
        {
            get { return this._defaultMailDomain; }
            set { this._defaultMailDomain = value; }
        }

        // Check to see if DefaultMailDomain property is set
        internal bool IsSetDefaultMailDomain()
        {
            return this._defaultMailDomain != null;
        }

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// The identifier for the directory associated with an WorkMail organization.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string DirectoryId
        {
            get { return this._directoryId; }
            set { this._directoryId = value; }
        }

        // Check to see if DirectoryId property is set
        internal bool IsSetDirectoryId()
        {
            return this._directoryId != null;
        }

        /// <summary>
        /// Gets and sets the property DirectoryType. 
        /// <para>
        /// The type of directory associated with the WorkMail organization.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string DirectoryType
        {
            get { return this._directoryType; }
            set { this._directoryType = value; }
        }

        // Check to see if DirectoryType property is set
        internal bool IsSetDirectoryType()
        {
            return this._directoryType != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// (Optional) The error message indicating if unexpected behavior was encountered with
        /// regards to the organization.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property InteroperabilityEnabled. 
        /// <para>
        /// Indicates if interoperability is enabled for this organization.
        /// </para>
        /// </summary>
        public bool? InteroperabilityEnabled
        {
            get { return this._interoperabilityEnabled; }
            set { this._interoperabilityEnabled = value; }
        }

        // Check to see if InteroperabilityEnabled property is set
        internal bool IsSetInteroperabilityEnabled()
        {
            return this._interoperabilityEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MigrationAdmin. 
        /// <para>
        /// The user ID of the migration admin if migration is enabled for the organization.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=256)]
        public string MigrationAdmin
        {
            get { return this._migrationAdmin; }
            set { this._migrationAdmin = value; }
        }

        // Check to see if MigrationAdmin property is set
        internal bool IsSetMigrationAdmin()
        {
            return this._migrationAdmin != null;
        }

        /// <summary>
        /// Gets and sets the property OrganizationId. 
        /// <para>
        /// The identifier of an organization.
        /// </para>
        /// </summary>
        [AWSProperty(Min=34, Max=34)]
        public string OrganizationId
        {
            get { return this._organizationId; }
            set { this._organizationId = value; }
        }

        // Check to see if OrganizationId property is set
        internal bool IsSetOrganizationId()
        {
            return this._organizationId != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of an organization.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}