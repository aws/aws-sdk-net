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
    /// Container for the parameters to the DeleteRemediationExceptions operation.
    /// Deletes one or more remediation exceptions mentioned in the resource keys.
    /// 
    ///  <note> 
    /// <para>
    /// AWS Config generates a remediation exception when a problem occurs executing a remediation
    /// action to a specific resource. Remediation exceptions blocks auto-remediation until
    /// the exception is cleared.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DeleteRemediationExceptionsRequest : AmazonConfigServiceRequest
    {
        private string _configRuleName;
        private List<RemediationExceptionResourceKey> _resourceKeys = new List<RemediationExceptionResourceKey>();

        /// <summary>
        /// Gets and sets the property ConfigRuleName. 
        /// <para>
        /// The name of the AWS Config rule for which you want to delete remediation exception
        /// configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ConfigRuleName
        {
            get { return this._configRuleName; }
            set { this._configRuleName = value; }
        }

        // Check to see if ConfigRuleName property is set
        internal bool IsSetConfigRuleName()
        {
            return this._configRuleName != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceKeys. 
        /// <para>
        /// An exception list of resource exception keys to be processed with the current request.
        /// AWS Config adds exception for each resource key. For example, AWS Config adds 3 exceptions
        /// for 3 resource keys. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<RemediationExceptionResourceKey> ResourceKeys
        {
            get { return this._resourceKeys; }
            set { this._resourceKeys = value; }
        }

        // Check to see if ResourceKeys property is set
        internal bool IsSetResourceKeys()
        {
            return this._resourceKeys != null && this._resourceKeys.Count > 0; 
        }

    }
}