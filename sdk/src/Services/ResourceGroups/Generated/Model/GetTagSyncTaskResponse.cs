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
    /// This is the response object from the GetTagSyncTask operation.
    /// </summary>
    public partial class GetTagSyncTaskResponse : AmazonWebServiceResponse
    {
        private DateTime? _createdAt;
        private string _errorMessage;
        private string _groupArn;
        private string _groupName;
        private ResourceQuery _resourceQuery;
        private string _roleArn;
        private TagSyncTaskStatus _status;
        private string _tagKey;
        private string _tagValue;
        private string _taskArn;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp of when the tag-sync task was created. 
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// The specific error message in cases where the tag-sync task status is <c>ERROR</c>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property GroupArn. 
        /// <para>
        /// The Amazon resource name (ARN) of the application group. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=1600)]
        public string GroupArn
        {
            get { return this._groupArn; }
            set { this._groupArn = value; }
        }

        // Check to see if GroupArn property is set
        internal bool IsSetGroupArn()
        {
            return this._groupArn != null;
        }

        /// <summary>
        /// Gets and sets the property GroupName. 
        /// <para>
        /// The name of the application group. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=300)]
        public string GroupName
        {
            get { return this._groupName; }
            set { this._groupName = value; }
        }

        // Check to see if GroupName property is set
        internal bool IsSetGroupName()
        {
            return this._groupName != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceQuery.
        /// </summary>
        public ResourceQuery ResourceQuery
        {
            get { return this._resourceQuery; }
            set { this._resourceQuery = value; }
        }

        // Check to see if ResourceQuery property is set
        internal bool IsSetResourceQuery()
        {
            return this._resourceQuery != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon resource name (ARN) of the role assumed by Resource Groups to tag and untag
        /// resources on your behalf. 
        /// </para>
        ///  
        /// <para>
        /// For more information about this role, review <a href="https://docs.aws.amazon.com/servicecatalog/latest/arguide/app-tag-sync.html#tag-sync-role">Tag-sync
        /// required permissions</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the tag-sync task. 
        /// </para>
        ///  
        /// <para>
        /// Valid values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ACTIVE</c> - The tag-sync task is actively managing resources in the application
        /// by adding or removing the <c>awsApplication</c> tag from resources when they are tagged
        /// or untagged with the specified tag key-value pair. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ERROR</c> - The tag-sync task is not actively managing resources in the application.
        /// Review the <c>ErrorMessage</c> for more information about resolving the error. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public TagSyncTaskStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TagKey. 
        /// <para>
        /// The tag key. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// The tag value. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
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

        /// <summary>
        /// Gets and sets the property TaskArn. 
        /// <para>
        /// The Amazon resource name (ARN) of the tag-sync task. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=1600)]
        public string TaskArn
        {
            get { return this._taskArn; }
            set { this._taskArn = value; }
        }

        // Check to see if TaskArn property is set
        internal bool IsSetTaskArn()
        {
            return this._taskArn != null;
        }

    }
}