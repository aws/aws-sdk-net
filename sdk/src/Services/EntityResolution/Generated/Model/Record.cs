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
 * Do not modify this file. This file is generated from the entityresolution-2018-05-10.normal.json service model.
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
namespace Amazon.EntityResolution.Model
{
    /// <summary>
    /// The record.
    /// </summary>
    public partial class Record
    {
        private string _inputSourceARN;
        private Dictionary<string, string> _recordAttributeMap = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _uniqueId;

        /// <summary>
        /// Gets and sets the property InputSourceARN. 
        /// <para>
        ///  The input source ARN of the record.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string InputSourceARN
        {
            get { return this._inputSourceARN; }
            set { this._inputSourceARN = value; }
        }

        // Check to see if InputSourceARN property is set
        internal bool IsSetInputSourceARN()
        {
            return this._inputSourceARN != null;
        }

        /// <summary>
        /// Gets and sets the property RecordAttributeMap. 
        /// <para>
        ///  The record's attribute map.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public Dictionary<string, string> RecordAttributeMap
        {
            get { return this._recordAttributeMap; }
            set { this._recordAttributeMap = value; }
        }

        // Check to see if RecordAttributeMap property is set
        internal bool IsSetRecordAttributeMap()
        {
            return this._recordAttributeMap != null && (this._recordAttributeMap.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UniqueId. 
        /// <para>
        ///  The unique ID of the record.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=38)]
        public string UniqueId
        {
            get { return this._uniqueId; }
            set { this._uniqueId = value; }
        }

        // Check to see if UniqueId property is set
        internal bool IsSetUniqueId()
        {
            return this._uniqueId != null;
        }

    }
}