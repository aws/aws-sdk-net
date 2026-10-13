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

namespace Amazon.WorkMail.Model
{
    /// <summary>
    /// This is the response object from the GetImpersonationRole operation.
    /// </summary>
    public partial class GetImpersonationRoleResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property DateCreated. 
        /// <para>
        /// The date when the impersonation role was created.
        /// </para>
        /// </summary>
        public DateTime? DateCreated { get; set; }

        /// <summary>
        /// Checks to see if the DateCreated property is set.
        /// </summary>
        internal bool IsSetDateCreated() => this.DateCreated.HasValue;

        /// <summary>
        /// Gets and sets the property DateModified. 
        /// <para>
        /// The date when the impersonation role was last modified.
        /// </para>
        /// </summary>
        public DateTime? DateModified { get; set; }

        /// <summary>
        /// Checks to see if the DateModified property is set.
        /// </summary>
        internal bool IsSetDateModified() => this.DateModified.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The impersonation role description.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ImpersonationRoleId. 
        /// <para>
        /// The impersonation role ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ImpersonationRoleId { get; set; }

        /// <summary>
        /// Checks to see if the ImpersonationRoleId property is set.
        /// </summary>
        internal bool IsSetImpersonationRoleId() => this.ImpersonationRoleId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The impersonation role name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Rules. 
        /// <para>
        /// The list of rules for the given impersonation role.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<ImpersonationRule> Rules { get; set; } = AWSConfigs.InitializeCollections ? new List<ImpersonationRule>() : null;

        /// <summary>
        /// Checks to see if the Rules property is set.
        /// </summary>
        internal bool IsSetRules() => this.Rules != null && (this.Rules.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The impersonation role type.
        /// </para>
        /// </summary>
        public ImpersonationRoleType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
