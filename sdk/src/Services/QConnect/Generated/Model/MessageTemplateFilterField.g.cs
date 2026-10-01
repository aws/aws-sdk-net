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

namespace Amazon.QConnect.Model
{
    /// <summary>
    /// The message template fields to filter the message template query results by. The following
    /// is the list of supported field names:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// name
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// description
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// channel
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// channelSubtype
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// language
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// qualifier
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// createdTime
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// lastModifiedTime
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// lastModifiedBy
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// groupingConfiguration.criteria
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// groupingConfiguration.values
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class MessageTemplateFilterField
    {
        /// <summary>
        /// Gets and sets the property IncludeNoExistence. 
        /// <para>
        /// Whether to treat null value as a match for the attribute field.
        /// </para>
        /// </summary>
        public bool? IncludeNoExistence { get; set; }

        /// <summary>
        /// Checks to see if the IncludeNoExistence property is set.
        /// </summary>
        internal bool IsSetIncludeNoExistence() => this.IncludeNoExistence.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the attribute field to filter the message templates by.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 4096)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Operator. 
        /// <para>
        /// The operator to use for filtering.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MessageTemplateFilterOperator Operator { get; set; }

        /// <summary>
        /// Checks to see if the Operator property is set.
        /// </summary>
        internal bool IsSetOperator() => this.Operator != null;

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// The values of attribute field to filter the message template by.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public List<string> Values { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Values property is set.
        /// </summary>
        internal bool IsSetValues() => this.Values != null && (this.Values.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
