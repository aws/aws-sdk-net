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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// Property key-value pairs passed into a Flink-based Kinesis Data Analytics application.
    /// </summary>
    public partial class PropertyGroup
    {
        private string _propertyGroupId;
        private Dictionary<string, string> _propertyMap = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property PropertyGroupId. 
        /// <para>
        /// Describes the key of an application execution property key-value pair.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public string PropertyGroupId
        {
            get { return this._propertyGroupId; }
            set { this._propertyGroupId = value; }
        }

        // Check to see if PropertyGroupId property is set
        internal bool IsSetPropertyGroupId()
        {
            return this._propertyGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property PropertyMap. 
        /// <para>
        /// Describes the value of an application execution property key-value pair.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public Dictionary<string, string> PropertyMap
        {
            get { return this._propertyMap; }
            set { this._propertyMap = value; }
        }

        // Check to see if PropertyMap property is set
        internal bool IsSetPropertyMap()
        {
            return this._propertyMap != null && this._propertyMap.Count > 0; 
        }

    }
}