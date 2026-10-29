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
    /// Container for the parameters to the CreateDataTable operation. Creates a new data
    /// table with the specified properties. Supports the creation of all table properties
    /// except for attributes and values. A table with no attributes and values is a valid
    /// state for a table. The number of tables per instance is limited to 100 per instance.
    /// Customers can request an increase by using Amazon Web Services Service Quotas.
    /// </summary>
    public partial class CreateDataTableRequest : AmazonConnectRequest
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional description for the data table. Must conform to Connect human readable
        /// string specification and have 0-250 characters. Whitespace must be trimmed first.
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
        /// The unique identifier for the Amazon Connect instance where the data table will be
        /// created.
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
        /// The name for the data table. Must conform to Connect human readable string specification
        /// and have 1-127 characters. Whitespace must be trimmed first. Must not start with the
        /// reserved case insensitive values 'connect:' and 'aws:'. Must be unique for the instance
        /// using case-insensitive comparison.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 127)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the data table. One of PUBLISHED or SAVED. Required parameter that determines
        /// the initial state of the table.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DataTableStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Key value pairs for attribute based access control (TBAC or ABAC). Optional tags to
        /// apply to the data table for organization and access control purposes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TimeZone. 
        /// <para>
        /// The IANA timezone identifier to use when resolving time based dynamic values. Required
        /// even if no time slices are specified.
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
        /// The data level that concurrent value edits are locked on. One of DATA_TABLE, PRIMARY_VALUE,
        /// ATTRIBUTE, VALUE, and NONE. NONE is the default if unspecified. This determines how
        /// concurrent edits are handled when multiple users attempt to modify values simultaneously.
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
