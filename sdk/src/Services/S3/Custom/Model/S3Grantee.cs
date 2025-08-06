/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.S3.Model
{
    /// <summary>Grantee
    /// </summary>
    public partial class S3Grantee
    {
        /// <summary>
        /// Type of grantee
        ///  
        /// </summary>
        public GranteeType Type
        {
            get 
            {
                if (this.IsSetEmailAddress())
                    return GranteeType.Email;
                if (this.IsSetURI())
                    return GranteeType.Group;
                if (this.IsSetCanonicalUser())
                    return GranteeType.CanonicalUser;

                return null; 
            }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this.Type != null;
        }

    }
}
