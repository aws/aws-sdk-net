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
 * Do not modify this file. This file is generated from the backupsearch-2018-05-10.normal.json service model.
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
namespace Amazon.BackupSearch.Model
{
    /// <summary>
    /// This specification contains a required string of the destination bucket; optionally,
    /// you can include the destination prefix.
    /// </summary>
    public partial class S3ExportSpecification
    {
        private string _destinationBucket;
        private string _destinationPrefix;

        /// <summary>
        /// Gets and sets the property DestinationBucket. 
        /// <para>
        /// This specifies the destination Amazon S3 bucket for the export job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DestinationBucket
        {
            get { return this._destinationBucket; }
            set { this._destinationBucket = value; }
        }

        // Check to see if DestinationBucket property is set
        internal bool IsSetDestinationBucket()
        {
            return this._destinationBucket != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationPrefix. 
        /// <para>
        /// This specifies the prefix for the destination Amazon S3 bucket for the export job.
        /// </para>
        /// </summary>
        public string DestinationPrefix
        {
            get { return this._destinationPrefix; }
            set { this._destinationPrefix = value; }
        }

        // Check to see if DestinationPrefix property is set
        internal bool IsSetDestinationPrefix()
        {
            return this._destinationPrefix != null;
        }

    }
}