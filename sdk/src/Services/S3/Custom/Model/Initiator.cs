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
    /// <summary>
    /// <para>Identifies who initiated the multipart upload.</para>
    /// </summary>
    public class Initiator
    {
        
        private string displayName;
        private string iD;

        /// <summary>
        /// Gets and sets the property DisplayName.  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public string DisplayName
        {
            get { return this.displayName; }
            set { this.displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this.displayName != null;
        }

        /// <summary>
        /// Gets and sets the property ID. 
        /// <para>
        /// If the principal is an Amazon Web Services account, it provides the Canonical User
        /// ID. If the principal is an IAM User, it provides a user ARN value.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <b>Directory buckets</b> - If the principal is an Amazon Web Services account, it
        /// provides the Amazon Web Services account ID. If the principal is an IAM User, it provides
        /// a user ARN value.
        /// </para>
        ///  </note>
        /// </summary>
        public string Id
        {
            get { return this.iD; }
            set { this.iD = value; }
        }

        // Check to see if ID property is set
        internal bool IsSetId()
        {
            return this.iD != null;
        }
    }
}
