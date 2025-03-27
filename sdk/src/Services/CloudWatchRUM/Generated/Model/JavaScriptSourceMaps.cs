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
 * Do not modify this file. This file is generated from the rum-2018-05-10.normal.json service model.
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
namespace Amazon.CloudWatchRUM.Model
{
    /// <summary>
    /// A structure that contains the configuration for how an app monitor can unminify JavaScript
    /// error stack traces using source maps.
    /// </summary>
    public partial class JavaScriptSourceMaps
    {
        private string _s3Uri;
        private DeobfuscationStatus _status;

        /// <summary>
        /// Gets and sets the property S3Uri. 
        /// <para>
        ///  The S3Uri of the bucket or folder that stores the source map files. It is required
        /// if status is ENABLED. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  Specifies whether JavaScript error stack traces should be unminified for this app
        /// monitor. The default is for JavaScript error stack trace unminification to be <c>DISABLED</c>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DeobfuscationStatus Status
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