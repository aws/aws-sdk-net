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

namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// Details about an S3 recording <c>Config</c> used in a contact.
    /// </summary>
    public partial class S3RecordingDetails
    {
        /// <summary>
        /// Gets and sets the property BucketArn. 
        /// <para>
        /// ARN of the bucket used.
        /// </para>
        /// </summary>
        public string BucketArn { get; set; }

        /// <summary>
        /// Checks to see if the BucketArn property is set.
        /// </summary>
        internal bool IsSetBucketArn() => this.BucketArn != null;

        /// <summary>
        /// Gets and sets the property KeyTemplate. 
        /// <para>
        /// Key template used for the S3 Recording Configuration
        /// </para>
        /// </summary>
        public string KeyTemplate { get; set; }

        /// <summary>
        /// Checks to see if the KeyTemplate property is set.
        /// </summary>
        internal bool IsSetKeyTemplate() => this.KeyTemplate != null;
    }
}
