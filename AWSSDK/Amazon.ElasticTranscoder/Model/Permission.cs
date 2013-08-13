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

namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Permission
    {
        
        private string granteeType;
        private string grantee;
        private List<string> access = new List<string>();

        /// <summary>
        /// 
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^Canonical$)|(^Email$)|(^Group$)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string GranteeType
        {
            get { return this.granteeType; }
            set { this.granteeType = value; }
        }

        /// <summary>
        /// Sets the GranteeType property
        /// </summary>
        /// <param name="granteeType">The value to set for the GranteeType property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Permission WithGranteeType(string granteeType)
        {
            this.granteeType = granteeType;
            return this;
        }
            

        // Check to see if GranteeType property is set
        internal bool IsSetGranteeType()
        {
            return this.granteeType != null;
        }

        /// <summary>
        /// 
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 255</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Grantee
        {
            get { return this.grantee; }
            set { this.grantee = value; }
        }

        /// <summary>
        /// Sets the Grantee property
        /// </summary>
        /// <param name="grantee">The value to set for the Grantee property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Permission WithGrantee(string grantee)
        {
            this.grantee = grantee;
            return this;
        }
            

        // Check to see if Grantee property is set
        internal bool IsSetGrantee()
        {
            return this.grantee != null;
        }

        /// <summary>
        /// 
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 30</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public List<string> Access
        {
            get { return this.access; }
            set { this.access = value; }
        }
        /// <summary>
        /// Adds elements to the Access collection
        /// </summary>
        /// <param name="access">The values to add to the Access collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Permission WithAccess(params string[] access)
        {
            foreach (string element in access)
            {
                this.access.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the Access collection
        /// </summary>
        /// <param name="access">The values to add to the Access collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Permission WithAccess(IEnumerable<string> access)
        {
            foreach (string element in access)
            {
                this.access.Add(element);
            }

            return this;
        }

        // Check to see if Access property is set
        internal bool IsSetAccess()
        {
            return this.access.Count > 0;
        }
    }
}
