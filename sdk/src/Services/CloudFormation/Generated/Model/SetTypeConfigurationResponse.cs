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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
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
namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// This is the response object from the SetTypeConfiguration operation.
    /// </summary>
    public partial class SetTypeConfigurationResponse : AmazonWebServiceResponse
    {
        private string _configurationArn;

        /// <summary>
        /// Gets and sets the property ConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the configuration data, in this account and Region.
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify <c>ConfigurationArn</c>, or <c>Type</c> and <c>TypeName</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string ConfigurationArn
        {
            get { return this._configurationArn; }
            set { this._configurationArn = value; }
        }

        // Check to see if ConfigurationArn property is set
        internal bool IsSetConfigurationArn()
        {
            return this._configurationArn != null;
        }

    }
}