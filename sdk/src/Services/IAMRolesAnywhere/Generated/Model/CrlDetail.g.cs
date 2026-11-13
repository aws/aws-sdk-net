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
    /// The state of the certificate revocation list (CRL) after a read or write operation.
    /// </summary>
    public partial class CrlDetail
    {
        /// <summary>
        /// Gets and sets the property AliasArn. 
        /// <para>
        /// The alias ARN of the certificate revocation list (CRL), in the form <c>arn:<i>partition</i>:rolesanywhere:<i>region</i>:<i>account</i>:alias/crl/<i>alias-name</i>
        /// </c>. Present only if the CRL has an alias.
        /// </para>
        ///  
        /// <para>
        /// You can use the alias ARN in place of the resource ID or ARN in the request parameters
        /// whose descriptions say that they accept an alias ARN. Don't use the alias ARN in Identity
        /// and Access Management (IAM) policies. A policy statement that names an alias ARN doesn't
        /// apply to the resource that holds the alias. Write policies with the ARN that contains
        /// the resource ID instead.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1011)]
        public string AliasArn { get; set; }

        /// <summary>
        /// Checks to see if the AliasArn property is set.
        /// </summary>
        internal bool IsSetAliasArn() => this.AliasArn != null;

        /// <summary>
        /// Gets and sets the property AliasName. 
        /// <para>
        /// The alias of the certificate revocation list (CRL). Present only if the CRL has an
        /// alias.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string AliasName { get; set; }

        /// <summary>
        /// Checks to see if the AliasName property is set.
        /// </summary>
        internal bool IsSetAliasName() => this.AliasName != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The ISO-8601 timestamp when the certificate revocation list (CRL) was created. 
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CrlArn. 
        /// <para>
        /// The ARN of the certificate revocation list (CRL).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1011)]
        public string CrlArn { get; set; }

        /// <summary>
        /// Checks to see if the CrlArn property is set.
        /// </summary>
        internal bool IsSetCrlArn() => this.CrlArn != null;

        /// <summary>
        /// Gets and sets the property CrlData. 
        /// <para>
        /// The state of the certificate revocation list (CRL) after a read or write operation.
        /// </para>
        /// </summary>
        public MemoryStream CrlData { get; set; }

        /// <summary>
        /// Checks to see if the CrlData property is set.
        /// </summary>
        internal bool IsSetCrlData() => this.CrlData != null;

        /// <summary>
        /// Gets and sets the property CrlId. 
        /// <para>
        /// The unique identifier of the certificate revocation list (CRL).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string CrlId { get; set; }

        /// <summary>
        /// Checks to see if the CrlId property is set.
        /// </summary>
        internal bool IsSetCrlId() => this.CrlId != null;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Indicates whether the certificate revocation list (CRL) is enabled.
        /// </para>
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the certificate revocation list (CRL).
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PreviousAliasName. 
        /// <para>
        /// The alias that the resource had before the update request. IAM Roles Anywhere returns
        /// this value only in the response to an update request that changed or removed an existing
        /// alias. It isn't returned when the alias was unchanged, when the resource had no alias
        /// before the request, or by other operations.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string PreviousAliasName { get; set; }

        /// <summary>
        /// Checks to see if the PreviousAliasName property is set.
        /// </summary>
        internal bool IsSetPreviousAliasName() => this.PreviousAliasName != null;

        /// <summary>
        /// Gets and sets the property TrustAnchorArn. 
        /// <para>
        /// The ARN of the TrustAnchor the certificate revocation list (CRL) will provide revocation
        /// for. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1011)]
        public string TrustAnchorArn { get; set; }

        /// <summary>
        /// Checks to see if the TrustAnchorArn property is set.
        /// </summary>
        internal bool IsSetTrustAnchorArn() => this.TrustAnchorArn != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The ISO-8601 timestamp when the certificate revocation list (CRL) was last updated.
        /// 
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
