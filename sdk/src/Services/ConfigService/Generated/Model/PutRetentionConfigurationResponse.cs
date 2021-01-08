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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// This is the response object from the PutRetentionConfiguration operation.
    /// </summary>
    public partial class PutRetentionConfigurationResponse : AmazonWebServiceResponse
    {
        private RetentionConfiguration _retentionConfiguration;

        /// <summary>
        /// Gets and sets the property RetentionConfiguration. 
        /// <para>
        /// Returns a retention configuration object.
        /// </para>
        /// </summary>
        public RetentionConfiguration RetentionConfiguration
        {
            get { return this._retentionConfiguration; }
            set { this._retentionConfiguration = value; }
        }

        // Check to see if RetentionConfiguration property is set
        internal bool IsSetRetentionConfiguration()
        {
            return this._retentionConfiguration != null;
        }

    }
}