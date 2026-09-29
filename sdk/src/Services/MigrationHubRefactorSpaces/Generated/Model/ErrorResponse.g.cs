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

namespace Amazon.MigrationHubRefactorSpaces.Model
{
    /// <summary>
    /// Error associated with a resource returned for a Get or List resource response.
    /// </summary>
    public partial class ErrorResponse
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID of the resource owner. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property AdditionalDetails. 
        /// <para>
        /// Additional details about the error. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> AdditionalDetails { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the AdditionalDetails property is set.
        /// </summary>
        internal bool IsSetAdditionalDetails() => this.AdditionalDetails != null && (this.AdditionalDetails.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// The error code associated with the error. 
        /// </para>
        /// </summary>
        public ErrorCode Code { get; set; }

        /// <summary>
        /// Checks to see if the Code property is set.
        /// </summary>
        internal bool IsSetCode() => this.Code != null;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The message associated with the error. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property ResourceIdentifier. 
        /// <para>
        /// The ID of the resource. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 63)]
        public string ResourceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ResourceIdentifier property is set.
        /// </summary>
        internal bool IsSetResourceIdentifier() => this.ResourceIdentifier != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of resource. 
        /// </para>
        /// </summary>
        public ErrorResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;
    }
}
