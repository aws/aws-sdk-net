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

namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// Provides the SAML 2.0 compliant identity provider (IdP) configuration information
    /// Amazon Q Business needs to deploy a Amazon Q Business web experience.
    /// </summary>
    public partial class SamlConfiguration
    {
        /// <summary>
        /// Gets and sets the property MetadataXML. 
        /// <para>
        /// The metadata XML that your IdP generated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1000, Max = 10000000)]
        public string MetadataXML { get; set; }

        /// <summary>
        /// Checks to see if the MetadataXML property is set.
        /// </summary>
        internal bool IsSetMetadataXML() => this.MetadataXML != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an IAM role assumed by users when they authenticate
        /// into their Amazon Q Business web experience, containing the relevant Amazon Q Business
        /// permissions for conversing with Amazon Q Business.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1284)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property UserGroupAttribute. 
        /// <para>
        /// The group attribute name in your IdP that maps to user groups.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string UserGroupAttribute { get; set; }

        /// <summary>
        /// Checks to see if the UserGroupAttribute property is set.
        /// </summary>
        internal bool IsSetUserGroupAttribute() => this.UserGroupAttribute != null;

        /// <summary>
        /// Gets and sets the property UserIdAttribute. 
        /// <para>
        /// The user attribute name in your IdP that maps to the user email.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string UserIdAttribute { get; set; }

        /// <summary>
        /// Checks to see if the UserIdAttribute property is set.
        /// </summary>
        internal bool IsSetUserIdAttribute() => this.UserIdAttribute != null;
    }
}
