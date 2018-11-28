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
    /// Describes details about the application code and starting parameters for an Amazon
    /// Kinesis Data Analytics application.
    /// </summary>
    public partial class ApplicationConfigurationDescription
    {
        private ApplicationCodeConfigurationDescription _applicationCodeConfigurationDescription;
        private ApplicationSnapshotConfigurationDescription _applicationSnapshotConfigurationDescription;
        private EnvironmentPropertyDescriptions _environmentPropertyDescriptions;
        private FlinkApplicationConfigurationDescription _flinkApplicationConfigurationDescription;
        private RunConfigurationDescription _runConfigurationDescription;
        private SqlApplicationConfigurationDescription _sqlApplicationConfigurationDescription;

        /// <summary>
        /// Gets and sets the property ApplicationCodeConfigurationDescription. 
        /// <para>
        /// The details about the application code for a Java-based Kinesis Data Analytics application.
        /// </para>
        /// </summary>
        public ApplicationCodeConfigurationDescription ApplicationCodeConfigurationDescription
        {
            get { return this._applicationCodeConfigurationDescription; }
            set { this._applicationCodeConfigurationDescription = value; }
        }

        // Check to see if ApplicationCodeConfigurationDescription property is set
        internal bool IsSetApplicationCodeConfigurationDescription()
        {
            return this._applicationCodeConfigurationDescription != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationSnapshotConfigurationDescription. 
        /// <para>
        /// Describes whether snapshots are enabled for a Java-based Kinesis Data Analytics application.
        /// </para>
        /// </summary>
        public ApplicationSnapshotConfigurationDescription ApplicationSnapshotConfigurationDescription
        {
            get { return this._applicationSnapshotConfigurationDescription; }
            set { this._applicationSnapshotConfigurationDescription = value; }
        }

        // Check to see if ApplicationSnapshotConfigurationDescription property is set
        internal bool IsSetApplicationSnapshotConfigurationDescription()
        {
            return this._applicationSnapshotConfigurationDescription != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentPropertyDescriptions. 
        /// <para>
        /// Describes execution properties for a Java-based Kinesis Data Analytics application.
        /// </para>
        /// </summary>
        public EnvironmentPropertyDescriptions EnvironmentPropertyDescriptions
        {
            get { return this._environmentPropertyDescriptions; }
            set { this._environmentPropertyDescriptions = value; }
        }

        // Check to see if EnvironmentPropertyDescriptions property is set
        internal bool IsSetEnvironmentPropertyDescriptions()
        {
            return this._environmentPropertyDescriptions != null;
        }

        /// <summary>
        /// Gets and sets the property FlinkApplicationConfigurationDescription. 
        /// <para>
        /// The details about a Java-based Kinesis Data Analytics application.
        /// </para>
        /// </summary>
        public FlinkApplicationConfigurationDescription FlinkApplicationConfigurationDescription
        {
            get { return this._flinkApplicationConfigurationDescription; }
            set { this._flinkApplicationConfigurationDescription = value; }
        }

        // Check to see if FlinkApplicationConfigurationDescription property is set
        internal bool IsSetFlinkApplicationConfigurationDescription()
        {
            return this._flinkApplicationConfigurationDescription != null;
        }

        /// <summary>
        /// Gets and sets the property RunConfigurationDescription. 
        /// <para>
        /// The details about the starting properties for a Kinesis Data Analytics application.
        /// </para>
        /// </summary>
        public RunConfigurationDescription RunConfigurationDescription
        {
            get { return this._runConfigurationDescription; }
            set { this._runConfigurationDescription = value; }
        }

        // Check to see if RunConfigurationDescription property is set
        internal bool IsSetRunConfigurationDescription()
        {
            return this._runConfigurationDescription != null;
        }

        /// <summary>
        /// Gets and sets the property SqlApplicationConfigurationDescription. 
        /// <para>
        /// The details about inputs, outputs, and reference data sources for an SQL-based Kinesis
        /// Data Analytics application.
        /// </para>
        /// </summary>
        public SqlApplicationConfigurationDescription SqlApplicationConfigurationDescription
        {
            get { return this._sqlApplicationConfigurationDescription; }
            set { this._sqlApplicationConfigurationDescription = value; }
        }

        // Check to see if SqlApplicationConfigurationDescription property is set
        internal bool IsSetSqlApplicationConfigurationDescription()
        {
            return this._sqlApplicationConfigurationDescription != null;
        }

    }
}