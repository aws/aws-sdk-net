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
    /// A data table value summary.
    /// </summary>
    public partial class DataTableValueSummary
    {
        /// <summary>
        /// Gets and sets the property AttributeId. 
        /// <para>
        /// The summary's attribute ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string AttributeId { get; set; }

        /// <summary>
        /// Checks to see if the AttributeId property is set.
        /// </summary>
        internal bool IsSetAttributeId() => this.AttributeId != null;

        /// <summary>
        /// Gets and sets the property AttributeName. 
        /// <para>
        /// The summary's attribute name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 127)]
        public string AttributeName { get; set; }

        /// <summary>
        /// Checks to see if the AttributeName property is set.
        /// </summary>
        internal bool IsSetAttributeName() => this.AttributeName != null;

        /// <summary>
        /// Gets and sets the property LastModifiedRegion. 
        /// <para>
        /// The summary's last modified region.
        /// </para>
        /// </summary>
        public string LastModifiedRegion { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedRegion property is set.
        /// </summary>
        internal bool IsSetLastModifiedRegion() => this.LastModifiedRegion != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The summary's last modified time.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property LockVersion. 
        /// <para>
        /// The summary's lock version.
        /// </para>
        /// </summary>
        public DataTableLockVersion LockVersion { get; set; }

        /// <summary>
        /// Checks to see if the LockVersion property is set.
        /// </summary>
        internal bool IsSetLockVersion() => this.LockVersion != null;

        /// <summary>
        /// Gets and sets the property PrimaryValues. 
        /// <para>
        /// The summary's primary values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<PrimaryValueResponse> PrimaryValues { get; set; } = AWSConfigs.InitializeCollections ? new List<PrimaryValueResponse>() : null;

        /// <summary>
        /// Checks to see if the PrimaryValues property is set.
        /// </summary>
        internal bool IsSetPrimaryValues() => this.PrimaryValues != null && (this.PrimaryValues.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RecordId. 
        /// <para>
        /// The summary's record ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string RecordId { get; set; }

        /// <summary>
        /// Checks to see if the RecordId property is set.
        /// </summary>
        internal bool IsSetRecordId() => this.RecordId != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The summary's value.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;

        /// <summary>
        /// Gets and sets the property ValueType. 
        /// <para>
        /// The summary's value type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DataTableAttributeValueType ValueType { get; set; }

        /// <summary>
        /// Checks to see if the ValueType property is set.
        /// </summary>
        internal bool IsSetValueType() => this.ValueType != null;
    }
}
