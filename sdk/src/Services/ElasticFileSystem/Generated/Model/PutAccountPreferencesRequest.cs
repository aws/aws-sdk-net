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
 * Do not modify this file. This file is generated from the elasticfilesystem-2015-02-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticFileSystem.Model
{
    /// <summary>
    /// Container for the parameters to the PutAccountPreferences operation.
    /// Use this operation to set the account preference in the current Amazon Web Services
    /// Region to use either long 17 character (63 bit) or short 8 character (32 bit) IDs
    /// for new EFS file systems and mount targets created. All existing resource IDs are
    /// not affected by any changes you make. You can set the ID preference during the opt-in
    /// period as EFS transitions to long resource IDs. For more information, see <a href="efs/latest/ug/manage-efs-resource-ids.html">Managing
    /// Amazon EFS resource IDs</a>.
    /// </summary>
    public partial class PutAccountPreferencesRequest : AmazonElasticFileSystemRequest
    {
        private ResourceIdType _resourceIdType;

        /// <summary>
        /// Gets and sets the property ResourceIdType. 
        /// <para>
        /// Specifies the EFS resource ID preference to set for the user's Amazon Web Services
        /// account, in the current Amazon Web Services Region, either <code>LONG_ID</code> (17
        /// characters), or <code>SHORT_ID</code> (8 characters).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ResourceIdType ResourceIdType
        {
            get { return this._resourceIdType; }
            set { this._resourceIdType = value; }
        }

        // Check to see if ResourceIdType property is set
        internal bool IsSetResourceIdType()
        {
            return this._resourceIdType != null;
        }

    }
}