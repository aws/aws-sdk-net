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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
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
namespace Amazon.S3.Model
{
    /// <summary>
    /// The metadata table configuration for a general purpose bucket.
    /// </summary>
    public partial class GetBucketMetadataTableConfigurationResult
    {
        private ErrorDetails _errorDetails;
        private MetadataTableConfigurationResult _metadataTableConfigurationResult;
        private string _status;

        /// <summary>
        /// Gets and sets the property ErrorDetails. 
        /// <para>
        ///  If the <c>CreateBucketMetadataTableConfiguration</c> request succeeds, but S3 Metadata
        /// was unable to create the table, this structure contains the error code and error message.
        /// 
        /// </para>
        /// </summary>
        public ErrorDetails ErrorDetails
        {
            get { return this._errorDetails; }
            set { this._errorDetails = value; }
        }

        // Check to see if ErrorDetails property is set
        internal bool IsSetErrorDetails()
        {
            return this._errorDetails != null;
        }

        /// <summary>
        /// Gets and sets the property MetadataTableConfigurationResult. 
        /// <para>
        ///  The metadata table configuration for a general purpose bucket. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MetadataTableConfigurationResult MetadataTableConfigurationResult
        {
            get { return this._metadataTableConfigurationResult; }
            set { this._metadataTableConfigurationResult = value; }
        }

        // Check to see if MetadataTableConfigurationResult property is set
        internal bool IsSetMetadataTableConfigurationResult()
        {
            return this._metadataTableConfigurationResult != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The status of the metadata table. The status values are: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATING</c> - The metadata table is in the process of being created in the specified
        /// table bucket.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACTIVE</c> - The metadata table has been created successfully and records are
        /// being delivered to the table. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> - Amazon S3 is unable to create the metadata table, or Amazon S3 is
        /// unable to deliver records. See <c>ErrorDetails</c> for details.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}