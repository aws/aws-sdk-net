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

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// <para>Contains the result of a successful invocation of the GetSAMLProvider action.</para>
    /// </summary>
    public partial class GetSAMLProviderResult
    {
        
        private string sAMLMetadataDocument;
        private DateTime? createDate;
        private DateTime? validUntil;

        /// <summary>
        /// The XML metadata document that includes information about an identity provider.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1000 - 10000000</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string SAMLMetadataDocument
        {
            get { return this.sAMLMetadataDocument; }
            set { this.sAMLMetadataDocument = value; }
        }

        /// <summary>
        /// Sets the SAMLMetadataDocument property
        /// </summary>
        /// <param name="sAMLMetadataDocument">The value to set for the SAMLMetadataDocument property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetSAMLProviderResult WithSAMLMetadataDocument(string sAMLMetadataDocument)
        {
            this.sAMLMetadataDocument = sAMLMetadataDocument;
            return this;
        }
            

        // Check to see if SAMLMetadataDocument property is set
        internal bool IsSetSAMLMetadataDocument()
        {
            return this.sAMLMetadataDocument != null;
        }

        /// <summary>
        /// The date and time when the SAML provider was created.
        ///  
        /// </summary>
        public DateTime CreateDate
        {
            get { return this.createDate ?? default(DateTime); }
            set { this.createDate = value; }
        }

        /// <summary>
        /// Sets the CreateDate property
        /// </summary>
        /// <param name="createDate">The value to set for the CreateDate property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetSAMLProviderResult WithCreateDate(DateTime createDate)
        {
            this.createDate = createDate;
            return this;
        }
            

        // Check to see if CreateDate property is set
        internal bool IsSetCreateDate()
        {
            return this.createDate.HasValue;
        }

        /// <summary>
        /// The expiration date and time for the SAML provider.
        ///  
        /// </summary>
        public DateTime ValidUntil
        {
            get { return this.validUntil ?? default(DateTime); }
            set { this.validUntil = value; }
        }

        /// <summary>
        /// Sets the ValidUntil property
        /// </summary>
        /// <param name="validUntil">The value to set for the ValidUntil property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetSAMLProviderResult WithValidUntil(DateTime validUntil)
        {
            this.validUntil = validUntil;
            return this;
        }
            

        // Check to see if ValidUntil property is set
        internal bool IsSetValidUntil()
        {
            return this.validUntil.HasValue;
        }
    }
}
