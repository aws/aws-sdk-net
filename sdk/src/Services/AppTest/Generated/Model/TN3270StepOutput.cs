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
 * Do not modify this file. This file is generated from the apptest-2022-12-06.normal.json service model.
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
namespace Amazon.AppTest.Model
{
    /// <summary>
    /// Specifies a TN3270 step output.
    /// </summary>
    public partial class TN3270StepOutput
    {
        private List<DataSet> _dataSetDetails = AWSConfigs.InitializeCollections ? new List<DataSet>() : null;
        private string _dataSetExportLocation;
        private string _dmsOutputLocation;
        private string _scriptOutputLocation;

        /// <summary>
        /// Gets and sets the property DataSetDetails. 
        /// <para>
        /// The data set details of the TN3270 step output.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DataSet> DataSetDetails
        {
            get { return this._dataSetDetails; }
            set { this._dataSetDetails = value; }
        }

        // Check to see if DataSetDetails property is set
        internal bool IsSetDataSetDetails()
        {
            return this._dataSetDetails != null && (this._dataSetDetails.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DataSetExportLocation. 
        /// <para>
        /// The data set export location of the TN3270 step output.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string DataSetExportLocation
        {
            get { return this._dataSetExportLocation; }
            set { this._dataSetExportLocation = value; }
        }

        // Check to see if DataSetExportLocation property is set
        internal bool IsSetDataSetExportLocation()
        {
            return this._dataSetExportLocation != null;
        }

        /// <summary>
        /// Gets and sets the property DmsOutputLocation. 
        /// <para>
        /// The output location of the TN3270 step output.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string DmsOutputLocation
        {
            get { return this._dmsOutputLocation; }
            set { this._dmsOutputLocation = value; }
        }

        // Check to see if DmsOutputLocation property is set
        internal bool IsSetDmsOutputLocation()
        {
            return this._dmsOutputLocation != null;
        }

        /// <summary>
        /// Gets and sets the property ScriptOutputLocation. 
        /// <para>
        /// The script output location of the TN3270 step output.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1024)]
        public string ScriptOutputLocation
        {
            get { return this._scriptOutputLocation; }
            set { this._scriptOutputLocation = value; }
        }

        // Check to see if ScriptOutputLocation property is set
        internal bool IsSetScriptOutputLocation()
        {
            return this._scriptOutputLocation != null;
        }

    }
}