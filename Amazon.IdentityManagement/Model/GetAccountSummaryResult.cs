/*
 * Copyright 2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>Get Account Summary Result
    /// </summary>
    public class GetAccountSummaryResult  
    {
        
        private Dictionary<string,int> summaryMap = new Dictionary<string,int>();
        public Dictionary<string,int> SummaryMap
        {
            get { return this.summaryMap; }
            set { this.summaryMap = value; }
        }

        /// <summary>
        /// Adds the KeyValuePairs to the SummaryMap dictionary.
        /// </summary>
        /// <param name="pairs">The pairs to be added to the SummaryMap dictionary.</param>
        /// <returns>this instance</returns>
        public GetAccountSummaryResult WithSummaryMap(params KeyValuePair<string, int>[] pairs)
        {
            foreach (KeyValuePair<string, int> pair in pairs)
            {
                this.SummaryMap[pair.Key] = pair.Value;
            }

            return this;
        }
        // Check to see if SummaryMap property is set
        internal bool IsSetSummaryMap()
        {
            return this.summaryMap != null;         
        }
    }
}
