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
 * Do not modify this file. This file is generated from the directconnect-2012-10-25.normal.json service model.
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
namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// Container for the parameters to the CreateResiliencyGroup operation.
    /// Creates a resiliency group. A resiliency group lets you group Direct Connect connections
    /// together and manage them as a single unit to meet a target resiliency model.
    /// </summary>
    public partial class CreateResiliencyGroupRequest : AmazonDirectConnectRequest
    {
        private string _clientToken;
        private ResiliencyModel _intendedResiliencyModel;
        private string _resiliencyGroupName;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property IntendedResiliencyModel. 
        /// <para>
        /// The resiliency model that the resiliency group is intended to meet. The valid values
        /// are <c>maximum-resiliency</c>, <c>high-resiliency</c>, and <c>basic-resiliency</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ResiliencyModel IntendedResiliencyModel
        {
            get { return this._intendedResiliencyModel; }
            set { this._intendedResiliencyModel = value; }
        }

        // Check to see if IntendedResiliencyModel property is set
        internal bool IsSetIntendedResiliencyModel()
        {
            return this._intendedResiliencyModel != null;
        }

        /// <summary>
        /// Gets and sets the property ResiliencyGroupName. 
        /// <para>
        /// The name of the resiliency group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string ResiliencyGroupName
        {
            get { return this._resiliencyGroupName; }
            set { this._resiliencyGroupName = value; }
        }

        // Check to see if ResiliencyGroupName property is set
        internal bool IsSetResiliencyGroupName()
        {
            return this._resiliencyGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to associate with the resiliency group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}