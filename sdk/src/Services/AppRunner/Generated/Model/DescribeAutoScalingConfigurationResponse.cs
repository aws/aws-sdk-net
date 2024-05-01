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
 * Do not modify this file. This file is generated from the apprunner-2020-05-15.normal.json service model.
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
namespace Amazon.AppRunner.Model
{
    /// <summary>
    /// This is the response object from the DescribeAutoScalingConfiguration operation.
    /// </summary>
    public partial class DescribeAutoScalingConfigurationResponse : AmazonWebServiceResponse
    {
        private AutoScalingConfiguration _autoScalingConfiguration;

        /// <summary>
        /// Gets and sets the property AutoScalingConfiguration. 
        /// <para>
        /// A full description of the App Runner auto scaling configuration that you specified
        /// in this request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AutoScalingConfiguration AutoScalingConfiguration
        {
            get { return this._autoScalingConfiguration; }
            set { this._autoScalingConfiguration = value; }
        }

        // Check to see if AutoScalingConfiguration property is set
        internal bool IsSetAutoScalingConfiguration()
        {
            return this._autoScalingConfiguration != null;
        }

    }
}