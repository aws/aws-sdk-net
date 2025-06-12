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
    /// Container for the parameters to the BatchGetStandardsControlAssociations operation.
    /// For a batch of security controls and standards, identifies whether each control is
    /// currently enabled or disabled in a standard. 
    /// 
    ///  
    /// <para>
    ///  Calls to this operation return a <c>RESOURCE_NOT_FOUND_EXCEPTION</c> error when the
    /// standard subscription for the association has a <c>NOT_READY_FOR_UPDATES</c> value
    /// for <c>StandardsControlsUpdatable</c>. 
    /// </para>
    /// </summary>
    public partial class BatchGetStandardsControlAssociationsRequest : AmazonSecurityHubRequest
    {
        private List<StandardsControlAssociationId> _standardsControlAssociationIds = AWSConfigs.InitializeCollections ? new List<StandardsControlAssociationId>() : null;

        /// <summary>
        /// Gets and sets the property StandardsControlAssociationIds. 
        /// <para>
        ///  An array with one or more objects that includes a security control (identified with
        /// <c>SecurityControlId</c>, <c>SecurityControlArn</c>, or a mix of both parameters)
        /// and the Amazon Resource Name (ARN) of a standard. This field is used to query the
        /// enablement status of a control in a specified standard. The security control ID or
        /// ARN is the same across standards. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<StandardsControlAssociationId> StandardsControlAssociationIds
        {
            get { return this._standardsControlAssociationIds; }
            set { this._standardsControlAssociationIds = value; }
        }

        // Check to see if StandardsControlAssociationIds property is set
        internal bool IsSetStandardsControlAssociationIds()
        {
            return this._standardsControlAssociationIds != null && (this._standardsControlAssociationIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}