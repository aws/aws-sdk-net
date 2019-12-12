/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Container for the parameters to the CreateReportGroup operation.
    /// Creates a report group. A report group contains a collection of reports.
    /// </summary>
    public partial class CreateReportGroupRequest : AmazonCodeBuildRequest
    {
        private ReportExportConfig _exportConfig;
        private string _name;
        private ReportType _type;

        /// <summary>
        /// Gets and sets the property ExportConfig. 
        /// <para>
        ///  A <code>ReportExportConfig</code> object that contains information about where the
        /// report group test results are exported. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the report group. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=128)]
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
        /// Gets and sets the property Type. 
        /// <para>
        ///  The type of report group. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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