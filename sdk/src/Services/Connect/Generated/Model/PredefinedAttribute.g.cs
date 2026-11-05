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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Information about a predefined attribute.
    /// </summary>
    public partial class PredefinedAttribute
    {
        /// <summary>
        /// Gets and sets the property AttributeConfiguration. 
        /// <para>
        /// Custom metadata that is associated to predefined attributes to control behavior in
        /// upstream services, such as controlling how a predefined attribute should be displayed
        /// in the Connect Customer admin website.
        /// </para>
        /// </summary>
        public PredefinedAttributeConfiguration AttributeConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AttributeConfiguration property is set.
        /// </summary>
        internal bool IsSetAttributeConfiguration() => this.AttributeConfiguration != null;

        /// <summary>
        /// Gets and sets the property LastModifiedRegion. 
        /// <para>
        /// Last modified region.
        /// </para>
        /// </summary>
        public string LastModifiedRegion { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedRegion property is set.
        /// </summary>
        internal bool IsSetLastModifiedRegion() => this.LastModifiedRegion != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// Last modified time.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the predefined attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Purposes. 
        /// <para>
        /// Values that enable you to categorize your predefined attributes. You can use them
        /// in custom UI elements across the Connect Customer admin website.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<string> Purposes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Purposes property is set.
        /// </summary>
        internal bool IsSetPurposes() => this.Purposes != null && (this.Purposes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// The values of the predefined attribute.
        /// </para>
        /// </summary>
        public PredefinedAttributeValues Values { get; set; }

        /// <summary>
        /// Checks to see if the Values property is set.
        /// </summary>
        internal bool IsSetValues() => this.Values != null;
    }
}
