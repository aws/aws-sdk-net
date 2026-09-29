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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property ConditionKey. 
        /// <para>
        /// The key for the condition. This identifies the attribute that the condition applies
        /// to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ConditionKey { get; set; }

        /// <summary>
        /// Checks to see if the ConditionKey property is set.
        /// </summary>
        internal bool IsSetConditionKey() => this.ConditionKey != null;

        /// <summary>
        /// Gets and sets the property ConditionOperator. 
        /// <para>
        /// The operator to use for the condition evaluation. This determines how the condition
        /// values are compared.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PermissionConditionOperator ConditionOperator { get; set; }

        /// <summary>
        /// Checks to see if the ConditionOperator property is set.
        /// </summary>
        internal bool IsSetConditionOperator() => this.ConditionOperator != null;

        /// <summary>
        /// Gets and sets the property ConditionValues. 
        /// <para>
        /// The values to compare against using the specified condition operator.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1)]
        public List<string> ConditionValues { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ConditionValues property is set.
        /// </summary>
        internal bool IsSetConditionValues() => this.ConditionValues != null && (this.ConditionValues.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
