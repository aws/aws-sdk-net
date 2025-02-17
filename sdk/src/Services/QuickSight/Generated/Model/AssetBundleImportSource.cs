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
    /// The source of the asset bundle zip file that contains the data that you want to import.
    /// The file must be in <c>QUICKSIGHT_JSON</c> format.
    /// </summary>
    public partial class AssetBundleImportSource
    {
        private MemoryStream _body;
        private string _s3Uri;

        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// The bytes of the base64 encoded asset bundle import zip file. This file can't exceed
        /// 20 MB. If the size of the file that you want to upload is more than 20 MB, add the
        /// file to your Amazon S3 bucket and use <c>S3Uri</c> of the file for this operation.
        /// </para>
        ///  
        /// <para>
        /// If you are calling the API operations from the Amazon Web Services SDK for Java, JavaScript,
        /// Python, or PHP, the SDK encodes base64 automatically to allow the direct setting of
        /// the zip file's bytes. If you are using an SDK for a different language or receiving
        /// related errors, try to base64 encode your data.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=20971520)]
        public MemoryStream Body
        {
            get { return this._body; }
            set { this._body = value; }
        }

        // Check to see if Body property is set
        internal bool IsSetBody()
        {
            return this._body != null;
        }

        /// <summary>
        /// Gets and sets the property S3Uri. 
        /// <para>
        /// The Amazon S3 URI for an asset bundle import file that exists in an Amazon S3 bucket
        /// that the caller has read access to. The file must be a zip format file and can't exceed
        /// 1 GB.
        /// </para>
        /// </summary>
        public string S3Uri
        {
            get { return this._s3Uri; }
            set { this._s3Uri = value; }
        }

        // Check to see if S3Uri property is set
        internal bool IsSetS3Uri()
        {
            return this._s3Uri != null;
        }

    }
}