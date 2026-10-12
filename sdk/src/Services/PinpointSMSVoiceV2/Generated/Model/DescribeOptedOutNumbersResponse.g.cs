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

namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// This is the response object from the DescribeOptedOutNumbers operation.
    /// </summary>
    public partial class DescribeOptedOutNumbersResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to be used for the next set of paginated results. If this field is empty
        /// then there are no more results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property OptOutListArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the OptOutList.
        /// </para>
        /// </summary>
        public string OptOutListArn { get; set; }

        /// <summary>
        /// Checks to see if the OptOutListArn property is set.
        /// </summary>
        internal bool IsSetOptOutListArn() => this.OptOutListArn != null;

        /// <summary>
        /// Gets and sets the property OptOutListName. 
        /// <para>
        /// The name of the OptOutList.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string OptOutListName { get; set; }

        /// <summary>
        /// Checks to see if the OptOutListName property is set.
        /// </summary>
        internal bool IsSetOptOutListName() => this.OptOutListName != null;

        /// <summary>
        /// Gets and sets the property OptedOutNumbers. 
        /// <para>
        /// An array of OptedOutNumbersInformation objects that provide information about the
        /// requested OptedOutNumbers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<OptedOutNumberInformation> OptedOutNumbers { get; set; } = AWSConfigs.InitializeCollections ? new List<OptedOutNumberInformation>() : null;

        /// <summary>
        /// Checks to see if the OptedOutNumbers property is set.
        /// </summary>
        internal bool IsSetOptedOutNumbers() => this.OptedOutNumbers != null && (this.OptedOutNumbers.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
