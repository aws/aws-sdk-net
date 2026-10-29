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
    /// This is the response object from the DescribeIndex operation.
    /// </summary>
    public partial class DescribeIndexResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property IndexName. 
        /// <para>
        /// The index name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string IndexName { get; set; }

        /// <summary>
        /// Checks to see if the IndexName property is set.
        /// </summary>
        internal bool IsSetIndexName() => this.IndexName != null;

        /// <summary>
        /// Gets and sets the property IndexStatus. 
        /// <para>
        /// The index status.
        /// </para>
        /// </summary>
        public IndexStatus IndexStatus { get; set; }

        /// <summary>
        /// Checks to see if the IndexStatus property is set.
        /// </summary>
        internal bool IsSetIndexStatus() => this.IndexStatus != null;

        /// <summary>
        /// Gets and sets the property Schema. 
        /// <para>
        /// Contains a value that specifies the type of indexing performed. Valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// REGISTRY – Your thing index contains only registry data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// REGISTRY_AND_SHADOW - Your thing index contains registry data and shadow data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// REGISTRY_AND_CONNECTIVITY_STATUS - Your thing index contains registry data and thing
        /// connectivity status data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// REGISTRY_AND_SHADOW_AND_CONNECTIVITY_STATUS - Your thing index contains registry data,
        /// shadow data, and thing connectivity status data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// MULTI_INDEXING_MODE - Your thing index contains multiple data sources. For more information,
        /// see <a href="https://docs.aws.amazon.com/iot/latest/apireference/API_GetIndexingConfiguration.html">GetIndexingConfiguration</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Schema { get; set; }

        /// <summary>
        /// Checks to see if the Schema property is set.
        /// </summary>
        internal bool IsSetSchema() => this.Schema != null;
    }
}
