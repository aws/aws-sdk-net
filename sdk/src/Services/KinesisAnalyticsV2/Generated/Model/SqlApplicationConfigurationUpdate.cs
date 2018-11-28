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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// Describes updates to the input streams, destination streams, and reference data sources
    /// for an SQL-based Kinesis Data Analytics application.
    /// </summary>
    public partial class SqlApplicationConfigurationUpdate
    {
        private List<InputUpdate> _inputUpdates = new List<InputUpdate>();
        private List<OutputUpdate> _outputUpdates = new List<OutputUpdate>();
        private List<ReferenceDataSourceUpdate> _referenceDataSourceUpdates = new List<ReferenceDataSourceUpdate>();

        /// <summary>
        /// Gets and sets the property InputUpdates. 
        /// <para>
        /// The array of <a>InputUpdate</a> objects describing the new input streams used by the
        /// application.
        /// </para>
        /// </summary>
        public List<InputUpdate> InputUpdates
        {
            get { return this._inputUpdates; }
            set { this._inputUpdates = value; }
        }

        // Check to see if InputUpdates property is set
        internal bool IsSetInputUpdates()
        {
            return this._inputUpdates != null && this._inputUpdates.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OutputUpdates. 
        /// <para>
        /// The array of <a>OutputUpdate</a> objects describing the new destination streams used
        /// by the application.
        /// </para>
        /// </summary>
        public List<OutputUpdate> OutputUpdates
        {
            get { return this._outputUpdates; }
            set { this._outputUpdates = value; }
        }

        // Check to see if OutputUpdates property is set
        internal bool IsSetOutputUpdates()
        {
            return this._outputUpdates != null && this._outputUpdates.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ReferenceDataSourceUpdates. 
        /// <para>
        /// The array of <a>ReferenceDataSourceUpdate</a> objects describing the new reference
        /// data sources used by the application.
        /// </para>
        /// </summary>
        public List<ReferenceDataSourceUpdate> ReferenceDataSourceUpdates
        {
            get { return this._referenceDataSourceUpdates; }
            set { this._referenceDataSourceUpdates = value; }
        }

        // Check to see if ReferenceDataSourceUpdates property is set
        internal bool IsSetReferenceDataSourceUpdates()
        {
            return this._referenceDataSourceUpdates != null && this._referenceDataSourceUpdates.Count > 0; 
        }

    }
}