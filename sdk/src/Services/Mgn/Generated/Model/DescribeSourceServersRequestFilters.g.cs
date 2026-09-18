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

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Request to filter Source Servers list.
    /// </summary>
    public partial class DescribeSourceServersRequestFilters
    {
        /// <summary>
        /// Gets and sets the property ApplicationIDs. 
        /// <para>
        /// Request to filter Source Servers list by application IDs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<string> ApplicationIDs { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ApplicationIDs property is set.
        /// </summary>
        internal bool IsSetApplicationIDs() => this.ApplicationIDs != null && (this.ApplicationIDs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IsArchived. 
        /// <para>
        /// Request to filter Source Servers list by archived.
        /// </para>
        /// </summary>
        public bool? IsArchived { get; set; }

        /// <summary>
        /// Checks to see if the IsArchived property is set.
        /// </summary>
        internal bool IsSetIsArchived() => this.IsArchived.HasValue;

        /// <summary>
        /// Gets and sets the property LifeCycleStates. 
        /// <para>
        /// Request to filter Source Servers list by life cycle states.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<string> LifeCycleStates { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the LifeCycleStates property is set.
        /// </summary>
        internal bool IsSetLifeCycleStates() => this.LifeCycleStates != null && (this.LifeCycleStates.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ReplicationTypes. 
        /// <para>
        /// Request to filter Source Servers list by replication type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2)]
        public List<string> ReplicationTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ReplicationTypes property is set.
        /// </summary>
        internal bool IsSetReplicationTypes() => this.ReplicationTypes != null && (this.ReplicationTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SourceServerIDs. 
        /// <para>
        /// Request to filter Source Servers list by Source Server ID.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<string> SourceServerIDs { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SourceServerIDs property is set.
        /// </summary>
        internal bool IsSetSourceServerIDs() => this.SourceServerIDs != null && (this.SourceServerIDs.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
