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
 * Do not modify this file. This file is generated from the securitylake-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityLake.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAwsLogSource operation.
    /// Adds a natively supported Amazon Web Service as an Amazon Security Lake source. Enables
    /// source types for member accounts in required Amazon Web Services Regions, based on
    /// the parameters you specify. You can choose any source type in any Region for either
    /// accounts that are part of a trusted organization or standalone accounts. Once you
    /// add an Amazon Web Service as a source, Security Lake starts collecting logs and events
    /// from it.
    /// 
    ///  
    /// <para>
    /// You can use this API only to enable natively supported Amazon Web Services as a source.
    /// Use <code>CreateCustomLogSource</code> to enable data collection from a custom source.
    /// </para>
    /// </summary>
    public partial class CreateAwsLogSourceRequest : AmazonSecurityLakeRequest
    {
        private List<AwsLogSourceConfiguration> _sources = new List<AwsLogSourceConfiguration>();

        /// <summary>
        /// Gets and sets the property Sources. 
        /// <para>
        /// Specify the natively-supported Amazon Web Services service to add as a source in Security
        /// Lake.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=50)]
        public List<AwsLogSourceConfiguration> Sources
        {
            get { return this._sources; }
            set { this._sources = value; }
        }

        // Check to see if Sources property is set
        internal bool IsSetSources()
        {
            return this._sources != null && this._sources.Count > 0; 
        }

    }
}