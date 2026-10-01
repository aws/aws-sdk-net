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
 * Do not modify this file. This file is generated from the cloudwatchomni-2025-01-01.normal.json service model.
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
namespace Amazon.CloudWatchOmni.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateSpace operation.
    /// Updates a space.
    /// 
    ///  
    /// <para>
    /// Only the provided fields are changed; omitted fields are left unchanged.
    /// </para>
    /// </summary>
    public partial class UpdateSpaceRequest : AmazonCloudWatchOmniRequest
    {
        private EncryptionConfiguration _encryptionConfiguration;
        private string _name;
        private string _spaceId;

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// How to encrypt the space's data at rest. Omit to leave encryption unchanged. Pass
        /// <c>encryptionStrategy</c> AWS_OWNED to stop using a customer managed key and revert
        /// to service owned encryption.
        /// </para>
        /// </summary>
        public EncryptionConfiguration EncryptionConfiguration
        {
            get { return this._encryptionConfiguration; }
            set { this._encryptionConfiguration = value; }
        }

        // Check to see if EncryptionConfiguration property is set
        internal bool IsSetEncryptionConfiguration()
        {
            return this._encryptionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A new name for the space. Omit to leave unchanged. Must be 3-64 characters: lowercase
        /// letters, numbers, and hyphens. It must begin and end with a letter or number and cannot
        /// contain consecutive hyphens.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=64)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property SpaceId. 
        /// <para>
        /// The unique ID of the space to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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