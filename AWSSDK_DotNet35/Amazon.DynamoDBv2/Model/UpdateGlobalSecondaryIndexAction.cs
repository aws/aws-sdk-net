/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para>Represents the new provisioned throughput settings to be applied to a global secondary index.</para>
    /// </summary>
    public class UpdateGlobalSecondaryIndexAction
    {
        
        private string indexName;
        private ProvisionedThroughput provisionedThroughput;


        /// <summary>
        /// The name of the global secondary index to be updated.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>3 - 255</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[a-zA-Z0-9_.-]+</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string IndexName
        {
            get { return this.indexName; }
            set { this.indexName = value; }
        }

        // Check to see if IndexName property is set
        internal bool IsSetIndexName()
        {
            return this.indexName != null;
        }

        /// <summary>
        /// Represents the provisioned throughput settings for a specified table or index. The settings can be modified using the <i>UpdateTable</i>
        /// operation. For current minimum and maximum provisioned throughput values, see <a
        /// href="http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Limits.html">Limits</a> in the Amazon DynamoDB Developer Guide.
        ///  
        /// </summary>
        public ProvisionedThroughput ProvisionedThroughput
        {
            get { return this.provisionedThroughput; }
            set { this.provisionedThroughput = value; }
        }

        // Check to see if ProvisionedThroughput property is set
        internal bool IsSetProvisionedThroughput()
        {
            return this.provisionedThroughput != null;
        }
    }
}
