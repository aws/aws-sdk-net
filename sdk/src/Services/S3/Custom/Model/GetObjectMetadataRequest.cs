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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3.Model
{
    public partial class GetObjectMetadataRequest : AmazonWebServiceRequest
    {
        DateTime? modifiedSinceDate;
        DateTime? unmodifiedSinceDate;

        /// <summary>
        /// Returns the object only if it has been modified since the specified time, 
        /// otherwise returns a PreconditionFailed.
        /// </summary>
        public DateTime? ModifiedSinceDate
        {
            get { return this.modifiedSinceDate ?? DateTime.SpecifyKind(default, DateTimeKind.Utc); }
            set
            {
                if (value == null)
                {
                    this.modifiedSinceDate = null;                    
                }
                else
                {
                    this.modifiedSinceDate = value;
                }
            }
        }

        // Check to see if ModifiedSinceDate property is set
        internal bool IsSetModifiedSinceDate()
        {
            return this.modifiedSinceDate.HasValue;
        }

        /// <summary>
        /// Returns the object only if it has not been modified since the specified time, 
        /// otherwise returns a PreconditionFailed.
        /// </summary>
        public DateTime? UnmodifiedSinceDate
        {
            get { return this.unmodifiedSinceDate ?? DateTime.SpecifyKind(default, DateTimeKind.Utc); }
            set
            {
                if (value == null)
                {
                    this.unmodifiedSinceDate = null;
                }
                else
                {
                    this.unmodifiedSinceDate = value;
                }
            }
        }

        // Check to see if IfUnmodifiedSince property is set
        internal bool IsSetUnmodifiedSinceDate()
        {
            return this.unmodifiedSinceDate.HasValue;
        }
    }
}