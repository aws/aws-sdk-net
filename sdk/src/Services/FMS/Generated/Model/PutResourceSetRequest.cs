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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
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
namespace Amazon.FMS.Model
{
    /// <summary>
    /// Container for the parameters to the PutResourceSet operation.
    /// Creates the resource set.
    /// 
    ///  
    /// <para>
    /// An Firewall Manager resource set defines the resources to import into an Firewall
    /// Manager policy from another Amazon Web Services service.
    /// </para>
    /// </summary>
    public partial class PutResourceSetRequest : AmazonFMSRequest
    {
        private ResourceSet _resourceSet;
        private List<Tag> _tagList = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property ResourceSet. 
        /// <para>
        /// Details about the resource set to be created or updated.&gt;
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ResourceSet ResourceSet
        {
            get { return this._resourceSet; }
            set { this._resourceSet = value; }
        }

        // Check to see if ResourceSet property is set
        internal bool IsSetResourceSet()
        {
            return this._resourceSet != null;
        }

        /// <summary>
        /// Gets and sets the property TagList. 
        /// <para>
        /// Retrieves the tags associated with the specified resource set. Tags are key:value
        /// pairs that you can use to categorize and manage your resources, for purposes like
        /// billing. For example, you might set the tag key to "customer" and the value to the
        /// customer name or ID. You can specify one or more tags to add to each Amazon Web Services
        /// resource, up to 50 tags for a resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> TagList
        {
            get { return this._tagList; }
            set { this._tagList = value; }
        }

        // Check to see if TagList property is set
        internal bool IsSetTagList()
        {
            return this._tagList != null && (this._tagList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}