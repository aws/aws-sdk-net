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

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Contains an identity that can access an IoT SiteWise Monitor resource.
    /// 
    ///  <note> 
    /// <para>
    /// Currently, you can't use Amazon Web Services API operations to retrieve IAM Identity
    /// Center identity IDs. You can find the IAM Identity Center identity IDs in the URL
    /// of user and group pages in the <a href="https://console.aws.amazon.com/singlesignon">IAM
    /// Identity Center console</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class Identity
    {
        /// <summary>
        /// Gets and sets the property Group. 
        /// <para>
        /// An IAM Identity Center group identity.
        /// </para>
        /// </summary>
        public GroupIdentity Group { get; set; }

        /// <summary>
        /// Checks to see if the Group property is set.
        /// </summary>
        internal bool IsSetGroup() => this.Group != null;

        /// <summary>
        /// Gets and sets the property IamRole. 
        /// <para>
        /// An IAM role identity.
        /// </para>
        /// </summary>
        public IAMRoleIdentity IamRole { get; set; }

        /// <summary>
        /// Checks to see if the IamRole property is set.
        /// </summary>
        internal bool IsSetIamRole() => this.IamRole != null;

        /// <summary>
        /// Gets and sets the property IamUser. 
        /// <para>
        /// An IAM user identity.
        /// </para>
        /// </summary>
        public IAMUserIdentity IamUser { get; set; }

        /// <summary>
        /// Checks to see if the IamUser property is set.
        /// </summary>
        internal bool IsSetIamUser() => this.IamUser != null;

        /// <summary>
        /// Gets and sets the property User. 
        /// <para>
        /// An IAM Identity Center user identity.
        /// </para>
        /// </summary>
        public UserIdentity User { get; set; }

        /// <summary>
        /// Checks to see if the User property is set.
        /// </summary>
        internal bool IsSetUser() => this.User != null;
    }
}
