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
 * Do not modify this file. This file is generated from the rolesanywhere-2018-05-10.normal.json service model.
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
namespace Amazon.IAMRolesAnywhere.Model
{
    /// <summary>
    /// The state of the subject after a read or write operation.
    /// </summary>
    public partial class SubjectDetail
    {
        private DateTime? _createdAt;
        private List<CredentialSummary> _credentials = AWSConfigs.InitializeCollections ? new List<CredentialSummary>() : null;
        private bool? _enabled;
        private List<InstanceProperty> _instanceProperties = AWSConfigs.InitializeCollections ? new List<InstanceProperty>() : null;
        private DateTime? _lastSeenAt;
        private string _subjectArn;
        private string _subjectId;
        private DateTime? _updatedAt;
        private string _x509Subject;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The ISO-8601 timestamp when the subject was created. 
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Credentials. 
        /// <para>
        /// The temporary session credentials vended at the last authenticating call with this
        /// subject.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CredentialSummary> Credentials
        {
            get { return this._credentials; }
            set { this._credentials = value; }
        }

        // Check to see if Credentials property is set
        internal bool IsSetCredentials()
        {
            return this._credentials != null && (this._credentials.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// The enabled status of the subject.
        /// </para>
        /// </summary>
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceProperties. 
        /// <para>
        /// The specified instance properties associated with the request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InstanceProperty> InstanceProperties
        {
            get { return this._instanceProperties; }
            set { this._instanceProperties = value; }
        }

        // Check to see if InstanceProperties property is set
        internal bool IsSetInstanceProperties()
        {
            return this._instanceProperties != null && (this._instanceProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LastSeenAt. 
        /// <para>
        /// The ISO-8601 timestamp of the last time this subject requested temporary session credentials.
        /// </para>
        /// </summary>
        public DateTime? LastSeenAt
        {
            get { return this._lastSeenAt; }
            set { this._lastSeenAt = value; }
        }

        // Check to see if LastSeenAt property is set
        internal bool IsSetLastSeenAt()
        {
            return this._lastSeenAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SubjectArn. 
        /// <para>
        /// The ARN of the resource.
        /// </para>
        /// </summary>
        public string SubjectArn
        {
            get { return this._subjectArn; }
            set { this._subjectArn = value; }
        }

        // Check to see if SubjectArn property is set
        internal bool IsSetSubjectArn()
        {
            return this._subjectArn != null;
        }

        /// <summary>
        /// Gets and sets the property SubjectId. 
        /// <para>
        /// The id of the resource
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string SubjectId
        {
            get { return this._subjectId; }
            set { this._subjectId = value; }
        }

        // Check to see if SubjectId property is set
        internal bool IsSetSubjectId()
        {
            return this._subjectId != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The ISO-8601 timestamp when the subject was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property X509Subject. 
        /// <para>
        /// The x509 principal identifier of the authenticating certificate.
        /// </para>
        /// </summary>
        public string X509Subject
        {
            get { return this._x509Subject; }
            set { this._x509Subject = value; }
        }

        // Check to see if X509Subject property is set
        internal bool IsSetX509Subject()
        {
            return this._x509Subject != null;
        }

    }
}