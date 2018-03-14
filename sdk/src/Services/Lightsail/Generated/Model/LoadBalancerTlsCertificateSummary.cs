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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Provides a summary of SSL/TLS certificate metadata.
    /// </summary>
    public partial class LoadBalancerTlsCertificateSummary
    {
        private bool? _isAttached;
        private string _name;

        /// <summary>
        /// Gets and sets the property IsAttached. 
        /// <para>
        /// When <code>true</code>, the SSL/TLS certificate is attached to the Lightsail load
        /// balancer.
        /// </para>
        /// </summary>
        public bool IsAttached
        {
            get { return this._isAttached.GetValueOrDefault(); }
            set { this._isAttached = value; }
        }

        // Check to see if IsAttached property is set
        internal bool IsSetIsAttached()
        {
            return this._isAttached.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the SSL/TLS certificate.
        /// </para>
        /// </summary>
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

    }
}