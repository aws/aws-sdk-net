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
 * Do not modify this file. This file is generated from the lex-models-2017-04-19.normal.json service model.
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
namespace Amazon.LexModelBuildingService.Model
{
    /// <summary>
    /// Contains the default values for a slot. Default values are used when Amazon Lex hasn't
    /// determined a value for a slot.
    /// </summary>
    public partial class SlotDefaultValueSpec
    {
        private List<SlotDefaultValue> _defaultValueList = AWSConfigs.InitializeCollections ? new List<SlotDefaultValue>() : null;

        /// <summary>
        /// Gets and sets the property DefaultValueList. 
        /// <para>
        /// The default values for a slot. You can specify more than one default. For example,
        /// you can specify a default value to use from a matching context variable, a session
        /// attribute, or a fixed value.
        /// </para>
        ///  
        /// <para>
        /// The default value chosen is selected based on the order that you specify them in the
        /// list. For example, if you specify a context variable and a fixed value in that order,
        /// Amazon Lex uses the context variable if it is available, else it uses the fixed value.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10)]
        public List<SlotDefaultValue> DefaultValueList
        {
            get { return this._defaultValueList; }
            set { this._defaultValueList = value; }
        }

        // Check to see if DefaultValueList property is set
        internal bool IsSetDefaultValueList()
        {
            return this._defaultValueList != null && (this._defaultValueList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}