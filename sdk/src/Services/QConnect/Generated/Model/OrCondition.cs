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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
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
namespace Amazon.QConnect.Model
{
    /// <summary>
    /// A list of conditions which would be applied together with an <c>OR</c> condition.
    /// </summary>
    public partial class OrCondition
    {
        private List<TagCondition> _andConditions = AWSConfigs.InitializeCollections ? new List<TagCondition>() : null;
        private TagCondition _tagCondition;

        /// <summary>
        /// Gets and sets the property AndConditions. 
        /// <para>
        /// A list of conditions which would be applied together with an <c>AND</c> condition.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagCondition> AndConditions
        {
            get { return this._andConditions; }
            set { this._andConditions = value; }
        }

        // Check to see if AndConditions property is set
        internal bool IsSetAndConditions()
        {
            return this._andConditions != null && (this._andConditions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TagCondition. 
        /// <para>
        /// A leaf node condition which can be used to specify a tag condition.
        /// </para>
        /// </summary>
        public TagCondition TagCondition
        {
            get { return this._tagCondition; }
            set { this._tagCondition = value; }
        }

        // Check to see if TagCondition property is set
        internal bool IsSetTagCondition()
        {
            return this._tagCondition != null;
        }

    }
}