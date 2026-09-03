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
 * Do not modify this file. This file is generated from the pinpoint-sms-voice-v2-2022-03-31.normal.json service model.
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
namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// A single condition on a dependency field's value. Conditions are combined into a <b>ConditionalRule</b>
    /// and evaluated together with logical AND.
    /// </summary>
    public partial class FieldCondition
    {
        private string _dependsOnFieldPath;
        private string _operator;
        private List<string> _values = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property DependsOnFieldPath. 
        /// <para>
        /// The path of the field whose value determines this condition, for example <b>companyInfo.businessType</b>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string DependsOnFieldPath
        {
            get { return this._dependsOnFieldPath; }
            set { this._dependsOnFieldPath = value; }
        }

        // Check to see if DependsOnFieldPath property is set
        internal bool IsSetDependsOnFieldPath()
        {
            return this._dependsOnFieldPath != null;
        }

        /// <summary>
        /// Gets and sets the property Operator. 
        /// <para>
        /// The comparison operator to apply between the dependency field's value and <b>Values</b>.
        /// Valid values are <b>EQUALS</b>, <b>NOT_EQUALS</b>, <b>IN</b>, <b>NOT_IN</b>, <b>HAS_VALUE</b>,
        /// and <b>NO_VALUE</b>. Operators not in this list are treated as evaluating to false,
        /// which causes the containing rule to be skipped. This allows forward-compatible additions
        /// of new operators without breaking older SDK clients.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Operator
        {
            get { return this._operator; }
            set { this._operator = value; }
        }

        // Check to see if Operator property is set
        internal bool IsSetOperator()
        {
            return this._operator != null;
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// The values to compare the dependency field's value against. Required for the <b>EQUALS</b>,
        /// <b>NOT_EQUALS</b>, <b>IN</b>, and <b>NOT_IN</b> operators. Omitted for <b>HAS_VALUE</b>
        /// and <b>NO_VALUE</b>, which test only presence.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<string> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && (this._values.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}