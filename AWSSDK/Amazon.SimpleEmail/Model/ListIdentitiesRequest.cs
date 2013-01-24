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
    /// status.</para>
    /// </summary>
    /// <seealso cref="Amazon.SimpleEmail.AmazonSimpleEmailService.ListIdentities"/>
    public class ListIdentitiesRequest : AmazonWebServiceRequest
    {
        private string identityType;
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
        public string IdentityType
        {
            get { return this.identityType; }
            set { this.identityType = value; }
        }

        /// <summary>
        /// Sets the IdentityType property
        /// </summary>
        /// <param name="identityType">The value to set for the IdentityType property </param>
        /// <returns>this instance</returns>
        public ListIdentitiesRequest WithIdentityType(string identityType)
        {
            this.identityType = identityType;
            return this;
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

        /// <summary>
        /// Sets the NextToken property
        /// </summary>
        /// <param name="nextToken">The value to set for the NextToken property </param>
        /// <returns>this instance</returns>
        public ListIdentitiesRequest WithNextToken(string nextToken)
        {
            this.nextToken = nextToken;
            return this;
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

        /// <summary>
        /// Sets the MaxItems property
        /// </summary>
        /// <param name="maxItems">The value to set for the MaxItems property </param>
        /// <returns>this instance</returns>
        public ListIdentitiesRequest WithMaxItems(int maxItems)
        {
            this.maxItems = maxItems;
            return this;
        }
            

        // Check to see if MaxItems property is set
        internal bool IsSetMaxItems()
        {
            return this.maxItems.HasValue;       
        }
    }
}
    
