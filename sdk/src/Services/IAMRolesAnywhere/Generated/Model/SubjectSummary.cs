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
    /// A summary representation of subjects.
    /// </summary>
    public partial class SubjectSummary
    {
        private DateTime? _createdAt;
        private bool? _enabled;
        private DateTime? _lastSeenAt;
        private string _subjectArn;
        private string _subjectId;
        private DateTime? _updatedAt;
        private string _x509Subject;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The ISO-8601 time stamp of when the certificate was first used in a temporary credential
        /// request.
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
        /// Gets and sets the property LastSeenAt. 
        /// <para>
        /// The ISO-8601 time stamp of when the certificate was last used in a temporary credential
        /// request.
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
        /// The id of the resource.
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