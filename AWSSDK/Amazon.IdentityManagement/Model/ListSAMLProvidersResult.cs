/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Contains the result of a successful invocation of the <a>ListSAMLProviders</a> action.
    /// </summary>
    public partial class ListSAMLProvidersResult
    {
        private List<SAMLProviderListEntry> _sAMLProviderList = new List<SAMLProviderListEntry>();


        /// <summary>
        /// Gets and sets the property SAMLProviderList. 
        /// <para>
        /// The list of SAML providers for this account.
        /// </para>
        /// </summary>
        public List<SAMLProviderListEntry> SAMLProviderList
        {
            get { return this._sAMLProviderList; }
            set { this._sAMLProviderList = value; }
        }

        /// <summary>
        /// Sets the SAMLProviderList property
        /// </summary>
        /// <param name="sAMLProviderList">The values to add to the SAMLProviderList collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListSAMLProvidersResult WithSAMLProviderList(params SAMLProviderListEntry[] sAMLProviderList)
        {
            foreach (var element in sAMLProviderList)
            {
                this._sAMLProviderList.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the SAMLProviderList property
        /// </summary>
        /// <param name="sAMLProviderList">The values to add to the SAMLProviderList collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListSAMLProvidersResult WithSAMLProviderList(IEnumerable<SAMLProviderListEntry> sAMLProviderList)
        {
            foreach (var element in sAMLProviderList)
            {
                this._sAMLProviderList.Add(element);
            }
            return this;
        }
        // Check to see if SAMLProviderList property is set
        internal bool IsSetSAMLProviderList()
        {
            return this._sAMLProviderList != null && this._sAMLProviderList.Count > 0; 
        }

    }
}