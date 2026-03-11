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
 * Do not modify this file. This file is generated from the arc-region-switch-2022-07-26.normal.json service model.
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
namespace Amazon.ARCRegionswitch.Model
{
    /// <summary>
    /// Information about a report delivered to Amazon S3.
    /// </summary>
    public partial class S3ReportOutput
    {
        private string _s3ObjectKey;

        /// <summary>
        /// Gets and sets the property S3ObjectKey. 
        /// <para>
        /// The S3 object key where the generated report is stored.
        /// </para>
        /// </summary>
        public string S3ObjectKey
        {
            get { return this._s3ObjectKey; }
            set { this._s3ObjectKey = value; }
        }

        // Check to see if S3ObjectKey property is set
        internal bool IsSetS3ObjectKey()
        {
            return this._s3ObjectKey != null;
        }

    }
}