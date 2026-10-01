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

namespace Amazon.Appflow.Model
{
    /// <summary>
    /// Information about required authentication parameters.
    /// </summary>
    public partial class AuthParameter
    {
        /// <summary>
        /// Gets and sets the property ConnectorSuppliedValues. 
        /// <para>
        /// Contains default values for this authentication parameter that are supplied by the
        /// connector.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ConnectorSuppliedValues { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ConnectorSuppliedValues property is set.
        /// </summary>
        internal bool IsSetConnectorSuppliedValues() => this.ConnectorSuppliedValues != null && (this.ConnectorSuppliedValues.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description about the authentication parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property IsRequired. 
        /// <para>
        /// Indicates whether this authentication parameter is required.
        /// </para>
        /// </summary>
        public bool? IsRequired { get; set; }

        /// <summary>
        /// Checks to see if the IsRequired property is set.
        /// </summary>
        internal bool IsSetIsRequired() => this.IsRequired.HasValue;

        /// <summary>
        /// Gets and sets the property IsSensitiveField. 
        /// <para>
        /// Indicates whether this authentication parameter is a sensitive field.
        /// </para>
        /// </summary>
        public bool? IsSensitiveField { get; set; }

        /// <summary>
        /// Checks to see if the IsSensitiveField property is set.
        /// </summary>
        internal bool IsSetIsSensitiveField() => this.IsSensitiveField.HasValue;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The authentication key required to authenticate with the connector.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string Key { get; set; }

        /// <summary>
        /// Checks to see if the Key property is set.
        /// </summary>
        internal bool IsSetKey() => this.Key != null;

        /// <summary>
        /// Gets and sets the property Label. 
        /// <para>
        /// Label used for authentication parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string Label { get; set; }

        /// <summary>
        /// Checks to see if the Label property is set.
        /// </summary>
        internal bool IsSetLabel() => this.Label != null;
    }
}
