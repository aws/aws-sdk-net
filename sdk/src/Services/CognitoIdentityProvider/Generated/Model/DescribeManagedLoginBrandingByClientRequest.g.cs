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

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeManagedLoginBrandingByClient operation.
    /// Given the ID of a user pool app client, returns detailed information about the style
    /// assigned to the app client.
    /// </summary>
    public partial class DescribeManagedLoginBrandingByClientRequest : AmazonCognitoIdentityProviderRequest
    {
        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The app client that's assigned to the branding style that you want more information
        /// about.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 128)]
        public string ClientId { get; set; }

        /// <summary>
        /// Checks to see if the ClientId property is set.
        /// </summary>
        internal bool IsSetClientId() => this.ClientId != null;

        /// <summary>
        /// Gets and sets the property ReturnMergedResources. 
        /// <para>
        /// When <c>true</c>, returns values for branding options that are unchanged from Amazon
        /// Cognito defaults. When <c>false</c> or when you omit this parameter, returns only
        /// values that you customized in your branding style.
        /// </para>
        /// </summary>
        public bool? ReturnMergedResources { get; set; }

        /// <summary>
        /// Checks to see if the ReturnMergedResources property is set.
        /// </summary>
        internal bool IsSetReturnMergedResources() => this.ReturnMergedResources.HasValue;

        /// <summary>
        /// Gets and sets the property UserPoolId. 
        /// <para>
        /// The ID of the user pool that contains the app client where you want more information
        /// about the managed login branding style.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 55)]
        public string UserPoolId { get; set; }

        /// <summary>
        /// Checks to see if the UserPoolId property is set.
        /// </summary>
        internal bool IsSetUserPoolId() => this.UserPoolId != null;
    }
}
