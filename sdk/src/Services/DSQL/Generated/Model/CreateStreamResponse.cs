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
 * Do not modify this file. This file is generated from the dsql-2018-05-10.normal.json service model.
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
    /// The output of a created stream.
    /// </summary>
    public partial class CreateStreamResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private string _clusterIdentifier;
        private DateTime? _creationTime;
        private StreamFormat _format;
        private StreamOrdering _ordering;
        private StreamStatus _status;
        private string _streamIdentifier;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the created stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The ID of the cluster for the created stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ClusterIdentifier
        {
            get { return this._clusterIdentifier; }
            set { this._clusterIdentifier = value; }
        }

        // Check to see if ClusterIdentifier property is set
        internal bool IsSetClusterIdentifier()
        {
            return this._clusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time when created the stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// The format of the created stream records.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public StreamFormat Format
        {
            get { return this._format; }
            set { this._format = value; }
        }

        // Check to see if Format property is set
        internal bool IsSetFormat()
        {
            return this._format != null;
        }

        /// <summary>
        /// Gets and sets the property Ordering. 
        /// <para>
        /// The ordering mode of the created stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public StreamOrdering Ordering
        {
            get { return this._ordering; }
            set { this._ordering = value; }
        }

        // Check to see if Ordering property is set
        internal bool IsSetOrdering()
        {
            return this._ordering != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the created stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public StreamStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StreamIdentifier. 
        /// <para>
        /// The ID of the created stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string StreamIdentifier
        {
            get { return this._streamIdentifier; }
            set { this._streamIdentifier = value; }
        }

        // Check to see if StreamIdentifier property is set
        internal bool IsSetStreamIdentifier()
        {
            return this._streamIdentifier != null;
        }

    }
}