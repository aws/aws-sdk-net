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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// This is the response object from the CreateDomainConfiguration operation.
    /// </summary>
    public partial class CreateDomainConfigurationResponse : AmazonWebServiceResponse
    {
        private string _domainConfigurationArn;
        private string _domainConfigurationName;

        /// <summary>
        /// Gets and sets the property DomainConfigurationArn. 
        /// <para>
        /// The ARN of the domain configuration.
        /// </para>
        /// </summary>
        public string DomainConfigurationArn
        {
            get { return this._domainConfigurationArn; }
            set { this._domainConfigurationArn = value; }
        }

        // Check to see if DomainConfigurationArn property is set
        internal bool IsSetDomainConfigurationArn()
        {
            return this._domainConfigurationArn != null;
        }

        /// <summary>
        /// Gets and sets the property DomainConfigurationName. 
        /// <para>
        /// The name of the domain configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string DomainConfigurationName
        {
            get { return this._domainConfigurationName; }
            set { this._domainConfigurationName = value; }
        }

        // Check to see if DomainConfigurationName property is set
        internal bool IsSetDomainConfigurationName()
        {
            return this._domainConfigurationName != null;
        }

    }
}