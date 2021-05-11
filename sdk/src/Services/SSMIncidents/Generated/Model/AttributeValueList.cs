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
 * Do not modify this file. This file is generated from the ssm-incidents-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SSMIncidents.Model
{
    /// <summary>
    /// Use the AttributeValueList to filter by string or integer values.
    /// </summary>
    public partial class AttributeValueList
    {
        private List<int> _integerValues = new List<int>();
        private List<string> _stringValues = new List<string>();

        /// <summary>
        /// Gets and sets the property IntegerValues. 
        /// <para>
        /// The list of integer values that the filter matches.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<int> IntegerValues
        {
            get { return this._integerValues; }
            set { this._integerValues = value; }
        }

        // Check to see if IntegerValues property is set
        internal bool IsSetIntegerValues()
        {
            return this._integerValues != null && this._integerValues.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StringValues. 
        /// <para>
        /// The list of string values that the filter matches.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> StringValues
        {
            get { return this._stringValues; }
            set { this._stringValues = value; }
        }

        // Check to see if StringValues property is set
        internal bool IsSetStringValues()
        {
            return this._stringValues != null && this._stringValues.Count > 0; 
        }

    }
}