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
    /// Container for the parameters to the CreatePermissionSet operation. Creates a permission
    /// set within a specified IAM Identity Center instance. <note> <para> To grant users
    /// and groups access to Amazon Web Services account resources, use <c> <a>CreateAccountAssignment</a>
    /// </c>. </para> </note>
    /// </summary>
    public partial class CreatePermissionSetRequest : AmazonSSOAdminRequest
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the <a>PermissionSet</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 700)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property InstanceArn. 
        /// <para>
        /// The ARN of the IAM Identity Center instance under which the operation will be executed.
        /// For more information about ARNs, see <a href="/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs) and Amazon Web Services Service Namespaces</a> in the <i>Amazon
        /// Web Services General Reference</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 1224)]
        public string InstanceArn { get; set; }

        /// <summary>
        /// Checks to see if the InstanceArn property is set.
        /// </summary>
        internal bool IsSetInstanceArn() => this.InstanceArn != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the <a>PermissionSet</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 32)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RelayState. 
        /// <para>
        /// Used to redirect users within the application during the federation authentication
        /// process.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 240)]
        public string RelayState { get; set; }

        /// <summary>
        /// Checks to see if the RelayState property is set.
        /// </summary>
        internal bool IsSetRelayState() => this.RelayState != null;

        /// <summary>
        /// Gets and sets the property SessionDuration. 
        /// <para>
        /// The length of time that the application user sessions are valid in the ISO-8601 standard.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string SessionDuration { get; set; }

        /// <summary>
        /// Checks to see if the SessionDuration property is set.
        /// </summary>
        internal bool IsSetSessionDuration() => this.SessionDuration != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to attach to the new <a>PermissionSet</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 75)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
