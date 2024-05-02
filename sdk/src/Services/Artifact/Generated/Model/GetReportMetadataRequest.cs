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
 * Do not modify this file. This file is generated from the artifact-2018-05-10.normal.json service model.
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
namespace Amazon.Artifact.Model
{
    /// <summary>
    /// Container for the parameters to the GetReportMetadata operation.
    /// Get the metadata for a single report.
    /// </summary>
    public partial class GetReportMetadataRequest : AmazonArtifactRequest
    {
        private string _reportId;
        private long? _reportVersion;

        /// <summary>
        /// Gets and sets the property ReportId. 
        /// <para>
        /// Unique resource ID for the report resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ReportId
        {
            get { return this._reportId; }
            set { this._reportId = value; }
        }

        // Check to see if ReportId property is set
        internal bool IsSetReportId()
        {
            return this._reportId != null;
        }

        /// <summary>
        /// Gets and sets the property ReportVersion. 
        /// <para>
        /// Version for the report resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public long? ReportVersion
        {
            get { return this._reportVersion; }
            set { this._reportVersion = value; }
        }

        // Check to see if ReportVersion property is set
        internal bool IsSetReportVersion()
        {
            return this._reportVersion.HasValue; 
        }

    }
}