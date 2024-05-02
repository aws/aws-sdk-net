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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A structure that describes the Amazon S3 settings to use to save the generated dashboard
    /// snapshot.
    /// </summary>
    public partial class SnapshotS3DestinationConfiguration
    {
        private S3BucketConfiguration _bucketConfiguration;

        /// <summary>
        /// Gets and sets the property BucketConfiguration. 
        /// <para>
        /// A structure that contains details about the Amazon S3 bucket that the generated dashboard
        /// snapshot is saved in.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public S3BucketConfiguration BucketConfiguration
        {
            get { return this._bucketConfiguration; }
            set { this._bucketConfiguration = value; }
        }

        // Check to see if BucketConfiguration property is set
        internal bool IsSetBucketConfiguration()
        {
            return this._bucketConfiguration != null;
        }

    }
}