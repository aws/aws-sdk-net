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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp of when the tag-sync task was created. 
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// The specific error message in cases where the tag-sync task status is <c>ERROR</c>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property GroupArn. 
        /// <para>
        /// The Amazon resource name (ARN) of the application group. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 1600)]
        public string GroupArn { get; set; }

        /// <summary>
        /// Checks to see if the GroupArn property is set.
        /// </summary>
        internal bool IsSetGroupArn() => this.GroupArn != null;

        /// <summary>
        /// Gets and sets the property GroupName. 
        /// <para>
        /// The name of the application group. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 300)]
        public string GroupName { get; set; }

        /// <summary>
        /// Checks to see if the GroupName property is set.
        /// </summary>
        internal bool IsSetGroupName() => this.GroupName != null;

        /// <summary>
        /// Gets and sets the property ResourceQuery.
        /// </summary>
        public ResourceQuery ResourceQuery { get; set; }

        /// <summary>
        /// Checks to see if the ResourceQuery property is set.
        /// </summary>
        internal bool IsSetResourceQuery() => this.ResourceQuery != null;

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
        [AWSProperty(Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

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
        public TagSyncTaskStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TagKey. 
        /// <para>
        /// The tag key. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string TagKey { get; set; }

        /// <summary>
        /// Checks to see if the TagKey property is set.
        /// </summary>
        internal bool IsSetTagKey() => this.TagKey != null;

        /// <summary>
        /// Gets and sets the property TagValue. 
        /// <para>
        /// The tag value. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string TagValue { get; set; }

        /// <summary>
        /// Checks to see if the TagValue property is set.
        /// </summary>
        internal bool IsSetTagValue() => this.TagValue != null;

        /// <summary>
        /// Gets and sets the property TaskArn. 
        /// <para>
        /// The Amazon resource name (ARN) of the tag-sync task. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 1600)]
        public string TaskArn { get; set; }

        /// <summary>
        /// Checks to see if the TaskArn property is set.
        /// </summary>
        internal bool IsSetTaskArn() => this.TaskArn != null;
    }
}
