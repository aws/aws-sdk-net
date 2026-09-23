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

namespace Amazon.ChimeSDKIdentity.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAppInstanceUser operation. Creates a user
    /// under an Amazon Chime <c>AppInstance</c>. The request consists of a unique <c>appInstanceUserId</c>
    /// and <c>Name</c> for that user.
    /// </summary>
    public partial class CreateAppInstanceUserRequest : AmazonChimeSDKIdentityRequest
    {
        /// <summary>
        /// Gets and sets the property AppInstanceArn. 
        /// <para>
        /// The ARN of the <c>AppInstance</c> request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 5, Max = 1600)]
        public string AppInstanceArn { get; set; }

        /// <summary>
        /// Checks to see if the AppInstanceArn property is set.
        /// </summary>
        internal bool IsSetAppInstanceArn() => this.AppInstanceArn != null;

        /// <summary>
        /// Gets and sets the property AppInstanceUserId. 
        /// <para>
        /// The user ID of the <c>AppInstance</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 64)]
        public string AppInstanceUserId { get; set; }

        /// <summary>
        /// Checks to see if the AppInstanceUserId property is set.
        /// </summary>
        internal bool IsSetAppInstanceUserId() => this.AppInstanceUserId != null;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// The unique ID of the request. Use different tokens to request additional <c>AppInstances</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 64)]
        public string ClientRequestToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientRequestToken property is set.
        /// </summary>
        internal bool IsSetClientRequestToken() => this.ClientRequestToken != null;

        /// <summary>
        /// Gets and sets the property ExpirationSettings. 
        /// <para>
        /// Settings that control the interval after which the <c>AppInstanceUser</c> is automatically
        /// deleted.
        /// </para>
        /// </summary>
        public ExpirationSettings ExpirationSettings { get; set; }

        /// <summary>
        /// Checks to see if the ExpirationSettings property is set.
        /// </summary>
        internal bool IsSetExpirationSettings() => this.ExpirationSettings != null;

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// The request's metadata. Limited to a 1KB string in UTF-8.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 1024)]
        public string Metadata { get; set; }

        /// <summary>
        /// Checks to see if the Metadata property is set.
        /// </summary>
        internal bool IsSetMetadata() => this.Metadata != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The user's name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 100)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags assigned to the <c>AppInstanceUser</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
