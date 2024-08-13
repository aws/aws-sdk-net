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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.AppFabric.Model
{
    /// <summary>
    /// Contains information about an ingestion.
    /// </summary>
    public partial class Ingestion
    {
        private string _app;
        private string _appBundleArn;
        private string _arn;
        private DateTime? _createdAt;
        private IngestionType _ingestionType;
        private IngestionState _state;
        private string _tenantId;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property App. 
        /// <para>
        /// The name of the application.
        /// </para>
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
        /// Gets and sets the property AppBundleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the app bundle for the ingestion.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1011)]
        public string AppBundleArn
        {
            get { return this._appBundleArn; }
            set { this._appBundleArn = value; }
        }

        // Check to see if AppBundleArn property is set
        internal bool IsSetAppBundleArn()
        {
            return this._appBundleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the ingestion.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1011)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp of when the ingestion was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IngestionType. 
        /// <para>
        /// The type of the ingestion.
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
        /// Gets and sets the property State. 
        /// <para>
        /// The status of the ingestion.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IngestionState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
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

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp of when the ingestion was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}