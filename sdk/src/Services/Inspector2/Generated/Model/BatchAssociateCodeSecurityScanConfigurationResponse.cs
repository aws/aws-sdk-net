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
    /// This is the response object from the BatchAssociateCodeSecurityScanConfiguration operation.
    /// </summary>
    public partial class BatchAssociateCodeSecurityScanConfigurationResponse : AmazonWebServiceResponse
    {
        private List<FailedAssociationResult> _failedAssociations = AWSConfigs.InitializeCollections ? new List<FailedAssociationResult>() : null;
        private List<SuccessfulAssociationResult> _successfulAssociations = AWSConfigs.InitializeCollections ? new List<SuccessfulAssociationResult>() : null;

        /// <summary>
        /// Gets and sets the property FailedAssociations. 
        /// <para>
        /// Details of any code repositories that failed to be associated with the scan configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FailedAssociationResult> FailedAssociations
        {
            get { return this._failedAssociations; }
            set { this._failedAssociations = value; }
        }

        // Check to see if FailedAssociations property is set
        internal bool IsSetFailedAssociations()
        {
            return this._failedAssociations != null && (this._failedAssociations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SuccessfulAssociations. 
        /// <para>
        /// Details of code repositories that were successfully associated with the scan configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SuccessfulAssociationResult> SuccessfulAssociations
        {
            get { return this._successfulAssociations; }
            set { this._successfulAssociations = value; }
        }

        // Check to see if SuccessfulAssociations property is set
        internal bool IsSetSuccessfulAssociations()
        {
            return this._successfulAssociations != null && (this._successfulAssociations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}