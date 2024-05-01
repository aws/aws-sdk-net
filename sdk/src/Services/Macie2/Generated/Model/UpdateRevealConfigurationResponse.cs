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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
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
namespace Amazon.Macie2.Model
{
    /// <summary>
    /// This is the response object from the UpdateRevealConfiguration operation.
    /// </summary>
    public partial class UpdateRevealConfigurationResponse : AmazonWebServiceResponse
    {
        private RevealConfiguration _configuration;
        private RetrievalConfiguration _retrievalConfiguration;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The KMS key to use to encrypt the sensitive data, and the status of the configuration
        /// for the Amazon Macie account.
        /// </para>
        /// </summary>
        public RevealConfiguration Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property RetrievalConfiguration. 
        /// <para>
        /// The access method and settings to use when retrieving the sensitive data.
        /// </para>
        /// </summary>
        public RetrievalConfiguration RetrievalConfiguration
        {
            get { return this._retrievalConfiguration; }
            set { this._retrievalConfiguration = value; }
        }

        // Check to see if RetrievalConfiguration property is set
        internal bool IsSetRetrievalConfiguration()
        {
            return this._retrievalConfiguration != null;
        }

    }
}