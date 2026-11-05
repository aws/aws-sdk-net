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

namespace Amazon.ApplicationDiscoveryService.Model
{
    /// <summary>
    /// Tags for a configuration item. Tags are metadata that help you categorize IT assets.
    /// </summary>
    public partial class ConfigurationTag
    {
        /// <summary>
        /// Gets and sets the property ConfigurationId. 
        /// <para>
        /// The configuration ID for the item to tag. You can specify a list of keys and values.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public string ConfigurationId { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationId property is set.
        /// </summary>
        internal bool IsSetConfigurationId() => this.ConfigurationId != null;

        /// <summary>
        /// Gets and sets the property ConfigurationType. 
        /// <para>
        /// A type of IT asset to tag.
        /// </para>
        /// </summary>
        public ConfigurationItemType ConfigurationType { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationType property is set.
        /// </summary>
        internal bool IsSetConfigurationType() => this.ConfigurationType != null;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// A type of tag on which to filter. For example, <i>serverType</i>.
        /// </para>
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// Checks to see if the Key property is set.
        /// </summary>
        internal bool IsSetKey() => this.Key != null;

        /// <summary>
        /// Gets and sets the property TimeOfCreation. 
        /// <para>
        /// The time the configuration tag was created in Coordinated Universal Time (UTC).
        /// </para>
        /// </summary>
        public DateTime? TimeOfCreation { get; set; }

        /// <summary>
        /// Checks to see if the TimeOfCreation property is set.
        /// </summary>
        internal bool IsSetTimeOfCreation() => this.TimeOfCreation.HasValue;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// A value on which to filter. For example <i>key = serverType</i> and <i>value = web
        /// server</i>.
        /// </para>
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
