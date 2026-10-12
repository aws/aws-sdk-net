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

namespace Amazon.Invoicing.Model
{
    /// <summary>
    /// Contains metadata for a procurement portal, including the portal identifier, name,
    /// and default feature configurations.
    /// </summary>
    public partial class ProcurementPortal
    {
        /// <summary>
        /// Gets and sets the property DefaultFeatureConfigurations. 
        /// <para>
        /// The default feature configurations for the procurement portal.
        /// </para>
        /// </summary>
        public FeatureConfigurations DefaultFeatureConfigurations { get; set; }

        /// <summary>
        /// Checks to see if the DefaultFeatureConfigurations property is set.
        /// </summary>
        internal bool IsSetDefaultFeatureConfigurations() => this.DefaultFeatureConfigurations != null;

        /// <summary>
        /// Gets and sets the property PortalDisplayName. 
        /// <para>
        /// The display name of the procurement portal.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string PortalDisplayName { get; set; }

        /// <summary>
        /// Checks to see if the PortalDisplayName property is set.
        /// </summary>
        internal bool IsSetPortalDisplayName() => this.PortalDisplayName != null;

        /// <summary>
        /// Gets and sets the property PortalIdentifier. 
        /// <para>
        /// The unique identifier of the procurement portal.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string PortalIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the PortalIdentifier property is set.
        /// </summary>
        internal bool IsSetPortalIdentifier() => this.PortalIdentifier != null;

        /// <summary>
        /// Gets and sets the property PortalName. 
        /// <para>
        /// The name of the procurement portal.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ProcurementPortalName PortalName { get; set; }

        /// <summary>
        /// Checks to see if the PortalName property is set.
        /// </summary>
        internal bool IsSetPortalName() => this.PortalName != null;
    }
}
