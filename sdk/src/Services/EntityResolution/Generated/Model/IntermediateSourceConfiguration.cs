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
 * Do not modify this file. This file is generated from the entityresolution-2018-05-10.normal.json service model.
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
namespace Amazon.EntityResolution.Model
{
    /// <summary>
    /// The Amazon S3 location that temporarily stores your data while it processes. Your
    /// information won't be saved permanently.
    /// </summary>
    public partial class IntermediateSourceConfiguration
    {
        private string _intermediates3Path;

        /// <summary>
        /// Gets and sets the property IntermediateS3Path. 
        /// <para>
        /// The Amazon S3 location (bucket and prefix). For example: <c>s3://provider_bucket/DOC-EXAMPLE-BUCKET</c>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string IntermediateS3Path
        {
            get { return this._intermediates3Path; }
            set { this._intermediates3Path = value; }
        }

        // Check to see if IntermediateS3Path property is set
        internal bool IsSetIntermediateS3Path()
        {
            return this._intermediates3Path != null;
        }

    }
}