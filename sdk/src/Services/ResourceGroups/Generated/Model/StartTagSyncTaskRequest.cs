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
 * Do not modify this file. This file is generated from the resource-groups-2017-11-27.normal.json service model.
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
namespace Amazon.ResourceGroups.Model
{
    /// <summary>
    /// Container for the parameters to the StartTagSyncTask operation.
    /// Creates a new tag-sync task to onboard and sync resources tagged with a specific tag
    /// key-value pair to an application. 
    /// 
    ///  
    /// <para>
    ///  <b>Minimum permissions</b> 
    /// </para>
    ///  
    /// <para>
    /// To run this command, you must have the following permissions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>resource-groups:StartTagSyncTask</c> on the application group
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>resource-groups:CreateGroup</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>iam:PassRole</c> on the role provided in the request 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class StartTagSyncTaskRequest : AmazonResourceGroupsRequest
    {
        private string _group;
        private string _roleArn;
        private string _tagKey;
        private string _tagValue;

        /// <summary>
        /// Gets and sets the property Group. 
        /// <para>
        /// The Amazon resource name (ARN) or name of the application group for which you want
        /// to create a tag-sync task. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1600)]
        public string Group
        {
            get { return this._group; }
            set { this._group = value; }
        }

        // Check to see if Group property is set
        internal bool IsSetGroup()
        {
            return this._group != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon resource name (ARN) of the role assumed by the service to tag and untag
        /// resources on your behalf.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property TagKey. 
        /// <para>
        /// The tag key. Resources tagged with this tag key-value pair will be added to the application.
        /// If a resource with this tag is later untagged, the tag-sync task removes the resource
        /// from the application. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string TagKey
        {
            get { return this._tagKey; }
            set { this._tagKey = value; }
        }

        // Check to see if TagKey property is set
        internal bool IsSetTagKey()
        {
            return this._tagKey != null;
        }

        /// <summary>
        /// Gets and sets the property TagValue. 
        /// <para>
        /// The tag value. Resources tagged with this tag key-value pair will be added to the
        /// application. If a resource with this tag is later untagged, the tag-sync task removes
        /// the resource from the application. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string TagValue
        {
            get { return this._tagValue; }
            set { this._tagValue = value; }
        }

        // Check to see if TagValue property is set
        internal bool IsSetTagValue()
        {
            return this._tagValue != null;
        }

    }
}