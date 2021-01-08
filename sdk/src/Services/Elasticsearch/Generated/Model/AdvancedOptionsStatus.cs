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
 * Do not modify this file. This file is generated from the es-2015-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Elasticsearch.Model
{
    /// <summary>
    /// Status of the advanced options for the specified Elasticsearch domain. Currently,
    /// the following advanced options are available:
    /// 
    ///  <ul> <li>Option to allow references to indices in an HTTP request body. Must be <code>false</code>
    /// when configuring access to individual sub-resources. By default, the value is <code>true</code>.
    /// See <a href="http://docs.aws.amazon.com/elasticsearch-service/latest/developerguide/es-createupdatedomains.html#es-createdomain-configure-advanced-options"
    /// target="_blank">Configuration Advanced Options</a> for more information.</li> <li>Option
    /// to specify the percentage of heap space that is allocated to field data. By default,
    /// this setting is unbounded.</li> </ul> 
    /// <para>
    /// For more information, see <a href="http://docs.aws.amazon.com/elasticsearch-service/latest/developerguide/es-createupdatedomains.html#es-createdomain-configure-advanced-options">Configuring
    /// Advanced Options</a>.
    /// </para>
    /// </summary>
    public partial class AdvancedOptionsStatus
    {
        private Dictionary<string, string> _options = new Dictionary<string, string>();
        private OptionStatus _status;

        /// <summary>
        /// Gets and sets the property Options. 
        /// <para>
        ///  Specifies the status of advanced options for the specified Elasticsearch domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, string> Options
        {
            get { return this._options; }
            set { this._options = value; }
        }

        // Check to see if Options property is set
        internal bool IsSetOptions()
        {
            return this._options != null && this._options.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  Specifies the status of <code>OptionStatus</code> for advanced options for the specified
        /// Elasticsearch domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OptionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}