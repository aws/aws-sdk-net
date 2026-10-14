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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// The properties of a single integration table, including the resource ARN, the table
    /// name, and the source or target table configuration.
    /// </summary>
    public partial class IntegrationTableProperties
    {
        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The connection ARN of the source, or the database ARN of the target.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;

        /// <summary>
        /// Gets and sets the property SourceTableConfig. 
        /// <para>
        /// A structure for the source table configuration.
        /// </para>
        /// </summary>
        public SourceTableConfig SourceTableConfig { get; set; }

        /// <summary>
        /// Checks to see if the SourceTableConfig property is set.
        /// </summary>
        internal bool IsSetSourceTableConfig() => this.SourceTableConfig != null;

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name of the source table to be replicated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string TableName { get; set; }

        /// <summary>
        /// Checks to see if the TableName property is set.
        /// </summary>
        internal bool IsSetTableName() => this.TableName != null;

        /// <summary>
        /// Gets and sets the property TargetTableConfig. 
        /// <para>
        /// A structure for the target table configuration.
        /// </para>
        /// </summary>
        public TargetTableConfig TargetTableConfig { get; set; }

        /// <summary>
        /// Checks to see if the TargetTableConfig property is set.
        /// </summary>
        internal bool IsSetTargetTableConfig() => this.TargetTableConfig != null;
    }
}
