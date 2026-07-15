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
 * Do not modify this file. This file is generated from the healthlake-2017-07-01.normal.json service model.
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
namespace Amazon.HealthLake.Model
{
    /// <summary>
    /// The Amazon S3 location and source format configuration for input data in a transformation
    /// job.
    /// </summary>
    public partial class TransformationInputDataConfig
    {
        private string _s3Uri;
        private SourceFormat _sourceFormat;

        /// <summary>
        /// Gets and sets the property S3Uri. 
        /// <para>
        /// The Amazon S3 URI of the input data to transform.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=8, Max=2048)]
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
        /// Gets and sets the property SourceFormat. 
        /// <para>
        /// The format of the source data files (C-CDA or CSV).
        /// </para>
        /// </summary>
        public SourceFormat SourceFormat
        {
            get { return this._sourceFormat; }
            set { this._sourceFormat = value; }
        }

        // Check to see if SourceFormat property is set
        internal bool IsSetSourceFormat()
        {
            return this._sourceFormat != null;
        }

    }
}