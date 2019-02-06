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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Indicates whether your instance is configured for hibernation. This parameter is valid
    /// only if the instance meets the <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Hibernate.html#hibernating-prerequisites">hibernation
    /// prerequisites</a>. Hibernation is currently supported only for Amazon Linux. For more
    /// information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Hibernate.html">Hibernate
    /// Your Instance</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// </summary>
    public partial class HibernationOptions
    {
        private bool? _configured;

        /// <summary>
        /// Gets and sets the property Configured. 
        /// <para>
        /// If this parameter is set to <code>true</code>, your instance is enabled for hibernation;
        /// otherwise, it is not enabled for hibernation.
        /// </para>
        /// </summary>
        public bool Configured
        {
            get { return this._configured.GetValueOrDefault(); }
            set { this._configured = value; }
        }

        // Check to see if Configured property is set
        internal bool IsSetConfigured()
        {
            return this._configured.HasValue; 
        }

    }
}