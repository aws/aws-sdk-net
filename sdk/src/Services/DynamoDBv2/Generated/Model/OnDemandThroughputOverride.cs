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
    /// Overrides the on-demand throughput settings for this replica table. If you don't specify
    /// a value for this parameter, it uses the source table's on-demand throughput settings.
    /// </summary>
    public partial class OnDemandThroughputOverride
    {
        private long? _maxReadRequestUnits;

        /// <summary>
        /// Gets and sets the property MaxReadRequestUnits. 
        /// <para>
        /// Maximum number of read request units for the specified replica table.
        /// </para>
        /// </summary>
        public long? MaxReadRequestUnits
        {
            get { return this._maxReadRequestUnits; }
            set { this._maxReadRequestUnits = value; }
        }

        // Check to see if MaxReadRequestUnits property is set
        internal bool IsSetMaxReadRequestUnits()
        {
            return this._maxReadRequestUnits.HasValue; 
        }

    }
}