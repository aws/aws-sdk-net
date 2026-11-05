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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDataTablePrimaryValues operation. Updates
    /// the primary values for a record. This operation affects all existing values that are
    /// currently associated to the record and its primary values. Users that have restrictions
    /// on attributes and/or primary values are not authorized to use this endpoint. The combination
    /// of new primary values must be unique within the table.
    /// </summary>
    public partial class UpdateDataTablePrimaryValuesRequest : AmazonConnectRequest
    {
        /// <summary>
        /// Gets and sets the property DataTableId. 
        /// <para>
        /// The unique identifier for the data table. Must also accept the table ARN with or without
        /// a version alias. If the version is provided as part of the identifier or ARN, the
        /// version must be one of the two available system managed aliases, $SAVED or $LATEST.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string DataTableId { get; set; }

        /// <summary>
        /// Checks to see if the DataTableId property is set.
        /// </summary>
        internal bool IsSetDataTableId() => this.DataTableId != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The unique identifier for the Amazon Connect instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property LockVersion. 
        /// <para>
        /// The lock version information required for optimistic locking to prevent concurrent
        /// modifications.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DataTableLockVersion LockVersion { get; set; }

        /// <summary>
        /// Checks to see if the LockVersion property is set.
        /// </summary>
        internal bool IsSetLockVersion() => this.LockVersion != null;

        /// <summary>
        /// Gets and sets the property NewPrimaryValues. 
        /// <para>
        /// The new primary values for the record. Required and must include values for all primary
        /// attributes. The combination must be unique within the table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<PrimaryValue> NewPrimaryValues { get; set; } = AWSConfigs.InitializeCollections ? new List<PrimaryValue>() : null;

        /// <summary>
        /// Checks to see if the NewPrimaryValues property is set.
        /// </summary>
        internal bool IsSetNewPrimaryValues() => this.NewPrimaryValues != null && (this.NewPrimaryValues.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PrimaryValues. 
        /// <para>
        /// The current primary values for the record. Required and must include values for all
        /// primary attributes. Fails if the table has primary attributes and some primary values
        /// are omitted.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<PrimaryValue> PrimaryValues { get; set; } = AWSConfigs.InitializeCollections ? new List<PrimaryValue>() : null;

        /// <summary>
        /// Checks to see if the PrimaryValues property is set.
        /// </summary>
        internal bool IsSetPrimaryValues() => this.PrimaryValues != null && (this.PrimaryValues.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
