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
    /// The characteristics of a source or destination user for linking a federated user profile
    /// to a local user profile.
    /// </summary>
    public partial class ProviderUserIdentifierType
    {
        private string _providerAttributeName;
        private string _providerAttributeValue;
        private string _providerName;

        /// <summary>
        /// Gets and sets the property ProviderAttributeName. 
        /// <para>
        /// The name of the provider attribute to link to, such as <c>NameID</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=131072)]
        public string ProviderAttributeName
        {
            get { return this._providerAttributeName; }
            set { this._providerAttributeName = value; }
        }

        // Check to see if ProviderAttributeName property is set
        internal bool IsSetProviderAttributeName()
        {
            return this._providerAttributeName != null;
        }

        /// <summary>
        /// Gets and sets the property ProviderAttributeValue. 
        /// <para>
        /// The value of the provider attribute to link to, such as <c>xxxxx_account</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=131072)]
        public string ProviderAttributeValue
        {
            get { return this._providerAttributeValue; }
            set { this._providerAttributeValue = value; }
        }

        // Check to see if ProviderAttributeValue property is set
        internal bool IsSetProviderAttributeValue()
        {
            return this._providerAttributeValue != null;
        }

        /// <summary>
        /// Gets and sets the property ProviderName. 
        /// <para>
        /// The name of the provider, such as Facebook, Google, or Login with Amazon.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public string ProviderName
        {
            get { return this._providerName; }
            set { this._providerName = value; }
        }

        // Check to see if ProviderName property is set
        internal bool IsSetProviderName()
        {
            return this._providerName != null;
        }

    }
}