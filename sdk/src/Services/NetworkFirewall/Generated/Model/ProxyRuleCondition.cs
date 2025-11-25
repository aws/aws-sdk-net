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
 * Do not modify this file. This file is generated from the network-firewall-2020-11-12.normal.json service model.
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
namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// Match criteria that specify what traffic attributes to examine.
    /// </summary>
    public partial class ProxyRuleCondition
    {
        private string _conditionKey;
        private string _conditionOperator;
        private List<string> _conditionValues = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ConditionKey. 
        /// <para>
        /// Defines what is to be matched.
        /// </para>
        /// </summary>
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
        /// Defines how to perform a match.
        /// </para>
        /// </summary>
        public string ConditionOperator
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
        /// Specifes the exact value that needs to be matched against.
        /// </para>
        /// </summary>
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