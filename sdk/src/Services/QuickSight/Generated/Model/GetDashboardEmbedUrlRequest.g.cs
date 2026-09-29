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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Container for the parameters to the GetDashboardEmbedUrl operation. Generates a temporary
    /// session URL and authorization code(bearer token) that you can use to embed an Amazon
    /// Quick Sight read-only dashboard in your website or application. Before you use this
    /// command, make sure that you have configured the dashboards and permissions. <para>
    /// Currently, you can use <c>GetDashboardEmbedURL</c> only from the server, not from
    /// the user's browser. The following rules apply to the generated URL: </para> <ul> <li>
    /// <para> They must be used together. </para> </li> <li> <para> They can be used one
    /// time only. </para> </li> <li> <para> They are valid for 5 minutes after you run this
    /// command. </para> </li> <li> <para> You are charged only when the URL is used or there
    /// is interaction with Quick. </para> </li> <li> <para> The resulting user session is
    /// valid for 15 minutes (default) up to 10 hours (maximum). You can use the optional
    /// <c>SessionLifetimeInMinutes</c> parameter to customize session duration. </para> </li>
    /// </ul> <para> For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/embedded-analytics-deprecated.html">Embedding
    /// Analytics Using GetDashboardEmbedUrl</a> in the <i>Amazon Quick User Guide</i>. </para>
    /// <para> For more information about the high-level steps for embedding and for an interactive
    /// demo of the ways you can customize embedding, visit the <a href="https://docs.aws.amazon.com/quicksight/latest/user/quicksight-dev-portal.html">Amazon
    /// Quick Developer Portal</a>. </para>
    /// </summary>
    public partial class GetDashboardEmbedUrlRequest : AmazonQuickSightRequest
    {
        /// <summary>
        /// Gets and sets the property AdditionalDashboardIds. 
        /// <para>
        /// A list of one or more dashboard IDs that you want anonymous users to have tempporary
        /// access to. Currently, the <c>IdentityType</c> parameter must be set to <c>ANONYMOUS</c>
        /// because other identity types authenticate as Quick or IAM users. For example, if you
        /// set "<c>--dashboard-id dash_id1 --dashboard-id dash_id2 dash_id3 identity-type ANONYMOUS</c>",
        /// the session can access all three dashboards.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public List<string> AdditionalDashboardIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AdditionalDashboardIds property is set.
        /// </summary>
        internal bool IsSetAdditionalDashboardIds() => this.AdditionalDashboardIds != null && (this.AdditionalDashboardIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID for the Amazon Web Services account that contains the dashboard that you're
        /// embedding.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 12)]
        public string AwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AwsAccountId property is set.
        /// </summary>
        internal bool IsSetAwsAccountId() => this.AwsAccountId != null;

        /// <summary>
        /// Gets and sets the property DashboardId. 
        /// <para>
        /// The ID for the dashboard, also added to the Identity and Access Management (IAM) policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string DashboardId { get; set; }

        /// <summary>
        /// Checks to see if the DashboardId property is set.
        /// </summary>
        internal bool IsSetDashboardId() => this.DashboardId != null;

        /// <summary>
        /// Gets and sets the property IdentityType. 
        /// <para>
        /// The authentication method that the user uses to sign in.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EmbeddingIdentityType IdentityType { get; set; }

        /// <summary>
        /// Checks to see if the IdentityType property is set.
        /// </summary>
        internal bool IsSetIdentityType() => this.IdentityType != null;

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The Amazon Quick Sight namespace that contains the dashboard IDs in this request.
        /// If you're not using a custom namespace, set <c>Namespace = default</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string Namespace { get; set; }

        /// <summary>
        /// Checks to see if the Namespace property is set.
        /// </summary>
        internal bool IsSetNamespace() => this.Namespace != null;

        /// <summary>
        /// Gets and sets the property ResetDisabled. 
        /// <para>
        /// Remove the reset button on the embedded dashboard. The default is FALSE, which enables
        /// the reset button.
        /// </para>
        /// </summary>
        public bool? ResetDisabled { get; set; }

        /// <summary>
        /// Checks to see if the ResetDisabled property is set.
        /// </summary>
        internal bool IsSetResetDisabled() => this.ResetDisabled.HasValue;

        /// <summary>
        /// Gets and sets the property SessionLifetimeInMinutes. 
        /// <para>
        /// How many minutes the session is valid. The session lifetime must be 15-600 minutes.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 15, Max = 600)]
        public long? SessionLifetimeInMinutes { get; set; }

        /// <summary>
        /// Checks to see if the SessionLifetimeInMinutes property is set.
        /// </summary>
        internal bool IsSetSessionLifetimeInMinutes() => this.SessionLifetimeInMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property StatePersistenceEnabled. 
        /// <para>
        /// Adds persistence of state for the user session in an embedded dashboard. Persistence
        /// applies to the sheet and the parameter settings. These are control settings that the
        /// dashboard subscriber (Amazon Quick Sight reader) chooses while viewing the dashboard.
        /// If this is set to <c>TRUE</c>, the settings are the same when the subscriber reopens
        /// the same dashboard URL. The state is stored in Amazon Quick Sight, not in a browser
        /// cookie. If this is set to FALSE, the state of the user session is not persisted. The
        /// default is <c>FALSE</c>.
        /// </para>
        /// </summary>
        public bool? StatePersistenceEnabled { get; set; }

        /// <summary>
        /// Checks to see if the StatePersistenceEnabled property is set.
        /// </summary>
        internal bool IsSetStatePersistenceEnabled() => this.StatePersistenceEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property UndoRedoDisabled. 
        /// <para>
        /// Remove the undo/redo button on the embedded dashboard. The default is FALSE, which
        /// enables the undo/redo button.
        /// </para>
        /// </summary>
        public bool? UndoRedoDisabled { get; set; }

        /// <summary>
        /// Checks to see if the UndoRedoDisabled property is set.
        /// </summary>
        internal bool IsSetUndoRedoDisabled() => this.UndoRedoDisabled.HasValue;

        /// <summary>
        /// Gets and sets the property UserArn. 
        /// <para>
        /// The Amazon Quick user's Amazon Resource Name (ARN), for use with <c>QUICKSIGHT</c>
        /// identity type. You can use this for any Amazon Quick users in your account (readers,
        /// authors, or admins) authenticated as one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Active Directory (AD) users or group members
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Invited nonfederated users
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IAM users and IAM role-based sessions authenticated through Federated Single Sign-On
        /// using SAML, OpenID Connect, or IAM federation.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Omit this parameter for users in the third group – IAM users and IAM role-based sessions.
        /// </para>
        /// </summary>
        public string UserArn { get; set; }

        /// <summary>
        /// Checks to see if the UserArn property is set.
        /// </summary>
        internal bool IsSetUserArn() => this.UserArn != null;
    }
}
