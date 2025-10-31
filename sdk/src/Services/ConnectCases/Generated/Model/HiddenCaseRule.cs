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
    /// A rule that controls field visibility based on conditions. Fields can be shown or
    /// hidden dynamically based on values in other fields.
    /// </summary>
    public partial class HiddenCaseRule
    {
        private List<BooleanCondition> _conditions = AWSConfigs.InitializeCollections ? new List<BooleanCondition>() : null;
        private bool? _defaultValue;

        /// <summary>
        /// Gets and sets the property Conditions. 
        /// <para>
        /// A list of conditions that determine field visibility.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public List<BooleanCondition> Conditions
        {
            get { return this._conditions; }
            set { this._conditions = value; }
        }

        // Check to see if Conditions property is set
        internal bool IsSetConditions()
        {
            return this._conditions != null && (this._conditions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DefaultValue. 
        /// <para>
        /// Whether the field is hidden when no conditions match.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool DefaultValue
        {
            get { return this._defaultValue.GetValueOrDefault(); }
            set { this._defaultValue = value; }
        }

        // Check to see if DefaultValue property is set
        internal bool IsSetDefaultValue()
        {
            return this._defaultValue.HasValue; 
        }

    }
}