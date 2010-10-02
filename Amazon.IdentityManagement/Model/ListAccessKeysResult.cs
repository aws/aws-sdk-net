/*
 * Copyright 2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para>Contains the result of a successful invocation of the
    /// ListAccessKeys action.</para>
    /// </summary>
    public class ListAccessKeysResult  
    {
        
        private List<AccessKeyMetadata> accessKeyMetadata = new List<AccessKeyMetadata>();
        private bool isTruncated;
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
        /// A flag that indicates whether there are more keys to list. If your
        /// results were truncated, you can make a follow-up pagination request
        /// using the <c>Marker</c> request parameter to retrieve more keys in the
        /// list.
        ///  
        /// </summary>
        public bool IsTruncated
        {
            get { return this.isTruncated; }
            set { this.isTruncated = value; }
        }

        /// <summary>
        /// If <c>IsTruncated</c> is true, this element is present and contains
        /// the value to use for the <c>Marker</c> parameter in a follow-up
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
    }
}
