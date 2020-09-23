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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Dashboard version.
    /// </summary>
    public partial class DashboardVersion
    {
        private string _arn;
        private DateTime? _createdTime;
        private List<string> _dataSetArns = new List<string>();
        private string _description;
        private List<DashboardError> _errors = new List<DashboardError>();
        private List<Sheet> _sheets = new List<Sheet>();
        private string _sourceEntityArn;
        private ResourceStatus _status;
        private string _themeArn;
        private long? _versionNumber;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The time that this dashboard version was created.
        /// </para>
        /// </summary>
        public DateTime CreatedTime
        {
            get { return this._createdTime.GetValueOrDefault(); }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataSetArns. 
        /// <para>
        /// The Amazon Resource Numbers (ARNs) for the datasets that are associated with this
        /// version of the dashboard.
        /// </para>
        /// </summary>
        [AWSProperty(Max=100)]
        public List<string> DataSetArns
        {
            get { return this._dataSetArns; }
            set { this._dataSetArns = value; }
        }

        // Check to see if DataSetArns property is set
        internal bool IsSetDataSetArns()
        {
            return this._dataSetArns != null && this._dataSetArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Description.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Errors. 
        /// <para>
        /// Errors associated with this dashboard version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<DashboardError> Errors
        {
            get { return this._errors; }
            set { this._errors = value; }
        }

        // Check to see if Errors property is set
        internal bool IsSetErrors()
        {
            return this._errors != null && this._errors.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Sheets. 
        /// <para>
        /// A list of the associated sheets with the unique identifier and name of each sheet.
        /// </para>
        /// </summary>
        [AWSProperty(Max=20)]
        public List<Sheet> Sheets
        {
            get { return this._sheets; }
            set { this._sheets = value; }
        }

        // Check to see if Sheets property is set
        internal bool IsSetSheets()
        {
            return this._sheets != null && this._sheets.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SourceEntityArn. 
        /// <para>
        /// Source entity ARN.
        /// </para>
        /// </summary>
        public string SourceEntityArn
        {
            get { return this._sourceEntityArn; }
            set { this._sourceEntityArn = value; }
        }

        // Check to see if SourceEntityArn property is set
        internal bool IsSetSourceEntityArn()
        {
            return this._sourceEntityArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The HTTP status of the request.
        /// </para>
        /// </summary>
        public ResourceStatus Status
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
        /// Gets and sets the property ThemeArn. 
        /// <para>
        /// The ARN of the theme associated with a version of the dashboard.
        /// </para>
        /// </summary>
        public string ThemeArn
        {
            get { return this._themeArn; }
            set { this._themeArn = value; }
        }

        // Check to see if ThemeArn property is set
        internal bool IsSetThemeArn()
        {
            return this._themeArn != null;
        }

        /// <summary>
        /// Gets and sets the property VersionNumber. 
        /// <para>
        /// Version number for this version of the dashboard.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public long VersionNumber
        {
            get { return this._versionNumber.GetValueOrDefault(); }
            set { this._versionNumber = value; }
        }

        // Check to see if VersionNumber property is set
        internal bool IsSetVersionNumber()
        {
            return this._versionNumber.HasValue; 
        }

    }
}