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

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Summary information for users or groups in your IAM Identity Center identity source
    /// with granted access to your Amazon Kendra experience. You can create an Amazon Kendra
    /// experience such as a search application. For more information on creating a search
    /// application experience, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/deploying-search-experience-no-code.html">Building
    /// a search experience with no code</a>.
    /// </summary>
    public partial class ExperienceEntitiesSummary
    {
        /// <summary>
        /// Gets and sets the property DisplayData. 
        /// <para>
        /// Information about the user entity.
        /// </para>
        /// </summary>
        public EntityDisplayData DisplayData { get; set; }

        /// <summary>
        /// Checks to see if the DisplayData property is set.
        /// </summary>
        internal bool IsSetDisplayData() => this.DisplayData != null;

        /// <summary>
        /// Gets and sets the property EntityId. 
        /// <para>
        /// The identifier of a user or group in your IAM Identity Center identity source. For
        /// example, a user ID could be an email.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 47)]
        public string EntityId { get; set; }

        /// <summary>
        /// Checks to see if the EntityId property is set.
        /// </summary>
        internal bool IsSetEntityId() => this.EntityId != null;

        /// <summary>
        /// Gets and sets the property EntityType. 
        /// <para>
        /// Shows the type as <c>User</c> or <c>Group</c>.
        /// </para>
        /// </summary>
        public EntityType EntityType { get; set; }

        /// <summary>
        /// Checks to see if the EntityType property is set.
        /// </summary>
        internal bool IsSetEntityType() => this.EntityType != null;
    }
}
