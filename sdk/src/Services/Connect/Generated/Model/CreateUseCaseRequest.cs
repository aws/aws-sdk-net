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
    /// This API is in preview release for Amazon Connect and is subject to change.
    /// 
    ///  
    /// <para>
    /// Creates a use case for an AppIntegration association.
    /// </para>
    /// </summary>
    public partial class CreateUseCaseRequest : AmazonConnectRequest
    {
        private string _instanceId;
        private string _integrationAssociationId;
        private UseCaseType _useCaseType;

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
        /// Gets and sets the property IntegrationAssociationId. 
        /// <para>
        /// The identifier for the AppIntegration association.
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
        /// Gets and sets the property UseCaseType. 
        /// <para>
        /// The type of use case to associate to the AppIntegration association. Each AppIntegration
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