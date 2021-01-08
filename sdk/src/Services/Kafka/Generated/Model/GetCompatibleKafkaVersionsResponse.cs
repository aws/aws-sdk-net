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
 * Do not modify this file. This file is generated from the kafka-2018-11-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kafka.Model
{
    /// <summary>
    /// This is the response object from the GetCompatibleKafkaVersions operation.
    /// </summary>
    public partial class GetCompatibleKafkaVersionsResponse : AmazonWebServiceResponse
    {
        private List<CompatibleKafkaVersion> _compatibleKafkaVersions = new List<CompatibleKafkaVersion>();

        /// <summary>
        /// Gets and sets the property CompatibleKafkaVersions.             
        /// <para>
        /// A list of CompatibleKafkaVersion objects.
        /// </para>
        /// </summary>
        public List<CompatibleKafkaVersion> CompatibleKafkaVersions
        {
            get { return this._compatibleKafkaVersions; }
            set { this._compatibleKafkaVersions = value; }
        }

        // Check to see if CompatibleKafkaVersions property is set
        internal bool IsSetCompatibleKafkaVersions()
        {
            return this._compatibleKafkaVersions != null && this._compatibleKafkaVersions.Count > 0; 
        }

    }
}