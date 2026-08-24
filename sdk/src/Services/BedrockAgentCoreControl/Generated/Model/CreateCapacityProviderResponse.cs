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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// This is the response object from the CreateCapacityProvider operation.
    /// </summary>
    public partial class CreateCapacityProviderResponse : AmazonWebServiceResponse
    {
        private string _capacityProviderArn;
        private string _capacityProviderId;
        private string _name;
        private CapacityProviderStatus _status;

        /// <summary>
        /// Gets and sets the property CapacityProviderArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the capacity provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CapacityProviderArn
        {
            get { return this._capacityProviderArn; }
            set { this._capacityProviderArn = value; }
        }

        // Check to see if CapacityProviderArn property is set
        internal bool IsSetCapacityProviderArn()
        {
            return this._capacityProviderArn != null;
        }

        /// <summary>
        /// Gets and sets the property CapacityProviderId. 
        /// <para>
        /// The unique identifier of the created capacity provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=59)]
        public string CapacityProviderId
        {
            get { return this._capacityProviderId; }
            set { this._capacityProviderId = value; }
        }

        // Check to see if CapacityProviderId property is set
        internal bool IsSetCapacityProviderId()
        {
            return this._capacityProviderId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the capacity provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=48)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the capacity provider. For possible values, see <c>CapacityProviderStatus</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CapacityProviderStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}