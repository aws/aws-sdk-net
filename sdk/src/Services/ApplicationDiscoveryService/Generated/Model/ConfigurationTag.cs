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
 * Do not modify this file. This file is generated from the discovery-2015-11-01.normal.json service model.
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
        private string _configurationId;
        private ConfigurationItemType _configurationType;
        private string _key;
        private DateTime? _timeOfCreation;
        private string _value;

        /// <summary>
        /// Gets and sets the property ConfigurationId. 
        /// <para>
        /// The configuration ID for the item to tag. You can specify a list of keys and values.
        /// </para>
        /// </summary>
        [AWSProperty(Max=200)]
        public string ConfigurationId
        {
            get { return this._configurationId; }
            set { this._configurationId = value; }
        }

        // Check to see if ConfigurationId property is set
        internal bool IsSetConfigurationId()
        {
            return this._configurationId != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigurationType. 
        /// <para>
        /// A type of IT asset to tag.
        /// </para>
        /// </summary>
        public ConfigurationItemType ConfigurationType
        {
            get { return this._configurationType; }
            set { this._configurationType = value; }
        }

        // Check to see if ConfigurationType property is set
        internal bool IsSetConfigurationType()
        {
            return this._configurationType != null;
        }

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// A type of tag on which to filter. For example, <i>serverType</i>.
        /// </para>
        /// </summary>
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property TimeOfCreation. 
        /// <para>
        /// The time the configuration tag was created in Coordinated Universal Time (UTC).
        /// </para>
        /// </summary>
        public DateTime? TimeOfCreation
        {
            get { return this._timeOfCreation; }
            set { this._timeOfCreation = value; }
        }

        // Check to see if TimeOfCreation property is set
        internal bool IsSetTimeOfCreation()
        {
            return this._timeOfCreation.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// A value on which to filter. For example <i>key = serverType</i> and <i>value = web
        /// server</i>.
        /// </para>
        /// </summary>
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}