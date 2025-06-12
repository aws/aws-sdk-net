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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
        private List<Expression> _andExpression = AWSConfigs.InitializeCollections ? new List<Expression>() : null;
        private AttributeCondition _attributeCondition;
        private AttributeCondition _notAttributeCondition;
        private List<Expression> _orExpression = AWSConfigs.InitializeCollections ? new List<Expression>() : null;

        /// <summary>
        /// Gets and sets the property AndExpression. 
        /// <para>
        /// List of routing expressions which will be AND-ed together.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Expression> AndExpression
        {
            get { return this._andExpression; }
            set { this._andExpression = value; }
        }

        // Check to see if AndExpression property is set
        internal bool IsSetAndExpression()
        {
            return this._andExpression != null && (this._andExpression.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AttributeCondition. 
        /// <para>
        /// An object to specify the predefined attribute condition.
        /// </para>
        /// </summary>
        public AttributeCondition AttributeCondition
        {
            get { return this._attributeCondition; }
            set { this._attributeCondition = value; }
        }

        // Check to see if AttributeCondition property is set
        internal bool IsSetAttributeCondition()
        {
            return this._attributeCondition != null;
        }

        /// <summary>
        /// Gets and sets the property NotAttributeCondition.
        /// </summary>
        public AttributeCondition NotAttributeCondition
        {
            get { return this._notAttributeCondition; }
            set { this._notAttributeCondition = value; }
        }

        // Check to see if NotAttributeCondition property is set
        internal bool IsSetNotAttributeCondition()
        {
            return this._notAttributeCondition != null;
        }

        /// <summary>
        /// Gets and sets the property OrExpression. 
        /// <para>
        /// List of routing expressions which will be OR-ed together.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Expression> OrExpression
        {
            get { return this._orExpression; }
            set { this._orExpression = value; }
        }

        // Check to see if OrExpression property is set
        internal bool IsSetOrExpression()
        {
            return this._orExpression != null && (this._orExpression.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}