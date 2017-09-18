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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeConfigurationSet operation.
    /// Returns the details of the specified configuration set. For information about using
    /// configuration sets, see the <i> <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/monitor-sending-activity.html">Amazon
    /// SES Developer Guide</a>.</i> 
    /// 
    ///  
    /// <para>
    /// You can execute this operation no more than once per second.
    /// </para>
    /// </summary>
    public partial class DescribeConfigurationSetRequest : AmazonSimpleEmailServiceRequest
    {
        private List<string> _configurationSetAttributeNames = new List<string>();
        private string _configurationSetName;

        /// <summary>
        /// Gets and sets the property ConfigurationSetAttributeNames. 
        /// <para>
        /// A list of configuration set attributes to return.
        /// </para>
        /// </summary>
        public List<string> ConfigurationSetAttributeNames
        {
            get { return this._configurationSetAttributeNames; }
            set { this._configurationSetAttributeNames = value; }
        }

        // Check to see if ConfigurationSetAttributeNames property is set
        internal bool IsSetConfigurationSetAttributeNames()
        {
            return this._configurationSetAttributeNames != null && this._configurationSetAttributeNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ConfigurationSetName. 
        /// <para>
        /// The name of the configuration set to describe.
        /// </para>
        /// </summary>
        public string ConfigurationSetName
        {
            get { return this._configurationSetName; }
            set { this._configurationSetName = value; }
        }

        // Check to see if ConfigurationSetName property is set
        internal bool IsSetConfigurationSetName()
        {
            return this._configurationSetName != null;
        }

    }
}