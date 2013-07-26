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

namespace Amazon.S3.Model
{
    /// <summary>
    /// The owner of an S3 bucket.
    /// </summary>
    public class Owner
    {
        /// <summary>
        /// The display name of the owner.
        /// </summary>
        public string DisplayName { set; get; }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this.DisplayName != null;
        }

        /// <summary>
        /// The unique identifier of the owner.
        /// </summary>
        public string Id { get; set; }

        // Check to see if ID property is set
        internal bool IsSetId()
        {
            return this.Id != null;
        }
    }
}
