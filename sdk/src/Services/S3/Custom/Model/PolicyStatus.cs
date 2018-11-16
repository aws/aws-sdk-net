/*
 * Copyright 2010-2018 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// The container element for this bucket's public-policy status.
    /// </summary>
    public class PolicyStatus
    {
        private bool? isPublic;

        /// <summary>
        /// Gets and sets the property IsPublic. 
        /// <para>
        /// The public-policy status for this bucket. <code>TRUE</code> indicates that this bucket
        /// is public. <code>FALSE</code> indicates that the bucket is not public.
        /// </para>
        /// </summary>
        public bool IsPublic
        {
            get { return this.isPublic ?? default(bool); }
            set { this.isPublic = value; }
        }

        // Check to see if IsPublic property is set
        internal bool IsSetIsPublic()
        {
            return this.isPublic.HasValue;
        }
    }
}