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
    /// Container for the parameters to the BatchAssociateCodeSecurityScanConfiguration operation.
    /// Associates multiple code repositories with an Amazon Inspector code security scan
    /// configuration.
    /// </summary>
    public partial class BatchAssociateCodeSecurityScanConfigurationRequest : AmazonInspector2Request
    {
        private List<AssociateConfigurationRequest> _associateConfigurationRequests = AWSConfigs.InitializeCollections ? new List<AssociateConfigurationRequest>() : null;

        /// <summary>
        /// Gets and sets the property AssociateConfigurationRequests. 
        /// <para>
        /// A list of code repositories to associate with the specified scan configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=25)]
        public List<AssociateConfigurationRequest> AssociateConfigurationRequests
        {
            get { return this._associateConfigurationRequests; }
            set { this._associateConfigurationRequests = value; }
        }

        // Check to see if AssociateConfigurationRequests property is set
        internal bool IsSetAssociateConfigurationRequests()
        {
            return this._associateConfigurationRequests != null && (this._associateConfigurationRequests.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}