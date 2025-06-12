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
 * Do not modify this file. This file is generated from the proton-2020-07-20.normal.json service model.
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
namespace Amazon.Proton.Model
{
    /// <summary>
    /// This is the response object from the ListServicePipelineProvisionedResources operation.
    /// </summary>
    public partial class ListServicePipelineProvisionedResourcesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ProvisionedResource> _provisionedResources = AWSConfigs.InitializeCollections ? new List<ProvisionedResource>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token that indicates the location of the next provisioned resource in the array
        /// of provisioned resources, after the current requested list of provisioned resources.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=0)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property ProvisionedResources. 
        /// <para>
        /// An array of provisioned resources for a service and pipeline.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ProvisionedResource> ProvisionedResources
        {
            get { return this._provisionedResources; }
            set { this._provisionedResources = value; }
        }

        // Check to see if ProvisionedResources property is set
        internal bool IsSetProvisionedResources()
        {
            return this._provisionedResources != null && (this._provisionedResources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}