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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
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
namespace Amazon.Backup.Model
{
    /// <summary>
    /// Container for the parameters to the GetTieringConfiguration operation.
    /// Returns <c>TieringConfiguration</c> details for the specified <c>TieringConfigurationName</c>.
    /// The details are the body of a tiering configuration in JSON format, in addition to
    /// configuration metadata.
    /// </summary>
    public partial class GetTieringConfigurationRequest : AmazonBackupRequest
    {
        private string _tieringConfigurationName;

        /// <summary>
        /// Gets and sets the property TieringConfigurationName. 
        /// <para>
        /// The unique name of a tiering configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TieringConfigurationName
        {
            get { return this._tieringConfigurationName; }
            set { this._tieringConfigurationName = value; }
        }

        // Check to see if TieringConfigurationName property is set
        internal bool IsSetTieringConfigurationName()
        {
            return this._tieringConfigurationName != null;
        }

    }
}