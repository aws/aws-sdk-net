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

namespace Amazon.FMS.Model
{
    /// <summary>
    /// Details of the Firewall Manager protocols list.
    /// </summary>
    public partial class ProtocolsListDataSummary
    {
        /// <summary>
        /// Gets and sets the property ListArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the specified protocols list.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string ListArn { get; set; }

        /// <summary>
        /// Checks to see if the ListArn property is set.
        /// </summary>
        internal bool IsSetListArn() => this.ListArn != null;

        /// <summary>
        /// Gets and sets the property ListId. 
        /// <para>
        /// The ID of the specified protocols list.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string ListId { get; set; }

        /// <summary>
        /// Checks to see if the ListId property is set.
        /// </summary>
        internal bool IsSetListId() => this.ListId != null;

        /// <summary>
        /// Gets and sets the property ListName. 
        /// <para>
        /// The name of the specified protocols list.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ListName { get; set; }

        /// <summary>
        /// Checks to see if the ListName property is set.
        /// </summary>
        internal bool IsSetListName() => this.ListName != null;

        /// <summary>
        /// Gets and sets the property ProtocolsList. 
        /// <para>
        /// An array of protocols in the Firewall Manager protocols list.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ProtocolsList { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ProtocolsList property is set.
        /// </summary>
        internal bool IsSetProtocolsList() => this.ProtocolsList != null && (this.ProtocolsList.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
