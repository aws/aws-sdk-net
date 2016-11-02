/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// A list of configuration sets associated with your AWS account. Configuration sets
    /// enable you to publish email sending events. For information about using configuration
    /// sets, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/monitor-sending-activity.html">Amazon
    /// SES Developer Guide</a>.
    /// </summary>
    public partial class ListConfigurationSetsResponse : AmazonWebServiceResponse
    {
        private List<ConfigurationSet> _configurationSets = new List<ConfigurationSet>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ConfigurationSets. 
        /// <para>
        /// A list of configuration sets.
        /// </para>
        /// </summary>
        public List<ConfigurationSet> ConfigurationSets
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
        /// A token indicating that there are additional configuration sets available to be listed.
        /// Pass this token to successive calls of <code>ListConfigurationSets</code>. 
        /// </para>
        /// </summary>
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