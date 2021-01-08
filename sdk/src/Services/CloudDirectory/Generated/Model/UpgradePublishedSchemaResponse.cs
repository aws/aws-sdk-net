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
 * Do not modify this file. This file is generated from the clouddirectory-2017-01-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudDirectory.Model
{
    /// <summary>
    /// This is the response object from the UpgradePublishedSchema operation.
    /// </summary>
    public partial class UpgradePublishedSchemaResponse : AmazonWebServiceResponse
    {
        private string _upgradedSchemaArn;

        /// <summary>
        /// Gets and sets the property UpgradedSchemaArn. 
        /// <para>
        /// The ARN of the upgraded schema that is returned as part of the response.
        /// </para>
        /// </summary>
        public string UpgradedSchemaArn
        {
            get { return this._upgradedSchemaArn; }
            set { this._upgradedSchemaArn = value; }
        }

        // Check to see if UpgradedSchemaArn property is set
        internal bool IsSetUpgradedSchemaArn()
        {
            return this._upgradedSchemaArn != null;
        }

    }
}