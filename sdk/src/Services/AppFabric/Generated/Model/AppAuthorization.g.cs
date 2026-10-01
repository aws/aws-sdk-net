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
    /// Contains information about an app authorization.
    /// </summary>
    public partial class AppAuthorization
    {
        /// <summary>
        /// Gets and sets the property App. 
        /// <para>
        /// The name of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string App { get; set; }

        /// <summary>
        /// Checks to see if the App property is set.
        /// </summary>
        internal bool IsSetApp() => this.App != null;

        /// <summary>
        /// Gets and sets the property AppAuthorizationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the app authorization.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1011)]
        public string AppAuthorizationArn { get; set; }

        /// <summary>
        /// Checks to see if the AppAuthorizationArn property is set.
        /// </summary>
        internal bool IsSetAppAuthorizationArn() => this.AppAuthorizationArn != null;

        /// <summary>
        /// Gets and sets the property AppBundleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the app bundle for the app authorization.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1011)]
        public string AppBundleArn { get; set; }

        /// <summary>
        /// Checks to see if the AppBundleArn property is set.
        /// </summary>
        internal bool IsSetAppBundleArn() => this.AppBundleArn != null;

        /// <summary>
        /// Gets and sets the property AuthType. 
        /// <para>
        /// The authorization type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AuthType AuthType { get; set; }

        /// <summary>
        /// Checks to see if the AuthType property is set.
        /// </summary>
        internal bool IsSetAuthType() => this.AuthType != null;

        /// <summary>
        /// Gets and sets the property AuthUrl. 
        /// <para>
        /// The application URL for the OAuth flow.
        /// </para>
        /// </summary>
        public string AuthUrl { get; set; }

        /// <summary>
        /// Checks to see if the AuthUrl property is set.
        /// </summary>
        internal bool IsSetAuthUrl() => this.AuthUrl != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp of when the app authorization was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Persona. 
        /// <para>
        /// The user persona of the app authorization.
        /// </para>
        ///  
        /// <para>
        /// This field should always be <c>admin</c>.
        /// </para>
        /// </summary>
        public Persona Persona { get; set; }

        /// <summary>
        /// Checks to see if the Persona property is set.
        /// </summary>
        internal bool IsSetPersona() => this.Persona != null;

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
        [AWSProperty(Required = true)]
        public AppAuthorizationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Tenant. 
        /// <para>
        /// Contains information about an application tenant, such as the application display
        /// name and identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Tenant Tenant { get; set; }

        /// <summary>
        /// Checks to see if the Tenant property is set.
        /// </summary>
        internal bool IsSetTenant() => this.Tenant != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp of when the app authorization was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
