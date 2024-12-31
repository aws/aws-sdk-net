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
    /// Container for the parameters to the DeleteConfigurationRecorder operation.
    /// Deletes the customer managed configuration recorder.
    /// 
    ///  
    /// <para>
    /// This operation does not delete the configuration information that was previously recorded.
    /// You will be able to access the previously recorded information by using the <a href="https://docs.aws.amazon.com/config/latest/APIReference/API_GetResourceConfigHistory.html">GetResourceConfigHistory</a>
    /// operation, but you will not be able to access this information in the Config console
    /// until you have created a new customer managed configuration recorder.
    /// </para>
    /// </summary>
    public partial class DeleteConfigurationRecorderRequest : AmazonConfigServiceRequest
    {
        private string _configurationRecorderName;

        /// <summary>
        /// Gets and sets the property ConfigurationRecorderName. 
        /// <para>
        /// The name of the customer managed configuration recorder that you want to delete. You
        /// can retrieve the name of your configuration recorders by using the <a href="https://docs.aws.amazon.com/config/latest/APIReference/API_DescribeConfigurationRecorders.html">DescribeConfigurationRecorders</a>
        /// operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ConfigurationRecorderName
        {
            get { return this._configurationRecorderName; }
            set { this._configurationRecorderName = value; }
        }

        // Check to see if ConfigurationRecorderName property is set
        internal bool IsSetConfigurationRecorderName()
        {
            return this._configurationRecorderName != null;
        }

    }
}