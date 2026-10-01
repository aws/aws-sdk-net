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

namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateApplication operation. Updates an existing
    /// Amazon Q Business application. <note> <para> Amazon Q Business applications may securely
    /// transmit data for processing across Amazon Web Services Regions within your geography.
    /// For more information, see <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/cross-region-inference.html">Cross
    /// region inference in Amazon Q Business</a>. </para> </note> <note> <para> An Amazon
    /// Q Apps service-linked role will be created if it's absent in the Amazon Web Services
    /// account when <c>QAppsConfiguration</c> is enabled in the request. For more information,
    /// see <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/using-service-linked-roles-qapps.html">Using
    /// service-linked roles for Q Apps</a>. </para> </note>
    /// </summary>
    public partial class UpdateApplicationRequest : AmazonQBusinessRequest
    {
        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The identifier of the Amazon Q Business application.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

        /// <summary>
        /// Gets and sets the property AttachmentsConfiguration. 
        /// <para>
        /// An option to allow end users to upload files directly during chat.
        /// </para>
        /// </summary>
        public AttachmentsConfiguration AttachmentsConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AttachmentsConfiguration property is set.
        /// </summary>
        internal bool IsSetAttachmentsConfiguration() => this.AttachmentsConfiguration != null;

        /// <summary>
        /// Gets and sets the property AutoSubscriptionConfiguration. 
        /// <para>
        /// An option to enable updating the default subscription type assigned to an Amazon Q
        /// Business application using IAM identity federation for user management.
        /// </para>
        /// </summary>
        public AutoSubscriptionConfiguration AutoSubscriptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AutoSubscriptionConfiguration property is set.
        /// </summary>
        internal bool IsSetAutoSubscriptionConfiguration() => this.AutoSubscriptionConfiguration != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the Amazon Q Business application.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// A name for the Amazon Q Business application.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property IdentityCenterInstanceArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the IAM Identity Center instance you are either
        /// creating for—or connecting to—your Amazon Q Business application.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 1224)]
        public string IdentityCenterInstanceArn { get; set; }

        /// <summary>
        /// Checks to see if the IdentityCenterInstanceArn property is set.
        /// </summary>
        internal bool IsSetIdentityCenterInstanceArn() => this.IdentityCenterInstanceArn != null;

        /// <summary>
        /// Gets and sets the property PersonalizationConfiguration. 
        /// <para>
        /// Configuration information about chat response personalization. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/personalizing-chat-responses.html">Personalizing
        /// chat responses</a>.
        /// </para>
        /// </summary>
        public PersonalizationConfiguration PersonalizationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the PersonalizationConfiguration property is set.
        /// </summary>
        internal bool IsSetPersonalizationConfiguration() => this.PersonalizationConfiguration != null;

        /// <summary>
        /// Gets and sets the property QAppsConfiguration. 
        /// <para>
        /// An option to allow end users to create and use Amazon Q Apps in the web experience.
        /// </para>
        /// </summary>
        public QAppsConfiguration QAppsConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the QAppsConfiguration property is set.
        /// </summary>
        internal bool IsSetQAppsConfiguration() => this.QAppsConfiguration != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// An Amazon Web Services Identity and Access Management (IAM) role that gives Amazon
        /// Q Business permission to access Amazon CloudWatch logs and metrics.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1284)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;
    }
}
