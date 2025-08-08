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
    /// Represents a version of an object in an S3 Bucket. An S3 object version is an S3 object
    /// that also has a version identifier, an indication of whether this is the latest version of the object 
    /// and whether it's a DeleteMarker or not.
    /// </summary>
    public partial class S3ObjectVersion : S3Object
    {
        private bool? isDeleteMarker;
        /// <summary>
        /// If true, the object is a delete marker for a deleted object.
        /// </summary>
        public bool? IsDeleteMarker
        {
            get { return this.isDeleteMarker; }
            set { this.isDeleteMarker = value; }
        }
    }
}
