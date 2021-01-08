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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// Describes the inputs, outputs, and reference data sources for a SQL-based Kinesis
    /// Data Analytics application.
    /// </summary>
    public partial class SqlApplicationConfigurationDescription
    {
        private List<InputDescription> _inputDescriptions = new List<InputDescription>();
        private List<OutputDescription> _outputDescriptions = new List<OutputDescription>();
        private List<ReferenceDataSourceDescription> _referenceDataSourceDescriptions = new List<ReferenceDataSourceDescription>();

        /// <summary>
        /// Gets and sets the property InputDescriptions. 
        /// <para>
        /// The array of <a>InputDescription</a> objects describing the input streams used by
        /// the application.
        /// </para>
        /// </summary>
        public List<InputDescription> InputDescriptions
        {
            get { return this._inputDescriptions; }
            set { this._inputDescriptions = value; }
        }

        // Check to see if InputDescriptions property is set
        internal bool IsSetInputDescriptions()
        {
            return this._inputDescriptions != null && this._inputDescriptions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OutputDescriptions. 
        /// <para>
        /// The array of <a>OutputDescription</a> objects describing the destination streams used
        /// by the application.
        /// </para>
        /// </summary>
        public List<OutputDescription> OutputDescriptions
        {
            get { return this._outputDescriptions; }
            set { this._outputDescriptions = value; }
        }

        // Check to see if OutputDescriptions property is set
        internal bool IsSetOutputDescriptions()
        {
            return this._outputDescriptions != null && this._outputDescriptions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ReferenceDataSourceDescriptions. 
        /// <para>
        /// The array of <a>ReferenceDataSourceDescription</a> objects describing the reference
        /// data sources used by the application.
        /// </para>
        /// </summary>
        public List<ReferenceDataSourceDescription> ReferenceDataSourceDescriptions
        {
            get { return this._referenceDataSourceDescriptions; }
            set { this._referenceDataSourceDescriptions = value; }
        }

        // Check to see if ReferenceDataSourceDescriptions property is set
        internal bool IsSetReferenceDataSourceDescriptions()
        {
            return this._referenceDataSourceDescriptions != null && this._referenceDataSourceDescriptions.Count > 0; 
        }

    }
}