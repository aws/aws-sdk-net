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
 * Do not modify this file. This file is generated from the neptune-graph-2023-11-29.normal.json service model.
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
namespace Amazon.NeptuneGraph.Model
{
    /// <summary>
    /// Container for the parameters to the TagResource operation.
    /// Adds tags to the specified resource.
    /// </summary>
    public partial class TagResourceRequest : AmazonNeptuneGraphRequest
    {
        private string _resourceArn;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// ARN of the resource for which tags need to be added.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1011)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to be assigned to the Neptune Analytics resource.
        /// </para>
        ///  
        /// <para>
        /// The tags are metadata that are specified as a list of key-value pairs:
        /// </para>
        ///  
        /// <para>
        ///  <b>Key</b> (string)   –   A key is the required name of the tag. The string value
        /// can be from 1 to 128 Unicode characters in length. It can't be prefixed with <c>aws:</c>
        /// and can only contain the set of Unicode characters specified by this Java regular
        /// expression: <c>"^([\p{L}\p{Z}\p{N}_.:/=+\-]*)$")</c>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Value</b> (string)   –   A value is the optional value of the tag. The string
        /// value can be from 1 to 256 Unicode characters in length. It can't be prefixed with
        /// <c>aws:</c> and can only contain the set of Unicode characters specified by this Java
        /// regular expression: <c>"^([\p{L}\p{Z}\p{N}_.:/=+\-]*)$")</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=50)]
        public Dictionary<string, string> Tags
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