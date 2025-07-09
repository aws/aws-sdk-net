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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
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
namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// Defines a condition that restricts when a permission is effective. Conditions allow
    /// you to control access based on specific attributes of the request.
    /// </summary>
    public partial class PermissionCondition
    {
        private string _conditionKey;
        private PermissionConditionOperator _conditionOperator;
        private List<string> _conditionValues = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ConditionKey. 
        /// <para>
        /// The key for the condition. This identifies the attribute that the condition applies
        /// to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ConditionKey
        {
            get { return this._conditionKey; }
            set { this._conditionKey = value; }
        }

        // Check to see if ConditionKey property is set
        internal bool IsSetConditionKey()
        {
            return this._conditionKey != null;
        }

        /// <summary>
        /// Gets and sets the property ConditionOperator. 
        /// <para>
        /// The operator to use for the condition evaluation. This determines how the condition
        /// values are compared.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PermissionConditionOperator ConditionOperator
        {
            get { return this._conditionOperator; }
            set { this._conditionOperator = value; }
        }

        // Check to see if ConditionOperator property is set
        internal bool IsSetConditionOperator()
        {
            return this._conditionOperator != null;
        }

        /// <summary>
        /// Gets and sets the property ConditionValues. 
        /// <para>
        /// The values to compare against using the specified condition operator.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<string> ConditionValues
        {
            get { return this._conditionValues; }
            set { this._conditionValues = value; }
        }

        // Check to see if ConditionValues property is set
        internal bool IsSetConditionValues()
        {
            return this._conditionValues != null && (this._conditionValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}