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
    /// Container for data related to the storage class analysis for an Amazon S3 bucket for
    /// export.
    /// </summary>
    public partial class StorageClassAnalysisDataExport
    {
        private AnalyticsExportDestination _destination;
        private StorageClassAnalysisSchemaVersion _outputSchemaVersion;

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The place to store the data for an analysis.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AnalyticsExportDestination Destination
        {
            get { return this._destination; }
            set { this._destination = value; }
        }

        // Check to see if Destination property is set
        internal bool IsSetDestination()
        {
            return this._destination != null;
        }

        /// <summary>
        /// Gets and sets the property OutputSchemaVersion. 
        /// <para>
        /// The version of the output schema to use when exporting data. Must be <c>V_1</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public StorageClassAnalysisSchemaVersion OutputSchemaVersion
        {
            get { return this._outputSchemaVersion; }
            set { this._outputSchemaVersion = value; }
        }

        // Check to see if OutputSchemaVersion property is set
        internal bool IsSetOutputSchemaVersion()
        {
            return this._outputSchemaVersion != null;
        }

    }
}