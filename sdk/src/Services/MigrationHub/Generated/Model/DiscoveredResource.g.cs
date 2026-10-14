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

namespace Amazon.MigrationHub.Model
{
    /// <summary>
    /// Object representing the on-premises resource being migrated.
    /// </summary>
    public partial class DiscoveredResource
    {
        /// <summary>
        /// Gets and sets the property ConfigurationId. 
        /// <para>
        /// The configurationId in Application Discovery Service that uniquely identifies the
        /// on-premise resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1600)]
        public string ConfigurationId { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationId property is set.
        /// </summary>
        internal bool IsSetConfigurationId() => this.ConfigurationId != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description that can be free-form text to record additional detail about the discovered
        /// resource for clarity or later reference.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;
    }
}
