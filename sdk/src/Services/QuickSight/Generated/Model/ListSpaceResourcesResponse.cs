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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// This is the response object from the ListSpaceResources operation.
    /// </summary>
    public partial class ListSpaceResourcesResponse : AmazonWebServiceResponse
    {
        private string _requestId;
        private string _spaceArn;
        private string _spaceId;
        private List<SpaceResourceSummary> _spaceResources = AWSConfigs.InitializeCollections ? new List<SpaceResourceSummary>() : null;

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        /// The Amazon Web Services request ID for this operation.
        /// </para>
        /// </summary>
        public string RequestId
        {
            get { return this._requestId; }
            set { this._requestId = value; }
        }

        // Check to see if RequestId property is set
        internal bool IsSetRequestId()
        {
            return this._requestId != null;
        }

        /// <summary>
        /// Gets and sets the property SpaceArn. 
        /// <para>
        /// The ARN of the space.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=512)]
        public string SpaceArn
        {
            get { return this._spaceArn; }
            set { this._spaceArn = value; }
        }

        // Check to see if SpaceArn property is set
        internal bool IsSetSpaceArn()
        {
            return this._spaceArn != null;
        }

        /// <summary>
        /// Gets and sets the property SpaceId. 
        /// <para>
        /// The ID of the space.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string SpaceId
        {
            get { return this._spaceId; }
            set { this._spaceId = value; }
        }

        // Check to see if SpaceId property is set
        internal bool IsSetSpaceId()
        {
            return this._spaceId != null;
        }

        /// <summary>
        /// Gets and sets the property SpaceResources. 
        /// <para>
        /// A list of resource summaries in the space.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<SpaceResourceSummary> SpaceResources
        {
            get { return this._spaceResources; }
            set { this._spaceResources = value; }
        }

        // Check to see if SpaceResources property is set
        internal bool IsSetSpaceResources()
        {
            return this._spaceResources != null && (this._spaceResources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}