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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// Container for the parameters to the CreateConfigurationSet operation. Creates a configuration
    /// set. <para> Configuration sets enable you to publish email sending events. For information
    /// about using configuration sets, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/monitor-sending-activity.html">Amazon
    /// SES Developer Guide</a>. </para> <para> You can execute this operation no more than
    /// once per second. </para>
    /// </summary>
    public partial class CreateConfigurationSetRequest : AmazonSimpleEmailServiceRequest
    {
        /// <summary>
        /// Gets and sets the property ConfigurationSet. 
        /// <para>
        /// A data structure that contains the name of the configuration set.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ConfigurationSet ConfigurationSet { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationSet property is set.
        /// </summary>
        internal bool IsSetConfigurationSet() => this.ConfigurationSet != null;
    }
}
