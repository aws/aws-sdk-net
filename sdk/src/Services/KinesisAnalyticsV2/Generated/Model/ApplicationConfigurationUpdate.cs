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
    /// Describes updates to an application's configuration.
    /// </summary>
    public partial class ApplicationConfigurationUpdate
    {
        private ApplicationCodeConfigurationUpdate _applicationCodeConfigurationUpdate;
        private ApplicationSnapshotConfigurationUpdate _applicationSnapshotConfigurationUpdate;
        private EnvironmentPropertyUpdates _environmentPropertyUpdates;
        private FlinkApplicationConfigurationUpdate _flinkApplicationConfigurationUpdate;
        private SqlApplicationConfigurationUpdate _sqlApplicationConfigurationUpdate;

        /// <summary>
        /// Gets and sets the property ApplicationCodeConfigurationUpdate. 
        /// <para>
        /// Describes updates to a Java-based Kinesis Data Analytics application's code configuration.
        /// </para>
        /// </summary>
        public ApplicationCodeConfigurationUpdate ApplicationCodeConfigurationUpdate
        {
            get { return this._applicationCodeConfigurationUpdate; }
            set { this._applicationCodeConfigurationUpdate = value; }
        }

        // Check to see if ApplicationCodeConfigurationUpdate property is set
        internal bool IsSetApplicationCodeConfigurationUpdate()
        {
            return this._applicationCodeConfigurationUpdate != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationSnapshotConfigurationUpdate. 
        /// <para>
        /// Describes whether snapshots are enabled for a Java-based Kinesis Data Analytics application.
        /// </para>
        /// </summary>
        public ApplicationSnapshotConfigurationUpdate ApplicationSnapshotConfigurationUpdate
        {
            get { return this._applicationSnapshotConfigurationUpdate; }
            set { this._applicationSnapshotConfigurationUpdate = value; }
        }

        // Check to see if ApplicationSnapshotConfigurationUpdate property is set
        internal bool IsSetApplicationSnapshotConfigurationUpdate()
        {
            return this._applicationSnapshotConfigurationUpdate != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentPropertyUpdates. 
        /// <para>
        /// Describes updates to the environment properties for a Java-based Kinesis Data Analytics
        /// application.
        /// </para>
        /// </summary>
        public EnvironmentPropertyUpdates EnvironmentPropertyUpdates
        {
            get { return this._environmentPropertyUpdates; }
            set { this._environmentPropertyUpdates = value; }
        }

        // Check to see if EnvironmentPropertyUpdates property is set
        internal bool IsSetEnvironmentPropertyUpdates()
        {
            return this._environmentPropertyUpdates != null;
        }

        /// <summary>
        /// Gets and sets the property FlinkApplicationConfigurationUpdate. 
        /// <para>
        /// Describes updates to a Java-based Kinesis Data Analytics application's configuration.
        /// </para>
        /// </summary>
        public FlinkApplicationConfigurationUpdate FlinkApplicationConfigurationUpdate
        {
            get { return this._flinkApplicationConfigurationUpdate; }
            set { this._flinkApplicationConfigurationUpdate = value; }
        }

        // Check to see if FlinkApplicationConfigurationUpdate property is set
        internal bool IsSetFlinkApplicationConfigurationUpdate()
        {
            return this._flinkApplicationConfigurationUpdate != null;
        }

        /// <summary>
        /// Gets and sets the property SqlApplicationConfigurationUpdate. 
        /// <para>
        /// Describes updates to an SQL-based Kinesis Data Analytics application's configuration.
        /// </para>
        /// </summary>
        public SqlApplicationConfigurationUpdate SqlApplicationConfigurationUpdate
        {
            get { return this._sqlApplicationConfigurationUpdate; }
            set { this._sqlApplicationConfigurationUpdate = value; }
        }

        // Check to see if SqlApplicationConfigurationUpdate property is set
        internal bool IsSetSqlApplicationConfigurationUpdate()
        {
            return this._sqlApplicationConfigurationUpdate != null;
        }

    }
}