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
 * Do not modify this file. This file is generated from the ec2-2014-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes an account attribute.
    /// </summary>
    public partial class AccountAttribute
    {
        private string _attributeName;
        private List<AccountAttributeValue> _attributeValues = new List<AccountAttributeValue>();

        /// <summary>
        /// Gets and sets the property AttributeName. 
        /// <para>
        /// The name of the account attribute.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property AttributeValues. 
        /// <para>
        /// One or more values for the account attribute.
        /// </para>
        /// </summary>
        public List<AccountAttributeValue> AttributeValues
        {
            get { return this._attributeValues; }
            set { this._attributeValues = value; }
        }

        // Check to see if AttributeValues property is set
        internal bool IsSetAttributeValues()
        {
            return this._attributeValues != null && this._attributeValues.Count > 0; 
        }

    }
}