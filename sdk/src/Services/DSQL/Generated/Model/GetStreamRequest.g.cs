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

namespace Amazon.DSQL.Model
{
    /// <summary>
    /// Container for the parameters to the GetStream operation. Retrieves information about
    /// a stream.
    /// </summary>
    public partial class GetStreamRequest : AmazonDSQLRequest
    {
        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The ID of the cluster containing the stream to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ClusterIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ClusterIdentifier property is set.
        /// </summary>
        internal bool IsSetClusterIdentifier() => this.ClusterIdentifier != null;

        /// <summary>
        /// Gets and sets the property StreamIdentifier. 
        /// <para>
        /// The ID of the stream to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string StreamIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the StreamIdentifier property is set.
        /// </summary>
        internal bool IsSetStreamIdentifier() => this.StreamIdentifier != null;
    }
}
