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
    /// Represents the verification attributes for a list of identities.
    /// </summary>
    public partial class GetIdentityVerificationAttributesResult
    {
        private Dictionary<string, IdentityVerificationAttributes> _verificationAttributes = new Dictionary<string, IdentityVerificationAttributes>();


        /// <summary>
        /// Gets and sets the property VerificationAttributes. 
        /// <para>
        /// A map of Identities to IdentityVerificationAttributes objects.
        /// </para>
        /// </summary>
        public Dictionary<string, IdentityVerificationAttributes> VerificationAttributes
        {
            get { return this._verificationAttributes; }
            set { this._verificationAttributes = value; }
        }

        /// <summary>
        /// Adds the KeyValuePairs to the VerificationAttributes dictionary.
        /// </summary>
        /// <param name="pairs">The pairs to be added to the VerificationAttributes dictionary.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetIdentityVerificationAttributesResult WithVerificationAttributes(params KeyValuePair<string, IdentityVerificationAttributes>[] pairs)
        {
            foreach (KeyValuePair<string, IdentityVerificationAttributes> pair in pairs)
            {
                this.VerificationAttributes[pair.Key] = pair.Value;
            }
            return this;
        }
        // Check to see if VerificationAttributes property is set
        internal bool IsSetVerificationAttributes()
        {
            return this._verificationAttributes != null && this._verificationAttributes.Count > 0; 
        }

    }
}