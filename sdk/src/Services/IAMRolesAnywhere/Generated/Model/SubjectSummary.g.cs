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

namespace Amazon.IAMRolesAnywhere.Model
{
    /// <summary>
    /// A summary representation of subjects.
    /// </summary>
    public partial class SubjectSummary
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The ISO-8601 time stamp of when the certificate was first used in a temporary credential
        /// request.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// The enabled status of the subject. 
        /// </para>
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property LastSeenAt. 
        /// <para>
        /// The ISO-8601 time stamp of when the certificate was last used in a temporary credential
        /// request.
        /// </para>
        /// </summary>
        public DateTime? LastSeenAt { get; set; }

        /// <summary>
        /// Checks to see if the LastSeenAt property is set.
        /// </summary>
        internal bool IsSetLastSeenAt() => this.LastSeenAt.HasValue;

        /// <summary>
        /// Gets and sets the property SubjectArn. 
        /// <para>
        /// The ARN of the resource.
        /// </para>
        /// </summary>
        public string SubjectArn { get; set; }

        /// <summary>
        /// Checks to see if the SubjectArn property is set.
        /// </summary>
        internal bool IsSetSubjectArn() => this.SubjectArn != null;

        /// <summary>
        /// Gets and sets the property SubjectId. 
        /// <para>
        /// The id of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string SubjectId { get; set; }

        /// <summary>
        /// Checks to see if the SubjectId property is set.
        /// </summary>
        internal bool IsSetSubjectId() => this.SubjectId != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The ISO-8601 timestamp when the subject was last updated. 
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property X509Subject. 
        /// <para>
        /// The x509 principal identifier of the authenticating certificate.
        /// </para>
        /// </summary>
        public string X509Subject { get; set; }

        /// <summary>
        /// Checks to see if the X509Subject property is set.
        /// </summary>
        internal bool IsSetX509Subject() => this.X509Subject != null;
    }
}
