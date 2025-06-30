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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteConfigRule operation.
    /// Deletes the specified Config rule and all of its evaluation results.
    /// 
    ///  
    /// <para>
    /// Config sets the state of a rule to <c>DELETING</c> until the deletion is complete.
    /// You cannot update a rule while it is in this state. If you make a <c>PutConfigRule</c>
    /// or <c>DeleteConfigRule</c> request for the rule, you will receive a <c>ResourceInUseException</c>.
    /// </para>
    ///  
    /// <para>
    /// You can check the state of a rule by using the <c>DescribeConfigRules</c> request.
    /// </para>
    ///  <note> 
    /// <para>
    ///  <b>Recommendation: Stop recording resource compliance before deleting rules</b> 
    /// </para>
    ///  
    /// <para>
    /// It is highly recommended that you stop recording for the <c>AWS::Config::ResourceCompliance</c>
    /// resource type before you delete rules in your account. Deleting rules creates CIs
    /// for <c>AWS::Config::ResourceCompliance</c> and can affect your Config <a href="https://docs.aws.amazon.com/config/latest/developerguide/stop-start-recorder.html">configuration
    /// recorder</a> costs. If you are deleting rules which evaluate a large number of resource
    /// types, this can lead to a spike in the number of CIs recorded.
    /// </para>
    ///  
    /// <para>
    /// Best practice:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Stop recording <c>AWS::Config::ResourceCompliance</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Delete rule(s)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Turn on recording for <c>AWS::Config::ResourceCompliance</c> 
    /// </para>
    ///  </li> </ol> </note>
    /// </summary>
    public partial class DeleteConfigRuleRequest : AmazonConfigServiceRequest
    {
        private string _configRuleName;

        /// <summary>
        /// Gets and sets the property ConfigRuleName. 
        /// <para>
        /// The name of the Config rule that you want to delete.
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

    }
}