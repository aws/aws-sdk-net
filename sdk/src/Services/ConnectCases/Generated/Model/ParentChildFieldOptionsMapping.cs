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
 * Do not modify this file. This file is generated from the connectcases-2022-10-03.normal.json service model.
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
namespace Amazon.ConnectCases.Model
{
    /// <summary>
    /// A mapping between a parent field option value and child field option values.
    /// </summary>
    public partial class ParentChildFieldOptionsMapping
    {
        private List<string> _childFieldOptionValues = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _parentFieldOptionValue;

        /// <summary>
        /// Gets and sets the property ChildFieldOptionValues. 
        /// <para>
        /// A list of allowed values in the child field.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1500)]
        public List<string> ChildFieldOptionValues
        {
            get { return this._childFieldOptionValues; }
            set { this._childFieldOptionValues = value; }
        }

        // Check to see if ChildFieldOptionValues property is set
        internal bool IsSetChildFieldOptionValues()
        {
            return this._childFieldOptionValues != null && (this._childFieldOptionValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ParentFieldOptionValue. 
        /// <para>
        /// The value in the parent field.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public string ParentFieldOptionValue
        {
            get { return this._parentFieldOptionValue; }
            set { this._parentFieldOptionValue = value; }
        }

        // Check to see if ParentFieldOptionValue property is set
        internal bool IsSetParentFieldOptionValue()
        {
            return this._parentFieldOptionValue != null;
        }

    }
}