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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// Specifies an attribute and value that filter the events returned.
    /// </summary>
    public partial class LookupAttribute
    {
        private LookupAttributeKey _attributeKey;
        private string _attributeValue;

        /// <summary>
        /// Gets and sets the property AttributeKey. 
        /// <para>
        /// Specifies an attribute on which to filter the events returned.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LookupAttributeKey AttributeKey
        {
            get { return this._attributeKey; }
            set { this._attributeKey = value; }
        }

        // Check to see if AttributeKey property is set
        internal bool IsSetAttributeKey()
        {
            return this._attributeKey != null;
        }

        /// <summary>
        /// Gets and sets the property AttributeValue. 
        /// <para>
        /// Specifies a value for the specified AttributeKey.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2000)]
        public string AttributeValue
        {
            get { return this._attributeValue; }
            set { this._attributeValue = value; }
        }

        // Check to see if AttributeValue property is set
        internal bool IsSetAttributeValue()
        {
            return this._attributeValue != null;
        }

    }
}