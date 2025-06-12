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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
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
namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// This is the response object from the CancelDomainConfigChange operation.
    /// </summary>
    public partial class CancelDomainConfigChangeResponse : AmazonWebServiceResponse
    {
        private List<string> _cancelledChangeIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<CancelledChangeProperty> _cancelledChangeProperties = AWSConfigs.InitializeCollections ? new List<CancelledChangeProperty>() : null;
        private bool? _dryRun;

        /// <summary>
        /// Gets and sets the property CancelledChangeIds. 
        /// <para>
        /// The unique identifiers of the changes that were cancelled.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CancelledChangeIds
        {
            get { return this._cancelledChangeIds; }
            set { this._cancelledChangeIds = value; }
        }

        // Check to see if CancelledChangeIds property is set
        internal bool IsSetCancelledChangeIds()
        {
            return this._cancelledChangeIds != null && (this._cancelledChangeIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CancelledChangeProperties. 
        /// <para>
        /// The domain change properties that were cancelled.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CancelledChangeProperty> CancelledChangeProperties
        {
            get { return this._cancelledChangeProperties; }
            set { this._cancelledChangeProperties = value; }
        }

        // Check to see if CancelledChangeProperties property is set
        internal bool IsSetCancelledChangeProperties()
        {
            return this._cancelledChangeProperties != null && (this._cancelledChangeProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Whether or not the request was a dry run. If <c>True</c>, the changes were not actually
        /// cancelled. 
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

    }
}