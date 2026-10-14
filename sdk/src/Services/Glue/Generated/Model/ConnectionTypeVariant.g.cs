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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Represents a variant of a connection type in Glue. Connection type variants provide
    /// specific configurations and behaviors for different implementations of the same general
    /// connection type.
    /// </summary>
    public partial class ConnectionTypeVariant
    {
        /// <summary>
        /// Gets and sets the property ConnectionTypeVariantName. 
        /// <para>
        /// The unique identifier for the connection type variant. This name is used internally
        /// to identify the specific variant of a connection type. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ConnectionTypeVariantName { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionTypeVariantName property is set.
        /// </summary>
        internal bool IsSetConnectionTypeVariantName() => this.ConnectionTypeVariantName != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A detailed description of the connection type variant, including its purpose, use
        /// cases, and any specific configuration requirements.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The human-readable name for the connection type variant that is displayed in the Glue
        /// console.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property LogoUrl. 
        /// <para>
        /// The URL of the logo associated with a connection type variant.
        /// </para>
        /// </summary>
        public string LogoUrl { get; set; }

        /// <summary>
        /// Checks to see if the LogoUrl property is set.
        /// </summary>
        internal bool IsSetLogoUrl() => this.LogoUrl != null;
    }
}
