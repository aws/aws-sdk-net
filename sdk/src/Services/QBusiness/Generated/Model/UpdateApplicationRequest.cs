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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
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
namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateApplication operation.
    /// Updates an existing Amazon Q Business application.
    /// 
    ///  <note> 
    /// <para>
    /// Amazon Q Business applications may securely transmit data for processing across Amazon
    /// Web Services Regions within your geography. For more information, see <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/cross-region-inference.html">Cross
    /// region inference in Amazon Q Business</a>.
    /// </para>
    ///  </note> <note> 
    /// <para>
    /// An Amazon Q Apps service-linked role will be created if it's absent in the Amazon
    /// Web Services account when <c>QAppsConfiguration</c> is enabled in the request. For
    /// more information, see <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/using-service-linked-roles-qapps.html">Using
    /// service-linked roles for Q Apps</a>. 
    /// </para>
    ///  </note>
    /// </summary>
    public partial class UpdateApplicationRequest : AmazonQBusinessRequest
    {
        private string _applicationId;
        private AttachmentsConfiguration _attachmentsConfiguration;
        private AutoSubscriptionConfiguration _autoSubscriptionConfiguration;
        private string _description;
        private string _displayName;
        private string _identityCenterInstanceArn;
        private PersonalizationConfiguration _personalizationConfiguration;
        private QAppsConfiguration _qAppsConfiguration;
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The identifier of the Amazon Q Business application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property AttachmentsConfiguration. 
        /// <para>
        /// An option to allow end users to upload files directly during chat.
        /// </para>
        /// </summary>
        public AttachmentsConfiguration AttachmentsConfiguration
        {
            get { return this._attachmentsConfiguration; }
            set { this._attachmentsConfiguration = value; }
        }

        // Check to see if AttachmentsConfiguration property is set
        internal bool IsSetAttachmentsConfiguration()
        {
            return this._attachmentsConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property AutoSubscriptionConfiguration. 
        /// <para>
        /// An option to enable updating the default subscription type assigned to an Amazon Q
        /// Business application using IAM identity federation for user management.
        /// </para>
        /// </summary>
        public AutoSubscriptionConfiguration AutoSubscriptionConfiguration
        {
            get { return this._autoSubscriptionConfiguration; }
            set { this._autoSubscriptionConfiguration = value; }
        }

        // Check to see if AutoSubscriptionConfiguration property is set
        internal bool IsSetAutoSubscriptionConfiguration()
        {
            return this._autoSubscriptionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the Amazon Q Business application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
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
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// A name for the Amazon Q Business application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityCenterInstanceArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the IAM Identity Center instance you are either
        /// creating for—or connecting to—your Amazon Q Business application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=1224)]
        public string IdentityCenterInstanceArn
        {
            get { return this._identityCenterInstanceArn; }
            set { this._identityCenterInstanceArn = value; }
        }

        // Check to see if IdentityCenterInstanceArn property is set
        internal bool IsSetIdentityCenterInstanceArn()
        {
            return this._identityCenterInstanceArn != null;
        }

        /// <summary>
        /// Gets and sets the property PersonalizationConfiguration. 
        /// <para>
        /// Configuration information about chat response personalization. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/personalizing-chat-responses.html">Personalizing
        /// chat responses</a>.
        /// </para>
        /// </summary>
        public PersonalizationConfiguration PersonalizationConfiguration
        {
            get { return this._personalizationConfiguration; }
            set { this._personalizationConfiguration = value; }
        }

        // Check to see if PersonalizationConfiguration property is set
        internal bool IsSetPersonalizationConfiguration()
        {
            return this._personalizationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property QAppsConfiguration. 
        /// <para>
        /// An option to allow end users to create and use Amazon Q Apps in the web experience.
        /// </para>
        /// </summary>
        public QAppsConfiguration QAppsConfiguration
        {
            get { return this._qAppsConfiguration; }
            set { this._qAppsConfiguration = value; }
        }

        // Check to see if QAppsConfiguration property is set
        internal bool IsSetQAppsConfiguration()
        {
            return this._qAppsConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// An Amazon Web Services Identity and Access Management (IAM) role that gives Amazon
        /// Q Business permission to access Amazon CloudWatch logs and metrics.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1284)]
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

    }
}