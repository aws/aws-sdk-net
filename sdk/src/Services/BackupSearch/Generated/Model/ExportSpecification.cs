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
    /// This contains the export specification object.
    /// </summary>
    public partial class ExportSpecification
    {
        private S3ExportSpecification _s3ExportSpecification;

        /// <summary>
        /// Gets and sets the property S3ExportSpecification. 
        /// <para>
        /// This specifies the destination Amazon S3 bucket for the export job. And, if included,
        /// it also specifies the destination prefix.
        /// </para>
        /// </summary>
        public S3ExportSpecification S3ExportSpecification
        {
            get { return this._s3ExportSpecification; }
            set { this._s3ExportSpecification = value; }
        }

        // Check to see if S3ExportSpecification property is set
        internal bool IsSetS3ExportSpecification()
        {
            return this._s3ExportSpecification != null;
        }

    }
}