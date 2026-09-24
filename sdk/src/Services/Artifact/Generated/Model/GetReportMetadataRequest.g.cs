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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the GetReportMetadata operation. Get the metadata
    /// for a single report.
    /// </summary>
    public partial class GetReportMetadataRequest : AmazonArtifactRequest
    {
        /// <summary>
        /// Gets and sets the property ReportId. 
        /// <para>
        /// Unique resource ID for the report resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ReportId { get; set; }

        /// <summary>
        /// Checks to see if the ReportId property is set.
        /// </summary>
        internal bool IsSetReportId() => this.ReportId != null;

        /// <summary>
        /// Gets and sets the property ReportVersion. 
        /// <para>
        /// Version for the report resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public long? ReportVersion { get; set; }

        /// <summary>
        /// Checks to see if the ReportVersion property is set.
        /// </summary>
        internal bool IsSetReportVersion() => this.ReportVersion.HasValue;
    }
}
