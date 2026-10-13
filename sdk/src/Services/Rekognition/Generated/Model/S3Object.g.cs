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

namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Provides the S3 bucket name and object name.
    /// 
    ///  
    /// <para>
    /// The region for the S3 bucket containing the S3 object must match the region you use
    /// for Amazon Rekognition operations.
    /// </para>
    ///  
    /// <para>
    /// For Amazon Rekognition to process an S3 object, the user must have permission to access
    /// the S3 object. For more information, see How Amazon Rekognition works with IAM in
    /// the Amazon Rekognition Developer Guide. 
    /// </para>
    /// </summary>
    public partial class S3Object
    {
        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        /// Name of the S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 255)]
        public string Bucket { get; set; }

        /// <summary>
        /// Checks to see if the Bucket property is set.
        /// </summary>
        internal bool IsSetBucket() => this.Bucket != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// S3 object key name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// If the bucket is versioning enabled, you can specify the object version. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
