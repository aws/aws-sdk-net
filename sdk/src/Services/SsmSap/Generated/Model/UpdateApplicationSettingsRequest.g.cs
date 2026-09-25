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

namespace Amazon.SsmSap.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateApplicationSettings operation. Updates the
    /// settings of an application registered with AWS Systems Manager for SAP.
    /// </summary>
    public partial class UpdateApplicationSettingsRequest : AmazonSsmSapRequest
    {
        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The ID of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 60)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

        /// <summary>
        /// Gets and sets the property Backint. 
        /// <para>
        /// Installation of AWS Backint Agent for SAP HANA.
        /// </para>
        /// </summary>
        public BackintConfig Backint { get; set; }

        /// <summary>
        /// Checks to see if the Backint property is set.
        /// </summary>
        internal bool IsSetBackint() => this.Backint != null;

        /// <summary>
        /// Gets and sets the property CredentialsToAddOrUpdate. 
        /// <para>
        /// The credentials to be added or updated.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public List<ApplicationCredential> CredentialsToAddOrUpdate { get; set; } = AWSConfigs.InitializeCollections ? new List<ApplicationCredential>() : null;

        /// <summary>
        /// Checks to see if the CredentialsToAddOrUpdate property is set.
        /// </summary>
        internal bool IsSetCredentialsToAddOrUpdate() => this.CredentialsToAddOrUpdate != null && (this.CredentialsToAddOrUpdate.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CredentialsToRemove. 
        /// <para>
        /// The credentials to be removed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public List<ApplicationCredential> CredentialsToRemove { get; set; } = AWSConfigs.InitializeCollections ? new List<ApplicationCredential>() : null;

        /// <summary>
        /// Checks to see if the CredentialsToRemove property is set.
        /// </summary>
        internal bool IsSetCredentialsToRemove() => this.CredentialsToRemove != null && (this.CredentialsToRemove.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DatabaseArn. 
        /// <para>
        /// The Amazon Resource Name of the SAP HANA database that replaces the current SAP HANA
        /// connection with the SAP_ABAP application.
        /// </para>
        /// </summary>
        public string DatabaseArn { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseArn property is set.
        /// </summary>
        internal bool IsSetDatabaseArn() => this.DatabaseArn != null;
    }
}
