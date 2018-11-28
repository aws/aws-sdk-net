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
    /// Specifies the creation parameters for an Amazon Kinesis Data Analytics application.
    /// </summary>
    public partial class ApplicationConfiguration
    {
        private ApplicationCodeConfiguration _applicationCodeConfiguration;
        private ApplicationSnapshotConfiguration _applicationSnapshotConfiguration;
        private EnvironmentProperties _environmentProperties;
        private FlinkApplicationConfiguration _flinkApplicationConfiguration;
        private SqlApplicationConfiguration _sqlApplicationConfiguration;

        /// <summary>
        /// Gets and sets the property ApplicationCodeConfiguration. 
        /// <para>
        /// The code location and type parameters for a Java-based Kinesis Data Analytics application.
        /// </para>
        /// </summary>
        public ApplicationCodeConfiguration ApplicationCodeConfiguration
        {
            get { return this._applicationCodeConfiguration; }
            set { this._applicationCodeConfiguration = value; }
        }

        // Check to see if ApplicationCodeConfiguration property is set
        internal bool IsSetApplicationCodeConfiguration()
        {
            return this._applicationCodeConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationSnapshotConfiguration. 
        /// <para>
        /// Describes whether snapshots are enabled for a Java-based Kinesis Data Analytics application.
        /// </para>
        /// </summary>
        public ApplicationSnapshotConfiguration ApplicationSnapshotConfiguration
        {
            get { return this._applicationSnapshotConfiguration; }
            set { this._applicationSnapshotConfiguration = value; }
        }

        // Check to see if ApplicationSnapshotConfiguration property is set
        internal bool IsSetApplicationSnapshotConfiguration()
        {
            return this._applicationSnapshotConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentProperties. 
        /// <para>
        /// Describes execution properties for a Java-based Kinesis Data Analytics application.
        /// </para>
        /// </summary>
        public EnvironmentProperties EnvironmentProperties
        {
            get { return this._environmentProperties; }
            set { this._environmentProperties = value; }
        }

        // Check to see if EnvironmentProperties property is set
        internal bool IsSetEnvironmentProperties()
        {
            return this._environmentProperties != null;
        }

        /// <summary>
        /// Gets and sets the property FlinkApplicationConfiguration. 
        /// <para>
        /// The creation and update parameters for a Java-based Kinesis Data Analytics application.
        /// </para>
        /// </summary>
        public FlinkApplicationConfiguration FlinkApplicationConfiguration
        {
            get { return this._flinkApplicationConfiguration; }
            set { this._flinkApplicationConfiguration = value; }
        }

        // Check to see if FlinkApplicationConfiguration property is set
        internal bool IsSetFlinkApplicationConfiguration()
        {
            return this._flinkApplicationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SqlApplicationConfiguration. 
        /// <para>
        /// The creation and update parameters for an SQL-based Kinesis Data Analytics application.
        /// </para>
        /// </summary>
        public SqlApplicationConfiguration SqlApplicationConfiguration
        {
            get { return this._sqlApplicationConfiguration; }
            set { this._sqlApplicationConfiguration = value; }
        }

        // Check to see if SqlApplicationConfiguration property is set
        internal bool IsSetSqlApplicationConfiguration()
        {
            return this._sqlApplicationConfiguration != null;
        }

    }
}