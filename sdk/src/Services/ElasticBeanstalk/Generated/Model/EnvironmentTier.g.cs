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

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Describes the properties of an environment tier
    /// </summary>
    public partial class EnvironmentTier
    {
        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of this environment tier.
        /// </para>
        ///  
        /// <para>
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For <i>Standard-mode EC2-based web server</i> – <c>WebServer</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <i>Standard-mode EC2-based backend application with Amazon SQS</i> – <c>Worker</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <i>Cluster-mode Amazon EKS-based applications</i> – <c>Cluster</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of this environment tier.
        /// </para>
        ///  
        /// <para>
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For <i>Web server tier</i> – <c>Standard</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <i>Worker tier</i> – <c>SQS/HTTP</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <i>Cluster tier</i> – <c>EKS</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of this environment tier. When you don't set a value to it, Elastic Beanstalk
        /// uses the latest compatible worker tier version.
        /// </para>
        ///  <note> 
        /// <para>
        /// This member is deprecated. Any specific version that you set may become out of date.
        /// We recommend leaving it unspecified.
        /// </para>
        ///  </note>
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
