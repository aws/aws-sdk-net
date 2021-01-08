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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateWorkteam operation.
    /// Updates an existing work team with new member definitions or description.
    /// </summary>
    public partial class UpdateWorkteamRequest : AmazonSageMakerRequest
    {
        private string _description;
        private List<MemberDefinition> _memberDefinitions = new List<MemberDefinition>();
        private NotificationConfiguration _notificationConfiguration;
        private string _workteamName;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An updated description for the work team.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
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
        /// A list of <code>MemberDefinition</code> objects that contains objects that identify
        /// the workers that make up the work team. 
        /// </para>
        ///  
        /// <para>
        /// Workforces can be created using Amazon Cognito or your own OIDC Identity Provider
        /// (IdP). For private workforces created using Amazon Cognito use <code>CognitoMemberDefinition</code>.
        /// For workforces created using your own OIDC identity provider (IdP) use <code>OidcMemberDefinition</code>.
        /// You should not provide input for both of these parameters in a single request.
        /// </para>
        ///  
        /// <para>
        /// For workforces created using Amazon Cognito, private work teams correspond to Amazon
        /// Cognito <i>user groups</i> within the user pool used to create a workforce. All of
        /// the <code>CognitoMemberDefinition</code> objects that make up the member definition
        /// must have the same <code>ClientId</code> and <code>UserPool</code> values. To add
        /// a Amazon Cognito user group to an existing worker pool, see <a href="">Adding groups
        /// to a User Pool</a>. For more information about user pools, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-identity-pools.html">Amazon
        /// Cognito User Pools</a>.
        /// </para>
        ///  
        /// <para>
        /// For workforces created using your own OIDC IdP, specify the user groups that you want
        /// to include in your private work team in <code>OidcMemberDefinition</code> by listing
        /// those groups in <code>Groups</code>. Be aware that user groups that are already in
        /// the work team must also be listed in <code>Groups</code> when you make this request
        /// to remain on the work team. If you do not include these user groups, they will no
        /// longer be associated with the work team you update. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<MemberDefinition> MemberDefinitions
        {
            get { return this._memberDefinitions; }
            set { this._memberDefinitions = value; }
        }

        // Check to see if MemberDefinitions property is set
        internal bool IsSetMemberDefinitions()
        {
            return this._memberDefinitions != null && this._memberDefinitions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NotificationConfiguration. 
        /// <para>
        /// Configures SNS topic notifications for available or expiring work items
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
        /// Gets and sets the property WorkteamName. 
        /// <para>
        /// The name of the work team to update.
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