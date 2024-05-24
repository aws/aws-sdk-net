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
 * Do not modify this file. This file is generated from the greengrass-2017-06-07.normal.json service model.
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
namespace Amazon.Greengrass.Model
{
    /// <summary>
    /// Container for the parameters to the GetGroupVersion operation.
    /// Retrieves information about a group version.
    /// </summary>
    public partial class GetGroupVersionRequest : AmazonGreengrassRequest
    {
        private string _groupId;
        private string _groupVersionId;

        /// <summary>
        /// Gets and sets the property GroupId. The ID of the Greengrass group.
        /// </summary>
        [AWSProperty(Required=true)]
        public string GroupId
        {
            get { return this._groupId; }
            set { this._groupId = value; }
        }

        // Check to see if GroupId property is set
        internal bool IsSetGroupId()
        {
            return this._groupId != null;
        }

        /// <summary>
        /// Gets and sets the property GroupVersionId. The ID of the group version. This value
        /// maps to the ''Version'' property of the corresponding ''VersionInformation'' object,
        /// which is returned by ''ListGroupVersions'' requests. If the version is the last one
        /// that was associated with a group, the value also maps to the ''LatestVersion'' property
        /// of the corresponding ''GroupInformation'' object.
        /// </summary>
        [AWSProperty(Required=true)]
        public string GroupVersionId
        {
            get { return this._groupVersionId; }
            set { this._groupVersionId = value; }
        }

        // Check to see if GroupVersionId property is set
        internal bool IsSetGroupVersionId()
        {
            return this._groupVersionId != null;
        }

    }
}