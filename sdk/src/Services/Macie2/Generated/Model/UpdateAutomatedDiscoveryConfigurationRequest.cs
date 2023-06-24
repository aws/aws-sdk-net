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

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateAutomatedDiscoveryConfiguration operation.
    /// Enables or disables automated sensitive data discovery for an account.
    /// </summary>
    public partial class UpdateAutomatedDiscoveryConfigurationRequest : AmazonMacie2Request
    {
        private AutomatedDiscoveryStatus _status;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The new status of automated sensitive data discovery for the account. Valid values
        /// are: ENABLED, start or resume automated sensitive data discovery activities for the
        /// account; and, DISABLED, stop performing automated sensitive data discovery activities
        /// for the account.
        /// </para>
        ///  
        /// <para>
        /// When you enable automated sensitive data discovery for the first time, Amazon Macie
        /// uses default configuration settings to determine which data sources to analyze and
        /// which managed data identifiers to use. To change these settings, use the UpdateClassificationScope
        /// and UpdateSensitivityInspectionTemplate operations, respectively. If you change the
        /// settings and subsequently disable the configuration, Amazon Macie retains your changes.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AutomatedDiscoveryStatus Status
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