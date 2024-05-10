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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the meta data tags associated with a transit gateway policy rule.
    /// </summary>
    public partial class TransitGatewayPolicyRuleMetaData
    {
        private string _metaDataKey;
        private string _metaDataValue;

        /// <summary>
        /// Gets and sets the property MetaDataKey. 
        /// <para>
        /// The key name for the transit gateway policy rule meta data tag.
        /// </para>
        /// </summary>
        public string MetaDataKey
        {
            get { return this._metaDataKey; }
            set { this._metaDataKey = value; }
        }

        // Check to see if MetaDataKey property is set
        internal bool IsSetMetaDataKey()
        {
            return this._metaDataKey != null;
        }

        /// <summary>
        /// Gets and sets the property MetaDataValue. 
        /// <para>
        /// The value of the key for the transit gateway policy rule meta data tag.
        /// </para>
        /// </summary>
        public string MetaDataValue
        {
            get { return this._metaDataValue; }
            set { this._metaDataValue = value; }
        }

        // Check to see if MetaDataValue property is set
        internal bool IsSetMetaDataValue()
        {
            return this._metaDataValue != null;
        }

    }
}