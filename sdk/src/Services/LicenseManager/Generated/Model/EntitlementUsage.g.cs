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

namespace Amazon.LicenseManager.Model
{
    /// <summary>
    /// Usage associated with an entitlement resource.
    /// </summary>
    public partial class EntitlementUsage
    {
        /// <summary>
        /// Gets and sets the property ConsumedValue. 
        /// <para>
        /// Resource usage consumed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ConsumedValue { get; set; }

        /// <summary>
        /// Checks to see if the ConsumedValue property is set.
        /// </summary>
        internal bool IsSetConsumedValue() => this.ConsumedValue != null;

        /// <summary>
        /// Gets and sets the property MaxCount. 
        /// <para>
        /// Maximum entitlement usage count.
        /// </para>
        /// </summary>
        public string MaxCount { get; set; }

        /// <summary>
        /// Checks to see if the MaxCount property is set.
        /// </summary>
        internal bool IsSetMaxCount() => this.MaxCount != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Entitlement usage name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// Entitlement usage unit.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EntitlementDataUnit Unit { get; set; }

        /// <summary>
        /// Checks to see if the Unit property is set.
        /// </summary>
        internal bool IsSetUnit() => this.Unit != null;
    }
}
