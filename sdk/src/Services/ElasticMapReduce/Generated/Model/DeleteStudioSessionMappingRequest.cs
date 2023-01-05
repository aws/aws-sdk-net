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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteStudioSessionMapping operation.
    /// Removes a user or group from an Amazon EMR Studio.
    /// </summary>
    public partial class DeleteStudioSessionMappingRequest : AmazonElasticMapReduceRequest
    {
        private string _identityId;
        private string _identityName;
        private IdentityType _identityType;
        private string _studioId;

        /// <summary>
        /// Gets and sets the property IdentityId. 
        /// <para>
        /// The globally unique identifier (GUID) of the user or group to remove from the Amazon
        /// EMR Studio. For more information, see <a href="https://docs.aws.amazon.com/singlesignon/latest/IdentityStoreAPIReference/API_User.html#singlesignon-Type-User-UserId">UserId</a>
        /// and <a href="https://docs.aws.amazon.com/singlesignon/latest/IdentityStoreAPIReference/API_Group.html#singlesignon-Type-Group-GroupId">GroupId</a>
        /// in the <i>IAM Identity Center Identity Store API Reference</i>. Either <code>IdentityName</code>
        /// or <code>IdentityId</code> must be specified.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string IdentityId
        {
            get { return this._identityId; }
            set { this._identityId = value; }
        }

        // Check to see if IdentityId property is set
        internal bool IsSetIdentityId()
        {
            return this._identityId != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityName. 
        /// <para>
        /// The name of the user name or group to remove from the Amazon EMR Studio. For more
        /// information, see <a href="https://docs.aws.amazon.com/singlesignon/latest/IdentityStoreAPIReference/API_User.html#singlesignon-Type-User-UserName">UserName</a>
        /// and <a href="https://docs.aws.amazon.com/singlesignon/latest/IdentityStoreAPIReference/API_Group.html#singlesignon-Type-Group-DisplayName">DisplayName</a>
        /// in the <i>IAM Identity Center Store API Reference</i>. Either <code>IdentityName</code>
        /// or <code>IdentityId</code> must be specified.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string IdentityName
        {
            get { return this._identityName; }
            set { this._identityName = value; }
        }

        // Check to see if IdentityName property is set
        internal bool IsSetIdentityName()
        {
            return this._identityName != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityType. 
        /// <para>
        /// Specifies whether the identity to delete from the Amazon EMR Studio is a user or a
        /// group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IdentityType IdentityType
        {
            get { return this._identityType; }
            set { this._identityType = value; }
        }

        // Check to see if IdentityType property is set
        internal bool IsSetIdentityType()
        {
            return this._identityType != null;
        }

        /// <summary>
        /// Gets and sets the property StudioId. 
        /// <para>
        /// The ID of the Amazon EMR Studio.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string StudioId
        {
            get { return this._studioId; }
            set { this._studioId = value; }
        }

        // Check to see if StudioId property is set
        internal bool IsSetStudioId()
        {
            return this._studioId != null;
        }

    }
}