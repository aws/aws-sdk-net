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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The Amazon S3 properties patch of a connection.
    /// </summary>
    public partial class S3PropertiesPatch
    {
        private string _s3AccessGrantLocationId;
        private string _s3Uri;

        /// <summary>
        /// Gets and sets the property S3AccessGrantLocationId. 
        /// <para>
        /// The Amazon S3 Access Grant location ID that's part of the Amazon S3 properties patch
        /// of a connection.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=64)]
        public string S3AccessGrantLocationId
        {
            get { return this._s3AccessGrantLocationId; }
            set { this._s3AccessGrantLocationId = value; }
        }

        // Check to see if S3AccessGrantLocationId property is set
        internal bool IsSetS3AccessGrantLocationId()
        {
            return this._s3AccessGrantLocationId != null;
        }

        /// <summary>
        /// Gets and sets the property S3Uri. 
        /// <para>
        /// The Amazon S3 URI that's part of the Amazon S3 properties patch of a connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
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