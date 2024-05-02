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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
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
namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// The S3 location where Identity Resolution Jobs write result files.
    /// </summary>
    public partial class ExportingLocation
    {
        private S3ExportingLocation _s3Exporting;

        /// <summary>
        /// Gets and sets the property S3Exporting. 
        /// <para>
        /// Information about the S3 location where Identity Resolution Jobs write result files.
        /// </para>
        /// </summary>
        public S3ExportingLocation S3Exporting
        {
            get { return this._s3Exporting; }
            set { this._s3Exporting = value; }
        }

        // Check to see if S3Exporting property is set
        internal bool IsSetS3Exporting()
        {
            return this._s3Exporting != null;
        }

    }
}