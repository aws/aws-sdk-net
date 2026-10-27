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

namespace Amazon.Resiliencehubv2.Model
{
    /// <summary>
    /// Represents a system associated with a service.
    /// </summary>
    public partial class AssociatedSystem
    {
        /// <summary>
        /// Gets and sets the property SystemArn.
        /// </summary>
        [AWSProperty(Required = true, Min = 31)]
        public string SystemArn { get; set; }

        /// <summary>
        /// Checks to see if the SystemArn property is set.
        /// </summary>
        internal bool IsSetSystemArn() => this.SystemArn != null;

        /// <summary>
        /// Gets and sets the property SystemName.
        /// </summary>
        [AWSProperty(Min = 2, Max = 60)]
        public string SystemName { get; set; }

        /// <summary>
        /// Checks to see if the SystemName property is set.
        /// </summary>
        internal bool IsSetSystemName() => this.SystemName != null;

        /// <summary>
        /// Gets and sets the property UserJourneyIds. 
        /// <para>
        /// The list of user journey identifiers that associate this system with the service.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 20)]
        public List<string> UserJourneyIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the UserJourneyIds property is set.
        /// </summary>
        internal bool IsSetUserJourneyIds() => this.UserJourneyIds != null && (this.UserJourneyIds.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
