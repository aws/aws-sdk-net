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
 * Do not modify this file. This file is generated from the support-2013-04-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AWSSupport.Model
{
    /// <summary>
    /// This is the response object from the DescribeCreateCaseOptions operation.
    /// </summary>
    public partial class DescribeCreateCaseOptionsResponse : AmazonWebServiceResponse
    {
        private List<CommunicationTypeOptions> _communicationTypes = new List<CommunicationTypeOptions>();
        private string _languageAvailability;

        /// <summary>
        /// Gets and sets the property CommunicationTypes. 
        /// <para>
        ///  A JSON-formatted array that contains the available communication type options, along
        /// with the available support timeframes for the given inputs. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<CommunicationTypeOptions> CommunicationTypes
        {
            get { return this._communicationTypes; }
            set { this._communicationTypes = value; }
        }

        // Check to see if CommunicationTypes property is set
        internal bool IsSetCommunicationTypes()
        {
            return this._communicationTypes != null && this._communicationTypes.Count > 0; 
        }

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
        [AWSProperty(Min=0, Max=100)]
        public string LanguageAvailability
        {
            get { return this._languageAvailability; }
            set { this._languageAvailability = value; }
        }

        // Check to see if LanguageAvailability property is set
        internal bool IsSetLanguageAvailability()
        {
            return this._languageAvailability != null;
        }

    }
}