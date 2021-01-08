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
    /// Describes updates to the execution property groups for a Flink-based Kinesis Data
    /// Analytics application.
    /// </summary>
    public partial class EnvironmentPropertyUpdates
    {
        private List<PropertyGroup> _propertyGroups = new List<PropertyGroup>();

        /// <summary>
        /// Gets and sets the property PropertyGroups. 
        /// <para>
        /// Describes updates to the execution property groups.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=50)]
        public List<PropertyGroup> PropertyGroups
        {
            get { return this._propertyGroups; }
            set { this._propertyGroups = value; }
        }

        // Check to see if PropertyGroups property is set
        internal bool IsSetPropertyGroups()
        {
            return this._propertyGroups != null && this._propertyGroups.Count > 0; 
        }

    }
}