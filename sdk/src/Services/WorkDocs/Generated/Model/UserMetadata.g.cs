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

namespace Amazon.WorkDocs.Model
{
    /// <summary>
    /// Describes the metadata of the user.
    /// </summary>
    public partial class UserMetadata
    {
        /// <summary>
        /// Gets and sets the property EmailAddress. 
        /// <para>
        /// The email address of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 256)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Checks to see if the EmailAddress property is set.
        /// </summary>
        internal bool IsSetEmailAddress() => this.EmailAddress != null;

        /// <summary>
        /// Gets and sets the property GivenName. 
        /// <para>
        /// The given name of the user before a rename operation.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 64)]
        public string GivenName { get; set; }

        /// <summary>
        /// Checks to see if the GivenName property is set.
        /// </summary>
        internal bool IsSetGivenName() => this.GivenName != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Surname. 
        /// <para>
        /// The surname of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 64)]
        public string Surname { get; set; }

        /// <summary>
        /// Checks to see if the Surname property is set.
        /// </summary>
        internal bool IsSetSurname() => this.Surname != null;

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// The name of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 256)]
        public string Username { get; set; }

        /// <summary>
        /// Checks to see if the Username property is set.
        /// </summary>
        internal bool IsSetUsername() => this.Username != null;
    }
}
