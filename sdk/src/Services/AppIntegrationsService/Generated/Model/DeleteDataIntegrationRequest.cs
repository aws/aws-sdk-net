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
    /// Container for the parameters to the DeleteDataIntegration operation.
    /// Deletes the DataIntegration. Only DataIntegrations that don't have any DataIntegrationAssociations
    /// can be deleted. Deleting a DataIntegration also deletes the underlying Amazon AppFlow
    /// flow and service linked role. 
    /// 
    ///  <note> 
    /// <para>
    /// You cannot create a DataIntegration association for a DataIntegration that has been
    /// previously associated. Use a different DataIntegration, or recreate the DataIntegration
    /// using the <a href="https://docs.aws.amazon.com/appintegrations/latest/APIReference/API_CreateDataIntegration.html">CreateDataIntegration</a>
    /// API.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DeleteDataIntegrationRequest : AmazonAppIntegrationsServiceRequest
    {
        private string _dataIntegrationIdentifier;

        /// <summary>
        /// Gets and sets the property DataIntegrationIdentifier. 
        /// <para>
        /// A unique identifier for the DataIntegration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string DataIntegrationIdentifier
        {
            get { return this._dataIntegrationIdentifier; }
            set { this._dataIntegrationIdentifier = value; }
        }

        // Check to see if DataIntegrationIdentifier property is set
        internal bool IsSetDataIntegrationIdentifier()
        {
            return this._dataIntegrationIdentifier != null;
        }

    }
}