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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.Chime.Model
{
    /// <summary>
    /// The Amazon Chime Business Calling settings for the administrator's AWS account. Includes
    /// any Amazon S3 buckets designated for storing call detail records.
    /// </summary>
    public partial class BusinessCallingSettings
    {
        /// <summary>
        /// Gets and sets the property CdrBucket. 
        /// <para>
        /// The Amazon S3 bucket designated for call detail record storage.
        /// </para>
        /// </summary>
        public string CdrBucket { get; set; }

        /// <summary>
        /// Checks to see if the CdrBucket property is set.
        /// </summary>
        internal bool IsSetCdrBucket() => this.CdrBucket != null;
    }
}
