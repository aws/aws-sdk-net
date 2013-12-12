/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// <para>The provisioned throughput settings for the specified table. The settings can be modified using the <i>UpdateTable</i>
    /// operation.</para> <para>For current minimum and maximum provisioned throughput values, see <a
    /// href="http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Limits.html" >Limits</a> in the Amazon DynamoDB Developer
    /// Guide.</para>
    /// </summary>
    public class ProvisionedThroughput
    {
        
        private long? readCapacityUnits;
        private long? writeCapacityUnits;


        /// <summary>
        /// The maximum number of strongly consistent reads consumed per second before Amazon DynamoDB returns a <i>ThrottlingException</i>. For more
        /// information, see <a
        /// href="http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/WorkingWithDDTables.html#ProvisionedThroughput">Specifying Read and
        /// Write Requirements</a> in the Amazon DynamoDB Developer Guide.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>1 - </description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public long ReadCapacityUnits
        {
            get { return this.readCapacityUnits ?? default(long); }
            set { this.readCapacityUnits = value; }
        }

        // Check to see if ReadCapacityUnits property is set
        internal bool IsSetReadCapacityUnits()
        {
            return this.readCapacityUnits.HasValue;
        }

        /// <summary>
        /// The maximum number of writes consumed per second before Amazon DynamoDB returns a <i>ThrottlingException</i>. For more information, see <a
        /// href="http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/WorkingWithDDTables.html#ProvisionedThroughput">Specifying Read and
        /// Write Requirements</a> in the Amazon DynamoDB Developer Guide.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>1 - </description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public long WriteCapacityUnits
        {
            get { return this.writeCapacityUnits ?? default(long); }
            set { this.writeCapacityUnits = value; }
        }

        // Check to see if WriteCapacityUnits property is set
        internal bool IsSetWriteCapacityUnits()
        {
            return this.writeCapacityUnits.HasValue;
        }
    }
}
