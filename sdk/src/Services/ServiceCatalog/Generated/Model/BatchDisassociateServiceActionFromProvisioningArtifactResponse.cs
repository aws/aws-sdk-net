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
    /// This is the response object from the BatchDisassociateServiceActionFromProvisioningArtifact operation.
    /// </summary>
    public partial class BatchDisassociateServiceActionFromProvisioningArtifactResponse : AmazonWebServiceResponse
    {
        private List<FailedServiceActionAssociation> _failedServiceActionAssociations = new List<FailedServiceActionAssociation>();

        /// <summary>
        /// Gets and sets the property FailedServiceActionAssociations. 
        /// <para>
        /// An object that contains a list of errors, along with information to help you identify
        /// the self-service action.
        /// </para>
        /// </summary>
        [AWSProperty(Max=50)]
        public List<FailedServiceActionAssociation> FailedServiceActionAssociations
        {
            get { return this._failedServiceActionAssociations; }
            set { this._failedServiceActionAssociations = value; }
        }

        // Check to see if FailedServiceActionAssociations property is set
        internal bool IsSetFailedServiceActionAssociations()
        {
            return this._failedServiceActionAssociations != null && this._failedServiceActionAssociations.Count > 0; 
        }

    }
}