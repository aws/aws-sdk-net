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
    /// Container for the parameters to the CreateUseCase operation.
    /// Creates a use case for an integration association.
    /// </summary>
    public partial class CreateUseCaseRequest : AmazonConnectRequest
    {
        private string _instanceId;
        private string _integrationAssociationId;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private UseCaseType _useCaseType;

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
        /// Gets and sets the property IntegrationAssociationId. 
        /// <para>
        /// The identifier for the integration association.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string IntegrationAssociationId
        {
            get { return this._integrationAssociationId; }
            set { this._integrationAssociationId = value; }
        }

        // Check to see if IntegrationAssociationId property is set
        internal bool IsSetIntegrationAssociationId()
        {
            return this._integrationAssociationId != null;
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

        /// <summary>
        /// Gets and sets the property UseCaseType. 
        /// <para>
        /// The type of use case to associate to the integration association. Each integration
        /// association can have only one of each use case type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public UseCaseType UseCaseType
        {
            get { return this._useCaseType; }
            set { this._useCaseType = value; }
        }

        // Check to see if UseCaseType property is set
        internal bool IsSetUseCaseType()
        {
            return this._useCaseType != null;
        }

    }
}