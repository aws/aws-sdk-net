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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Operational metadata for an application in Application Manager.
    /// </summary>
    public partial class OpsMetadata
    {
        private DateTime? _creationDate;
        private DateTime? _lastModifiedDate;
        private string _lastModifiedUser;
        private string _opsMetadataArn;
        private string _resourceId;

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date the OpsMetadata objects was created.
        /// </para>
        /// </summary>
        public DateTime? CreationDate
        {
            get { return this._creationDate; }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date the OpsMetadata object was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedDate
        {
            get { return this._lastModifiedDate; }
            set { this._lastModifiedDate = value; }
        }

        // Check to see if LastModifiedDate property is set
        internal bool IsSetLastModifiedDate()
        {
            return this._lastModifiedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastModifiedUser. 
        /// <para>
        /// The user name who last updated the OpsMetadata object.
        /// </para>
        /// </summary>
        public string LastModifiedUser
        {
            get { return this._lastModifiedUser; }
            set { this._lastModifiedUser = value; }
        }

        // Check to see if LastModifiedUser property is set
        internal bool IsSetLastModifiedUser()
        {
            return this._lastModifiedUser != null;
        }

        /// <summary>
        /// Gets and sets the property OpsMetadataArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the OpsMetadata Object or blob.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1011)]
        public string OpsMetadataArn
        {
            get { return this._opsMetadataArn; }
            set { this._opsMetadataArn = value; }
        }

        // Check to see if OpsMetadataArn property is set
        internal bool IsSetOpsMetadataArn()
        {
            return this._opsMetadataArn != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The ID of the Application Manager application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

    }
}