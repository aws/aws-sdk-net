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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Provides details about a labeling work team.
    /// </summary>
    public partial class Workteam
    {
        /// <summary>
        /// Gets and sets the property CreateDate. 
        /// <para>
        /// The date and time that the work team was created (timestamp).
        /// </para>
        /// </summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// Checks to see if the CreateDate property is set.
        /// </summary>
        internal bool IsSetCreateDate() => this.CreateDate.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the work team.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 200)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedDate. 
        /// <para>
        /// The date and time that the work team was last updated (timestamp).
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedDate property is set.
        /// </summary>
        internal bool IsSetLastUpdatedDate() => this.LastUpdatedDate.HasValue;

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
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10)]
        public List<MemberDefinition> MemberDefinitions { get; set; } = AWSConfigs.InitializeCollections ? new List<MemberDefinition>() : null;

        /// <summary>
        /// Checks to see if the MemberDefinitions property is set.
        /// </summary>
        internal bool IsSetMemberDefinitions() => this.MemberDefinitions != null && (this.MemberDefinitions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NotificationConfiguration. 
        /// <para>
        /// Configures SNS notifications of available or expiring work items for work teams.
        /// </para>
        /// </summary>
        public NotificationConfiguration NotificationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the NotificationConfiguration property is set.
        /// </summary>
        internal bool IsSetNotificationConfiguration() => this.NotificationConfiguration != null;

        /// <summary>
        /// Gets and sets the property ProductListingIds. 
        /// <para>
        /// The Amazon Marketplace identifier for a vendor's work team.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ProductListingIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ProductListingIds property is set.
        /// </summary>
        internal bool IsSetProductListingIds() => this.ProductListingIds != null && (this.ProductListingIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SubDomain. 
        /// <para>
        /// The URI of the labeling job's user interface. Workers open this URI to start labeling
        /// your data objects.
        /// </para>
        /// </summary>
        public string SubDomain { get; set; }

        /// <summary>
        /// Checks to see if the SubDomain property is set.
        /// </summary>
        internal bool IsSetSubDomain() => this.SubDomain != null;

        /// <summary>
        /// Gets and sets the property WorkerAccessConfiguration. 
        /// <para>
        /// Describes any access constraints that have been defined for Amazon S3 resources.
        /// </para>
        /// </summary>
        public WorkerAccessConfiguration WorkerAccessConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the WorkerAccessConfiguration property is set.
        /// </summary>
        internal bool IsSetWorkerAccessConfiguration() => this.WorkerAccessConfiguration != null;

        /// <summary>
        /// Gets and sets the property WorkforceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the workforce.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string WorkforceArn { get; set; }

        /// <summary>
        /// Checks to see if the WorkforceArn property is set.
        /// </summary>
        internal bool IsSetWorkforceArn() => this.WorkforceArn != null;

        /// <summary>
        /// Gets and sets the property WorkteamArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that identifies the work team.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string WorkteamArn { get; set; }

        /// <summary>
        /// Checks to see if the WorkteamArn property is set.
        /// </summary>
        internal bool IsSetWorkteamArn() => this.WorkteamArn != null;

        /// <summary>
        /// Gets and sets the property WorkteamName. 
        /// <para>
        /// The name of the work team.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string WorkteamName { get; set; }

        /// <summary>
        /// Checks to see if the WorkteamName property is set.
        /// </summary>
        internal bool IsSetWorkteamName() => this.WorkteamName != null;
    }
}
