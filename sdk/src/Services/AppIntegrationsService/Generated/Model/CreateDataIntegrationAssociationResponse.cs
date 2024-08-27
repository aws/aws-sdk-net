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
 * Do not modify this file. This file is generated from the appintegrations-2020-07-29.normal.json service model.
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
namespace Amazon.AppIntegrationsService.Model
{
    /// <summary>
    /// This is the response object from the CreateDataIntegrationAssociation operation.
    /// </summary>
    public partial class CreateDataIntegrationAssociationResponse : AmazonWebServiceResponse
    {
        private string _dataIntegrationArn;
        private string _dataIntegrationAssociationId;

        /// <summary>
        /// Gets and sets the property DataIntegrationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the DataIntegration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string DataIntegrationArn
        {
            get { return this._dataIntegrationArn; }
            set { this._dataIntegrationArn = value; }
        }

        // Check to see if DataIntegrationArn property is set
        internal bool IsSetDataIntegrationArn()
        {
            return this._dataIntegrationArn != null;
        }

        /// <summary>
        /// Gets and sets the property DataIntegrationAssociationId. 
        /// <para>
        /// A unique identifier. for the DataIntegrationAssociation.
        /// </para>
        /// </summary>
        public string DataIntegrationAssociationId
        {
            get { return this._dataIntegrationAssociationId; }
            set { this._dataIntegrationAssociationId = value; }
        }

        // Check to see if DataIntegrationAssociationId property is set
        internal bool IsSetDataIntegrationAssociationId()
        {
            return this._dataIntegrationAssociationId != null;
        }

    }
}