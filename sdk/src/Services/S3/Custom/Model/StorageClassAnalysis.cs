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
    /// Class for StorageClassAnalysis
    /// </summary>
    public class StorageClassAnalysis
    {
        private StorageClassAnalysisDataExport storageClassAnalysisDataExport;

        /// <summary>
        /// A container used to describe how data related to the storage class analysis should be exported.
        /// </summary>
        public StorageClassAnalysisDataExport DataExport
        {
            get { return this.storageClassAnalysisDataExport; }
            set { this.storageClassAnalysisDataExport = value; }
        }

        // Check to see if DataExport property is set
        internal bool IsSetDataExport()
        {
            return this.storageClassAnalysisDataExport != null;
        }
    }
}
