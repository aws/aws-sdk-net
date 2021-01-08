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
 * Do not modify this file. This file is generated from the kinesisanalytics-2015-08-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisAnalytics.Model
{
    /// <summary>
    /// Describes updates to apply to an existing Amazon Kinesis Analytics application.
    /// </summary>
    public partial class ApplicationUpdate
    {
        private string _applicationCodeUpdate;
        private List<CloudWatchLoggingOptionUpdate> _cloudWatchLoggingOptionUpdates = new List<CloudWatchLoggingOptionUpdate>();
        private List<InputUpdate> _inputUpdates = new List<InputUpdate>();
        private List<OutputUpdate> _outputUpdates = new List<OutputUpdate>();
        private List<ReferenceDataSourceUpdate> _referenceDataSourceUpdates = new List<ReferenceDataSourceUpdate>();

        /// <summary>
        /// Gets and sets the property ApplicationCodeUpdate. 
        /// <para>
        /// Describes application code updates.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=102400)]
        public string ApplicationCodeUpdate
        {
            get { return this._applicationCodeUpdate; }
            set { this._applicationCodeUpdate = value; }
        }

        // Check to see if ApplicationCodeUpdate property is set
        internal bool IsSetApplicationCodeUpdate()
        {
            return this._applicationCodeUpdate != null;
        }

        /// <summary>
        /// Gets and sets the property CloudWatchLoggingOptionUpdates. 
        /// <para>
        /// Describes application CloudWatch logging option updates.
        /// </para>
        /// </summary>
        public List<CloudWatchLoggingOptionUpdate> CloudWatchLoggingOptionUpdates
        {
            get { return this._cloudWatchLoggingOptionUpdates; }
            set { this._cloudWatchLoggingOptionUpdates = value; }
        }

        // Check to see if CloudWatchLoggingOptionUpdates property is set
        internal bool IsSetCloudWatchLoggingOptionUpdates()
        {
            return this._cloudWatchLoggingOptionUpdates != null && this._cloudWatchLoggingOptionUpdates.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property InputUpdates. 
        /// <para>
        /// Describes application input configuration updates.
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
        /// Describes application output configuration updates.
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
        /// Describes application reference data source updates.
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