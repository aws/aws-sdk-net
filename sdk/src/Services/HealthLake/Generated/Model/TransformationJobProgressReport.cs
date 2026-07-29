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
    /// Contains progress metrics for a data transformation job, including counts of files
    /// scanned, converted, and failed.
    /// </summary>
    public partial class TransformationJobProgressReport
    {
        private long? _totalFilesConverted;
        private long? _totalFilesFailed;
        private long? _totalFilesScanned;
        private long? _totalResourcesGenerated;

        /// <summary>
        /// Gets and sets the property TotalFilesConverted. 
        /// <para>
        /// The total number of source files successfully converted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? TotalFilesConverted
        {
            get { return this._totalFilesConverted; }
            set { this._totalFilesConverted = value; }
        }

        // Check to see if TotalFilesConverted property is set
        internal bool IsSetTotalFilesConverted()
        {
            return this._totalFilesConverted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalFilesFailed. 
        /// <para>
        /// The total number of source files that failed conversion.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? TotalFilesFailed
        {
            get { return this._totalFilesFailed; }
            set { this._totalFilesFailed = value; }
        }

        // Check to see if TotalFilesFailed property is set
        internal bool IsSetTotalFilesFailed()
        {
            return this._totalFilesFailed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalFilesScanned. 
        /// <para>
        /// The total number of source files scanned by the job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? TotalFilesScanned
        {
            get { return this._totalFilesScanned; }
            set { this._totalFilesScanned = value; }
        }

        // Check to see if TotalFilesScanned property is set
        internal bool IsSetTotalFilesScanned()
        {
            return this._totalFilesScanned.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalResourcesGenerated. 
        /// <para>
        /// The total number of FHIR R4 resources generated across all converted files.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? TotalResourcesGenerated
        {
            get { return this._totalResourcesGenerated; }
            set { this._totalResourcesGenerated = value; }
        }

        // Check to see if TotalResourcesGenerated property is set
        internal bool IsSetTotalResourcesGenerated()
        {
            return this._totalResourcesGenerated.HasValue; 
        }

    }
}