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
    /// Container for the parameters to the UpdateSpaceResources operation.
    /// Adds or removes resources from an Amazon QuickSight space.
    /// </summary>
    public partial class UpdateSpaceResourcesRequest : AmazonQuickSightRequest
    {
        private List<SpaceResourceOperation> _addResources = AWSConfigs.InitializeCollections ? new List<SpaceResourceOperation>() : null;
        private string _awsAccountId;
        private List<SpaceResourceOperation> _removeResources = AWSConfigs.InitializeCollections ? new List<SpaceResourceOperation>() : null;
        private string _spaceId;

        /// <summary>
        /// Gets and sets the property AddResources. 
        /// <para>
        /// A list of resources to add to the space.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SpaceResourceOperation> AddResources
        {
            get { return this._addResources; }
            set { this._addResources = value; }
        }

        // Check to see if AddResources property is set
        internal bool IsSetAddResources()
        {
            return this._addResources != null && (this._addResources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account that contains the space.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string AwsAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AwsAccountId property is set
        internal bool IsSetAwsAccountId()
        {
            return this._awsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property RemoveResources. 
        /// <para>
        /// A list of resources to remove from the space.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SpaceResourceOperation> RemoveResources
        {
            get { return this._removeResources; }
            set { this._removeResources = value; }
        }

        // Check to see if RemoveResources property is set
        internal bool IsSetRemoveResources()
        {
            return this._removeResources != null && (this._removeResources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SpaceId. 
        /// <para>
        /// The ID of the space that you want to update resources for.
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

    }
}