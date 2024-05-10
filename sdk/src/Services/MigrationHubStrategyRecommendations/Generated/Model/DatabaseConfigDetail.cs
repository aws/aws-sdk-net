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
 * Do not modify this file. This file is generated from the migrationhubstrategy-2020-02-19.normal.json service model.
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
namespace Amazon.MigrationHubStrategyRecommendations.Model
{
    /// <summary>
    /// Configuration information used for assessing databases.
    /// </summary>
    public partial class DatabaseConfigDetail
    {
        private string _secretName;

        /// <summary>
        /// Gets and sets the property SecretName. 
        /// <para>
        ///  AWS Secrets Manager key that holds the credentials that you use to connect to a database.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string SecretName
        {
            get { return this._secretName; }
            set { this._secretName = value; }
        }

        // Check to see if SecretName property is set
        internal bool IsSetSecretName()
        {
            return this._secretName != null;
        }

    }
}