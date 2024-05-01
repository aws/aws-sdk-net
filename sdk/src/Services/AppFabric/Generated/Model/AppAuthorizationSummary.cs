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
    /// Contains a summary of an app authorization.
    /// </summary>
    public partial class AppAuthorizationSummary
    {
        private string _app;
        private string _appAuthorizationArn;
        private string _appBundleArn;
        private AppAuthorizationStatus _status;
        private Tenant _tenant;
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
        /// Gets and sets the property AppAuthorizationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the app authorization.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1011)]
        public string AppAuthorizationArn
        {
            get { return this._appAuthorizationArn; }
            set { this._appAuthorizationArn = value; }
        }

        // Check to see if AppAuthorizationArn property is set
        internal bool IsSetAppAuthorizationArn()
        {
            return this._appAuthorizationArn != null;
        }

        /// <summary>
        /// Gets and sets the property AppBundleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the app bundle for the app authorization.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The state of the app authorization.
        /// </para>
        ///  
        /// <para>
        /// The following states are possible:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PendingConnect</c>: The initial state of the app authorization. The app authorization
        /// is created but not yet connected.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Connected</c>: The app authorization is connected to the application, and is ready
        /// to be used.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ConnectionValidationFailed</c>: The app authorization received a validation exception
        /// when trying to connect to the application. If the app authorization is in this state,
        /// you should verify the configured credentials and try to connect the app authorization
        /// again.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TokenAutoRotationFailed</c>: AppFabric failed to refresh the access token. If
        /// the app authorization is in this state, you should try to reconnect the app authorization.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public AppAuthorizationStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Tenant. 
        /// <para>
        /// Contains information about an application tenant, such as the application display
        /// name and identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Tenant Tenant
        {
            get { return this._tenant; }
            set { this._tenant = value; }
        }

        // Check to see if Tenant property is set
        internal bool IsSetTenant()
        {
            return this._tenant != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// Timestamp for when the app authorization was last updated.
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