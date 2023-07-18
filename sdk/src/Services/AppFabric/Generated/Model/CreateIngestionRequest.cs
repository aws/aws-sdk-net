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
 * Do not modify this file. This file is generated from the appfabric-2023-05-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppFabric.Model
{
    /// <summary>
    /// Container for the parameters to the CreateIngestion operation.
    /// Creates a data ingestion for an application.
    /// </summary>
    public partial class CreateIngestionRequest : AmazonAppFabricRequest
    {
        private string _app;
        private string _appBundleIdentifier;
        private string _clientToken;
        private IngestionType _ingestionType;
        private List<Tag> _tags = new List<Tag>();
        private string _tenantId;

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
        ///  <code>SLACK</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ASANA</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>JIRA</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>M365</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>M365AUDITLOGS</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ZOOM</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ZENDESK</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>OKTA</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>GOOGLE</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DROPBOX</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SMARTSHEET</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CISCO</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string App
        {
            get { return this._app; }
            set { this._app = value; }
        }

        // Check to see if App property is set
        internal bool IsSetApp()
        {
            return this._app != null;
        }

        /// <summary>
        /// Gets and sets the property AppBundleIdentifier. 
        /// <para>
        /// The Amazon Resource Name (ARN) or Universal Unique Identifier (UUID) of the app bundle
        /// to use for the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1011)]
        public string AppBundleIdentifier
        {
            get { return this._appBundleIdentifier; }
            set { this._appBundleIdentifier = value; }
        }

        // Check to see if AppBundleIdentifier property is set
        internal bool IsSetAppBundleIdentifier()
        {
            return this._appBundleIdentifier != null;
        }

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
        /// If you retry the operation with the same <code>ClientToken</code>, but with different
        /// parameters, the retry fails with an <code>IdempotentParameterMismatch</code> error.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property IngestionType. 
        /// <para>
        /// The ingestion type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IngestionType IngestionType
        {
            get { return this._ingestionType; }
            set { this._ingestionType = value; }
        }

        // Check to see if IngestionType property is set
        internal bool IsSetIngestionType()
        {
            return this._ingestionType != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map of the key-value pairs of the tag or tags to assign to the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TenantId. 
        /// <para>
        /// The ID of the application tenant.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string TenantId
        {
            get { return this._tenantId; }
            set { this._tenantId = value; }
        }

        // Check to see if TenantId property is set
        internal bool IsSetTenantId()
        {
            return this._tenantId != null;
        }

    }
}