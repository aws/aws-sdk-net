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
    /// Container for the parameters to the UpdateDataTableMetadata operation. Updates the
    /// metadata properties of a data table. Accepts all fields similar to CreateDataTable,
    /// except for fields and tags. There are no other granular update endpoints. It does
    /// not act as a patch operation - all properties must be provided or defaults will be
    /// used. Fields follow the same requirements as CreateDataTable.
    /// </summary>
    public partial class UpdateDataTableMetadataRequest : AmazonConnectRequest
    {
        /// <summary>
        /// Gets and sets the property DataTableId. 
        /// <para>
        /// The unique identifier for the data table. Must also accept the table ARN with or without
        /// a version alias. If the version is provided as part of the identifier or ARN, the
        /// version must be $LATEST. Providing any other alias fails with an error.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string DataTableId { get; set; }

        /// <summary>
        /// Checks to see if the DataTableId property is set.
        /// </summary>
        internal bool IsSetDataTableId() => this.DataTableId != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The updated description for the data table. Must conform to Connect human readable
        /// string specification and have 0-250 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 250)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

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
        /// Gets and sets the property Name. 
        /// <para>
        /// The updated name for the data table. Must conform to Connect human readable string
        /// specification and have 1-127 characters. Must be unique for the instance using case-insensitive
        /// comparison.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 127)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property TimeZone. 
        /// <para>
        /// The updated IANA timezone identifier to use when resolving time based dynamic values.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TimeZone { get; set; }

        /// <summary>
        /// Checks to see if the TimeZone property is set.
        /// </summary>
        internal bool IsSetTimeZone() => this.TimeZone != null;

        /// <summary>
        /// Gets and sets the property ValueLockLevel. 
        /// <para>
        /// The updated value lock level for the data table. One of DATA_TABLE, PRIMARY_VALUE,
        /// ATTRIBUTE, VALUE, and NONE.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DataTableLockLevel ValueLockLevel { get; set; }

        /// <summary>
        /// Checks to see if the ValueLockLevel property is set.
        /// </summary>
        internal bool IsSetValueLockLevel() => this.ValueLockLevel != null;
    }
}
