/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Container for the parameters to the ListIdentities operation.
    /// <para>Returns a list containing all of the identities (email addresses and domains) for a specific AWS Account, regardless of verification
    /// status.</para> <para>This action is throttled at one request per second.</para>
    /// </summary>
    public partial class ListIdentitiesRequest : AmazonSimpleEmailServiceRequest
    {
        private IdentityType identityType;
        private string nextToken;
        private int? maxItems;


        /// <summary>
        /// The type of the identities to list. Possible values are "EmailAddress" and "Domain". If this parameter is omitted, then all identities will
        /// be listed.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>EmailAddress, Domain</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public IdentityType IdentityType
        {
            get { return this.identityType; }
            set { this.identityType = value; }
        }

        // Check to see if IdentityType property is set
        internal bool IsSetIdentityType()
        {
            return this.identityType != null;
        }

        /// <summary>
        /// The token to use for pagination.
        ///  
        /// </summary>
        public string NextToken
        {
            get { return this.nextToken; }
            set { this.nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this.nextToken != null;
        }

        /// <summary>
        /// The maximum number of identities per page. Possible values are 1-100 inclusive.
        ///  
        /// </summary>
        public int MaxItems
        {
            get { return this.maxItems ?? default(int); }
            set { this.maxItems = value; }
        }

        // Check to see if MaxItems property is set
        internal bool IsSetMaxItems()
        {
            return this.maxItems.HasValue;
        }

    }
}
    
