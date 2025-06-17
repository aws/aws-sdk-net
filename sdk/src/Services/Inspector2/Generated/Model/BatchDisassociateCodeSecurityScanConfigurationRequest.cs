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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
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
namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// Container for the parameters to the BatchDisassociateCodeSecurityScanConfiguration operation.
    /// Disassociates multiple code repositories from an Amazon Inspector code security scan
    /// configuration.
    /// </summary>
    public partial class BatchDisassociateCodeSecurityScanConfigurationRequest : AmazonInspector2Request
    {
        private List<DisassociateConfigurationRequest> _disassociateConfigurationRequests = AWSConfigs.InitializeCollections ? new List<DisassociateConfigurationRequest>() : null;

        /// <summary>
        /// Gets and sets the property DisassociateConfigurationRequests. 
        /// <para>
        /// A list of code repositories to disassociate from the specified scan configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=25)]
        public List<DisassociateConfigurationRequest> DisassociateConfigurationRequests
        {
            get { return this._disassociateConfigurationRequests; }
            set { this._disassociateConfigurationRequests = value; }
        }

        // Check to see if DisassociateConfigurationRequests property is set
        internal bool IsSetDisassociateConfigurationRequests()
        {
            return this._disassociateConfigurationRequests != null && (this._disassociateConfigurationRequests.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}