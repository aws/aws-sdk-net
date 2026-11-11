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

namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// Represents information about each property specified in the action configuration,
    /// such as the description and key name that display for the customer using the action
    /// type.
    /// </summary>
    public partial class ActionTypeProperty
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the property that is displayed to users.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 250)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// Whether the configuration property is a key.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? Key { get; set; }

        /// <summary>
        /// Checks to see if the Key property is set.
        /// </summary>
        internal bool IsSetKey() => this.Key.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The property name that is displayed to users.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 50)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NoEcho. 
        /// <para>
        /// Whether to omit the field value entered by the customer in the log. If <c>true</c>,
        /// the value is not saved in CloudTrail logs for the action execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? NoEcho { get; set; }

        /// <summary>
        /// Checks to see if the NoEcho property is set.
        /// </summary>
        internal bool IsSetNoEcho() => this.NoEcho.HasValue;

        /// <summary>
        /// Gets and sets the property Optional. 
        /// <para>
        /// Whether the configuration property is an optional value.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? Optional { get; set; }

        /// <summary>
        /// Checks to see if the Optional property is set.
        /// </summary>
        internal bool IsSetOptional() => this.Optional.HasValue;

        /// <summary>
        /// Gets and sets the property Queryable. 
        /// <para>
        /// Indicates that the property is used with polling. An action type can have up to one
        /// queryable property. If it has one, that property must be both required and not secret.
        /// </para>
        /// </summary>
        public bool? Queryable { get; set; }

        /// <summary>
        /// Checks to see if the Queryable property is set.
        /// </summary>
        internal bool IsSetQueryable() => this.Queryable.HasValue;
    }
}
