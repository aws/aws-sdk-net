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

namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// Represents a list of all the DKIM attributes for the specified identity.
    /// </summary>
    public partial class GetIdentityDkimAttributesResult
    {
        private Dictionary<string, IdentityDkimAttributes> _dkimAttributes = new Dictionary<string, IdentityDkimAttributes>();


        /// <summary>
        /// Gets and sets the property DkimAttributes. 
        /// <para>
        /// The DKIM attributes for an email address or a domain. 
        /// </para>
        /// </summary>
        public Dictionary<string, IdentityDkimAttributes> DkimAttributes
        {
            get { return this._dkimAttributes; }
            set { this._dkimAttributes = value; }
        }

        /// <summary>
        /// Adds the KeyValuePairs to the DkimAttributes dictionary.
        /// </summary>
        /// <param name="pairs">The pairs to be added to the DkimAttributes dictionary.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetIdentityDkimAttributesResult WithDkimAttributes(params KeyValuePair<string, IdentityDkimAttributes>[] pairs)
        {
            foreach (KeyValuePair<string, IdentityDkimAttributes> pair in pairs)
            {
                this.DkimAttributes[pair.Key] = pair.Value;
            }
            return this;
        }
        // Check to see if DkimAttributes property is set
        internal bool IsSetDkimAttributes()
        {
            return this._dkimAttributes != null && this._dkimAttributes.Count > 0; 
        }

    }
}