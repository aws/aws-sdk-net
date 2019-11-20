/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Container for the parameters to the CreateTemplate operation.
    /// Creates a template from an existing QuickSight analysis or template. The resulting
    /// template can be used to create a dashboard.
    /// 
    ///  
    /// <para>
    /// A template is an entity in QuickSight which encapsulates the metadata required to
    /// create an analysis that can be used to create dashboard. It adds a layer of abstraction
    /// by use placeholders to replace the dataset associated with the analysis. You can use
    /// templates to create dashboards by replacing dataset placeholders with datasets which
    /// follow the same schema that was used to create the source analysis and template.
    /// </para>
    ///  
    /// <para>
    /// To create a template from an existing analysis, use the analysis's ARN, <code>aws-account-id</code>,
    /// <code>template-id</code>, <code>source-entity</code>, and <code>data-set-references</code>.
    /// </para>
    ///  
    /// <para>
    /// CLI syntax to create a template: 
    /// </para>
    ///  
    /// <para>
    ///  <code>aws quicksight create-template —cli-input-json file://create-template.json</code>
    /// 
    /// </para>
    ///  
    /// <para>
    /// CLI syntax to create a template from another template in the same AWS account:
    /// </para>
    ///  
    /// <para>
    ///  <code>aws quicksight create-template --aws-account-id 111122223333 --template-id
    /// reports_test_template --data-set-references DataSetPlaceholder=reports,DataSetArn=arn:aws:quicksight:us-west-2:111122223333:dataset/0dfc789c-81f6-4f4f-b9ac-7db2453eefc8
    /// DataSetPlaceholder=Elblogs,DataSetArn=arn:aws:quicksight:us-west-2:111122223333:dataset/f60da323-af68-45db-9016-08e0d1d7ded5
    /// --source-entity SourceAnalysis='{Arn=arn:aws:quicksight:us-west-2:111122223333:analysis/7fb74527-c36d-4be8-8139-ac1be4c97365}'</code>
    /// 
    /// </para>
    ///  
    /// <para>
    /// To create template from another account’s template, you need to grant cross account
    /// resource permission for DescribeTemplate the account that contains the template.
    /// </para>
    ///  
    /// <para>
    /// You can use a file to pass JSON to the function if you prefer. 
    /// </para>
    /// </summary>
    public partial class CreateTemplateRequest : AmazonQuickSightRequest
    {
        private string _awsAccountId;
        private string _name;
        private List<ResourcePermission> _permissions = new List<ResourcePermission>();
        private TemplateSourceEntity _sourceEntity;
        private List<Tag> _tags = new List<Tag>();
        private string _templateId;
        private string _versionDescription;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID for the AWS account that the group is in. Currently, you use the ID for the
        /// AWS account that contains your Amazon QuickSight account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string AwsAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AwsAccountId property is set
        internal bool IsSetAwsAccountId()
        {
            return this._awsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A display name for the template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// Gets and sets the property Permissions. 
        /// <para>
        /// A list of resource permissions to be set on the template. The shorthand syntax should
        /// look similar to this: <code>Shorthand Syntax: Principal=string,Actions=string,string
        /// ... </code> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public List<ResourcePermission> Permissions
        {
            get { return this._permissions; }
            set { this._permissions = value; }
        }

        // Check to see if Permissions property is set
        internal bool IsSetPermissions()
        {
            return this._permissions != null && this._permissions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SourceEntity. 
        /// <para>
        /// The ARN of the source entity from which this template is being created. Templates
        /// can be currently created from an analysis or another template. If the ARN is for an
        /// analysis, you must include its dataset references. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TemplateSourceEntity SourceEntity
        {
            get { return this._sourceEntity; }
            set { this._sourceEntity = value; }
        }

        // Check to see if SourceEntity property is set
        internal bool IsSetSourceEntity()
        {
            return this._sourceEntity != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Contains a map of the key-value pairs for the resource tag or tags assigned to the
        /// resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TemplateId. 
        /// <para>
        /// An ID for the template you want to create. This is unique per AWS region per AWS account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string TemplateId
        {
            get { return this._templateId; }
            set { this._templateId = value; }
        }

        // Check to see if TemplateId property is set
        internal bool IsSetTemplateId()
        {
            return this._templateId != null;
        }

        /// <summary>
        /// Gets and sets the property VersionDescription. 
        /// <para>
        /// A description of the current template version being created. This API created the
        /// first version of the template. Every time UpdateTemplate is called a new version is
        /// created. Each version of the template maintains a description of the version in the
        /// VersionDescription field.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string VersionDescription
        {
            get { return this._versionDescription; }
            set { this._versionDescription = value; }
        }

        // Check to see if VersionDescription property is set
        internal bool IsSetVersionDescription()
        {
            return this._versionDescription != null;
        }

    }
}