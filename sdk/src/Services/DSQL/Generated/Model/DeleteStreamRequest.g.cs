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
    /// Container for the parameters to the DeleteStream operation. Deletes a stream from
    /// a cluster.
    /// </summary>
    public partial class DeleteStreamRequest : AmazonDSQLRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. Idempotency ensures that an API request completes only once. With an
        /// idempotent request, if the original request completes successfully, the subsequent
        /// retries with the same client token return the result from the original successful
        /// request and they have no additional effect.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a client token, the Amazon Web Services SDK automatically generates
        /// one.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The ID of the cluster containing the stream to delete.
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
        /// The ID of the stream to delete.
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
