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

namespace Amazon.AppFabric.Model
{
    /// <summary>
    /// Container for the parameters to the CreateIngestion operation. Creates a data ingestion
    /// for an application.
    /// </summary>
    public partial class CreateIngestionRequest : AmazonAppFabricRequest
    {
        /// <summary>
        /// Gets and sets the property App. 
        /// <para>
        /// The name of the application.
        /// </para>
        ///  
        /// <para>
        /// Valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SLACK</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ASANA</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>JIRA</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>M365</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>M365AUDITLOGS</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ZOOM</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ZENDESK</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OKTA</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GOOGLE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DROPBOX</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SMARTSHEET</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CISCO</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string App { get; set; }

        /// <summary>
        /// Checks to see if the App property is set.
        /// </summary>
        internal bool IsSetApp() => this.App != null;

        /// <summary>
        /// Gets and sets the property AppBundleIdentifier. 
        /// <para>
        /// The Amazon Resource Name (ARN) or Universal Unique Identifier (UUID) of the app bundle
        /// to use for the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1011)]
        public string AppBundleIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the AppBundleIdentifier property is set.
        /// </summary>
        internal bool IsSetAppBundleIdentifier() => this.AppBundleIdentifier != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Specifies a unique, case-sensitive identifier that you provide to ensure the idempotency
        /// of the request. This lets you safely retry the request without accidentally performing
        /// the same operation a second time. Passing the same value to a later call to an operation
        /// requires that you also pass the same value for all other parameters. We recommend
        /// that you use a <a href="https://wikipedia.org/wiki/Universally_unique_identifier">UUID
        /// type of value</a>.
        /// </para>
        ///  
        /// <para>
        /// If you don't provide this value, then Amazon Web Services generates a random one for
        /// you.
        /// </para>
        ///  
        /// <para>
        /// If you retry the operation with the same <c>ClientToken</c>, but with different parameters,
        /// the retry fails with an <c>IdempotentParameterMismatch</c> error.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property IngestionType. 
        /// <para>
        /// The ingestion type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public IngestionType IngestionType { get; set; }

        /// <summary>
        /// Checks to see if the IngestionType property is set.
        /// </summary>
        internal bool IsSetIngestionType() => this.IngestionType != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map of the key-value pairs of the tag or tags to assign to the resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TenantId. 
        /// <para>
        /// The ID of the application tenant.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string TenantId { get; set; }

        /// <summary>
        /// Checks to see if the TenantId property is set.
        /// </summary>
        internal bool IsSetTenantId() => this.TenantId != null;
    }
}
