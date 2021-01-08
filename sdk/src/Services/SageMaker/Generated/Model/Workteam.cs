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
    /// Provides details about a labeling work team.
    /// </summary>
    public partial class Workteam
    {
        private DateTime? _createDate;
        private string _description;
        private DateTime? _lastUpdatedDate;
        private List<MemberDefinition> _memberDefinitions = new List<MemberDefinition>();
        private NotificationConfiguration _notificationConfiguration;
        private List<string> _productListingIds = new List<string>();
        private string _subDomain;
        private string _workforceArn;
        private string _workteamArn;
        private string _workteamName;

        /// <summary>
        /// Gets and sets the property CreateDate. 
        /// <para>
        /// The date and time that the work team was created (timestamp).
        /// </para>
        /// </summary>
        public DateTime CreateDate
        {
            get { return this._createDate.GetValueOrDefault(); }
            set { this._createDate = value; }
        }

        // Check to see if CreateDate property is set
        internal bool IsSetCreateDate()
        {
            return this._createDate.HasValue; 
        }

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
        /// Gets and sets the property LastUpdatedDate. 
        /// <para>
        /// The date and time that the work team was last updated (timestamp).
        /// </para>
        /// </summary>
        public DateTime LastUpdatedDate
        {
            get { return this._lastUpdatedDate.GetValueOrDefault(); }
            set { this._lastUpdatedDate = value; }
        }

        // Check to see if LastUpdatedDate property is set
        internal bool IsSetLastUpdatedDate()
        {
            return this._lastUpdatedDate.HasValue; 
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
        /// </para>
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
            return this._memberDefinitions != null && this._memberDefinitions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NotificationConfiguration. 
        /// <para>
        /// Configures SNS notifications of available or expiring work items for work teams.
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
        /// Gets and sets the property ProductListingIds. 
        /// <para>
        /// The Amazon Marketplace identifier for a vendor's work team.
        /// </para>
        /// </summary>
        public List<string> ProductListingIds
        {
            get { return this._productListingIds; }
            set { this._productListingIds = value; }
        }

        // Check to see if ProductListingIds property is set
        internal bool IsSetProductListingIds()
        {
            return this._productListingIds != null && this._productListingIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SubDomain. 
        /// <para>
        /// The URI of the labeling job's user interface. Workers open this URI to start labeling
        /// your data objects.
        /// </para>
        /// </summary>
        public string SubDomain
        {
            get { return this._subDomain; }
            set { this._subDomain = value; }
        }

        // Check to see if SubDomain property is set
        internal bool IsSetSubDomain()
        {
            return this._subDomain != null;
        }

        /// <summary>
        /// Gets and sets the property WorkforceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the workforce.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string WorkforceArn
        {
            get { return this._workforceArn; }
            set { this._workforceArn = value; }
        }

        // Check to see if WorkforceArn property is set
        internal bool IsSetWorkforceArn()
        {
            return this._workforceArn != null;
        }

        /// <summary>
        /// Gets and sets the property WorkteamArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that identifies the work team.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string WorkteamArn
        {
            get { return this._workteamArn; }
            set { this._workteamArn = value; }
        }

        // Check to see if WorkteamArn property is set
        internal bool IsSetWorkteamArn()
        {
            return this._workteamArn != null;
        }

        /// <summary>
        /// Gets and sets the property WorkteamName. 
        /// <para>
        /// The name of the work team.
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