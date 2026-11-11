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
    /// Describes constraints that apply to the template fields.
    /// </summary>
    public partial class TaskTemplateConstraints
    {
        /// <summary>
        /// Gets and sets the property InvisibleFields. 
        /// <para>
        /// Lists the fields that are invisible to agents.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InvisibleFieldInfo> InvisibleFields { get; set; } = AWSConfigs.InitializeCollections ? new List<InvisibleFieldInfo>() : null;

        /// <summary>
        /// Checks to see if the InvisibleFields property is set.
        /// </summary>
        internal bool IsSetInvisibleFields() => this.InvisibleFields != null && (this.InvisibleFields.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ReadOnlyFields. 
        /// <para>
        /// Lists the fields that are read-only to agents, and cannot be edited.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ReadOnlyFieldInfo> ReadOnlyFields { get; set; } = AWSConfigs.InitializeCollections ? new List<ReadOnlyFieldInfo>() : null;

        /// <summary>
        /// Checks to see if the ReadOnlyFields property is set.
        /// </summary>
        internal bool IsSetReadOnlyFields() => this.ReadOnlyFields != null && (this.ReadOnlyFields.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RequiredFields. 
        /// <para>
        /// Lists the fields that are required to be filled by agents.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RequiredFieldInfo> RequiredFields { get; set; } = AWSConfigs.InitializeCollections ? new List<RequiredFieldInfo>() : null;

        /// <summary>
        /// Checks to see if the RequiredFields property is set.
        /// </summary>
        internal bool IsSetRequiredFields() => this.RequiredFields != null && (this.RequiredFields.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
