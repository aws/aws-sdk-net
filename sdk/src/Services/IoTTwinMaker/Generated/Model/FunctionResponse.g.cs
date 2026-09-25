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

namespace Amazon.IoTTwinMaker.Model
{
    /// <summary>
    /// The function response.
    /// </summary>
    public partial class FunctionResponse
    {
        /// <summary>
        /// Gets and sets the property ImplementedBy. 
        /// <para>
        /// The data connector.
        /// </para>
        /// </summary>
        public DataConnector ImplementedBy { get; set; }

        /// <summary>
        /// Checks to see if the ImplementedBy property is set.
        /// </summary>
        internal bool IsSetImplementedBy() => this.ImplementedBy != null;

        /// <summary>
        /// Gets and sets the property IsInherited. 
        /// <para>
        /// Indicates whether this function is inherited.
        /// </para>
        /// </summary>
        public bool? IsInherited { get; set; }

        /// <summary>
        /// Checks to see if the IsInherited property is set.
        /// </summary>
        internal bool IsSetIsInherited() => this.IsInherited.HasValue;

        /// <summary>
        /// Gets and sets the property RequiredProperties. 
        /// <para>
        /// The required properties of the function.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RequiredProperties { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RequiredProperties property is set.
        /// </summary>
        internal bool IsSetRequiredProperties() => this.RequiredProperties != null && (this.RequiredProperties.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// The scope of the function.
        /// </para>
        /// </summary>
        public Scope Scope { get; set; }

        /// <summary>
        /// Checks to see if the Scope property is set.
        /// </summary>
        internal bool IsSetScope() => this.Scope != null;
    }
}
