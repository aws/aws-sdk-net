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
    /// A summary of an OAuthClientApplication.
    /// </summary>
    public partial class OAuthClientApplicationSummary
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the OAuthClientApplication.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The time that the OAuthClientApplication was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTime property is set.
        /// </summary>
        internal bool IsSetCreatedTime() => this.CreatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property DataSourceType. 
        /// <para>
        /// The type of data source that the OAuthClientApplication is used with. Valid values
        /// are <c>SNOWFLAKE</c>.
        /// </para>
        /// </summary>
        public DataSourceType DataSourceType { get; set; }

        /// <summary>
        /// Checks to see if the DataSourceType property is set.
        /// </summary>
        internal bool IsSetDataSourceType() => this.DataSourceType != null;

        /// <summary>
        /// Gets and sets the property IdentityProviderVpcConnectionProperties.
        /// </summary>
        public VpcConnectionProperties IdentityProviderVpcConnectionProperties { get; set; }

        /// <summary>
        /// Checks to see if the IdentityProviderVpcConnectionProperties property is set.
        /// </summary>
        internal bool IsSetIdentityProviderVpcConnectionProperties() => this.IdentityProviderVpcConnectionProperties != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The time that the OAuthClientApplication was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTime() => this.LastUpdatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The display name of the OAuthClientApplication.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OAuthClientApplicationId. 
        /// <para>
        /// The ID of the OAuthClientApplication. This ID is unique per Amazon Web Services Region
        /// for each Amazon Web Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string OAuthClientApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the OAuthClientApplicationId property is set.
        /// </summary>
        internal bool IsSetOAuthClientApplicationId() => this.OAuthClientApplicationId != null;

        /// <summary>
        /// Gets and sets the property OAuthClientAuthenticationType. 
        /// <para>
        /// The OAuth client authentication type used by the OAuthClientApplication. Valid values
        /// are <c>TOKEN</c>.
        /// </para>
        /// </summary>
        public OAuthClientAuthenticationType OAuthClientAuthenticationType { get; set; }

        /// <summary>
        /// Checks to see if the OAuthClientAuthenticationType property is set.
        /// </summary>
        internal bool IsSetOAuthClientAuthenticationType() => this.OAuthClientAuthenticationType != null;
    }
}
