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

namespace Amazon.Snowball.Model
{
    /// <summary>
    /// Each <c>S3Resource</c> object represents an Amazon S3 bucket that your transferred
    /// data will be exported from or imported into. For export jobs, this object can have
    /// an optional <c>KeyRange</c> value. The length of the range is defined at job creation,
    /// and has either an inclusive <c>BeginMarker</c>, an inclusive <c>EndMarker</c>, or
    /// both. Ranges are UTF-8 binary sorted.
    /// </summary>
    public partial class S3Resource
    {
        /// <summary>
        /// Gets and sets the property BucketArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an Amazon S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string BucketArn { get; set; }

        /// <summary>
        /// Checks to see if the BucketArn property is set.
        /// </summary>
        internal bool IsSetBucketArn() => this.BucketArn != null;

        /// <summary>
        /// Gets and sets the property KeyRange. 
        /// <para>
        /// For export jobs, you can provide an optional <c>KeyRange</c> within a specific Amazon
        /// S3 bucket. The length of the range is defined at job creation, and has either an inclusive
        /// <c>BeginMarker</c>, an inclusive <c>EndMarker</c>, or both. Ranges are UTF-8 binary
        /// sorted.
        /// </para>
        /// </summary>
        public KeyRange KeyRange { get; set; }

        /// <summary>
        /// Checks to see if the KeyRange property is set.
        /// </summary>
        internal bool IsSetKeyRange() => this.KeyRange != null;

        /// <summary>
        /// Gets and sets the property TargetOnDeviceServices. 
        /// <para>
        /// Specifies the service or services on the Snow Family device that your transferred
        /// data will be exported from or imported into. Amazon Web Services Snow Family supports
        /// Amazon S3 and NFS (Network File System).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TargetOnDeviceService> TargetOnDeviceServices { get; set; } = AWSConfigs.InitializeCollections ? new List<TargetOnDeviceService>() : null;

        /// <summary>
        /// Checks to see if the TargetOnDeviceServices property is set.
        /// </summary>
        internal bool IsSetTargetOnDeviceServices() => this.TargetOnDeviceServices != null && (this.TargetOnDeviceServices.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
