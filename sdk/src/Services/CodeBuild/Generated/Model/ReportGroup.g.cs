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
    /// A series of reports. Each report contains information about the results from running
    /// a series of test cases. You specify the test cases for a report group in the buildspec
    /// for a build project using one or more paths to the test case files.
    /// </summary>
    public partial class ReportGroup
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the <c>ReportGroup</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Created. 
        /// <para>
        /// The date and time this <c>ReportGroup</c> was created. 
        /// </para>
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// Checks to see if the Created property is set.
        /// </summary>
        internal bool IsSetCreated() => this.Created.HasValue;

        /// <summary>
        /// Gets and sets the property ExportConfig. 
        /// <para>
        /// Information about the destination where the raw data of this <c>ReportGroup</c> is
        /// exported. 
        /// </para>
        /// </summary>
        public ReportExportConfig ExportConfig { get; set; }

        /// <summary>
        /// Checks to see if the ExportConfig property is set.
        /// </summary>
        internal bool IsSetExportConfig() => this.ExportConfig != null;

        /// <summary>
        /// Gets and sets the property LastModified. 
        /// <para>
        /// The date and time this <c>ReportGroup</c> was last modified. 
        /// </para>
        /// </summary>
        public DateTime? LastModified { get; set; }

        /// <summary>
        /// Checks to see if the LastModified property is set.
        /// </summary>
        internal bool IsSetLastModified() => this.LastModified.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the <c>ReportGroup</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the report group. This property is read-only.
        /// </para>
        ///  
        /// <para>
        /// This can be one of the following values:
        /// </para>
        ///  <dl> <dt>ACTIVE</dt> <dd> 
        /// <para>
        /// The report group is active.
        /// </para>
        ///  </dd> <dt>DELETING</dt> <dd> 
        /// <para>
        /// The report group is in the process of being deleted.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public ReportGroupStatusType Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tag key and value pairs associated with this report group. 
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
        /// The type of the <c>ReportGroup</c>. This can be one of the following values:
        /// </para>
        ///  <dl> <dt>CODE_COVERAGE</dt> <dd> 
        /// <para>
        /// The report group contains code coverage reports.
        /// </para>
        ///  </dd> <dt>TEST</dt> <dd> 
        /// <para>
        /// The report group contains test reports.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public ReportType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
