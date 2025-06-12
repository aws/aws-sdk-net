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
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
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
namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// Represents a PartiQL statement that uses parameters.
    /// </summary>
    public partial class ParameterizedStatement
    {
        private List<AttributeValue> _parameters = AWSConfigs.InitializeCollections ? new List<AttributeValue>() : null;
        private ReturnValuesOnConditionCheckFailure _returnValuesOnConditionCheckFailure;
        private string _statement;

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        ///  The parameter values. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<AttributeValue> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && (this._parameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ReturnValuesOnConditionCheckFailure. 
        /// <para>
        /// An optional parameter that returns the item attributes for a PartiQL <c>ParameterizedStatement</c>
        /// operation that failed a condition check.
        /// </para>
        ///  
        /// <para>
        /// There is no additional cost associated with requesting a return value aside from the
        /// small network and processing overhead of receiving a larger response. No read capacity
        /// units are consumed.
        /// </para>
        /// </summary>
        public ReturnValuesOnConditionCheckFailure ReturnValuesOnConditionCheckFailure
        {
            get { return this._returnValuesOnConditionCheckFailure; }
            set { this._returnValuesOnConditionCheckFailure = value; }
        }

        // Check to see if ReturnValuesOnConditionCheckFailure property is set
        internal bool IsSetReturnValuesOnConditionCheckFailure()
        {
            return this._returnValuesOnConditionCheckFailure != null;
        }

        /// <summary>
        /// Gets and sets the property Statement. 
        /// <para>
        ///  A PartiQL statement that uses parameters. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=8192)]
        public string Statement
        {
            get { return this._statement; }
            set { this._statement = value; }
        }

        // Check to see if Statement property is set
        internal bool IsSetStatement()
        {
            return this._statement != null;
        }

    }
}