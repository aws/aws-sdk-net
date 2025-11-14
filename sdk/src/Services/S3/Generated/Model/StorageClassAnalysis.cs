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
    /// Specifies data related to access patterns to be collected and made available to analyze
    /// the tradeoffs between different storage classes for an Amazon S3 bucket.
    /// </summary>
    public partial class StorageClassAnalysis
    {
        private StorageClassAnalysisDataExport _dataExport;

        /// <summary>
        /// Gets and sets the property DataExport. 
        /// <para>
        /// Specifies how data related to the storage class analysis for an Amazon S3 bucket should
        /// be exported.
        /// </para>
        /// </summary>
        public StorageClassAnalysisDataExport DataExport
        {
            get { return this._dataExport; }
            set { this._dataExport = value; }
        }

        // Check to see if DataExport property is set
        internal bool IsSetDataExport()
        {
            return this._dataExport != null;
        }

    }
}