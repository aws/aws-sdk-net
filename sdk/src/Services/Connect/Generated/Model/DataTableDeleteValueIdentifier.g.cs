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
    /// A data table delete value identifier.
    /// </summary>
    public partial class DataTableDeleteValueIdentifier
    {
        /// <summary>
        /// Gets and sets the property AttributeName. 
        /// <para>
        /// The identifier's attribute name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 127)]
        public string AttributeName { get; set; }

        /// <summary>
        /// Checks to see if the AttributeName property is set.
        /// </summary>
        internal bool IsSetAttributeName() => this.AttributeName != null;

        /// <summary>
        /// Gets and sets the property LockVersion. 
        /// <para>
        /// The identifier's lock version.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DataTableLockVersion LockVersion { get; set; }

        /// <summary>
        /// Checks to see if the LockVersion property is set.
        /// </summary>
        internal bool IsSetLockVersion() => this.LockVersion != null;

        /// <summary>
        /// Gets and sets the property PrimaryValues. 
        /// <para>
        /// The identifier's primary values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PrimaryValue> PrimaryValues { get; set; } = AWSConfigs.InitializeCollections ? new List<PrimaryValue>() : null;

        /// <summary>
        /// Checks to see if the PrimaryValues property is set.
        /// </summary>
        internal bool IsSetPrimaryValues() => this.PrimaryValues != null && (this.PrimaryValues.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
