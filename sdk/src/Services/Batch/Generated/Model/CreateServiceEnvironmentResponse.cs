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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
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
namespace Amazon.Batch.Model
{
    /// <summary>
    /// This is the response object from the CreateServiceEnvironment operation.
    /// </summary>
    public partial class CreateServiceEnvironmentResponse : AmazonWebServiceResponse
    {
        private string _serviceEnvironmentArn;
        private string _serviceEnvironmentName;

        /// <summary>
        /// Gets and sets the property ServiceEnvironmentArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the service environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ServiceEnvironmentArn
        {
            get { return this._serviceEnvironmentArn; }
            set { this._serviceEnvironmentArn = value; }
        }

        // Check to see if ServiceEnvironmentArn property is set
        internal bool IsSetServiceEnvironmentArn()
        {
            return this._serviceEnvironmentArn != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceEnvironmentName. 
        /// <para>
        /// The name of the service environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ServiceEnvironmentName
        {
            get { return this._serviceEnvironmentName; }
            set { this._serviceEnvironmentName = value; }
        }

        // Check to see if ServiceEnvironmentName property is set
        internal bool IsSetServiceEnvironmentName()
        {
            return this._serviceEnvironmentName != null;
        }

    }
}