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
    /// A version of a template.
    /// </summary>
    public partial class TemplateVersion
    {
        private DateTime? _createdTime;
        private List<DataSetConfiguration> _dataSetConfigurations = new List<DataSetConfiguration>();
        private string _description;
        private List<TemplateError> _errors = new List<TemplateError>();
        private List<Sheet> _sheets = new List<Sheet>();
        private string _sourceEntityArn;
        private ResourceStatus _status;
        private string _themeArn;
        private long? _versionNumber;

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The time that this template version was created.
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
        /// Gets and sets the property DataSetConfigurations. 
        /// <para>
        /// Schema of the dataset identified by the placeholder. Any dashboard created from this
        /// template should be bound to new datasets matching the same schema described through
        /// this API operation.
        /// </para>
        /// </summary>
        [AWSProperty(Max=30)]
        public List<DataSetConfiguration> DataSetConfigurations
        {
            get { return this._dataSetConfigurations; }
            set { this._dataSetConfigurations = value; }
        }

        // Check to see if DataSetConfigurations property is set
        internal bool IsSetDataSetConfigurations()
        {
            return this._dataSetConfigurations != null && this._dataSetConfigurations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the template.
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
        /// Errors associated with this template version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<TemplateError> Errors
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
        /// The Amazon Resource Name (ARN) of an analysis or template that was used to create
        /// this template.
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
        /// The status that is associated with the template.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CREATION_IN_PROGRESS</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CREATION_SUCCESSFUL</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CREATION_FAILED</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>UPDATE_IN_PROGRESS</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>UPDATE_SUCCESSFUL</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>UPDATE_FAILED</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DELETED</code> 
        /// </para>
        ///  </li> </ul>
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
        /// The ARN of the theme associated with this version of the template.
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
        /// The version number of the template version.
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