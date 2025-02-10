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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the CreateContactFlowVersion operation.
    /// Publishes a new version of the flow provided. Versions are immutable and monotonically
    /// increasing. If the <c>FlowContentSha256</c> provided is different from the <c>FlowContentSha256</c>
    /// of the <c>$LATEST</c> published flow content, then an error is returned. This API
    /// only supports creating versions for flows of type <c>Campaign</c>.
    /// </summary>
    public partial class CreateContactFlowVersionRequest : AmazonConnectRequest
    {
        private string _contactFlowId;
        private long? _contactFlowVersion;
        private string _description;
        private string _flowContentSha256;
        private string _instanceId;
        private string _lastModifiedRegion;
        private DateTime? _lastModifiedTime;

        /// <summary>
        /// Gets and sets the property ContactFlowId. 
        /// <para>
        /// The identifier of the flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ContactFlowId
        {
            get { return this._contactFlowId; }
            set { this._contactFlowId = value; }
        }

        // Check to see if ContactFlowId property is set
        internal bool IsSetContactFlowId()
        {
            return this._contactFlowId != null;
        }

        /// <summary>
        /// Gets and sets the property ContactFlowVersion. 
        /// <para>
        /// The identifier of the flow version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public long? ContactFlowVersion
        {
            get { return this._contactFlowVersion; }
            set { this._contactFlowVersion = value; }
        }

        // Check to see if ContactFlowVersion property is set
        internal bool IsSetContactFlowVersion()
        {
            return this._contactFlowVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the flow version.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property FlowContentSha256. 
        /// <para>
        /// Indicates the checksum value of the flow content.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string FlowContentSha256
        {
            get { return this._flowContentSha256; }
            set { this._flowContentSha256 = value; }
        }

        // Check to see if FlowContentSha256 property is set
        internal bool IsSetFlowContentSha256()
        {
            return this._flowContentSha256 != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Amazon Connect instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedRegion. 
        /// <para>
        /// The Amazon Web Services Region where this resource was last modified.
        /// </para>
        /// </summary>
        public string LastModifiedRegion
        {
            get { return this._lastModifiedRegion; }
            set { this._lastModifiedRegion = value; }
        }

        // Check to see if LastModifiedRegion property is set
        internal bool IsSetLastModifiedRegion()
        {
            return this._lastModifiedRegion != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The Amazon Web Services Region where this resource was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

    }
}