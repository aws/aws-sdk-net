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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the CreateWorkteam operation.
    /// Creates a new work team for labeling your data. A work team is defined by one or more
    /// Amazon Cognito user pools. You must first create the user pools before you can create
    /// a work team.
    /// 
    ///  
    /// <para>
    /// You cannot create more than 25 work teams in an account and region.
    /// </para>
    /// </summary>
    public partial class CreateWorkteamRequest : AmazonSageMakerRequest
    {
        private string _description;
        private List<MemberDefinition> _memberDefinitions = AWSConfigs.InitializeCollections ? new List<MemberDefinition>() : null;
        private NotificationConfiguration _notificationConfiguration;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private WorkerAccessConfiguration _workerAccessConfiguration;
        private string _workforceName;
        private string _workteamName;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the work team.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property MemberDefinitions. 
        /// <para>
        /// A list of <c>MemberDefinition</c> objects that contains objects that identify the
        /// workers that make up the work team. 
        /// </para>
        ///  
        /// <para>
        /// Workforces can be created using Amazon Cognito or your own OIDC Identity Provider
        /// (IdP). For private workforces created using Amazon Cognito use <c>CognitoMemberDefinition</c>.
        /// For workforces created using your own OIDC identity provider (IdP) use <c>OidcMemberDefinition</c>.
        /// Do not provide input for both of these parameters in a single request.
        /// </para>
        ///  
        /// <para>
        /// For workforces created using Amazon Cognito, private work teams correspond to Amazon
        /// Cognito <i>user groups</i> within the user pool used to create a workforce. All of
        /// the <c>CognitoMemberDefinition</c> objects that make up the member definition must
        /// have the same <c>ClientId</c> and <c>UserPool</c> values. To add a Amazon Cognito
        /// user group to an existing worker pool, see <a href="">Adding groups to a User Pool</a>.
        /// For more information about user pools, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-identity-pools.html">Amazon
        /// Cognito User Pools</a>.
        /// </para>
        ///  
        /// <para>
        /// For workforces created using your own OIDC IdP, specify the user groups that you want
        /// to include in your private work team in <c>OidcMemberDefinition</c> by listing those
        /// groups in <c>Groups</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<MemberDefinition> MemberDefinitions
        {
            get { return this._memberDefinitions; }
            set { this._memberDefinitions = value; }
        }

        // Check to see if MemberDefinitions property is set
        internal bool IsSetMemberDefinitions()
        {
            return this._memberDefinitions != null && (this._memberDefinitions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NotificationConfiguration. 
        /// <para>
        /// Configures notification of workers regarding available or expiring work items.
        /// </para>
        /// </summary>
        public NotificationConfiguration NotificationConfiguration
        {
            get { return this._notificationConfiguration; }
            set { this._notificationConfiguration = value; }
        }

        // Check to see if NotificationConfiguration property is set
        internal bool IsSetNotificationConfiguration()
        {
            return this._notificationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of key-value pairs.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-resource-tags.html">Resource
        /// Tag</a> and <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/cost-alloc-tags.html#allocation-what">Using
        /// Cost Allocation Tags</a> in the <i> Amazon Web Services Billing and Cost Management
        /// User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property WorkerAccessConfiguration. 
        /// <para>
        /// Use this optional parameter to constrain access to an Amazon S3 resource based on
        /// the IP address using supported IAM global condition keys. The Amazon S3 resource is
        /// accessed in the worker portal using a Amazon S3 presigned URL.
        /// </para>
        /// </summary>
        public WorkerAccessConfiguration WorkerAccessConfiguration
        {
            get { return this._workerAccessConfiguration; }
            set { this._workerAccessConfiguration = value; }
        }

        // Check to see if WorkerAccessConfiguration property is set
        internal bool IsSetWorkerAccessConfiguration()
        {
            return this._workerAccessConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property WorkforceName. 
        /// <para>
        /// The name of the workforce.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string WorkforceName
        {
            get { return this._workforceName; }
            set { this._workforceName = value; }
        }

        // Check to see if WorkforceName property is set
        internal bool IsSetWorkforceName()
        {
            return this._workforceName != null;
        }

        /// <summary>
        /// Gets and sets the property WorkteamName. 
        /// <para>
        /// The name of the work team. Use this name to identify the work team.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string WorkteamName
        {
            get { return this._workteamName; }
            set { this._workteamName = value; }
        }

        // Check to see if WorkteamName property is set
        internal bool IsSetWorkteamName()
        {
            return this._workteamName != null;
        }

    }
}