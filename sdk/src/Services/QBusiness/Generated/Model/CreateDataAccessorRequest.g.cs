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
    /// Container for the parameters to the CreateDataAccessor operation. Creates a new data
    /// accessor for an ISV to access data from a Amazon Q Business application. The data
    /// accessor is an entity that represents the ISV's access to the Amazon Q Business application's
    /// data. It includes the IAM role ARN for the ISV, a friendly name, and a set of action
    /// configurations that define the specific actions the ISV is allowed to perform and
    /// any associated data filters. When the data accessor is created, an IAM Identity Center
    /// application is also created to manage the ISV's identity and authentication for accessing
    /// the Amazon Q Business application.
    /// </summary>
    public partial class CreateDataAccessorRequest : AmazonQBusinessRequest
    {
        /// <summary>
        /// Gets and sets the property ActionConfigurations. 
        /// <para>
        /// A list of action configurations specifying the allowed actions and any associated
        /// filters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10)]
        public List<ActionConfiguration> ActionConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<ActionConfiguration>() : null;

        /// <summary>
        /// Checks to see if the ActionConfigurations property is set.
        /// </summary>
        internal bool IsSetActionConfigurations() => this.ActionConfigurations != null && (this.ActionConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The unique identifier of the Amazon Q Business application.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

        /// <summary>
        /// Gets and sets the property AuthenticationDetail. 
        /// <para>
        /// The authentication configuration details for the data accessor. This specifies how
        /// the ISV will authenticate when accessing data through this data accessor.
        /// </para>
        /// </summary>
        public DataAccessorAuthenticationDetail AuthenticationDetail { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticationDetail property is set.
        /// </summary>
        internal bool IsSetAuthenticationDetail() => this.AuthenticationDetail != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier you provide to ensure idempotency of the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// A friendly name for the data accessor.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 100)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property Principal. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role for the ISV that will be accessing
        /// the data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1284)]
        public string Principal { get; set; }

        /// <summary>
        /// Checks to see if the Principal property is set.
        /// </summary>
        internal bool IsSetPrincipal() => this.Principal != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to associate with the data accessor.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
