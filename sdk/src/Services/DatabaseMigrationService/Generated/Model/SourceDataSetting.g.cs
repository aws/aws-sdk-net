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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Defines settings for a source data provider for a data migration.
    /// </summary>
    public partial class SourceDataSetting
    {
        /// <summary>
        /// Gets and sets the property CDCStartPosition. 
        /// <para>
        /// The change data capture (CDC) start position for the source data provider.
        /// </para>
        /// </summary>
        public string CDCStartPosition { get; set; }

        /// <summary>
        /// Checks to see if the CDCStartPosition property is set.
        /// </summary>
        internal bool IsSetCDCStartPosition() => this.CDCStartPosition != null;

        /// <summary>
        /// Gets and sets the property CDCStartTime. 
        /// <para>
        /// The change data capture (CDC) start time for the source data provider.
        /// </para>
        /// </summary>
        public DateTime? CDCStartTime { get; set; }

        /// <summary>
        /// Checks to see if the CDCStartTime property is set.
        /// </summary>
        internal bool IsSetCDCStartTime() => this.CDCStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property CDCStopTime. 
        /// <para>
        /// The change data capture (CDC) stop time for the source data provider.
        /// </para>
        /// </summary>
        public DateTime? CDCStopTime { get; set; }

        /// <summary>
        /// Checks to see if the CDCStopTime property is set.
        /// </summary>
        internal bool IsSetCDCStopTime() => this.CDCStopTime.HasValue;

        /// <summary>
        /// Gets and sets the property SlotName. 
        /// <para>
        /// The name of the replication slot on the source data provider. This attribute is only
        /// valid for a PostgreSQL or Aurora PostgreSQL source.
        /// </para>
        /// </summary>
        public string SlotName { get; set; }

        /// <summary>
        /// Checks to see if the SlotName property is set.
        /// </summary>
        internal bool IsSetSlotName() => this.SlotName != null;
    }
}
