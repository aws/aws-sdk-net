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

namespace Amazon.Elasticsearch.Model
{
    /// <summary>
    /// Specifies maintenance schedule duration: duration value and duration unit. See the
    /// <a href="https://docs.aws.amazon.com/elasticsearch-service/latest/developerguide/auto-tune.html"
    /// target="_blank">Developer Guide</a> for more information.
    /// </summary>
    public partial class Duration
    {
        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// Specifies the unit of a maintenance schedule duration. Valid value is HOURS. See the
        /// <a href="https://docs.aws.amazon.com/elasticsearch-service/latest/developerguide/auto-tune.html"
        /// target="_blank">Developer Guide</a> for more information.
        /// </para>
        /// </summary>
        public TimeUnit Unit { get; set; }

        /// <summary>
        /// Checks to see if the Unit property is set.
        /// </summary>
        internal bool IsSetUnit() => this.Unit != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        ///  Integer to specify the value of a maintenance schedule duration. See the <a href="https://docs.aws.amazon.com/elasticsearch-service/latest/developerguide/auto-tune.html"
        /// target="_blank">Developer Guide</a> for more information.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 24)]
        public long? Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value.HasValue;
    }
}
