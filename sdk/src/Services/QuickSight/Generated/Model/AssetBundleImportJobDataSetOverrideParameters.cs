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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The override parameters for a single dataset that is being imported.
    /// </summary>
    public partial class AssetBundleImportJobDataSetOverrideParameters
    {
        private string _dataSetId;
        private DataSetRefreshProperties _dataSetRefreshProperties;
        private string _name;

        /// <summary>
        /// Gets and sets the property DataSetId. 
        /// <para>
        /// The ID of the dataset to apply overrides to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DataSetId
        {
            get { return this._dataSetId; }
            set { this._dataSetId = value; }
        }

        // Check to see if DataSetId property is set
        internal bool IsSetDataSetId()
        {
            return this._dataSetId != null;
        }

        /// <summary>
        /// Gets and sets the property DataSetRefreshProperties.
        /// </summary>
        public DataSetRefreshProperties DataSetRefreshProperties
        {
            get { return this._dataSetRefreshProperties; }
            set { this._dataSetRefreshProperties = value; }
        }

        // Check to see if DataSetRefreshProperties property is set
        internal bool IsSetDataSetRefreshProperties()
        {
            return this._dataSetRefreshProperties != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A new name for the dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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

    }
}