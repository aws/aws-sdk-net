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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the CreateIntegrationAssociation operation.
    /// Creates an Amazon Web Services resource association with an Amazon Connect instance.
    /// </summary>
    public partial class CreateIntegrationAssociationRequest : AmazonConnectRequest
    {
        private string _instanceId;
        private string _integrationArn;
        private IntegrationType _integrationType;
        private string _sourceApplicationName;
        private string _sourceApplicationUrl;
        private SourceType _sourceType;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Amazon Connect instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
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
        /// Gets and sets the property IntegrationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the integration.
        /// </para>
        ///  <note> 
        /// <para>
        /// When integrating with Amazon Pinpoint, the Amazon Connect and Amazon Pinpoint instances
        /// must be in the same account.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public string IntegrationArn
        {
            get { return this._integrationArn; }
            set { this._integrationArn = value; }
        }

        // Check to see if IntegrationArn property is set
        internal bool IsSetIntegrationArn()
        {
            return this._integrationArn != null;
        }

        /// <summary>
        /// Gets and sets the property IntegrationType. 
        /// <para>
        /// The type of information to be ingested.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IntegrationType IntegrationType
        {
            get { return this._integrationType; }
            set { this._integrationType = value; }
        }

        // Check to see if IntegrationType property is set
        internal bool IsSetIntegrationType()
        {
            return this._integrationType != null;
        }

        /// <summary>
        /// Gets and sets the property SourceApplicationName. 
        /// <para>
        /// The name of the external application. This field is only required for the EVENT integration
        /// type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string SourceApplicationName
        {
            get { return this._sourceApplicationName; }
            set { this._sourceApplicationName = value; }
        }

        // Check to see if SourceApplicationName property is set
        internal bool IsSetSourceApplicationName()
        {
            return this._sourceApplicationName != null;
        }

        /// <summary>
        /// Gets and sets the property SourceApplicationUrl. 
        /// <para>
        /// The URL for the external application. This field is only required for the EVENT integration
        /// type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
        public string SourceApplicationUrl
        {
            get { return this._sourceApplicationUrl; }
            set { this._sourceApplicationUrl = value; }
        }

        // Check to see if SourceApplicationUrl property is set
        internal bool IsSetSourceApplicationUrl()
        {
            return this._sourceApplicationUrl != null;
        }

        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        /// The type of the data source. This field is only required for the EVENT integration
        /// type.
        /// </para>
        /// </summary>
        public SourceType SourceType
        {
            get { return this._sourceType; }
            set { this._sourceType = value; }
        }

        // Check to see if SourceType property is set
        internal bool IsSetSourceType()
        {
            return this._sourceType != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags used to organize, track, or control access for this resource. For example,
        /// { "tags": {"key1":"value1", "key2":"value2"} }.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}