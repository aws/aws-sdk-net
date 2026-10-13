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

namespace Amazon.SSOAdmin.Model
{
    /// <summary>
    /// A structure that describes an application that uses IAM Identity Center for access
    /// management.
    /// </summary>
    public partial class Application
    {
        /// <summary>
        /// Gets and sets the property ApplicationAccount. 
        /// <para>
        /// The Amazon Web Services account ID number of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string ApplicationAccount { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationAccount property is set.
        /// </summary>
        internal bool IsSetApplicationAccount() => this.ApplicationAccount != null;

        /// <summary>
        /// Gets and sets the property ApplicationArn. 
        /// <para>
        /// The ARN of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 1224)]
        public string ApplicationArn { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationArn property is set.
        /// </summary>
        internal bool IsSetApplicationArn() => this.ApplicationArn != null;

        /// <summary>
        /// Gets and sets the property ApplicationProviderArn. 
        /// <para>
        /// The ARN of the application provider for this application.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 1224)]
        public string ApplicationProviderArn { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationProviderArn property is set.
        /// </summary>
        internal bool IsSetApplicationProviderArn() => this.ApplicationProviderArn != null;

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The date and time when the application was originally created.
        /// </para>
        /// </summary>
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Checks to see if the CreatedDate property is set.
        /// </summary>
        internal bool IsSetCreatedDate() => this.CreatedDate.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedFrom. 
        /// <para>
        /// The Amazon Web Services Region where the application was created in IAM Identity Center.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public string CreatedFrom { get; set; }

        /// <summary>
        /// Checks to see if the CreatedFrom property is set.
        /// </summary>
        internal bool IsSetCreatedFrom() => this.CreatedFrom != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property IdentityStoreArn. 
        /// <para>
        /// The ARN of the identity store that is connected to the instance of IAM Identity Center.
        /// </para>
        /// </summary>
        public string IdentityStoreArn { get; set; }

        /// <summary>
        /// Checks to see if the IdentityStoreArn property is set.
        /// </summary>
        internal bool IsSetIdentityStoreArn() => this.IdentityStoreArn != null;

        /// <summary>
        /// Gets and sets the property InstanceArn. 
        /// <para>
        /// The ARN of the instance of IAM Identity Center that is configured with this application.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 1224)]
        public string InstanceArn { get; set; }

        /// <summary>
        /// Checks to see if the InstanceArn property is set.
        /// </summary>
        internal bool IsSetInstanceArn() => this.InstanceArn != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PortalOptions. 
        /// <para>
        /// A structure that describes the options for the access portal associated with this
        /// application.
        /// </para>
        /// </summary>
        public PortalOptions PortalOptions { get; set; }

        /// <summary>
        /// Checks to see if the PortalOptions property is set.
        /// </summary>
        internal bool IsSetPortalOptions() => this.PortalOptions != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the application in this instance of IAM Identity Center.
        /// </para>
        /// </summary>
        public ApplicationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
