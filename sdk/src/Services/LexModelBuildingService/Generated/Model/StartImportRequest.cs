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
 * Do not modify this file. This file is generated from the lex-models-2017-04-19.normal.json service model.
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
namespace Amazon.LexModelBuildingService.Model
{
    /// <summary>
    /// Container for the parameters to the StartImport operation.
    /// Starts a job to import a resource to Amazon Lex.
    /// </summary>
    public partial class StartImportRequest : AmazonLexModelBuildingServiceRequest
    {
        private MergeStrategy _mergeStrategy;
        private MemoryStream _payload;
        private ResourceType _resourceType;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property MergeStrategy. 
        /// <para>
        /// Specifies the action that the <c>StartImport</c> operation should take when there
        /// is an existing resource with the same name.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// FAIL_ON_CONFLICT - The import operation is stopped on the first conflict between a
        /// resource in the import file and an existing resource. The name of the resource causing
        /// the conflict is in the <c>failureReason</c> field of the response to the <c>GetImport</c>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// OVERWRITE_LATEST - The import operation proceeds even if there is a conflict with
        /// an existing resource. The $LASTEST version of the existing resource is overwritten
        /// with the data from the import file.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public MergeStrategy MergeStrategy
        {
            get { return this._mergeStrategy; }
            set { this._mergeStrategy = value; }
        }

        // Check to see if MergeStrategy property is set
        internal bool IsSetMergeStrategy()
        {
            return this._mergeStrategy != null;
        }

        /// <summary>
        /// Gets and sets the property Payload. 
        /// <para>
        /// A zip archive in binary format. The archive should contain one file, a JSON file containing
        /// the resource to import. The resource should match the type specified in the <c>resourceType</c>
        /// field.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MemoryStream Payload
        {
            get { return this._payload; }
            set { this._payload = value; }
        }

        // Check to see if Payload property is set
        internal bool IsSetPayload()
        {
            return this._payload != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// Specifies the type of resource to export. Each resource also exports any resources
        /// that it depends on. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A bot exports dependent intents.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An intent exports dependent slot types.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public ResourceType ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags to add to the imported bot. You can only add tags when you import a
        /// bot, you can't add tags to an intent or slot type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
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