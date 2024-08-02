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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Indicates whether your instance is configured for hibernation. This parameter is valid
    /// only if the instance meets the <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/hibernating-prerequisites.html">hibernation
    /// prerequisites</a>. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Hibernate.html">Hibernate
    /// your Amazon EC2 instance</a> in the <i>Amazon EC2 User Guide</i>.
    /// </summary>
    public partial class HibernationOptionsRequest
    {
        private bool? _configured;

        /// <summary>
        /// Gets and sets the property Configured. 
        /// <para>
        /// Set to <c>true</c> to enable your instance for hibernation.
        /// </para>
        ///  
        /// <para>
        /// For Spot Instances, if you set <c>Configured</c> to <c>true</c>, either omit the <c>InstanceInterruptionBehavior</c>
        /// parameter (for <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_SpotMarketOptions.html">
        /// <c>SpotMarketOptions</c> </a>), or set it to <c>hibernate</c>. When <c>Configured</c>
        /// is true:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you omit <c>InstanceInterruptionBehavior</c>, it defaults to <c>hibernate</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you set <c>InstanceInterruptionBehavior</c> to a value other than <c>hibernate</c>,
        /// you'll get an error.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default: <c>false</c> 
        /// </para>
        /// </summary>
        public bool? Configured
        {
            get { return this._configured; }
            set { this._configured = value; }
        }

        // Check to see if Configured property is set
        internal bool IsSetConfigured()
        {
            return this._configured.HasValue; 
        }

    }
}