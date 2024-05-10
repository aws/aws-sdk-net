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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// The disk container object for the import snapshot request.
    /// </summary>
    public partial class SnapshotDiskContainer
    {
        private string _description;
        private string _format;
        private string _url;
        private UserBucket _userBucket;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the disk image being imported.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// The format of the disk image being imported.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>VHD</c> | <c>VMDK</c> | <c>RAW</c> 
        /// </para>
        /// </summary>
        public string Format
        {
            get { return this._format; }
            set { this._format = value; }
        }

        // Check to see if Format property is set
        internal bool IsSetFormat()
        {
            return this._format != null;
        }

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The URL to the Amazon S3-based disk image being imported. It can either be a https
        /// URL (https://..) or an Amazon S3 URL (s3://..).
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string Url
        {
            get { return this._url; }
            set { this._url = value; }
        }

        // Check to see if Url property is set
        internal bool IsSetUrl()
        {
            return this._url != null;
        }

        /// <summary>
        /// Gets and sets the property UserBucket. 
        /// <para>
        /// The Amazon S3 bucket for the disk image.
        /// </para>
        /// </summary>
        public UserBucket UserBucket
        {
            get { return this._userBucket; }
            set { this._userBucket = value; }
        }

        // Check to see if UserBucket property is set
        internal bool IsSetUserBucket()
        {
            return this._userBucket != null;
        }

    }
}