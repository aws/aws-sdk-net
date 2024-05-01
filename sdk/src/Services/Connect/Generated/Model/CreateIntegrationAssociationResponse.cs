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
    /// This is the response object from the CreateIntegrationAssociation operation.
    /// </summary>
    public partial class CreateIntegrationAssociationResponse : AmazonWebServiceResponse
    {
        private string _integrationAssociationArn;
        private string _integrationAssociationId;

        /// <summary>
        /// Gets and sets the property IntegrationAssociationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the association.
        /// </para>
        /// </summary>
        public string IntegrationAssociationArn
        {
            get { return this._integrationAssociationArn; }
            set { this._integrationAssociationArn = value; }
        }

        // Check to see if IntegrationAssociationArn property is set
        internal bool IsSetIntegrationAssociationArn()
        {
            return this._integrationAssociationArn != null;
        }

        /// <summary>
        /// Gets and sets the property IntegrationAssociationId. 
        /// <para>
        /// The identifier for the integration association.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
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

    }
}