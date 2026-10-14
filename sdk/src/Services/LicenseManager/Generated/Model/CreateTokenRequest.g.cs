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

namespace Amazon.LicenseManager.Model
{
    /// <summary>
    /// Container for the parameters to the CreateToken operation. Creates a long-lived token.
    /// <para> A refresh token is a JWT token used to get an access token. With an access
    /// token, you can call AssumeRoleWithWebIdentity to get role credentials that you can
    /// use to call License Manager to manage the specified license. </para>
    /// </summary>
    public partial class CreateTokenRequest : AmazonLicenseManagerRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Idempotency token, valid for 10 minutes.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2048)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property ExpirationInDays. 
        /// <para>
        /// Token expiration, in days, counted from token creation. The default is 365 days.
        /// </para>
        /// </summary>
        public int? ExpirationInDays { get; set; }

        /// <summary>
        /// Checks to see if the ExpirationInDays property is set.
        /// </summary>
        internal bool IsSetExpirationInDays() => this.ExpirationInDays.HasValue;

        /// <summary>
        /// Gets and sets the property LicenseArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the license. The ARN is mapped to the aud claim of the
        /// JWT token.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2048)]
        public string LicenseArn { get; set; }

        /// <summary>
        /// Checks to see if the LicenseArn property is set.
        /// </summary>
        internal bool IsSetLicenseArn() => this.LicenseArn != null;

        /// <summary>
        /// Gets and sets the property RoleArns. 
        /// <para>
        /// Amazon Resource Name (ARN) of the IAM roles to embed in the token. License Manager
        /// does not check whether the roles are in use.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RoleArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RoleArns property is set.
        /// </summary>
        internal bool IsSetRoleArns() => this.RoleArns != null && (this.RoleArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TokenProperties. 
        /// <para>
        /// Data specified by the caller to be included in the JWT token. The data is mapped to
        /// the amr claim of the JWT token.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 3)]
        public List<string> TokenProperties { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TokenProperties property is set.
        /// </summary>
        internal bool IsSetTokenProperties() => this.TokenProperties != null && (this.TokenProperties.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
