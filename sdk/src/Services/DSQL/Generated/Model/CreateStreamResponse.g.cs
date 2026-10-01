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
    /// This is the response object from the CreateStream operation.
    /// </summary>
    public partial class CreateStreamResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the created stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The ID of the cluster for the created stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ClusterIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ClusterIdentifier property is set.
        /// </summary>
        internal bool IsSetClusterIdentifier() => this.ClusterIdentifier != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time when created the stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// The format of the created stream records.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public StreamFormat Format { get; set; }

        /// <summary>
        /// Checks to see if the Format property is set.
        /// </summary>
        internal bool IsSetFormat() => this.Format != null;

        /// <summary>
        /// Gets and sets the property Ordering. 
        /// <para>
        /// The ordering mode of the created stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public StreamOrdering Ordering { get; set; }

        /// <summary>
        /// Checks to see if the Ordering property is set.
        /// </summary>
        internal bool IsSetOrdering() => this.Ordering != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the created stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public StreamStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StreamIdentifier. 
        /// <para>
        /// The ID of the created stream.
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
