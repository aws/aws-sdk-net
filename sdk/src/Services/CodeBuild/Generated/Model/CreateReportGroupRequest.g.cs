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

namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Container for the parameters to the CreateReportGroup operation. Creates a report
    /// group. A report group contains a collection of reports.
    /// </summary>
    public partial class CreateReportGroupRequest : AmazonCodeBuildRequest
    {
        /// <summary>
        /// Gets and sets the property ExportConfig. 
        /// <para>
        ///  A <c>ReportExportConfig</c> object that contains information about where the report
        /// group test results are exported. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ReportExportConfig ExportConfig { get; set; }

        /// <summary>
        /// Checks to see if the ExportConfig property is set.
        /// </summary>
        internal bool IsSetExportConfig() => this.ExportConfig != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the report group. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        ///  A list of tag key and value pairs associated with this report group. 
        /// </para>
        ///  
        /// <para>
        /// These tags are available for use by Amazon Web Services services that support CodeBuild
        /// report group tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        ///  The type of report group. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ReportType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
