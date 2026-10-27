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

namespace Amazon.CertificateManager.Model
{
    /// <summary>
    /// Contains detailed information about an ACME external account binding.
    /// </summary>
    public partial class AcmeExternalAccountBinding
    {
        /// <summary>
        /// Gets and sets the property AcmeEndpointArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the ACME endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string AcmeEndpointArn { get; set; }

        /// <summary>
        /// Checks to see if the AcmeEndpointArn property is set.
        /// </summary>
        internal bool IsSetAcmeEndpointArn() => this.AcmeEndpointArn != null;

        /// <summary>
        /// Gets and sets the property AcmeExternalAccountBindingArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the ACME external account binding.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string AcmeExternalAccountBindingArn { get; set; }

        /// <summary>
        /// Checks to see if the AcmeExternalAccountBindingArn property is set.
        /// </summary>
        internal bool IsSetAcmeExternalAccountBindingArn() => this.AcmeExternalAccountBindingArn != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time at which the external account binding was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ExpiresAt. 
        /// <para>
        /// The time at which the external account binding expires.
        /// </para>
        /// </summary>
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Checks to see if the ExpiresAt property is set.
        /// </summary>
        internal bool IsSetExpiresAt() => this.ExpiresAt.HasValue;

        /// <summary>
        /// Gets and sets the property LastUsedAt. 
        /// <para>
        /// The time at which the external account binding was last used.
        /// </para>
        /// </summary>
        public DateTime? LastUsedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastUsedAt property is set.
        /// </summary>
        internal bool IsSetLastUsedAt() => this.LastUsedAt.HasValue;

        /// <summary>
        /// Gets and sets the property RevokedAt. 
        /// <para>
        /// The time at which the external account binding was revoked.
        /// </para>
        /// </summary>
        public DateTime? RevokedAt { get; set; }

        /// <summary>
        /// Checks to see if the RevokedAt property is set.
        /// </summary>
        internal bool IsSetRevokedAt() => this.RevokedAt.HasValue;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role associated with the external account
        /// binding.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The time at which the external account binding was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
