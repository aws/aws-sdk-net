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
 * Do not modify this file. This file is generated from the inspector-2016-02-16.normal.json service model.
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
namespace Amazon.Inspector.Model
{
    /// <summary>
    /// Container for the parameters to the RemoveAttributesFromFindings operation.
    /// Removes entire attributes (key and value pairs) from the findings that are specified
    /// by the ARNs of the findings where an attribute with the specified key exists.
    /// </summary>
    public partial class RemoveAttributesFromFindingsRequest : AmazonInspectorRequest
    {
        private List<string> _attributeKeys = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _findingArns = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AttributeKeys. 
        /// <para>
        /// The array of attribute keys that you want to remove from specified findings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10)]
        public List<string> AttributeKeys
        {
            get { return this._attributeKeys; }
            set { this._attributeKeys = value; }
        }

        // Check to see if AttributeKeys property is set
        internal bool IsSetAttributeKeys()
        {
            return this._attributeKeys != null && (this._attributeKeys.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FindingArns. 
        /// <para>
        /// The ARNs that specify the findings that you want to remove attributes from.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<string> FindingArns
        {
            get { return this._findingArns; }
            set { this._findingArns = value; }
        }

        // Check to see if FindingArns property is set
        internal bool IsSetFindingArns()
        {
            return this._findingArns != null && (this._findingArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}