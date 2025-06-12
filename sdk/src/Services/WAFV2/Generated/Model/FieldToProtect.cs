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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
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
namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// Specifies a field type and keys to protect in stored web request data. This is part
    /// of the data protection configuration for a web ACL.
    /// </summary>
    public partial class FieldToProtect
    {
        private List<string> _fieldKeys = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private FieldToProtectType _fieldType;

        /// <summary>
        /// Gets and sets the property FieldKeys. 
        /// <para>
        /// Specifies the keys to protect for the specified field type. If you don't specify any
        /// key, then all keys for the field type are protected. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=100)]
        public List<string> FieldKeys
        {
            get { return this._fieldKeys; }
            set { this._fieldKeys = value; }
        }

        // Check to see if FieldKeys property is set
        internal bool IsSetFieldKeys()
        {
            return this._fieldKeys != null && (this._fieldKeys.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FieldType. 
        /// <para>
        /// Specifies the web request component type to protect. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FieldToProtectType FieldType
        {
            get { return this._fieldType; }
            set { this._fieldType = value; }
        }

        // Check to see if FieldType property is set
        internal bool IsSetFieldType()
        {
            return this._fieldType != null;
        }

    }
}