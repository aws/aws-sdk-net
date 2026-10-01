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

namespace Amazon.WorkMailMessageFlow.Model
{
    /// <summary>
    /// Amazon S3 object representing the updated message content, in MIME format.
    /// 
    ///  <note> 
    /// <para>
    /// The region for the S3 bucket containing the S3 object must match the region used for
    /// WorkMail operations. Also, for WorkMail to process an S3 object, it must have permission
    /// to access that object. For more information, see <a href="https://docs.aws.amazon.com/workmail/latest/adminguide/update-with-lambda.html">
    /// Updating message content with AWS Lambda</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class S3Reference
    {
        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        /// The S3 bucket name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 63)]
        public string Bucket { get; set; }

        /// <summary>
        /// Checks to see if the Bucket property is set.
        /// </summary>
        internal bool IsSetBucket() => this.Bucket != null;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The S3 key object name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string Key { get; set; }

        /// <summary>
        /// Checks to see if the Key property is set.
        /// </summary>
        internal bool IsSetKey() => this.Key != null;

        /// <summary>
        /// Gets and sets the property ObjectVersion. 
        /// <para>
        /// If you enable versioning for the bucket, you can specify the object version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string ObjectVersion { get; set; }

        /// <summary>
        /// Checks to see if the ObjectVersion property is set.
        /// </summary>
        internal bool IsSetObjectVersion() => this.ObjectVersion != null;
    }
}
