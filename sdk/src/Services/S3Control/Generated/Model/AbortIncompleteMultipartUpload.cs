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

/*
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3Control.Model
{
    /// <summary>
    /// The container for abort incomplete multipart upload
    /// </summary>
    public partial class AbortIncompleteMultipartUpload
    {
        private int? _daysAfterInitiation;

        /// <summary>
        /// Gets and sets the property DaysAfterInitiation. 
        /// <para>
        /// Specifies the number of days after which Amazon S3 aborts an incomplete multipart
        /// upload to the Outposts bucket.
        /// </para>
        /// </summary>
        public int DaysAfterInitiation
        {
            get { return this._daysAfterInitiation.GetValueOrDefault(); }
            set { this._daysAfterInitiation = value; }
        }

        // Check to see if DaysAfterInitiation property is set
        internal bool IsSetDaysAfterInitiation()
        {
            return this._daysAfterInitiation.HasValue; 
        }

    }
}