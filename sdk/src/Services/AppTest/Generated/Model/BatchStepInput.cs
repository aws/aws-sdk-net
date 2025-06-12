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
    /// Defines a batch step input.
    /// </summary>
    public partial class BatchStepInput
    {
        private string _batchJobName;
        private Dictionary<string, string> _batchJobParameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<string> _exportDataSetNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private MainframeActionProperties _properties;
        private MainframeResourceSummary _resource;

        /// <summary>
        /// Gets and sets the property BatchJobName. 
        /// <para>
        /// The batch job name of the batch step input.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BatchJobName
        {
            get { return this._batchJobName; }
            set { this._batchJobName = value; }
        }

        // Check to see if BatchJobName property is set
        internal bool IsSetBatchJobName()
        {
            return this._batchJobName != null;
        }

        /// <summary>
        /// Gets and sets the property BatchJobParameters. 
        /// <para>
        /// The batch job parameters of the batch step input.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> BatchJobParameters
        {
            get { return this._batchJobParameters; }
            set { this._batchJobParameters = value; }
        }

        // Check to see if BatchJobParameters property is set
        internal bool IsSetBatchJobParameters()
        {
            return this._batchJobParameters != null && (this._batchJobParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ExportDataSetNames. 
        /// <para>
        /// The export data set names of the batch step input.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ExportDataSetNames
        {
            get { return this._exportDataSetNames; }
            set { this._exportDataSetNames = value; }
        }

        // Check to see if ExportDataSetNames property is set
        internal bool IsSetExportDataSetNames()
        {
            return this._exportDataSetNames != null && (this._exportDataSetNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Properties. 
        /// <para>
        /// The properties of the batch step input.
        /// </para>
        /// </summary>
        public MainframeActionProperties Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }

        // Check to see if Properties property is set
        internal bool IsSetProperties()
        {
            return this._properties != null;
        }

        /// <summary>
        /// Gets and sets the property Resource. 
        /// <para>
        /// The resource of the batch step input.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MainframeResourceSummary Resource
        {
            get { return this._resource; }
            set { this._resource = value; }
        }

        // Check to see if Resource property is set
        internal bool IsSetResource()
        {
            return this._resource != null;
        }

    }
}