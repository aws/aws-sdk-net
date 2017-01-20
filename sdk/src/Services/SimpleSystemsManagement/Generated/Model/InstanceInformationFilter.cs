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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Describes a filter for a specific list of instances.
    /// </summary>
    public partial class InstanceInformationFilter
    {
        private InstanceInformationFilterKey _key;
        private List<string> _valueSet = new List<string>();

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The name of the filter. 
        /// </para>
        /// </summary>
        public InstanceInformationFilterKey Key
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
        /// Gets and sets the property ValueSet. 
        /// <para>
        /// The filter values.
        /// </para>
        /// </summary>
        public List<string> ValueSet
        {
            get { return this._valueSet; }
            set { this._valueSet = value; }
        }

        // Check to see if ValueSet property is set
        internal bool IsSetValueSet()
        {
            return this._valueSet != null && this._valueSet.Count > 0; 
        }

    }
}