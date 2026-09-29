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
    /// The state of the subject after a read or write operation.
    /// </summary>
    public partial class SubjectDetail
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The ISO-8601 timestamp when the subject was created. 
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Credentials. 
        /// <para>
        /// The temporary session credentials vended at the last authenticating call with this
        /// subject.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CredentialSummary> Credentials { get; set; } = AWSConfigs.InitializeCollections ? new List<CredentialSummary>() : null;

        /// <summary>
        /// Checks to see if the Credentials property is set.
        /// </summary>
        internal bool IsSetCredentials() => this.Credentials != null && (this.Credentials.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Gets and sets the property InstanceProperties. 
        /// <para>
        /// The specified instance properties associated with the request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InstanceProperty> InstanceProperties { get; set; } = AWSConfigs.InitializeCollections ? new List<InstanceProperty>() : null;

        /// <summary>
        /// Checks to see if the InstanceProperties property is set.
        /// </summary>
        internal bool IsSetInstanceProperties() => this.InstanceProperties != null && (this.InstanceProperties.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LastSeenAt. 
        /// <para>
        /// The ISO-8601 timestamp of the last time this subject requested temporary session credentials.
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
        /// The id of the resource
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
