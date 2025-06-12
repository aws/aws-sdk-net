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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
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
        private string _arn;
        private DateTime? _created;
        private ReportExportConfig _exportConfig;
        private DateTime? _lastModified;
        private string _name;
        private ReportGroupStatusType _status;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private ReportType _type;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the <c>ReportGroup</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Created. 
        /// <para>
        /// The date and time this <c>ReportGroup</c> was created. 
        /// </para>
        /// </summary>
        public DateTime? Created
        {
            get { return this._created; }
            set { this._created = value; }
        }

        // Check to see if Created property is set
        internal bool IsSetCreated()
        {
            return this._created.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExportConfig. 
        /// <para>
        /// Information about the destination where the raw data of this <c>ReportGroup</c> is
        /// exported. 
        /// </para>
        /// </summary>
        public ReportExportConfig ExportConfig
        {
            get { return this._exportConfig; }
            set { this._exportConfig = value; }
        }

        // Check to see if ExportConfig property is set
        internal bool IsSetExportConfig()
        {
            return this._exportConfig != null;
        }

        /// <summary>
        /// Gets and sets the property LastModified. 
        /// <para>
        /// The date and time this <c>ReportGroup</c> was last modified. 
        /// </para>
        /// </summary>
        public DateTime? LastModified
        {
            get { return this._lastModified; }
            set { this._lastModified = value; }
        }

        // Check to see if LastModified property is set
        internal bool IsSetLastModified()
        {
            return this._lastModified.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the <c>ReportGroup</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

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
        public ReportGroupStatusType Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        public ReportType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}