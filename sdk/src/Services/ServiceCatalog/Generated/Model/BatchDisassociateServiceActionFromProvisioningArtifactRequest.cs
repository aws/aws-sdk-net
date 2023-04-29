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
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// Container for the parameters to the BatchDisassociateServiceActionFromProvisioningArtifact operation.
    /// Disassociates a batch of self-service actions from the specified provisioning artifact.
    /// </summary>
    public partial class BatchDisassociateServiceActionFromProvisioningArtifactRequest : AmazonServiceCatalogRequest
    {
        private string _acceptLanguage;
        private List<ServiceActionAssociation> _serviceActionAssociations = new List<ServiceActionAssociation>();

        /// <summary>
        /// Gets and sets the property AcceptLanguage. 
        /// <para>
        /// The language code.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>jp</code> - Japanese
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>zh</code> - Chinese
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Max=100)]
        public string AcceptLanguage
        {
            get { return this._acceptLanguage; }
            set { this._acceptLanguage = value; }
        }

        // Check to see if AcceptLanguage property is set
        internal bool IsSetAcceptLanguage()
        {
            return this._acceptLanguage != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceActionAssociations. 
        /// <para>
        /// One or more associations, each consisting of the Action ID, the Product ID, and the
        /// Provisioning Artifact ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public List<ServiceActionAssociation> ServiceActionAssociations
        {
            get { return this._serviceActionAssociations; }
            set { this._serviceActionAssociations = value; }
        }

        // Check to see if ServiceActionAssociations property is set
        internal bool IsSetServiceActionAssociations()
        {
            return this._serviceActionAssociations != null && this._serviceActionAssociations.Count > 0; 
        }

    }
}