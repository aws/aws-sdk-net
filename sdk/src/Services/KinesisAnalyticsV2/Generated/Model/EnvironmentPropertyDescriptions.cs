/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// Describes the execution properties for a Java-based Amazon Kinesis Data Analytics
    /// application.
    /// </summary>
    public partial class EnvironmentPropertyDescriptions
    {
        private List<PropertyGroup> _propertyGroupDescriptions = new List<PropertyGroup>();

        /// <summary>
        /// Gets and sets the property PropertyGroupDescriptions. 
        /// <para>
        /// Describes the execution property groups.
        /// </para>
        /// </summary>
        public List<PropertyGroup> PropertyGroupDescriptions
        {
            get { return this._propertyGroupDescriptions; }
            set { this._propertyGroupDescriptions = value; }
        }

        // Check to see if PropertyGroupDescriptions property is set
        internal bool IsSetPropertyGroupDescriptions()
        {
            return this._propertyGroupDescriptions != null && this._propertyGroupDescriptions.Count > 0; 
        }

    }
}