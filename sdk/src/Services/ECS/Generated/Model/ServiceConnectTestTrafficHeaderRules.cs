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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
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
namespace Amazon.ECS.Model
{
    /// <summary>
    /// The HTTP header rules used to identify and route test traffic during Amazon ECS blue/green
    /// deployments. These rules specify which HTTP headers to examine and what values to
    /// match for routing decisions.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/service-connect-blue-green.html">Service
    /// Connect for Amazon ECS blue/green deployments</a> in the <i> Amazon Elastic Container
    /// Service Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class ServiceConnectTestTrafficHeaderRules
    {
        private string _name;
        private ServiceConnectTestTrafficHeaderMatchRules _value;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the HTTP header to examine for test traffic routing. Common examples include
        /// custom headers like <c>X-Test-Version</c> or <c>X-Canary-Request</c> that can be used
        /// to identify test traffic.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The header value matching configuration that determines how the HTTP header value
        /// is evaluated for test traffic routing decisions.
        /// </para>
        /// </summary>
        public ServiceConnectTestTrafficHeaderMatchRules Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}