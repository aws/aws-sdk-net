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
    /// key-value pair to an application. To start a tag-sync task, you need a <a href="https://docs.aws.amazon.com/servicecatalog/latest/arguide/app-tag-sync.html#tag-sync-role">resource
    /// tagging role</a>. The resource tagging role grants permissions to tag and untag applications
    /// resources and must include a trust policy that allows Resource Groups to assume the
    /// role and perform resource tagging tasks on your behalf. 
    /// 
    ///  
    /// <para>
    /// For instructions on creating a tag-sync task, see <a href="https://docs.aws.amazon.com/servicecatalog/latest/arguide/app-tag-sync.html#create-tag-sync">Create
    /// a tag-sync using the Resource Groups API</a> in the <i>Amazon Web Services Service
    /// Catalog AppRegistry Administrator Guide</i>. 
    /// </para>
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
        private ResourceQuery _resourceQuery;
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
        /// Gets and sets the property ResourceQuery. 
        /// <para>
        /// The query you can use to create the tag-sync task. With this method, all resources
        /// matching the query are added to the specified application group. A <c>ResourceQuery</c>
        /// specifies both a query <c>Type</c> and a <c>Query</c> string as JSON string objects.
        /// For more information on defining a resource query for a tag-sync task, see the tag-based
        /// query type in <a href="https://docs.aws.amazon.com/ARG/latest/userguide/gettingstarted-query.html#getting_started-query_types">
        /// Types of resource group queries</a> in <i>Resource Groups User Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// When using the <c>ResourceQuery</c> parameter, you cannot use the <c>TagKey</c> and
        /// <c>TagValue</c> parameters. 
        /// </para>
        ///  
        /// <para>
        /// When you combine all of the elements together into a single string, any double quotes
        /// that are embedded inside another double quote pair must be escaped by preceding the
        /// embedded double quote with a backslash character (\). For example, a complete <c>ResourceQuery</c>
        /// parameter must be formatted like the following CLI parameter example:
        /// </para>
        ///  
        /// <para>
        ///  <c>--resource-query '{"Type":"TAG_FILTERS_1_0","Query":"{\"ResourceTypeFilters\":[\"AWS::AllSupported\"],\"TagFilters\":[{\"Key\":\"Stage\",\"Values\":[\"Test\"]}]}"}'</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// In the preceding example, all of the double quote characters in the value part of
        /// the <c>Query</c> element must be escaped because the value itself is surrounded by
        /// double quotes. For more information, see <a href="https://docs.aws.amazon.com/cli/latest/userguide/cli-usage-parameters-quoting-strings.html">Quoting
        /// strings</a> in the <i>Command Line Interface User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For the complete list of resource types that you can use in the array value for <c>ResourceTypeFilters</c>,
        /// see <a href="https://docs.aws.amazon.com/ARG/latest/userguide/supported-resources.html">Resources
        /// you can use with Resource Groups and Tag Editor</a> in the <i>Resource Groups User
        /// Guide</i>. For example:
        /// </para>
        ///  
        /// <para>
        ///  <c>"ResourceTypeFilters":["AWS::S3::Bucket", "AWS::EC2::Instance"]</c> 
        /// </para>
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
        ///  
        /// <para>
        /// When using the <c>TagKey</c> parameter, you must also specify the <c>TagValue</c>
        /// parameter. If you specify a tag key-value pair, you can't use the <c>ResourceQuery</c>
        /// parameter. 
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
        /// The tag value. Resources tagged with this tag key-value pair will be added to the
        /// application. If a resource with this tag is later untagged, the tag-sync task removes
        /// the resource from the application. 
        /// </para>
        ///  
        /// <para>
        /// When using the <c>TagValue</c> parameter, you must also specify the <c>TagKey</c>
        /// parameter. If you specify a tag key-value pair, you can't use the <c>ResourceQuery</c>
        /// parameter. 
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

    }
}