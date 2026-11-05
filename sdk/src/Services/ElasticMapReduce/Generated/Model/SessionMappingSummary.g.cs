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

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Details for an Amazon EMR Studio session mapping. The details do not include the time
    /// the session mapping was last modified.
    /// </summary>
    public partial class SessionMappingSummary
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time the session mapping was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property IdentityId. 
        /// <para>
        /// The globally unique identifier (GUID) of the user or group from the IAM Identity Center
        /// Identity Store.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string IdentityId { get; set; }

        /// <summary>
        /// Checks to see if the IdentityId property is set.
        /// </summary>
        internal bool IsSetIdentityId() => this.IdentityId != null;

        /// <summary>
        /// Gets and sets the property IdentityName. 
        /// <para>
        /// The name of the user or group. For more information, see <a href="https://docs.aws.amazon.com/singlesignon/latest/IdentityStoreAPIReference/API_User.html#singlesignon-Type-User-UserName">UserName</a>
        /// and <a href="https://docs.aws.amazon.com/singlesignon/latest/IdentityStoreAPIReference/API_Group.html#singlesignon-Type-Group-DisplayName">DisplayName</a>
        /// in the <i>IAM Identity Center Identity Store API Reference</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string IdentityName { get; set; }

        /// <summary>
        /// Checks to see if the IdentityName property is set.
        /// </summary>
        internal bool IsSetIdentityName() => this.IdentityName != null;

        /// <summary>
        /// Gets and sets the property IdentityType. 
        /// <para>
        /// Specifies whether the identity mapped to the Amazon EMR Studio is a user or a group.
        /// </para>
        /// </summary>
        public IdentityType IdentityType { get; set; }

        /// <summary>
        /// Checks to see if the IdentityType property is set.
        /// </summary>
        internal bool IsSetIdentityType() => this.IdentityType != null;

        /// <summary>
        /// Gets and sets the property SessionPolicyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the session policy associated with the user or group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string SessionPolicyArn { get; set; }

        /// <summary>
        /// Checks to see if the SessionPolicyArn property is set.
        /// </summary>
        internal bool IsSetSessionPolicyArn() => this.SessionPolicyArn != null;

        /// <summary>
        /// Gets and sets the property StudioId. 
        /// <para>
        /// The ID of the Amazon EMR Studio.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string StudioId { get; set; }

        /// <summary>
        /// Checks to see if the StudioId property is set.
        /// </summary>
        internal bool IsSetStudioId() => this.StudioId != null;
    }
}
