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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Container for the parameters to the BatchUpdateStandardsControlAssociations operation.
    /// For a batch of security controls and standards, this operation updates the enablement
    /// status of a control in a standard.
    /// </summary>
    public partial class BatchUpdateStandardsControlAssociationsRequest : AmazonSecurityHubRequest
    {
        private List<StandardsControlAssociationUpdate> _standardsControlAssociationUpdates = AWSConfigs.InitializeCollections ? new List<StandardsControlAssociationUpdate>() : null;

        /// <summary>
        /// Gets and sets the property StandardsControlAssociationUpdates. 
        /// <para>
        ///  Updates the enablement status of a security control in a specified standard. 
        /// </para>
        ///  
        /// <para>
        ///  Calls to this operation return a <c>RESOURCE_NOT_FOUND_EXCEPTION</c> error when the
        /// standard subscription for the control has <c>StandardsControlsUpdatable</c> value
        /// <c>NOT_READY_FOR_UPDATES</c>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<StandardsControlAssociationUpdate> StandardsControlAssociationUpdates
        {
            get { return this._standardsControlAssociationUpdates; }
            set { this._standardsControlAssociationUpdates = value; }
        }

        // Check to see if StandardsControlAssociationUpdates property is set
        internal bool IsSetStandardsControlAssociationUpdates()
        {
            return this._standardsControlAssociationUpdates != null && (this._standardsControlAssociationUpdates.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}