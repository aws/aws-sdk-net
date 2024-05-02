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
 * Do not modify this file. This file is generated from the bcm-data-exports-2023-11-26.normal.json service model.
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
namespace Amazon.BCMDataExports.Model
{
    /// <summary>
    /// The details that are available for an export.
    /// </summary>
    public partial class Export
    {
        private DataQuery _dataQuery;
        private string _description;
        private DestinationConfigurations _destinationConfigurations;
        private string _exportArn;
        private string _name;
        private RefreshCadence _refreshCadence;

        /// <summary>
        /// Gets and sets the property DataQuery. 
        /// <para>
        /// The data query for this specific data export.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DataQuery DataQuery
        {
            get { return this._dataQuery; }
            set { this._dataQuery = value; }
        }

        // Check to see if DataQuery property is set
        internal bool IsSetDataQuery()
        {
            return this._dataQuery != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description for this specific data export.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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
        /// Gets and sets the property DestinationConfigurations. 
        /// <para>
        /// The destination configuration for this specific data export.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DestinationConfigurations DestinationConfigurations
        {
            get { return this._destinationConfigurations; }
            set { this._destinationConfigurations = value; }
        }

        // Check to see if DestinationConfigurations property is set
        internal bool IsSetDestinationConfigurations()
        {
            return this._destinationConfigurations != null;
        }

        /// <summary>
        /// Gets and sets the property ExportArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for this export.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string ExportArn
        {
            get { return this._exportArn; }
            set { this._exportArn = value; }
        }

        // Check to see if ExportArn property is set
        internal bool IsSetExportArn()
        {
            return this._exportArn != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of this specific data export.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// Gets and sets the property RefreshCadence. 
        /// <para>
        /// The cadence for Amazon Web Services to update the export in your S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RefreshCadence RefreshCadence
        {
            get { return this._refreshCadence; }
            set { this._refreshCadence = value; }
        }

        // Check to see if RefreshCadence property is set
        internal bool IsSetRefreshCadence()
        {
            return this._refreshCadence != null;
        }

    }
}