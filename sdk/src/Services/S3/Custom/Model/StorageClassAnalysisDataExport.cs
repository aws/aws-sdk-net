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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;


namespace Amazon.S3.Model
{
    /// <summary>
    /// Class for StorageClassAnalysisDataExport
    /// </summary>
    public class StorageClassAnalysisDataExport
    {
        private StorageClassAnalysisSchemaVersion storageClassAnalysisSchemaVersion;
        private AnalyticsExportDestination analyticsExportDestination;

        /// <summary>
        /// The version of the output schema to use when exporting data. Must be V_1.
        /// </summary>
        public StorageClassAnalysisSchemaVersion OutputSchemaVersion
        {
            get { return this.storageClassAnalysisSchemaVersion; }
            set { this.storageClassAnalysisSchemaVersion = value; }
        }

        // Check to see if OutputSchemaVersion property is set
        internal bool IsSetOutputSchemaVersion()
        {
            return this.storageClassAnalysisSchemaVersion != null;
        }

        /// <summary>
        /// The place to store the data for an analysis.
        /// </summary>
        public AnalyticsExportDestination Destination
        {
            get { return this.analyticsExportDestination; }
            set { this.analyticsExportDestination = value; }
        }

        // Check to see if DataExport property is set
        internal bool IsSetDestination()
        {
            return this.analyticsExportDestination != null;
        }
    }
}
