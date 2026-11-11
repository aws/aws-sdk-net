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

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyUser operation. Changes user password(s)
    /// and/or access string.
    /// </summary>
    public partial class ModifyUserRequest : AmazonElastiCacheRequest
    {
        /// <summary>
        /// Gets and sets the property AccessString. 
        /// <para>
        /// Access permissions string used for this user.
        /// </para>
        /// </summary>
        public string AccessString { get; set; }

        /// <summary>
        /// Checks to see if the AccessString property is set.
        /// </summary>
        internal bool IsSetAccessString() => this.AccessString != null;

        /// <summary>
        /// Gets and sets the property AppendAccessString. 
        /// <para>
        /// Adds additional user permissions to the access string.
        /// </para>
        /// </summary>
        public string AppendAccessString { get; set; }

        /// <summary>
        /// Checks to see if the AppendAccessString property is set.
        /// </summary>
        internal bool IsSetAppendAccessString() => this.AppendAccessString != null;

        /// <summary>
        /// Gets and sets the property AuthenticationMode. 
        /// <para>
        /// Specifies how to authenticate the user.
        /// </para>
        /// </summary>
        public AuthenticationMode AuthenticationMode { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticationMode property is set.
        /// </summary>
        internal bool IsSetAuthenticationMode() => this.AuthenticationMode != null;

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// Modifies the engine listed for a user. The options are valkey or redis.
        /// </para>
        /// </summary>
        public string Engine { get; set; }

        /// <summary>
        /// Checks to see if the Engine property is set.
        /// </summary>
        internal bool IsSetEngine() => this.Engine != null;

        /// <summary>
        /// Gets and sets the property NoPasswordRequired. 
        /// <para>
        /// Indicates no password is required for the user.
        /// </para>
        /// </summary>
        public bool? NoPasswordRequired { get; set; }

        /// <summary>
        /// Checks to see if the NoPasswordRequired property is set.
        /// </summary>
        internal bool IsSetNoPasswordRequired() => this.NoPasswordRequired.HasValue;

        /// <summary>
        /// Gets and sets the property Passwords. 
        /// <para>
        /// The passwords belonging to the user. You are allowed up to two.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<string> Passwords { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Passwords property is set.
        /// </summary>
        internal bool IsSetPasswords() => this.Passwords != null && (this.Passwords.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The ID of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string UserId { get; set; }

        /// <summary>
        /// Checks to see if the UserId property is set.
        /// </summary>
        internal bool IsSetUserId() => this.UserId != null;
    }
}
