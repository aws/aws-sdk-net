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
    /// The representation of a resource.
    /// </summary>
    public partial class Resource
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Resource description.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 64)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DisabledDate. 
        /// <para>
        /// The date indicating when the resource was disabled from WorkMail use.
        /// </para>
        /// </summary>
        public DateTime? DisabledDate { get; set; }

        /// <summary>
        /// Checks to see if the DisabledDate property is set.
        /// </summary>
        internal bool IsSetDisabledDate() => this.DisabledDate.HasValue;

        /// <summary>
        /// Gets and sets the property Email. 
        /// <para>
        /// The email of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 254)]
        public string Email { get; set; }

        /// <summary>
        /// Checks to see if the Email property is set.
        /// </summary>
        internal bool IsSetEmail() => this.Email != null;

        /// <summary>
        /// Gets and sets the property EnabledDate. 
        /// <para>
        /// The date indicating when the resource was enabled for WorkMail use.
        /// </para>
        /// </summary>
        public DateTime? EnabledDate { get; set; }

        /// <summary>
        /// Checks to see if the EnabledDate property is set.
        /// </summary>
        internal bool IsSetEnabledDate() => this.EnabledDate.HasValue;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 256)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the resource, which can be ENABLED, DISABLED, or DELETED.
        /// </para>
        /// </summary>
        public EntityState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the resource: equipment or room.
        /// </para>
        /// </summary>
        public ResourceType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
