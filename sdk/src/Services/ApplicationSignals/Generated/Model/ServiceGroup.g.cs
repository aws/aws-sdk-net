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

namespace Amazon.ApplicationSignals.Model
{
    /// <summary>
    /// A structure that represents a logical grouping of services based on shared attributes
    /// such as business unit, environment, or entry point.
    /// </summary>
    public partial class ServiceGroup
    {
        /// <summary>
        /// Gets and sets the property GroupIdentifier. 
        /// <para>
        /// A unique identifier for this grouping attribute value, used for filtering and API
        /// operations.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string GroupIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the GroupIdentifier property is set.
        /// </summary>
        internal bool IsSetGroupIdentifier() => this.GroupIdentifier != null;

        /// <summary>
        /// Gets and sets the property GroupName. 
        /// <para>
        /// The name of the grouping attribute, such as <c>BusinessUnit</c> or <c>Environment</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string GroupName { get; set; }

        /// <summary>
        /// Checks to see if the GroupName property is set.
        /// </summary>
        internal bool IsSetGroupName() => this.GroupName != null;

        /// <summary>
        /// Gets and sets the property GroupSource. 
        /// <para>
        /// The source of the grouping attribute, such as <c>TAG</c>, <c>OTEL</c>, or <c>DEFAULT</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string GroupSource { get; set; }

        /// <summary>
        /// Checks to see if the GroupSource property is set.
        /// </summary>
        internal bool IsSetGroupSource() => this.GroupSource != null;

        /// <summary>
        /// Gets and sets the property GroupValue. 
        /// <para>
        /// The value of the grouping attribute for this service, such as <c>Payments</c> or <c>Production</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string GroupValue { get; set; }

        /// <summary>
        /// Checks to see if the GroupValue property is set.
        /// </summary>
        internal bool IsSetGroupValue() => this.GroupValue != null;
    }
}
