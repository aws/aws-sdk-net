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
    /// <para>Contains the result of a successful invocation of the ListAccessKeys action.</para>
    /// </summary>
    public class ListAccessKeysResult  
    {
        
        private List<AccessKeyMetadata> accessKeyMetadata = new List<AccessKeyMetadata>();
        private bool? isTruncated;
        private string marker;

        /// <summary>
        /// A list of access key metadata.
        ///  
        /// </summary>
        public List<AccessKeyMetadata> AccessKeyMetadata
        {
            get { return this.accessKeyMetadata; }
            set { this.accessKeyMetadata = value; }
        }
        /// <summary>
        /// Adds elements to the AccessKeyMetadata collection
        /// </summary>
        /// <param name="accessKeyMetadata">The values to add to the AccessKeyMetadata collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListAccessKeysResult WithAccessKeyMetadata(params AccessKeyMetadata[] accessKeyMetadata)
        {
            foreach (AccessKeyMetadata element in accessKeyMetadata)
            {
                this.accessKeyMetadata.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the AccessKeyMetadata collection
        /// </summary>
        /// <param name="accessKeyMetadata">The values to add to the AccessKeyMetadata collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ListAccessKeysResult WithAccessKeyMetadata(IEnumerable<AccessKeyMetadata> accessKeyMetadata)
        {
            foreach (AccessKeyMetadata element in accessKeyMetadata)
            {
                this.accessKeyMetadata.Add(element);
            }

            return this;
        }

        // Check to see if AccessKeyMetadata property is set
        internal bool IsSetAccessKeyMetadata()
        {
            return this.accessKeyMetadata.Count > 0;       
        }

        /// <summary>
        /// A flag that indicates whether there are more keys to list. If your results were truncated, you can make a subsequent pagination request
        /// using the <c>Marker</c> request parameter to retrieve more keys in the list.
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
        public ListAccessKeysResult WithIsTruncated(bool isTruncated)
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
        public ListAccessKeysResult WithMarker(string marker)
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
