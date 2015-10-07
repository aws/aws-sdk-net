/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteConfigRule operation.
    /// Deletes the specified AWS Config rule and all of its evaluation results.
    /// 
    ///  
    /// <para>
    /// AWS Config sets the state of a rule to <code>DELETING</code> until the deletion is
    /// complete. You cannot update a rule while it is in this state. If you make a <code>PutConfigRule</code>
    /// request for the rule, you will receive a <code>ResourceInUseException</code>.
    /// </para>
    ///  
    /// <para>
    /// You can check the state of a rule by using the <code>DescribeConfigRules</code> request.
    /// </para>
    /// </summary>
    public partial class DeleteConfigRuleRequest : AmazonConfigServiceRequest
    {
        private string _configRuleName;

        /// <summary>
        /// Gets and sets the property ConfigRuleName. 
        /// <para>
        /// The name of the AWS Config rule that you want to delete.
        /// </para>
        /// </summary>
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