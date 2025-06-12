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
 * Do not modify this file. This file is generated from the snowball-2016-06-30.normal.json service model.
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
        private string _bucketArn;
        private KeyRange _keyRange;
        private List<TargetOnDeviceService> _targetOnDeviceServices = AWSConfigs.InitializeCollections ? new List<TargetOnDeviceService>() : null;

        /// <summary>
        /// Gets and sets the property BucketArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an Amazon S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
        public string BucketArn
        {
            get { return this._bucketArn; }
            set { this._bucketArn = value; }
        }

        // Check to see if BucketArn property is set
        internal bool IsSetBucketArn()
        {
            return this._bucketArn != null;
        }

        /// <summary>
        /// Gets and sets the property KeyRange. 
        /// <para>
        /// For export jobs, you can provide an optional <c>KeyRange</c> within a specific Amazon
        /// S3 bucket. The length of the range is defined at job creation, and has either an inclusive
        /// <c>BeginMarker</c>, an inclusive <c>EndMarker</c>, or both. Ranges are UTF-8 binary
        /// sorted.
        /// </para>
        /// </summary>
        public KeyRange KeyRange
        {
            get { return this._keyRange; }
            set { this._keyRange = value; }
        }

        // Check to see if KeyRange property is set
        internal bool IsSetKeyRange()
        {
            return this._keyRange != null;
        }

        /// <summary>
        /// Gets and sets the property TargetOnDeviceServices. 
        /// <para>
        /// Specifies the service or services on the Snow Family device that your transferred
        /// data will be exported from or imported into. Amazon Web Services Snow Family supports
        /// Amazon S3 and NFS (Network File System).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TargetOnDeviceService> TargetOnDeviceServices
        {
            get { return this._targetOnDeviceServices; }
            set { this._targetOnDeviceServices = value; }
        }

        // Check to see if TargetOnDeviceServices property is set
        internal bool IsSetTargetOnDeviceServices()
        {
            return this._targetOnDeviceServices != null && (this._targetOnDeviceServices.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}