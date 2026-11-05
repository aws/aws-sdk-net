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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the CreateRoleAlias operation. Creates a role alias.
    /// <para> Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CreateRoleAlias</a>
    /// action. </para> <important> <para> The value of <a href="https://docs.aws.amazon.com/iot/latest/apireference/API_CreateRoleAlias.html#iot-CreateRoleAlias-request-credentialDurationSeconds">
    /// <c>credentialDurationSeconds</c> </a> must be less than or equal to the maximum session
    /// duration of the IAM role that the role alias references. For more information, see
    /// <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/roles-managingrole-editing-api.html#roles-modify_max-session-duration-api">
    /// Modifying a role maximum session duration (Amazon Web Services API)</a> from the Amazon
    /// Web Services Identity and Access Management User Guide. </para> </important>
    /// </summary>
    public partial class CreateRoleAliasRequest : AmazonIoTRequest
    {
        /// <summary>
        /// Gets and sets the property CredentialDurationSeconds. 
        /// <para>
        /// How long (in seconds) the credentials will be valid. The default value is 3,600 seconds.
        /// </para>
        ///  
        /// <para>
        /// This value must be less than or equal to the maximum session duration of the IAM role
        /// that the role alias references.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 900, Max = 43200)]
        public int? CredentialDurationSeconds { get; set; }

        /// <summary>
        /// Checks to see if the CredentialDurationSeconds property is set.
        /// </summary>
        internal bool IsSetCredentialDurationSeconds() => this.CredentialDurationSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property RoleAlias. 
        /// <para>
        /// The role alias that points to a role ARN. This allows you to change the role without
        /// having to update the device.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string RoleAlias { get; set; }

        /// <summary>
        /// Checks to see if the RoleAlias property is set.
        /// </summary>
        internal bool IsSetRoleAlias() => this.RoleAlias != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The role ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Metadata which can be used to manage the role alias.
        /// </para>
        ///  <note> 
        /// <para>
        /// For URI Request parameters use format: ...key1=value1&amp;key2=value2...
        /// </para>
        ///  
        /// <para>
        /// For the CLI command-line parameter use format: &amp;&amp;tags "key1=value1&amp;key2=value2..."
        /// </para>
        ///  
        /// <para>
        /// For the cli-input-json file use format: "tags": "key1=value1&amp;key2=value2..."
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
