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
    /// <para>Contains the result of a successful invocation of the ListSigningCertificates action.</para>
    /// </summary>
    public class ListSigningCertificatesResult  
    {
        
        private List<SigningCertificate> certificates = new List<SigningCertificate>();
        private bool? isTruncated;
        private string marker;

        /// <summary>
        /// A list of the user's signing certificate information.
        ///  
        /// </summary>
        public List<SigningCertificate> Certificates
        {
            get { return this.certificates; }
            set { this.certificates = value; }
        }
        /// <summary>
        /// Adds elements to the Certificates collection
        /// </summary>
        /// <param name="certificates">The values to add to the Certificates collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListSigningCertificatesResult WithCertificates(params SigningCertificate[] certificates)
        {
            foreach (SigningCertificate element in certificates)
            {
                this.certificates.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the Certificates collection
        /// </summary>
        /// <param name="certificates">The values to add to the Certificates collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListSigningCertificatesResult WithCertificates(IEnumerable<SigningCertificate> certificates)
        {
            foreach (SigningCertificate element in certificates)
            {
                this.certificates.Add(element);
            }

            return this;
        }

        // Check to see if Certificates property is set
        internal bool IsSetCertificates()
        {
            return this.certificates.Count > 0;       
        }

        /// <summary>
        /// A flag that indicates whether there are more certificate IDs to list. If your results were truncated, you can make a subsequent pagination
        /// request using the <c>Marker</c> request parameter to retrieve more certificates in the list.
        ///  
        /// </summary>
        public bool IsTruncated
        {
            get { return this.isTruncated ?? default(bool); }
            set { this.isTruncated = value; }
        }

        /// <summary>
        /// Sets the IsTruncated property
        /// </summary>
        /// <param name="isTruncated">The value to set for the IsTruncated property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListSigningCertificatesResult WithIsTruncated(bool isTruncated)
        {
            this.isTruncated = isTruncated;
            return this;
        }
            

        // Check to see if IsTruncated property is set
        internal bool IsSetIsTruncated()
        {
            return this.isTruncated.HasValue;       
        }

        /// <summary>
        /// If <c>IsTruncated</c> is <c>true</c>, this element is present and contains the value to use for the <c>Marker</c> parameter in a subsequent
        /// pagination request.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 320</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\u00FF]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this.marker; }
            set { this.marker = value; }
        }

        /// <summary>
        /// Sets the Marker property
        /// </summary>
        /// <param name="marker">The value to set for the Marker property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListSigningCertificatesResult WithMarker(string marker)
        {
            this.marker = marker;
            return this;
        }
            

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;       
        }
    }
}
