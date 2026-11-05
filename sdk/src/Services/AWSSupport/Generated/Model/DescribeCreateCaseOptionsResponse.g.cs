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

namespace Amazon.AWSSupport.Model
{
    /// <summary>
    /// This is the response object from the DescribeCreateCaseOptions operation.
    /// </summary>
    public partial class DescribeCreateCaseOptionsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CommunicationTypes. 
        /// <para>
        ///  A JSON-formatted array that contains the available communication type options, along
        /// with the available support timeframes for the given inputs. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<CommunicationTypeOptions> CommunicationTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<CommunicationTypeOptions>() : null;

        /// <summary>
        /// Checks to see if the CommunicationTypes property is set.
        /// </summary>
        internal bool IsSetCommunicationTypes() => this.CommunicationTypes != null && (this.CommunicationTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LanguageAvailability. 
        /// <para>
        /// Language availability can be any of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  available 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  best_effort 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  unavailable 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public string LanguageAvailability { get; set; }

        /// <summary>
        /// Checks to see if the LanguageAvailability property is set.
        /// </summary>
        internal bool IsSetLanguageAvailability() => this.LanguageAvailability != null;
    }
}
