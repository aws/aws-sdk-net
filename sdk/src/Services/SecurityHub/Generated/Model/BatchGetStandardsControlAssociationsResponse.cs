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
    /// This is the response object from the BatchGetStandardsControlAssociations operation.
    /// </summary>
    public partial class BatchGetStandardsControlAssociationsResponse : AmazonWebServiceResponse
    {
        private List<StandardsControlAssociationDetail> _standardsControlAssociationDetails = AWSConfigs.InitializeCollections ? new List<StandardsControlAssociationDetail>() : null;
        private List<UnprocessedStandardsControlAssociation> _unprocessedAssociations = AWSConfigs.InitializeCollections ? new List<UnprocessedStandardsControlAssociation>() : null;

        /// <summary>
        /// Gets and sets the property StandardsControlAssociationDetails. 
        /// <para>
        /// Provides the enablement status of a security control in a specified standard and other
        /// details for the control in relation to the specified standard. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<StandardsControlAssociationDetail> StandardsControlAssociationDetails
        {
            get { return this._standardsControlAssociationDetails; }
            set { this._standardsControlAssociationDetails = value; }
        }

        // Check to see if StandardsControlAssociationDetails property is set
        internal bool IsSetStandardsControlAssociationDetails()
        {
            return this._standardsControlAssociationDetails != null && (this._standardsControlAssociationDetails.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UnprocessedAssociations. 
        /// <para>
        ///  A security control (identified with <c>SecurityControlId</c>, <c>SecurityControlArn</c>,
        /// or a mix of both parameters) whose enablement status in a specified standard cannot
        /// be returned. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UnprocessedStandardsControlAssociation> UnprocessedAssociations
        {
            get { return this._unprocessedAssociations; }
            set { this._unprocessedAssociations = value; }
        }

        // Check to see if UnprocessedAssociations property is set
        internal bool IsSetUnprocessedAssociations()
        {
            return this._unprocessedAssociations != null && (this._unprocessedAssociations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}