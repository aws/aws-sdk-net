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
 * Do not modify this file. This file is generated from the network-firewall-2020-11-12.normal.json service model.
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
namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// Additional settings for a stateful rule. This is part of the <a>StatefulRule</a> configuration.
    /// </summary>
    public partial class RuleOption
    {
        private string _keyword;
        private List<string> _settings = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Keyword. 
        /// <para>
        /// The keyword for the Suricata compatible rule option. You must include a <c>sid</c>
        /// (signature ID), and can optionally include other keywords. For information about Suricata
        /// compatible keywords, see <a href="https://suricata.readthedocs.io/en/suricata-7.0.3/rules/intro.html#rule-options">Rule
        /// options</a> in the Suricata documentation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Keyword
        {
            get { return this._keyword; }
            set { this._keyword = value; }
        }

        // Check to see if Keyword property is set
        internal bool IsSetKeyword()
        {
            return this._keyword != null;
        }

        /// <summary>
        /// Gets and sets the property Settings. 
        /// <para>
        /// The settings of the Suricata compatible rule option. Rule options have zero or more
        /// setting values, and the number of possible and required settings depends on the <c>Keyword</c>.
        /// For more information about the settings for specific options, see <a href="https://suricata.readthedocs.io/en/suricata-7.0.3/rules/intro.html#rule-options">Rule
        /// options</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Settings
        {
            get { return this._settings; }
            set { this._settings = value; }
        }

        // Check to see if Settings property is set
        internal bool IsSetSettings()
        {
            return this._settings != null && (this._settings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}