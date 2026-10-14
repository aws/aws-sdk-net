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

namespace Amazon.WorkMail.Model
{
    /// <summary>
    /// This is the response object from the GetPersonalAccessTokenMetadata operation.
    /// </summary>
    public partial class GetPersonalAccessTokenMetadataResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property DateCreated. 
        /// <para>
        ///  The date when the Personal Access Token ID was created. 
        /// </para>
        /// </summary>
        public DateTime? DateCreated { get; set; }

        /// <summary>
        /// Checks to see if the DateCreated property is set.
        /// </summary>
        internal bool IsSetDateCreated() => this.DateCreated.HasValue;

        /// <summary>
        /// Gets and sets the property DateLastUsed. 
        /// <para>
        ///  The date when the Personal Access Token ID was last used. 
        /// </para>
        /// </summary>
        public DateTime? DateLastUsed { get; set; }

        /// <summary>
        /// Checks to see if the DateLastUsed property is set.
        /// </summary>
        internal bool IsSetDateLastUsed() => this.DateLastUsed.HasValue;

        /// <summary>
        /// Gets and sets the property ExpiresTime. 
        /// <para>
        ///  The time when the Personal Access Token ID will expire. 
        /// </para>
        /// </summary>
        public DateTime? ExpiresTime { get; set; }

        /// <summary>
        /// Checks to see if the ExpiresTime property is set.
        /// </summary>
        internal bool IsSetExpiresTime() => this.ExpiresTime.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The Personal Access Token name. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PersonalAccessTokenId. 
        /// <para>
        ///  The Personal Access Token ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string PersonalAccessTokenId { get; set; }

        /// <summary>
        /// Checks to see if the PersonalAccessTokenId property is set.
        /// </summary>
        internal bool IsSetPersonalAccessTokenId() => this.PersonalAccessTokenId != null;

        /// <summary>
        /// Gets and sets the property Scopes. 
        /// <para>
        ///  Lists all the Personal Access Token permissions for a mailbox. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<string> Scopes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Scopes property is set.
        /// </summary>
        internal bool IsSetScopes() => this.Scopes != null && (this.Scopes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        ///  The WorkMail User ID. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 256)]
        public string UserId { get; set; }

        /// <summary>
        /// Checks to see if the UserId property is set.
        /// </summary>
        internal bool IsSetUserId() => this.UserId != null;
    }
}
