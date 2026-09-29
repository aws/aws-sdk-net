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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A structure that contains information to identify a user.
    /// </summary>
    public partial class UserIdentifier
    {
        /// <summary>
        /// Gets and sets the property Email. 
        /// <para>
        /// The email address of the user that you want to get identity context for.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string Email { get; set; }

        /// <summary>
        /// Checks to see if the Email property is set.
        /// </summary>
        internal bool IsSetEmail() => this.Email != null;

        /// <summary>
        /// Gets and sets the property UserArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the user that you want to get identity context for.
        /// </para>
        /// </summary>
        public string UserArn { get; set; }

        /// <summary>
        /// Checks to see if the UserArn property is set.
        /// </summary>
        internal bool IsSetUserArn() => this.UserArn != null;

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// The name of the user that you want to get identity context for.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string UserName { get; set; }

        /// <summary>
        /// Checks to see if the UserName property is set.
        /// </summary>
        internal bool IsSetUserName() => this.UserName != null;
    }
}
