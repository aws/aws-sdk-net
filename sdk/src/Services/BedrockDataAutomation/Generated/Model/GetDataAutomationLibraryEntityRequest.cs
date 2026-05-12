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
 * Do not modify this file. This file is generated from the bedrock-data-automation-2023-07-26.normal.json service model.
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
namespace Amazon.BedrockDataAutomation.Model
{
    /// <summary>
    /// Container for the parameters to the GetDataAutomationLibraryEntity operation.
    /// Gets an existing entity based on entity type from the library
    /// </summary>
    public partial class GetDataAutomationLibraryEntityRequest : AmazonBedrockDataAutomationRequest
    {
        private string _entityId;
        private EntityType _entityType;
        private string _libraryArn;

        /// <summary>
        /// Gets and sets the property EntityId. 
        /// <para>
        /// Unique identifier for the entity
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string EntityId
        {
            get { return this._entityId; }
            set { this._entityId = value; }
        }

        // Check to see if EntityId property is set
        internal bool IsSetEntityId()
        {
            return this._entityId != null;
        }

        /// <summary>
        /// Gets and sets the property EntityType. 
        /// <para>
        /// The entity type for which the entity is requested
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EntityType EntityType
        {
            get { return this._entityType; }
            set { this._entityType = value; }
        }

        // Check to see if EntityType property is set
        internal bool IsSetEntityType()
        {
            return this._entityType != null;
        }

        /// <summary>
        /// Gets and sets the property LibraryArn. 
        /// <para>
        /// ARN generated at the server side when a DataAutomationLibrary is created
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=128)]
        public string LibraryArn
        {
            get { return this._libraryArn; }
            set { this._libraryArn = value; }
        }

        // Check to see if LibraryArn property is set
        internal bool IsSetLibraryArn()
        {
            return this._libraryArn != null;
        }

    }
}