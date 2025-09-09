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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Information about proficiency of a user.
    /// </summary>
    public partial class UserProficiency
    {
        private string _attributeName;
        private string _attributeValue;
        private float? _level;

        /// <summary>
        /// Gets and sets the property AttributeName. 
        /// <para>
        /// The name of user's proficiency. You must use name of predefined attribute present
        /// in the Amazon Connect instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string AttributeName
        {
            get { return this._attributeName; }
            set { this._attributeName = value; }
        }

        // Check to see if AttributeName property is set
        internal bool IsSetAttributeName()
        {
            return this._attributeName != null;
        }

        /// <summary>
        /// Gets and sets the property AttributeValue. 
        /// <para>
        /// The value of user's proficiency. You must use value of predefined attribute present
        /// in the Amazon Connect instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
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

        /// <summary>
        /// Gets and sets the property Level. 
        /// <para>
        /// The level of the proficiency. The valid values are 1, 2, 3, 4 and 5.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public float? Level
        {
            get { return this._level; }
            set { this._level = value; }
        }

        // Check to see if Level property is set
        internal bool IsSetLevel()
        {
            return this._level.HasValue; 
        }

    }
}