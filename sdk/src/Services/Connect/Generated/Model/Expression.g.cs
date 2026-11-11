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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// A tagged union to specify expression for a routing step.
    /// </summary>
    public partial class Expression
    {
        /// <summary>
        /// Gets and sets the property AndExpression. 
        /// <para>
        /// List of routing expressions which will be AND-ed together.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Expression> AndExpression { get; set; } = AWSConfigs.InitializeCollections ? new List<Expression>() : null;

        /// <summary>
        /// Checks to see if the AndExpression property is set.
        /// </summary>
        internal bool IsSetAndExpression() => this.AndExpression != null && (this.AndExpression.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AttributeCondition. 
        /// <para>
        /// An object to specify the predefined attribute condition.
        /// </para>
        /// </summary>
        public AttributeCondition AttributeCondition { get; set; }

        /// <summary>
        /// Checks to see if the AttributeCondition property is set.
        /// </summary>
        internal bool IsSetAttributeCondition() => this.AttributeCondition != null;

        /// <summary>
        /// Gets and sets the property NotAttributeCondition.
        /// </summary>
        public AttributeCondition NotAttributeCondition { get; set; }

        /// <summary>
        /// Checks to see if the NotAttributeCondition property is set.
        /// </summary>
        internal bool IsSetNotAttributeCondition() => this.NotAttributeCondition != null;

        /// <summary>
        /// Gets and sets the property OrExpression. 
        /// <para>
        /// List of routing expressions which will be OR-ed together.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Expression> OrExpression { get; set; } = AWSConfigs.InitializeCollections ? new List<Expression>() : null;

        /// <summary>
        /// Checks to see if the OrExpression property is set.
        /// </summary>
        internal bool IsSetOrExpression() => this.OrExpression != null && (this.OrExpression.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
