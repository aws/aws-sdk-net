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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
    /// A structure that describes how data is partitioned on the target.
    /// </summary>
    public partial class IntegrationPartition
    {
        private string _fieldName;
        private string _functionSpec;

        /// <summary>
        /// Gets and sets the property FieldName. 
        /// <para>
        /// The field name used to partition data on the target. Avoid using columns that have
        /// unique values for each row (for example, `LastModifiedTimestamp`, `SystemModTimeStamp`)
        /// as the partition column. These columns are not suitable for partitioning because they
        /// create a large number of small partitions, which can lead to performance issues.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string FieldName
        {
            get { return this._fieldName; }
            set { this._fieldName = value; }
        }

        // Check to see if FieldName property is set
        internal bool IsSetFieldName()
        {
            return this._fieldName != null;
        }

        /// <summary>
        /// Gets and sets the property FunctionSpec. 
        /// <para>
        /// Specifies the function used to partition data on the target. The only accepted value
        /// for this parameter is `'identity'` (string). The `'identity'` function ensures that
        /// the data partitioning on the target follows the same scheme as the source. In other
        /// words, the partitioning structure of the source data is preserved in the target destination.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string FunctionSpec
        {
            get { return this._functionSpec; }
            set { this._functionSpec = value; }
        }

        // Check to see if FunctionSpec property is set
        internal bool IsSetFunctionSpec()
        {
            return this._functionSpec != null;
        }

    }
}