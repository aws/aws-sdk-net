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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Describes an action to write to a DynamoDB table.
    /// 
    ///  
    /// <para>
    /// The <c>tableName</c>, <c>hashKeyField</c>, and <c>rangeKeyField</c> values must match
    /// the values used when you created the table.
    /// </para>
    ///  
    /// <para>
    /// The <c>hashKeyValue</c> and <c>rangeKeyvalue</c> fields use a substitution template
    /// syntax. These templates provide data at runtime. The syntax is as follows: ${<i>sql-expression</i>}.
    /// </para>
    ///  
    /// <para>
    /// You can specify any valid expression in a WHERE or SELECT clause, including JSON properties,
    /// comparisons, calculations, and functions. For example, the following field uses the
    /// third level of the topic:
    /// </para>
    ///  
    /// <para>
    ///  <c>"hashKeyValue": "${topic(3)}"</c> 
    /// </para>
    ///  
    /// <para>
    /// The following field uses the timestamp:
    /// </para>
    ///  
    /// <para>
    ///  <c>"rangeKeyValue": "${timestamp()}"</c> 
    /// </para>
    /// </summary>
    public partial class DynamoDBAction
    {
        /// <summary>
        /// Gets and sets the property HashKeyField. 
        /// <para>
        /// The hash key name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string HashKeyField { get; set; }

        /// <summary>
        /// Checks to see if the HashKeyField property is set.
        /// </summary>
        internal bool IsSetHashKeyField() => this.HashKeyField != null;

        /// <summary>
        /// Gets and sets the property HashKeyType. 
        /// <para>
        /// The hash key type. Valid values are "STRING" or "NUMBER"
        /// </para>
        /// </summary>
        public DynamoKeyType HashKeyType { get; set; }

        /// <summary>
        /// Checks to see if the HashKeyType property is set.
        /// </summary>
        internal bool IsSetHashKeyType() => this.HashKeyType != null;

        /// <summary>
        /// Gets and sets the property HashKeyValue. 
        /// <para>
        /// The hash key value.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string HashKeyValue { get; set; }

        /// <summary>
        /// Checks to see if the HashKeyValue property is set.
        /// </summary>
        internal bool IsSetHashKeyValue() => this.HashKeyValue != null;

        /// <summary>
        /// Gets and sets the property Operation. 
        /// <para>
        /// The type of operation to be performed. This follows the substitution template, so
        /// it can be <c>${operation}</c>, but the substitution must result in one of the following:
        /// <c>INSERT</c>, <c>UPDATE</c>, or <c>DELETE</c>.
        /// </para>
        /// </summary>
        public string Operation { get; set; }

        /// <summary>
        /// Checks to see if the Operation property is set.
        /// </summary>
        internal bool IsSetOperation() => this.Operation != null;

        /// <summary>
        /// Gets and sets the property PayloadField. 
        /// <para>
        /// The action payload. This name can be customized.
        /// </para>
        /// </summary>
        public string PayloadField { get; set; }

        /// <summary>
        /// Checks to see if the PayloadField property is set.
        /// </summary>
        internal bool IsSetPayloadField() => this.PayloadField != null;

        /// <summary>
        /// Gets and sets the property RangeKeyField. 
        /// <para>
        /// The range key name.
        /// </para>
        /// </summary>
        public string RangeKeyField { get; set; }

        /// <summary>
        /// Checks to see if the RangeKeyField property is set.
        /// </summary>
        internal bool IsSetRangeKeyField() => this.RangeKeyField != null;

        /// <summary>
        /// Gets and sets the property RangeKeyType. 
        /// <para>
        /// The range key type. Valid values are "STRING" or "NUMBER"
        /// </para>
        /// </summary>
        public DynamoKeyType RangeKeyType { get; set; }

        /// <summary>
        /// Checks to see if the RangeKeyType property is set.
        /// </summary>
        internal bool IsSetRangeKeyType() => this.RangeKeyType != null;

        /// <summary>
        /// Gets and sets the property RangeKeyValue. 
        /// <para>
        /// The range key value.
        /// </para>
        /// </summary>
        public string RangeKeyValue { get; set; }

        /// <summary>
        /// Checks to see if the RangeKeyValue property is set.
        /// </summary>
        internal bool IsSetRangeKeyValue() => this.RangeKeyValue != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the IAM role that grants access to the DynamoDB table.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name of the DynamoDB table.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TableName { get; set; }

        /// <summary>
        /// Checks to see if the TableName property is set.
        /// </summary>
        internal bool IsSetTableName() => this.TableName != null;
    }
}
