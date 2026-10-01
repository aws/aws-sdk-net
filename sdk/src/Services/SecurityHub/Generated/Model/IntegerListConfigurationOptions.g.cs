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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// The options for customizing a security control parameter that is a list of integers.
    /// </summary>
    public partial class IntegerListConfigurationOptions
    {
        /// <summary>
        /// Gets and sets the property DefaultValue. 
        /// <para>
        ///  The Security Hub CSPM default value for a control parameter that is a list of integers.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> DefaultValue { get; set; } = AWSConfigs.InitializeCollections ? new List<int>() : null;

        /// <summary>
        /// Checks to see if the DefaultValue property is set.
        /// </summary>
        internal bool IsSetDefaultValue() => this.DefaultValue != null && (this.DefaultValue.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Max. 
        /// <para>
        ///  The maximum valid value for a control parameter that is a list of integers. 
        /// </para>
        /// </summary>
        public int? Max { get; set; }

        /// <summary>
        /// Checks to see if the Max property is set.
        /// </summary>
        internal bool IsSetMax() => this.Max.HasValue;

        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        ///  The maximum number of list items that an interger list control parameter can accept.
        /// 
        /// </para>
        /// </summary>
        public int? MaxItems { get; set; }

        /// <summary>
        /// Checks to see if the MaxItems property is set.
        /// </summary>
        internal bool IsSetMaxItems() => this.MaxItems.HasValue;

        /// <summary>
        /// Gets and sets the property Min. 
        /// <para>
        ///  The minimum valid value for a control parameter that is a list of integers. 
        /// </para>
        /// </summary>
        public int? Min { get; set; }

        /// <summary>
        /// Checks to see if the Min property is set.
        /// </summary>
        internal bool IsSetMin() => this.Min.HasValue;
    }
}
