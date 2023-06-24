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

namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// This is the response object from the DescribeConfigurationSets operation.
    /// </summary>
    public partial class DescribeConfigurationSetsResponse : AmazonWebServiceResponse
    {
        private List<ConfigurationSetInformation> _configurationSets = new List<ConfigurationSetInformation>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ConfigurationSets. 
        /// <para>
        /// An array of ConfigurationSets objects.
        /// </para>
        /// </summary>
        public List<ConfigurationSetInformation> ConfigurationSets
        {
            get { return this._configurationSets; }
            set { this._configurationSets = value; }
        }

        // Check to see if ConfigurationSets property is set
        internal bool IsSetConfigurationSets()
        {
            return this._configurationSets != null && this._configurationSets.Count > 0; 
        }

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

    }
}