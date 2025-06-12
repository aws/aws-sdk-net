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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
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
namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the CreateTags operation.
    /// Adds tags to a cluster.
    /// 
    ///  
    /// <para>
    /// A resource can have up to 50 tags. If you try to create more than 50 tags for a resource,
    /// you will receive an error and the attempt will fail.
    /// </para>
    ///  
    /// <para>
    /// If you specify a key that already exists for the resource, the value for that key
    /// will be updated with the new value.
    /// </para>
    /// </summary>
    public partial class CreateTagsRequest : AmazonRedshiftRequest
    {
        private string _resourceName;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property ResourceName. 
        /// <para>
        /// The Amazon Resource Name (ARN) to which you want to add the tag or tags. For example,
        /// <c>arn:aws:redshift:us-east-2:123456789:cluster:t1</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=2147483647)]
        public string ResourceName
        {
            get { return this._resourceName; }
            set { this._resourceName = value; }
        }

        // Check to see if ResourceName property is set
        internal bool IsSetResourceName()
        {
            return this._resourceName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// One or more name/value pairs to add as tags to the specified resource. Each tag name
        /// is passed in with the parameter <c>Key</c> and the corresponding value is passed in
        /// with the parameter <c>Value</c>. The <c>Key</c> and <c>Value</c> parameters are separated
        /// by a comma (,). Separate multiple tags with a space. For example, <c>--tags "Key"="owner","Value"="admin"
        /// "Key"="environment","Value"="test" "Key"="version","Value"="1.0"</c>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
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