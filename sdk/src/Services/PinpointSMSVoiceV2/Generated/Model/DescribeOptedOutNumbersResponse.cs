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
 * Do not modify this file. This file is generated from the pinpoint-sms-voice-v2-2022-03-31.normal.json service model.
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
        private string _nextToken;
        private List<OptedOutNumberInformation> _optedOutNumbers = AWSConfigs.InitializeCollections ? new List<OptedOutNumberInformation>() : null;
        private string _optOutListArn;
        private string _optOutListName;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to be used for the next set of paginated results. If this field is empty
        /// then there are no more results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property OptedOutNumbers. 
        /// <para>
        /// An array of OptedOutNumbersInformation objects that provide information about the
        /// requested OptedOutNumbers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<OptedOutNumberInformation> OptedOutNumbers
        {
            get { return this._optedOutNumbers; }
            set { this._optedOutNumbers = value; }
        }

        // Check to see if OptedOutNumbers property is set
        internal bool IsSetOptedOutNumbers()
        {
            return this._optedOutNumbers != null && (this._optedOutNumbers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OptOutListArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the OptOutList.
        /// </para>
        /// </summary>
        public string OptOutListArn
        {
            get { return this._optOutListArn; }
            set { this._optOutListArn = value; }
        }

        // Check to see if OptOutListArn property is set
        internal bool IsSetOptOutListArn()
        {
            return this._optOutListArn != null;
        }

        /// <summary>
        /// Gets and sets the property OptOutListName. 
        /// <para>
        /// The name of the OptOutList.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string OptOutListName
        {
            get { return this._optOutListName; }
            set { this._optOutListName = value; }
        }

        // Check to see if OptOutListName property is set
        internal bool IsSetOptOutListName()
        {
            return this._optOutListName != null;
        }

    }
}