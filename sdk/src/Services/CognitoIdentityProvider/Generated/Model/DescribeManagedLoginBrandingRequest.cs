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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
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
    /// Container for the parameters to the DescribeManagedLoginBranding operation.
    /// Given the ID of a managed login branding style, returns detailed information about
    /// the style.
    /// </summary>
    public partial class DescribeManagedLoginBrandingRequest : AmazonCognitoIdentityProviderRequest
    {
        private string _managedLoginBrandingId;
        private bool? _returnMergedResources;
        private string _userPoolId;

        /// <summary>
        /// Gets and sets the property ManagedLoginBrandingId. 
        /// <para>
        /// The ID of the managed login branding style that you want to get more information about.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ManagedLoginBrandingId
        {
            get { return this._managedLoginBrandingId; }
            set { this._managedLoginBrandingId = value; }
        }

        // Check to see if ManagedLoginBrandingId property is set
        internal bool IsSetManagedLoginBrandingId()
        {
            return this._managedLoginBrandingId != null;
        }

        /// <summary>
        /// Gets and sets the property ReturnMergedResources. 
        /// <para>
        /// When <c>true</c>, returns values for branding options that are unchanged from Amazon
        /// Cognito defaults. When <c>false</c> or when you omit this parameter, returns only
        /// values that you customized in your branding style.
        /// </para>
        /// </summary>
        public bool? ReturnMergedResources
        {
            get { return this._returnMergedResources; }
            set { this._returnMergedResources = value; }
        }

        // Check to see if ReturnMergedResources property is set
        internal bool IsSetReturnMergedResources()
        {
            return this._returnMergedResources.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UserPoolId. 
        /// <para>
        /// The ID of the user pool that contains the managed login branding style that you want
        /// to get information about.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=55)]
        public string UserPoolId
        {
            get { return this._userPoolId; }
            set { this._userPoolId = value; }
        }

        // Check to see if UserPoolId property is set
        internal bool IsSetUserPoolId()
        {
            return this._userPoolId != null;
        }

    }
}